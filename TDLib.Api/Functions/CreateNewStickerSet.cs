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
        /// Creates a new sticker set; for bots only. Returns the newly created sticker set 
        /// </summary>
        public class CreateNewStickerSet : Function<StickerSet>
        {
            /// <summary>
            /// Data type for serialization
            /// </summary>
            [JsonProperty("@type")]
            public override string DataType { get; set; } = "createNewStickerSet";

            /// <summary>
            /// Extra data attached to the message
            /// </summary>
            [JsonProperty("@extra")]
            public override string Extra { get; set; }

            /// <summary>
            /// Sticker set owner 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("user_id")]
            public int UserId { get; set; }

            /// <summary>
            /// Sticker set title; 1-64 characters 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("title")]
            public string Title { get; set; }

            /// <summary>
            /// Sticker set name. Can contain only English letters, digits and underscores. Must end with *"_by_<bot username>"* (*<bot_username>* is case insensitive); 1-64 characters
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("name")]
            public string Name { get; set; }

            /// <summary>
            /// True, if stickers are masks 
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("is_masks")]
            public bool IsMasks { get; set; }

            /// <summary>
            /// List of stickers to be added to the set
            /// </summary>
            [JsonConverter(typeof(Converter))]
            [JsonProperty("stickers")]
            public InputSticker[] Stickers { get; set; }
        }


        /// <summary>
        /// Creates a new sticker set; for bots only. Returns the newly created sticker set 
        /// </summary>
        public static Task<StickerSet> CreateNewStickerSetAsync(this Client client,
            int userId = default(int),
            string title = default(string),
            string name = default(string),
            bool isMasks = default(bool),
            InputSticker[] stickers = default(InputSticker[]))
        {
            return client.ExecuteAsync(new CreateNewStickerSet
            {
                UserId = userId,
                Title = title,
                Name = name,
                IsMasks = isMasks,
                Stickers = stickers,
            });
        }
    }
}