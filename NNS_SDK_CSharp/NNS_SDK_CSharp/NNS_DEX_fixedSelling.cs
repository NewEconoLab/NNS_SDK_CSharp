using System;
using System.Collections.Generic;
using System.Text;
using NEL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static NEL.neoHelper;

namespace NNS_SDK_CSharp
{
    public class NNS_DEX_fixedSelling
    {
        contractOperate cop;
        public NNS_DEX_fixedSelling(neoAddress neoAddressIn, string contractHashIn, string nelApiUrlIn)
        {
            cop = new contractOperate(neoAddressIn, contractHashIn, nelApiUrlIn);
        }

        public decimal getNNCbanlance(string NNCHash, string addr)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)balanceOf',
	                    [
                            '(addr){0}'
	                    ]
                    ]", addr));

            JObject result = cop.nelApi.invokeScript(neoHelper.Jarray2script(NNCHash, inputJA));
            string banlance = (string)result["result"][0]["stack"][0]["value"];

            return banlance.Hexstring2Decimal(2);
        }

        public decimal getDEXfixedSellingBalance(string addr)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)getBalanceOf',
	                    [
		                    '(addr){0}'
	                    ]
                    ]", addr));

            JObject result = cop.nelApi.invokeScript(neoHelper.Jarray2script(cop.contractHash, inputJA));
            string banlance = (string)result["result"][0]["stack"][0]["value"];

            return banlance.Hexstring2Decimal(2);
        }

        public string getFixedSellingInfo(string domain)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)getFixedSellingInfo',
	                    [
		                    '(hex256){0}'
	                    ]
                    ]", domain.getNamehashForInvoke()));

            JObject result = cop.nelApi.invokeScript(neoHelper.Jarray2script(cop.contractHash, inputJA));
            JArray stackJA = (JArray)result["result"][0]["stack"][0]["value"];

            if ((string)stackJA[0]["value"] != "False")
            {
                JObject resultJ = new JObject();
                resultJ.Add("fullHash", stackJA[0]["value"]);
                resultJ.Add("fullDomain", ((string)stackJA[1]["value"]).Hexstring2String());
                resultJ.Add("seller", ThinNeo.Helper_NEO.GetAddress_FromScriptHash(((string)stackJA[2]["value"]).Hexstring2Bytes()));
                resultJ.Add("price", ((string)stackJA[3]["value"]).Hexstring2Decimal(2));
                return resultJ.ToString();
            }

            return "No Data";
        }

        public string doNNCinStep0(string NNCHash, string addr, decimal amount, int precision = 2)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)transfer',
	                    [
		                    '(addr){0}',
                            '(addr){1}',
                            '(int){2}'
	                    ]
                    ]",addr,cop.contractAddr,fixedPrecision(amount,precision).ToString()));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, NNCHash, inputJA);
        }

        public string doNNCinStep1(string txid_step0)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)setMoneyIn',
	                    [
		                    '(hex256){0}',
	                    ]
                    ]", txid_step0));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cop.contractHash, inputJA);
        }

        public string doNNCout(string addr, decimal amount, int precision = 2)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)getMoneyBack',
	                    [
		                    '(addr){0}',
                            '(int){1}'
	                    ]
                    ]", addr,fixedPrecision(amount,precision).ToString()));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cop.contractHash, inputJA);
        }

        public string doNNCoutAll(string addr)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)getMoneyBackAll',
	                    [
		                    '(addr){0}'
	                    ]
                    ]", addr));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cop.contractHash, inputJA);
        }

        public string doLaunch(string[] domainArray, decimal price, int precision = 2)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                     [
	                    '(str)launch',
	                    [
		                    [{0}],
                            '(int){1}'
	                    ]
                    ]", "'(str)" + string.Join("','(str)", domainArray) + "'", fixedPrecision(price,precision).ToString()));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cop.contractHash, inputJA);
        }

        public string doDiscontinue(string domain)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)discontinue',
	                    [
                            '(hex256){0}'
	                    ]
                    ]", domain.getNamehashForInvoke()));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cop.contractHash, inputJA);
        }

        public string doBuy(string addr, string domain)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)buy',
	                    [
                            '(addr){0}',
                            '(hex256){1}'
	                    ]
                    ]", addr, domain.getNamehashForInvoke()));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cop.contractHash, inputJA);
        }
    }
}
