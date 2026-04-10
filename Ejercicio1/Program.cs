CuentaBancaria s = new CuentaBancaria();
s.Saldo = -3;
Console.WriteLine(s.Saldo); 

class CuentaBancaria
{
	private double saldo;

	public	double Saldo
	{
		get 
		{ 
			return saldo; 
		}
		set
		{
			if (value >= 0)
            {
				 saldo = value;

			}
			else
			{
                Console.WriteLine("Saldo no disponible");
			}
     
		}
	}

}