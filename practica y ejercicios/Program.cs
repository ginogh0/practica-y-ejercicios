int numero;
do {
    Console.WriteLine("====== Introduce 0 para salir ======");
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero != 0)
    {
        Console.WriteLine("Numero invalido: " + numero + "\n" + "Intente de nuevo...");
    }
}while(numero != 0);
Console.WriteLine($"Numero valido: {numero}");
Console.WriteLine("====== Haz salido con exito ======");









Console.ReadKey();