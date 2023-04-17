using System.ComponentModel.DataAnnotations;

namespace FQ23L056_ConsumeApi.Models.Forms
{
#nullable disable
    public class CreateTaskForm
    {
        [Required]
        [StringLength(128, MinimumLength = 1)]
        public string Title { get; set; }
    }
}
