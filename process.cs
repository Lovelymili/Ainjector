using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ainjector
{

    public partial class process : Form
    {
        private string id;

        public process()
        {
            InitializeComponent();
        }

        private void process_Load(object sender, EventArgs e)
        {
            // 清空列表框
            listBox1.Items.Clear();

            // 获取当前所有进程
            Process[] ps = Process.GetProcesses();

            foreach (Process p in ps)
            {
                string info = "";

                try
                {
                    // 构建信息字符串
                    info = $"{p.Id}  {p.ProcessName}  {p.MainWindowTitle}  {(p.HasExited ? "N/A" : p.StartTime.ToString())}";
                }
                catch (Exception ex)
                {
                    // 捕获异常并记录错误信息
                    info = $"Error: {ex.Message}";
                }

                // 将信息添加到列表框中
                listBox1.Items.Add(info);
            }
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            // 获取被双击的项
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                // 在这里处理双击事件，比如显示更多信息
                MessageBox.Show($"您选中了: {selectedItem}");
                id = selectedItem.Split(' ')[0];
                Ainjector.targetprogress = id;
                this.Close();
                

            }
        }

    }
}
