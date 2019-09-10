// Built from tag arkiv

using System;
using System.Collections.Generic;



using FINT.Model.Administrasjon.Arkiv;

namespace FINT.Model.Administrasjon.Arkiv
{
	public abstract class Saksmappe : Mappe {
		public enum Relasjonsnavn
        {
			JOURNALENHET,
			ADMINISTRATIVENHET,
			SAKSANSVARLIG,
			SAKSSTATUS
        }
        
	
		public List<Registrering> Arkivnotat { get; set; }
		public List<Journalpost> Journalpost { get; set; }
		public string Saksaar { get; set; }
		public DateTime? Saksdato { get; set; }
		public string Sakssekvensnummer { get; set; }
		public DateTime? UtlaantDato { get; set; }
		
	}
}
