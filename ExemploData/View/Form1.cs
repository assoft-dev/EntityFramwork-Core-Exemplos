using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExemploData.Controllers;
using ExemploData.Controllers.Helps;
using ExemploData.Models;
using Microsoft.EntityFrameworkCore;

namespace ExemploData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var db = new ClientesRepository(new ClientesContext());
            dataGridView1.DataSource = await db.GetAll().ToListAsync();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var db = new ClientesRepository(new ClientesContext());

            var result = await db.Add(new ClientesModels()
            {
                Idade = Convert.ToInt32(textBox2.Text),
                Nome = textBox1.Text,
            });

            if (result)
            {
                MessageBox.Show("Inserido com Exito");
            }
        }
    }
}
