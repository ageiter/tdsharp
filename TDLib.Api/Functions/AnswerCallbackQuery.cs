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
        /// Sets the result of a callback query; for bots only 
        /// </summary>
        public class AnswerCallbackQuery : Function<Ok>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "answerCallbackQuery";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Identifier of the callback query 
            /// </summary>
            [JsonConverter(typeof(Converter.Int64))]
            [JsonProperty("callback_query_id")]
            public Int64 CallbackQueryId { get; set; }

            /// <summary>
            /// Text of the answer 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("text")]
            public string Text { get; set; }

            /// <summary>
            /// If true, an alert should be shown to the user instead of a toast notification 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("show_alert")]
            public bool ShowAlert { get; set; }

            /// <summary>
            /// URL to be opened 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("url")]
            public string Url { get; set; }

            /// <summary>
            /// Time during which the result of the query can be cached, in seconds
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("cache_time")]
            public int CacheTime { get; set; }
        }


        /// <summary>
        /// Sets the result of a callback query; for bots only 
        /// </summary>
        public static Task<Ok> AnswerCallbackQueryAsync(this Client client,
            Int64 callbackQueryId = default(Int64),
            string text = default(string),
            bool showAlert = default(bool),
            string url = default(string),
            int cacheTime = default(int))
        {
            return client.ExecuteAsync(new AnswerCallbackQuery
            {
                CallbackQueryId = callbackQueryId,
                Text = text,
                ShowAlert = showAlert,
                Url = url,
                CacheTime = cacheTime,
            });
        }
    }
}