namespace FluentBuilder
{
    public class Item
    {
        public string Name;
        public int Quantity;
    }

    public class ItemNameBuilder
    {
        protected Item _item = new Item();

        public ItemNameBuilder WithName(string name)
        {
            _item.Name = name;
            return this;
        }

        public Item Build()
        {
            return _item;
        }
    }
    public class ItemQuantityBuilder : ItemNameBuilder
    {

        public ItemQuantityBuilder WithQuantiry(int quantity)
        {
            _item.Quantity = quantity;
            return this;
        }
    }
}