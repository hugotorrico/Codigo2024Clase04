
using static System.Runtime.InteropServices.JavaScript.JSType;

void EjemploDoWhile()
{
    int valor = 0;
    do
    {
        valor++;
        Console.WriteLine(valor);

    } while (valor<12);
}


void LeerNumeroPositivo()
{

    int numero = 0;
    do
    {
        Console.Write("Ingresa un número positivo: ");
        numero = Convert.ToInt32(Console.ReadLine());

    } while (numero <= 0);

    Console.WriteLine("Has ingresado el número positivo: " + numero);
}


//Las nota debe estar entre 0 y 20 
//ingresas una nota correcta, debe decir su nota es : nota
//ingresas una nota incorrecta, debes volver a pedir la nota
void LeerNota()
{

}
    LeerNumeroPositivo();





//int numero, numero2;
//Console.Write("Ingresa un número: ");
//numero = Convert.ToInt32(Console.ReadLine());

//Console.Write("Ingresa un número 2: ");
//numero2 = Convert.ToInt32(Console.ReadLine());

//Console.Write("La Suma de los números es : ");
//Console.WriteLine(numero +numero2);



Console.Read();

