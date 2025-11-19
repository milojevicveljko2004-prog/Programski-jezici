package transport;

import java.io.*;

public class Kamion extends PrevoznoSredstvo implements Comparable<PrevoznoSredstvo> {
	
	private int nosivost;
	
	public Kamion(int starost, double stanje, int nosivost, String filename) throws IOException, IllegalArgumentException {
		super(starost, stanje);
		this.nosivost=nosivost;
		upisi(filename);
	}
	
	public Kamion(int starost, int nosivost, String filename) throws IOException {
		super(starost);
		this.nosivost=nosivost;
		upisi(filename);
	}
	
	private void upisi(String filename) throws IOException { //upisuje podatke u tekstualnu datoteku
		try {
			FileWriter fw=new FileWriter(filename);
			BufferedWriter bw=new BufferedWriter(fw);
			
			bw.write(this.starost + " " + this.stanje + " " + this.nosivost);
			bw.newLine();
			bw.close();
		}
		catch(Exception e)
		{
			System.out.println("Greska: " + e);
		}
	}

	public double vrednost() {
		return (this.nosivost*10-this.starost)*this.stanje;
	}

	public int compareTo(PrevoznoSredstvo o) {
		if(this.starost>o.getStarost())
			return 1;
		else if(this.starost==o.getStarost())
			return 0;
		
		return -1;
	}
	
	public void print() {
		System.out.println("KAMION: " + this.nosivost + " " + this.stanje + " " + this.starost);
	}
}
