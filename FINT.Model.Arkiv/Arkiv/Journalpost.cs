// Built from tag arkiv

using System;
using System.Collections.Generic;



using FINT.Model.Administrasjon.Arkiv;

namespace FINT.Model.Administrasjon.Arkiv
{
	public class Journalpost : Registrering {
		public enum Relasjonsnavn
        {
			JOURNALENHET,
			JOURNALSTATUS,
			JOURNALPOSTTYPE
        }
        
	
		public long? AntallVedlegg { get; set; }
		public DateTime? DokumentetsDato { get; set; }
		public DateTime? ForfallsDato { get; set; }
		public string JournalAr { get; set; }
		public DateTime? JournalDato { get; set; }
		public long? JournalPostnummer { get; set; }
		public long? JournalSekvensnummer { get; set; }
		public DateTime? MottattDato { get; set; }
		public DateTime? OffentlighetsvurdertDato { get; set; }
		public DateTime? SendtDato { get; set; }
		
	}
}
