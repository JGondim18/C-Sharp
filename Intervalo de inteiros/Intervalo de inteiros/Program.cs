Console.WriteLine("Insira o valor N:");

int N = int.Parse(Console.ReadLine());

Console.WriteLine("Insira o valor X:");

int X = int.Parse(Console.ReadLine());

if (N > X)
{
    Console.WriteLine("O primeiro valor deve ser menor que o segundo!");
    Environment.Exit(0);
}

Console.WriteLine($"Intervalo: {N},{X}");

int IN = 0;
int OUT= 0;

for(int i = 1; i <= N; i++)
{
    Console.WriteLine($"Insira o {i}° valor:");
    int I = int.Parse(Console.ReadLine());

    if(I >= N && I <= X)
    {
        IN++; 
    }
    else{ 
        OUT++; 
    }
}

Console.WriteLine($"{IN} por dentro do intervalo");
Console.WriteLine($"{OUT} por fora do intervalo");
