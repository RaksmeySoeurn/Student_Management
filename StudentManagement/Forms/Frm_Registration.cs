using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.Forms
{
    public partial class Frm_Registration : Form
    {
        SQL_Control sql = new SQL_Control();

        public Frm_Registration()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Txt_Save.Text = sql.GetMaxID("[user]", "id", 2, "U-", "U-00000001");
        }
    }
}
