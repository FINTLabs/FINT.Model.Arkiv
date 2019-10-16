// Built from tag arkiv

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Arkiv
{
	public class Tilgang {
		public enum Relasjonsnavn
        {
			ADMINISTRATIVENHET,
			ARKIVDEL,
			ARKIVRESSURS,
			ROLLE
        }
        
	
		public Identifikator SystemId { get; set; }
		public string Tittel { get; set; }
		
	}
}
