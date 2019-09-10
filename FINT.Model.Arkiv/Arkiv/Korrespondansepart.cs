// Built from tag arkiv

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Arkiv
{
	public class Korrespondansepart {
	
		public Adresse Adresse { get; set; }
		public Identifikator Fodselsnummer { get; set; }
		public Kontaktinformasjon Kontaktinformasjon { get; set; }
		public string Kontaktperson { get; set; }
		public string KorrespondansepartNavn { get; set; }
		public Identifikator Organisasjonsnummer { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}
