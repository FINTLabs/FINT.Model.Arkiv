// Built from tag arkiv

using System;
using System.Collections.Generic;



using FINT.Model.Administrasjon.Arkiv;

namespace FINT.Model.Administrasjon.Arkiv
{
	public class Dokumentbeskrivelse {
		public enum Relasjonsnavn
        {
			TILKNYTTETAV,
			OPPRETTETAV,
			DOKUMENTSTATUS,
			DOKUMENTTYPE,
			TILKNYTTETREGISTRERINGSOM
        }
        
	
		public string Beskrivelse { get; set; }
		public long? Dokumentnummer { get; set; }
		public List<Dokumentobjekt> Dokumentobjekt { get; set; }
		public List<string> Forfatter { get; set; }
		public DateTime? OpprettetDato { get; set; }
		public List<Partsinformasjon> Part { get; set; }
		public List<string> ReferanseArkivdel { get; set; }
		public Skjerming Skjerming { get; set; }
		public DateTime? TilknyttetDato { get; set; }
		public string Tittel { get; set; }
		
	}
}
