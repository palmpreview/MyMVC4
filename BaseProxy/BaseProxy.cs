using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ApiHelper
{
    public abstract class BaseProxy
    {
        protected JsonSerializer Serializer { get; private set; }
        protected Uri BaseUri { get; private set; }
        protected string Locale { get; private set; }

        public BaseProxy(string baseUri, string locale)
            : this(baseUri)
        {
            Locale = locale;
        }
        public BaseProxy(string baseUri)
        {
            Serializer = new JsonSerializer();
            BaseUri = new Uri(baseUri);
            if (BaseUri.Scheme != Uri.UriSchemeHttp && BaseUri.Scheme != Uri.UriSchemeHttps)
            {
                throw new ArgumentException("Base uri is not web address (http or https).", "baseUri");
            }
        }

        protected virtual HttpWebRequest CreateRequest(string method, string apiPath, object query)
        {
            return CreateRequest(method, CreateQueryString(apiPath, query));
        }

        protected virtual HttpWebRequest CreateRequest(string method, string apiPath)
        {
            var request = (HttpWebRequest)WebRequest.Create(new Uri(BaseUri, apiPath));
            request.Method = method;
            request.Accept = "application/json";
            if (!string.IsNullOrWhiteSpace(Locale)) { request.Headers[HttpRequestHeader.AcceptLanguage] = Locale; }
            request.Headers[HttpRequestHeader.AcceptCharset] = "UTF-8";
            request.ContentType = "application/json; charset=utf-8";
            return request;
        }

        protected virtual string CreateQueryString(string apiPath, object query)
        {
            var type = query.GetType();
            var props = type.GetProperties();
            var pairs = props.Select(x => Uri.EscapeDataString(x.Name) + "=" + Uri.EscapeDataString(x.GetValue(query, null).ToString())).ToArray();
            return apiPath + "?" + String.Join("&", pairs);
        }

        protected virtual T ProcessRequest<T>(HttpWebRequest request)
        {

            using (Stream responseStream = request.GetResponse().GetResponseStream())
            {
                return DeserializeStream<T>(responseStream);
            }

        }

        protected virtual T DeserializeStream<T>(Stream stream)
        {
            return Serializer.Deserialize<T>(new JsonTextReader(new StreamReader(stream)));
        }



    }


}
