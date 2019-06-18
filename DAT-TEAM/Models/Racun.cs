using System;

public class Racun
{
    public int Id { get; }
    public Radnik Narucilac { set; get; }
    public DateTime datumKreiranja { set; get; }
    public List<Proizvod> stavkeRacuna { set; get; }

	public Racun()
	{
	}
}
