using System;
using System.Threading.Tasks;
using DevIO.Business.Core.Data;

namespace DevIO.Business.Models.Fornecedores
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}