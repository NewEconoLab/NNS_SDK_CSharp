using System;
using System.Collections.Generic;
using System.Text;
using NEL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static NEL.neoHelper;

namespace NNS_SDK_CSharp
{
    public class NNS_register_sell
    {
        contractOperate cop;
        public NNS_register_sell(neoAddress neoAddressIn, string contractHashIn, string nelApiUrlIn)
        {
            cop = new contractOperate(neoAddressIn, contractHashIn, nelApiUrlIn);
        }

        DateTime startTime = TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1, 8, 0, 0), TimeZoneInfo.Local); // 当地时区

        class AuctionState
        {
            public string id; //拍卖id,就是拍卖生成的auctionid
            public string auctionStarter;//域名开拍的人

            public string parenthash;//拍卖内容
            public string domain;//拍卖内容
            public DateTime domainTTL;//域名的TTL,用这个信息来判断域名是否发生了变化
            public Int64 startBlockSelling;//开始销售块
            public double day;//第几天
            //public int StartTime 算出
            //step2time //算出
            //rantime //算出
            //endtime //算出
            //最终领取时间 算出,如果超出最终领取时间没有领域名,就不让领了
            //public BigInteger startBlockRan;//当第一个在rantime~endtime之后出价的人,记录他出价的块
            //这个变量移除,改为运算更少的随机块决定方式
            //从这个块开始,往后的每一个块出价都有一定几率直接结束
            public Int64 endBlock;//结束块
            public decimal maxPrice;//最高出价
            public string maxBuyer;//最大出价者
            public Int64 lastBlock;//最后出价块
        }

        public decimal getCGASbanlance(string cgasHash,string addr)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)balanceOf',
	                    [
                            '(addr){0}'
	                    ]
                    ]", addr));

            JObject result = cop.nelApi.invokeScript(neoHelper.Jarray2script(cgasHash, inputJA));
            string banlance = (string)result["result"][0]["stack"][0]["value"];

            return banlance.Hexstring2Decimal(8);
        }

        public decimal getBalanceOf(string addr)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)balanceOf',
	                    [
                            '(addr){0}'
	                    ]
                    ]", addr));

            JObject result = cop.nelApi.invokeScript(neoHelper.Jarray2script(cop.contractHash, inputJA));
            string banlance = (string)result["result"][0]["stack"][0]["value"];

            return banlance.Hexstring2Decimal(8);
        }

        public string getAuctionStateByFullDomain(string domain,int minuteOfDay = 1440)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)getAuctionStateByFullhash',
	                    [
		                    '(hex256){0}'
	                    ]
                    ]", domain.getNamehashForInvoke()));

            JObject result = cop.nelApi.invokeScript(neoHelper.Jarray2script(cop.contractHash, inputJA));
            JArray stackJA = (JArray)result["result"][0]["stack"][0]["value"];

            AuctionState AS = new AuctionState();
            AS.id = ((string)stackJA[0]["value"]).HexstringReverse();
            if (AS.id != "")
            {
                AS.auctionStarter = ThinNeo.Helper_NEO.GetAddress_FromScriptHash(((string)stackJA[1]["value"]).Hexstring2Bytes());
                AS.parenthash = (string)stackJA[2]["value"];
                AS.domain = ((string)stackJA[3]["value"]).Hexstring2String();
                AS.domainTTL = startTime.AddSeconds((double)((string)stackJA[4]["value"]).Hexstring2Decimal(0));
                AS.startBlockSelling = (Int64)stackJA[5]["value"];

                DateTime start = startTime.AddSeconds(cop.nelApi.getBlockTimeStamp(AS.startBlockSelling));

                //按设置换算天数，默认24小数*60.test为5
                AS.day = ((DateTime.Now - start).TotalMinutes) / minuteOfDay;

                try { AS.endBlock = (Int64)stackJA[6]["value"]; }
                catch { AS.endBlock = 0; }
                try { AS.maxPrice = (decimal)((int)stackJA[7]["value"] / Math.Pow(10, 8)); }
                catch { AS.maxPrice = 0; }
                try { AS.maxBuyer = ThinNeo.Helper_NEO.GetAddress_FromScriptHash(((string)stackJA[8]["value"]).Hexstring2Bytes()); }
                catch { AS.maxBuyer = ""; }
                try { AS.lastBlock = (Int64)stackJA[9]["value"]; }
                catch { AS.lastBlock = 0; }
            }

            string ASstr = JsonConvert.SerializeObject(AS);
            ASstr = JObject.Parse(ASstr).ToString();

            return ASstr;
        }

        public decimal getBalanceOfBid(string addr, string domain)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)balanceOfBid',
	                    [
		                    '(addr){0}',
                            '(hex256){1}'
	                    ]
                    ]",addr, (string)JObject.Parse(getAuctionStateByFullDomain(domain))["id"]));

            JObject result = cop.nelApi.invokeScript(neoHelper.Jarray2script(cop.contractHash, inputJA));
            string hex = (string)result["result"][0]["stack"][0]["value"];

            decimal decV = 0;
            try { decV = hex.Hexstring2Decimal(8); }
            catch { }

            return decV;
        }

        public string getDomainUseState(string domain)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)getDomainUseState',
	                    [
		                    '(hex256){0}'
	                    ]
                    ]", domain.getNamehashForInvoke()));

            JObject result = cop.nelApi.invokeScript(neoHelper.Jarray2script(cop.contractHash, inputJA));
            string stack = (string)result["result"][0]["stack"][0]["value"];

            return stack;
        }

        public string doCGASinStep0(string cgasHash, string addr, decimal amount,int precision = 8)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)transfer',
	                    [
		                    '(addr){0}',
                            '(addr){1}',
                            '(int){2}'
	                    ]
                    ]", addr, cop.contractAddr, fixedPrecision(amount,precision).ToString()));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cgasHash, inputJA);
        }

        public string doCGASinStep1(string txid_step0)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)setmoneyin',
	                    [
		                    '(hex256){0}',
	                    ]
                    ]", txid_step0));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cop.contractHash, inputJA);
        }

        public string doCGASout(string addr, decimal amount, int precision = 8)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)getmoneyback',
	                    [
		                    '(addr){0}',
                            '(int){1}'
	                    ]
                    ]", addr,fixedPrecision(amount,precision).ToString()));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cop.contractHash, inputJA);
        }

        public string doStartAuction(string addr, string rootDomainStr, string domainStr)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)startAuction',
	                    [
		                    '(addr){0}',
                            '(hex256){1}',
                            '(str){2}'
	                    ]
                    ]", addr, rootDomainStr.getNamehashForInvoke(), domainStr));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cop.contractHash, inputJA);
        }

        public string doBid(string addr, string domain, decimal amount, int precision = 8)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)raise',
	                    [
		                    '(addr){0}',
                            '(hex256){1}',
                            '(int){2}'
	                    ]
                    ]", addr, (string)JObject.Parse(getAuctionStateByFullDomain(domain))["id"], fixedPrecision(amount,precision).ToString()));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cop.contractHash, inputJA);
        }

        public string doBidSettlement(string addr, string domain)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)bidSettlement',
	                    [
		                    '(addr){0}',
                            '(hex256){1}'
	                    ]
                    ]", addr, (string)JObject.Parse(getAuctionStateByFullDomain(domain))["id"]));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cop.contractHash, inputJA);
        }

        public string doCollectDomain(string addr, string domain)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)collectDomain',
	                    [
		                    '(addr){0}',
                            '(hex256){1}'
	                    ]
                    ]", addr, (string)JObject.Parse(getAuctionStateByFullDomain(domain))["id"]));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cop.contractHash, inputJA);
        }

        public string doRenewDomain(string addr, string rootDomain, string subDomain)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)renewDomain',
	                    [
		                    '(addr){0}',
                            '(hex256){1}',
                            '(str){2}'
	                    ]
                    ]", addr, rootDomain.getNamehashForInvoke(),subDomain));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cop.contractHash, inputJA);
        }
    }
}
