﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Simplex.Pizzaria.Models;
using Simplex.Pizzaria.Service;
using SimpleX.ModelCore;

namespace Simplex.Pizzaria.Facade
{
    public class cadastroFacade
    {
        
        private clienteService<cliente> serviceCliente;
        private clienteEnderecoService<clienteEndereco> serviceClienteEndereco;
        private clienteContatoService<clienteContato> serviceClienteContato;

        private fornecedorService<fornecedor> serviceFornecedor;
        private fornecedorEnderecoService<fornecedorEndereco> serviceFornecedorEndereco;
        private fornecedorContatoService<fornecedorContato> serviceFornecedorContato;

        private produtoService<produto> serviceProduto;
        private produtoCategoriaService<produtoCategoria> serviceProdutoCategoria;
        private produtoTipoService<produtoTipo> serviceProdutoTipo;
        private produtoComposicaoService<produtoComposicao> serviceProdutoComposicao;

        public cadastroFacade()
        {
            serviceCliente = new clienteService<cliente>();
            serviceClienteEndereco = new clienteEnderecoService<clienteEndereco>();
            serviceClienteContato = new clienteContatoService<clienteContato>();

            serviceFornecedor = new fornecedorService<fornecedor>();
            serviceFornecedorEndereco = new fornecedorEnderecoService<fornecedorEndereco>();
            serviceFornecedorContato = new fornecedorContatoService<fornecedorContato>();

            serviceProduto = new produtoService<produto>();
            serviceProdutoCategoria = new produtoCategoriaService<produtoCategoria>();
            serviceProdutoTipo = new produtoTipoService<produtoTipo>();
            serviceProdutoComposicao = new produtoComposicaoService<produtoComposicao>();
        }

        public void Dispose()
        {
            serviceCliente.Dispose();
            serviceClienteEndereco.Dispose();
            serviceClienteContato.Dispose();

            serviceFornecedor.Dispose();
            serviceFornecedorEndereco.Dispose();
            serviceFornecedorContato.Dispose();

            serviceProduto.Dispose();
            serviceProdutoCategoria.Dispose();
            serviceProdutoTipo.Dispose();
            serviceProdutoComposicao.Dispose();
        }


        #region Cliente //Cliente==============================================================
        public List<cliente> FiltrarCliente(cliente cliente)
        {
            return serviceCliente.Filtrar(cliente);
        }

        public cliente ConsultarCliente(Guid Id)
        {
            return serviceCliente.Consultar(Id);
        }

        public List<cliente> ListarCliente()
        {
            return serviceCliente.Listar();
        }

        public Result SalvarCliente(cliente cliente)
        {
            //if (!modelState.IsValid)
            //{
            //    return;
            //}

            Result retorno = serviceCliente.Salvar(cliente);
            //if (!retorno.Sucesso)
            //{
            //    modelState.AddModelError("", retorno.MensagemGeral);

            //    foreach (ResultadoCampo campo in retorno.Campos)
            //    {
            //        modelState.AddModelError(campo.Campo, campo.Mensagem);
            //    }
            //}

            return retorno;
        }

        public Result AlterarCliente(cliente cliente)
        {
            //if (!modelState.IsValid)
            //{
            //    return;
            //}

            Result retorno = serviceCliente.Alterar(cliente);
            //if (!retorno.Sucesso)
            //{
            //    modelState.AddModelError("", retorno.MensagemGeral);

            //    foreach (ResultadoCampo campo in retorno.Campos)
            //    {
            //        modelState.AddModelError(campo.Campo, campo.Mensagem);
            //    }
            //}

            return retorno;
        }

        public Result ExcluirCliente(Guid Id)
        {
            return serviceCliente.Excluir(Id);
        }



        public List<clienteEndereco> FiltrarClienteEndereco(clienteEndereco clienteEndereco)
        {
            return serviceClienteEndereco.Filtrar(clienteEndereco);
        }

        public clienteEndereco ConsultarClienteEndereco(Guid Id)
        {
            return serviceClienteEndereco.Consultar(Id);
        }

        public List<clienteEndereco> ListarClienteEndereco()
        {
            return serviceClienteEndereco.Listar();
        }

        public Result SalvarClienteEndereco(clienteEndereco clienteEndereco)
        {
            //if (!modelState.IsValid)
            //{
            //    return;
            //}

            Result retorno = serviceClienteEndereco.Salvar(clienteEndereco);
            //if (!retorno.Sucesso)
            //{
            //    modelState.AddModelError("", retorno.MensagemGeral);

            //    foreach (ResultadoCampo campo in retorno.Campos)
            //    {
            //        modelState.AddModelError(campo.Campo, campo.Mensagem);
            //    }
            //}

            return retorno;
        }
        public Result AlterarClienteEndereco(clienteEndereco clienteEndereco)
        {
            //if (!modelState.IsValid)
            //{
            //    return;
            //}

            Result retorno = serviceClienteEndereco.Alterar(clienteEndereco);
            //if (!retorno.Sucesso)
            //{
            //    modelState.AddModelError("", retorno.MensagemGeral);

            //    foreach (ResultadoCampo campo in retorno.Campos)
            //    {
            //        modelState.AddModelError(campo.Campo, campo.Mensagem);
            //    }
            //}

            return retorno;
        }


