namespace sda_onsite_2_csharp_library_management.src
{
    public class User : BaseEntity
    {
        private string _name;

        public User(string name, DateTime? date = null) :base(date)
        {
            this._name = name;
        }
        public string GetName()
        {
            return _name;
        }
    }
}