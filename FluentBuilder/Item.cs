namespace FluentBuilder
{
    public class Item
    {
        public string Name;
        public int Quantity;
        public Builder New => new Builder();
    }

    public class Builder : ItemQuantityBuilder<Builder>
    {

    }

    public abstract class ItemBuilder
    {
        protected Item Item = new Item();
        public Item Build()
        {
            return Item;
        }
    }

    public class ItemNameBuilder<T> : ItemBuilder where T : ItemNameBuilder<T>
    {
        //substituted with Builder : ItemQuantityBuilder<Builder>
        public T WithName(string name)
        {
            Item.Name = name;
            return (T) this; //cast is safe due to constraint.
        }
    }

    public class ItemQuantityBuilder<T> : ItemNameBuilder<ItemQuantityBuilder<T>> where T:ItemQuantityBuilder<T>
    {
        //same substitution
        public T WithQuantity(int quantity)
        {
            Item.Quantity = quantity;
            return (T) this;
        }
    }
}