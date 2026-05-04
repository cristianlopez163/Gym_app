public class persona
{
    protected string nombre;
    protected string documento; 
    protected string correo;
    private int edad;
    public int Edad
    {
        get { return edad;}
        set
        {
            if(value >= 0 && value <= 110)
            {
                edad = value;
            } else{
                Console.WriteLine("Error.. La edad debe estar entre 0-110");
            }
        }
    }

    public persona
    (
        string nombre,
        string documento,
        string correo,
        int edad
    )
    {
        this.nombre = nombre;
        this.documento = documento;
        this.correo = correo;
        this.edad = edad;
    }

    public virtual void MostrarInfo()
    {
        Console.WriteLine("======================");
        Console.WriteLine("Nombre: " + this.nombre);
        Console.WriteLine("documento: " + this.documento);
        Console.WriteLine("correo: " + this.correo);
        Console.WriteLine("edad: " + this.edad);
    }
}