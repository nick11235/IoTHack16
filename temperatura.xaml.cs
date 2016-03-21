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
    public sealed partial class temperatura : Page
    {
        public float temp;
        public float getTemp()
        {
            Random a = new Random();
            int randomNumber = a.Next(0, 100);
            temp = randomNumber;
            return randomNumber;

        }
        public async void tmp()
        {
            int temp = 3;
            this.InitializeComponent();
            await AzureIoTHub.SendDeviceToCloudMessageAsync(temp.ToString());
            //await AzureIoTHub.ReceiveCloudToDeviceMessageAsync(luminozitate.ToString());
        }
        public temperatura()
        {
            this.InitializeComponent();
        }
        private void home_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage1), null);
        }
    }
}
