using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace r.net.Models
{
    public class DCandidate
    {
        [Key]
        public int id { get;set; }

        [Column(TypeName="nvarchar(100)")]
        public string fullName { get;set; }

        [Column(TypeName="nvarchar(16)")]
        public string mobile { get;set; }

        [Column(TypeName="nvarchar(100)")]     
        public string email { get;set; }
        public int age { get;set; }   

        [Column(TypeName="nvarchar(3)")]
        public int bloodGroup { get;set; }

        [Column(TypeName="nvarchar(100)")]
        public int address { get;set; }                        
    }
}