﻿using CasaDoCodigo.Models;
using CasaDoCodigo.Models.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CasaDoCodigo.Services
{
    public interface IApiService
    {
        Task<IEnumerable<Produto>> GetProdutos();
        Task<Produto> GetProduto(string codigo);
        Task<CarrinhoViewModel> Carrinho(string codigo, int pedidoId);
        Task<PedidoViewModel> GetPedido(int pedidoId);
        Task<PedidoViewModel> UpdateCadastro(CadastroViewModel viewModel);
        Task<UpdateQuantidadeOutput> UpdateQuantidade(string itemPedidoId, int quantidade);
    }
}
