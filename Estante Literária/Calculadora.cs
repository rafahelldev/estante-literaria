using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estante_Literária
{
    class Calculadora
    {
        public static decimal valor_livro;
        public static int unidades;
        public static decimal solucao;
        public static decimal valor_itemvenda;

        public static decimal ValorItemVenda_Adicionar(decimal valor_livro, int unidades)
        {
            solucao = valor_livro * unidades;
            valor_itemvenda += solucao;

            return solucao;
        }

        public static decimal ValorItemVenda_Remover(decimal valor_livro, int unidades)
        {
            solucao = 0 - (valor_livro * unidades);
            valor_itemvenda += solucao;

            return solucao;
        }
    }
}
