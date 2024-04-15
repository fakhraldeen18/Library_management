using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_library_management.src
{
    public class User : Base
    {
        private string _name;

        public User(string name, DateTime? Date = null)
        {
            this._name = name;
            this.Id = Guid.NewGuid();
            if (Date == null)
            {
                this.Date = DateTime.Now;
            }
            else
            {
                this.Date = (DateTime)Date;
            }
        }

        public string GetName()
        {
            return _name;
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