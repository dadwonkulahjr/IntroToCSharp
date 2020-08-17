using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToCSharp
{
    //0 - Unknown
    //1 - Male
    //2 - Female
    public class Customer 
    {
        #region Auto Implemented Properties
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Id { get; set; }
        protected string Message { get; set; }

        #endregion

        #region Methods
        public static List<Customer> GetPeople()
        {
            return new List<Customer>()
            {
                new Customer(){Name="Mark", Gender=Gender.Male},
                new Customer(){Name="Mary", Gender=Gender.Female},
                new Customer(){Name="Sam", Gender=Gender.Unknown},
                new Customer(){Name="Princess", Gender=Gender.Unknown}
            };
        }
      
        public async static void GetArrayOfCustomers()
        {
            Customer[] customers = new Customer[3];

            customers[0] = new Customer() { Name = "Prince Smith", Gender = Gender.Male };
            customers[1] = new Customer() { Name = "Rita Peterson", Gender = Gender.Female };
            customers[2] = new Customer() { Name = "John Brown", Gender = Gender.Male };

            for (int i = 0; i < customers.Length; i++)
            {
              Console.WriteLine($"Name: {customers[i].Name} && Gender : {customers[i].Gender}");
            }

            await new System.Threading.Tasks.Task(new Action(GetArrayOfCustomers));
        }

        public static string CheckPersonGender(int gender)
        {
            if (gender == 0)
            {
                return "Unknown";
            }
            else if (gender == 1)
            {
                return "Male";
            }
            else if (gender == 2)
            {
                return "Female";
            }
            else
            {
                return "Invalid data detected.";
            }
        }

        
        #endregion
    }

    #region Gender Enum
    public enum Gender : short
    {
        Unknown = 0,
        Male, 
        Female
    }
    #endregion
}
