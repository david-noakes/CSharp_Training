using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ValidationApp1.Models
{
    public class ItemListInitializer : DropCreateDatabaseAlways<ItemListDB>
    {
        private DbContext dbContext;

        public ItemListInitializer(DbContext dbContext) : base()
        {
            this.dbContext = dbContext;
        }

        protected override void Seed(ItemListDB context)
        {
            base.Seed(context);
            // Create supplier records
            var itemList = new List<ItemList>
            {
                new ItemList {Title="Grocery Shopping", ListItemEntry="Bread, Cheese, Chianti, Grapes and Shunka", CompleteByDate=new DateTime(2017, 9, 10, 15, 0, 0 )},
                new ItemList {Title="Things to do", ListItemEntry="Wash the windows, clean the carpets, mop the tiles", CompleteByDate=new DateTime(2017, 8, 20, 15, 0, 0 ) }
            };
            itemList.ForEach(i => context.ItemLists.Add(i));
            context.SaveChanges();

        }
    }
}