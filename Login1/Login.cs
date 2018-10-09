using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Login1 {
    public partial class Login : Form {

        public Login() {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void buttonOk_Click(object sender, EventArgs e) {
            String id = this.userName.Text;
            String pwd = this.userPwd.Text;
            Program.isValidUser = true;


            string conStr = "server=localhost;Integrated Security=SSPI;database=userinfo";
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();
            //创建SQL语句
            string selStr = "select * from t_user where id='" + id + "'and pwd = '"+pwd+"'";
            SqlCommand com = new SqlCommand(selStr, conn);
            SqlDataReader da = com.ExecuteReader();
            bool isExit = da.HasRows;

            if (isExit == true) {
                MessageBox.Show("登录成功！");
            }else {
                MessageBox.Show("账号或密码输入错误，请重新输入！");
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            Program.isValidUser = false;

            this.Close();
        }
    }
}
