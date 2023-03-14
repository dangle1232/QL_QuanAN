using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOAN_QLQuanAn.DAO;
using DOAN_QLQuanAn.DTO;
using Guna.UI2.WinForms;

namespace DOAN_QLQuanAn
{
    public partial class FNhanVien : Form
    {
        BindingSource accountList = new BindingSource();
        BindingSource foodList = new BindingSource();
        BindingSource tableList = new BindingSource();
        BindingSource categoryList = new BindingSource();

        public FNhanVien()
        {
            InitializeComponent();
            LoadDL();
        }

        //Code các phương pháp xử lý
        #region Method

        void LoadDL()
        {
            dgvTaiKhoan.DataSource = accountList;
            dgvMonAn.DataSource = foodList;
            dgvBanAn.DataSource = tableList;
            dgvDanhMuc.DataSource = categoryList;
            LoadTable();
            LoadCategory();
            LoadAccount();
            LoadDateTimePickerBill();

            //LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadListFood();
            LoadListCategory();
            LoadListTable();

            AddAccountBinding(txtTenTaiKhoan.Text);
            AddCategoryBinding();
            AddFoodBinding();
            AddTableBinding();

            LoadComboboxTable(cbChuyenBan);
            LoadCategoryComboBox(cbDMThucAn);
        }


        // Panel Thực đơn món ăn
        void AddFoodBinding() //Hiển thị thông tin từ datagridview sang textbox
        {
            txtIDMonAn.DataBindings.Add(new Binding("Text", dgvMonAn.DataSource, "ID"));
            txtMonAn.DataBindings.Add(new Binding("Text", dgvMonAn.DataSource, "Name"));
            numGiaThucAn.DataBindings.Add(new Binding("Value", dgvMonAn.DataSource, "Price"));
            //cbDMThucAn.DataBindings.Add(new Binding("SelectedValue", dgvMonAn.DataSource, "CategoryID", true, DataSourceUpdateMode.Never));
        }
        void LoadListFood() //Lấy danh sách món ăn
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }
        void LoadCategoryComboBox(ComboBox cb) //Lấy danh sách danh mục vào combobox DM ở Thực đơn
        {
            cbDMThucAn.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        void LoadFoodListByCategoryID(int id) //Lấy danh sách món ăn từ id danh mục
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbMonAn.DataSource = listFood;
            cbMonAn.DisplayMember = "Name";
        }

