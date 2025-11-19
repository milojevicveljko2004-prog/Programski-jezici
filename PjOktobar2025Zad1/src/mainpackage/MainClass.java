package mainpackage;

import prevoz.*;
import prevoz.SUSAuto.Gorivo;
import java.io.*;

public class MainClass { 
	public static void main(String[] args) {
		
		try {
		
			Garaza g=new Garaza();
			
			g.Add(new SUSAuto(500, 1000, Gorivo.Dizel));
			g.Add(new SUSAuto(700, 1800, Gorivo.Benzin));
			g.Add(new ElektricniAuto(700, 1800, 190));
			g.Add(new ElektricniAuto(1200, 910, 400));
			
			g.megatest();
		}
		catch(IllegalStateException e1)
		{
			System.out.println("Greska: " + e1);
		}
		catch(IOException e2)
		{
			System.out.println("Greska: " + e2);
		}
		catch(IllegalArgumentException e3)
		{
			System.out.println("Greska: " + e3);
		}
	}
}
