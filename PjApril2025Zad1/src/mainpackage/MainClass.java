package mainpackage;

import java.io.*;
import pismenost.*;

public class MainClass { 
	public static void main(String[] args) {
		
		try {
			
			Biblioteka b = new Biblioteka();
			
			b.Add(new Roman("RomeoAndJuliet", 500));
			b.Add(new Roman("AsterixAndObelix", 450));
			b.Add(new Roman("CaptainOW", 350));
			b.Add(new Udzbenik("History", 370, false));
			b.Add(new Udzbenik("Math", 480, true));
			b.Add(new Udzbenik("Java Programming", 570, true));
			
			Knjiga k=b.getKnjigaKojaSeCitaNajduze();
			
			double vremeCitanja = k.vremeCitanja(); //ovo treba zapisati u binarni fajl
			
			FileOutputStream f=new FileOutputStream("citanje.bin");
			BufferedOutputStream bos=new BufferedOutputStream(f);
			DataOutputStream d=new DataOutputStream(bos);
			
			d.writeDouble(vremeCitanja);
			d.close();
			
			System.out.println("Najduze vreme citanja je: " + vremeCitanja);
			
		}
		catch(IOException e1)
		{
			System.out.println("Gresk: " + e1);
		}
		catch(IllegalStateException e2)
		{
			System.out.println("Gresk: " + e2);
		}
		catch(IllegalArgumentException e3)
		{
			System.out.println("Gresk: " + e3);
		}
	}
}
