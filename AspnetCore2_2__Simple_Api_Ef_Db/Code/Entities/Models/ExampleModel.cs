using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace template.Entities.Models
{
    public class ExampleModel
    {
        //[Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Payload { get; set; }
    }
}
