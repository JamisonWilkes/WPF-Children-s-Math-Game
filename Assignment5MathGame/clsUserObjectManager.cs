using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5MathGame
{
    public class clsUserObjectManager
    {
        /// <summary>
        /// A list of Usersis list is created then passed around between objects so that only one list of users exists in the program.
        /// </summary>
        public List<clsUser> lstUsers { get; set; }

        /// <summary>
        /// Constructor to create the user list
        /// </summary>
        public clsUserObjectManager()
        {
            try
            {
                lstUsers = new List<clsUser>();
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            
        }

        /// <summary>
        /// Add a new employee to the list.
        /// </summary>
        /// <param name="FirstName">First name.</param>
        /// <param name="LastName">Last name.</param>
        /// <param name="Salary">Salary.</param>
        public void AddNewUser(string FirstName, string LastName, int Age)
        {
            try
            {
                lstUsers.Add(new clsUser { sFirstName = FirstName, sLastName = LastName, iAge = Age });
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// Create a string to report the employee data.
        /// </summary>
        /// <returns>String of employee data.</returns>
        public string CreateUserString()
        {
            try
            {
                string sDataToReport = "";

                foreach (clsUser clsMyUser in lstUsers)
                {
                    sDataToReport += clsMyUser.sFirstName + " " + clsMyUser.sLastName + "      " + clsMyUser.iAge.ToString();
                }

                return sDataToReport;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }
    }
}
