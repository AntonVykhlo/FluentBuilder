using System;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new ItemQuantityBuilder().WithQuantity(123).WithName("asd").Build();
            var item2 = new ItemQuantityBuilder().WithName("asd").WithQuantity(123).Build(); // the problem
        }
    }
}
