using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
using Negocio;
using Entidades;
using System.Collections.ObjectModel;

namespace Vista
{
    /// <summary>
    /// Lógica de interacción para PlanCuentas.xaml
    /// </summary>
    public partial class PlanCuentas : Window
    {
        ControladorPlanCuentas cn = new ControladorPlanCuentas();

        public ObservableCollection<string> TipoCuenta { get; set; }
      
        List<Cuenta> listaCuentas = new List<Cuenta>();

        public DataSet dtSet = null;
        public PlanCuentas()
        {
            InitializeComponent();
        }
        
        private void InicializacionBasica()
        {
            ClearNodes();

            for (int i = 1; i <= 8; i++)
            {
                var result = cn.ConsultaCuentas(i);

                if (result.Item2 == null)
                {
                    dtSet = result.Item1;

                    switch (i)
                    {
                        case 1:
                            cn.CreateFatherAccount("0", null, dtSet, treeViewActivos);
                            break;

                        case 2:
                            cn.CreateFatherAccount("0", null, dtSet, treeViewPasivos);
                            break;

                        case 3:
                            cn.CreateFatherAccount("0", null, dtSet, treeViewPatrimonio);
                            break;

                        case 4:
                            cn.CreateFatherAccount("0", null, dtSet, treeViewIngresos);
                            break;

                        case 5:
                            cn.CreateFatherAccount("0", null, dtSet, treeViewGastos);
                            break;

                        case 6:
                            cn.CreateFatherAccount("0", null, dtSet, treeViewGastosOperacionales);
                            break;

                        case 7:
                            cn.CreateFatherAccount("0", null, dtSet, treeViewOtrosIngresos);
                            break;

                        case 8:
                            cn.CreateFatherAccount("0", null, dtSet, treeViewOtrosGastos);
                            break;

                    }

                    dtSet.Clear();
                }
                else
                {
                    EstableceLogin.GetMenuStatusBar().ShowStatusMessage("Error: " + result.Item2, Brushes.Red, Brushes.White, "003-interface-2.png");
                }

            }

        }

        public void LoadedWindow()
        {
            InicializacionBasica();
        }

        private void comboBox_LostFocus(object sender, RoutedEventArgs e)
        {
            App.comboBox_LostFocus(sender, e);
        }

        private void comboBox_GotFocus(object sender, RoutedEventArgs e)
        {
            App.comboBox_GotFocus(sender, e);
        }

        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            App.textBox_LostFocus(sender, e);
        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            App.textBox_GotFocus(sender, e);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            InicializacionBasica();

            var result = cn.ConsultaMonedas();

            if (result.Item2 == null)
            {              
                cbMoneda.ItemsSource = result.Item1;
            }
            else
            {
                EstableceLogin.GetMenuStatusBar().ShowStatusMessage("Error: " + result.Item2, Brushes.Red, Brushes.White, "003-interface-2.png");
            }

            App.Window_Closing(sender, e);
        }

        private void btnWindow_Close(object sender, RoutedEventArgs e)
        {
            InicializacionBasica();

            var result = cn.ConsultaMonedas();

            if (result.Item2 == null)
            {
                cbMoneda.ItemsSource = result.Item1;
            }
            else
            {
                EstableceLogin.GetMenuStatusBar().ShowStatusMessage("Error: " + result.Item2, Brushes.Red, Brushes.White, "003-interface-2.png");
            }

            this.Hide();
        }

        private void treeViewActivos_Selected(object sender, RoutedEventArgs e)
        {
            if (btnOk.Content.ToString() == "OK")
            {                           
                TreeViewItem item = treeViewActivos.SelectedItem as TreeViewItem;

                SelectedAccount(item);
            }
        }

        private void GetAccount(List<Cuenta> listaCuenta)
        {
            foreach (Cuenta cuenta in listaCuenta)
            {
                txtCuenta.Text = cuenta.AcctCode;
                txtNombre.Text= cuenta.AcctName;
                txtNivel.Text = cuenta.Levels.ToString();
                cbMoneda.SelectedValue = cuenta.ActCurr.ToString();
                cbxCuentaAsociada.IsChecked = cn.CuentaAsociada(cuenta.LocManTran);
                txtSaldo.Text = cuenta.CurrTotal.ToString();
                cbClaseCuenta.SelectedValue= cn.TipoCuenta(cuenta.ActType);
                rbCuentaActiva.IsChecked = cn.CuentaActivo(cuenta.Postable);
                rbTitulo.IsChecked = cn.CuentaTitulo(cuenta.Postable);

                VerificaCuenta(rbTitulo.IsChecked);               
              
                //cuenta.FcTotal = Convert.ToDecimal(reader["FcTotal"]);
                //cuenta.Finanse = Convert.ToChar(reader["Finanse"].ToString());   
               // cuenta.GroupMask = cuenta.GroupMask.ToString();                
                //cuenta.FatherNum = reader["FatherNum"].ToString();

            }
        }

