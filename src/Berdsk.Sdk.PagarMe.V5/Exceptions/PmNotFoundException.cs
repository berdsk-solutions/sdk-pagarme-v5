using System.Net;

namespace Berdsk.Sdk.PagarMe.V5.Exceptions
{
    /// <summary>
    ///     Exceção lançada quando o recurso solicitado não é encontrado (Status 404).
    /// </summary>
    public class PmNotFoundException : PagarMeException
    {
        public PmNotFoundException(PmErrorResponse? errorResponse, string? rawBody = null)
            : base(HttpStatusCode.NotFound, errorResponse, rawBody)
        {
        }
    }
}