using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        [Column(TypeName = "character varying(50)")]
        public string title { get; set; }

        [Column(TypeName = "character varying(20)")]
        public string owner { get; set; }

        [Column(TypeName = "character varying(10)")]
        public string duedate { get; set; }
    }
}
