package brojevi;

public class RacionalanBroj extends Broj { //oblika a/b

	private int a;
	private int b;
	
	
	public RacionalanBroj(int a, int b) throws IllegalArgumentException
	{
		if(b==0)
			throw new IllegalArgumentException("Zabranjeno je deljenje nulom! ");
		
		this.a=a;
		this.b=b;
	}

	public void print() {
		System.out.println(this.a + "/" + this.b);
	}

	//mogu da se sabiraju i kompleksan i racionalan broj
	public Broj saberi(Broj o) throws IllegalArgumentException {
		if(o instanceof RacionalanBroj r) //ako je o racionalan broj
		{
			int a=this.a * r.b + this.b + r.a;
			int b = this.b * r.b;
			return new RacionalanBroj(a, b);
		}
		else if(o instanceof KompleksanBroj k)
		{
			int real = (int)this.odrediVrednost() + k.getReal();
			return new KompleksanBroj(real, k.getImag());
		}
		else
		{
			throw new IllegalArgumentException("Nepoznat broj prosledjen metodi saberi! ");
		}
	}

	public Broj podeli(int broj) throws IllegalArgumentException {
		if(broj==0)
			throw new IllegalArgumentException("Zabranjeno je deljenje nulom! ");
		
		int b=this.b*broj;
		return new RacionalanBroj(this.a, b);
	}

	protected double odrediVrednost() {
		return (double)this.a/this.b;
	}
	
	public String toString()
	{
		return this.a + "/" + this.b;
	}
}
