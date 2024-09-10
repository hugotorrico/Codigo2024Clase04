// See https://aka.ms/new-console-template for more information


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

int SumarPares(int cantidad)
{
	return 0;

}
int SumarImparesPares(int cantidad)
{
    return 0;
}
//Crear una función Sumar los primeros n numeros impares n=4
//1+3+5+7

//Crear una función Sumar los primeros n numeros pares n=4
//2+4+6+8


//1+2+3+4=10
Console.WriteLine( SumarNaturales(5));





Console.Read();
