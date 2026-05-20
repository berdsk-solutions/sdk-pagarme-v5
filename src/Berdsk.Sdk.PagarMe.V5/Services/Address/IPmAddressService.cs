using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Address.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Address
{
    /// <summary>
    /// Interface para o serviço de endereços.
    /// </summary>
    public interface IPmAddressService
    {
        /// <summary>
        ///     Cria um novo endereço para um cliente.
        ///     <para>Referência: https://docs.pagar.me/reference/criar-endereço-1.md</para>
        /// </summary>
        /// <param name="customerId">Identificador do cliente (cus_xxxxxxxxxxxxxxxx)</param>
        /// <param name="request">Dados do endereço</param>
        /// <returns>Dados do endereço criado</returns>
        Task<PmAddressResponse?> CreateAddressAsync(string customerId, PmCreateAddressRequest request);

        /// <summary>
        ///     Obtém os dados de um endereço específico de um cliente.
        ///     <para>Referência: https://docs.pagar.me/reference/obter-endereço-1.md</para>
        /// </summary>
        /// <param name="customerId">Identificador do cliente</param>
        /// <param name="addressId">Identificador do endereço (addr_xxxxxxxxxxxxxxxx)</param>
        /// <returns>Dados do endereço</returns>
        Task<PmAddressResponse?> GetAddressAsync(string customerId, string addressId);

        /// <summary>
        ///     Lista os endereços de um cliente.
        ///     <para>Referência: https://docs.pagar.me/reference/listar-endereços-1.md</para>
        /// </summary>
        /// <param name="customerId">Identificador do cliente</param>
        /// <param name="page">número da página</param>
        /// <param name="size">Quantidade de registros por página</param>
        /// <returns>Lista de endereços</returns>
        Task<PmListAddressesResponse?> ListAddressesAsync(string customerId, int? page = null, int? size = null);

        /// <summary>
        ///     Atualiza os dados de um endereço existente.
        ///     <para>Referência: https://docs.pagar.me/reference/editar-endereço-1.md</para>
        /// </summary>
        /// <param name="customerId">Identificador do cliente</param>
        /// <param name="addressId">Identificador do endereço</param>
        /// <param name="request">Dados para atualização</param>
        /// <returns>Dados do endereço atualizado</returns>
        Task<PmAddressResponse?> UpdateAddressAsync(string customerId, string addressId, PmUpdateAddressRequest request);

        /// <summary>
        ///     Exclui um endereço de um cliente.
        ///     <para>Referência: https://docs.pagar.me/reference/excluir-endereço-1.md</para>
        /// </summary>
        /// <param name="customerId">Identificador do cliente</param>
        /// <param name="addressId">Identificador do endereço</param>
        /// <returns>Dados do endereço excluído</returns>
        Task<PmAddressResponse?> DeleteAddressAsync(string customerId, string addressId);
    }
}


