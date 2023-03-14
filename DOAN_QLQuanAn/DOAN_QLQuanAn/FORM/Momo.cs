using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode.Internal;
using ZXing.Rendering;
using DOAN_QLQuanAn.DAO;
using DOAN_QLQuanAn;

namespace DOAN_QLQuanAn
{
    public partial class Momo : Form
    {   
        //public int b;
        public Momo()
        {
            InitializeComponent();
        }

        private void btTaoQR_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSDT.Text == "" || txtHoTen.Text == "" || txtMail.Text == "" || txtTien.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                else
                {
                    var qrcode_text = $"2|99|0944934229|{txtHoTen.Text.Trim()}|{txtMail.Text.Trim()}|0|0|{txtTien.Text.Trim()}";

                    MessageBox.Show("Tạo mã thành công!^^");
                    BarcodeWriter barcodeWriter = new BarcodeWriter();
                    EncodingOptions encodingOptions = new EncodingOptions() { Width = 250, Height = 250, Margin = 0, PureBarcode = false };
                    encodingOptions.Hints.Add(EncodeHintType.ERROR_CORRECTION, ErrorCorrectionLevel.H);
                    barcodeWriter.Renderer = new BitmapRenderer();
                    barcodeWriter.Options = encodingOptions;
                    barcodeWriter.Format = BarcodeFormat.QR_CODE;
                    Bitmap bitmap = barcodeWriter.Write(qrcode_text);
                    Bitmap logo = resizeImage(Properties.Resources.MoMo_Logo, 64, 64) as Bitmap;
                    Graphics g = Graphics.FromImage(bitmap);
                    g.DrawImage(logo, new Point((bitmap.Width - logo.Width) / 2, (bitmap.Height - logo.Height) / 2));
                    picMomo.Image = bitmap;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Image resizeImage(Image image, int new_height, int new_width)
        {
            Bitmap new_image = new Bitmap(new_width, new_height);
            Graphics g = Graphics.FromImage((Image)new_image);
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(image, 0, 0, new_width, new_height);
            return new_image;
        }

        private void Momo_Load(object sender, EventArgs e)
        {
            //FQuanLy fQuanLy = new FQuanLy();
            //txtTien.Text = b.ToString();
            txtTien.Clear();
            txtTien.Focus();
        }

        //Mở file Help hướng dẫn sử dụng 
        private void btHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, System.IO.Path.Combine(Application.StartupPath, @"F:\IT\LTWINDOWS\MetroFood\FileHelp\FileHelp.chm"));
        }
    }
}
