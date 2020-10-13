using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Ho_So_SV
{
    public partial class fUpdateFile : Form
    {
        public fUpdateFile()
        {
            InitializeComponent();
            binDingUpdate();
        }
        void binDingUpdate()
        {
            fManager mana= new fManager();
            textMa.Text = mana.textMa.Text;  //textMa bên fManager để chế độ public
            
            //textMa.DataBindings.Add(new Binding("Text", dataList.DataSource, "MaSV"));
            //textHo.DataBindings.Add(new Binding("Text", dataList.DataSource, "Ho"));
            //textTen.DataBindings.Add(new Binding("Text", dataList.DataSource, "Ten"));
            //dateTimeNgaySinh.DataBindings.Add(new Binding("Value", dataList.DataSource, "NgaySinh"));
            //comboBoxNoiSinh.DataBindings.Add(new Binding("Text", dataList.DataSource, "NoiSinh"));
            //comboBoxGioiTinh.DataBindings.Add(new Binding("Text", dataList.DataSource, "GioiTinh"));
            //comboBoxDanToc.DataBindings.Add(new Binding("Text", dataList.DataSource, "DanToc"));
            //comboBoxMaLop.DataBindings.Add(new Binding("Text", dataList.DataSource, "MaLop"));
            //comboBoxMaDT.DataBindings.Add(new Binding("Text", dataList.DataSource, "MaDT"));
            //dateTimeNgayVaoTruong.DataBindings.Add(new Binding("Value", dataList.DataSource, "NgayVaoTruong"));
            //comboBoxTrangThai.DataBindings.Add(new Binding("Text", dataList.DataSource, "TrangThai"));
        }

        private void ExitUpdateFile_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
