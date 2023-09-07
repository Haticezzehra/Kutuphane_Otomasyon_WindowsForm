using DevExpress.XtraPrinting.Native.Lines;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Image_Processing
{
    public class ImageProcesssing
    {

        public static byte[] ResminKalitesiniDusur(Image resim)
        {
            // Resmi boyutlandırıyoruz.
            //İlk olarak, Bitmap sınıfını kullanarak verilen resim nesnesini belirtilen
            //genislik ve yukseklik değerlerine uygun olarak yeni bir bitmap oluşturuyoruz.
            //// Resmi belirtilen dosya yoluna kaydediyoruz.
           // image.Save(dosyaYolu);
            Bitmap myBitmap = new Bitmap(resim, 1000, 1000);
            ImageCodecInfo myImageCodecInfo = TipBilgisi("image/jpeg");
            System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 50L);
            EncoderParameters myEncoderParameters = new EncoderParameters(1);
            myEncoderParameters.Param[0] = myEncoderParameter;

            using (MemoryStream ms = new MemoryStream())
            {
                myBitmap.Save(ms, myImageCodecInfo, myEncoderParameters);
                return ms.ToArray();
            }
        }

        //  TipBilgisi metodu, verilen mimeType parametresine uygun olan codec /
        //  bilgisini döndürmek için bu dizi içinde dolaşır ve aranan MIME
        //  türünü(mimeType) bulduğunda ilgili ImageCodecInfo nesnesini geri döndürür.
        //  Eğer verilen MIME türüne uygun codec bilgisi bulunamazsa, null değeri döndürür.
        private static ImageCodecInfo TipBilgisi(string mimeType)
        {
            ImageCodecInfo[] encoders = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in encoders)
            {
                if (codec.MimeType == mimeType)
                    return codec;
            }
            return null;
        }
    }
}
