﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace SimpleX.ModelCore.Repository
{
    public interface IRepository<T> where T : class
    {
        T Adicionar(T t);
        void Alterar(T t);
        void Remover(params object[] chaves);
        void Remover(Expression<Func<T, bool>> predicado);
        void Remover(T t);
        int Contagem();
        int Contagem(Expression<Func<T, bool>> predicado);
        bool Contem(Expression<Func<T, bool>> predicado);
        T Obter(params object[] chaves);
        IQueryable<T> ObterTodos();
        IQueryable<T> ObterPorFiltros(Expression<Func<T, bool>> predicado);
        IQueryable<T> Filtrar(Expression<Func<T, bool>> filtro, Expression<Func<T, object>> campo = null, Ordenacao ordenacao = Ordenacao.Asc);
        IQueryable<T> ObterPorFiltros(Expression<Func<T, bool>> predicado, out int totalPaginas, int tamanho = 10, int pagina = 1);
    }
}
