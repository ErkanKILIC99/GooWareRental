using System;
using System.IO;
using System.Net;
using System.Text;

namespace DevCarRental.WinFormUI.Modules
{
    public static class PostRequest
    {
        private static HttpWebRequest _request;
        private static WebResponse _webResponse = null;

        public static object PostData(Uri url, object dataToSent)
        {
            string responseResult = "";

            byte[] bytes = Encoding.UTF8.GetBytes(JsonConverter.ConvertDataToJson(dataToSent));
            _request = (HttpWebRequest)WebRequest.Create(url);
            _request.Method = "POST";
            _request.ContentType = "application/json; charset=UTF-8";
            _request.Accept = "application/json";
            _request.ContentLength = Convert.ToInt64(bytes.Length);

            Stream writeStream = _request.GetRequestStream();
            writeStream.Write(bytes, 0, bytes.Length);
            writeStream.Close();
            try
            {
                HttpWebResponse response = (HttpWebResponse)_request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(responseStream, Encoding.UTF8);
                responseResult = readStream.ReadToEnd();
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    _webResponse = ex.Response;
                    responseResult = new StreamReader(_webResponse.GetResponseStream()).ReadToEnd().Trim();
                }
            }
            return responseResult;
        }

    }
}