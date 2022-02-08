using SoftUniHttpServer.HTTP;

namespace SoftUniHttpServer.Responses
{
    public class BadRequestResponse : Response
    {
        public BadRequestResponse()
            : base(StatusCode.BadRequest)
        {

        }
    }
}
