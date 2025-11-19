package prevoz;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;

public class ElektricniAuto extends Auto implements Comparable<Auto> {

	private int kapacitetBaterije;
	
	public ElektricniAuto(int k, int om, int kap) throws IOException {
		super(k, om); //takodje povecava redniBroj?
		this.kapacitetBaterije=kap;
		upisi();
	}
	
	public void upisi() throws IOException { //upis u tekstualnu datoteku
		String filename=redniBroj + ".txt";
		
		try {
			FileWriter fw=new FileWriter(filename);
			BufferedWriter bw=new BufferedWriter(fw);
			
			bw.write(this.konjaza + " " + this.obrtniMoment + " " + this.kapacitetBaterije + " " + redniBroj);
			bw.newLine();
			bw.close();
		}
		catch(IOException e)
		{
			System.out.println("Greska: " + e);
		}
	}

	public double brutalnost() {
		return (double)(this.konjaza*(this.obrtniMoment+this.kapacitetBaterije));
	}

	public int compareTo(Auto o) {
		if(this.brutalnost()==o.brutalnost()) //jednake konjaze
			return 0;
		else if(this.brutalnost()<o.brutalnost()) //this<other
			return -1;
		
		return 1; //this>other
	}
	
	@Override
	public void print() {
		System.out.println("Elektricni automobil[kapacitet, konjaza, obrtniMoment, rednoBroj]: ");
		System.out.println(this.kapacitetBaterije + " " + this.konjaza + " " + this.obrtniMoment +
				" " + redniBroj);
	}
}
