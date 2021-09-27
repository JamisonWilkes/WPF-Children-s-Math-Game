using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment5MathGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Class object to help manage the user
        /// </summary>
        clsUserObjectManager clsUserObjectManager;

        /// <summary>
        /// Class for the Game
        /// </summary>
        clsGame clsGame;


        /// <summary>
        /// This initializes the program
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();


            //MAKE SURE TO INCLUDE THIS LINE OR THE APPLICATION WILL NOT CLOSE
            //BECAUSE THE WINDOWS ARE STILL IN MEMORY
            Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;///////////////////////////////////////////////////////////

            //wndFinalScoreForm = new FinalScore();
            //wndGameForm = new GameWindow(userObjectManager);

            clsUserObjectManager = new clsUserObjectManager();
        }


        /// <summary>
        /// Opens up the game window and validates the user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPlayGame_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                clsGame = new clsGame();

                if (txtUserFirstName.Text.Length == 1 || txtUserLastName.Text.Length == 1)
                {
                    lblInvalidInput.Foreground = Brushes.Red;
                    lblInvalidInput.Content = "Please enter in a First or last Name";
                }

                if (txtUserAge.Text.Length == 1 || ((Convert.ToInt32(txtUserAge.Text) < 3 || Convert.ToInt32(txtUserAge.Text) > 10)))
                {
                    lblInvalidInput.Foreground = Brushes.Red;
                    lblInvalidInput.Content = "Please enter in an Age between 3 and 10";
                }

                if (rbAddition.IsChecked == false && rbDivision.IsChecked == false && rbMultiplication.IsChecked == false && rbSubtraction.IsChecked == false)
                {
                    lblInvalidInput.Content = "Please choose a game type";
                }



                if (rbAddition.IsChecked == true)
                {
                    clsGame.bAddition = true;
                }
                else if (rbSubtraction.IsChecked == true)
                {
                    clsGame.bSubtraction = true;
                }
                else if (rbMultiplication.IsChecked == true)
                {
                    clsGame.bMultiplication = true;
                }
                else if (rbDivision.IsChecked == true)
                {
                    clsGame.bDivision = true;
                }
                
                clsUserObjectManager.AddNewUser(txtUserFirstName.Text, txtUserLastName.Text, Convert.ToInt32(txtUserAge.Text));
                lblMessage.Content = "Created new user: " + txtUserFirstName.Text + " " + txtUserLastName.Text + " " + txtUserAge.Text;


                GameWindow wndGameWindow = new GameWindow(clsUserObjectManager, clsGame);

                this.Hide();
                wndGameWindow.ShowDialog();
                

            }
            catch(Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                           MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
            finally
            {

            }
        }

        /// <summary>
        /// Makes you only able to type in numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUserAge_PreviousKeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (!((e.Key >= Key.D0 && e.Key <= Key.D9) ||
                  e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9))
                {
                    //Allow the user to use the backspace and delete keys
                    if (!(e.Key == Key.Back || e.Key == Key.Delete))
                    {
                        //No other keys allowed besides numbers, backspace, and delete
                        e.Handled = true;
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
        /// Handle the error.
        /// </summary>
        /// <param name="sClass">The class in which the error occurred in.</param>
        /// <param name="sMethod">The method in which the error occurred in.</param>
        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                //Would write to a file or database here.
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("C:\\Error.txt", Environment.NewLine +
                                             "HandleError Exception: " + ex.Message);
            }
        }

    }
}
