using Entidades;
using Microsoft.Win32;
using Negocio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Xml;
using Vista.Clases_Basicas;
using WPFtoolkitFrameworkStalin.ViewModels;

namespace Vista
{
    public class EstableceLogin: Interface
    {
        ControladorRegistro cn = new ControladorRegistro();
        public static Window Screen { get; set; }

        public static Menu menuStatusBar;

        public static TablaRetencionImpuesto retencionImpuesto;

        public static MediosPago mediosPagoVentana;

        const string pathPublicKey = @"C:\Users\jamara\source\repos\LoginSystem\ConexionSQLServer\obj\Debug\ConexionSQLServer.dll";

        public static byte[] PublicKey;

        public static bool IsValid;

        public void IngresoSistema(string nombreSociedad, string username)
        {
            GetPublicKey();

            IsValid = VerifyXmlFile(Properties.Settings.Default.LicenseFile);
            
            Menu menu = new Menu(nombreSociedad, username,IsValid);

            Screen = menu;
            
            menuStatusBar = menu;            

            menu.Show();

            menu.WindowState = WindowState.Maximized;

            menu.Width = SystemParameters.PrimaryScreenWidth;

            menu.Height =SystemParameters.PrimaryScreenHeight;

            menu.ShowStatusMessage("Inicio de Sesion Exitoso", Brushes.LightGreen, Brushes.Black, "001-interface.png"); 
            
            LoadTipoCambio();

            CreateTableRetencion();

            CreateTableMediosPagos();

           
        }

        public bool VerifyXmlFile(string Name)
        {
            bool validate;

            try
            {
                var resultDatabase = cn.obtenerBaseDatos();                

                var licenceForDatabase = Properties.Settings.Default.LicenseInfo.Where(x => x.DataBase == resultDatabase.Item1).OrderByDescending(x => x.Code).First(); // obtiene el archivo de licencia mas actualizado para la base de datos

                    if(Environment.MachineName== licenceForDatabase.Server)
                    {
                        if(HardwareKey.GET_HARDWAREID == licenceForDatabase.HardwareKey)
                        {

                            var creationLicence = licenceForDatabase.FechaInicio;

                            DateTime now = (DateTime)fechaActual.GetFechaActual();

                            int result = DateTime.Compare(creationLicence, now);

                            if (result <= 0)
                            {
                                var expirationLicence = licenceForDatabase.FechaVencimiento;

                                int resultExpiration = DateTime.Compare(expirationLicence, now);

                                if (resultExpiration >= 0)
                                {
                                    validate = true;
                                }
                                else
                                {
                                    validate = false;
                                }

                            }
                            else
                            {
                                validate = false;
                            }

                           
                        }
                        else
                        {
                            validate = false;
                        }
                    }
                    else
                    {
                        validate = false;
                    }
                

                return validate;
            }
            catch (Exception ex)
            {
                App.GetMainWindowStatusBar().ShowStatusMessage("Error al verificar archivo de licencia: " + ex.Message, Brushes.Red, Brushes.White, "003-interface-2.png");

                validate = false;

                return validate;
            }

           
        }

        private void GetPublicKey()
        {
            Assembly a = Assembly.LoadFile(pathPublicKey);
            // Get the type to use.
            Type myType = a.GetType("Datos.ModeloPublicKey.ModeloPublicKey");
            // Get the method to call.
            PropertyInfo publicKey = myType.GetProperty("PublicKey", BindingFlags.Public | BindingFlags.Static);

            publicKey.GetValue(null).ToString();

            PublicKey = System.Text.Encoding.UTF8.GetBytes(publicKey.GetValue(null).ToString());

        }

        private void CreateTableMediosPagos()
        {
            MediosPago mediosPago = new MediosPago();

            mediosPagoVentana = mediosPago;           
        }

        private void CreateTableRetencion()
        {
            TablaRetencionImpuesto tablaRetencionImpuesto = new TablaRetencionImpuesto();

            retencionImpuesto = tablaRetencionImpuesto;
        }

       
        private void LoadTipoCambio()
        {
            TipoCambio ventanaTipoCambio = new TipoCambio();

            DoubleAnimation animation = new DoubleAnimation(0, 1,
                                 (Duration)TimeSpan.FromSeconds(1));
            ventanaTipoCambio.BeginAnimation(UIElement.OpacityProperty, animation);

            ventanaTipoCambio.Show();
        }


        public void UltimaSociedad(string sociedad)
        {
            Properties.Settings.Default.BaseDatos = sociedad;

            Properties.Settings.Default.Save();
            

        }

        public void UsuarioActual(string nombre,int user)
        {
            Properties.Settings.Default.Usuario = user;

            Properties.Settings.Default.NombreUsuario = nombre;

            Properties.Settings.Default.Save();
        }

        public static Window GetMenu()
        {
            return Screen;
        }

        public static Menu GetMenuStatusBar()
        {
            return menuStatusBar;
        }

        public static TablaRetencionImpuesto GetTablaRetencionImpuesto()
        {
            return retencionImpuesto;
        }

        public static MediosPago GetMediosPago()
        {
            return mediosPagoVentana;
        }
    }
}
