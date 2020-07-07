using BakkalRemzi.BLL;
using BakkalRemzi.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakkalRemzi.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductRepository repo = new ProductRepository();
        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Name = "Salatalık";
            p.Price = 100;
            p.Stock = 100;
            repo.Add(p);
            DataFill();
        }

        private void DataFill()
        {
            dataGridView1.DataSource = repo.getAll();
        }
    }
}