        private void VerificaCuenta(bool? isChecked)
        {
            if (isChecked == true)
            {

                cbxCuentaAsociada.IsEnabled = true;

                txtCuenta.Background = Brushes.White;

                txtCuenta.IsReadOnly = false;

                txtNombre.Background = Brushes.White;

                txtNombre.IsReadOnly = false;

                rbTitulo.IsEnabled = false;

                rbCuentaActiva.IsEnabled = false;

                cbMoneda.IsEnabled = false;

                cbMoneda.Background = Brushes.LightGray;

                txtSaldo.Visibility = Visibility.Hidden;

                cbCodeMoneda.Visibility = Visibility.Hidden;

                lblSaldo.Visibility = Visibility.Hidden;

                lblPropiedad.Visibility = Visibility.Hidden;

                lblClaseCuenta.Visibility = Visibility.Hidden;

                cbClaseCuenta.Visibility = Visibility.Hidden;

                cbxCuentaAsociada.Visibility = Visibility.Hidden;
            }
            else
            {

                cbxCuentaAsociada.IsEnabled = true;

                txtCuenta.Background = Brushes.White;

                txtCuenta.IsReadOnly = false;

                txtNombre.Background = Brushes.White;

                txtNombre.IsReadOnly = false;

                cbxCuentaAsociada.IsEnabled = true;

                rbTitulo.IsEnabled = true;

                rbCuentaActiva.IsEnabled = true;

                cbMoneda.IsEnabled = true;

                cbMoneda.Background = Brushes.White;

                txtSaldo.Visibility = Visibility.Visible;

                cbCodeMoneda.Visibility = Visibility.Visible;

                lblSaldo.Visibility = Visibility.Visible;

                lblPropiedad.Visibility = Visibility.Visible;

                lblClaseCuenta.Visibility = Visibility.Visible;

                cbClaseCuenta.Visibility = Visibility.Visible;

                cbxCuentaAsociada.Visibility = Visibility.Visible;
            }
        }

        public class ListTipoCuenta : List<string>
        {
            public ListTipoCuenta()
            {
                this.Add("Otros");
                this.Add("Ingresos");
                this.Add("Gastos");

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DisableAccount();

            InicializacionBasica();

            var result = cn.ConsultaMonedas();

            if (result.Item2 == null)
            {
                cbMoneda.ItemsSource = result.Item1;
            }
            else
            {
                EstableceLogin.GetMenuStatusBar().ShowStatusMessage("Error: " + result.Item2, Brushes.Red, Brushes.White, "003-interface-2.png");
            }

            TipoCuenta = new ObservableCollection<string>() { "Otros", "Ingresos", "Gastos" };

            cbClaseCuenta.ItemsSource =TipoCuenta;
        }

        private void DisableAccount()
        {
            rbTitulo.IsEnabled = false;

            rbCuentaActiva.IsEnabled = false;

            cbMoneda.IsEnabled = false;

            txtCuenta.Background = Brushes.LightGray;

            txtCuenta.IsReadOnly = true;

            txtNombre.Background = Brushes.LightGray;

            txtNombre.IsReadOnly = true;

            cbMoneda.Background = Brushes.LightGray;

            cbMoneda.IsReadOnly = true;

            cbCodeMoneda.Background = Brushes.LightGray;

            cbCodeMoneda.IsReadOnly = true;

            cbClaseCuenta.Background=Brushes.LightGray;

            cbClaseCuenta.IsReadOnly = true;

            cbxCuentaAsociada.IsEnabled = false;


        }

        private void treeViewPasivos_Selected(object sender, RoutedEventArgs e)
        {
           
            if (btnOk.Content.ToString() == "OK")
            {
                TreeViewItem item = treeViewPasivos.SelectedItem as TreeViewItem;

                SelectedAccount(item);
            }
        }

        private void treeViewPatrimonio_Selected(object sender, RoutedEventArgs e)
        {
            if (btnOk.Content.ToString() == "OK")
            {
                TreeViewItem item = treeViewPatrimonio.SelectedItem as TreeViewItem;

                SelectedAccount(item);
            }
        }

