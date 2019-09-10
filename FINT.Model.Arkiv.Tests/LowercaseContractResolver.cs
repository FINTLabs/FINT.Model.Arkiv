using Newtonsoft.Json.Serialization;

namespace FINT.Model.Arkiv.Tests
{
    public class LowercaseContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string propertyName)
        {
            return propertyName.ToLower();
        }
    }
}