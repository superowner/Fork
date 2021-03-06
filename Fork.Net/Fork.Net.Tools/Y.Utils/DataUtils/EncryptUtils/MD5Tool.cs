﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Y.Utils.DataUtils.EncryptUtils
{
    public class MD5Tool
    {
        /// <summary>
        /// 给一个字符串进行MD5加密
        /// </summary>
        /// <param name="s">待加密字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string Encrypt(string s)
        {
            string result = "";
            byte[] buffer = Encoding.Default.GetBytes(s);
            HashAlgorithm algorithm = MD5.Create();
            byte[] hashBytes = algorithm.ComputeHash(buffer);
            result = BitConverter.ToString(hashBytes).Replace("-", "");
            return result;
        }
    }
}
