using System;

namespace AddressBookSystem
{
    public class Contacts
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        internal void Add(Contacts contact)
        {
            throw new NotImplementedException();
        }
    }
}