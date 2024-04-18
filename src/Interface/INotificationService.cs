using System.Runtime.CompilerServices;

namespace sda_onsite_2_csharp_library_management.src.Entity
{
    public interface INotificationService
    {
        void SendNotificationOnSuccess(string operationAndItemName, string title,string type);
        void SendNotificationOnFailure(string operationAndItemName, string title);

    }
}