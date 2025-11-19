package mainpackage; 

import prevoz.*;
import java.io.*;

public class MainClass {
	public static void main(String[] args) {
		
		Garaza g=new Garaza();
		
		try {
			//SUS automobili
			Auto a1=new SUSAuto(300, 500, "benzin");
			Auto a2=new SUSAuto(450, 700, "dizel");
			Auto a3=new SUSAuto(200, 200, "benzin");
			
			//Elektricni automobili
			Auto a4=new ElektricniAuto(350, 400, 50);
			Auto a5=new ElektricniAuto(100, 100, 70);
			Auto a6=new ElektricniAuto(900, 800, 80);
			
			g.addCar(a1);
			g.addCar(a2);
			g.addCar(a3);
			g.addCar(a4);
			g.addCar(a5);
			g.addCar(a6);
			
			g.print();
			g.megatest();
			
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
