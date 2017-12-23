using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
        [Required]
        [Display(Name = "Cheese")]
        public int CheeseID { get; set; }

        [Required]
        [Display(Name = "Menu")]
        public int MenuID { get; set; }

        //[Required(ErrorMessage = "Dont mess with the process buddy")]
        public Menu Menu { get; set; }

        public List<SelectListItem> Cheeses { get; set; }

        public AddMenuItemViewModel() { }


        public AddMenuItemViewModel(Menu menu, IEnumerable<Cheese> cheeses)
        {
            this.Menu = menu;

            Cheeses = new List<SelectListItem>();

            //navigate throght cheese objects in cheeses list
            foreach (var cheese in cheeses)
            {
                //navigate through the CheeseMenu property of the cheese objects in cheeses
                //foreach (var menus in cheese.CheeseMenu)
                {
                    //add only the cheeses that arent already on the menu
                    //if (menus.MenuID != menu.ID)
                    {
                        Cheeses.Add(new SelectListItem
                        {
                            Value = cheese.ID.ToString(),
                            Text = cheese.Name
                        });
                    }
                }
            }
            // adds all cheeses to cheeses selectlist
            /*foreach( var cheese in cheeses)
            {
                Cheeses.Add(new SelectListItem
                {
                    Value = cheese.ID.ToString(),
                    Text = cheese.Name
                });
            }*/

        }

    }

}