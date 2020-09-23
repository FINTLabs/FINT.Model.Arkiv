// Built from tag arkiv

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Arkiv
{
	public class Autorisasjon {
		public enum Relasjonsnavn
        {
			ADMINISTRATIVENHET,
			TILGANGSRESTRIKSJON,
			ARKIVRESSURS
        }
        
	
		public Identifikator SystemId { get; set; }
		
	}
}
