package prevoz;

import java.util.ArrayList;
import java.io.*;

public class Garaza {
	
	private ArrayList<Auto> automobili;
	
	public Garaza() {
		this.automobili=new ArrayList<>();
	}
	
	public void addCar(Auto a) throws IllegalArgumentException {
		if (a == null) throw new IllegalArgumentException("Metoda addCar, prosledio si null! ");
		automobili.add(a);
	}
	
	private Auto getNajbrutalniji() throws IllegalStateException {
		
		if(automobili.size()==0)
			throw new IllegalStateException("list is empty! ");
		
		//pretpostavka da je prvi najbrutalniji
		Auto najbrutalniji=automobili.get(0);
		
		if(automobili.size()==1) //ako je jedini u listi, on je istovremeno najbrutalniji
			return najbrutalniji;
		
		for(int i=1; i<automobili.size(); i++)
		{
			if(automobili.get(i).brutalnost()>najbrutalniji.brutalnost())
			{
				najbrutalniji=automobili.get(i);
			}
		}
		
		return najbrutalniji;
	}
	
	//brutalnost najbrutalnijeg automobila upisuje u binarnu datoteku
	public void megatest() throws IOException { 
		Auto a=getNajbrutalniji();
		
		try {
			FileOutputStream f=new FileOutputStream("bruteforce.bin");
			BufferedOutputStream b=new BufferedOutputStream(f);
			DataOutputStream d=new DataOutputStream(b);
			
			d.writeDouble(a.brutalnost());
			d.close();
		}
		catch(IOException e)
		{
			System.out.println("Greska: " + e);
		}
	}
	
	public void print() {
		for(int i=0; i<automobili.size(); i++)
		{
		    automobili.get(i).print();
		}
	}
}
