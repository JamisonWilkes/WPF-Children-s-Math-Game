using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Assignment5MathGame
{

    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
       
        /// <summary>
        /// Class to manage user object
        /// </summary>
        clsUserObjectManager clsMyUserObjectManager;

        /// <summary>
        /// Game class
        /// </summary>
        clsGame clsMyGame;

        /// <summary>
        /// Class for the timer
        /// </summary>
        DispatcherTimer MyTimer;

        /// <summary>
        /// Variable to hold the number of question
        /// </summary>
        private int iQuestionNumber = 1;

        /// <summary>
        /// Variable to hold the number of right answers
        /// </summary>
        private int iTotalRight = 0;

        /// <summary>
        /// Variable to hold the number of wrong answers
        /// </summary>
        private int iTotalWrong = 0;

        /// <summary>
        /// Variable to hold the timer time
        /// </summary>
        int MyTimerTime;

        /// <summary>
        /// Class object to create a new instance of a media player object
        /// </summary>
        MediaPlayer medPlayer = new MediaPlayer();

        /// <summary>
        /// Method to initialize the GameWindow 
        /// </summary>
        /// <param name="userObjectManager"></param>
        /// <param name="myGame"></param>
        public GameWindow(clsUserObjectManager userObjectManager, clsGame myGame)
        {
            InitializeComponent();
            clsMyUserObjectManager = userObjectManager;
            clsMyGame = myGame;

            //Instantiate the DispatcherTimer
            MyTimer = new DispatcherTimer();
            //Make the timer go off every second
            MyTimer.Interval = TimeSpan.FromSeconds(1);
            //Tell it which method will handle the click event
            MyTimer.Tick += new EventHandler(MyTimer_Tick);

        }
        
        /// <summary>
        /// Method to hanled the start game button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdStartGame_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lblTime.Content = "Time:   " ;
                MyTimerTime = 0;
                MyTimer.Start();

                btnSubmit.IsEnabled = true;
                txtUserAnswer.IsEnabled = true;

                lblQuestionNumber.Content = "Quesetion # " + iQuestionNumber.ToString() + ":";

                //Generates the random numbers
                clsMyGame.GenRandomNum();

                //Displays the numbers to the user
                DisplayNumbers();

                //Displays the operation
                DisplayOperation();

                //Clear the screen
                txtUserAnswer.Text = "";
                lblRightWrongAnswer.Content = "";

                btnStart.IsEnabled = false;
            }
            catch(Exception ex)
            {
                //This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
            finally
            {
                    
            }

        }

        /// <summary>
        /// This method handles the click submit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //while (iQuestionNumber < 10)
                //{
                iQuestionNumber++;

                int iResult;
                int iUserGuess;
                bool bNumbersMatch = false;

                iUserGuess = Int32.Parse(txtUserAnswer.Text);

                //Calculate the result and find out if the user's guess is correct
                iResult = clsMyGame.calcMath(iUserGuess, ref bNumbersMatch);

                if (bNumbersMatch == true)
                {
                    lblRightWrongAnswer.Content = "You are right!!!";
                    iTotalRight++;
                    //iAmGroot.Play();
                    medPlayer.Open(new Uri("groot.wav", UriKind.Relative)); 
                    medPlayer.Play();
                }
                else
                {
                    lblRightWrongAnswer.Content = "You are wrong!!!";
                    iTotalWrong++;
                    //hulkSmash.Play();
                    medPlayer.Open(new Uri("smash.wav", UriKind.Relative));
                    medPlayer.Play();
                }

                
                clsMyGame.GenRandomNum();
                DisplayNumbers();
                DisplayOperation();

                lblQuestionNumber.Content = "Question # " + iQuestionNumber.ToString() + ":" ;

                //txtUserAnswer.Text = " ";

                //} 
                if(iQuestionNumber == 11)
                {
                    MyTimer.Stop();

                    lblRightWrongAnswer.Content = "Game Over!";
                    lblQuestionNumber.Content = " ";
                    btnSubmit.IsEnabled = false;
                    txtUserAnswer.IsEnabled = false;
                    lblTotalRight.Content = iTotalRight.ToString();
                    lblTotalWrong.Content = iTotalWrong.ToString();

                    clsMyGame.iRight = iTotalRight;
                    clsMyGame.iWrong = iTotalWrong;
                    clsMyGame.iTime = MyTimerTime;

                    this.Hide();
                    FinalScore wndFinalScore = new FinalScore(clsMyUserObjectManager, clsMyGame);
                    if (clsMyGame.iRight > 7)
                    {
                        ImageBrush myBrush = new ImageBrush(new BitmapImage(new Uri(@"images/babyCaptainAmerica.png", UriKind.Relative)));

                        wndFinalScore.Background = myBrush;
                    }
                    else if (clsMyGame.iRight > 4 && clsMyGame.iRight < 7)
                    {
                        ImageBrush myBrush = new ImageBrush(new BitmapImage(new Uri(@"images/littleThor.png", UriKind.Relative)));

                        wndFinalScore.Background = myBrush;
                    }
                    else if (clsMyGame.iRight < 5)
                    {
                        ImageBrush myBrush = new ImageBrush(new BitmapImage(new Uri(@"images/babyFlash.png", UriKind.Relative)));

                        wndFinalScore.Background = myBrush;
                        
                    }
                    wndFinalScore.lblUserAndFinalScore.Content = clsMyUserObjectManager.CreateUserString();
                    wndFinalScore.lblTotalRight.Content = clsMyGame.iRight;
                    wndFinalScore.lblTotalWrong.Content = clsMyGame.iWrong;
                    wndFinalScore.lblUserTotalTime.Content = clsMyGame.iTime.ToString() + " Seconds";
                    wndFinalScore.ShowDialog();

                }

            }
            catch (Exception ex)
            {
                //This is the top level method so we want to handle the exception
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                            MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
            finally
            {

            }


        }


        /// <summary>
        /// This method displays the operation
        /// </summary>
        private void DisplayOperation()
        {
            try
            {
                if (clsMyGame.bAddition == true)
                {
                    lblOperation.Content = "+";
                }
                else if (clsMyGame.bSubtraction == true)
                {
                    lblOperation.Content = "-";
                }
                else if (clsMyGame.bMultiplication == true)
                {
                    lblOperation.Content = "*";
                }
                else if (clsMyGame.bDivision == true)
                {
                    lblOperation.Content = "/";
                }
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }

        /// <summary>
        /// This method displays the two random numbers.
        /// </summary>
        private void DisplayNumbers()
        {
            try
            {
                lblRandomNum1.Content = clsMyGame.iFirstNumber.ToString();
                lblRandomNum2.Content = clsMyGame.iSecondNumber.ToString();
               
            }
            catch (Exception ex)
            {
                //Just throw the exception
                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                    MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }
            
        }


        /// <summary>
        /// Goes off when the timer ticks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MyTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                MyTimerTime++;
                lblTimer.Content = MyTimerTime.ToString();
            }
            catch (Exception ex)
            {
                //Just throw the exception
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

        /// <summary>
        /// Makes you only able to type in numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUserAnswer_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //Only allow numbers to be entered
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

                if (e.Key == Key.Return)
                {
                    cmdSubmit_Click(sender, e);
                }
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                   MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }


        }

        /// <summary>
        /// Mehtod to cancel the game and return to the main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCancel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MyTimer.Stop();

                MainWindow wndMainWindow = new MainWindow();
                this.Hide();
                wndMainWindow.ShowDialog();
            }
            catch (Exception ex)
            {

                throw new Exception(MethodInfo.GetCurrentMethod().DeclaringType.Name + "." +
                                   MethodInfo.GetCurrentMethod().Name + " -> " + ex.Message);
            }

        }
    }
}
