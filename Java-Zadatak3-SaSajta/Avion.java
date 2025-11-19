package transport;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;

public class Avion extends PrevoznoSredstvo implements Comparable<PrevoznoSredstvo> {
	
	private int maxDolet;
	
	public Avion(int starost, double stanje, int maxDolet, String filename) throws IOException, IllegalArgumentException {
		super(starost, stanje);
		this.maxDolet=maxDolet;
		upisi(filename);
	}
	
	public Avion(int starost, int maxDolet, String filename) throws IOException {
		super(starost);
		this.maxDolet=maxDolet;
		upisi(filename);
	}
	
	private void upisi(String filename) throws IOException { //upisuje podatke u tekstualnu datoteku
		try {
			FileWriter fw=new FileWriter(filename);
			BufferedWriter bw=new BufferedWriter(fw);
			
			bw.write(this.starost + " " + this.stanje + " " + this.maxDolet);
			bw.newLine();
			bw.close();
		}
		catch(Exception e)
		{
			System.out.println("Greska: " + e);
		}
	}
	
	public double vrednost() {
		return (this.maxDolet-this.starost*10)*this.stanje;
	}
	
	public int compareTo(PrevoznoSredstvo o) {
		if(this.starost>o.getStarost())
			return 1;
		else if(this.starost==o.getStarost())
			return 0;
		
		return -1;
	}
	
	public void print() {
		System.out.println("AVION: " + this.maxDolet + " " + this.stanje + " " + this.starost);
	}
}
