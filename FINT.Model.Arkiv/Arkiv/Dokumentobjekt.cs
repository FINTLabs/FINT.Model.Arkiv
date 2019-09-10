// Built from tag arkiv

using System;
using System.Collections.Generic;



namespace FINT.Model.Administrasjon.Arkiv
{
	public class Dokumentobjekt {
		public enum Relasjonsnavn
        {
			OPPRETTETAV,
			REFERANSEDOKUMENTFIL,
			VARIANTFORMAT
        }
        
	
		public string Filstorrelse { get; set; }
		public string Format { get; set; }
		public string FormatDetaljer { get; set; }
		public string Sjekksum { get; set; }
		public string SjekksumAlgoritme { get; set; }
		public long? Versjonsummer { get; set; }
		
	}
}
