

using System.ComponentModel.DataAnnotations;

namespace ModelBinding.Models
{
    public class Hero
    {

        [StringLength(10,MinimumLength =5)]
        public string F_name { get; set; }

        public string L_name { get; set; }

        [Range(40,60)]
        public int Age { get; set; }
    }
}
