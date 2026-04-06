Console.WriteLine("====== Introduce tu nota del examen: ======");
int nota = Convert.ToInt32(Console.ReadLine());
if (nota > 6)
{
    Console.WriteLine("Has aprobado el examen");
}
else if (nota < 6 && nota > 4)
{
    Console.WriteLine("Debes repetir el examen");
}
else
{
    Console.WriteLine("Has reprobado el examen");
}
;

Console.ReadKey();