//6. Diseñar un programa para leer una serie de números hasta obtener un número superior a 100.

int numero;
do
{
    Console.Write("INGRESE UN NUMERO SEGUID0 DE ENTER: ");
    numero = int.Parse(Console.ReadLine());
}

while (numero <= 100);

Console.Write("ERROR!!! NUMERO FUERA DE RANGO: ");
