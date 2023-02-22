using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportProject10._11._22
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        TransportEntities con = new TransportEntities();
        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.CustomerShipments();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.ShipmentAndVehicle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.EmployeesAndShipments();
        }
    }
}
