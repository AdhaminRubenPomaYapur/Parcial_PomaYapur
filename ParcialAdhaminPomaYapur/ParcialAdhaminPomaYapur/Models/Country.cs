using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;

namespace ParcialAdhaminPomaYapur.Models
{
    public class Country
    {
        [Key]
        [Required]
        public string alpha3Code { get; set; }

        [DisplayName("REGION")]
        [Required]
        [StringLength(30, ErrorMessage = "This must between {0} and {1}", MinimumLength = 5)]
        public string region { get; set; }

        [DisplayName("NAME")]
        [Required]
        [StringLength(30, ErrorMessage = "This must between {0} and {1}", MinimumLength = 5)]
        public string name { get; set; }

        [DisplayName("AREA")]
        [Required]
        public int area { get; set; }

        [DisplayName("CALLINGCODES")]
        [Required]
        [Range(0,14)]
        public int CallingCodes { get; set; }

        [DisplayName("LANGUAGES")]
        [StringLength(20, ErrorMessage = "This must between {0} and {1}", MinimumLength = 3)]
        public string languages { get; set; }

        [DisplayName("Flag")]
        public string flag { get; set; }
    }
}