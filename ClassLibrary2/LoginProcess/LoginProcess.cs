using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DataAccessLayer.LoginProgres
{
    public class LoginProcess
    {
  
        public static Boolean LoginControl(string kullanıcıAdı, string parola)
        {
            using (KutuphaneEntities context = new KutuphaneEntities())//Using kullanımı newlenen nesneyi kullanıktan sonr siler
            {
                Kullanici kullanici = context.Kullanici.Where(n => n.KullaniciAdi == kullanıcıAdı && n.Parola == parola).FirstOrDefault();
                if (kullanici != null)
                    return true;
            }
            return false;
        }

        //////////////////////////////XML////////////////////////////////
        public void XmlYaz(string kullaniciAdi, string parola)
        {
            string path = Application.StartupPath + "\\log.xml";

            if (File.Exists(path))
            {
                ReadDataFromXml(path, kullaniciAdi, parola);
            }
            else
            {
                CreateXmlFile(path, kullaniciAdi, parola);
            }
        }
        private static void CreateXmlFile(string path, string kullaniciAdi, string parola)
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t"
            };

            using (XmlWriter xmlWriter = XmlWriter.Create(path, settings))
            {
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Root");

                xmlWriter.WriteStartElement("KullanıcıAdı");
                xmlWriter.WriteString(kullaniciAdi);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteStartElement("Parola");
                xmlWriter.WriteString(parola);
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
            }


        }
        private static void ReadDataFromXml(string path, string kullaniciAdi, string parola)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);

            XmlNode rootNode = xmlDoc.DocumentElement;

            if (rootNode.HasChildNodes)
            {
                if (!(rootNode.FirstChild.InnerText == kullaniciAdi && rootNode.LastChild.InnerText == parola))
                {
                    rootNode.RemoveAll();
                    CreateXmlFile(path, kullaniciAdi, parola);
                }
            }
        }


        public void XmlBilgiSil()
        {
            string path = Application.StartupPath + "\\log.xml";
            CreateXmlFile(path, "", "");

        }
        //////////////////////////////JSON////////////////////////////////
        public void JsonYaz(string kullaniciAdi, string parola)
        {
            string calismaDizini = Application.StartupPath + "\\log.json";
            if (!File.Exists(calismaDizini))
            {
                File.Create(calismaDizini).Close();
            }
            string jsond = File.ReadAllText(calismaDizini);
            Kullanici k = JsonConvert.DeserializeObject<Kullanici>(jsond);
            if (jsond == "")
            {
                Kullanici kullanici = new Kullanici
                {
                    KullaniciAdi = kullaniciAdi,
                    Parola = parola
                };
                string jsonData = JsonConvert.SerializeObject(kullanici);
                File.WriteAllText(calismaDizini, jsonData);
            }
            else
            {
                string okunan = File.ReadAllText(calismaDizini);
                Kullanici kullanici = JsonConvert.DeserializeObject<Kullanici>(okunan);
                if (!(kullanici.KullaniciAdi == kullaniciAdi && kullanici.Parola == parola))
                {
                    Kullanici yeniKullanıcı = new Kullanici
                    {
                        KullaniciAdi = kullaniciAdi,
                        Parola = parola
                    };
                    string jsonData = JsonConvert.SerializeObject(yeniKullanıcı);
                    File.WriteAllText(calismaDizini, jsonData);
                }
            }
        }

        public Kullanici readData(string bilgi)
        {
            if (bilgi == "XML")
            {
                Kullanici kullanici = new Kullanici();
                string path = Application.StartupPath + "\\log.xml";
                if (File.Exists(path))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(path);

                    XmlNode rootNode = xmlDoc.DocumentElement;


                    kullanici.KullaniciAdi = rootNode.FirstChild.InnerText;
                    kullanici.Parola = rootNode.LastChild.InnerText;
                }
                return kullanici;
            }
            else
            {
                string calismaDizini = Application.StartupPath + "\\log.json";
                string okunan = File.ReadAllText(calismaDizini);
                Kullanici kullanici = JsonConvert.DeserializeObject<Kullanici>(okunan);
                return kullanici;
            }
        }
        public void JsonBilgiSil()
        {
            string calismaDizini = Application.StartupPath + "\\log.json";
            string jsond = File.ReadAllText(calismaDizini);
            Kullanici k = JsonConvert.DeserializeObject<Kullanici>(jsond);
            Kullanici kullanici = new Kullanici
            {
                KullaniciAdi = "",
                Parola = ""
            };
            string jsonData = JsonConvert.SerializeObject(kullanici);
            File.WriteAllText(calismaDizini, jsonData);

        }

    }
}


