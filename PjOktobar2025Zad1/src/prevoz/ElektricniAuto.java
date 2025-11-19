package prevoz;

public class ElektricniAuto extends Auto {

	private int kapacitetBaterije;
	
	public ElektricniAuto(int k, int om, int kb) {
		super(k, om);
		this.kapacitetBaterije=kb;
		//upis u fajl
		String content=this.getKonjaza() + " " + this.getObrtniMoment() + " " + this.getRedniBroj() + " " + this.kapacitetBaterije;
		
		this.upisiUFajl(content);
	}

	public double brutalnost() {
		return getKonjaza() * (getObrtniMoment() + this.kapacitetBaterije);
	}
}
