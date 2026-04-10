Estudiante s = new Estudiante();
s.Edad = 200;
Console.WriteLine(s.Edad);

class Estudiante
{
    private double edad;

    public double Edad
    {
        get
        {
            return edad;
        }
        set
        {
            if (value >= 0 && value<=100)
            {
                edad = value;

            }
            else
            {
                edad = 0;
            }

        }
    }

}