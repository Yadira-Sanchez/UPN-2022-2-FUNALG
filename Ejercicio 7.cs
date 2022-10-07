// 7. Diseñar un programa para buscar y escribir la primera vocal leída del teclado.
// (Se supone que se leen, uno a uno, caracteres desde el teclado.)

char caracter;
do
{
    Console.Write("INGRESE UNA LETRA: ");
    caracter = char.Parse(Console.ReadLine());
}
while (caracter != 'a' && caracter != 'e' && caracter != 'i' && caracter != 'o' && caracter != 'u' && caracter != 'A');


Console.WriteLine("LA PRIMERA VOCAL INGRESADA ES: " + caracter);
