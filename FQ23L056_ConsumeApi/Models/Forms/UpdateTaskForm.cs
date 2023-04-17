using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FQ23L056_ConsumeApi.Models.Forms
{
    public class UpdateTaskForm
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required]
        [StringLength(128, MinimumLength = 1)]
        public string Title { get; set; }
        [Required]
        public bool Done { get; set; }
    }
}
