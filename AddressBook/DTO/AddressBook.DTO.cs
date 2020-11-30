using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebApplication4.DTO
{
    [DataContract]
    public class AddressBook
    {
        [DataMember]
        public int eId { get; set; }
        [DataMember]
        public string eName { get; set; }
        [DataMember]
        public string eNumber { get; set; }
    }
}
