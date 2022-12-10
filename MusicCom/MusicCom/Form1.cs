using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicCom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mCDataSet.Стили' table. You can move, or remove it, as needed.
            this.стилиTableAdapter.Fill(this.mCDataSet.Стили);
            // TODO: This line of code loads data into the 'mCDataSet.Произведения' table. You can move, or remove it, as needed.
            this.произведенияTableAdapter.Fill(this.mCDataSet.Произведения);
            // TODO: This line of code loads data into the 'mCDataSet.Носители' table. You can move, or remove it, as needed.
            this.носителиTableAdapter.Fill(this.mCDataSet.Носители);
            // TODO: This line of code loads data into the 'mCDataSet.Исполнители' table. You can move, or remove it, as needed.
            this.исполнителиTableAdapter.Fill(this.mCDataSet.Исполнители);
            // TODO: This line of code loads data into the 'mCDataSet.Журнал' table. You can move, or remove it, as needed.
            this.журналTableAdapter.Fill(this.mCDataSet.Журнал);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
