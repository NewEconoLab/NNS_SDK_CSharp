using System;
using System.Collections.Generic;
using System.Text;
using NEL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static NEL.neoHelper;

namespace NNS_SDK_CSharp
{
    public class NNS_domainCenter
    {
        contractOperate cop;
        public NNS_domainCenter(neoAddress neoAddressIn, string contractHashIn, string nelApiUrlIn) {
            cop = new contractOperate(neoAddressIn,contractHashIn,nelApiUrlIn);
        }

        DateTime startTime = TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1, 8, 0, 0), TimeZoneInfo.Local); // 当地时区

        public string getOwnerInfo(string domain)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)getOwnerInfo',
	                    [
                            '(hex256){0}'
	                    ]
                    ]", domain.getNamehashForInvoke()));
            JObject result = cop.nelApi.invokeScript(neoHelper.Jarray2script(cop.contractHash, inputJA));
            JArray stackJA = (JArray)result["result"][0]["stack"][0]["value"];

            NNSHelper.OwnerInfo OI = new NNSHelper.OwnerInfo();
            if ((string)stackJA[0]["value"] != "")
            {
                OI.owner = ThinNeo.Helper_NEO.GetAddress_FromScriptHash(((string)stackJA[0]["value"]).Hexstring2Bytes());
                OI.register = ((string)stackJA[1]["value"]).HexstringReverse();
                OI.resolver = ((string)stackJA[2]["value"]).HexstringReverse();
                OI.TTL = startTime.AddSeconds((long)((string)stackJA[3]["value"]).Hexstring2Decimal(0));
                OI.parentOwner = ThinNeo.Helper_NEO.GetAddress_FromScriptHash(((string)stackJA[4]["value"]).Hexstring2Bytes());
                OI.domain = ((string)stackJA[5]["value"]).Hexstring2String();
                OI.parenthash = (string)stackJA[6]["value"];
                if ((string)stackJA[7]["value"] == "") OI.root = false; else OI.root = true;

                string OIstr = JsonConvert.SerializeObject(OI);
                OIstr = JObject.Parse(OIstr).ToString();

                return OIstr;
            }
            else
            { return "No OwnerInfo Data"; }
        }

        public string doOwnerSetOwner(string addrOwner, string domain, string addrTo)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)owner_SetOwner',
	                    [
		                    '(addr){0}',
                            '(hex256){1}',
                            '(addr){2}'
	                    ]
                    ]", addrOwner, domain.getNamehashForInvoke(), addrTo));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cop.contractHash, inputJA);
        }

        public string doOwnerSetRegister(string addrOwner, string domain, string registerHash)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)owner_SetRegister',
	                    [
		                    '(addr){0}',
                            '(hex256){1}',
                            '(hex160){2}'
	                    ]
                    ]", addrOwner, domain.getNamehashForInvoke(), registerHash));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cop.contractHash, inputJA);
        }

        public string doOwnerSetResolver(string addrOwner, string domain, string resolverHash)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                    [
	                    '(str)owner_SetResolver',
	                    [
		                    '(addr){0}',
                            '(hex256){1}',
                            '(hex160){2}'
	                    ]
                    ]", addrOwner, domain.getNamehashForInvoke(), resolverHash));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cop.contractHash, inputJA);
        }
    }
}
