package brojevi;

public class KompleksanBroj extends Broj { //a+ib

	private int a;
	private int b;
	
	public int getReal() { return this.a; }
	public int getImag() { return this.b; }
	
	public KompleksanBroj(int a, int b)
	{
//		if(b==0)
//			throw new IllegalArgumentException("Zabranjeno je deljenje nulom! ");
		
		this.a=a;
		this.b=b;
	}

	@Override
	public void print() {
		System.out.println(this.a + " + i * " + this.b);
	}

	@Override
	public Broj saberi(Broj o) throws IllegalArgumentException {
		if(o instanceof RacionalanBroj r)
		{
			int real = (int)r.odrediVrednost() + this.a;
			return new KompleksanBroj(real, this.b);
		}
		else if(o instanceof KompleksanBroj k)
		{
			int real = this.a + k.getReal();
			int imag = this.a + k.getImag();
			return new KompleksanBroj(real, imag);
		}
		else
		{
			throw new IllegalArgumentException("Nepoznat broj prosledjen metodi saberi! ");
		}
	}

	public Broj podeli(int broj) {
		if(broj==0)
			throw new IllegalArgumentException("Zabranjeno je deljenje nulom! ");
		
		int a= this.a/broj;
		int b = this.b/broj;
		return new KompleksanBroj(a, b);
	}

	protected double odrediVrednost() {
		return (double)Math.sqrt(this.a*this.a + this.b*this.b);
	}
	
	public String toString()
	{
		return this.a + " + i * " + this.b;
	}
}
