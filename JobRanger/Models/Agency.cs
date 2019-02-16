using System.ComponentModel.DataAnnotations;

namespace JobRanger.Models
{
    public class Agency
    {
        public int Id { get; set; }

        [Required] public string Name { get; set; }

        public string WebSite { get; set; }
        public string IconSrc { get; set; }
    }
}