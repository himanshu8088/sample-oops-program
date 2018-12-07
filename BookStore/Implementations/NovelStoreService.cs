using System;
using System.Collections.Generic;
using BookStore.Interfaces;
using BookStore.Models;

namespace BookStore
{
    public class NovelStoreService : IStoreService
    {
        public Reciept Buy(List<Book> books)
        {
            throw new NotImplementedException();
        }

        public Reciept Sell(List<Book> books)
        {
            throw new NotImplementedException();
        }
    }
}

