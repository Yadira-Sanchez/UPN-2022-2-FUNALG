// 3. Diseñar un programa que imprima una tabla de m filas por n columnas y un caracter fijado.
// El usuario debe ingresar “m”, “n” y el caracter.

int f, c;
string n;

Console.Write("Ingrese numero de filas: ");

f = int.Parse(Console.ReadLine());
Console.Write("Ingrese numero de columnas: ");

c = int.Parse(Console.ReadLine());
Console.Write("Ingrese el numero a mostar: ");

n = (Console.ReadLine());

for (int i = 0; i < c; i++)
{
    for (int j = 0; j < f; j++)
    {
        Console.Write("" + n + "");
    }
    Console.Write("\n");
}
