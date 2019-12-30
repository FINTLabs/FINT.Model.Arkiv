// Built from tag arkiv

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using FINT.Model.Resource;

using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Administrasjon.Arkiv;

namespace FINT.Model.Kultur.Kulturminnevern
{

    public class TilskuddFredaHusPrivatEieResource : SaksmappeResource 
    {

    
        public string KulturminneId { get; set; }
        public MatrikkelnummerResource Matrikkelnummer { get; set; }
        public Identifikator Soknadsnummer { get; set; }
        
    }
}
