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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WorkFrames.AppData;
using WorkFrames.View.Pages;

namespace WorkFrames
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ClassFrame.FrameMenu = FrameMenuMain;
            FrameMenuMain.Navigate(new PageMenu());

            ClassFrame.FrameLogo = FrameLogoMain;
            FrameLogoMain.Navigate(new PageLogo());

            ClassFrame.FrameTitle = FrameTitleMain;
            FrameTitleMain.Navigate(new PageTitle());

            ClassFrame.FrameBody = FrameBodyMain;
            FrameBodyMain.Navigate(new PageBody());
        }
    }
}
