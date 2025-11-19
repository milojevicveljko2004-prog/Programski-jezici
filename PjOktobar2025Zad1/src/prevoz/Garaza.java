package prevoz;

import java.util.ArrayList;
import java.io.*;

public class Garaza {
	
	private ArrayList<Auto> lista;
	
	public Garaza() { this.lista=new ArrayList<Auto>(); }
	
	public void Add(Auto a) throws IllegalArgumentException {
		if(a==null)
			throw new IllegalArgumentException("Prosledjen auto je null! ");
		
		this.lista.add(a);
	}
	
	public void megatest() throws IllegalStateException, IOException { //brutalnost najbrutalnijeg automobila upisuje u binarnu datoteku bruteforce.bin
		
		double najbrutalniji=nadjiBrutalnostNajbrutalnijeg();
		
		FileOutputStream f=new FileOutputStream("bruteforce.bin");
		BufferedOutputStream b=new BufferedOutputStream(f);
		DataOutputStream d=new DataOutputStream(b);
		
		d.writeDouble(najbrutalniji);
		d.close();
	}
	
	private double nadjiBrutalnostNajbrutalnijeg() throws IllegalStateException {
		if(lista.isEmpty())
			throw new IllegalStateException("Lista je prazna! ");
		
		if(lista.size()==1) //ako lista ima samo jedan element
		{
			return lista.getFirst().brutalnost();
		}
		
		double max=lista.getFirst().brutalnost(); //pretpostavka da je prvi najbrutalniji
		
		for(int i=1; i<lista.size(); i++)
		{
			if(lista.get(i).brutalnost()>max)
			{
				max=lista.get(i).brutalnost();
			}
		}
		
		return max;
	}
}
