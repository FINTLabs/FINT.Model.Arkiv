// Built from tag arkiv

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Arkiv
{

    public class KlasseResource 
    {

    
        public string AvsluttetAv { get; set; }
        public DateTime? AvsluttetDato { get; set; }
        public string Beskrivelse { get; set; }
        public Identifikator KlasseId { get; set; }
        public List<string> Noekkelord { get; set; }
        public string OpprettetAv { get; set; }
        public DateTime OpprettetDato { get; set; }
        public Identifikator SystemId { get; set; }
        public string Tittel { get; set; }
        
        public KlasseResource()
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
     
            

        public void AddUnderklasse(Link link)
        {
            AddLink("underklasse", link);
        }

        public void AddKlassifikasjonssystem(Link link)
        {
            AddLink("klassifikasjonssystem", link);
        }
    }
}
