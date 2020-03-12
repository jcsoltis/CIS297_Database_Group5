using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            label1.Text = "Hello world!";
            Instructor eric = new Instructor {
                Id = 1,
                Name = "Eric",
                Phone = "248-762-4206",
                Office = "CIS 237"
            };
            string connectionString = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=ClassFeb20;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        }
    }
}
