using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class No
    {
        private int Valor;
        private No Esquerda;
        private No Direita;

        public No(int valor)
        {
            Valor = valor;
            Esquerda = null;
            Direita = null;
        }

        public int GetValor()
        {
            return Valor;
        }

        public No GetEsquerda()
        {
            return Esquerda;
        }

        public No GetDireita()
        {
            return Direita;
        }

        public void SetValor(int valor)
        {
            Valor = valor;
        }

        public void SetEsquerda(No esquerda)
        {
            Esquerda = esquerda;
        }

        public void SetDireita(No direita)
        {
            Direita = direita;
        }

    }
}