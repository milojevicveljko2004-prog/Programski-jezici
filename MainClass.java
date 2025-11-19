package mainpackage; 

import transport.*;
import java.io.*;

public class MainClass {
	public static void main(String[] args) {
		
		Hangar h=new Hangar(100);
		
		try {
				h.addHangar(new Kamion(20, 100, "vozila.txt"));
				h.addHangar(new Kamion(30, 150, "vozila2.txt"));
				h.addHangar(new Kamion(40, 200, "vozila3.txt"));
				
				h.addHangar(new Avion(70, 10000, "vozila4.txt"));
				h.addHangar(new Avion(60, 15000, "vozila5.txt"));
				h.addHangar(new Avion(50, 20000, "vozila6.txt"));
				
				h.print();
				h.inventar();
		}
		catch(IOException e1)
		{
			System.out.println("Greska: " + e1);
		}
		catch(IllegalStateException e2)
		{
			System.out.println("Greska: " + e2);
		}
		catch(IllegalArgumentException e3)
		{
			System.out.println("Greska: " + e3);
		}
	}
}
