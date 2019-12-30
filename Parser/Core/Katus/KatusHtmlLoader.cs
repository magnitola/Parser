using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Parser.Core
{
    class KatusHtmlLoader<T> where T : class
    {
        readonly HttpClient client;
        readonly string url;
        IParser<T> parser = new KatusParser() as IParser<T>;
        public event Action<object, T> OnNewData;

        public KatusHtmlLoader(IParserSettings settings, string request)
        {
            client = new HttpClient();
            url = $"{settings.BaseUrl}/{settings.Prefix.Replace("{request}", request)}/";
        }

        /// <summary>
        /// Получить статьи
        /// </summary>
        /// <returns></returns>
        public async Task Worker()
        {
            var source = await GetSource();
            var domParser = new HtmlParser();

            var document = await domParser.ParseDocumentAsync(source);

            var result = parser.Parse(document);
            foreach (var res in result)
            {
                OnNewData?.Invoke(this, res);
            }
        }

        /// <summary>
        /// Получить Html страницы
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetSource()
        {
            var response = await client.GetAsync(url);
            string source = null;

            if (response != null && response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }
    }
}
