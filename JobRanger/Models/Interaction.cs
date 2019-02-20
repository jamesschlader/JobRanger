using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobRanger.Models
{
    public class Interaction
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Action Date")]
        public DateTime TargetTime { get; set; }

        [Required]
        [DisplayName("To Do")]
       public bool ToDo { get; set; }
        
       [DefaultValue(false)]
      public bool Finished { get; set; }

        public string Notes { get; set; }

        [DisplayName("Interaction Type")]
        public string InteractionTypeName { get; set; }

        [ForeignKey("ApplicationUserId")]
        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        
        public int? ContactId { get; set; }
        public Contact Contact { get; set; }

        public int? JobId { get; set; }
       public Job Job { get; set; }

      
    }
}