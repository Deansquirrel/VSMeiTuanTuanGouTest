using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace WinFormTest
{
    class HttpHelper
    {

        public HttpHelper()
        {
        }

        public string Get(string url, int Timeout)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.UserAgent = null;
            request.Timeout = Timeout;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }

        public string Post(string url, string data, int timeout)
        {
            string result = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Timeout = timeout;
            byte[] byteData = Encoding.UTF8.GetBytes(data);
            request.ContentLength = byteData.LongLength;

            using (Stream reqStream = request.GetRequestStream())
            {
                reqStream.Write(byteData, 0, byteData.Length);
                reqStream.Close();
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();

            using (StreamReader reader = new StreamReader(myResponseStream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }

            return result;

        }
    }
}
