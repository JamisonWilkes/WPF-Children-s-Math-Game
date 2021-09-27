using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Assignment5MathGame
{
    /// <summary>
    /// Interaction logic for FinalScore.xaml
    /// </summary>
    public partial class FinalScore : Window
    {
        /// <summary>
        /// This is an object reference to our employee object manager.  Note that we do not create/instantiate the object here.  This object gets
        /// passed into this class via the property below.  That way we are only using one copy of our list of employees for our whole application.
        /// </summary>
        clsUserObjectManager clsMyUserObjectManager;

        /// <summary>
        /// Game class object
        /// </summary>
        clsGame clsMyGame;

        /// <summary>
        /// Main window object
        /// </summary>
        MainWindow wndMainWindow;

        /// <summary>
        /// Method to initialize the Final score window
        /// </summary>
        /// <param name="userObjectManager"></param>
        /// <param name="myGame"></param>
        public FinalScore(clsUserObjectManager userObjectManager, clsGame myGame)
        {
            InitializeComponent();
            clsMyUserObjectManager = userObjectManager;
            clsMyGame = myGame;
            wndMainWindow = new MainWindow();
        }

        /// <summary>
        /// Property where our user object manager gets passed in.
        /// </summary>
        public clsUserObjectManager SetMyUserObjectManager
        {
            set
            {
                clsMyUserObjectManager = value;
            }
        }

        /// <summary>
        /// Method to handle the return to main window button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdReturnMain_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            wndMainWindow.ShowDialog();
        }
    }
}
