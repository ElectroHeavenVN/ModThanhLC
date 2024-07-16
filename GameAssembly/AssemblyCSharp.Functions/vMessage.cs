using Newtonsoft.Json;

namespace AssemblyCSharp.Functions
{
    public class vMessage
    {
        [JsonProperty(nameof(cmd))]
        public int cmd;

        [JsonProperty(nameof(data))]
        public byte[] data;
    }
}
