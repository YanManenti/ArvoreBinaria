using BinaryTree;

BinaryTreeClass arvore = new BinaryTreeClass();

arvore.Inserir(8);
arvore.Inserir(3);
arvore.Inserir(1);
arvore.Inserir(6);
arvore.Inserir(4);
arvore.Inserir(7);
arvore.Inserir(10);
arvore.Inserir(14);
arvore.Inserir(13);

Console.WriteLine("Em Ordem:");
arvore.EmOrdem(arvore.GetRaiz());
Console.WriteLine("\n\nPre Ordem:");
arvore.PreOrdem(arvore.GetRaiz());
Console.WriteLine("\n\nPos Ordem:");
arvore.PosOrdem(arvore.GetRaiz());
Console.WriteLine();

Console.WriteLine("\nBusca Binária:");
arvore.BuscaBinaria(2);
arvore.BuscaBinaria(6);
arvore.BuscaBinaria(13);
arvore.BuscaBinaria(18);
