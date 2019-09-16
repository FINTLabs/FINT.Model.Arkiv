// Built from tag arkiv

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Arkiv
{
	public class Arkivressurs {
		public enum Relasjonsnavn
        {
			PERSONALRESSURS,
			ADMINISTRATIVENHET,
			ROLLE
        }
        
	
		public Identifikator KildesystemId { get; set; }
		public Identifikator SystemId { get; set; }
		
	}
}
