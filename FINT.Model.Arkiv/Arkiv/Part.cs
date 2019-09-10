// Built from tag arkiv

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Arkiv
{
	public class Part {
	
		public Adresse Adresse { get; set; }
		public Kontaktinformasjon Kontaktinformasjon { get; set; }
		public string Kontaktperson { get; set; }
		public Identifikator PartId { get; set; }
		public string PartNavn { get; set; }
		
	}
}
