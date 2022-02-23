﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class ManipulateContact
    {
        List<ContactDetails> AddressBookList = new List<ContactDetails>();
        public void AddingContact
            (
            string Name,
            string Address,
            string City,
            string State,
            string ZipCode,
            string PhoneNumber,
            string Email
            )
        {
            AddressBookList.Add
                (new ContactDetails()
                {
                    Name = Name,
                    Address = Address,
                    City = City,
                    State = State,
                    ZipCode = ZipCode,
                    PhoneNumber = PhoneNumber,
                    Email = Email
                }
            );
            Console.WriteLine($"{Name} is added");
        }
    }

    internal class ContactDetails
    {
        public ContactDetails()
        {
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
