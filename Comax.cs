using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToCSharp
{
    #region Struct Type
    public struct Comax
    {
        #region Auto Implemented Propertities
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        #endregion

        #region Default Constructor & Developer Constructor
        public Comax(int id, string firstName, string lastName, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = null;
        }
        public Comax(int id, string firstName, string lastName, string email, string gender)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;
            
        }
        #endregion
    }
    #endregion


}