        //Panel Danh mục
        void AddCategoryBinding() //Hiển thị thông tin từ datagridview sang textbox
        {
            txtIDDanhmuc.DataBindings.Add(new Binding("Text", dgvDanhMuc.DataSource, "ID"));
            txtTenDanhMuc.DataBindings.Add(new Binding("Text", dgvDanhMuc.DataSource, "Name"));
        }

        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
        }

        //Panel DS bàn
        void AddTableBinding() //Hiển thị thông tin từ datagridview sang textbox
        {
            txtIDBan.DataBindings.Add(new Binding("Text", dgvBanAn.DataSource, "ID"));
            txtTenBan.DataBindings.Add(new Binding("Text", dgvBanAn.DataSource, "Name"));
            txtTrangThaiBan.DataBindings.Add(new Binding("Text", dgvBanAn.DataSource, "Status"));
        }
        void LoadListTable() //Lấy danh sách bàn
        {
            tableList.DataSource = TableDAO.Instance.GetListTable();
        }
        // Panel Hóa đơn
        void LoadCategory() //Lấy danh sách danh mục vào combobox DM ở Hóa đơn
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbDanhMucMon.DataSource = listCategory; //Combobox Danh Mục ở Hóa đơn
            cbDanhMucMon.DisplayMember = "Name";

            cbDMThucAn.DataSource = listCategory; //Combobox Danh Mục ở Thực đơn
            cbDMThucAn.DisplayMember = "Name";
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.ForeColor = Color.Black; // chỉnh chữ màu đen
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    //Bàn không có khách
                    case "Trống":
                        //btn.BackColor = Color.Pink;
                        btn.TextAlign = ContentAlignment.TopLeft; //chỉnh chữ nằm góc trên bên trái
                        string pathToIcoFile = AppDomain.CurrentDomain.BaseDirectory + @"Resources\Banantrong.JPG"; //Lấy ảnh từ đường dẫn máy đến thư mục project
                        //string duongdan = @"Resources\\Banantrong.JPG"; // chèn ảnh vào bt
                        btn.Image = Image.FromFile(pathToIcoFile); // mở file lấy hình
                        break;

                    //Bàn đã có khách
                    default:
                        //btn.BackColor = Color.Blue;
                        btn.TextAlign = ContentAlignment.BottomLeft;
                        string pathToIcoFile1 = AppDomain.CurrentDomain.BaseDirectory + @"Resources\Banconguoi.JPG";
                        //string duongdan1 = @"Resources\\Banconguoi.JPG";
                        btn.Image = Image.FromFile(pathToIcoFile1);
                        break;
                }
                flpTable.Controls.Add(btn);
                LoadListTable(); //Khi bàn bên hóa đơn thay đổi trạng thái thì bảng ở ds bàn cũng cập nhật
            }
        }
        void ShowBill(int id)   //Hiện hóa đơn các món của bàn ăn
        {
            lvHoaDon.Items.Clear();
            List<DOAN_QLQuanAn.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;

            foreach (DOAN_QLQuanAn.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice; //Cộng tiền các món ăn lại
                lvHoaDon.Items.Add(lsvItem); //Món ăn được thêm vào hóa đơn
            }

            CultureInfo culture = new CultureInfo("vi-VN"); // Ở chổ tính tiền sẽ hiện đơn vị tiền VN
            txtTotalPrice.Text = totalPrice.ToString("c", culture); // Hiện tiền kiểu 0.000

            //Thread.CurrentThread.CurrentCulture = culture;
        }
        void LoadComboboxTable(ComboBox cb) //Load ra danh sách combobox bàn để có thể chọn chuyển bàn
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }
        List<Food> SearchFoodByName(string name) // Tìm món ăn gần giống với từ đã nhập
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }


        //Panel Doanh thu
        public void tinhTongDoanhThu() //Tính tổng doanh thu
        {
            try
            {
                int tien = dgvDoanhThu.Rows.Count;
                float thanhtien = 0;
                for (int i = 0; i < tien; i++)
                {
                    thanhtien += float.Parse(dgvDoanhThu.Rows[i].Cells["Tongtien"].Value.ToString());
                }
                txtTongDoanhThu.Text = thanhtien.ToString();
                CultureInfo culture = new CultureInfo("vi-VN"); // Ở chổ tính tiền sẽ hiện đơn vị tiền VN
                txtTongDoanhThu.Text = thanhtien.ToString("C3", culture); // Hiện tiền kiểu 0.000
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void LoadDateTimePickerBill() //Lấy thời gian từ datetimepicker
        {
            DateTime today = DateTime.Now;
            dateTuNgay.Value = new DateTime(today.Year, today.Month, 1);
            dateDenNgay.Value = dateTuNgay.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)//Xuất danh sách hóa đơn theo thời gian chọn
        {
            dgvDoanhThu.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }


        //Panel Tài khoản
        void AddAccountBinding(string textbox) //Hiển thị thông tin từ datagridview sang textbox ( dùng để truyền dữ liệu qua form đổi mật khẩu)
        {
            txtTenTaiKhoan.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtHienThiTenTK.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            numLoaiTaiKhoan.DataBindings.Add(new Binding("Value", dgvTaiKhoan.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void AddAccount(string userName, string displayName, int type) //Thêm tài khoản
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }
        void EditAccount(string userName, string displayName, int type) //Sửa tài khoản
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }
        void DeleteAccount(string userName) //Xóa tài khoản
        {
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }


        #endregion

        //Code các sự kiện
        #region Events 

        private void FQuanLy_Load(object sender, EventArgs e)
        {
            /*
            //Report Thực đơn
            this.uSP_GetFoodListTableAdapter.Fill(this.doAn_QLDOAN_QLQuanAnDataSet1.USP_GetFoodList);
            this.reportThucDon.RefreshReport();

            //Report Danh sách bàn
            this.USP_GetTableListTableAdapter.Fill(this.DoAn_QLDOAN_QLQuanAnDataSet.USP_GetTableList);
            this.reportDSBan.RefreshReport();
            */
        }


        //Hóa đơn
        void btn_Click(object sender, EventArgs e) //taọ button bàn cho flowpanel hiện bàn
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lvHoaDon.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void btThemMon_Click(object sender, EventArgs e)
        {
            LoadListFood();
            try
            {
                Table table = lvHoaDon.Tag as Table;

                if (table == null)
                {
                    MessageBox.Show("Hãy chọn bàn!!");
                    return;
                }

                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
                int foodID = (cbMonAn.SelectedItem as Food).ID;
                int count = (int)numDemMon.Value;

                if (idBill == -1)
                {
                    MessageBox.Show("Đã thêm món thành công");
                    BillDAO.Instance.InsertBill(table.ID);
                    BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
                }
                else
                {
                    BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
                }
                ShowBill(table.ID);
                LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lvHoaDon.Tag as Table;

                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
                int discount = (int)numGiamGia.Value;

                double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split(',')[0]);
                double finalTotalPrice = totalPrice - (totalPrice / 100) * discount; //Tính tổng tiền khi có giảm giá

                if (idBill != -1)
                {
                    if (MessageBox.Show("Bạn có muốn in hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                      //  FReport rp = new FReport(dateTuNgay.Text, discount);
                       // rp.ShowDialog();
                    }
                    if (MessageBox.Show(string.Format("Bạn có chắc muốn thanh toán hóa đơn cho bàn {0} \nTổng tiền - (Tổng tiền / 100) x Giảm giá \n => {1:#,##0.#00} - ({1:#,##0.#00} / 100) x {2} = {3:#,##0.#00}",
                                                    table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                        ShowBill(table.ID);
                        LoadTable();
                    }
                    numGiamGia.Value = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btChuyenBan_Click(object sender, EventArgs e)
        {
            try
            {
                int id1 = (lvHoaDon.Tag as Table).ID;

                int id2 = (cbChuyenBan.SelectedItem as Table).ID;
                if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lvHoaDon.Tag as Table).Name, (cbChuyenBan.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    TableDAO.Instance.SwitchTable(id1, id2);

                    LoadTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cbDanhMucMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }
        private void btInHoaDon_Click(object sender, EventArgs e)
        {
            int discount = (int)numGiamGia.Value;
           // FReport rp = new FReport(dateTuNgay.Text, discount);
            //rp.ShowDialog();
        }


        //Thực đơn
        private void btTimMonAn_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txtTimMonAn.Text);
        }
        private void btThemThucDon_Click(object sender, EventArgs e)
        {

            string name = txtMonAn.Text;
            int categoryID = (cbDMThucAn.SelectedItem as Category).ID;
            float price = (float)numGiaThucAn.Value;
            if (name.Equals("") || price.Equals("") || categoryID == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!!!");
            }
            else
            {
                try
                {
                    DialogResult check = MessageBox.Show($"Bạn có muốn thêm món {txtMonAn.Text.Trim()}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (check == DialogResult.Yes)
                    {
                        if (FoodDAO.Instance.InsertFood(name, categoryID, price))
                        {
                            MessageBox.Show("Thêm món ăn thành công");
                            LoadListFood();
                            if (insertFood != null) //Kiểm tra món đó có chưa
                                insertFood(this, new EventArgs());
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi khi thêm thức ăn");
                        }
                        LoadFoodListByCategoryID((cbDMThucAn.SelectedItem as Category).ID);
                        if (lvHoaDon.Tag != null)
                        {
                            ShowBill((lvHoaDon.Tag as Table).ID);
                        }
                    }
                    LoadTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btSuaThucDon_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtMonAn.Text;
                int categoryID = (cbDanhMucMon.SelectedItem as Category).ID;
                float price = (float)numGiaThucAn.Value;
                int id = Convert.ToInt32(txtIDMonAn.Text);

                if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
                {
                    MessageBox.Show("Sửa món thành công");
                    LoadListFood();
                    if (updateFood != null)
                        updateFood(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa thức ăn");
                }
                LoadFoodListByCategoryID((cbDMThucAn.SelectedItem as Category).ID);
                if (lvHoaDon.Tag != null)
                {
                    ShowBill((lvHoaDon.Tag as Table).ID);
                }
                LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btXoaThucDon_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIDMonAn.Text);
                DialogResult check = MessageBox.Show($"Bạn có muốn xóa món {txtMonAn.Text.Trim()}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    if (FoodDAO.Instance.DeleteFood(id))
                    {
                        MessageBox.Show("Xóa món thành công");
                        LoadListFood();
                        if (deleteFood != null)
                            deleteFood(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xóa thức ăn");
                    }
                    LoadFoodListByCategoryID((cbDMThucAn.SelectedItem as Category).ID);
                    if (lvHoaDon.Tag != null)
                    {
                        ShowBill((lvHoaDon.Tag as Table).ID);
                    }
                }
                LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void picFood_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Image Files (*.jpg; *.png; *.gif;)|*.jpg; *.png; *.gif;";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                imageFoodText.Text = openfd.FileName;
                picFood.Image = new Bitmap(openfd.FileName);
                picFood.ImageLocation = openfd.FileName;
                picFood.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void btXemMon_Click(object sender, EventArgs e)
        {
            LoadListFood();
            txtIDMonAn.Text = "";
            txtMonAn.Text = "";
            numGiaThucAn.Value = 0;
        }
        private void txtIDMonAn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvMonAn.SelectedCells.Count > 0)
                {
                    int id = (int)dgvMonAn.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    cbDMThucAn.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbDMThucAn.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbDMThucAn.SelectedIndex = index;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cbDMThucAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }

        //Danh mục
        private void btXemDanhMuc_Click(object sender, EventArgs e)
        {
            LoadListCategory();
            txtIDDanhmuc.Text = "";
            txtTenDanhMuc.Text = "";
        }
        private void btThemDanhMuc_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtTenDanhMuc.Text;

                if (CategoryDAO.Instance.InsertFoodCategory(name))
                {
                    MessageBox.Show("Thêm danh mục thành công " + txtTenDanhMuc.Text.Trim());
                    LoadListCategory();
                    if (insertCategory != null) //Kiểm tra danh mục đó có chưa
                        insertCategory(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm danh mục");
                }
                LoadCategory(); //Câp nhật lại combobox danh mục
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btXoaDanhMuc_Click(object sender, EventArgs e)
        {
            try
            {
                //category.Name = txtTenDanhMuc.Text;
                int id = Convert.ToInt32(txtIDDanhmuc.Text);
                DialogResult check = MessageBox.Show($"Bạn có muốn xóa danh mục {txtTenDanhMuc.Text.Trim()}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    if (CategoryDAO.Instance.DeleteFoodCategory(id))
                    {
                        LoadListCategory();
                        if (deleteCategory != null)
                            deleteCategory(this, new EventArgs());
                        MessageBox.Show("Xóa danh mục thành công");
                    }
                    else
                    {
                        //MessageBox.Show("Có lỗi khi xóa danh mục");
                        MessageBox.Show("Xóa danh mục thành công");
                    }
                }
                LoadCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btSuaDanhMuc_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtTenDanhMuc.Text;
                int id = Convert.ToInt32(txtIDDanhmuc.Text);

                if (CategoryDAO.Instance.UpdateFoodCategory(name, id))
                {
                    MessageBox.Show("Sửa danh mục thành công");
                    LoadListCategory();
                    if (updateCategory != null)
                        updateCategory(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa danh mục!!!");
                }
                //LoadListCategoryByCategoryID((cbDanhMucMon.SelectedItem as Category).ID);
                //if (lvHoaDon.Tag != null)
                //{
                //    ShowBill((lvHoaDon.Tag as Table).ID);
                //}
                LoadCategory();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void picDanhMuc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Image Files (*.jpg; *.png; *.gif;)|*.jpg; *.png; *.gif;";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                imageDanhMucText.Text = openfd.FileName;
                picDanhMuc.Image = new Bitmap(openfd.FileName);
                picDanhMuc.ImageLocation = openfd.FileName;
                picDanhMuc.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //DS Bàn
        private void btThemBan_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtTenBan.Text;
                string status = txtTrangThaiBan.Text;
                DialogResult check = MessageBox.Show($"Bạn có muốn thêm bàn {txtTenBan.Text.Trim()}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    if (TableDAO.Instance.InsertTable(name, status))
                    {
                        MessageBox.Show("Thêm bàn thành công");
                        LoadListTable();
                        if (insertTable != null) //Kiểm tra bàn đó có chưa
                            insertTable(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm bàn");
                    }
                }
                LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btXoaBan_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtIDBan.Text);

                DialogResult check = MessageBox.Show($"Bạn có muốn xóa bàn {txtTenBan.Text.Trim()}", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    if (TableDAO.Instance.DeleteTable(id))
                    {
                        MessageBox.Show("Xóa bàn thành công.");
                        LoadListTable();
                        if (deleteTable != null)
                            deleteTable(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi xóa bàn");
                    }
                }
                LoadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btSuaBan_Click(object sender, EventArgs e)
        {
            string status = txtTrangThaiBan.Text;
            string name = txtTenBan.Text;
            int id = Convert.ToInt32(txtIDBan.Text);

            if (TableDAO.Instance.UpdateTable(name, status, id))
            {
                MessageBox.Show("Sửa bàn thành công");
                LoadListCategory();
                if (updateTable != null)
                    updateTable(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa bàn");
            }
            LoadTable();
        }
        private void btXemBan_Click(object sender, EventArgs e)
        {
            LoadListTable();
            txtIDBan.Text = "";
            txtTenBan.Text = "";
        }


        //Tài khoản
        private void btThemTK_Click(object sender, EventArgs e)
        {
            string userName = txtTenTaiKhoan.Text;
            string displayName = txtHienThiTenTK.Text;
            int type = (int)numLoaiTaiKhoan.Value;

            AddAccount(userName, displayName, type);
        }
        private void btXoaTK_Click(object sender, EventArgs e)
        {
            string userName = txtTenTaiKhoan.Text;

            DeleteAccount(userName);
        }
        private void btSuaTK_Click(object sender, EventArgs e)
        {
            string userName = txtTenTaiKhoan.Text;
            string displayName = txtHienThiTenTK.Text;
            int type = (int)numLoaiTaiKhoan.Value;

            EditAccount(userName, displayName, type);
        }
        private void btXemTK_Click(object sender, EventArgs e)
        {
            LoadAccount();
            txtTenTaiKhoan.Text = "";
            txtHienThiTenTK.Text = "Nhân viên";
            numLoaiTaiKhoan.Value = 0;
        }
        private void btCaiDatMK_Click(object sender, EventArgs e)
        {
            ChangePassword f = new ChangePassword(txtTenTaiKhoan.Text, txtHienThiTenTK.Text); //Mở form cài đặt lại mật khẩu (khai báo biến liên kết form MK)
            f.ShowDialog();
        }
        private void rpTaiKhoan_Click(object sender, EventArgs e)
        {
            //Report Tài khoản

            //this.USP_GetAccountByUserNameTableAdapter.Fill(this.DoAn_QLDOAN_QLQuanAnDataSet3.USP_GetAccountByUserName, txtReportTK.Text);
            //this.reportTaiKhoan.RefreshReport();

            /*Code Report thông tin tài khoản
            try
            {
                if (txtReportTK.Text == "" || txtrpUser.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ!!!");
                }
                else
                {
                    int i = int.Parse(txtrpUser.Text);

                    this.accountTableAdapter.Fill(this.doAn_QLDOAN_QLQuanAnDataSet3.Account, txtReportTK.Text, i);
                    this.reportTaiKhoan.RefreshReport();
                }
            }
            catch { }*/
        }


        //Doanh thu
        private void btThongKe_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dateTuNgay.Value, dateDenNgay.Value);
            tinhTongDoanhThu();
        }

        private void rpDoanhThu_Click(object sender, EventArgs e)
        {
            //this.uSP_RPGetListBillByDateTableAdapter.Fill(this.doAn_QLDOAN_QLQuanAnDataSet2.USP_RPGetListBillByDate, dateFromDate.Value, dateToDate.Value); Lỗi

            //Gán param cho ngày
            //Microsoft.Reporting.WinForms.ReportParameter[] parameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            //{
            //new Microsoft.Reporting.WinForms.ReportParameter("fromDate",dateFromDate.Value.Date.ToShortDateString()),
            //new Microsoft.Reporting.WinForms.ReportParameter("toDate", dateToDate.Value.ToShortDateString())
            //};
            //reportDoanhThu.LocalReport.SetParameters(parameters);
            //this.LoadDateTimePickerBill();
            //this.reportDoanhThu.RefreshReport();
        }

        //Code các chức năng cho form
        private void picMoMo_Click(object sender, EventArgs e)
        {
            //int a;
            Momo momo = new Momo(); //Mở form MoMo quét mã QR
            momo.ShowDialog();
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //Tạo nút ẩn phần mềm xuống taskbar
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        //moveImg & Home_CheckedChanged dùng để tạo chức năng check khi bấm vào các button của menu QL
        private void moveImg(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 34, b.Location.Y - 25);
            imgSlide.SendToBack();
        }

        private void Home_CheckedChanged(object sender, EventArgs e)
        {
            moveImg(sender);
        }

        //Trang chủ
        private void btHome_Click(object sender, EventArgs e)
        {
            panelHome.Visible = true;
            panelThucDon.Visible = false;
            panelDanhMuc.Visible = false;
            panelDSBan.Visible = false;
            panelHoaDon.Visible = false;
            panelDoanhThu.Visible = false;
            panelTaiKhoan.Visible = false;
            panelReport.Visible = false;
            panelReportDSBan.Visible = false;
            panelReportThucDon.Visible = false;
            panelReportTaiKhoan.Visible = false;
        }

        //Trang thực đơn
        private void btFood_Click(object sender, EventArgs e)
        {
            panelThucDon.Visible = true;
            panelDanhMuc.Visible = false;
            panelDSBan.Visible = false;
            panelHoaDon.Visible = false;
            panelDoanhThu.Visible = false;
            panelTaiKhoan.Visible = false;
            panelHome.Visible = false;
            panelReport.Visible = false;
            panelReportDSBan.Visible = false;
            panelReportThucDon.Visible = false;
            panelReportTaiKhoan.Visible = false;
        }

        //Trang danh mục
        private void btDanhMuc_Click(object sender, EventArgs e)
        {
            panelDanhMuc.Visible = true;
            panelThucDon.Visible = false;
            panelDSBan.Visible = false;
            panelHoaDon.Visible = false;
            panelDoanhThu.Visible = false;
            panelTaiKhoan.Visible = false;
            panelHome.Visible = false;
            panelReport.Visible = false;
            panelReportDSBan.Visible = false;
            panelReportThucDon.Visible = false;
            panelReportTaiKhoan.Visible = false;
        }

        //Trang danh sách bàn
        private void btDSBan_Click(object sender, EventArgs e)
        {
            panelDSBan.Visible = true;
            panelThucDon.Visible = false;
            panelDanhMuc.Visible = false;
            panelHoaDon.Visible = false;
            panelDoanhThu.Visible = false;
            panelTaiKhoan.Visible = false;
            panelHome.Visible = false;
            panelReport.Visible = false;
            panelReportDSBan.Visible = false;
            panelReportThucDon.Visible = false;
            panelReportTaiKhoan.Visible = false;
        }

        //Trang doanh thu
        private void btDoanhThu_Click(object sender, EventArgs e)
        {
            //panelDoanhThu.Visible = true;
            //panelDSBan.Visible = false;
            //panelThucDon.Visible = false;
            //panelDanhMuc.Visible = false;
            //panelHoaDon.Visible = false;
            //panelTaiKhoan.Visible = false;
            //panelHome.Visible = false;
            //panelReport.Visible = false;
            //panelReportDSBan.Visible = false;
            //panelReportThucDon.Visible = false;
            //panelReportTaiKhoan.Visible = false;
        }

        //Trang hóa đơn
        private void btHoaDon_Click(object sender, EventArgs e)
        {
            panelHoaDon.Visible = true;
            panelDSBan.Visible = false;
            panelThucDon.Visible = false;
            panelDanhMuc.Visible = false;
            panelDoanhThu.Visible = false;
            panelTaiKhoan.Visible = false;
            panelHome.Visible = false;
            panelReport.Visible = false;
            panelReportDSBan.Visible = false;
            panelReportThucDon.Visible = false;
            panelReportTaiKhoan.Visible = false;
        }

        //Trang tài khoản
        private void btTaiKhoan_Click(object sender, EventArgs e)
        {
            //panelTaiKhoan.Visible = true;
            //panelHoaDon.Visible = false;
            //panelDSBan.Visible = false;
            //panelThucDon.Visible = false;
            //panelDanhMuc.Visible = false;
            //panelDoanhThu.Visible = false;
            //panelHome.Visible = false;
            //panelReport.Visible = false;
            //panelReportDSBan.Visible = false;
            //panelReportThucDon.Visible = false;
            //panelReportTaiKhoan.Visible = false;
        }

        //Trang report doanh thu
        private void btReportDoanhThu_Click(object sender, EventArgs e)
        {
            panelReport.Visible = true;
            panelHoaDon.Visible = false;
            panelDSBan.Visible = false;
            panelThucDon.Visible = false;
            panelDanhMuc.Visible = false;
            panelDoanhThu.Visible = false;
            panelTaiKhoan.Visible = false;
            panelHome.Visible = false;
            panelReportDSBan.Visible = false;
            panelReportThucDon.Visible = false;
            panelReportTaiKhoan.Visible = false;
        }

        //Trang report danh sách bàn
        private void btRPDSBan_Click(object sender, EventArgs e)
        {
            panelReportDSBan.Visible = true;
            panelReport.Visible = false;
            panelHoaDon.Visible = false;
            panelDSBan.Visible = false;
            panelThucDon.Visible = false;
            panelDanhMuc.Visible = false;
            panelDoanhThu.Visible = false;
            panelTaiKhoan.Visible = false;
            panelHome.Visible = false;
            panelReportThucDon.Visible = false;
            panelReportTaiKhoan.Visible = false;
        }

        private void btReportThucDon_Click(object sender, EventArgs e)
        {
            panelReportThucDon.Visible = true;
            panelReportTaiKhoan.Visible = false;
            panelReportDSBan.Visible = false;
            panelReport.Visible = false;
            panelHoaDon.Visible = false;
            panelDSBan.Visible = false;
            panelThucDon.Visible = false;
            panelDanhMuc.Visible = false;
            panelDoanhThu.Visible = false;
            panelTaiKhoan.Visible = false;
            panelHome.Visible = false;
        }

        private void btReportTaiKhoan_Click(object sender, EventArgs e)
        {
            panelReportTaiKhoan.Visible = true;
            panelReportThucDon.Visible = false;
            panelReportDSBan.Visible = false;
            panelReport.Visible = false;
            panelHoaDon.Visible = false;
            panelDSBan.Visible = false;
            panelThucDon.Visible = false;
            panelDanhMuc.Visible = false;
            panelDoanhThu.Visible = false;
            panelTaiKhoan.Visible = false;
            panelHome.Visible = false;
        }

        //Thêm ảnh
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.JPG)| *.JPG | GIF Files(*.GIF) | *.GIF";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                picFood.Image = Image.FromFile(dlg.FileName);
            }
        }

        //Chưa áp dụng được. Kiểu hiển thị gợi ý nên làm gì khi để chuột vào chổ đó
        void HelpHoaDon()
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.helpHoaDon = new HelpProvider();
            this.helpHoaDon.SetShowHelp(this.cbDanhMucMon, true);
            this.helpHoaDon.SetHelpString(this.cbDanhMucMon, "Chọn danh mục món cần tìm");
            this.helpHoaDon.HelpNamespace = "mspaint.chm";
        }

        #endregion

        //Món ăn

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }


        //Danh mục
        private event EventHandler insertCategory;
        public event EventHandler InsertCategory
        {
            add { insertCategory += value; }
            remove { insertCategory -= value; }
        }

        private event EventHandler deleteCategory;
        public event EventHandler DeleteCategory
        {
            add { deleteCategory += value; }
            remove { deleteCategory -= value; }
        }

        private event EventHandler updateCategory;
        public event EventHandler UpdateCategory
        {
            add { updateCategory += value; }
            remove { updateCategory -= value; }
        }


        //DS Bàn
        private event EventHandler insertTable;
        public event EventHandler InsertTable
        {
            add { insertTable += value; }
            remove { insertTable -= value; }
        }

        private event EventHandler deleteTable;
        public event EventHandler DeleteTable
        {
            add { deleteTable += value; }
            remove { deleteTable -= value; }
        }

        private event EventHandler updateTable;
        public event EventHandler UpdateTable
        {
            add { updateTable += value; }
            remove { updateTable -= value; }
        }
    }
}
