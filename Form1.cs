using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Ainjector
{
    public partial class Ainjector : Form
    {

        [DllImport("AinjectorLib.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Inject(uint processID, string dllPath);

        public static string targetprogress;

        public Ainjector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool result = Inject(uint.Parse(textBox2.Text), textBox1.Text);
            if (result)
            {
                MessageBox.Show("注入成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("注入失败!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择dll文件";
            fileDialog.InitialDirectory = @"C:\";                 
            fileDialog.Filter = "所有文件(*.*)|*.*";
            fileDialog.Filter = "dll文件(*.dll)|*.dll";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {

                string file = fileDialog.FileName;
                textBox1.Text = file;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            process process = new process();
            process.ShowDialog();
            textBox2.Text = Ainjector.targetprogress;
        }
        public void UpdateTextBox(string text)
        {
            textBox2.Text = text;
        }
    }
}