        public Result ExcluirClienteEndereco(Guid Id)
        {
            return serviceClienteEndereco.Excluir(Id);
        }



        public List<clienteContato> FiltrarClienteContato(clienteContato clienteContato)
        {
            return serviceClienteContato.Filtrar(clienteContato);
        }

        public clienteContato ConsultarClienteContato(Guid Id)
        {
            return serviceClienteContato.Consultar(Id);
        }

        public List<clienteContato> ListarClienteContato()
        {
            return serviceClienteContato.Listar();
        }

        public Result SalvarClienteContato(clienteContato clienteContato)
        {
            //if (!modelState.IsValid)
            //{
            //    return;
            //}

            Result retorno = serviceClienteContato.Salvar(clienteContato);
            //if (!retorno.Sucesso)
            //{
            //    modelState.AddModelError("", retorno.MensagemGeral);

            //    foreach (ResultadoCampo campo in retorno.Campos)
            //    {
            //        modelState.AddModelError(campo.Campo, campo.Mensagem);
            //    }
            //}

            return retorno;
        }

        public Result AlterarClienteContato(clienteContato clienteContato)
        {
            //if (!modelState.IsValid)
            //{
            //    return;
            //}

            Result retorno = serviceClienteContato.Alterar(clienteContato);
            //if (!retorno.Sucesso)
            //{
            //    modelState.AddModelError("", retorno.MensagemGeral);

            //    foreach (ResultadoCampo campo in retorno.Campos)
            //    {
            //        modelState.AddModelError(campo.Campo, campo.Mensagem);
            //    }
            //}

            return retorno;
        }

        public Result ExcluirClienteContato(Guid Id)
        {
            return serviceClienteContato.Excluir(Id);
        }


        #endregion Cliente //=====================================================================

        #region Fornecedor // Fornecedor =========================================================
        public List<fornecedor> FiltrarFornecedor(fornecedor fornecedor)
        {
            return serviceFornecedor.Filtrar(fornecedor);
        }

        public fornecedor ConsultarFornecedor(Guid Id)
        {
            return serviceFornecedor.Consultar(Id);
        }

        public List<fornecedor> ListarFornecedor()
        {
            return serviceFornecedor.Listar();
        }

        public Result SalvarFornecedor(fornecedor fornecedor)
        {
            //if (!modelState.IsValid)
            //{
            //    return;
            //}

            Result retorno = serviceFornecedor.Salvar(fornecedor);
            //if (!retorno.Sucesso)
            //{
            //    modelState.AddModelError("", retorno.MensagemGeral);

            //    foreach (ResultadoCampo campo in retorno.Campos)
            //    {
            //        modelState.AddModelError(campo.Campo, campo.Mensagem);
            //    }
            //}

            return retorno;
        }

        public Result AlterarFornecedor(fornecedor fornecedor)
        {
            //if (!modelState.IsValid)
            //{
            //    return;
            //}

            Result retorno = serviceFornecedor.Alterar(fornecedor);
            //if (!retorno.Sucesso)
            //{
            //    modelState.AddModelError("", retorno.MensagemGeral);

            //    foreach (ResultadoCampo campo in retorno.Campos)
            //    {
            //        modelState.AddModelError(campo.Campo, campo.Mensagem);
            //    }
            //}

            return retorno;
        }

        public Result ExcluirFornecedor(Guid Id)
        {
            return serviceFornecedor.Excluir(Id);
        }



        public List<fornecedorEndereco> FiltrarFornecedorEndereco(fornecedorEndereco fornecedorEndereco)
        {
            return serviceFornecedorEndereco.Filtrar(fornecedorEndereco);
        }

        public fornecedorEndereco ConsultarFornecedorEndereco(Guid Id)
        {
            return serviceFornecedorEndereco.Consultar(Id);
        }

        public List<fornecedorEndereco> ListarFornecedorEndereco()
        {
            return serviceFornecedorEndereco.Listar();
        }

        public Result SalvarFornecedorEndereco(fornecedorEndereco fornecedorEndereco)
        {
            
            Result retorno = serviceFornecedorEndereco.Salvar(fornecedorEndereco);
            return retorno;
        }
        public Result AlterarFornecedorEndereco(fornecedorEndereco fornecedorEndereco)
        {

            Result retorno = serviceFornecedorEndereco.Alterar(fornecedorEndereco);
            return retorno;
        }

