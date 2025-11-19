package transport;

import java.util.ArrayList;
import java.util.Collections;
import java.io.*;

public class Hangar {
	
	private int maxKapacitet;
	private ArrayList<PrevoznoSredstvo> listaHangara;
	
	public Hangar() {
		this.maxKapacitet=0;
		this.listaHangara=new ArrayList<>(this.maxKapacitet);
	}
	
	public Hangar(int max) {
		this.maxKapacitet=max;
		this.listaHangara=new ArrayList<>(this.maxKapacitet);
	}
	
	public void addHangar(PrevoznoSredstvo p) throws IllegalStateException {
		if(this.listaHangara.size()>=this.maxKapacitet)
		{
			throw new IllegalStateException("List is full! ");
		}
		
		this.listaHangara.add(p);
	}
	
	//upisuje vrednost najstarijeg i najnovijeg prevoznog sredstva u binarnu datoteku bal.bin
	public void inventar() throws IOException, IllegalStateException {
		sort();
		try {
			FileOutputStream f=new FileOutputStream("bal.bin");
			BufferedOutputStream b=new BufferedOutputStream(f);
			DataOutputStream d=new DataOutputStream(b);
			
			double vrNajstarijeg=this.listaHangara.get(0).vrednost();
			double vrNajnovijeg=this.listaHangara.get(this.listaHangara.size()-1).vrednost();
			
			d.writeDouble(vrNajstarijeg);
			d.writeDouble(vrNajnovijeg);
			d.close();
		}
		catch(Exception e)
		{
			System.out.println("Greska: " + e);
		}
	}
	
	private void sort() throws IllegalStateException { //sortira od najveceg do najmanjeg
		if(this.listaHangara.isEmpty())
		{
			throw new IllegalStateException("List is empty! Can't be sorted! ");
		}
		
		this.listaHangara.sort(Collections.reverseOrder());
	}
	
	public void print() throws IllegalStateException {
		if(this.listaHangara.isEmpty())
			throw new IllegalStateException("List is empty! ");
		
		for(int i=0; i<this.listaHangara.size(); i++)
		{
			this.listaHangara.get(i).print();
		}
	}
}
