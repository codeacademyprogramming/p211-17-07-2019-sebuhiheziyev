namespace home_work_17_07_2019
{
    public static class CategoryList
    {
        private static Category[] categories = new Category[3]
        {

            new Category {Name = "Dairy Products"},
            new Category {Name = "Meat Products"},
            new Category {Name = "Bakery Products"}
        };

        public static Category[] GetCategories() => categories;
    }
}
