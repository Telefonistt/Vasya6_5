using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab5Shtokal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void FileOpen(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt";// "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Title = "Открыть файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //if (openFileDialog1.)
                string path = openFileDialog1.FileName;
                filePath.Text = path;
                dataGridView1.DataSource = ReadCSV(path);
            }
        }

        private DataTable ReadCSV(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            DataTable dt = new DataTable();
            if (lines.Length > 0)
            {


                //columns///////////////////////////
                string[] line1 = lines[0].Split(';');

                for(int i=0;i<line1.Length;i++)
                {
                    dt.Columns.Add(line1[i]);
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] line = lines[i].Split(';');

                    DataRow dr= dt.NewRow();
                    for (int j = 0; j < line.Length; j++)
                    {
                            dr[j] = line[j];
                            
                    }
                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }

        private void WriteToCSV(string filePath)
        {
            DataTable dt =(DataTable) dataGridView1.DataSource;
        }

        private void addRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //if(dataGridView1.RowCount>=1)
        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRecord add = new AddRecord();
            add.ShowDialog(this);
            if (add.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Данные добавлены");
            }
            else
            {
                MessageBox.Show("Отменено");
            }
}
    }
}
