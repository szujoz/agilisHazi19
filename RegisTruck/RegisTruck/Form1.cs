using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RegisTruck
{
    public partial class Form1 : Form
    {
        public Serializer Serializer { get; set; }
        public QrParser   QrParser   { get; set; }
        public Bitmap     QrCode     { get; set; }

        public Package DummyPackage { get; set; }
        public String TestPic { get; set; }

        public Form1()
        {
            InitializeComponent();
            Serializer = new Serializer();
            QrParser = new QrParser();

            DummyPackage = new Package(2,
                                       1000,
                                       2.5,
                                       "2019.12.01",
                                       PackageType.Normal,
                                       "Ez kell az ingyen 2 kredithez");


            var currDirectory = Directory.GetCurrentDirectory();
            TestPic = Directory.GetParent(currDirectory).ToString();
            TestPic = Directory.GetParent(TestPic).ToString();
            TestPic = Directory.GetParent(TestPic).ToString();
            TestPic = Directory.GetParent(TestPic).ToString();
            TestPic += "\\QRs\\qrcode.png";

            // load a bitmap
            QrCode = (Bitmap)Image.FromFile(TestPic);
        }

        private void btn_ReadQr_Click(object sender, EventArgs e)
        {
            string  json;
            Package package;

            // Get json from QR reader API
            //json = QrParser.DecodeQr(QrCode);
            json = QrParser.DecodeQr((Bitmap)pictureBox1.Image);

            //json = Serializer.ToJson(DummyPackage);
            package = Serializer.PackageFromJson(json);

            DisplayPackage(package);
            tBox_JsonOutput.Text = json.ToString();
        }

        private void DisplayPackage(Package package)
        {
            tBox_PackageId.Text          = package.Id.ToString();
            tBox_PackageDestination.Text = package.DestinationStationId.ToString();
            tBox_PackageWeight.Text      = package.Weight.ToString();
            tBox_PackageDeadline.Text    = package.Deadline.ToString();
            tBox_PackageType.Text        = Enum.GetName(typeof(PackageType), package.Type).ToString();
            tBox_PackageDescription.Text = package.Description.ToString();
        }

        private void btn_GenerateQr_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = QrParser.GenerateQr(tBox_JsonInput.Text);
        }
    }
}
