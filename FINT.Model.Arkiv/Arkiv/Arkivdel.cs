// Built from tag arkiv

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Arkiv
{
	public class Arkivdel {
		public enum Relasjonsnavn
        {
			KLASSIFIKASJONSSYSTEM,
			REGISTRERING,
			MAPPE
        }
        
	
		public Identifikator SystemId { get; set; }
		public string Tittel { get; set; }
		
	}
}
