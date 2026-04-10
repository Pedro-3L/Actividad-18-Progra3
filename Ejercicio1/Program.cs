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