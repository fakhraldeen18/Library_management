namespace sda_onsite_2_csharp_library_management.src
{
    public class Book: BaseEntity
    {

        private string _title;
        public Book(string title , DateTime? date = null):base(date)
        {
            _title = title;
        }
        public string GetTitle()
        {
            return _title;
        }
    }
}