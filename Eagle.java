package moon;

import java.io.*;

public class Eagle implements Comparable<Eagle> {
	
	private int redniBroj;
	private int kapacitet; //u tonama
	
	public Eagle(int rb) {
		this.redniBroj=rb;
	}
	
	public Eagle(int rb, int kap) {
		this.redniBroj=rb;
		this.kapacitet=kap;
	}

	//metoda interfejsa koju moram da implementiram:
	public int compareTo(Eagle o) {
		if(Integer.compare(this.kapacitet, o.kapacitet)==0) //ako su jednaki
			return 0;
		
		if(Integer.compare(this.kapacitet, o.kapacitet)<0) //other je veci, this je manji
			return -1;
		
		return 1; //this je veci, other je manji
	}
	
	public int getRedniBroj() { return this.redniBroj; }
	public int getKapacitet() { return this.kapacitet; }
	
	public void setRedniBroj(int rb) { this.redniBroj=rb; }
	public void setKapacitet(int kap) { this.kapacitet=kap; }
	
	//kapacitet dobija iz fajla, a ime fajla predstavlja redni broj. Redni broj dobija iz konstruktora.
	public void ucitajNosivost() throws IOException {
		String filename=this.redniBroj + ".txt";
		
		FileReader fr=new FileReader(filename);
		BufferedReader br=new BufferedReader(fr);
		
		String line=br.readLine(); //procitaj kapacitet iz fajla
		int kap=Integer.parseInt(line);
		
		setKapacitet(kap);
		br.close();
	}
	
	public void print() {
		System.out.println("Redni broj: " + this.redniBroj + ", kapacitet: " + this.kapacitet);
	}
}
