
Console.WriteLine("Bem vindo! Digite quantos valores deseja testar:");
int contador = int.Parse(Console.ReadLine());

int quantidadePositivos = 0;
int quantidadeNegativos = 0;
int quantidadePares = 0;
int quantidadeImpares = 0;

for (int i = 1; i <= 5; i++) 
{
    Console.Write($"Digite o {i}º valor: ");
    float valor = float.Parse(Console.ReadLine());

        if (valor > 0)
    {
        quantidadePositivos++;
    }
    else if(valor< 0)
    {
        quantidadeNegativos++;
    }
        if(valor % 2==0)
    { 
        quantidadePares++; 
    }  
    else { 
        quantidadeImpares++; 
    }
}

Console.WriteLine($"{quantidadePositivos} valor(es) positivo(s)");
Console.WriteLine($"{quantidadeNegativos} valor(es) negativo(s)");
Console.WriteLine($"{quantidadePares} valor(es) par(es)");
Console.WriteLine($"{quantidadeImpares} valor(es) impar(es)");
Console.WriteLine($"{quantidadePositivos} valor(es) positivo(s)");
