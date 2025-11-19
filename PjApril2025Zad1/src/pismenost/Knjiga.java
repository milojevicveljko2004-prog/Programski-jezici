package pismenost;

import java.io.IOException;

public abstract class Knjiga implements Comparable<Knjiga> {
	
	protected String naslov;
	protected int brStrana;
	
	public Knjiga(String n, int brs) throws IllegalArgumentException
	{
		if(brs<0)
			throw new IllegalArgumentException("Broj strana ne moze biti manji od 0! ");
		
		this.naslov=n;
		this.brStrana=brs;
	}
	
	public abstract int vremeCitanja();
	
	public int compareTo(Knjiga o)
	{
		if(this.vremeCitanja()>o.vremeCitanja())
			return 1;
		else if(this.vremeCitanja()==o.vremeCitanja())
			return 0;
		else
			return -1;
	}
}
