using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RJP.API
{
    public class UserParams
    {
        public int PageNumber { get; set; }

        private const int MaxPageSize = 50;        
        private int pageSize;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = Math.Min(value, MaxPageSize); }
        }

        private const int MaxResultsLimit = 10000;        
        private int resultsLimit;
        public int ResultsLimit
        {
            get { return resultsLimit; }
            set { resultsLimit = Math.Min(value, MaxResultsLimit); }
        }

        public string OrderBy { get; set; }
        public string Genre { get; set; }
    }
}
