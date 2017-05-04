using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SketoProductionAuthentication.Data;

namespace SketoProductionAuthentication.Models
{
    public partial class JobsApplied
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public DateTime DateApplied { get; set; }
        public bool Interview { get; set; }

      
    }
}
