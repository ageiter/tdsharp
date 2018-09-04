using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class KeyboardButtonType : Object
        {
            public class KeyboardButtonTypeRequestPhoneNumber : KeyboardButtonType
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "keyboardButtonTypeRequestPhoneNumber";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}