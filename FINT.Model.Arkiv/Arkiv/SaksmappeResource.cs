// Built from tag arkiv

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Administrasjon.Arkiv;

namespace FINT.Model.Administrasjon.Arkiv
{

    public abstract class SaksmappeResource : MappeResource 
    {

    
        public List<RegistreringResource> Arkivnotat { get; set; }
        public List<JournalpostResource> Journalpost { get; set; }
        public string Saksaar { get; set; }
        public DateTime? Saksdato { get; set; }
        public string Sakssekvensnummer { get; set; }
        public DateTime? UtlaantDato { get; set; }
        
            

        public void AddJournalenhet(Link link)
        {
            AddLink("journalenhet", link);
        }

        public void AddAdministrativEnhet(Link link)
        {
            AddLink("administrativEnhet", link);
        }

        public void AddSaksansvarlig(Link link)
        {
            AddLink("saksansvarlig", link);
        }

        public void AddSaksstatus(Link link)
        {
            AddLink("saksstatus", link);
        }
    }
}
