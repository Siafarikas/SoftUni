using SoftUniHttpServer.HTTP;

namespace SoftUniHttpServer.Responses
{
    public class NotFoundResponse : Response
    {

        public NotFoundResponse()
            : base(StatusCode.NotFound)
        {

        }
    }
}
