namespace sda_onsite_2_csharp_library_management.src
{
    public class Library
    {

        private readonly List<Book> _books;
        private readonly List<User> _users;
        private string Name;
        public Library(string name)
        {
            _books = [];
            _users = [];
            this.Name = name;
        }

        public List<Book> GetBooks()
        {
            return _books;
        }
        public void AddBook(Book book)
        {
            _books.Add(book);
        }
        public List<User> GetUsers()
        {
            return _users;
        }
        public void AddUser(User user)
        {
            _users.Add(user);
        }
        public void FindBook(string title)
        {
            Book? book = _books.Find(item => item.GetTitle() == title);
            if (book != null)
            {
                Console.WriteLine($"Book title is  {book.GetTitle()}");
            }

            else
            {
                Console.WriteLine("Book not found");
            }
        }

        public void FindUsers(string name)
        {
            User? users = _users.Find(item => item.GetName() == name);
            if (users != null)
            {
                Console.WriteLine($"this users is {users.GetName()}");
            }
            else
            {
                Console.WriteLine("Can't find item");
            }
        }


        public void DeleteBook(Guid id)
        {
            Book? deleteById = _books.Find(book => book.GetId() == id);
            if (deleteById != null)
            {
                _books.Remove(deleteById);
                Console.WriteLine("Delete book was successful");
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }


        public void DeleteUser(Guid id)
        {
            User? deleteById = _users.Find(user => user.GetId() == id);
            if (deleteById != null)
            {
                _users.Remove(deleteById);
                Console.WriteLine("Delete user was successful");
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }


        public List<Book> GetBooksByDate(SortType type)
        {
            if (type == SortType.ASC)
            {
                var AscByDate = _books.OrderBy(book => book.GetDate()).ToList();
                Console.WriteLine("Sorting date by Ascending");
                return AscByDate;
            }
            if (type == SortType.DESC)
            {
                var DescByDate = _books.OrderByDescending(book => book.GetDate()).ToList();
                Console.WriteLine("Sorting date by Descending");
                return DescByDate;
            }
            else
            {
                Console.WriteLine("Please type ASC or DESC to get something");
                return _books;
            }
        }


        public List<User> GetUsersByDate(SortType type)
        {
            if (type == SortType.ASC)
            {
                var AscByDate = _users.OrderBy(user => user.GetDate()).ToList();
                Console.WriteLine("Sorting date by Ascending");
                return AscByDate;
            }
            if (type == SortType.DESC)
            {
                var DescByDate = _users.OrderByDescending(user => user.GetDate()).ToList();
                Console.WriteLine("Sorting date by Descending");
                return DescByDate;
            }
            else
            {
                Console.WriteLine("Please type ASC or DESC to get something");
                return _users;
            }
        }
    }
}