// 4. Diseñar un programa para calcular la suma de los números naturales,
// comprendidos entre 2 números ingresados por el usuario.


int num1, num2, suma = 0;

Console.WriteLine("INGRESE EL PRIMER NUMERO ");

num1 = int.Parse(Console.ReadLine());
Console.WriteLine("INGRESE EL SEGUNDO NUMERO");

num2 = int.Parse(Console.ReadLine());

for (int i = num1; i <= num2; i++)
{
    suma = suma + i;
}

Console.WriteLine("LA SUMA COMPRENDIDOS ENTRE ESTOS DOS NUMEROS ES: : " + suma);

Console.ReadKey();
