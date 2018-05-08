using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5Shtokal
{
    public partial class AddRecord : Form
    {
        public bool CreateNew { get; private set; } = false;
        public string[] data { get; private set; } = new string[6]; 
        public AddRecord()
        {
            InitializeComponent();
            educationCombo.SelectedIndex = 0;
            expCombo.SelectedIndex = 0;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            data[0] = name.Text;
            data[1] = secondName.Text;
            data[2] = educationCombo.Text;
            data[3] = phone.Text;
            data[4] = expCombo.Text;
            StringBuilder sb = new StringBuilder();
            sb.Append(languageList.CheckedItems[0].ToString());
            
            for (int i =1;i< languageList.CheckedItems.Count;i++)
            {
                sb.Append(", ");
                sb.Append(languageList.CheckedItems[i].ToString());
            }

            data[5] = sb.ToString();

            



            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateNew = true;
            ok_Click(sender, e);
        }
    }
}
