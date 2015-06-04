using Newtonsoft.Json;

namespace Digirati.IIIF.Serialisation
{
    public class ToStringJsonConverter : WriteOnlyConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }
    }
}
