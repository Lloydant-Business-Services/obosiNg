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

        public static string GetYouTubeVideoId(string youtubeUrl)
        {
            Uri uri = new Uri(youtubeUrl);
            string host = uri.Host;
            string videoId = "";

            if (host.Contains("youtu.be"))
            {
                videoId = uri.Segments[1];
                if (videoId.EndsWith("/"))
                {
                    videoId = videoId.TrimEnd('/');
                }
            }
            else if (host.Contains("youtube.com"))
            {
                string queryString = uri.Query;
                string[] queryParams = queryString.Split('&');
                foreach (string param in queryParams)
                {
                    string[] keyValue = param.Split('=');
                    if (keyValue[0] == "v")
                    {
                        videoId = keyValue[1];
                        break;
                    }
                }
            }
            if (string.IsNullOrEmpty(videoId))
            {
                throw new ArgumentException("Invalid YouTube URL");
            }
            return videoId;
        }
        public static string ToSentenceCase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            // Convert the first character to uppercase
            string sentenceCase = input.Substring(0, 1).ToUpper();

            if (input.Length > 1)
            {
                // Convert the rest of the string to lowercase
                sentenceCase += input.Substring(1).ToLower();
            }

            return sentenceCase;
        }
        public static string GetTimeDifference(DateTime pastDate)
        {
            DateTime currentDate = DateTime.Now;
            TimeSpan timeDifference = currentDate - pastDate;

            if (timeDifference.TotalDays >= 1)
            {
                return $"{(int)timeDifference.TotalDays} days ago";
            }
            else if (timeDifference.TotalHours >= 1)
            {
                return $"{(int)timeDifference.TotalHours} hours ago";
            }
            else
            {
                if ((int)timeDifference.TotalMinutes == 0)
                {
                    return "Just Now.";
                }
                else
                {
                    return $"{(int)timeDifference.TotalMinutes} minutes ago";
                }
            }
        }

    }

}
