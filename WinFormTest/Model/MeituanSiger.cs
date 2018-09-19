using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WinFormTest
{
    class MeituanSiger
    {

        private readonly MeituanConfig config;

        public MeituanSiger()
        {
            config = new MeituanConfig();
        }

        public string GetSign(Hashtable param)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(config.SignKey);

            ArrayList akeys = new ArrayList(param.Keys);
            akeys.Sort();
            foreach (string key in akeys)
            {
                sb.Append(key);
                sb.Append(param[key]);
            }

            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] bytes = Encoding.UTF8.GetBytes(sb.ToString());
            byte[] bytes_out = sha.ComputeHash(bytes);

            sb = new StringBuilder();
            foreach (byte b in bytes_out)
            {
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }

    }
}
