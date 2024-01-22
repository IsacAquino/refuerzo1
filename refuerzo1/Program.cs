// See https://aka.ms/new-console-template for more information
Console.Write("Ingrese un número del 0 al 255: ");

string ingresar = Console.ReadLine();
int numero = int.Parse(ingresar);

Console.WriteLine($"Esta es la tabla del número {numero}: ");

for (int i = 0; i <= 12; i++)
{
    int resultado = numero * i;
    Console.WriteLine($"{i} x {numero} = {resultado}");
}

