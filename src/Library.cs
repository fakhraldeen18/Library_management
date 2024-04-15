using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_library_management.src
{
    public class Library
    {
        private List<Book> _books;
        private List<User> _users;
        private string Name;
        public Library(string name){
            _books = [];
            _users = [];
            this.Name=name;
        }

        public List<Book> GetBooks()
        {
            return _books;
        }
        public void AddBook(Book book )
        {
            _books.Add(book);
        }
        public List<User>  GetUsers()
        {
            return _users;
        }
        public void AddUser(User user )
        {
            _users.Add(user);
        }
    }
}