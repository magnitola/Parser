using AngleSharp.Html.Dom;

namespace Parser.Core
{
    interface IParser<T> where T : class
    {
        System.Collections.Generic.IEnumerable<T> Parse(IHtmlDocument document);
    }
}
