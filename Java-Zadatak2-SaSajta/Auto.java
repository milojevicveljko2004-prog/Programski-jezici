package prevoz;

public abstract class Auto {
	
	protected int konjaza;
	protected int obrtniMoment;
	protected static int redniBroj=0;
	
	public Auto(int k, int om) {
		this.konjaza=k;
		this.obrtniMoment=om;
		redniBroj++;
	}

	public abstract double brutalnost();
	public abstract void print();

}
