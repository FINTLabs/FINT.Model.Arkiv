// Built from tag arkiv

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Arkiv
{

    public class KorrespondansepartResource 
    {

    
        public AdresseResource Adresse { get; set; }
        public Identifikator Fodselsnummer { get; set; }
        public Kontaktinformasjon Kontaktinformasjon { get; set; }
        public string Kontaktperson { get; set; }
        public string KorrespondansepartNavn { get; set; }
        public Identifikator Organisasjonsnummer { get; set; }
        public Identifikator SystemId { get; set; }
        
        public KorrespondansepartResource()
        {
            Links = new Dictionary<string, List<Link>>();
        }

        [JsonProperty(PropertyName = "_links")]
        public Dictionary<string, List<Link>> Links { get; private set; }

        protected void AddLink(string key, Link link)
        {
            if (!Links.ContainsKey(key))
            {
                Links.Add(key, new List<Link>());
            }
            Links[key].Add(link);
        }
     
    }
}
