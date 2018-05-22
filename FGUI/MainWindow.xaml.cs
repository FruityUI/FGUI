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

namespace FGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Frame[] pages = new Frame[4]
        {
            new Frame() { Content = new Pages.Debug() },
            new Frame() { Content = new Pages.News() },
            new Frame() { Content = new Pages.Installer() },
            new Frame() { Content = new Pages.Settings() }
        };

        public MainWindow()
        {
            InitializeComponent();
            Loaded += onLoaded;

            // 
            Style style = new Style();
            style.Setters.Add(new Setter(UIElement.VisibilityProperty, Visibility.Collapsed));
            book.ItemContainerStyle = style;

            for (int i = 0; i < pages.Count(); i++)
            {
                Frame frame = pages[i];
                Abstract.Page page = (frame.Content as Abstract.Page);

                Console.WriteLine(page.pName);
            }


        }




        private void onLoaded(Object sender, RoutedEventArgs e)
        {



        }

    }
}
