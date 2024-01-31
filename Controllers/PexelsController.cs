using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PexelsDotNetSDK.Models
{
    public class Photo
    {

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("photographer")]
        public string photographer { get; set; }

       
    }
}