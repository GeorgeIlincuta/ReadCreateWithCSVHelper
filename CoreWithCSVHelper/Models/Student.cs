using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWithCSVHelper.Models
{
    public class Student
    {
        [Index(0)]
        public string Name { get; set; } = "";
        [Index(2)]
        public string Roll { get; set; } = "";
        [Index(1)]
        public string Email { get; set; } = "";
    }
}
