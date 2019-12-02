// Built from tag arkiv

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Administrasjon.Arkiv;

namespace FINT.Model.Administrasjon.Arkiv
{

    public class PersonalmappeResource : SaksmappeResource 
    {

    
        public Identifikator Fodselsnummer { get; set; }
        public Personnavn Navn { get; set; }
        
            

        public void AddOrganisasjonselement(Link link)
        {
            AddLink("organisasjonselement", link);
        }

        public void AddPersonalressurs(Link link)
        {
            AddLink("personalressurs", link);
        }
    }
}
