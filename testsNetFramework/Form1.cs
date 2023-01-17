using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testsNetFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        int aux = 0;
        private void c_MouseDown(object sender, MouseEventArgs e)
        {
            var control = sender as Control;
            MessageBox.Show(control.Name);
            this.DoDragDrop(control.Name, DragDropEffects.Move);
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(string)))
                return;

            var name = e.Data.GetData(typeof(string)) as string;
            var control = this.Controls.Find(name, true).FirstOrDefault();
            if (control != null)
            {
                e.Effect = DragDropEffects.Move;
                
            }
            
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(string)))
                return;

            var name = e.Data.GetData(typeof(string)) as string;
            var control = this.Controls.Find(name, true).FirstOrDefault();

            if (flowLayoutPanel1.Controls.Contains(control))
            {
                flowLayoutPanel1.Controls.Remove(control);
            }

            if (control != null)
            {
                //control.Parent.Controls.Remove(control);
                var panel = sender as FlowLayoutPanel;
                ((FlowLayoutPanel)sender).Controls.Add(control);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ItemListBack item = new ItemListBack();

            item.Id = aux;
            item.Title = aux.ToString();
            item.Customer = "Customer: " + aux.ToString();
            item.Amount = 100;
            item.Type = "Product";
            
            aux++;
            
            flowLayoutPanel1.Controls.Add(item);
            //flowLayoutPanel1.Controls.mov
        }

    }
}
