using System;
using System.Collections;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GreenPlus.ViewModels;

namespace GreenPlus.Windows
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        public string Username
        {
            get { return txtUsuario.Text; }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, RoutedEventArgs e)
        {
           if(txtUsuario.Text == "Admin" && Senha.Password == "Admin")
            {
                this.Hide();
                var window = new MainWindow();
                window.Show();

            }else
            {
                MessageBox.Show("Não está funcionando");
            }
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        
    }
}
