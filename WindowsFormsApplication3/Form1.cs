using Ninject;
using System.Windows.Forms;  
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        
        private IMount Mount { get; set; }

        [Inject()]
        public Form1(IMount mount)
        {
            InitializeComponent();
            Mount = mount;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            label1.Text = Mount?.GetDateTime().ToLongDateString();
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Form2 frm = FormResolve.Resolve<Form2>();
            frm.ShowDialog();
        }
    }
}
