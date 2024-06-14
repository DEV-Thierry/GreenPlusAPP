using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenPlus.Views;


namespace GreenPlus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SideBar_MouseEnter(object sender, MouseEventArgs e)
        {
            var animacaoLargura = new DoubleAnimation
            {
                From = 60,
                To = 200,
                Duration = TimeSpan.FromSeconds(0.3)
            };
            SideBar.BeginAnimation(WidthProperty, animacaoLargura);

            txtCadastro.Visibility = Visibility.Visible;
            txtHome.Visibility = Visibility.Visible;
            txtProducao.Visibility = Visibility.Visible;
            txtEstoque.Visibility = Visibility.Visible;
        }

        private void SideBar_MouseLeave(object sender, MouseEventArgs e)
        {
            var animacaoLargura = new DoubleAnimation
            {
                From = 200,
                To = 60,
                Duration = TimeSpan.FromSeconds(0.3)
            };
            SideBar.BeginAnimation(WidthProperty,animacaoLargura);

            ConteudoDrop.Visibility = Visibility.Collapsed;

            txtCadastro.Visibility= Visibility.Collapsed;
            txtHome.Visibility= Visibility.Collapsed;
            txtProducao.Visibility= Visibility.Collapsed;
            txtEstoque.Visibility= Visibility.Collapsed;
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            if (ConteudoDrop.Visibility == Visibility.Collapsed) 
            
                ConteudoDrop.Visibility = Visibility.Visible;
            else
                ConteudoDrop.Visibility = Visibility.Collapsed;
        }
    }
}