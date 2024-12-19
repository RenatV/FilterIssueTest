using System.Collections.Generic;

namespace FilterIssueTest.GraphQl
{
    public class Item
    {
        public int Id { get; set; }

        public ItemSetting ItemSetting { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }

    public class ItemSetting
    {
        public int Data { get; set; }
    }

    public class Category
    {
        public string Name { get; set; }
    }
}
