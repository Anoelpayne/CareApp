using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CareApp.ViewModels
{
    public class AddTaskViewModel
    {
        [Required(ErrorMessage = "Task name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Task name must be between 3 and 50 characters. ")]
        public string Name { get; set; }
        public int TaskId { get; set; }

        public AddTaskViewModel() {}
    }
}
