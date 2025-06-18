using System;
using System.Collections.Generic;
using Librarymaneger.Models;

namespace Librarymaneger.Services
{
    public interface ILibrary
    {
        List<Book> GetAll();
        Book? GetById(Guid id);
        void Add(Book book);

    }
}