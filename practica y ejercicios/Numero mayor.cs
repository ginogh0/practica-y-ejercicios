string repetir = "s";

while (repetir == "s")
{
    Console.WriteLine("===== Ingrese dos numeros enteros: =====");

    int numero = Convert.ToInt32(Console.ReadLine());
    int numero2 = Convert.ToInt32(Console.ReadLine());

    if (numero < numero2)
    {
        Console.WriteLine("El numero " + numero + " es menor que el numero " + numero2);
    }
    else if (numero > numero2)
    {
        Console.WriteLine("El numero " + numero + " es mayor que el numero " + numero2);
    }
    else
    {
        Console.WriteLine("Los numeros son iguales");
    }

    Console.WriteLine("¿Querés repetir? (s/n)");
    repetir = Console.ReadLine();
    if (repetir != "s")
    {
        Console.WriteLine("====== Fin del programa ======");
    }
}















Console.ReadKey();