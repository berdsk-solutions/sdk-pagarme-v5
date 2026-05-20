using System;
using System.Net;

namespace Berdsk.Sdk.PagarMe.V5.Exceptions
{
    /// <summary>
    ///     Exceção lançada quando parâmetros são válidos mas a requisição falhou (Status 412).
    /// </summary>
    public class PmPreconditionFailedException : PagarMeException
    {
        public PmPreconditionFailedException(PmErrorResponse? errorResponse, string? rawBody = null)
            : base(HttpStatusCode.PreconditionFailed, errorResponse, rawBody)
        {
        }
    }
}
