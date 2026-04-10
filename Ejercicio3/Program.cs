Producto s = new Producto();
s.Precio = 20.5;
Console.WriteLine(s.Precio);

class Producto
{
    private double precio;

    public double Precio
    {
        get
        {
            return precio;
        }
        set
        {
            if (value >= 0)
            {
                precio = value;

            }
            else
            {
                precio = 0;
            }

        }
    }

}