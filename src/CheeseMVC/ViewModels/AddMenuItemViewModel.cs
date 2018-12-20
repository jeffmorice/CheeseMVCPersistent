﻿using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
        [Required]
        [Display(Name = "Select a cheese.")]
        public int CheeseID { get; set; }
        public int MenuID { get; set; }

        public Menu Menu { get; set; }
        public List<SelectListItem> Cheeses = new List<SelectListItem>(); //{ get; set; }

        public AddMenuItemViewModel() { }

        public AddMenuItemViewModel(Menu menu, IEnumerable<Cheese> cheeses)
        {
            Menu = menu;
            
            foreach(Cheese cheese in cheeses)
            {
                SelectListItem newSelectListItem = new SelectListItem
                {
                    Value = cheese.ID.ToString(),
                    Text = cheese.Name
                };

                this.Cheeses.Add(newSelectListItem);
            }
        }
    }
}
