﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BTTH3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable tblKHACHHANG, tblPHIEUDATBAO, tblCTDATBAO, tblTAPCHI;
        SqlDataAdapter daPDB, daCTDB, daKH, daTC;
        BindingManagerBase bindPDB, bindCTDB;
        bool capNhat;

        private void cbSDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbSDT.SelectedIndex;
            if(index >=0)
            {
                txtTenKH.Text = tblKHACHHANG.Rows[index]["TenKH"].ToString();
                txtDiaChi.Text = tblKHACHHANG.Rows[index]["DiaChi"].ToString();
            }
            else
            {
                txtTenKH.Text = "";
                txtDiaChi.Text = "";
            }
        }

        private void loadDSDT()
        {
            cbSDT.DataSource = tblKHACHHANG;
            cbSDT.ValueMember = "MaKH";
            cbSDT.DisplayMember = "DienThoai";
            cbSDT.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSDT.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void loadTAPCHI()
        {
            cbTapChi.DataSource = tblTAPCHI;
            cbTapChi.ValueMember = "MaTC";
            cbTapChi.DisplayMember = "TenTC";
            cbTapChi.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbTapChi.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbTapChi.SelectedIndex = -1;
        }
        private void addColCTDATBAO()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblTAPCHI, tblCTDATBAO });
            DataRelation qh = new DataRelation("FRK_TAPCHI_CTDATBAO", tblTAPCHI.Columns["MaTC"], tblCTDATBAO.Columns["MaTC"]);
            ds.Relations.Add(qh);
            DataColumn cot_TenTC = new DataColumn("TenTC", Type.GetType("System.String"), "Parent(FRK_TAPCHI_CTDATBAO).TenTC");
            DataColumn cot_DonGiaThang = new DataColumn("DonGiaThang", Type.GetType("System.String"), "Parent (FRK_TAPCHI_CTDATBAO).DonGiaThang");
            DataColumn cot_ThanhTien = new DataColumn("ThanhTien", Type.GetType("System.String"), "Parent (FRK_TAPCHI_CTDATBAO).DonGiaThang* SoLuong*(ThangKT - ThangBD +1)");
            tblCTDATBAO.Columns.Add(cot_TenTC);
            tblCTDATBAO.Columns.Add(cot_DonGiaThang);
            tblCTDATBAO.Columns.Add(cot_ThanhTien);
        }
        private void loadCTDATBAO()
        {
            bindCTDB = this.BindingContext[tblCTDATBAO];
            dgvCTDB.AutoGenerateColumns = false;
            dgvCTDB.DataSource = tblCTDATBAO;
        }
        private void bdPDB_PositionChanged(object sender, EventArgs e)
        {
            tblCTDATBAO.DefaultView.RowFilter = "SoPhieu='" + txtSoPhieu.Text + "'";
            int s = 0;
            foreach (DataRowView r in tblCTDATBAO.DefaultView)
            {
                s += int.Parse(r["ThanhTien"].ToString());
            }
            txtTong.Text = s.ToString();
        }
        private void loadDSDATBAO()
        {
            txtSoPhieu.DataBindings.Add("text", tblPHIEUDATBAO, "SoPhieu", true);
            dtNgayDat.DataBindings.Add("value", tblPHIEUDATBAO, "NgayDat", true);
            cbSDT.DataBindings.Add("SelectedValue", tblPHIEUDATBAO, "MaKH", true);
            bindPDB = this.BindingContext[tblPHIEUDATBAO];
            bindPDB.PositionChanged += new EventHandler(bdPDB_PositionChanged);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tblKHACHHANG = new DataTable();
            tblPHIEUDATBAO = new DataTable();
            tblCTDATBAO = new DataTable();
            tblTAPCHI = new DataTable();
            daKH = new SqlDataAdapter("Select * from KHACHHANG", Modules.cnnStr);
            daPDB = new SqlDataAdapter("Select * from PHIEUDATBAO", Modules.cnnStr);
            daCTDB = new SqlDataAdapter("Select * from CTDATBAO", Modules.cnnStr);
            daTC = new SqlDataAdapter("Select * from TAPCHI", Modules.cnnStr);
            try
            {
                daKH.Fill(tblKHACHHANG);
                daPDB.Fill(tblPHIEUDATBAO);
                daCTDB.Fill(tblCTDATBAO);
                daTC.Fill(tblTAPCHI);
                SqlCommandBuilder cmdPDB = new SqlCommandBuilder(daPDB);
                SqlCommandBuilder cmdCTDB = new SqlCommandBuilder(daCTDB);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            loadDSDT();
            loadTAPCHI();
            addColCTDATBAO();
            loadCTDATBAO();
            loadDSDATBAO();
            bdPDB_PositionChanged(sender, e);
            capNhat = false;
            ennableButton();
        }
        private void ennableButton()
        {
            btnNewDB.Enabled = !capNhat;
            btnUpdateDB.Enabled = !capNhat;
            btnDeleteDB.Enabled = !capNhat;
            btnCancel.Enabled = capNhat;
            btnSave.Enabled = capNhat;
            btnAddTC.Enabled = capNhat;
            btnDeleteTC.Enabled = capNhat;
            dgvCTDB.Enabled = capNhat;
        }


        private void dgvCTDB_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvCTDB.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bindPDB.Position = 0;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (bindPDB.Position > 0)
                bindPDB.Position -= 1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (bindPDB.Position < bindPDB.Count - 1)
                bindPDB.Position += 1;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bindPDB.Position = bindPDB.Count - 1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTC_Click(object sender, EventArgs e)
        {
            if(cbTapChi.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn tạp chí @-@");
                return;
            }
            int count = tblCTDATBAO.Select("SoPhieu = '" + txtSoPhieu.Text + "' and MaTC='" + cbTapChi.SelectedValue + "'").Count();
            if(count > 0)
            {
                MessageBox.Show("Tạp Chí đã tồn tại, chọn tạp chí khác @-@");
                return;
            }
            DataRow r = tblCTDATBAO.NewRow();
            r["MaTC"] = cbTapChi.SelectedValue;
            r["SoPhieu"] = txtSoPhieu.Text;
            r["SoLuong"] = nudSoLuong.Value;
            r["ThangBD"] = nudThangBD.Value;
            r["ThangKT"] = nudThangKT.Value;
            tblCTDATBAO.Rows.Add(r);
            bdPDB_PositionChanged(sender, e);
        }

        private void btnDeleteTC_Click(object sender, EventArgs e)
        {
            int index = bindCTDB.Position;
            if (index >= 0)
                bindCTDB.RemoveAt(index);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bindCTDB.CancelCurrentEdit();
            tblCTDATBAO.RejectChanges();
            bindPDB.CancelCurrentEdit();
            tblPHIEUDATBAO.RejectChanges();
            bdPDB_PositionChanged(sender, e);
            capNhat = false;
            ennableButton();
        }

        private void btnNewDB_Click(object sender, EventArgs e)
        {
            bindPDB.AddNew();
            dtNgayDat.Value = DateTime.Now;
            try
            {
                SqlCommand cmm = new SqlCommand("Select dbo.fn_CreateMaPB()", Modules.cnn);
                Modules.cnn.Open();
                txtSoPhieu.Text = cmm.ExecuteScalar().ToString();
                capNhat = true;
                ennableButton();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Modules.cnn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(cbSDT.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn khách hàng @-@");
                return;
            }
            try
            {
                bindPDB.EndCurrentEdit();
                daPDB.Update(tblPHIEUDATBAO);
                tblPHIEUDATBAO.AcceptChanges();

                bindCTDB.EndCurrentEdit();
                daCTDB.Update(tblCTDATBAO);
                tblCTDATBAO.AcceptChanges();
                MessageBox.Show("Cập nhật thành công (^-^) ");
                capNhat = false;
                ennableButton();
            }
            catch (SqlException ex)
            {
                tblCTDATBAO.RejectChanges();
                tblPHIEUDATBAO.RejectChanges();
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            capNhat = true;
            ennableButton();
        }

        private void btnDeleteDB_Click(object sender, EventArgs e)
        {
            try
            {
                var rows = tblCTDATBAO.Select("SoPhieu =' " + txtSoPhieu.Text + "'");
                foreach (DataRow r in rows)
                    r.Delete();
                daCTDB.Update(tblCTDATBAO);
                tblCTDATBAO.AcceptChanges();
                bindPDB.RemoveAt(bindPDB.Position);
                daPDB.Update(tblPHIEUDATBAO);
                tblPHIEUDATBAO.AcceptChanges();
                MessageBox.Show(" Thành Công (^-^)");
            }
            catch (SqlException ex)
            {
                tblCTDATBAO.RejectChanges();
                tblPHIEUDATBAO.RejectChanges();
                MessageBox.Show(ex.ToString());
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
