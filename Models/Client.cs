using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRecord.Models
{
    class Client:Person
    {
        [Key]
        public int ClientId { get; set; }
       
    }
}