        public Result ExcluirFornecedorEndereco(Guid Id)
        {
            return serviceFornecedorEndereco.Excluir(Id);
        }



        public List<fornecedorContato> FiltrarFornecedorContato(fornecedorContato fornecedorContato)
        {
            return serviceFornecedorContato.Filtrar(fornecedorContato);
        }

        public fornecedorContato ConsultarFornecedorContato(Guid Id)
        {
            return serviceFornecedorContato.Consultar(Id);
        }

        public List<fornecedorContato> ListarFornecedorContato()
        {
            return serviceFornecedorContato.Listar();
        }

        public Result SalvarFornecedorContato(fornecedorContato fornecedorContato)
        {
            Result retorno = serviceFornecedorContato.Salvar(fornecedorContato);            
            return retorno;
        }

        public Result AlterarFornecedorContato(fornecedorContato fornecedorContato)
        {
            Result retorno = serviceFornecedorContato.Alterar(fornecedorContato);
            return retorno;
        }


        public Result ExcluirFornecedorContato(Guid Id)
        {
            return serviceFornecedorContato.Excluir(Id);
        }

        #endregion Fornecedor//=====================================================================

        #region Produto// Produto =========================================================
        public List<produto> FiltrarProduto(produto produto)
        {
            return serviceProduto.Filtrar(produto);
        }

        public produto ConsultarProduto(Guid Id)
        {
            return serviceProduto.Consultar(Id);
        }

        public List<produto> ListarProduto()
        {
            return serviceProduto.Listar();
        }

        public Result SalvarProduto(produto produto)
        {
           
            Result retorno = serviceProduto.Salvar(produto);           
            return retorno;
        }

        public Result AlterarProduto(produto produto)
        {

            Result retorno = serviceProduto.Alterar(produto);
            return retorno;
        }

        public Result ExcluirProduto(Guid Id)
        {
            return serviceProduto.Excluir(Id);
        }


        public List<produtoCategoria> FiltrarProduto(produtoCategoria produtoCategoria)
        {
            return serviceProdutoCategoria.Filtrar(produtoCategoria);
        }

        public produtoCategoria ConsultarProdutoCategoria(Guid Id)
        {
            return serviceProdutoCategoria.Consultar(Id);
        }

        public List<produtoCategoria> ListarProdutoCategoria()
        {
            return serviceProdutoCategoria.Listar();
        }

        public Result SalvarProdutoCategoria(produtoCategoria produtoCategoria)
        {

            Result retorno = serviceProdutoCategoria.Salvar(produtoCategoria);
            return retorno;
        }
        public Result AlterarProdutoCategoria(produtoCategoria produtoCategoria)
        {

            Result retorno = serviceProdutoCategoria.Alterar(produtoCategoria);
            return retorno;
        }

        public Result ExcluirProdutoCategoria(Guid Id)
        {
            return serviceProdutoCategoria.Excluir(Id);
        }

        
        public List<produtoTipo> FiltrarProdutoTipo(produtoTipo produtoTipo)
        {
            return serviceProdutoTipo.Filtrar(produtoTipo);
        }

        public produtoTipo ConsultarProdutoTipo(Guid Id)
        {
            return serviceProdutoTipo.Consultar(Id);
        }

        public List<produtoTipo> ListarProdutoTipo()
        {
            return serviceProdutoTipo.Listar();
        }

        public Result SalvarProdutoTipo(produtoTipo produtoTipo)
        {

            Result retorno = serviceProdutoTipo.Salvar(produtoTipo);
            return retorno;
        }
        public Result AlterarProdutoTipo(produtoTipo produtoTipo)
        {

            Result retorno = serviceProdutoTipo.Alterar(produtoTipo);
            return retorno;
        }

        public Result ExcluirProdutoTipo(Guid Id)
        {
            return serviceProdutoTipo.Excluir(Id);
        }


        public List<produtoComposicao> FiltrarProdutoComposicao(produtoComposicao produtoComposicao)
        {
            return serviceProdutoComposicao.Filtrar(produtoComposicao);
        }

        public produtoComposicao ConsultarProdutoComposicao(Guid Id)
        {
            return serviceProdutoComposicao.Consultar(Id);
        }

        public List<produtoComposicao> ListarProdutoComposicao()
        {
            return serviceProdutoComposicao.Listar();
        }

        public Result SalvarProdutoComposicao(produtoComposicao produtoComposicao)
        {

            Result retorno = serviceProdutoComposicao.Salvar(produtoComposicao);
            return retorno;
        }

        public Result AlterarProdutoComposicao(produtoComposicao produtoComposicao)
        {

            Result retorno = serviceProdutoComposicao.Alterar(produtoComposicao);
            return retorno;
        }

        public Result ExcluirProdutoComposicao(Guid Id)
        {
            return serviceProdutoComposicao.Excluir(Id);
        }


        #endregion Produto//=====================================================================

    }
}
