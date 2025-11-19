package transport;

public abstract class PrevoznoSredstvo {
	
	protected int starost;
	protected double stanje; //slucajan broj izmedju 0 i 1
	
	public PrevoznoSredstvo(int s) {
		this.starost=s;
		this.stanje=Math.random();
	}
	
	public PrevoznoSredstvo(int s, double st) throws IllegalArgumentException {
		if(st<0 || st>1)
			throw new IllegalArgumentException("stanje mora biti izmedju 0 i 1! ");
		
		this.starost=s;
		this.stanje=st;
	}
	
	public int getStarost() { return this.starost; }
	
	public abstract double vrednost();
	public abstract void print();
}
