﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace TootNet.Objects
{
    public class Meta : BaseObject
    {
        [JsonProperty("original")]
        public MetaInfo Original { get; set; }

        [JsonProperty("small")]
        public MetaInfo Small { get; set; }

        [JsonProperty("focus")]
        public MetaInfo Focus { get; set; }
    }

    public class MetaInfo : BaseObject
    {
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("aspect")]
        public double Aspect { get; set; }
    }

    public class Focus : BaseObject
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }
}
