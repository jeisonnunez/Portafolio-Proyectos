using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vista.Clases_Basicas;

namespace Vista.Gestion.ModelRetencionImpuestos
{
    public class ModelRetencionImpuestos: INotifyPropertyChangeObservable
    {
        public string Error { get { return null; } }

        public int UserSign { get => userSign; set => userSign = value; }

        private string oldWtCode;

        private string wt_Code;

        private string wt_Name;

        private string rate;

        private string effecDate;

        private bool category;

        private bool baseType;

        private string prctBsAmnt;

        private string account;

        private string offclCode;

        private int userSign;

        private bool inactive;

        private string tipoRetencion;

        private string baseMinima;

        private string sustraendo;

        public string Wt_Code
        {
            get
            {
                return wt_Code;
            }

            set
            {
                if (value != wt_Code)
                {
                    wt_Code = value;
                    //notify the binding that my value has been changed
                    OnPropertyChanged("Wt_Code");
                }
            }
        }

        public string TipoRetencion
        {
            get
            {
                return tipoRetencion;
            }

            set
            {
                if (value != tipoRetencion)
                {
                    wt_Code = value;
                    //notify the binding that my value has been changed
                    OnPropertyChanged("TipoRetencion");
                }
            }
        }

        public string Sustraendo
        {
            get
            {
                return sustraendo;
            }

            set
            {
                if (value != sustraendo)
                {
                    sustraendo = value;
                    //notify the binding that my value has been changed
                    OnPropertyChanged("Sustraendo");
                }
            }
        }

        public string BaseMinima
        {
            get
            {
                return baseMinima;
            }

            set
            {
                if (value != baseMinima)
                {
                    baseMinima = value;
                    //notify the binding that my value has been changed
                    OnPropertyChanged("BaseMinima");
                }
            }
        }

        public string Account
        {
            get
            {
                return account;
            }

            set
            {
                if (value != account)
                {
                    account = value;
                    //notify the binding that my value has been changed
                    OnPropertyChanged("Account");
                }
            }
        }

        public string OffclCode
        {
            get
            {
                return offclCode;
            }

            set
            {
                if (value != offclCode)
                {
                    offclCode = value;
                    //notify the binding that my value has been changed
                    OnPropertyChanged("OffclCode");
                }
            }
        }

        public string PrctBsAmnt
        {
            get
            {
                return prctBsAmnt;
            }

            set
            {
                if (value != prctBsAmnt)
                {
                    prctBsAmnt = value;
                    //notify the binding that my value has been changed
                    OnPropertyChanged("PrctBsAmnt");
                }
            }
        }

        public bool Category
        {
            get
            {
                return category;
            }

            set
            {
                if (value != category)
                {
                    category = value;
                    //notify the binding that my value has been changed
                    OnPropertyChanged("Category");
                }
            }
        }

        public bool Inactive
        {
            get
            {
                return inactive;
            }

            set
            {
                if (value != inactive)
                {
                    inactive = value;
                    //notify the binding that my value has been changed
                    OnPropertyChanged("Inactive");
                }
            }
        }

        public bool BaseType
        {
            get
            {
                return baseType;
            }

            set
            {
                if (value != baseType)
                {
                    baseType = value;
                    //notify the binding that my value has been changed
                    OnPropertyChanged("BaseType");
                }
            }
        }

        public string EffecDate
        {
            get
            {
                return effecDate;
            }

            set
            {
                if (value != effecDate)
                {
                    effecDate = value;
                    //notify the binding that my value has been changed
                    OnPropertyChanged("EffecDate");
                }
            }
        }

        public string Rate
        {
            get
            {
                return rate;
            }

            set
            {
                if (value != rate)
                {
                    rate = value;
                    //notify the binding that my value has been changed
                    OnPropertyChanged("Rate");
                }
            }
        }

        public string Wt_Name
        {
            get
            {
                return wt_Name;
            }

            set
            {
                if (value != wt_Name)
                {
                    wt_Name = value;
                    //notify the binding that my value has been changed
                    OnPropertyChanged("Wt_Name");
                }
            }
        }

        public string OldWtCode { get => oldWtCode; set => oldWtCode = value; }
    }
}
