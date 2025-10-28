﻿using BlazorActivity.Data.Models;

namespace BlazorActivity.Data.Interfaces
{
    public interface IBookService
    {
        IList<Book> GetAllBooks();
        Book GetBookById(int id);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}
