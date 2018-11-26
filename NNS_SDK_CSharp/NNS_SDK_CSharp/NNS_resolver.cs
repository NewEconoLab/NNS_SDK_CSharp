using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using NEL;

namespace NNS_SDK_CSharp
{
    public class NNS_resolver
    {
        contractOperate cop;
        public NNS_resolver(neoHelper.neoAddress neoAddressIn, string contractHashIn, string nelApiUrlIn)
        {
            cop = new contractOperate(neoAddressIn, contractHashIn, nelApiUrlIn);
        }

        public string resolve(string domain)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                [
	                '(str)resolve',
	                [
		                '(str){0}',
                        '(hex256){1}'
	                ]
                ]","addr",domain.getNamehashForInvoke()));

            JObject result = cop.nelApi.invokeScript(neoHelper.Jarray2script(cop.contractHash, inputJA));
            string addr = (string)result["result"][0]["stack"][0]["value"];

            if (addr != "") addr = addr.Hexstring2String(); //ThinNeo.Helper_NEO.GetAddress_FromScriptHash(ThinNeo.Helper.HexString2Bytes(addr));
            else addr = "NNS Unresolved";

            return addr;
        }

        public string SetResolverData(string addrOwner, string ownerDomain, string subDomain, string resolveAddr)
        {
            JArray inputJA = JArray.Parse(string.Format(@"
                [
	                '(str)setResolverData',
	                [
		                '(addr){0}',
                        '(hex256){1}',
                        '(str){2}',
                        '(str)addr',
                        '(str){3}'
	                ]
                ]", addrOwner, ownerDomain.getNamehashForInvoke(), subDomain, resolveAddr));

            return cop.nTX.SendSimpleInvokeTx(cop.neoAddress, cop.neoAddress.addrStr, cop.contractHash, inputJA);
        }
    }
}
