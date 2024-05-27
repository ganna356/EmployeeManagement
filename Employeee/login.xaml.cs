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

namespace Employeee
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        EmployeeManagementEntities1 db = new EmployeeManagementEntities1();
        public login()
        {
            InitializeComponent();
        }

            private void Button_Click(object sender, RoutedEventArgs e)
            {
                C_admin ad = new C_admin();
                var findname = db.C_admin.FirstOrDefault(x => x.Username == l_name.Text);
                var findpass = db.C_admin.FirstOrDefault(x => x.C_Password == l_pass.Password);
                if (findname != null && findpass != null)
                {
                    search ss = new search();
                    this.NavigationService.Navigate(ss);
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
    }
}
