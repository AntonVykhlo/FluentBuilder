using System;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new Item().New.WithQuantity(123).WithName("asd").Build();
            var item2 = new Item().New.WithName("asd").WithQuantity(123).Build();
        }
    }
}
