using SoftUniHttpServer.HTTP;

namespace SoftUniHttpServer.Responses
{
    public class HtmlResponse : ContentResponse
    {
        public HtmlResponse(string text)
            : base(text, ContentType.Html)
        {

        }
    }
}
