package prevoz;

import java.io.*;

public abstract class Auto implements Comparable<Auto> {
	//atributi su privatni jer se tako trazi po tekstu zadatka
	private int konjaza;
	private int obrtniMoment;
	protected static int redniBroj; //mora da bude vidljiv i izvedenim klasama
	
	public Auto(int k, int om) throws IllegalArgumentException {
		if(k<0 || om<0)
			throw new IllegalArgumentException("Pogresni argumenti u konstruktoru Auto! ");
		
		this.konjaza=k;
		this.obrtniMoment=om;
		redniBroj++;
	}
	
	public abstract double brutalnost();
	
	public int compareTo(Auto o) {
		if(this.brutalnost()>o.brutalnost())
			return 1;
		else if(this.brutalnost()==o.brutalnost())
			return 0;
		else
			return -1;
	}
	
	public int getKonjaza() { return this.konjaza; }
	public int getObrtniMoment() { return this.obrtniMoment; }
	public int getRedniBroj() { return this.redniBroj; }
	
	protected void upisiUFajl(String content) //od izvedene klase dobija atribute(content)
	{
		String filename=redniBroj + ".txt";
		try 
		{
			FileWriter fw=new FileWriter(filename);
			BufferedWriter bw=new BufferedWriter(fw);
			
			bw.write(content);
			bw.newLine();
			bw.close();
		}
		catch(IOException e)
		{
			System.out.println("Greska: " + e);
		}
	}
}
