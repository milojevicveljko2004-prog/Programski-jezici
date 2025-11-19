package moon;

import java.util.ArrayList;
import java.io.*;
import java.util.Collections;
import emergency.LowCapasity;

public class MoonBaseAlpha {
	
	private ArrayList<Eagle> letelice;
	private int brMestaZaLetelice;
	
	public MoonBaseAlpha() {
		this.brMestaZaLetelice=0;
		letelice=new ArrayList<>();
	}
	
	public MoonBaseAlpha(int broj) {
		this.brMestaZaLetelice=broj;
		this.letelice=new ArrayList<>(this.brMestaZaLetelice);
	}
	
	public int getBrLetelica() { return this.brMestaZaLetelice; }
	public void setBrLetelica(int br) { this.brMestaZaLetelice=br; }
	
	public void addEagle(Eagle e) throws IllegalStateException, IllegalArgumentException {
		if(letelice.size()>=this.brMestaZaLetelice)
			throw new IllegalStateException("list is full! ");
		
		if(e==null)
			throw new IllegalArgumentException("Prosledjen Eagle je null! ");
		
		letelice.add(e);
	}
	
	private void sortirajPoNosivosti() //od najveceg do najmanjeg
	{
		this.letelice.sort(Collections.reverseOrder());
	}
	
	public void uzbuna() throws IOException, LowCapasity, IllegalStateException {
		sortirajPoNosivosti();
		
		if(letelice.size() < 3)
			throw new IllegalStateException("Nedovoljan broj letelica za zapis u fajl! ");
		
		//tri najprostranija Eagle
		Eagle e1=this.letelice.get(0);
		Eagle e2=this.letelice.get(1);
		Eagle e3=this.letelice.get(2);
		
		if(e1.getKapacitet()<100)
		{
			throw new LowCapasity("Kapacitet najprostranijeg Eagle-a ne sme biti manji od 100 tona! ");
		}
		
		//redni brojevi koji trebaju biti zapisani u binarni fajl eagle.bin
		int rb1=e1.getRedniBroj();
		int rb2=e2.getRedniBroj();
		int rb3=e3.getRedniBroj();
		
		FileOutputStream f=new FileOutputStream("eagle.bin");
		BufferedOutputStream b=new BufferedOutputStream(f);
		DataOutputStream d=new DataOutputStream(b);
		
		d.writeInt(rb1);
		d.writeInt(rb2);
		d.writeInt(rb3);
		
		d.close();
	}
	
	public void print() {
		System.out.println("Max Broj letelica: " + this.brMestaZaLetelice);
		System.out.println("Trenutni broj letelica: " + letelice.size());
		for(int i=0; i<letelice.size(); i++)
		{
			letelice.get(i).print();
		}
	}
}
