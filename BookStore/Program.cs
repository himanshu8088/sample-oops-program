using System;
using System.Collections.Generic;
using BookStore;
using BookStore.Interfaces;
using BookStore.Models;

namespace BookStore
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            IStoreService storeService1 = new MagzineStoreService();
            IStoreService storeService2 = new NovelStoreService();
            IStoreService storeService3 = new GeneralBookStore();

            var mathBook = new Book("abc", "Maths", "Arihant");
            var physicsBook = new Book("syz", "physicsBook", "Arihant");
            var books = new List<Book> { mathBook, physicsBook };
            var purchaseReciept = storeService3.Buy(books);
            var sellReciept = storeService3.Sell(books);
        }        
    }
    
}

