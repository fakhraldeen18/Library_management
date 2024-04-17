namespace sda_onsite_2_csharp_library_management.src
{
    public class Library
    {

        private readonly List<Book> _books;
        private readonly List<User> _users;
        private string Name;
        public Library(string name)
        {
            _books = new List<Book>();
            _users = new List<User>();
            this.Name = name;
        }

        public List<Book> GetBooks()
        {
            return _books;
        }
        public List<Book> GetBooksWithPagination()
        {
            var Page = 1;
            var itemsPerPage = 4;
            var currentPage = (Page-1) * itemsPerPage;
            var paginatedBook = _books
                                    .Select(i=>i)
                                    .Skip(currentPage)
                                    .Take(itemsPerPage)
                                    .ToList();
            return paginatedBook;
        }
        public List<User> GetUsersWithPagination()
        {
            var Page = 1;
            var itemsPerPage = 4;
            var currentPage = (Page-1) *  itemsPerPage;
            var paginatedUser = _users
                                    .Select(i=>i)
                                    .Skip(currentPage)
                                    .Take( itemsPerPage)
                                    .ToList();
            return paginatedUser;
        }
        public void AddBook(Book book)
        {
            Book? exsectBook = _books.Find(findBook => findBook.GetTitle() == book.GetTitle());
            if (exsectBook != null)
            {
                throw new Exception("Book already exists");
            }
            else
            {
                _books.Add(book);
            }
        }
        public List<User> GetUsers()
        {
            return _users;
        }
        public void AddUser(User user)
        {
            User? exsectUser = _users.Find(findUser => findUser.GetName() == user.GetName());
            if (exsectUser != null)
            {
                throw new Exception("User already exists");
            }
            else
            {

                _users.Add(user);
            }
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
                throw new Exception("Book not found");
            }
        }

        public void FindUsers(string name)
        {
            User? users = _users.Find(item => item.GetName() == name);
            if (users != null)
            {
                Console.WriteLine($"The users name is {users.GetName()}");
            }
            else
            {
                throw new Exception("Can't found user");
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
                throw new Exception("Book not found");
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
                throw new Exception("User not found");
            }
        }


        public List<Book> GetBooksByDate(SortType type)
        {
            var Page = 1;
            var itemsPerPage = 4;
            var currentPage = (Page - 1) * itemsPerPage;
            if (type == SortType.ASC)
            {
                List<Book>? AscByDate = _books.OrderBy(book => book.GetDate())
                                        .Select(i => i)
                                        .Skip(currentPage)
                                        .Take(itemsPerPage)
                                        .ToList();
                Console.WriteLine("Sorting date by Ascending");
                return AscByDate;
            }
            if (type == SortType.DESC)
            {
                List<Book>? DescByDate = _books.OrderByDescending(book => book.GetDate())
                                        .Select(i => i)
                                        .Skip(currentPage)
                                        .Take(itemsPerPage)
                                        .ToList();
                Console.WriteLine("Sorting date by Descending");
                return DescByDate;
            }
            else
            {
                Console.WriteLine("Please type ASC or DESC to get sorting");
                return _books;
            }
        }


        public List<User> GetUsersByDate(SortType type)
        {
            var Page = 1;
            var itemsPerPage = 4;
            var currentPage = (Page - 1) * itemsPerPage;
            if (type == SortType.ASC)
            {
                List<User>? AscByDate = _users.OrderBy(user => user.GetDate())
                                        .Select(i=>i)
                                        .Skip(currentPage)
                                        .Take(itemsPerPage)
                                        .ToList();
                Console.WriteLine("Sorting date by Ascending");
                return AscByDate;
            }
            if (type == SortType.DESC)
            {
                List<User>? DescByDate = _users.OrderByDescending(user => user.GetDate())
                                        .Select(i => i)
                                        .Skip(currentPage)
                                        .Take(itemsPerPage)
                                        .ToList();
                Console.WriteLine("Sorting date by Descending");
                return DescByDate;
            }
            else
            {
                Console.WriteLine("Please type ASC or DESC to get sorting");
                return _users;
            }
        }
    }
}