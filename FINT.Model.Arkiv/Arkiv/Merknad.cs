// Built from tag arkiv

using System;
using System.Collections.Generic;



namespace FINT.Model.Administrasjon.Arkiv
{
	public class Merknad {
		public enum Relasjonsnavn
        {
			MERKNADREGISTRERTAV,
			MERKNADSTYPE
        }
        
	
		public DateTime Merknadsdato { get; set; }
		public string Merknadstekst { get; set; }
		
	}
}
