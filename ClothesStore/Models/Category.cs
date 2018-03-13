using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ClothesStore.Models
{
   public class Category
   {
      public int CategoryID { get; set; }

      [Required, StringLength(50), Display(Name = "Name")]
      public string CategoryName { get; set; }

      [Display(Name = "Item Description")]
      public string Description { get; set; }

      public virtual ICollection<Item> Items { get; set; }
   }
} 
   