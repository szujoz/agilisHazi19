using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace RegisTruck
{
    public partial class Form1 : Form
    {
        public Serializer Serializer   { get; set; }
        public QrParser   QrParser     { get; set; }
        public Bitmap     QrCode       { get; set; }
        public Truck      Truck        { get; set; }
        public Settings  Settings      { get; set; }
        public Package   ActualPackage { get; set; }

        public Form1()
        {
            InitializeComponent();
            Serializer = new Serializer();
            QrParser   = new QrParser();
            Truck      = new Truck();

            Package dummyPackage1 = new Package(0, 1, 10, "1996.01.20", PackageType.Normal, "Leírááááááááás");
            Package dummyPackage2 = new Package(1, 3, 54, "2006.08.12", PackageType.Fragile, "Alle mögen when das Wetter ideal ist");

            List<Package> dummyPayload = new List<Package>();
            dummyPayload.Add(dummyPackage1);
            dummyPayload.Add(dummyPackage2);

            Truck.LoadInfo("Jungheinrich - EFG 316",
                           "SN-222-11-RT5",
                           2600,
                           1200,
                           1.5,
                           "Opera Thor",
                           75,
                           dummyPayload);

            DisplayTruck(Truck);
        }

        private void DisplayTruck(Truck truck)
        {
            tBox_TruckType.Text                 = Truck.Type.ToString();
            tBox_TruckSerialNumber.Text         = Truck.SerialNumber.ToString();
            tBox_TruckWeight.Text               = Truck.Weight.ToString() + " kg";
            tBox_TruckCapacity.Text             = Truck.Capacity.ToString() + " kg"; 
            tBox_TruckLiftHeight.Text           = Truck.LiftHeight.ToString() + " m";
            tBox_TruckOperator.Text             = Truck.Operator.ToString();
            tBox_TruckRepairState.Text          = Truck.RepairState.ToString() + " %";
            tBox_TruckOnboardPackagesCount.Text = Truck.Payload.Count.ToString();
            tBox_TruckPayloadWeight.Text        = Truck.GetPayloadWeight().ToString() + " kg";
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
            pic_QrGenerated.Image = QrParser.GenerateQr(tBox_JsonInput.Text);
        }

        private void btn_SaveQr_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Png Image|*.png|JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.pic_QrGenerated.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                        break;

                    case 2:
                        this.pic_QrGenerated.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 3:
                        this.pic_QrGenerated.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 4:
                        this.pic_QrGenerated.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }

        private void btn_LoadQrFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var image = new FileStream(openFileDialog1.FileName, FileMode.Open))
                    {
                        pic_LoadedQr.Image = Image.FromStream(image);
                    }
                }
                catch
                {

                }
            }
        }

        private void btn_ReadQr_Click(object sender, EventArgs e)
        {
            string json;

            // Get json from QR reader API
            //json = QrParser.DecodeQr(QrCode);
            json = QrParser.DecodeQr((Bitmap)pic_LoadedQr.Image);

            //json = Serializer.ToJson(DummyPackage);
            ActualPackage = Serializer.PackageFromJson(json);

            DisplayPackage(ActualPackage);
            tBox_JsonOutput.Text = json.ToString();
        }

        private void btn_ToPayload_Click(object sender, EventArgs e)
        {
            Truck.Payload.Add(ActualPackage);

            tBox_PayloadList.Text += Serializer.ToJson(ActualPackage) + "\r\n";
            tBox_TruckOnboardPackagesCount.Text = Truck.Payload.Count.ToString();
            tBox_TruckPayloadWeight.Text = Truck.GetPayloadWeight().ToString() + " kg";
        }

        private void btn_PayloadEmpty_Click(object sender, EventArgs e)
        {
            Truck.Payload.Clear();

            tBox_PayloadList.Text = "";
            tBox_TruckOnboardPackagesCount.Text = Truck.Payload.Count.ToString();
            tBox_TruckPayloadWeight.Text = Truck.GetPayloadWeight().ToString() + " kg";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(tBox_PayloadSelectedPackageID.Text.ToString());
            string payloadList = "";
            Package selectedPackage = null;

            foreach (var package in Truck.Payload)
            {
                if (package.Id == selectedId)
                {
                    selectedPackage = package;
                }
                else
                {
                    payloadList += Serializer.ToJson(package);
                }                
            }

            if (selectedPackage != null)
            {
                Truck.Payload.Remove(selectedPackage);
            }

            tBox_PayloadList.Text = payloadList;
            tBox_TruckOnboardPackagesCount.Text = Truck.Payload.Count.ToString();
            tBox_TruckPayloadWeight.Text = Truck.GetPayloadWeight().ToString() + " kg";
        }
    }
}
