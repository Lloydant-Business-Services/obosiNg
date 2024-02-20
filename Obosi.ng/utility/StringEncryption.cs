using System;
using System.Security.Cryptography;
using System.Text;

namespace Obosi.ng.Presentation.utility
{

    public static class StringEncryption
    {
        public static string Encrypt(string encrypData)
        {
            string data = "";
            try
            {
                string CharData = "";
                string ConChar = "";
                for (int i = 0; i < encrypData.Length; i++)
                {
                    CharData = Convert.ToString(encrypData.Substring(i, 1));
                    ConChar = char.ConvertFromUtf32(char.ConvertToUtf32(CharData, 0) + 115);
                    data = data + ConChar;
                }
            }
            catch (Exception)
            {
                data = "1";
                return data;
            }
            return data;
        }

        public static string Decrypt(string encrypData)
        {
            string data = "";
            try
            {
                string CharData = "";
                string ConChar = "";
                for (int i = 0; i < encrypData.Length; i++)
                {
                    CharData = Convert.ToString(encrypData.Substring(i, 1));
                    ConChar = char.ConvertFromUtf32(char.ConvertToUtf32(CharData, 0) - 115);
                    data = data + ConChar;
                }
            }
            catch (Exception)
            {
                data = "1";
                return data;
            }
            return data;
        }
    }

}
