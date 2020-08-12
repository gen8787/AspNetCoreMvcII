using System.ComponentModel.DataAnnotations;

namespace DojoSurveyIII.Models
{
    public class SurveyResults
    {
        //Name
        [Required]
        [MinLength(2)]
        public string Name { get; set; }


        //Location
        [Required]
        public string Location { get; set; }


        //Language
        [Required]
        public string Language { get; set; }


        //Comment
        [MinLength(20)]
        public string Comment { get; set; }
    }
}