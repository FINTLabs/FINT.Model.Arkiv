// Built from tag arkiv

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Kompleksedatatyper;

namespace FINT.Model.Administrasjon.Arkiv
{

    public class ArkivdelResource 
    {

    
        public Identifikator SystemId { get; set; }
        public string Tittel { get; set; }
        
        public ArkivdelResource()
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
     
            

        public void AddRegistrering(Link link)
        {
            AddLink("registrering", link);
        }

        public void AddMappe(Link link)
        {
            AddLink("mappe", link);
        }
    }
}
