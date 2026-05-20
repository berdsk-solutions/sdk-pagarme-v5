using System.Net;

namespace Berdsk.Sdk.PagarMe.V5.Exceptions
{
    /// <summary>
    ///     Exceção lançada quando o limite de requisições é excedido (Status 429).
    /// </summary>
    public class PmTooManyRequestsException : PagarMeException
    {
        public PmTooManyRequestsException(PmErrorResponse? errorResponse, string? rawBody = null)
            : base(HttpStatusCode.TooManyRequests, errorResponse, rawBody)
        {
        }
    }
}