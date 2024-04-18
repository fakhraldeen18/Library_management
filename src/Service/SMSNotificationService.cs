namespace sda_onsite_2_csharp_library_management.src.Entity
{
    public class SMSNotificationService : INotificationService
    {

        public void SendNotificationOnFailure(string operationAndItemName, string title)
        {
            Console.WriteLine($"Error {operationAndItemName} '{title}'. Please email support@library.com.");
        }

        public void SendNotificationOnSuccess(string operationAndItemName, string title, string type)
        {
            Console.WriteLine($"{operationAndItemName} '{title}' {type} to Library. Thank you!");
        }
    }
}