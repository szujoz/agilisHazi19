using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisTruck
{
    public partial class Form1 : Form
    {
        public Serializer Serializer { get; set; }
        public Package DummyPackage { get; set; }

        public Form1()
        {
            InitializeComponent();
            Serializer = new Serializer();

            DummyPackage = new Package(2,
                                       1000,
                                       2.5,
                                       "2019.12.01",
                                       PackageType.Normal,
                                       "Ez kell az ingyen 2 kredithez");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string  json;
            Package package;

            json = Serializer.ToJson(DummyPackage);
            package = Serializer.PackageFromJson(json);

            DisplayPackage(package);
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
    }
}
