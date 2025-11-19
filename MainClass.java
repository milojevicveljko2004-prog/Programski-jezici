package mainpackage; //Zadatak radi!

import moon.*;
import emergency.LowCapasity;

public class MainClass {
	public static void main(String[] args) {
		
		MoonBaseAlpha base=new MoonBaseAlpha(1000);
		
		Eagle e1=new Eagle(101);
		Eagle e2=new Eagle(102);
		Eagle e3=new Eagle(103);
		Eagle e4=new Eagle(104);
		Eagle e5=new Eagle(105);
		Eagle e6=new Eagle(106);
		
		try {
			e1.ucitajNosivost();
			e2.ucitajNosivost();
			e3.ucitajNosivost();
			e4.ucitajNosivost();
			e5.ucitajNosivost();
			e6.ucitajNosivost();
			
			base.addEagle(e1);
			base.addEagle(e2);
			base.addEagle(e3);
			base.addEagle(e4);
			base.addEagle(e5);
			base.addEagle(e6);
			
			System.out.println("Ispis cele baze: ");
			base.print();
			
			base.uzbuna();
			
			System.out.println("Nakon uzbune: ");
			base.print();
			
		}
		catch(Exception e)
		{
			System.out.println("Greska: " + e);
		}
	}
}
