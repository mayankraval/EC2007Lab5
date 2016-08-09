using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using COMP2007_S2016_Lesson12C.Models;

namespace COMP2007_S2016_Lesson12C.ViewModels
{
    public class ShoppingCartViewModel
    {
        public virtual List<Cart> CartItems { get; set; }
        public virtual decimal CartTotal { get; set; }
    }
}