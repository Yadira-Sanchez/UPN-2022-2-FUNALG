// 1. Diseñar un programa para imprimir todos los números primos entre 2 y 100 inclusive.

int dividendo = 2;
int divisor = 1;
int divisiones = 0;

while (dividendo <= 100)
{
    while (dividendo <= 100)
    {
        while (divisor <= dividendo)
        {
            if (dividendo % divisor == 0)
            {
                divisiones++;
            }
            divisor++;
        }

        if (divisiones == 2)
        {
            Console.WriteLine(dividendo);
        }

        dividendo++;
        divisor = 1;
        divisiones = 0;
    }
}
