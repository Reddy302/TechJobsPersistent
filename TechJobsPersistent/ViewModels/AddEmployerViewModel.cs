﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        public List<SelectListItem> Employers { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Location must be between 3 and 50 characters")]
        public string Location { get; set; }

        public AddEmployerViewModel(List<Employer> employers)
        {
            Employers = new List<SelectListItem>();
            foreach (var employer in employers)
            {
                Employers.Add(
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    }
               );
            }
        }
        public AddEmployerViewModel()
        {

        }
    }
}
