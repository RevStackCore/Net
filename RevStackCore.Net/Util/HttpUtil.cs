using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace RevStackCore.Net.Util
{
    public static class HttpUtil
    {
        public static bool IsValidEmail(string strIn)
        {
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names. 
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", DomainMapper,
                    RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (!isValidDomain)
                return false;

            // Return true if strIn is in valid e-mail format. 
            try
            {
                return Regex.IsMatch(strIn,
                    @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public static string ConvertPathToUrl(string path, string domain)
        {
            var url = "";
            if (path.IndexOf("http://") == -1)
            {
                url = "http://" + domain + path;
            }
            else
            {
                url = path;
            }
            return path;
        }

        public static string ConvertPathToUrl(string path, string domain, string port)
        {
            var url = "";
            if (path.IndexOf("http://") == -1)
            {
                url = "http://" + domain + ":" + port + path;
            }
            else
            {
                url = path;
            }
            return path;
        }

        public static string ConvertPathToUrl(string path, string domain, string host, string port)
        {
            var url = "";
            if (path.IndexOf("http://") == -1)
            {
                url = "http://" + host + "." + domain + ":" + port + path;
            }
            else
            {
                url = path;
            }
            return path;
        }

        public static BasicCredentials DecodeBasicAuthorization(string auth)
        {
            var basicCredentials = new BasicCredentials();
            try
            {
                var decoded = Encoding.ASCII.GetString(Convert.FromBase64String(auth));
                var authArray = decoded.Split(':');
                var user = authArray[0];
                var pass = authArray[1];
                basicCredentials.Username = user;
                basicCredentials.Password = pass;
                return basicCredentials;
            }
            catch (Exception)
            {
                return null;
            }
        }


        #region "private"

        private static bool isValidDomain = true;

        private static string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            var idn = new IdnMapping();

            var domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                isValidDomain = false;
            }
            return match.Groups[1].Value + domainName;
        }

        #endregion
    }
}
