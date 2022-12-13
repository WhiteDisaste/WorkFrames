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

namespace WorkFrames.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PageLogoDirector());
            ClassFrame.FrameBody.Navigate(new PageBodyDirector());
        }

        private void Law_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PageLogoLawyer());
            ClassFrame.FrameBody.Navigate(new PageBodyLawyer());
        }

        private void Bux_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PageLogoBux());
            ClassFrame.FrameBody.Navigate(new PageBodyBux());
        }

        private void Eng_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PageLogoEnjneer());
            ClassFrame.FrameBody.Navigate(new PageBodyEngineer());
        }

        private void Meng_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PageLogoManager());
            ClassFrame.FrameBody.Navigate(new PageBodyManager());
        }

        private void Sysa_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameLogo.Navigate(new PageLogoSysadmin());
            ClassFrame.FrameBody.Navigate(new PageBodySysadmin());
        }
    }
}
