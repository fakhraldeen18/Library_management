namespace sda_onsite_2_csharp_library_management.src.Entity
{
    public class EmailNotificationService : INotificationService
    {
        public void SendNotificationOnFailure(string operationAndItemName, string title)
        {
            Console.WriteLine($"We encountered an issue {operationAndItemName} '{title}'. Please review the input data. For more help, visit our FAQ at library.com/faq.");
        }

        public void SendNotificationOnSuccess(string operationAndItemName, string title,string type)
        {
            Console.WriteLine($"Hello, a new {operationAndItemName} '{title}' has been successfully {type} to the Library. If you have any queries or feedback, please contact our support team at support@library.com.");

        }
    }
}