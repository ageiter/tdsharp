using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Changes the username of the current user. If something changes, updateUser will be sent 
        /// </summary>
        public class SetUsername : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "setUsername";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// The new value of the username. Use an empty string to remove the username
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("username")]
            public string Username { get; set; }
        }


        /// <summary>
        /// Changes the username of the current user. If something changes, updateUser will be sent 
        /// </summary>
        public static Task<Ok> SetUsernameAsync(this Client client,
            string username = default(string))
        {
            return client.ExecuteAsync(new SetUsername
            {
                Username = username,
            });
        }
    }
}