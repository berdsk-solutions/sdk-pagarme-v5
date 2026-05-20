using System.Net;

namespace Berdsk.Sdk.PagarMe.V5.Exceptions
{
    /// <summary>
    ///     Exceção lançada quando a chave da API é inválida ou não fornecida (Status 401).
    /// </summary>
    public class PmUnauthorizedException : PagarMeException
    {
        public PmUnauthorizedException(PmErrorResponse? errorResponse, string? rawBody = null)
            : base(HttpStatusCode.Unauthorized, errorResponse, rawBody)
        {
        }
    }
}