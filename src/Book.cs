using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_library_management.src
{
    public class Book:Base
    {

        private string _title;
        public Book(string title , DateTime?Date = null){
            this.Id = Guid.NewGuid();
            this._title = title;
            if (Date == null){
            this.Date = DateTime.Now;
            }
            else{
                this.Date = (DateTime)Date;
            }
        }

        public Guid GetId()
        {
            return Id;
        }
        public string GetTitle()
        {
            return _title;
        }
        public DateTime GetDate()
        {
            return Date;
        }
    }
}