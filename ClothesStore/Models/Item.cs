using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClothesStore.Models
{
   public class Item
   {
      public int ItemID { get; set; }

      [Required, StringLength(50), Display(Name = "Name")]
      public string ItemName { get; set; }
      public string Description { get; set; }

      
      [Display(Name = "Price")]
      public int ItemPrice { get; set; }
      public int? CategoryID { get; set; }
      public virtual Category Category { get; set; }

   }
}