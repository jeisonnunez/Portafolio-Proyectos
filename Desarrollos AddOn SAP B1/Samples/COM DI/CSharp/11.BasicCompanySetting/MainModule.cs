using System.Diagnostics;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace FormWindowTemplateVb
{
	sealed class MainModule
	{
		
		public static SAPbobsCOM.Company oCompany = new SAPbobsCOM.Company();
		public static SAPbobsCOM.CompanyService oCmpSrv;
		
		static public void Main ()
		{
			
			StartupForm frm = new StartupForm();
			
			frm.ShowDialog();
			
		}
		
		
		
	}
	
}
