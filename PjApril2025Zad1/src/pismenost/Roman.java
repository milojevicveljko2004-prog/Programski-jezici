package pismenost;

import java.io.*;

public class Roman extends Knjiga {
	
	public Roman(String n, int brs) throws IllegalArgumentException, IOException
	{
		super(n, brs);
		
		//upis u tekstualni fajl
		
		String filename = this.naslov + ".txt";
		
		FileWriter fw=new FileWriter(filename);
		BufferedWriter bw=new BufferedWriter(fw);
		
		bw.write(this.brStrana + " "); //upisuje samo broj strana, po tekstu zadatka
		bw.close();
	}

	public int vremeCitanja() {
		return this.brStrana * 5; //u minutima, dakle broj strana po minutu
	}
}
