namespace sda_onsite_2_csharp_library_management.src
{
    public class BaseEntity
    {
        public Guid Id;
        public DateTime Date;

        public BaseEntity(DateTime? Date = null){
            Id = Guid.NewGuid();
            this.Date = Date ?? DateTime.Now; 
        }
        public DateTime GetDate()
        {
            return Date;
        }
        public Guid GetId()
        {
            return Id;
        }
    }
}