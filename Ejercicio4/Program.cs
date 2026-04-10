Empleado e = new Empleado();
e.Salario = 2000;
Console.WriteLine(e.Salario);

class Empleado
{
    private double salario;

    public double Salario
    {
        get
        {
            return salario;
        }
        set
        {
            if (value >= 5000)
            {
                salario = value;

            }
            else
            {
                Console.WriteLine("Salario invalido");
            }

        }
    }
}