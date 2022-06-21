using System.Collections.Generic;

namespace VideoSearchService.Common.Interfaces
{
    public interface ISource
    {
        public string Name { get; set; }
        public IEnumerable<string> Genre { get; set; }
        public string Description { get; set; }
    }
}
