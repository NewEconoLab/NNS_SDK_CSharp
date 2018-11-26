using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NNS_SDK_CSharp
{
    static public class NNSHelper
    {
        public class OwnerInfo
        {
            public string owner;//如果长度=0 表示没有初始化
            public string register;
            public string resolver;
            public DateTime TTL;
            public string parentOwner;//当此域名注册时，他爹的所有者，记录这个，则可以检测域名的爹变了
            //nameinfo 整合到一起
            public string domain;//如果长度=0 表示没有初始化
            public string parenthash;
            public bool root;//是不是根合约
        }

        //单极域名
        static public byte[] NameHashSingle(string singleDomain)
        {
            return ThinNeo.Helper.CalcSha256(singleDomain.Str2ByteArray());
        }
        //父级域名hash，附加单极子域名
        static public byte[] NameHashSub(byte[] parentHash, string subSingleDomain)
        {
            var bs = subSingleDomain.Str2ByteArray();
            if (bs.Length == 0)
                return parentHash;

            byte[] domain = ThinNeo.Helper.CalcSha256(bs).ByteConcat(parentHash);
            return ThinNeo.Helper.CalcSha256(domain);
        }
        //多级域名数组
        static public byte[] NameHashArray(string[] domainarray)
        {
            byte[] hash = NameHashSingle(domainarray[0]);
            for (var i = 1; i < domainarray.Length; i++)
            {
                hash = NameHashSub(hash, domainarray[i]);
            }
            return hash;
        }
        //多级域名点分割
        static public byte[] NameHashMultilevelDomain(string multilevelDomain)
        {
            return NameHashArray(multilevelDomain.Split('.').Reverse().ToArray());
        }

        //合约调用需要的翻转hash
        static public string getNamehashForInvoke(this string multilevelDomain)
        {
            return ThinNeo.Helper.Bytes2HexString(NameHashMultilevelDomain(multilevelDomain).Reverse().ToArray());
        }

        static private byte[] Str2ByteArray(this string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        static private byte[] ByteConcat(this byte[] byteSource, byte[] byteAdd)
        {
            byte[] byteNew = new byte[byteSource.Length + byteAdd.Length];
            Buffer.BlockCopy(byteSource, 0, byteNew, 0, byteSource.Length);
            Buffer.BlockCopy(byteAdd, 0, byteNew, byteSource.Length, byteAdd.Length);

            return byteNew;
        }
    }
}
