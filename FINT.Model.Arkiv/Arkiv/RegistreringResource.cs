// Built from tag arkiv

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Administrasjon.Arkiv;

namespace FINT.Model.Administrasjon.Arkiv
{

    public abstract class RegistreringResource 
    {

    
        public DateTime? ArkivertDato { get; set; }
        public string Beskrivelse { get; set; }
        public List<DokumentbeskrivelseResource> Dokumentbeskrivelse { get; set; }
        public List<string> Forfatter { get; set; }
        public List<KorrespondanseResource> Korrespondansepart { get; set; }
        public List<MerknadResource> Merknad { get; set; }
        public List<string> Nokkelord { get; set; }
        public string OffentligTittel { get; set; }
        public DateTime? OpprettetDato { get; set; }
        public List<PartsinformasjonResource> Part { get; set; }
        public List<string> ReferanseArkivDel { get; set; }
        public string RegistreringsId { get; set; }
        public SkjermingResource Skjerming { get; set; }
        public string Tittel { get; set; }
        
        protected RegistreringResource()
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
     
            

        public void AddAdministrativEnhet(Link link)
        {
            AddLink("administrativEnhet", link);
        }

        public void AddArkivdel(Link link)
        {
            AddLink("arkivdel", link);
        }

        public void AddSaksbehandler(Link link)
        {
            AddLink("saksbehandler", link);
        }

        public void AddArkivertAv(Link link)
        {
            AddLink("arkivertAv", link);
        }

        public void AddOpprettetAv(Link link)
        {
            AddLink("opprettetAv", link);
        }
    }
}
