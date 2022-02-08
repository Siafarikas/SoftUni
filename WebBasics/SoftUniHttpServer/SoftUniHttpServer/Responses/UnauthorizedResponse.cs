using SoftUniHttpServer.HTTP;

namespace SoftUniHttpServer.Responses
{
    public class UnauthorizedResponse : Response
    {
        public UnauthorizedResponse() 
            : base(StatusCode.Unauthorized)
        {

        }
    }
}
