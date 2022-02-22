using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using VideoSearchService.Service.Interfaces;

namespace VideoSearchService.Service
{
    public class ApiSource<ISource>
    {
        [JsonProperty("data")]
        public IEnumerable<ISource> Values { get; set; }

        [JsonProperty("@next")]
        public Uri NextPage { get; set; }
    }
}
