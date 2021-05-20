using System;
using System.Collections.Generic;
using System.Linq;
using Dao;
using Entity;
using System.Windows.Forms;

namespace Business
{
    public class BusinessProdutos
    {
        public void incluir(Produto prod)
        {
            new DaoProdutos().incluir(prod);
        }

        public List<Produto> obterLista(bool showAll, LinkLabel lnklbl)
        {
            return new DaoProdutos().obterLista(showAll, lnklbl);
        }
        public void excluir(int codigo)
        {
            new DaoProdutos().excluir(codigo);
        }

        public Produto RecuperarId(int codigo)
        {
            return new DaoProdutos().recuperarPorId(codigo);
        }
    }
}
