int qtdlinhas = 3, qtdcolunas = 4;

float[,] matriz1 = new float[qtdlinhas, qtdcolunas];
float[,] matriz2 = new float[qtdlinhas, qtdcolunas];
float[,] matriz3 = new float[qtdlinhas, qtdcolunas];

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
}


//criacao da matriz 1

for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz1[linha, coluna] = new Random().Next(0, 10);
    }
}

ImprimirMatriz(matriz1, "Matriz 1");

//criacao da matriz 2

for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz2[linha, coluna] = new Random().Next(0, 10);
    }
}

Console.ReadLine();

ImprimirMatriz(matriz2, "Matriz 2");

for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
    }
}

Console.ReadLine();
ImprimirMatriz(matriz3, "Matriz Somada");


for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
    }
}

Console.ReadLine();

ImprimirMatriz(matriz3, "Matriz Subtraida");

Console.ReadLine();

for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
    }
}

ImprimirMatriz(matriz3, "Matriz Multiplicada");

Console.ReadLine();


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