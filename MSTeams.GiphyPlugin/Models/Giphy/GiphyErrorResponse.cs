using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MSTeams.GiphyPlugin.Models.Giphy
{
    public class GiphyErrorResponse: Exception
    {
        public GiphyError GiphyError { get; set; }
    }
}
