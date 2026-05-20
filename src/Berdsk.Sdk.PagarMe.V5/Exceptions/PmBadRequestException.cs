using System.Net;

namespace Berdsk.Sdk.PagarMe.V5.Exceptions
{
    /// <summary>
    ///     Exceção lançada quando a requisição é inválida (Status 400).
    /// </summary>
    public class PmBadRequestException : PagarMeException
    {
        public PmBadRequestException(PmErrorResponse? errorResponse, string? rawBody = null)
            : base(HttpStatusCode.BadRequest, errorResponse, rawBody)
        {
        }
    }
}