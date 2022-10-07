// 9. Diseñar un programa para leer sucesivamente números del teclado hasta que aparezca un número comprendido entre 1 y 5.

int num;
do
{
    Console.Write("\t\tINGRESE UN NUMERO: ");
    num = int.Parse(Console.ReadLine());
} while (num <= 1 || num >= 5);
