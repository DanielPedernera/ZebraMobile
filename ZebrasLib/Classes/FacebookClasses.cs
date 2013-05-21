﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace ZebrasLib
{
    namespace Classes
    {
        public class Friend
        {
            [JsonProperty("id")]
            public string id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("picture")]
            public Picture picture { get; set; }

            [JsonProperty("installed")]
            public bool usesApp { get; set; }
        }

        public class Paging
        {
            [JsonProperty("next")]
            public string next { get; set; }
        }

        public class Picture
        {
            [JsonProperty("data")]
            public PictureData data { get; set; }
        }

        public class PictureData
        {
            [JsonProperty("url")]
            public string url { get; set; }

            [JsonProperty("is_silhouette")]
            public bool isSilhouette { get; set; }
        }

        public class FacebookData
        {
            [JsonProperty("data")]
            public static List<Friend> friends { get; set; }

            [JsonProperty("paging")]
            public static Paging paging { get; set; }
        }
    }
}