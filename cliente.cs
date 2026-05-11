public class Cliente : persona
{
    public string Plan;
    public string FechaIngreso;
    public bool Activo;

    public Cliente
    (
        string nombre,
        string documento,
        string correo,
        int edad,
        string plan,
        string fechaIngreso
    ) : base(nombre, documento, correo, edad)
    {
        this.Plan = plan;
        this.FechaIngreso = fechaIngreso;
        this.Activo = true;
    }

    public override void MostrarInfo()
    {
        base.MostrarInfo();

        Console.WriteLine("Plan: " + this.Plan);
        Console.WriteLine("Fecha de ingreso: " + this.FechaIngreso);
        Console.WriteLine("Activo: " + this.Activo);
    }

    public bool TieneMembresia()
    {
        return this.Activo;
    }
}