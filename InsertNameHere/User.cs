using InsertNameHere.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertNameHere
{
    public enum Rank
    {
        Gold, Silver, Bronze
    }
    internal class User : IIdentifiable
    {
        public string UserId;
        public string Username;
        public string Password;
        public string FirstName, LastName;
        public string Email;
        public string PhoneNumber;
        public DateTime CreatedAt;
        public Rank Urank;
        
        public void GetProfile()
        {

        }

        public void CheckPassword()
        { }

        public void Adjust() { }
    }
}
