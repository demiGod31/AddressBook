using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.DTO;
using WebApplication4.Controllers;
using System.Data.SqlClient;
using WebApplication4.DAL;
using System.Data;
using WebApplication4.Interface;
using StructureMap;

namespace WebApplication4.Services
{
    public class AddressBookService : IAddressBookService
    {
        private IAddressBookAddWrite _addressBookAddWrite;
        IAddressBookDeleteWrite _addressBookDeleteWrite;
        IAddressBookShowRead _addressBookShowRead;
        IAddressBookUpdateWrite _addressBookUpdateWrite;


        public AddressBookService(IContainer _container)
        {
            _addressBookAddWrite = _container.GetInstance<IAddressBookAddWrite>();
            _addressBookDeleteWrite = _container.GetInstance<IAddressBookDeleteWrite>();
            _addressBookShowRead = _container.GetInstance<IAddressBookShowRead>();
            _addressBookUpdateWrite = _container.GetInstance<IAddressBookUpdateWrite>();
        }
        public List<AddressBook> ShowService()
        {                     
            return (_addressBookShowRead.Read());
        }
        public void AddService(AddressBook Data)
        {
            _addressBookAddWrite.Add(Data);
        }

        public void DeleteService(AddressBook Data)
        {
            _addressBookDeleteWrite.delete(Data);
        }

        public void UpdateService(AddressBook Data)
        {
            _addressBookUpdateWrite.Update(Data);
        }
    }
}