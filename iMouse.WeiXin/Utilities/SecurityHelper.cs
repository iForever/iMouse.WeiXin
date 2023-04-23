using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace iMouse.WeiXin.Utilities
{
    public class SecurityHelper
    {
        /// <summary>
        /// MD5摘要
        /// </summary>
        /// <returns>The 5 hash.</returns>
        /// <param name="input">Input.</param>
        public static string MD5Hash(string input)
        {
            using (var md5 = MD5.Create())
            {
                var result = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                var strResult = BitConverter.ToString(result);
                return strResult.Replace("-", "").ToLowerInvariant();
            }
        }

        /// <summary>
        /// AES加密算法
        /// </summary>
        /// <returns>The ncrypt.</returns>
        /// <param name="key">Key.</param>
        /// <param name="iv">Iv.</param>
        /// <param name="data">Data.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        public static string AESEncrypt<T>(string key, string iv, T data)
        {
            var szEncryptedData = JsonConvert.SerializeObject(data);
            return AESEncrypt(key, iv, szEncryptedData);
        }

        /// <summary>
        /// AES加密算法
        /// </summary>
        /// <returns>The ncrypt.</returns>
        /// <param name="key">Key.</param>
        /// <param name="iv">Iv.</param>
        /// <param name="data">Data.</param>
        public static string AESEncrypt(string key, string iv, string data)
        {
            using (var aesProvider = Aes.Create())
            {
                aesProvider.KeySize = 128;
                aesProvider.Mode = CipherMode.CBC;
                aesProvider.Padding = PaddingMode.PKCS7;

                aesProvider.Key = Convert.FromBase64String(key);
                aesProvider.IV = Convert.FromBase64String(iv);

                var encryptBytes = Convert.FromBase64String(data);
                using (var decryptor = aesProvider.CreateDecryptor(aesProvider.Key, aesProvider.IV))
                {
                    var result = string.Empty;

                    using (MemoryStream msEncrypt = new MemoryStream(encryptBytes))
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, decryptor, CryptoStreamMode.Write))
                        {
                            csEncrypt.Write(encryptBytes, 0, encryptBytes.Length);
                            csEncrypt.Close();
                        }
                        return Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
        }

        /// <summary>
        /// AES 解密
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="encryptedData">加密数据</param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        public static T? AESDecrypt<T>(string encryptedData, string key, string iv)
        {
            var szDecryptedData = AESDecrypt(encryptedData, key, iv);
            return JsonConvert.DeserializeObject<T>(szDecryptedData);
        }


        /// <summary>
        /// AES 解密
        /// </summary>
        /// <param name="encryptedData"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        public static string AESDecrypt(string encryptedData, string key, string iv)
        {
            using (var aesProvider = Aes.Create())
            {
                aesProvider.KeySize = 128;
                aesProvider.Mode = CipherMode.CBC;
                aesProvider.Padding = PaddingMode.PKCS7;

                aesProvider.Key = Convert.FromBase64String(key);
                aesProvider.IV = Convert.FromBase64String(iv);

                var encryptedBytes = Convert.FromBase64String(encryptedData);
                using (var decryptor = aesProvider.CreateDecryptor(aesProvider.Key, aesProvider.IV))
                {
                    var result = string.Empty;

                    using (MemoryStream msDecrypt = new MemoryStream(encryptedBytes))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                result = srDecrypt.ReadToEnd();
                            }
                        }
                    }
                    return result;
                }
            }
        }


        public static string SHA1Hash(string content)
        {
            return SHA1Hash(content, Encoding.UTF8);
        }

        public static string SHA1Hash(string content, Encoding encoding)
        {
            using var sha1 = SHA1.Create();
            var bytes = sha1.ComputeHash(encoding.GetBytes(content));
            var result = BitConverter.ToString(bytes).Replace("-", "").ToLowerInvariant();
            return result;
        }
    }
}
