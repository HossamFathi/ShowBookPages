using System;

namespace BookDisplaying
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.StartWatching();
            while (true)
            {
                book.Go(Console.ReadLine());
            }

        }
    }
}
