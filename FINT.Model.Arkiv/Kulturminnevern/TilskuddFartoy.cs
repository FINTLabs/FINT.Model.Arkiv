// Built from tag arkiv

using System;
using System.Collections.Generic;



using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Administrasjon.Arkiv;

namespace FINT.Model.Kultur.Kulturminnevern
{
	public class TilskuddFartoy : Saksmappe {
		public enum Relasjonsnavn
        {
			JOURNALENHET,
			ADMINISTRATIVENHET,
			SAKSANSVARLIG,
			SAKSSTATUS,
			ARKIVDEL,
			AVSLUTTETAV,
			OPPRETTETAV
        }
        
	
		public string FartoyNavn { get; set; }
		public string Kallesignal { get; set; }
		public string KulturminneId { get; set; }
		public Identifikator Soknadsnummer { get; set; }
		
	}
}
