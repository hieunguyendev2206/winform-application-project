using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DA_LTTQ
{
    public partial class frmXemHD : Form
    {
        TTTV_BLL blltttv;
        public frmXemHD()
        {
            InitializeComponent();
            blltttv = new TTTV_BLL();
        }


        public void ShowTTTV()
        {
            tbl_HoaDon HD = new tbl_HoaDon();
            HD.SoHD = lblSoHD.Text;
            DataTable dtTable = blltttv.GetTTTV2(HD);
            dgvThanhVien.DataSource = dtTable;
        }
        private void frmXemHD_Load(object sender, EventArgs e)
        {
            ShowTTTV();
        }
    }
}
