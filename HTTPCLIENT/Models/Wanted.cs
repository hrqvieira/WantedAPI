using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace HTTPCLIENT.Models
{

    public class Wanted
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Crime { get; set; }
        public string? Nationality { get; set; }
        public string? Sex { get; set; }
        public string? Hair { get; set; }
        public string? ScarsAndMarks { get; set; }
        public string? Eyes { get; set; }
        public string? WantedDescription { get; set; }
        public string? Warning_message { get; set; }
        public string? BirthDate { get; set; }

    }
}


