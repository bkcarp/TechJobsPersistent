using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name Required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Location Required")]
        public string Location { get; set; }

        public AddEmployerViewModel()
        {
        }
    }
}
