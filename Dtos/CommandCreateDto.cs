using System.ComponentModel.DataAnnotations;

namespace Fast_P_T_Profile.Dtos
{
    public class CommandCreateDto
    {
       

        [Required]
        public string Name { get; set; }

         [Required]
        public string  Age { get; set; }
        
        [Required]
        public string  Position { get; set; }

    }
}