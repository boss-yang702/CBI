using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static cousrse_design.Program;

namespace cousrse_design
{
    public partial class PQF : Form
    {
        public PQF()
        {
            InitializeComponent();
        }
        private void PQF_Load(object sender, EventArgs e)
        {
        }

        private void ENTER_Click(object sender, EventArgs e)
        {
            if(SRK.Text=="123")
            {
                this.Close();
                common.flag= 1;

            }
        }
        private void CANCEL_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
