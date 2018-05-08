using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lab5Shtokal
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitHeaders();
        }

        private DataTable source;
       
        private string[] columnHeaders = { "Name", "Second Name", "Education", "Phone numb.", "Work experience", "Pr.Language" };

        private DataTable  InitHeaders()
        {
            source = new DataTable();
            for (int i = 0; i < columnHeaders.Length; i++)
            {
                source.Columns.Add(columnHeaders[i]);
            }
            dataGridView1.DataSource = source;
            return source;
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
                source= ReadCSV(path);
                dataGridView1.DataSource = source;
            }
        }

        private DataTable ReadCSV(string filePath)
        {
            try
            {


                string[] lines = File.ReadAllLines(filePath);
                //DataTable dt = new DataTable();

                DataTable dt = InitHeaders();
                if (lines.Length > 0)
                {


                    //columns///////////////////////////
                    //string[] line1 = lines[0].Split(';');

                    //for(int i=0;i<line1.Length;i++)
                    //{
                    //    dt.Columns.Add(line1[i]);
                    //}

                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] line = lines[i].Split(';');

                        DataRow dr = dt.NewRow();
                        for (int j = 0; j < line.Length; j++)
                        {
                            dr[j] = line[j];

                        }
                        dt.Rows.Add(dr);
                    }
                }

                return dt;
            }
            catch
            {
                MessageBox.Show("Read Error");
                return InitHeaders();
            }
        }

        private string GetSavePath()
        {
           // DataTable dt =(DataTable) dataGridView1.DataSource;

            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt|all files (*.*)|*.*";// "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.Title = "Сохранить файл";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //if (openFileDialog1.)
                string path = saveFileDialog1.FileName;
                filePath.Text = path;
                return path;
            }
            return "";
        }

        private void addRecordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addRecordToolStripMenuItem_Click(sender, e);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitHeaders();
            //if(dataGridView1.RowCount>=1)
        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRecord addForm = new AddRecord();
            addForm.ShowDialog(this);
            if (addForm.DialogResult == DialogResult.OK)
            {

                AddRow(source, addForm.data);

                

                MessageBox.Show("Данные добавлены");
                if(addForm.CreateNew==true)
                {
                    addRecordToolStripMenuItem_Click(sender,e);
                }
            }
            else
            {
                MessageBox.Show("Отменено");
            }
}

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string path= GetSavePath();
            if(path!="")
            {

                FileStream fs = File.Create(path);
                fs.Close();
                //FileStream fs= File.Create(path);
                // fs.Close();
                // string appendText="";//= "This is extra text" + Environment.NewLine;
                // foreach (string line in readText)
                // {
                //     appendText += line + Environment.NewLine;
                // }
                File.AppendAllText(path, DTtoString(source));
            }
        }

        private string DTtoString(DataTable dt)
        {
            int countRow = dt.Rows.Count;
            int countCol = dt.Columns.Count;
            StringBuilder content = new StringBuilder();

            if (countRow != 0)
            {
                
                for (int i=0;i< countRow; i++)
                {
                    content.Append(dt.Rows[i][0]);
                    
                    for (int j=1;j< countCol; j++)
                    {
                        content.Append(';');
                        content.Append(dt.Rows[i][j]);
                    }

                    content.Append("\r\n");


                }
            }
            return content.ToString();
        }

        private DataTable AddRow(DataTable sourse,string[] row )
        {
            DataRow dr = sourse.NewRow();

            for (int j = 0; j < row.Length; j++)
            {
                dr[j] = row[j];

            }

            sourse.Rows.Add(dr);
            return source;
        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int count = dataGridView1.SelectedRows.Count;
            for (int i=0;i< count; i++)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }



            //dataGridView1.SelectedRows[]
        }
    }
}
