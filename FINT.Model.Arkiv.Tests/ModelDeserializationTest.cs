#pragma warning disable xUnit2002

using System.IO;
using FINT.Model.Administrasjon.Arkiv;
using Newtonsoft.Json;
using Xunit;

namespace FINT.Model.Arkiv.Tests
{
    public class ModelDeserializationTest
    {
        [Fact(DisplayName = "Read Sak from sak.json")]
        public void Read_Sak_from_sak_json()
        {
            var sak = JsonConvert.DeserializeObject<Sak>(File.ReadAllText(@"./TestData/sak.json"));
            Assert.NotNull(sak);
            Assert.NotNull(sak.Tittel);
            Assert.Equal("15/00123", sak.MappeId.Identifikatorverdi);
            Assert.Equal("232327", sak.SystemId.Identifikatorverdi);
            Assert.NotEmpty(sak.Journalpost);
        }

        [Fact(DisplayName = "Read SakResource from sak.json")]
        public void Read_SakResource_from_sak_json()
        {
            var sak =
                JsonConvert.DeserializeObject<SakResource>(File.ReadAllText(@"./TestData/sak.json"));

            Assert.NotNull(sak);
            Assert.NotNull(sak.Tittel);
            Assert.Equal("15/00123", sak.MappeId.Identifikatorverdi);
            Assert.Equal("232327", sak.SystemId.Identifikatorverdi);
            Assert.NotEmpty(sak.Journalpost);
            Assert.NotNull(sak.Links);
            Assert.True(sak.Links.ContainsKey("saksstatus"));
        }

        [Fact(DisplayName = "Read Korrespondansepart from korrespondansepart.json")]
        public void Read_Korrespondansepart_from_korrespondansepart_json()
        {
            var korrespondansepart =
                JsonConvert.DeserializeObject<Korrespondansepart>(File.ReadAllText(@"./TestData/korrespondansepart.json"));

            Assert.NotNull(korrespondansepart);
            Assert.Equal("Asgeir S. Nilsen", korrespondansepart.Kontaktperson);
        }

        [Fact(DisplayName = "Read KorrespondansepartResource from korrespondansepart.json")]
        public void Read_KorrespondansepartResource_from_korrespondansepart_json()
        {
            var korrespondansepart =
                JsonConvert.DeserializeObject<KorrespondansepartResource>(File.ReadAllText(@"./TestData/korrespondansepart.json"));

            Assert.NotNull(korrespondansepart);
            Assert.Equal("Asgeir S. Nilsen", korrespondansepart.Kontaktperson);
        }

    }
}
#pragma warning restore xUnit2002