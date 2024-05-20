using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HostsEdit.Model;

namespace HostsFileEdit
{
    public partial class EditForm : Form
    {
        private EditFormVo editFormVo;

        public EditForm(EditFormVo editFormVo)
        {
            InitializeComponent();
            this.editFormVo = editFormVo;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            textBox_key.Text = editFormVo.key;
            textBox_value.Text = editFormVo.value;
        }
    }
}
