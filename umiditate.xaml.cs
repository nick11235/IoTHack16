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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace testapp2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class umiditate : Page
    {
        public float ud;
        public umiditate()
        {
            this.InitializeComponent();
        }
        private void home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage1), null);
        }
        public float getUd()
        {
            Random a = new Random();
            int randomNumber = a.Next( 0, 100);
            ud = randomNumber;
            return randomNumber;

        }
        public async void uda()
        {
            int ud = 3;
            this.InitializeComponent();
            await AzureIoTHub.SendDeviceToCloudMessageAsync(ud.ToString());
            //await AzureIoTHub.ReceiveCloudToDeviceMessageAsync(luminozitate.ToString());
        }

        private void home_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
