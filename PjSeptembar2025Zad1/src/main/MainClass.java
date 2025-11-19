package main;

import java.util.*;
import brojevi.*;
import java.io.*;

public class MainClass { // Ovo je ipak rok Jun 2025.
	
	public static void main(String[] args) {
	
		try {
			ArrayList<Broj> lista=new ArrayList<Broj>();
			Random rnd=new Random();
			
			for(int i=0; i<10; i++)
			{
				if(i%2==0) //parna pozicija
				{
					int a = rnd.nextInt(101); //od 0 do 100
					int b = rnd.nextInt(100) + 1; //bilo je od 0 do 99 ali zbog +1 je od 1 do 100
					lista.add(new RacionalanBroj(a, b));
				}
				else //neparna
				{
					int a = rnd.nextInt(101);
					int b=rnd.nextInt(101);
					lista.add(new KompleksanBroj(a, b));
				}
			}
			
			Collections.sort(lista);
			
			//snimanje u tekstualni fajl
			
			FileWriter fw=new FileWriter("brojevi.txt");
			BufferedWriter bw=new BufferedWriter(fw);
			
			for(Broj b : lista)
			{
				bw.write(b.toString());
				bw.newLine();
			}
			
			bw.close();
			
			//aritmeticku sredinu brojeva upisati u binarni fajl
			
			Broj suma = new RacionalanBroj(0, 1);
			
			for(Broj b : lista)
			{
				suma=suma.saberi(b);
			}
			
			suma=suma.podeli(lista.size());
			
			double vrednost = suma.getVrednost(); //ovo trebam da zapisem u binarni fajl
			
			FileOutputStream f=new FileOutputStream("aritmeticka_sredina.bin");
			BufferedOutputStream b = new BufferedOutputStream(f);
			DataOutputStream d = new DataOutputStream(b);
			
			d.writeDouble(vrednost);
			d.close();
			
		}
		catch(IllegalArgumentException e1)
		{
			System.out.println("Greska: " + e1);
		}
		catch(IOException e2)
		{
			System.out.println("Greska: " + e2);
		}
	
	}
}
