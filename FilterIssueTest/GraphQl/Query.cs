using System.Collections.Generic;
using HotChocolate.Types;

namespace FilterIssueTest.GraphQl
{
    public class Query
    {
        [UseFiltering]
        public IEnumerable<Item> GetItems()
        {
            return [
                new Item
                {
                    Id = 1,
                    ItemSetting = new ItemSetting
                    {
                        Data = 123
                    },
                    Categories = [ new Category
                    {
                        Name = "Cat1"
                    }]
                },
                new Item
                {
                    Id = 2,
                    ItemSetting = null,
                    Categories = [ new Category
                    {
                        Name = "Cat2"
                    }]
                }
            ];
        }
    }
}
