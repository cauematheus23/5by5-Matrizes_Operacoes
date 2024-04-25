int qtdlinhas= 0, qtdcolunas = 0;
void Parametros(int x, int y)
{
    do
    {
        Console.WriteLine("Digite o tamanho de linhas");
        qtdlinhas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o tamanho de colunas");
        qtdcolunas = int.Parse(Console.ReadLine());
    } while (qtdlinhas != qtdcolunas || qtdcolunas == 0 || qtdlinhas == 0);
}
Parametros(qtdlinhas, qtdcolunas);
float[,] matriz1 = new float[qtdlinhas, qtdcolunas];
float[,] matriz2 = new float[qtdlinhas, qtdcolunas];
float[,] matriz3 = new float[qtdlinhas, qtdcolunas];
int opcao = 0;
void sorteio(float[,] matriz)
{
    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            matriz[linha, coluna] = new Random().Next(0, 10);
        }
    }

}
void ImprimirMatriz(float[,] matriz, string titulo)
{
    Console.WriteLine(titulo);
    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            Console.Write(matriz[linha, coluna] + " ");
        }
    }
    Console.WriteLine();
}
void Menu_Usuario()


{
    sorteio(matriz1);
    ImprimirMatriz(matriz1, "Matriz 1");
    sorteio(matriz2);
    ImprimirMatriz(matriz2, "Matriz 2");
    while (opcao != 5)
    { 
        do
        {
        Console.WriteLine("Escolha uma operação:\n[1]SOMA\n[2]SUBTRAÇÃO\n[3]MULTIPLICAÇÃO\n[4]DIVISÃO\n[5]SAIR");
        opcao = int.Parse(Console.ReadLine());
            if (opcao == 0)
            {
            Console.WriteLine("Valor invalido, por favor digite uma opção válida ");
            }
        }while (opcao == 0 );

     
        switch (opcao)
        {
            case 1:
                for (int linha = 0; linha < qtdlinhas; linha++)
                {
                    for (int coluna = 0; coluna < qtdcolunas; coluna++)
                    {
                        matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
                    }
                }
                ImprimirMatriz(matriz3, "Matriz Somada");
                break;
            case 2:
                for (int linha = 0; linha < qtdlinhas; linha++)
                {
                    for (int coluna = 0; coluna < qtdcolunas; coluna++)
                    {
                        matriz3[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
                    }
                }
                ImprimirMatriz(matriz3, "Matriz Subtraida");
                break;
            case 3:
                for (int linha = 0; linha < qtdlinhas; linha++)
                {
                    for (int coluna = 0; coluna < qtdcolunas; coluna++)
                    {
                        matriz3[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
                    }
                }
                ImprimirMatriz(matriz3, "Matriz Multiplicada");
                break;
            case 4:
                for (int linha = 0; linha < qtdlinhas; linha++)
                {
                    for (int coluna = 0; coluna < qtdcolunas; coluna++)
                    {
                        if (matriz2[linha, coluna] != 0)
                            matriz3[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
                        else
                            matriz3[linha, coluna] = float.NaN;
                    }
                }
                ImprimirMatriz(matriz3, "Matriz Dividida");
                break;
            case 5:
                break;
            default: break;
        }

    }
}

Menu_Usuario();



