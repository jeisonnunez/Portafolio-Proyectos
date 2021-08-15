using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace LicenceSCVSystem
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string fileName;

        public AsymmetricAlgorithm privateKey;        

        const string pfxPath = @"C:\Users\jamara\Desktop\OpenSSL-Win64\bin\scv-test-cert.pfx";

        public ValidationLicence ValidationLicence;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnGenerar_Click(object sender, RoutedEventArgs e)
        {
            CreateLicenceFile();

            ClearFields();
           
            GetPrivateKey();

            SignXmlFile(fileName); 
        }

        private void GetPrivateKey()
        {   
            X509Certificate2 cert = new X509Certificate2(File.ReadAllBytes(pfxPath), "Msn363gr");

            privateKey=cert.GetRSAPrivateKey();            

            //Console.WriteLine("{0}Subject: {1}{0}", Environment.NewLine, cert.Subject);
            //Console.WriteLine("{0}Issuer: {1}{0}", Environment.NewLine, cert.Issuer);
            //Console.WriteLine("{0}Version: {1}{0}", Environment.NewLine, cert.Version);
            //Console.WriteLine("{0}Valid Date: {1}{0}", Environment.NewLine, cert.NotBefore);
            //Console.WriteLine("{0}Expiry Date: {1}{0}", Environment.NewLine, cert.NotAfter);
            //Console.WriteLine("{0}Thumbprint: {1}{0}", Environment.NewLine, cert.Thumbprint);
            //Console.WriteLine("{0}Serial Number: {1}{0}", Environment.NewLine, cert.SerialNumber);
            //Console.WriteLine("{0}Friendly Name: {1}{0}", Environment.NewLine, cert.PublicKey.Oid.FriendlyName);
            //Console.WriteLine("{0}Public Key Format: {1}{0}", Environment.NewLine, cert.PublicKey.EncodedKeyValue.Format(true));
            //Console.WriteLine("{0}Raw Data Length: {1}{0}", Environment.NewLine, cert.RawData.Length);
            //Console.WriteLine("{0}Certificate to string: {1}{0}", Environment.NewLine, cert.ToString(true));
            //Console.WriteLine("{0}Certificate to XML String: {1}{0}", Environment.NewLine, cert.PublicKey.Key.ToXmlString(false));


            if (privateKey == null)
            {
                throw new Exception("No valid cert was found");
            }            
        }

        

        public void SignXmlFile(string FileName)
        {
            // Create a new XML document.
            XmlDocument doc = new XmlDocument();

            // Load the passed XML file using its name.
          

            XmlTextReader xml = new XmlTextReader(FileName);

            doc.Load(xml);            
            //Creating the XML signing object.


            // Create a SignedXml object.
            SignedXml signedXml = new SignedXml(doc);

            // Add the key to the SignedXml document. 
            signedXml.SigningKey = privateKey;

            // Create a reference to be signed.
            Reference reference = new Reference();
            reference.Uri = "";

            // Add an enveloped transformation to the reference.
            XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
            reference.AddTransform(env);

            // Add the reference to the SignedXml object.
            signedXml.AddReference(reference);

            // Compute the signature.
            signedXml.ComputeSignature();

            // Get the XML representation of the signature and save
            // it to an XmlElement object.
            XmlElement xmlDigitalSignature = signedXml.GetXml();

            // Append the element to the XML document.
            doc.DocumentElement.AppendChild(doc.ImportNode(xmlDigitalSignature, true));

            if (doc.FirstChild is XmlDeclaration)
            {
                doc.RemoveChild(doc.FirstChild);
            }

            // Save the signed XML document to a file specified
            // using the passed string.

            xml.Close();

            XmlTextWriter xmltw = new XmlTextWriter(FileName, new UTF8Encoding(false));
            doc.WriteTo(xmltw);
            xmltw.Close();
        }

       

        private void ClearFields()
        {
            txtServidor.Text = "";
            txtHardWareKey.Text = "";
            dpFechaVencimiento.SelectedDate = null;
            dpFechaInicio.SelectedDate = null;
        }

        private void CreateLicenceFile()
        {
            fileName = System.IO.Path.GetDirectoryName(@"C:\Users\jamara\source\repos\LicenceSCVSystem\Licenses\SCV_License_") + Guid.NewGuid().ToString() + ".xml"; //archivo temporal

            using (XmlWriter writer = XmlWriter.Create(fileName))
            {
                XmlDocument doc = new XmlDocument();

                XmlNode docTitle = doc.CreateXmlDeclaration("1.0", "UTF-8", null);

                doc.AppendChild(docTitle);

                XmlNode licence = doc.CreateElement("LICENCE");

                doc.AppendChild(licence);

                XmlAttribute server = doc.CreateAttribute("SERVER");

                server.Value = txtServidor.Text;

                licence.Attributes.Append(server);

                XmlAttribute hardwareKey = doc.CreateAttribute("HARDWAREKEY");

                hardwareKey.Value = txtHardWareKey.Text;

                licence.Attributes.Append(hardwareKey);

                XmlAttribute fechaInicio = doc.CreateAttribute("CREATION");

                fechaInicio.Value = String.Format("{0:yyyyMMdd}", dpFechaInicio.SelectedDate);

                licence.Attributes.Append(fechaInicio);

                XmlAttribute fechaVencimiento = doc.CreateAttribute("EXPIRED");

                fechaVencimiento.Value = String.Format("{0:yyyyMMdd}", dpFechaVencimiento.SelectedDate);

                licence.Attributes.Append(fechaVencimiento);

                writer.Close(); //cierra el escritor

                doc.Save(fileName); //guarda el archivo temporal               

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ClearFields();            

            GetPrivateKey();

            CreateValidationLicenceObject();

        }

        private void CreateValidationLicenceObject()
        {
            ValidationLicence validationLicence = new ValidationLicence();

            ValidationLicence = validationLicence;
        }

        private void LoadedWindow()
        {
            ClearFields();         

            GetPrivateKey();

        }

        private void btnValidar_Click(object sender, RoutedEventArgs e)
        {
            ValidationLicence.Show();
        }
    }
}
