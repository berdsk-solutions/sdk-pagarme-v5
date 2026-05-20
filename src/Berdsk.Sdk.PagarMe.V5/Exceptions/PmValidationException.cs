using System.Net;

namespace Berdsk.Sdk.PagarMe.V5.Exceptions
{
    /// <summary>
    ///     Exceção lançada quando há erros de validação nos parâmetros da requisição (Status 422).
    /// </summary>
    public class PmValidationException : PagarMeException
    {
        public PmValidationException(PmErrorResponse? errorResponse, string? rawBody = null)
            : base(HttpStatusCode.UnprocessableEntity, errorResponse, rawBody)
        {
        }
    }
}