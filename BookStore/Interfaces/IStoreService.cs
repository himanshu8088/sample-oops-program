using System.Collections.Generic;
using BookStore.Models;

namespace BookStore.Interfaces
{
    public interface IStoreService
    {
        Reciept Sell(List<Book> books);
        Reciept Buy(List<Book> books);
    }
}

