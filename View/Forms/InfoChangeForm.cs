using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Forms
{
    public partial class InfoChangeForm : Form
    {
        public string InfoText
        {
            get;
            private set;
        }
        public InfoChangeForm(string text)
        {
            InitializeComponent();
            TB_Info.Text = text;
            B_Change.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            B_Change.Enabled = true;
        }

        private void B_Change_Click(object sender, EventArgs e)
        {
            InfoText = TB_Info.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
