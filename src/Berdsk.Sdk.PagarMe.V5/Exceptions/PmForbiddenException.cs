using System;
using System.Net;

namespace Berdsk.Sdk.PagarMe.V5.Exceptions
{
    /// <summary>
    ///     Exceção lançada quando há um bloqueio por IP ou domínio (Status 403).
    /// </summary>
    public class PmForbiddenException : PagarMeException
    {
        public PmForbiddenException(PmErrorResponse? errorResponse, string? rawBody = null)
            : base(HttpStatusCode.Forbidden, errorResponse, rawBody)
        {
        }
    }
}
