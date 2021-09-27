using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5MathGame
{
    public class clsGame
    {
        /// <summary>
        /// Object to manage user
        /// </summary>
        clsUserObjectManager clsMyUserObjectManager;

        /// <summary>
        /// Boolean to hold addition info
        /// </summary>
        public bool bAddition = false;

        /// <summary>
        /// Boolean to hold subtaction info
        /// </summary>
        public bool bSubtraction = false;

        /// <summary>
        /// Boolean to hold multiplication info
        /// </summary>
        public bool bMultiplication = false;

        /// <summary>
        /// Boolean to hold division info
        /// </summary>
        public bool bDivision = false;

        /// <summary>
        /// Int to hold the answer to question
        /// </summary>
        public int answer;

        /// <summary>
        /// Into to hold nubmer of right answers
        /// </summary>
        public int iRight;

        /// <summary>
        /// Int to hold number of wrong answers
        /// </summary>
        public int iWrong;

        /// <summary>
        /// int to hold total time
        /// </summary>
        public int iTime;

        /// <summary>
        /// into to hold the first random number
        /// </summary>
        public int iFirstNumber;

        /// <summary>
        /// int to hold the second random number
        /// </summary>
        public int iSecondNumber;

        /// <summary>
        /// Method to set the user manager object for future development 
        /// </summary>
        public clsUserObjectManager SetMyUserObjectManager
        {
            set
            {
                clsMyUserObjectManager = value;
            }
        }

        /// <summary>
        /// Method to calculate the answer
        /// </summary>
        /// <param name="iGuessedNumber"></param>
        /// <param name="bIsMatch"></param>
        /// <returns></returns>
        public int calcMath(int iGuessedNumber, ref bool bIsMatch)
        {
            try
            {

                if (bAddition == true)
                {
                    calcAddition();
                }
                else if (bSubtraction == true)
                {
                    calcSubtraction();
                }
                else if (bMultiplication == true)
                {
                    calcMultiplication();
                }
                else if (bDivision == true)
                {
                    calcDivision();
                }

                if (answer == iGuessedNumber)
                {
                    bIsMatch = true;
                }
                else
                {
                    bIsMatch = false;
                }

                return answer;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }

        /// <summary>
        /// display the addition
        /// </summary>
        public int calcAddition()
        {

            try
            {
                answer = iFirstNumber + iSecondNumber;
                return answer;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// display the subtraction
        /// </summary>
        public int calcSubtraction()
        {
            try
            {
                answer = iFirstNumber - iSecondNumber;
                return answer;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// display the multiplication
        /// </summary>
        public int calcMultiplication()
        {
            try
            {
                answer = iFirstNumber * iSecondNumber;
                return answer;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }

        /// <summary>
        /// display the division
        /// </summary>
        public int calcDivision()
        {
            try
            {
                answer = iFirstNumber / iSecondNumber;
                return answer;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
        }


        /// <summary>
        /// this method generates and displays the randome numbers
        /// </summary>
        public void GenRandomNum()
        {
            try
            {
                //Create a random number object
                Random rndNumber = new Random();

                if (bAddition == true || bMultiplication == true)
                {
                    iFirstNumber = rndNumber.Next(0, 11);
                    iSecondNumber = rndNumber.Next(0, 11);
                }
                else if (bSubtraction == true)
                {
                    iFirstNumber = rndNumber.Next(1, 11);
                    if (iFirstNumber == 0)
                    {
                        iSecondNumber = 0;
                    }
                    else if (iFirstNumber == 1)
                    {
                        iSecondNumber = rndNumber.Next(0, 2);
                    }
                    else if (iFirstNumber == 2)
                    {
                        iSecondNumber = rndNumber.Next(0, 3);
                    }
                    else if (iFirstNumber == 3)
                    {
                        iSecondNumber = rndNumber.Next(0, 4);
                    }
                    else if (iFirstNumber == 4)
                    {
                        iSecondNumber = rndNumber.Next(0, 5);
                    }
                    else if (iFirstNumber == 5)
                    {
                        iSecondNumber = rndNumber.Next(0, 6);
                    }
                    else if (iFirstNumber == 6)
                    {
                        iSecondNumber = rndNumber.Next(0, 7);
                    }
                    else if (iFirstNumber == 7)
                    {
                        iSecondNumber = rndNumber.Next(0, 8);
                    }
                    else if (iFirstNumber == 8)
                    {
                        iSecondNumber = rndNumber.Next(0, 9);
                    }
                    else if (iFirstNumber == 9)
                    {
                        iSecondNumber = rndNumber.Next(0, 10);
                    }
                    else if (iFirstNumber == 10)
                    {
                        iSecondNumber = rndNumber.Next(0, 11);
                    }

                }

                else if (bDivision == true)
                {
                    iFirstNumber = rndNumber.Next(0, 11);
                    if (iFirstNumber == 0)
                    {
                        iSecondNumber = rndNumber.Next(0, 11);
                    }
                    else if (iFirstNumber == 1)
                    {
                        iSecondNumber = 1;
                    }
                    else if (iFirstNumber == 2)
                    {
                        iSecondNumber = rndNumber.Next(1, 3);
                    }
                    else if (iFirstNumber == 3)
                    {
                        iSecondNumber = random_except_list(3, new int[] { 0, 2 });
                    }
                    else if (iFirstNumber == 4)
                    {
                        iSecondNumber = random_except_list(4, new int[] { 0, 3 });
                    }
                    else if (iFirstNumber == 5)
                    {
                        iSecondNumber = random_except_list(5, new int[] { 0, 2, 3, 4 });
                    }
                    else if (iFirstNumber == 6)
                    {
                        iSecondNumber = random_except_list(6, new int[] { 0, 4, 5 });
                    }
                    else if (iFirstNumber == 7)
                    {
                        iSecondNumber = random_except_list(7, new int[] { 0, 2, 3, 4, 5, 6 });
                    }
                    else if (iFirstNumber == 8)
                    {
                        iSecondNumber = random_except_list(8, new int[] { 0, 3, 5, 6, 7 });
                    }
                    else if (iFirstNumber == 9)
                    {
                        iSecondNumber = random_except_list(9, new int[] { 0, 2, 4, 5, 6, 7, 8 });
                    }
                    else if (iFirstNumber == 10)
                    {
                        iSecondNumber = random_except_list(10, new int[] { 0, 3, 4, 6, 7, 8, 9 });
                    }
                }

            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }

        /// <summary>
        /// method to skip values that are randomly generated 
        /// from https://stackoverflow.com/questions/18484577/how-to-get-a-random-number-from-a-range-excluding-some-values
        /// </summary>
        /// <param name="n"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int random_except_list(int n, int[] x)
        {
            try
            {
                Random r = new Random();
                int result = r.Next(n - x.Length);

                for (int i = 0; i < x.Length; i++)
                {
                    if (result < x[i])
                        return result;
                    result++;
                }
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
           
        }
    }
}
