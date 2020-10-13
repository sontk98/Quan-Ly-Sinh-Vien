using Quan_Ly_Ho_So_SV.SET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Ho_So_SV
{
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
            LoadDataList();
            this.showMaDT();
            this.showMaLop();
            this.showNganh();
            this.showDT();
            this.showKhoa();
            binDing();
        }

        void binDing()
        {
            textMa.DataBindings.Add(new Binding("Text", dataList.DataSource, "MaSV"));
            textHo.DataBindings.Add(new Binding("Text", dataList.DataSource, "Ho"));
            textTen.DataBindings.Add(new Binding("Text", dataList.DataSource, "Ten"));
            dateTimeNgaySinh.DataBindings.Add(new Binding("Value", dataList.DataSource, "NgaySinh"));
            comboBoxNoiSinh.DataBindings.Add(new Binding("Text", dataList.DataSource, "NoiSinh"));
            comboBoxGioiTinh.DataBindings.Add(new Binding("Text", dataList.DataSource, "GioiTinh"));
            comboBoxDanToc.DataBindings.Add(new Binding("Text", dataList.DataSource, "DanToc"));
            comboBoxMaLop.DataBindings.Add(new Binding("Text", dataList.DataSource, "MaLop"));
            comboBoxMaDT.DataBindings.Add(new Binding("Text", dataList.DataSource, "MaDT"));
            dateTimeNgayVaoTruong.DataBindings.Add(new Binding("Value", dataList.DataSource, "NgayVaoTruong"));
            comboBoxTrangThai.DataBindings.Add(new Binding("Text", dataList.DataSource, "TrangThai"));
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fUpdateFile f = new fUpdateFile();
            f.ShowDialog();
        }
        private void LoadDataList()
        {
            string query = "SELECT * FROM SinhVien";
            DataProvider provider = new DataProvider();
            dataList.DataSource = provider.ExcuteQuery(query);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void reSet_Click(object sender, EventArgs e)
        {
            //textMa.Clear();
            //textHo.Clear();
            //textTen.Clear();

            //LoadDataList();
        }
        void showMaDT()
        {
            string query = "SELECT MaDT FROM DoiTuong";
            DataProvider provider = new DataProvider();
            comboBoxMaDT.DataSource = provider.ExcuteQuery(query);
            comboBoxMaDT.ValueMember = "MaDT";
        }
        void showMaLop()
        {
            string query = "SELECT MaLop FROM Lop";
            DataProvider provider = new DataProvider();
            comboBoxMaLop.DataSource = provider.ExcuteQuery(query);
            comboBoxMaLop.ValueMember = "MaLop";
            comboBoxLop.DataSource = provider.ExcuteQuery(query);
            comboBoxLop.ValueMember = "MaLop";
        }
        void showNganh()
        {
            string query = "SELECT TenNganh FROM Nganh";
            DataProvider provider = new DataProvider();
            comboBoxNganh.DataSource = provider.ExcuteQuery(query);
            comboBoxNganh.ValueMember = "TenNganh";
        }
        void showDT()
        {
            string query = "SELECT TenDT FROM DoiTuong";
            DataProvider provider = new DataProvider();
            comboBoxDoiTuong.DataSource = provider.ExcuteQuery(query);
            comboBoxDoiTuong.ValueMember = "TenDT";
        }
        void showKhoa()
        {
            string query = "SELECT TenKhoa FROM Khoa";
            DataProvider provider = new DataProvider();
            comboBoxKhoa.DataSource = provider.ExcuteQuery(query);
            comboBoxKhoa.ValueMember = "TenKhoa";
        }
        private void resetPassword_Click(object sender, EventArgs e)
        {
            fResetPassword reset = new fResetPassword();
            reset.ShowDialog();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            fAdmin admin = new fAdmin();
            admin.ShowDialog();
        }

        private void addSV_Click(object sender, EventArgs e)
        {
            string ma = textMa.Text;
            string ho = textHo.Text;
            string ten = textTen.Text;
            string ngaysinh = dateTimeNgaySinh.Text;
            string noisinh = comboBoxNoiSinh.Text;
            string gioitinh = comboBoxGioiTinh.Text;
            string dantoc = comboBoxDanToc.Text;
            string malop = comboBoxLop.Text;
            string maDT = comboBoxDoiTuong.Text;
            string ngayvaotruong = dateTimeNgayVaoTruong.Text;
            string trangthai = comboBoxTrangThai.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = KetNoi.str;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO SinhVien(MaSV,Ho,Ten,NgaySinh,NoiSinh,GioiTinh,DanToc,MaLop,MaDT,NgayVaoTruong,TrangThai) VALUES('" + ma + "','" + ho + "','" + ten + "','" + ngaysinh + "','" + noisinh + "','" + gioitinh + "','" + dantoc + "','" + malop + "','" + maDT + "','" + ngayvaotruong + "','" + trangthai + "')";
            cmd.ExecuteNonQuery();
            DialogResult result;
            result = MessageBox.Show("THÊM DỮ LIỆU THÀNH CÔNG", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.Close();
                fManager frm = new fManager();
                frm.Show();
            }

        }
    }
}
