using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTreeClass
    {
        private No raiz;

        public BinaryTreeClass()
        {
            raiz = null;
        }

        public No GetRaiz()
        {
            return raiz;
        }

        public void SetRaiz(No raiz)
        {
            this.raiz = raiz;
        }

        public void Inserir(int valor)
        {
            No novo = new No(valor);
            No atual = raiz;

            if (raiz == null)
            {
                raiz = novo;
                return;
            }

            if (Search(valor) != null)
            {
                Console.WriteLine($"O valor {valor} já existe na árvore!");
                return;
            }

            while (atual != null)
            {
                if (valor < atual.GetValor())
                {
                    if (atual.GetEsquerda() == null)
                    {
                        atual.SetEsquerda(novo);
                        return;
                    }
                    atual = atual.GetEsquerda();
                }
                if (valor > atual.GetValor())
                {
                    if (atual.GetDireita() == null)
                    {
                        atual.SetDireita(novo);
                        return;
                    }
                    atual = atual.GetDireita();
                }
            }

        }

        public void EmOrdem(No atual)
        {
            if (atual != null)
            {
                EmOrdem(atual.GetEsquerda());
                Console.Write($"{atual.GetValor()} ");
                EmOrdem(atual.GetDireita());
            }
        }

        public void PreOrdem(No atual)
        {
            if (atual != null)
            {
                Console.Write($"{atual.GetValor()} ");
                PreOrdem(atual.GetEsquerda());
                PreOrdem(atual.GetDireita());
            }
        }

        public void PosOrdem(No atual)
        {
            if (atual != null)
            {
                PosOrdem(atual.GetEsquerda());
                PosOrdem(atual.GetDireita());
                Console.Write($"{atual.GetValor()} ");
            }
        }

        private No Search(int valor)
        {
            No atual = raiz;

            while (atual != null)
            {
                if (valor == atual.GetValor())
                {
                    return atual;
                }
                if (valor < atual.GetValor())
                {
                    atual = atual.GetEsquerda();
                }
                else
                {
                    atual = atual.GetDireita();
                }
            }

            return null;
        }

        public void BuscaBinaria(int valor)
        {
            No resultado = Search(valor);
            if (resultado != null)
            {
                Console.WriteLine($"Valor {valor} encontrado!");
            }
            else
            {
                Console.WriteLine($"Valor {valor} não encontrado!");
            }
        }

    }
}