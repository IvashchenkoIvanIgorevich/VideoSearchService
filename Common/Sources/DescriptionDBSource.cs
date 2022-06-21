using System.Collections.Generic;
using VideoSearchService.Common.Interfaces;

namespace VideoSearchService.Common.Sources
{
    public class DescriptionDBSource : ISource
    {
        public string Name { get; set; }
        public IEnumerable<string> Genre { get; set; }
        public string Description { get; set; }
    }
}
