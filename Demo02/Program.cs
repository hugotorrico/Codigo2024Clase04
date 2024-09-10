
//Crear una función Sumar los primeros n numeros naturales
//1+2+3+4+5+...+n;
int SumarNaturales(int cantidad)
{
	int suma = 0;

	for (int i = 1; i <= cantidad; i++)
	{
		suma = suma + i;
	}
	return suma;
}


//Crear una función Sumar los primeros n numeros pares n=4
//2+4+6+8+10
//2 * (1+2+3+4+...n)
int SumarPares(int cantidad)
{	
    return 2 * SumarNaturales(cantidad);
}

//Crear una función Sumar los primeros n numeros impares n=4
//1+3+5+7=16
int SumarImpares(int cantidad)
{
    int suma = 0;
    int impar = 0;

    for (int i = 1; i <= cantidad; i++)
    {
        impar = 2 * i - 1;   
        suma = suma + impar;
    }
    return suma;
}


void CrearTablaMultiplicar(int numero)
{
    int cantidad = 12;
    int i = 1;
    while (i<=12)
    {
        Console.WriteLine(numero + " X " + i + " = " + numero * i);
        i = i + 1;
    }
}
void CrearTablaMultiplicarReves(int numero)
{ 
    int i = 12;
    while (i > 0)
    {
        Console.WriteLine(numero + " X " + i + " = " + numero * i);
        i--;
    }

}
//Crear una función usando while Sumar los primeros n numeros cuadrados n=5
//1+4+9+16+25
int SumarCuadrados(int cantidad)
{
    int i = 1;
    int suma = 0;
    int cuadrado = 0;
    while (i<=cantidad)
    {
        cuadrado = i * i;        
        suma = suma + cuadrado;
        i++;
    }
    return suma;
}

//Console.WriteLine( SumarCuadrados(3));
//CrearTablaMultiplicar(5);
//CrearTablaMultiplicarReves(5);
//Console.WriteLine( SumarNaturales(5));
//Console.WriteLine(SumarPares(5));
//Console.WriteLine(SumarImpares(20));//16

Console.Read();
