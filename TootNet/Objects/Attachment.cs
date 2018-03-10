﻿using Newtonsoft.Json;
using TootNet.Internal;

namespace TootNet.Objects
{
    public class Attachment : BaseObject
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(IdConverter))]
        public long Id { get; set; }

        /// <summary>
        /// One of: "image", "video", "gifv", "unknown"
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("remote_url")]
        public string RemoteUrl { get; set; }

        [JsonProperty("preview_url")]
        public string PreviewUrl { get; set; }

        [JsonProperty("text_url")]
        public string TextUrl { get; set; }
        
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
