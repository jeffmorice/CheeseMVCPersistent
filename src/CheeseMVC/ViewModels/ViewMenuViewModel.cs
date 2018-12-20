using CheeseMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class ViewMenuViewModel
    {
        public Menu Menu { get; set; }
        // Changed from IList to List because I was not able to initialize an empty IList, which caused its value to be null, thus a null reference exception.
        public List<CheeseMenu> Items = new List<CheeseMenu>(); //{ get; set; }

        public ViewMenuViewModel() { }

        public ViewMenuViewModel(Menu menu, List<CheeseMenu> cheeseMenus)
        {
            Menu = menu;

            foreach (CheeseMenu cheeseMenu in cheeseMenus)
            {
                Items.Add(cheeseMenu);
            }
        }
    }
}
