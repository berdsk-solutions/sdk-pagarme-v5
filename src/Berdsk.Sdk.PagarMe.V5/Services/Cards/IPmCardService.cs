using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Cards.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Cards
{
    /// <summary>
    ///     Interface para o serviço de cartões.
    /// </summary>
    public interface IPmCardService
    {
        /// <summary>
        ///     Cria um cartão para um cliente.
        ///     <see href="https://docs.pagar.me/reference/criar-cartão">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="customerId">Identificador do cliente (cus_xxxxxxxxxxxxxxxx)</param>
        /// <param name="request">Dados do cartão</param>
        /// <returns>Dados do cartão criado</returns>
        Task<PmCardResponse?> CreateCardAsync(string customerId, PmCreateCardRequest request);

        /// <summary>
        ///     Obtém os dados de um cartão específico de um cliente.
        ///     <see href="https://docs.pagar.me/reference/obter-cartão">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="customerId">Identificador do cliente</param>
        /// <param name="cardId">Identificador do cartão (card_xxxxxxxxxxxxxxxx)</param>
        /// <returns>Dados do cartão</returns>
        Task<PmCardResponse?> GetCardAsync(string customerId, string cardId);

        /// <summary>
        ///     Lista os cartões de um cliente.
        ///     <see href="https://docs.pagar.me/reference/listar-cartão">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="customerId">Identificador do cliente</param>
        /// <param name="page">número da página</param>
        /// <param name="size">Quantidade de registros por página</param>
        /// <returns>Lista de cartões</returns>
        Task<PmListCardsResponse?> ListCardsAsync(string customerId, int? page = null, int? size = null);

        /// <summary>
        ///     Edita um cartão de um cliente.
        ///     <see href="https://docs.pagar.me/reference/editar-cartão">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="customerId">Identificador do cliente</param>
        /// <param name="cardId">Identificador do cartão</param>
        /// <param name="request">Dados para atualização</param>
        /// <returns>Dados do cartão atualizado</returns>
        Task<PmCardResponse?> UpdateCardAsync(string customerId, string cardId, PmUpdateCardRequest request);

        /// <summary>
        ///     Exclui um cartão de um cliente.
        ///     <see href="https://docs.pagar.me/reference/excluir-cartão">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="customerId">Identificador do cliente</param>
        /// <param name="cardId">Identificador do cartão</param>
        /// <returns>Dados do cartão excluído</returns>
        Task<PmCardResponse?> DeleteCardAsync(string customerId, string cardId);

        /// <summary>
        ///     Renova um cartão da Wallet do cliente (Card Updater manual).
        ///     <see href="https://docs.pagar.me/reference/renovar-cartão-1">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="customerId">Identificador do cliente</param>
        /// <param name="cardId">Identificador do cartão</param>
        /// <returns>Dados do cartão renovado</returns>
        Task<PmCardResponse?> RenewCardAsync(string customerId, string cardId);

        /// <summary>
        ///     Cria um token para um cartão (Tokenização segura).
        ///     <see href="https://docs.pagar.me/reference/criar-token-cartão-1">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="publicKey">Chave pública (appId na query string)</param>
        /// <param name="request">Dados do cartão para tokenização</param>
        /// <returns>Token do cartão</returns>
        Task<PmCardTokenResponse?> CreateCardTokenAsync(string publicKey, PmCreateCardTokenRequest request);
    }
}