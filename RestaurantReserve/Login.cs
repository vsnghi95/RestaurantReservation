using Service.Models;
using Service.Repository;
namespace RestaurantReserve
{

    public partial class Login : Form
    {
        AccountRepo account;
        public Login()
        {
            InitializeComponent();
            account = new AccountRepo();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            var check = account.GetAll().Where(x => x.Username == user && x.Password == pass);

            if (check.Any())
            {
                MessageBox.Show("Successful", "Welcome");
            } else
            {
                MessageBox.Show("You are not allow to enter the application", "Warning");
            }
        }
    }
}