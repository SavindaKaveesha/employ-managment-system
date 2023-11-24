namespace employ_managment_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //hello world
        //sameera

        private void button1_Click(object sender, EventArgs e)
        {
            employe form = new employe();
            form.Show();
            //testing 2
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeInfo info = new EmployeInfo();
            info.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}