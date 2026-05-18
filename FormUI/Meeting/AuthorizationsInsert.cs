using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using NPOI.SS.Formula.Functions;
using System;
using System.Data;
using System.Windows.Forms;

namespace pmDHCD
{
    public partial class AuthorizationsInsert
    {
        public AuthorizationsInsert()
        {
            InitializeComponent();
        }

        private void AuthorizationsInsert_Load(object sender, EventArgs e)
        {
            MaskedTextBox3.Focus();
        }

        private void MaskedTextBox3_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MaskedTextBox3.Text) && !string.IsNullOrWhiteSpace(MaskedTextBox3.Text))
            {
                TimDaiBieu();
            }
        }

        private void TimDaiBieu()
        {
            var daibieu = new DataTable();
            string identityCard = MaskedTextBox3.Text.Trim(); // Loại bỏ khoảng trắng

            try
            {
                // daibieu = Mainform.BenlyDal.Delegate_getlist(Mainform.workingmeeting, 0, MaskedTextBox3.Text)
                daibieu = My.MyProject.Forms.Mainform.BenlyDal.Delegate_getlist(My.MyProject.Forms.Mainform.workingmeeting, 0m, identityCard);
                //}
                //catch (Exception ex)
                //{
                //    //Interaction.MsgBox("Lỗi" + ex.Message);
                //    return;
                //}
                if (daibieu.Rows.Count == 1)
                {
                    MaskedTextBox2.Text = Conversions.ToString(daibieu.Rows[0]["DelegateCode"]);
                    MaskedTextBox3.Text = Conversions.ToString(daibieu.Rows[0]["IdentityCard"]);
                    MaskedTextBox4.Text = Conversions.ToString(daibieu.Rows[0]["DelegateName"]);
                    MaskedTextBox7.Focus();
                }
                else if (daibieu.Rows.Count > 1)
                {
                    var objDelegateListForSelect = new DelegateListForSelect();
                    objDelegateListForSelect.IdentifyCard = identityCard;
                    objDelegateListForSelect.ShowDialog();
                    if (objDelegateListForSelect.DataGridView1.CurrentRow != null)
                    {
                        MaskedTextBox2.Text = objDelegateListForSelect.DataGridView1.CurrentRow.Cells["DelegateCode"].Value.ToString();
                        MaskedTextBox3.Text = objDelegateListForSelect.DataGridView1.CurrentRow.Cells["IdentityCard"].Value.ToString();
                        MaskedTextBox4.Text = objDelegateListForSelect.DataGridView1.CurrentRow.Cells["DelegateName"].Value.ToString();
                    }
                }
                else if (daibieu.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy đại biểu với CCCD/HC: " + identityCard + "!");
                    MaskedTextBox2.Text = "";
                    //MaskedTextBox3.Text = "";
                    MaskedTextBox4.Text = "";
                    MaskedTextBox3.Focus();
                    MaskedTextBox3.SelectAll();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi" + ex.Message);
                return;
            }
        }

        private void MaskedTextBox2_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MaskedTextBox2.Text) && !string.IsNullOrWhiteSpace(MaskedTextBox2.Text))
            {
                TimDaiBieuByCode();
            }
        }

        private void TimDaiBieuByCode()
        {
            var daibieu = new DataTable();
            int delecode = 0;
            if (!int.TryParse(MaskedTextBox2.Text, out delecode))
            {
                delecode = 0;
            }

            try
            {
                // daibieu = Mainform.BenlyDal.Delegate_getlist(Mainform.workingmeeting, 0, MaskedTextBox3.Text)
                daibieu = My.MyProject.Forms.Mainform.BenlyDal.Delegate_getlist(My.MyProject.Forms.Mainform.workingmeeting, delecode, "");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi" + ex.Message);
                return;
            }
            if (daibieu.Rows.Count == 1)
            {
                MaskedTextBox2.Text = Conversions.ToString(daibieu.Rows[0]["DelegateCode"]);
                MaskedTextBox3.Text = Conversions.ToString(daibieu.Rows[0]["IdentityCard"]);
                MaskedTextBox4.Text = Conversions.ToString(daibieu.Rows[0]["DelegateName"]);
                MaskedTextBox7.Focus();

            }
            else if (daibieu.Rows.Count > 1)
            {
                //Tìm đại biểu là exact match nên không có case này, nhưng vẫn giữ lại để sau này nếu cần tìm theo code mà trả về nhiều kết quả thì sẽ xử lý được
                MessageBox.Show("Có nhiều hơn 1 mã đại biểu. Vui lòng tìm kiếm lại");
                MaskedTextBox3.Text = "";
                MaskedTextBox4.Text = "";
                MaskedTextBox2.Focus();
                MaskedTextBox2.SelectAll();
                //var objDelegateListForSelectByCode = new DelegateListForSelectByCode();
                //objDelegateListForSelectByCode.DelegateCode = delecode;
                //objDelegateListForSelectByCode.ShowDialog();
                //if (objDelegateListForSelectByCode.DataGridView1.CurrentRow != null)
                //{
                //    MaskedTextBox3.Text = objDelegateListForSelectByCode.DataGridView1.CurrentRow.Cells["DelegateCode"].Value.ToString();
                //    TimDaiBieuByCode();
                //}
            }
            else if (daibieu.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy đại biểu với mã đại biểu: " + delecode + "!");
                //MaskedTextBox2.Text = "";
                MaskedTextBox3.Text = "";
                MaskedTextBox4.Text = "";
                MaskedTextBox2.Focus();
                MaskedTextBox2.SelectAll();
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra validation trước khi thêm
                if (!string.IsNullOrEmpty(ErrorProvider1.GetError(StockTextBox2)))
                {
                    MessageBox.Show("Vui lòng sửa lỗi trước khi thêm!");
                    StockTextBox2.Focus();
                    return;
                }

                // Kiểm tra xem có nhập đầy đủ thông tin không
                if (string.IsNullOrEmpty(MaskedTextBox3.Text))
                {
                    MessageBox.Show("Vui lòng nhập CCCD/HC!");
                    MaskedTextBox3.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(MaskedTextBox7.Text))
                {
                    MessageBox.Show("Vui lòng nhập Số đăng ký sở hữu!");
                    MaskedTextBox7.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(StockTextBox2.Text) || Conversions.ToDecimal(StockTextBox2.Text) <= 0)
                {
                    MessageBox.Show("Vui lòng nhập Số quyền BQ ủy quyền!");
                    StockTextBox2.Focus();
                    return;
                }

                My.MyProject.Forms.Mainform.BenlyDal.Authorizations_insert(My.MyProject.Forms.Mainform.workingmeeting, MaskedTextBox8.Text, Conversions.ToDecimal(MaskedTextBox2.Text), Conversions.ToDecimal(StockTextBox2.Text));

                MessageBox.Show("Thêm ủy quyền thành công!");
                Close();

                // If (MessageBox.Show("Bạn có muốn in phiếu xác nhận tham dự không?", "In phiếu xác nhận tham dự", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes) Then
                // Me.InPhieuXacNhan(MaskedTextBox6.Text, MaskedTextBox2.Text, MaskedTextBox4.Text, MaskedTextBox7.Text, MaskedTextBox1.Text, StockTextBox2.Text)
                // End If

                Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi: " + ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AuthorizationsInsert_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        //private void MaskedTextBox3_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        MaskedTextBox7.Focus();
        //    }
        //}

        //private void MaskedTextBox2_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        MaskedTextBox7.Focus();
        //    }
        //}

        private void MaskedTextBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThucHienUyQuyen();
            }
        }

        private void MaskedTextBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThucHienUyQuyenByCode();
            }
        }

        private void ThucHienUyQuyen()
        {
            var codong = new DataTable();
            string holderIdentity = MaskedTextBox7.Text.Trim(); // Loại bỏ khoảng trắng

            try
            {
                codong = My.MyProject.Forms.Mainform.BenlyDal.Holder_getlist(My.MyProject.Forms.Mainform.workingmeeting, "", holderIdentity);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi: " + ex.Message);
                return;
            }
            if (codong.Rows.Count == 1)
            {
                MaskedTextBox8.Text = Conversions.ToString(codong.Rows[0]["Holdercode"]);
                MaskedTextBox7.Text = Conversions.ToString(codong.Rows[0]["HolderIdentity"]);
                MaskedTextBox6.Text = Conversions.ToString(codong.Rows[0]["Holdername"]);
                MaskedTextBox1.Text = Conversions.ToString(codong.Rows[0]["HolderAddress"]);
                StockTextBox1.Text = Conversions.ToString(codong.Rows[0]["Shares"]);
                StockTextBox2.Text = Conversions.ToString(codong.Rows[0]["Voterights"]);
                TinhSoQuyenConLai();
                StockTextBox2.Focus();
            }
            else if (codong.Rows.Count > 1)
            {
                var objHolderListForSelect = new HolderListForSelect();
                objHolderListForSelect.IdentifyCard = holderIdentity;
                objHolderListForSelect.ShowDialog();
                if (objHolderListForSelect.DataGridView1.CurrentRow != null)
                {
                    MaskedTextBox8.Text = objHolderListForSelect.DataGridView1.CurrentRow.Cells["Holdercode"].Value.ToString();
                    MaskedTextBox7.Text = objHolderListForSelect.DataGridView1.CurrentRow.Cells["HolderIdentity"].Value.ToString();
                    MaskedTextBox6.Text = objHolderListForSelect.DataGridView1.CurrentRow.Cells["Holdername"].Value.ToString();
                    MaskedTextBox1.Text = objHolderListForSelect.DataGridView1.CurrentRow.Cells["HolderAddress"].Value.ToString();
                    StockTextBox1.Text = objHolderListForSelect.DataGridView1.CurrentRow.Cells["Shares"].Value.ToString();
                    StockTextBox2.Text = objHolderListForSelect.DataGridView1.CurrentRow.Cells["Voterights"].Value.ToString();
                    TinhSoQuyenConLai();
                }
            }
            else if (codong.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy cổ đông với số đăng ký sở hữu: " + holderIdentity + "!");
                MaskedTextBox1.Text = "";
                MaskedTextBox6.Text = "";
                //MaskedTextBox7.Text = "";
                MaskedTextBox8.Text = "";
                StockTextBox1.Text = "";
                StockTextBox2.Text = "";
                StockTextBox3.Text = "";
                ErrorProvider1.SetError(StockTextBox2, "");
                StockTextBox2.BackColor = System.Drawing.SystemColors.Window;
                MaskedTextBox7.Focus();
                MaskedTextBox7.SelectAll();
            }

        }

        private void ThucHienUyQuyenByCode()
        {
            var codong = new DataTable();
            string holderCode = MaskedTextBox8.Text.Trim(); // Loại bỏ khoảng trắng

            try
            {
                codong = My.MyProject.Forms.Mainform.BenlyDal.Holder_getlist(My.MyProject.Forms.Mainform.workingmeeting, holderCode, "");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi: " + ex.Message);
                return;
            }
            if (codong.Rows.Count == 1)
            {
                MaskedTextBox8.Text = Conversions.ToString(codong.Rows[0]["Holdercode"]);
                MaskedTextBox7.Text = Conversions.ToString(codong.Rows[0]["HolderIdentity"]);
                MaskedTextBox6.Text = Conversions.ToString(codong.Rows[0]["Holdername"]);
                MaskedTextBox1.Text = Conversions.ToString(codong.Rows[0]["HolderAddress"]);
                StockTextBox1.Text = Conversions.ToString(codong.Rows[0]["Shares"]);
                StockTextBox2.Text = Conversions.ToString(codong.Rows[0]["Voterights"]);
                TinhSoQuyenConLai();
                StockTextBox2.Focus();
            }
            else if (codong.Rows.Count > 1)
            {
                var objHolderListForSelectByCode= new HolderListForSelectByCode();
                objHolderListForSelectByCode.HolderCode = holderCode;
                objHolderListForSelectByCode.ShowDialog();
                if (objHolderListForSelectByCode.DataGridView1.CurrentRow != null)
                {
                    MaskedTextBox8.Text = objHolderListForSelectByCode.DataGridView1.CurrentRow.Cells["Holdercode"].Value.ToString();
                    MaskedTextBox7.Text = objHolderListForSelectByCode.DataGridView1.CurrentRow.Cells["HolderIdentity"].Value.ToString();
                    MaskedTextBox6.Text = objHolderListForSelectByCode.DataGridView1.CurrentRow.Cells["Holdername"].Value.ToString();
                    MaskedTextBox1.Text = objHolderListForSelectByCode.DataGridView1.CurrentRow.Cells["HolderAddress"].Value.ToString();
                    StockTextBox1.Text = objHolderListForSelectByCode.DataGridView1.CurrentRow.Cells["Shares"].Value.ToString();
                    StockTextBox2.Text = objHolderListForSelectByCode.DataGridView1.CurrentRow.Cells["Voterights"].Value.ToString();
                    TinhSoQuyenConLai();
                }
            }
            else if (codong.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy cổ đông với số đăng ký sở hữu: " + holderCode + "!");
                MaskedTextBox1.Text = "";
                MaskedTextBox6.Text = "";
                MaskedTextBox7.Text = "";
                //MaskedTextBox8.Text = "";
                StockTextBox1.Text = "";
                StockTextBox2.Text = "";
                StockTextBox3.Text = "";
                ErrorProvider1.SetError(StockTextBox2, "");
                StockTextBox2.BackColor = System.Drawing.SystemColors.Window;
                MaskedTextBox8.Focus();
                MaskedTextBox8.SelectAll();
            }

        }

        private void StockTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KiemTraVaCapNhatSoQuyenConLai();
                Button1.Focus();
            }

        }

        private void StockTextBox2_Leave(object sender, EventArgs e)
        {
            KiemTraVaCapNhatSoQuyenConLai();
        }

        //private void MaskedTextBox3_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        TimDaiBieu();
        //    }

        //}

        //private void MaskedTextBox2_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        TimDaiBieuByCode();
        //    }

        //}

        private void MaskedTextBox7_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MaskedTextBox7.Text) && !string.IsNullOrWhiteSpace(MaskedTextBox7.Text))
            {
                ThucHienUyQuyen();
            }
        }

        private void MaskedTextBox8_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MaskedTextBox8.Text) && !string.IsNullOrWhiteSpace(MaskedTextBox8.Text))
            {
                ThucHienUyQuyenByCode();
            }
            else
            {
                StockTextBox2.Focus();
            }   
        }

        private void TinhSoQuyenConLai()
        {
            try
            {
                if (string.IsNullOrEmpty(MaskedTextBox8.Text))
                {
                    StockTextBox3.Text = "0";
                    return;
                }

                decimal soQuyenConLai = My.MyProject.Forms.Mainform.BenlyDal.Holder_GetRemainingVoterights(
                    My.MyProject.Forms.Mainform.workingmeeting,
                    MaskedTextBox8.Text);

                if (soQuyenConLai < 0)
                {
                    soQuyenConLai = 0;
                }

                StockTextBox3.Text = soQuyenConLai.ToString();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi tính số quyền còn lại: " + ex.Message);
            }
        }

        private void KiemTraVaCapNhatSoQuyenConLai()
        {
            try
            {
                // Trước tiên tính số quyền còn lại
                TinhSoQuyenConLai();

                // Kiểm tra xem số quyền BQ ủy quyền có vượt quá số quyền còn lại không
                if (decimal.TryParse(StockTextBox2.Text, out decimal soQuyenUyQuyen) &&
                    decimal.TryParse(StockTextBox3.Text, out decimal soQuyenConLai))
                {
                    decimal soQuyenConLaiSauKhiTru = soQuyenConLai - soQuyenUyQuyen;

                    if (soQuyenConLaiSauKhiTru < 0)
                    {
                        ErrorProvider1.SetError(StockTextBox2,
                            string.Format("Số quyền BQ ủy quyền ({0}) vượt quá số quyền BQ còn lại ({1}).", 
                            soQuyenUyQuyen, soQuyenConLai));
                        StockTextBox2.BackColor = System.Drawing.Color.FromArgb(255, 200, 200);
                    }
                    else
                    {
                        ErrorProvider1.SetError(StockTextBox2, "");
                        StockTextBox2.BackColor = System.Drawing.SystemColors.Window;
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi kiểm tra: " + ex.Message);
            }
        }

        private void InPhieuXacNhan(string strHolderName, string strDelegateCode, string strDelegateName, string strIndentityCard, string strAddress, string strVoteRight)
        {

            // Dim cr As New PhieuXacNhan
            var cr = new ReportDocument();
            cr.Load("~/Report/PhieuXacNhan.rpt");
            try
            {
                string logoPath = System.IO.Path.Combine(Application.StartupPath, @"Resources\Logo.jpg");
                cr.SetParameterValue("LogoPath", logoPath);
                cr.SetParameterValue("HolderName", strHolderName.ToUpper());
                cr.SetParameterValue("Delegatecode", My.MyProject.Forms.Mainform.stockCode + strDelegateCode.PadLeft(4, '0'));
                cr.SetParameterValue("Delegatename", strDelegateName.ToUpper());
                cr.SetParameterValue("IdentityCard", strIndentityCard);
                cr.SetParameterValue("Address", strAddress);
                cr.SetParameterValue("voterights", strVoteRight);
                cr.PrintToPrinter(1, true, 1, 10);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi :" + ex.Message);
            }

        }
    }
}