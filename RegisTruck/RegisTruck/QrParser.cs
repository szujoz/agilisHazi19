using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;

namespace RegisTruck
{
    public class QrParser
    {
        public BarcodeReader QrReader { get; set; }
        public BarcodeWriter QrWriter { get; set; }

        public QrParser()
        {
            QrReader = new BarcodeReader();
            QrWriter = new BarcodeWriter();

            QrWriter.Format = BarcodeFormat.QR_CODE;
            QrWriter.Options.Width  = 600;
            QrWriter.Options.Height = 600;
        }

        public String DecodeQr(Bitmap qrCode)
        {
            string qrContent = "";
            
            var result = QrReader.Decode(qrCode);

            if (result != null)
            {
                //txtDecoderType.Text = result.BarcodeFormat.ToString();
                qrContent = result.Text;
            }

            return qrContent;
        }

        public Bitmap GenerateQr(String json)
        {
            Bitmap picture;

            picture = new Bitmap(QrWriter.Write(json));

            return picture;
        }
    }
}
