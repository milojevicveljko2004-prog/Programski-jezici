package pismenost;

import java.io.*;

public class Udzbenik extends Knjiga {
	
	private boolean imaJednacine;
	
	public Udzbenik(String n, int brs, boolean imaJednacine) throws IllegalArgumentException, IOException
	{
		super(n, brs);
		this.imaJednacine = imaJednacine;
		
		//upis u fajl:
		
		String filename = this.naslov + ".txt";
		
		FileWriter fw=new FileWriter(filename);
		BufferedWriter bw=new BufferedWriter(fw);
		
		bw.write(this.brStrana + " ");
		bw.newLine();
		
		if(this.imaJednacine==true)
			bw.write("ima jednacine");
		else
			bw.write("nema jednacine");
		
		bw.close();
	}

	public int vremeCitanja() {
		
		if(this.imaJednacine==false)
			return this.brStrana * 20;
		else
			return this.brStrana * 120;
	}
}
