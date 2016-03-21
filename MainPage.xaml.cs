using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace testapp2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }
        //Metoda(delegate-ul) ce este apelata la apasarea butonului
        private void login_Click(object sender, RoutedEventArgs e)
        {
            //Clasa NavigationService contine metode utile navigarii intre pagini. 
            //http://msdn.microsoft.com/en-us/library/system.windows.navigation.navigationservice(v=vs.110).aspx
            //Accesarea unei pagini/ transmiterea de parametrii se face ca in navigarea web /exemplu.xaml?p1=a&p2=b&p3=c
        this.Frame.Navigate(typeof(BlankPage1), null);
        }

    }
}
