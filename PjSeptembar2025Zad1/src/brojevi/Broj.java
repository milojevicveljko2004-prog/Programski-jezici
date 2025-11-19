package brojevi;

public abstract class Broj implements Comparable<Broj> {
	
	public int compareTo(Broj o) {
		if(this.odrediVrednost()>o.odrediVrednost())
			return 1;
		else if(this.odrediVrednost()==o.odrediVrednost())
			return 0;
		else
			return -1;
	}
	
	public abstract void print();
	
	public abstract Broj saberi(Broj o);
	
	public abstract Broj podeli(int broj);
	
	protected abstract double odrediVrednost();
	
	public double getVrednost() { return this.odrediVrednost(); }
}
