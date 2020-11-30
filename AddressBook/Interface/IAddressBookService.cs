using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.DTO;

namespace WebApplication4.Interface
{
    interface IAddressBookService
    {
        List<AddressBook> ShowService();

        void AddService(AddressBook Data);

        void DeleteService(AddressBook Data);

        void UpdateService(AddressBook Data);
    }
}
