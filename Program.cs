// 8. Diseñar un programa que permita escribir en una pantalla la frase
// “¿Desea continuar? S/N” hasta que la respuesta sea 'N'

string caracter;
do
{
    Console.Write("¿DESEA CONTINUAR? S/N: ");
    caracter = Console.ReadLine();
}
while (caracter != "N");