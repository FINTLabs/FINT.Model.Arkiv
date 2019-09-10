// Built from tag arkiv

using System;
using System.Collections.Generic;



namespace FINT.Model.Felles.Kompleksedatatyper
{
	public class Matrikkelnummer {
		public enum Relasjonsnavn
        {
			KOMMUNENUMMER
        }
        
	
		public string Bruksnummer { get; set; }
		public string Festenummer { get; set; }
		public string Gardsnummer { get; set; }
		public string Seksjonsnummer { get; set; }
		
	}
}
