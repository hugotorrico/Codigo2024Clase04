
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

//Console.WriteLine( SumarNaturales(5));
//Console.WriteLine(SumarPares(5));
Console.WriteLine(SumarImpares(20));//16

Console.Read();
