using sda_onsite_2_csharp_library_management.src.Entity;

namespace sda_onsite_2_csharp_library_management.src
{
    public class Library
    {

        private readonly List<Book> _books;
        private readonly List<User> _users;
        private INotificationService _notificationService;
        private string _name;
        public Library(string name, INotificationService notificationService)
        {
            _books = new List<Book>();
            _users = new List<User>();
            _name = name;
            _notificationService = notificationService;
        }


        public List<Book> GetBooks()
        {
            return _books;
        }
        public List<Book> GetBooks(int Page)
        {

            var itemsPerPage = 4;
            var Offset = (Page - 1) * itemsPerPage;
            var paginatedBook = _books
                                    .Select(i => i)
                                    .Skip(Offset)
                                    .Take(itemsPerPage)
                                    .ToList();
            return paginatedBook;
        }

        public List<User> GetUsers()
        {
            return _users;
        }

        public List<User> GetUsers(int Page)
        {

            var itemsPerPage = 4;
            var Offset = (Page - 1) * itemsPerPage;
            var paginatedUser = _users
                                    .Select(i => i)
                                    .Skip(Offset)
                                    .Take(itemsPerPage)
                                    .ToList();
            return paginatedUser;
        }
        public void AddBook(Book book)
        {
            Book? exsectBook = _books.Find(findBook => findBook.GetTitle() == book.GetTitle());
            if (exsectBook != null)
            {
                _notificationService.SendNotificationOnFailure("adding book", book.GetTitle());
            }
            else
            {
                _books.Add(book);
                _notificationService.SendNotificationOnSuccess("book titled", book.GetTitle(),"added");
            }
        }
        public void AddUser(User user)
        {
            User? exsectUser = _users.Find(findUser => findUser.GetName() == user.GetName());
            if (exsectUser != null)
            {
                _notificationService.SendNotificationOnFailure("adding user", user.GetName());
            }
            else
            {
                _users.Add(user);
                _notificationService.SendNotificationOnSuccess("user name", user.GetName(),"added");
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
                Console.WriteLine("Book not found");
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
                Console.WriteLine("User not found");
            }
        }


        public void DeleteBook(Book deletedBook)
        {
            Book? deleteById = _books.Find(book => book.GetId() == deletedBook.GetId());
            if (deleteById != null)
            {
                _books.Remove(deleteById);
                _notificationService.SendNotificationOnSuccess("book titled", deletedBook.GetTitle(), "deleted");
            }
            else
            {
                _notificationService.SendNotificationOnFailure("deleting book", deletedBook.GetTitle());
            }
        }


        public void DeleteUser(User deletedUser)
        {
            User? deleteById = _users.Find(user => user.GetId() == deletedUser.GetId());
            if (deleteById != null)
            {
                _users.Remove(deleteById);
                _notificationService.SendNotificationOnSuccess("user name", deletedUser.GetName(), "deleted");
            }
            else
            {
                _notificationService.SendNotificationOnFailure("deleting user", deletedUser.GetName());
            }
        }


        public List<Book> GetBooksByDate(SortType type)
        {

            if (type == SortType.ASC)
            {
                List<Book>? AscByDate = _books.OrderBy(book => book.GetDate()).ToList();
                Console.WriteLine("Sorting date by Ascending");
                return AscByDate;
            }
            if (type == SortType.DESC)
            {
                List<Book>? DescByDate = _books.OrderByDescending(book => book.GetDate()).ToList();
                Console.WriteLine("Sorting date by Descending");
                return DescByDate;
            }
            else
            {
                Console.WriteLine("Please type ASC or DESC to get sorting");
                return _books;
            }
        }
        public List<Book> GetBooksByDate(SortType type, int Page)
        {

            var itemsPerPage = 4;
            var Offset = (Page - 1) * itemsPerPage;
            if (type == SortType.ASC)
            {
                List<Book>? AscByDate = _books.OrderBy(book => book.GetDate())
                                        .Select(i => i)
                                        .Skip(Offset)
                                        .Take(itemsPerPage)
                                        .ToList();
                Console.WriteLine("Sorting date by Ascending");
                return AscByDate;
            }
            if (type == SortType.DESC)
            {
                List<Book>? DescByDate = _books.OrderByDescending(book => book.GetDate())
                                        .Select(i => i)
                                        .Skip(Offset)
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

            if (type == SortType.ASC)
            {
                List<User>? AscByDate = _users.OrderBy(user => user.GetDate()).ToList();
                Console.WriteLine("Sorting date by Ascending");
                return AscByDate;
            }
            if (type == SortType.DESC)
            {
                List<User>? DescByDate = _users.OrderByDescending(user => user.GetDate()).ToList();
                Console.WriteLine("Sorting date by Descending");
                return DescByDate;
            }
            else
            {
                Console.WriteLine("Please type ASC or DESC to get sorting");
                return _users;
            }
        }
        public List<User> GetUsersByDate(SortType type, int Page)
        {

            var itemsPerPage = 4;
            var Offset = (Page - 1) * itemsPerPage;
            if (type == SortType.ASC)
            {
                List<User>? AscByDate = _users.OrderBy(user => user.GetDate())
                                        .Select(i => i)
                                        .Skip(Offset)
                                        .Take(itemsPerPage)
                                        .ToList();
                Console.WriteLine("Sorting date by Ascending");
                return AscByDate;
            }
            if (type == SortType.DESC)
            {
                List<User>? DescByDate = _users.OrderByDescending(user => user.GetDate())
                                        .Select(i => i)
                                        .Skip(Offset)
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