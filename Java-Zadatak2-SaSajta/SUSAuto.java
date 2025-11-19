package prevoz;

import java.io.*;

public class SUSAuto extends Auto implements Comparable<Auto> {
	
	private String tipGoriva; //dizel ili benzin
	
	public SUSAuto(int k, int om, String tip) throws IOException, IllegalArgumentException {
		super(k, om); 
		
		if(tip!="benzin" && tip!="dizel")
			throw new IllegalArgumentException("tip mora biti dizel ili benzin! ");
		
		this.tipGoriva=tip;
		upisi();
	}
	
	public void upisi() throws IOException { //upis u tekstualnu datoteku
		String filename=redniBroj + ".txt";
		
		try {
			FileWriter fw=new FileWriter(filename);
			BufferedWriter bw=new BufferedWriter(fw);
			
			bw.write(this.konjaza + " " + this.obrtniMoment + " " + this.tipGoriva + " " + redniBroj);
			bw.newLine();
			bw.close();
		}
		catch(IOException e)
		{
			System.out.println("Greska: " + e);
		}
	}

	public int compareTo(Auto o) {
		if(this.brutalnost()==o.brutalnost()) //jednake konjaze
			return 0;
		else if(this.brutalnost()<o.brutalnost()) //this<other
			return -1;
		
		return 1; //this>other
	}

	public double brutalnost() {
		double povOm;
		if("dizel".equals(this.tipGoriva)) //dizel
			povOm=this.obrtniMoment*1.3; //obrtni moment povecan za 30%
		else //benzin
			povOm=this.obrtniMoment*1.5; //povecan za 50%
		
		return (double)this.konjaza*povOm;
	}
	
	@Override
	public void print() {
		System.out.println("SUS automobil[tipGoriva, konjaza, obrtniMoment, rednoBroj]: ");
		System.out.println(this.tipGoriva + " " + this.konjaza + " " + this.obrtniMoment +
				" " + redniBroj);
	}
	
}
