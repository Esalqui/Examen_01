void opcion1()
{
    int numero = 0;
    Console.Write("Ingrese un número: ");
    numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("El número es: " + esPositivoNegativoCero(numero));
}
void opcion3()
{
    Console.Write("La suma de los 100 primeros números naturales es: " + suma100Naturales());
    Console.ReadLine();
}
void opcion4()
{
    int numero = 0;
    Console.Write("Ingrese un número: ");
    numero = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= numero; i++)
        Console.WriteLine(i);
    Console.ReadLine();
}
void opcion5()
{
    double radio = 0.0;
    Console.Write("Ingrese Radio del círculo: ");
    radio = Convert.ToDouble(Console.ReadLine());
    Console.Write("El área del círculo es: " + areaCirculo(radio));
    Console.ReadLine();
}
void opcion6()
{
    int[] arregloUnidimensional = { 1, 5, 12, 18, 20, 16, 14, 11, 8 };
    for (int i = 0; i < arregloUnidimensional.Length; i++)
        Console.WriteLine(arregloUnidimensional[i]);
    Console.ReadLine();
}
void opcion7()
{
    List<string> nombres = ["Eduardo", "Jorge", "Pedro", "José", "Alex"];
    foreach (var nombre in nombres)
    {
        Console.WriteLine($"Alumno: {nombre}");
    }
    Console.ReadLine();
}

void diaSemana()
{
    int dia = 0;
    string diaSemana = "";
    do
    {
        Console.Clear();
        Console.Write("Ingrese el día de la semana (1 a 7): ");
        dia = Convert.ToInt32(Console.ReadLine());
    } while (dia < 1 || dia > 7);
    switch (dia)
    {
        case 1:
            diaSemana = "Lunes";
            break;
        case 2:
            diaSemana = "Martes";
            break;
        case 3:
            diaSemana = "Miércoles";
            break;
        case 4:
            diaSemana = "Jueves";
            break;
        case 5:
            diaSemana = "Viernes";
            break;
        case 6:
            diaSemana = "Sábado";
            break;
        case 7:
            diaSemana = "Domingo";
            break;
    }
    Console.WriteLine("Es un día: " + diaSemana);
    Console.ReadLine();
}
double areaCirculo(double radio)
{
    const double pi = 3.1416;
    double area = 0.0;
    area = pi * Math.Pow(radio, 2);
    return area;
}
string esPositivoNegativoCero(int numero)
{
    string condicion = "";
    if (numero > 0)
        condicion = "Positivo";
    else
        if (numero < 0)
        condicion = "Negativo";
    else
        condicion = "Cero";

    return condicion;
}
int suma100Naturales()
{
    int suma = 0;
    for (int i = 1; i <= 100; i++)
        suma += i;
    return suma;
}
int opcion = 0;
do
{
    Console.Clear();
    Console.WriteLine("------- MENU -------");
    Console.WriteLine("1] Determinar si es positivo, Negativo o Cero");
    Console.WriteLine("2] Imprimir mensaje según día de la semana");
    Console.WriteLine("3] Calcular la suma de los primeros 100 números naturales");
    Console.WriteLine("4] Imprimir números de 1 a n");
    Console.WriteLine("5] Calcular el Área de un Círculo");
    Console.WriteLine("6] Mostrar elementos de Arreglo Unidimensional");
    Console.WriteLine("7] Mostra nombres de personas de un Lista");
    Console.WriteLine("8] SALIR");
    Console.Write("Ingrese una opción de 1 a 8: ");
    opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            opcion1();
            Console.ReadLine();
            break;
        case 2:
            diaSemana();
            break;
        case 3:
            opcion3();
            break;
        case 4:
            opcion4();
            break;
        case 5:
            opcion5();
            break;
        case 6:
            opcion6();
            break;
        case 7:
            opcion7();
            break;
        case 8:
            break;
        default:
            Console.WriteLine("Opción inválida. Elija una opción entre 1 y 8");
            Console.ReadLine();
            break;
    }
}
while (opcion != 8);
Console.WriteLine("Gracias por utilizar este programa");
Console.ReadLine();