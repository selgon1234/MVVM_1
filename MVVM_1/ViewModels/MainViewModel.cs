using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_1.Models;
namespace MVVM_1.ViewModels
{
    public class MainViewModel
    {
        DataManager dataManager = new DataManager();
        public string GetFirstName()
        {
            string firstName = dataManager.ImportantPerson.FirstName;
            return firstName;
        }
        public string GetLastName()
        {
            string lastName = dataManager.ImportantPerson.LastName;
            return lastName;
        }
    }
}
