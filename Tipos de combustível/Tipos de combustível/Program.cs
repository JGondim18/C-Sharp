int Alcool = 1;
int Gasolina = 2;
int Diesel = 3;
int Fim = 4;
int combustível= int.Parse(Console.ReadLine()); 


while(combustível != 4 )
{
    string input = Console.ReadLine();
    if (int.TryParse(input, out combustível))

        if (combustível == Alcool)
    {
        Console.WriteLine($"Alcool: {Alcool}");
    }
    else if(combustível == Gasolina)
    {
        Console.WriteLine($"Gasolina: {Gasolina}");
    }
    else if(combustível==Diesel)
    {
        Console.WriteLine($"Diesel: {Diesel}");
    }
    else if(combustível == Fim)
    {
        break;
    }
    else
    {
        Console.WriteLine("MUITO OBRIGADO");
    }
    
}