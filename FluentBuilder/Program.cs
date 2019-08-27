using System;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = new ItemQuantityBuilder().WithName("asd").Build();
        }
    }
}
