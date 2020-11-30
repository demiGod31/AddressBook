using StructureMap;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication4.DTO;
using WebApplication4.Interface;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    public class AddressBookController : ApiController
    {

        private IAddressBookService _addressBookService;

        public AddressBookController(IContainer _container)
        {
           _addressBookService= _container.GetInstance<IAddressBookService>();
        }
        [HttpGet]
        public List<AddressBook> Show()
        {

            return (_addressBookService.ShowService());
        }

        [HttpPost]
        public string Add(AddressBook data)
        {
            _addressBookService.AddService(data);
            return ("ok");
        }

        [HttpPost]
        public string Delete(AddressBook data)
        {
            _addressBookService.DeleteService(data);
            return ("ok");
        }

        [HttpPost]
        public string Update(AddressBook data)
        {
            _addressBookService.UpdateService(data);
            return ("ok");
        }
    }
}
