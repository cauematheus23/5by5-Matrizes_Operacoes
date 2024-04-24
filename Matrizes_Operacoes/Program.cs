int qline = 3, qcolums = 3;
int[,] matriz = new int[qline, qcolums];
int[,] matriz2 = new int[qline, qcolums];
int[,] matriz_res = new int[qline, qcolums];

for (int linha = 0; linha < qline; linha++)
{
    for (int coluna = 0; coluna < qcolums; coluna++)
    {
        matriz[linha,coluna] = new Random().Next(1, 11);
        matriz2[linha,coluna] = new Random().Next(1, 11);

    }
}
Console.WriteLine("Vetor 1");
for (int linha = 0; linha < qline; linha++)
{
    for (int coluna = 0; coluna < qcolums; coluna++)
    {
        Console.Write(matriz[linha, coluna] + " ");
    }
    Console.WriteLine();
}
    Console.WriteLine("Vetor 2");
for (int linha = 0; linha < qline; linha++)
{
    for (int coluna = 0; coluna < qcolums; coluna++)
    {
        Console.Write(matriz2[linha, coluna] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("SOMA");
for (int linha = 0; linha < qline; linha++)
{
    for (int coluna = 0; coluna < qcolums; coluna++)
    {
        matriz_res[linha,coluna] = matriz[linha,coluna] + matriz2[linha,coluna];
        Console.Write(matriz_res[linha,coluna] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Subtração");
for (int linha = 0; linha < qline; linha++)
{
    for (int coluna = 0; coluna < qcolums; coluna++)
    {
        matriz_res[linha, coluna] = matriz[linha, coluna] - matriz2[linha, coluna];
        Console.Write(matriz_res[linha, coluna] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Divisão");
for (int linha = 0; linha < qline; linha++)
{
    for (int coluna = 0; coluna < qcolums; coluna++)
    {
        matriz_res[linha, coluna] = matriz[linha, coluna] / matriz2[linha, coluna];
        Console.Write(matriz_res[linha, coluna] + " ");
    }
    Console.WriteLine();
}