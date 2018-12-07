using System;
using System.Collections.Generic;
using BookStore.Interfaces;
using BookStore.Models;

namespace BookStore
{
    public class GeneralBookStore : IStoreService
    {
        public Reciept Buy(List<Book> books)
        {
            return new Reciept(101)
            {
                ItemQuantity = books.Count,
                TotalBill = books.Count * 100
            };            
        }

        public Reciept Sell(List<Book> books)
        {
            throw new NotImplementedException();
        }
    }
}

