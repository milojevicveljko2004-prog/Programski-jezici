package prevoz;

public class SUSAuto extends Auto {
	
	public enum Gorivo { Dizel, Benzin }
	
	private Gorivo tipGoriva; //benzin ili dizel
	
	public SUSAuto(int k, int om, Gorivo tg) throws IllegalArgumentException {
		super(k, om);
		
		if(tg==null)
			throw new IllegalArgumentException("Prosledjen tip goriva je null! ");
		
		this.tipGoriva=tg;
		//upis u fajl
		String content=this.getKonjaza() + " " + this.getObrtniMoment() + " " + this.getRedniBroj() + " " + this.tipGoriva;
	
		this.upisiUFajl(content); //try i catch vec postoje unutar ove metode
		
	}

	public double brutalnost() { 
		
		if(this.tipGoriva==Gorivo.Dizel) //obrtni moment povecan za 30%
		{
			return getKonjaza() * (getObrtniMoment() * 1.3);
		}
		else //obrtni moment povecan za 50%
		{
			return getKonjaza() * (getObrtniMoment() * 1.5);
		}
	}
}
