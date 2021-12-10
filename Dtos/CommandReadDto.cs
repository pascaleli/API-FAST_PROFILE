using System.ComponentModel.DataAnnotations;

namespace Fast_P_T_Profile.Dtos
{
    public class CommandReadDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

         [Required]
        public string  Age { get; set; }
        
        [Required]
        public string  Position { get; set; }

    }
}