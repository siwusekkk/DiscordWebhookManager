using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebhookManager.Embed
{
    public class Thumbnail
    {
        [JsonProperty("url")]
        public string url { get; set; }
    }
}
