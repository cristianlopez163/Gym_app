public class Program
{
    static void Main()
    {
        empleado emp1 = new empleado(
            "Juan",
            "101000110",
            "JuanQmail.com",
            22,
            1000.0,
            "Jefe de personal"
        );

        Console.WriteLine(emp1.cargo);

        emp1.Sueldo = 1200.35;

        Console.WriteLine(emp1.Sueldo);

        Console.WriteLine("=======================");

        emp1.calcularsueldo("Hola");
        
        Console.WriteLine("=======================");

        emp1.calcularsueldo(0.5);
    }
}