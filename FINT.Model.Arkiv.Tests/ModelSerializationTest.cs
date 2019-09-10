using System;
using System.Collections.Generic;
using FINT.Model.Felles;
using FINT.Model.Felles.Kompleksedatatyper;
using FINT.Model.Administrasjon.Arkiv;
using Newtonsoft.Json;
using Xunit;
using FINT.Model.Resource;

namespace FINT.Model.Arkiv.Tests
{
    public class ModelSerializationTest
    {
        [Fact(DisplayName = "Serialize Sak without Links")]
        public void Serialize_Sak_without_Links()
        {
            var sak = new Sak
            {
                SystemId = new Identifikator {Identifikatorverdi = "ABC123"},
                Tittel = "Gamle Dampen",
                MappeId = new Identifikator { Identifikatorverdi = "19/12345" }
            };

            var settings = new JsonSerializerSettings
            {
                ContractResolver = new LowercaseContractResolver()
            };
            var json = JsonConvert.SerializeObject(sak, settings);
            Console.WriteLine(json);

            var deserializeObject = JsonConvert.DeserializeObject<Sak>(json);
            Assert.NotNull(deserializeObject);
            Assert.Equal("Gamle Dampen", deserializeObject.Tittel);
        }

        [Fact(DisplayName = "Serialize SakResource with links")]
        public void Serialize_SakResource_with_links()
        {

            var sak = new SakResource
            {
                SystemId = new Identifikator {Identifikatorverdi = "ABC123"},
                Tittel = "Gamle Dampen",
                MappeId = new Identifikator { Identifikatorverdi = "19/12345" }
            };

            sak.AddSaksstatus(Link.with(typeof(Saksstatus), "systemid", "1"));

            var settings = new JsonSerializerSettings
            {
                ContractResolver = new LowercaseContractResolver()
            };
            var json = JsonConvert.SerializeObject(sak, settings);

            Console.WriteLine(json);

            var deserializeObject = JsonConvert.DeserializeObject<SakResource>(json);
            Assert.NotNull(deserializeObject);
            Assert.True(deserializeObject.Links.ContainsKey("saksstatus"));
        }

    }
}