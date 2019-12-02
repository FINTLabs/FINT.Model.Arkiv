// Built from tag arkiv

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Administrasjon.Arkiv;

namespace FINT.Model.Administrasjon.Arkiv
{
	public class Personalmappe : Saksmappe {
		public enum Relasjonsnavn
        {
			ORGANISASJONSELEMENT,
			PERSONALRESSURS
        }
        
	
		public Identifikator Fodselsnummer { get; set; }
		public Personnavn Navn { get; set; }
		
	}
}
