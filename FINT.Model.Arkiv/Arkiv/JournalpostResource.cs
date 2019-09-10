// Built from tag arkiv

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Administrasjon.Arkiv;

namespace FINT.Model.Administrasjon.Arkiv
{

    public class JournalpostResource : RegistreringResource 
    {

    
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
        
            

        public void AddJournalenhet(Link link)
        {
            AddLink("journalenhet", link);
        }

        public void AddJournalstatus(Link link)
        {
            AddLink("journalstatus", link);
        }

        public void AddJournalposttype(Link link)
        {
            AddLink("journalposttype", link);
        }
    }
}
