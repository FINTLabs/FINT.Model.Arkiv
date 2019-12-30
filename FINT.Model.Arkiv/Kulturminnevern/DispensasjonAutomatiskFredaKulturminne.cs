// Built from tag arkiv

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Administrasjon.Arkiv;

namespace FINT.Model.Kultur.Kulturminnevern
{
	public class DispensasjonAutomatiskFredaKulturminne : Saksmappe {
	
		public string KulturminneId { get; set; }
		public Matrikkelnummer Matrikkelnummer { get; set; }
		public Identifikator Soknadsnummer { get; set; }
		
	}
}
