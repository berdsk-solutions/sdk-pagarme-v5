using System.Threading.Tasks;
using Berdsk.Sdk.PagarMe.V5.Services.Address;
using Berdsk.Sdk.PagarMe.V5.Services.Cards;
using Berdsk.Sdk.PagarMe.V5.Services.Customer.Dtos;

namespace Berdsk.Sdk.PagarMe.V5.Services.Customer
{
    /// <summary>
    ///     Interface para o serviço de clientes.
    /// </summary>
    public interface IPmCustomerService
    {
        /// <summary>
        ///     Serviço de cartões do cliente.
        /// </summary>
        IPmCardService Cards { get; }

        /// <summary>
        ///     Serviço de endereços do cliente.
        /// </summary>
        IPmAddressService Addresses { get; }

        /// <summary>
        ///     Cria um novo cliente na PagarMe.
        /// </summary>
        /// <param name="request">Dados do cliente para criação</param>
        /// <returns>Dados do cliente criado ou null em caso de erro</returns>
        /// <see href="https://docs.pagar.me/reference/criar-cliente-1">Documentação Oficial PagarMe</see>
        Task<PmCustomerResponse?> CreateCustomerAsync(PmCreateCustomerRequest request);

        /// <summary>
        ///     Obtém os dados de um cliente específico.
        /// </summary>
        /// <param name="customerId">Identificador do cliente (ex: cus_xxxxxxxxxxxxxxxx)</param>
        /// <returns>Dados do cliente ou null se não encontrado</returns>
        /// <see href="https://docs.pagar.me/reference/obter-cliente-1">Documentação Oficial PagarMe</see>
        Task<PmCustomerResponse?> GetCustomerAsync(string customerId);

        /// <summary>
        ///     Atualiza os dados de um cliente existente.
        /// </summary>
        /// <param name="customerId">Identificador do cliente</param>
        /// <param name="request">Dados para atualização</param>
        /// <returns>Dados do cliente atualizado ou null em caso de erro</returns>
        /// <see href="https://docs.pagar.me/reference/editar-cliente-1">Documentação Oficial PagarMe</see>
        Task<PmCustomerResponse?> UpdateCustomerAsync(string customerId, PmUpdateCustomerRequest request);

        /// <summary>
        ///     Lista os clientes cadastrados com filtros opcionais.
        ///     <see href="https://docs.pagar.me/reference/listar-clientes-1">Documentação Oficial PagarMe</see>
        /// </summary>
        /// <param name="name">Filtro por nome</param>
        /// <param name="email">Filtro por email</param>
        /// <param name="document">Filtro por documento</param>
        /// <param name="gender">Filtro por gênero (male, female)</param>
        /// <param name="code">Filtro por código de referência</param>
        /// <param name="page">número da página</param>
        /// <param name="size">Quantidade de registros por página</param>
        /// <returns>Lista de clientes e informações de paginação</returns>
        Task<PmListCustomersResponse?> ListCustomersAsync(string? name = null, string? email = null,
            string? document = null, string? gender = null, string? code = null, int? page = null, int? size = null);
    }
}