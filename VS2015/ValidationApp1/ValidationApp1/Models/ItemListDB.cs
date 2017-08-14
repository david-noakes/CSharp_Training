using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ValidationApp1.Models
{
    public class ItemListDB : DbContext
    {

        public DbSet<ItemList> ItemLists { get; set; }
        public ItemListDB() : base()
        {

        }
        public ItemListDB(string nameOrConnectionString) : base(nameOrConnectionString)
        {

        }

    }
    [Table("ItemList")]
    public class ItemList
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ListItemId { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [MustHaveMultipleItems(ErrorMessage = "Please enter more than one item and separate by commas.")]
        [Display(Name = "Things To Do")]
        public string ListItemEntry { get; set; }

        [Required]
        [Display(Name = "Complete By")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime CompleteByDate { get; set; }


    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class MustHaveMultipleItemsAttribute : ValidationAttribute
    {
        // Override IsValid method to run the validation test
        public override bool IsValid(object value)
        {
            bool result;
            var testVal = (string)value;

            if (testVal.IndexOf(',') != -1)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
            //return base.IsValid(value);
        }
    }
}