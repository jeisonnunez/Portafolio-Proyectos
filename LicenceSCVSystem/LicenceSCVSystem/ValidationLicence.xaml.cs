using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Windows.Shapes;
using System.Xml;

namespace LicenceSCVSystem
{
    /// <summary>
    /// Lógica de interacción para ValidationLicence.xaml
    /// </summary>
    public partial class ValidationLicence : Window
    {
        const string pathPublicKey = @"C:\Users\jamara\source\repos\LicenceSCVSystem\ModeloPublicKey\obj\Debug\ModeloPublicKey.dll";

        public byte[] PublicKey;
        public ValidationLicence()
        {
            InitializeComponent();
        }

        public bool VerifyXmlFile(string Name)
        {
            XmlDocument document = new XmlDocument();

            document.Load(Name);

            X509Certificate2 x509 = new X509Certificate2(PublicKey);

            SignedXml signedXml = new SignedXml(document);

            XmlNode xmlNode = document.GetElementsByTagName("Signature")[0];

            signedXml.LoadXml((XmlElement)xmlNode);

            return signedXml.CheckSignature(x509, true);
        }

        private void GetPublicKey()
        {
            Assembly a = Assembly.LoadFile(pathPublicKey);
            // Get the type to use.
            Type myType = a.GetType("ModeloPublicKey.ModeloPublicKey");
            // Get the method to call.
            PropertyInfo publicKey = myType.GetProperty("PublicKey", BindingFlags.Public | BindingFlags.Static);

            publicKey.GetValue(null).ToString();

            PublicKey = System.Text.Encoding.UTF8.GetBytes(publicKey.GetValue(null).ToString());

        }

        private void Validar_Click(object sender, RoutedEventArgs e)
        {
            GetPublicKey();

            try
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "XML Files (*.xml)|*.xml";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (openFileDialog.ShowDialog() == true)
                {


                    bool result = VerifyXmlFile(openFileDialog.FileName);

                    // Display the results of the signature verification to 
                    // the console.
                    if (result)
                    {
                        MessageBox.Show("The XML signature is valid.");

                        Licence.Text = "The XML signature is valid.";
                    }
                    else
                    {
                        MessageBox.Show("The XML signature is not valid.");

                        Licence.Text = "The XML signature is not valid.";
                    }
                }
                



            }
            catch (CryptographicException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
