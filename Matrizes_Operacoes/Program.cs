
int qtdlinhas= 0, qtdcolunas = 0;
void Parametros(int x, int y)
{
    do
    {
        Console.WriteLine("Digite o tamanho de linhas");
        qtdlinhas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o tamanho de colunas");
        qtdcolunas = int.Parse(Console.ReadLine());
    } while (qtdcolunas == 0 || qtdlinhas == 0);
}
Parametros(qtdlinhas, qtdcolunas);
float[,] matriz1 = new float[qtdlinhas, qtdcolunas];
float[,] matriz2 = new float[qtdlinhas, qtdcolunas];
float[,] matriz3 = new float[qtdlinhas, qtdcolunas];
int opcao = 0;
float[,] sortear()
{
    float[,] matrizresultante = new float[qtdlinhas, qtdcolunas];
    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            matrizresultante[linha, coluna] = new Random().Next(0, 10);
        }
    }
    return matrizresultante;
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
void Somar_Matriz(float[,]matriz, float[,] matriz2)
{
    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            matriz3[linha, coluna] = matriz[linha, coluna] + matriz2[linha, coluna];
        }
    }
    ImprimirMatriz(matriz3, "Matriz Somada");
}
void Subtrair_Matriz(float[,]matriz, float[,] matriz2)
{
    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            matriz3[linha, coluna] = matriz[linha, coluna] - matriz2[linha, coluna];
        }
    }
    ImprimirMatriz(matriz3, "Matriz Subtraida");
}void Multiplicar_Matriz(float[,]matriz, float[,] matriz2)
{
    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            matriz3[linha, coluna] = matriz[linha, coluna] * matriz2[linha, coluna];
        }
    }
    ImprimirMatriz(matriz3, "Matriz Multiplicada");
}

void Dividir_Matriz(float[,]matriz, float[,] matriz2)
{
    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            if (matriz2[linha, coluna] != 0)
                matriz3[linha, coluna] = matriz[linha, coluna] / matriz2[linha, coluna];
            else
                matriz3[linha, coluna] = float.NaN;
        }
    } 
    ImprimirMatriz(matriz3, "Matriz Dividida");
}
int Menu_Usuario() 
{
    int escolha;
    Console.WriteLine("Escolha uma operação:\n[1]SOMA\n[2]SUBTRAÇÃO\n[3]MULTIPLICAÇÃO\n[4]DIVISÃO\n[5]SAIR");
    escolha = int.Parse(Console.ReadLine());


    return escolha;
}
ImprimirMatriz(matriz1, "matriz 1");
matriz1 = sortear();
ImprimirMatriz(matriz2, "matriz 2");
matriz2 = sortear();
do
{   
    opcao = Menu_Usuario();
    switch (opcao)
    {
        case 1:
            Somar_Matriz(matriz1, matriz2);
            break;
        case 2:
           
            Subtrair_Matriz(matriz1, matriz2);
            break;
        case 3:
           
            Multiplicar_Matriz(matriz1, matriz2);
            break;
        case 4:
            Dividir_Matriz (matriz1, matriz2);
            break;
        case 5:
            break;
        default: break;
    }
  
} while (opcao != 5);





