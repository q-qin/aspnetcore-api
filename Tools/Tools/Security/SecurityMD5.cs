using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Tools.Security
{
    public static class SecurityMD5
    {
        public static string Encrypt(string data)
        {
            //首次加密
            MD5 md5 = MD5.Create();
            byte[] bs = Encoding.UTF8.GetBytes(data + SecurityKeys.Md5Key);
            byte[] hs = md5.ComputeHash(bs);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hs)
            {
                sb.Append(b.ToString("x2"));
            }

            //再次加密
            byte[] nbs = Encoding.UTF8.GetBytes(sb.ToString() + SecurityKeys.Md5Key);
            byte[] nhs = md5.ComputeHash(nbs);
            StringBuilder nsb = new StringBuilder();
            foreach (byte nb in nhs)
            {
                nsb.Append(nb.ToString("x2"));
            }

            return nsb.ToString();
        }
    }
}
