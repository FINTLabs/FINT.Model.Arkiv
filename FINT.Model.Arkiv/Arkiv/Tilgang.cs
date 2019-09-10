// Built from tag arkiv

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Arkiv
{
	public class Tilgang {
		public enum Relasjonsnavn
        {
			ROLLE,
			TILGANGSRESTRIKSJON
        }
        
	
		public Identifikator SystemId { get; set; }
		
	}
}
