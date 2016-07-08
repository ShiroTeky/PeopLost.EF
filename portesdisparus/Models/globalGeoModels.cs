using System;
using System.Collections.Generic;
namespace PeopLost.Web.Models
{
    public class globalGeoModels
    {
        public Int32 PersonId { get; set; }

        public ICollection<PersonPointGeoModels> PersonPointGeos{get;set;}
    }


}
