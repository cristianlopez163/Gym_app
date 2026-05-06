public class empleado : persona
{
    private double sueldo;
    public string cargo;
    public double Sueldo
    {
        get { return sueldo;}
        set
        {
            if(value >= 0)
            {
                sueldo = value;
            }else{
                Console.WriteLine("Error.. El sueldo debe ser positivo");
            }
        }
    }

    public empleado
    (
        string nombre,
        string documento,
        string correo,
        int edad,
        double sueldo,
        string cargo
    )
    :base(nombre, documento, correo, edad)
    {
        this.sueldo = sueldo;
        this.cargo = cargo;
    }

    public void calcularsueldo(string tipo)
    {
        Console.WriteLine(this.sueldo);
    }
    public void calcularsueldo(double descuento)
    {
        Console.WriteLine(this.sueldo * descuento);
    }

    
}