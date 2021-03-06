using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// Represents a link to an animated GIF 
        /// </summary>
        public partial class InputInlineQueryResult : Object
        {
            /// <summary>
            /// Represents a link to an animated GIF 
            /// </summary>
            public class InputInlineQueryResultAnimatedGif : InputInlineQueryResult
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputInlineQueryResultAnimatedGif";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Unique identifier of the query result 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string Id { get; set; }

                /// <summary>
                /// Title of the query result 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string Title { get; set; }

                /// <summary>
                /// URL of the static result thumbnail (JPEG or GIF), if it exists
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail_url")]
                public string ThumbnailUrl { get; set; }

                /// <summary>
                /// The URL of the GIF-file (file size must not exceed 1MB) 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("gif_url")]
                public string GifUrl { get; set; }

                /// <summary>
                /// Duration of the GIF, in seconds 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("gif_duration")]
                public int GifDuration { get; set; }

                /// <summary>
                /// Width of the GIF 
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("gif_width")]
                public int GifWidth { get; set; }

                /// <summary>
                /// Height of the GIF
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("gif_height")]
                public int GifHeight { get; set; }

                /// <summary>
                /// The message reply markup. Must be of type replyMarkupInlineKeyboard or null
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("reply_markup")]
                public ReplyMarkup ReplyMarkup { get; set; }

                /// <summary>
                /// The content of the message to be sent. Must be one of the following types: InputMessageText, InputMessageAnimation, InputMessageLocation, InputMessageVenue or InputMessageContact
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("input_message_content")]
                public InputMessageContent InputMessageContent { get; set; }
            }
        }
    }
}