Usuario u = new Usuario();
u.Contrasena = "12345678";
Console.WriteLine(u.Contrasena);

class Usuario
{
    private string contrasena;
    
    public string Contrasena
    {
        get
        {
            if (contrasena.Length >= 8)
            {
                return "****";
            }
            else
            {
                return "Contraseña insegura";
            }
        }
        set
        {
            contrasena = value;
        }
    }
}