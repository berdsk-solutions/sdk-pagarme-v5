using System.Net;

namespace Berdsk.Sdk.PagarMe.V5.Exceptions
{
    /// <summary>
    ///     Exceção lançada quando ocorre um erro interno no servidor do Pagar.me (Status 500).
    /// </summary>
    public class PmInternalServerErrorException : PagarMeException
    {
        public PmInternalServerErrorException(PmErrorResponse? errorResponse, string? rawBody = null)
            : base(HttpStatusCode.InternalServerError, errorResponse, rawBody)
        {
        }
    }
}