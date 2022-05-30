using System;
using System.Collections.Generic;
using System.Text;

namespace VideoSearchService.Service.Interfaces
{
    public interface ISource
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
    }
}
