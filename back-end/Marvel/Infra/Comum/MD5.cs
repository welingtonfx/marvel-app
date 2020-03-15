﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Infra.Comum
{
    public class MD5
    {
        public string ObterHash(string texto)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(texto));

            for (int i = 0; i < bytes.Length; i++)
                hash.Append(bytes[i].ToString("x2"));

            return hash.ToString();
        }
    }
}
