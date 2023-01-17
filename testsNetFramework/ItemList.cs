﻿using System;
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
    public partial class ItemListBack : UserControl
    {
        
        public ItemListBack()
        {
            InitializeComponent();
        }

        private int id;
        private string title;
        private string customer;
        private float amount;
        private string type;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; lbTitle.Text = value; }
        }

        public string Customer
        {
            get { return customer; }
            set { customer = value; lbCustomer.Text = value; }
        }

        public float Amount
        {
            get { return amount; }
            set { amount = value; lbAmount.Text = value.ToString(); }
        }

        public string Type
        {
            get { return type; }
            set { type = value; lbType.Text = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola");
        }

        private void ItemList_MouseDown(object sender, MouseEventArgs e)
        {
            var control = sender as Control;
            control.Name = id.ToString();
            this.DoDragDrop(control.Name, DragDropEffects.Move);

        }

    }
}