        private void treeViewIngresos_Selected(object sender, RoutedEventArgs e)
        {
            if (btnOk.Content.ToString() == "OK")
            {
                TreeViewItem item = treeViewIngresos.SelectedItem as TreeViewItem;

                SelectedAccount(item);
            }
        }

        private void treeViewGastos_Selected(object sender, RoutedEventArgs e)
        {
            if (btnOk.Content.ToString() == "OK")
            {
                TreeViewItem item = treeViewGastos.SelectedItem as TreeViewItem;

                SelectedAccount(item);
            }
        }

        private void treeViewGastosOperacionales_Selected(object sender, RoutedEventArgs e)
        {
            if (btnOk.Content.ToString() == "OK")
            {
                TreeViewItem item = treeViewGastosOperacionales.SelectedItem as TreeViewItem;

                SelectedAccount(item);
            }
        }

        private void treeViewOtrosIngresos_Selected(object sender, RoutedEventArgs e)
        {
            if (btnOk.Content.ToString() == "OK")
            {
                TreeViewItem item = treeViewOtrosIngresos.SelectedItem as TreeViewItem;

                SelectedAccount(item);
            }
        }

        private void treeViewOtrosGastos_Selected(object sender, RoutedEventArgs e)
        {
            if (btnOk.Content.ToString() == "OK")
            {
                TreeViewItem item = treeViewOtrosGastos.SelectedItem as TreeViewItem;

                SelectedAccount(item);

            }
        }

        private void SelectedAccount(TreeViewItem item)
        {
            listaCuentas.Clear();

            string account = item.Tag.ToString();

            var result= cn.FindCuenta(account);

            if (result.Item2 == null)
            {
                listaCuentas = result.Item1;

                GetAccount(listaCuentas);

                item.IsSelected = false;
            }
            else
            {
                EstableceLogin.GetMenuStatusBar().ShowStatusMessage("Error: " + result.Item2, Brushes.Red, Brushes.White, "003-interface-2.png");
            }

        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            List<Cuenta> listaCuenta = new List<Cuenta>();

            Cuenta cuenta = new Cuenta();

            switch (btnOk.Content.ToString())
            {
                case "OK":

                    InicializacionBasica();

                    this.Hide();

                    break;

                case "Actualizar":

                    cuenta.AcctCode = txtCuenta.Text;
                    cuenta.AcctName = txtNombre.Text;
                    cuenta.ActCurr = cbMoneda.SelectedValue.ToString();
                    cuenta.LocManTran = cn.CuentaAsociada(cbxCuentaAsociada.IsChecked);
                    cuenta.UserSign = Properties.Settings.Default.Usuario;
                    cuenta.ActType = cn.TipoCuenta(cbClaseCuenta.Text.ToString());
                    cuenta.CreateDate = fechaActual.GetFechaActual();

                    listaCuenta.Add(cuenta);

                    var result = cn.UpdateAccount(listaCuenta);

                    if (result.Item1 == 1)
                    {
                        EstableceLogin.GetMenuStatusBar().ShowStatusMessage("Cuenta " + cuenta.AcctCode + " se actualizo correctamente", Brushes.LightGreen, Brushes.Black, "001-interface.png");
                        
                        btnOk.Content = "OK";
                    }
                    else
                    {
                        EstableceLogin.GetMenuStatusBar().ShowStatusMessage("Error en la actualizacion de la cuenta " + cuenta.AcctCode + " " + result.Item2, Brushes.Red, Brushes.Black, "003-interface-2.png");
                        
                    }

                    ClearNodes();

                    InicializacionBasica();

                    break;
            }
        }

        private void ClearNodes()
        {
            treeViewActivos.Items.Clear();

            treeViewPasivos.Items.Clear();

            treeViewPatrimonio.Items.Clear();

            treeViewIngresos.Items.Clear();

            treeViewGastos.Items.Clear();

            treeViewGastosOperacionales.Items.Clear();

            treeViewOtrosGastos.Items.Clear();

            treeViewOtrosIngresos.Items.Clear();
        }

        private void rbTitulo_Click(object sender, RoutedEventArgs e)
        {
            btnOk.Content = "Actualizar";
        }

        private void txtCuenta_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            btnOk.Content = "Actualizar";
        }

        private void cbMoneda_DropDownOpened(object sender, EventArgs e)
        {
            btnOk.Content = "Actualizar";
        }

        private void cbxCuentaAsociada_Click(object sender, RoutedEventArgs e)
        {
            btnOk.Content = "Actualizar";
        }
    }
}
