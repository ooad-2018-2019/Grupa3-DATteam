using System;
using System.Collections.Generic;

public class Racun
{
    public int Id { get; }
    public DATteam.Models.Radnik Narucilac { set; get; }
    public DateTime datumKreiranja { set; get; }
    public List<Proizvod> stavkeRacuna { set; get; }

	public Racun()
	{
	}
}
