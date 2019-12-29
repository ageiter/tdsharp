using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public partial class TdApi
    {
        /// <summary>
        /// Constructs a persistent HTTP URL for a background 
        /// </summary>
        public class GetBackgroundUrl : Function<HttpUrl>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "getBackgroundUrl";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Background name 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// Background type
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("type")]
            public BackgroundType Type { get; set; }
        }
    }
}