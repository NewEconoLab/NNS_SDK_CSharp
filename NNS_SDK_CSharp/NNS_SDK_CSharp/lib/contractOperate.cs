using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NEL
{
    public class contractOperate
    {
        public string contractHash;
        public string contractAddr;
        public nelApiHelper nelApi;
        public neoHelper.neoTranstion nTX;
        public neoHelper.neoAddress neoAddress;

        public contractOperate(neoHelper.neoAddress neoAddressIn, string contractHashIn, string nelApiUrlIn)
        {
            neoAddress = neoAddressIn;
            contractHash = contractHashIn;
            contractAddr = ThinNeo.Helper_NEO.GetAddress_FromScriptHash(contractHashIn.HexstringReverse().Hexstring2Bytes());
            nelApi = new nelApiHelper(nelApiUrlIn);
            nTX = new neoHelper.neoTranstion(nelApiUrlIn);
        }
    }
}
