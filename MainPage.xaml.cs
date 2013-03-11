using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HelloWorldApp
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

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void HelloWorldBtn_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new MessageDialog("Hello world!", "Заголовок");
            dlg.Commands.Add(new UICommand("Команда 1", new UICommandInvokedHandler((args) =>
                {

                })));
            dlg.Commands.Add(new UICommand("Команда 2"));
            dlg.Commands.Add(new UICommand("Команда 3") { Id=3 });
            
            dlg.DefaultCommandIndex = 1;
            dlg.CancelCommandIndex = 3;

            var command = await dlg.ShowAsync();
        }
    }
}
