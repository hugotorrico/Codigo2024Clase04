// See https://aka.ms/new-console-template for more information


double CalcularDistancia(double x1, double y1, double x2, double y2)
{
    double valor1 = Math.Pow(x2 - x1, 2);
    double valor2 = Math.Pow(y2 - y1, 2);
    double distancia = Math.Sqrt(valor1 + valor2);
    return distancia;
}


//Función
int Sumar(int a, int b)
{
    return a + b;
}

//Procedimiento
void Restar(int a, int b)
{
    Console.WriteLine(a-b);
}

double x1=0;
double y1=0;
double x2=4;
double y2 = 0;
double x3 = 4;
double y3 = 6;
double x4= 0;
double y4 = 6;


double base1 = CalcularDistancia(x1, y1, x2, y2);
Console.WriteLine("La base es : ");
Console.WriteLine(base1);

double altura = CalcularDistancia(x2, y2, x3, y3);
Console.WriteLine("La altura es : ");
Console.WriteLine(altura);


Console.Read();