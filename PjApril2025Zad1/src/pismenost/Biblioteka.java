package pismenost;

import java.util.ArrayList;

public class Biblioteka {

	private ArrayList<Knjiga> lista;
	
	public Biblioteka()
	{
		this.lista = new ArrayList<Knjiga>();
	}
	
	public void Add(Knjiga k)
	{
		this.lista.add(k);
	}
	
	public void sort() throws IllegalStateException
	{
		if(lista.size()==0)
			throw new IllegalStateException("Lista je prazna! ");
		
		this.lista.sort(null);
	}
	
	public Knjiga getKnjigaKojaSeCitaNajduze() throws IllegalStateException
	{
		if(lista.size()==0)
			throw new IllegalStateException("Lista je prazna! ");
		
		if(lista.size()==1)
			return lista.getFirst();
		
		Knjiga najduza=lista.getFirst(); //pretpostavka da se prva najduze cita
		
		for(int i=1; i<lista.size(); i++)
		{
			if(lista.get(i).vremeCitanja()>najduza.vremeCitanja())
			{
				najduza = lista.get(i);
			}
		}
		
		return najduza;
	}
}
