using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos 
{
    public class ModeloPagoEfectuado : ModeloDocumento
    {
        public Tuple <int,string, string> FindPaymentMadeLines(int docEntry)
        {
            int docNum = 0;

            string transType = null;

            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    using (SqlCommand cmd = Connection.CreateCommand())
                    {
                        cmd.CommandText = "FindPaymentMadeLines";

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@DocEntry", docEntry);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            docNum =Convert.ToInt32(reader["DocNum"]);

                            transType = reader["InvType"].ToString();

                        }

                        reader.Close();
                    }

                }

                Connection.Close();

                return Tuple.Create(docNum, transType, error);

            }
            catch (Exception e)
            {

                Connection.Close();

                return Tuple.Create(docNum, transType, e.Message);

            }
        }

       
        public Tuple<List<Payment>,string> FindLastPaymentMade()
        {
            List<Payment> newListPayment = new List<Payment>();

            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    using (SqlCommand cmd = Connection.CreateCommand())
                    {
                        cmd.CommandText = "LastPaymentMade";

                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Payment newPayment = new Payment();

                            newPayment.DocEntry = Convert.ToInt32(reader["DocEntry"]);
                            newPayment.DocNum = Convert.ToInt32(reader["DocNum"]);
                            newPayment.CardCode = reader["CardCode"].ToString();
                            newPayment.CardName = reader["CardName"].ToString();
                            newPayment.DocType = Convert.ToChar(reader["DocType"]);
                            newPayment.CashAcct = reader["CashAcct"].ToString();
                            newPayment.CashSum = Convert.ToDecimal(reader["CashSum"]);
                            newPayment.CashSumFC = Convert.ToDecimal(reader["CashSumFC"]);
                            newPayment.CashSumSy = Convert.ToDecimal(reader["CashSumSy"]);
                            newPayment.DocDate = Convert.ToDateTime(reader["DocDate"]);
                            newPayment.TaxDate = Convert.ToDateTime(reader["TaxDate"]);
                            newPayment.DocDueDate = Convert.ToDateTime(reader["DocDueDate"]);
                            newPayment.Address = reader["Address"].ToString();
                            newPayment.TrsfrAcct = reader["TrsfrAcct"].ToString();
                            newPayment.TrsfrSum = Convert.ToDecimal(reader["TrsfrSum"]);
                            newPayment.TrsfrSumFC = Convert.ToDecimal(reader["TrsfrSumFC"]);
                            newPayment.TrsfrSumSy = Convert.ToDecimal(reader["TrsfrSumSy"]);
                            newPayment.TrsfrDate = Convert.ToDateTime(reader["TrsfrDate"]);
                            newPayment.TrsfrRef = reader["TrsfrRef"].ToString();
                            newPayment.PayNoDoc = Convert.ToChar(reader["PayNoDoc"]);
                            newPayment.NoDocSum = Convert.ToDecimal(reader["NoDocSum"]);
                            newPayment.NoDocSumSy = Convert.ToDecimal(reader["NoDocSumSy"]);
                            newPayment.NoDocSumFC = Convert.ToDecimal(reader["NoDocSumFC"]);
                            newPayment.DocTotal = Convert.ToDecimal(reader["DocTotal"]);
                            newPayment.DocTotalFC = Convert.ToDecimal(reader["DocTotalFC"]);
                            newPayment.DocTotalSy = Convert.ToDecimal(reader["DocTotalSy"]);
                            newPayment.JrnlMemo = reader["JrnlMemo"].ToString();
                            newPayment.TransId = Convert.ToInt32(reader["TransId"]);
                            newPayment.CounterRef = reader["CounterRef"].ToString();
                            newPayment.BpAct = reader["BpAct"].ToString();
                            newPayment.DocCurr = reader["DocCurr"].ToString();

                            newListPayment.Add(newPayment);

                        }

                        reader.Close();
                    }

                }

                Connection.Close();

                return Tuple.Create(newListPayment, error);

            }
            catch (Exception e)
            {

                Connection.Close();

                return Tuple.Create(newListPayment, e.Message);
            }
        }

       
        public Tuple <DataTable,string> FindPurchaseInvoiceSupplierSpecific(int docEntry, string transType=null)
        {
            DataTable tabla = new DataTable();

            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    using (SqlCommand cmd = Connection.CreateCommand())
                    {
                        cmd.CommandText = "FindPurchaseInvoiceSupplierSpecific";

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@DocEntry", docEntry);

                        if (String.IsNullOrWhiteSpace(transType) == false)
                        {
                            cmd.Parameters.AddWithValue("@TransType", transType);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@TransType", DBNull.Value);
                        }

                        data = new SqlDataAdapter(cmd);

                        data.Fill(tabla);

                    }

                }

                Connection.Close();

                return Tuple.Create(tabla, error);

            }
            catch (Exception e)
            {
                Connection.Close();

                return Tuple.Create(tabla, e.Message);
            }
        }

        public Tuple<int, string> InsertPaymentMadeLinesPreliminar(List<PaymentDetails> listPayment)
        {
            //LoadDatatable INV1_TEST

            dtVPM2 = dataSet.Tables["VPM2_TEST"];

            int flag = 0;

            string error = null;

            int DocEntry = 0;

            try
            {
                foreach (PaymentDetails PaymentDatails in listPayment)
                {
                    DocEntry = PaymentDatails.DocEntry;

                    DataRow newRow = dtVPM2.NewRow();

                    newRow["DocEntry"] = PaymentDatails.DocEntry;
                    newRow["DocNum"] = PaymentDatails.DocNum;
                    newRow["InvoiceId"] = PaymentDatails.InvoiceId;
                    newRow["SumApplied"] = PaymentDatails.SumApplied;
                    newRow["AppliedFC"] = PaymentDatails.AppliedFC;
                    newRow["AppliedSys"] = PaymentDatails.AppliedSys;
                    newRow["VatApplied"] = PaymentDatails.VatApplied;
                    newRow["VatAppldFC"] = PaymentDatails.VatAppldFC;
                    newRow["VatAppldSy"] = PaymentDatails.VatAppldSy;
                    newRow["WtInvCatS"] = PaymentDatails.WtInvCatS;
                    newRow["WtInvCatSF"] = PaymentDatails.WtInvCatSF;
                    newRow["WtInvCatSS"] = PaymentDatails.WtInvCatSS;
                    newRow["InvType"] = PaymentDatails.InvType;
                    newRow["ObjType"] = PaymentDatails.ObjType;
                    newRow["DocSubType"] = PaymentDatails.DocSubType;
                    newRow["DocTransId"] = PaymentDatails.DocTransId;
                    newRow["DocRate"] = PaymentDatails.DocRate;
                    newRow["U_IDA_CompIVA"] = PaymentDatails.U_IDA_CompIVA;
                    newRow["U_IDA_MontoCompIVA"] = PaymentDatails.U_IDA_MontoCompIVA;
                    newRow["U_IDA_CompISLR"] = PaymentDatails.U_IDA_CompISLR;
                    newRow["U_IDA_FechaComp"] = PaymentDatails.U_IDA_FechaComp;
                    newRow["U_IDA_DateCompISLR"] = PaymentDatails.U_IDA_DateCompISLR;

                    dtVPM2.Rows.Add(newRow);

                    dtVPM2.AcceptChanges();
                }

                DataRow[] selected = dtVPM2.Select("DocEntry = " + DocEntry);

                flag = selected.Count();

                return Tuple.Create(flag, error);

            }
            catch (Exception e)
            {
                return Tuple.Create(flag, e.Message);
            }
        }

        

       

        public Tuple<DataTable, string> GetRetencionImpuesto(int docEntry, string objType)
        {
            DataTable tabla = new DataTable();

            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    using (SqlCommand cmd = Connection.CreateCommand())
                    {
                        cmd.CommandText = "GetRetencionImpuestoOPCH";

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@DocEntry", docEntry);

                        cmd.Parameters.AddWithValue("@ObjType", objType);

                        data = new SqlDataAdapter(cmd);

                        data.Fill(tabla);

                    }

                }

                Connection.Close();

                return Tuple.Create(tabla, error);

            }
            catch (Exception e)
            {
                Connection.Close();

                return Tuple.Create(tabla, e.Message);
            }
        }

        public Tuple<int, string> FindDocEntry(int docNum)
        {
            int DocEntry = 0;

            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    using (SqlCommand cmd = Connection.CreateCommand())
                    {
                        cmd.CommandText = "FindDocEntryOVPM";

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@DocNum", docNum);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            DocEntry = Convert.ToInt32(reader["DocEntry"]);

                        }

                        reader.Close();
                    }

                }

                Connection.Close();

                return Tuple.Create(DocEntry, error);

            }
            catch (Exception e)
            {

                Connection.Close();

                return Tuple.Create(DocEntry, e.Message);

            }
        }

        public Tuple<int, string> FindDocEntryPreliminar(object docNum)
        {
            int DocEntry = 0;

            string error = null;

            try
            {

                DataRow dataRow = dtOVPM.AsEnumerable().Where(r => ((int)r["DocNum"]).Equals(docNum)).First();

                DocEntry = Convert.ToInt32(dataRow["DocEntry"]);

                return Tuple.Create(DocEntry, error);

            }
            catch (Exception e)
            {

                return Tuple.Create(DocEntry, e.Message);

            }
        }

        public Tuple<List<DocumentoCabecera>, string> FindPurchaseInvoiceSpecificPreliminar(int docNum)
        {
            List<DocumentoCabecera> newList = new List<DocumentoCabecera>();

            string error = null;

            try
            {
                var reader = dtOPCH.AsEnumerable().Where(x => x.Field<int>("DocNum") == docNum && x.Field<string>("DocSubType") == "--").First();

                DocumentoCabecera newItem = new DocumentoCabecera();

                newItem.DocEntry = Convert.ToInt32(reader["DocEntry"]);
                newItem.DocNum = Convert.ToInt32(reader["DocNum"]);
                newItem.CardCode = reader["CardCode"].ToString();
                newItem.CardName = reader["CardName"].ToString();
                newItem.NumAtCard = reader["NumAtCard"].ToString();
                newItem.DocStatus = Convert.ToChar(reader["DocStatus"]);
                newItem.NumControl = reader["U_IDA_NumControl"].ToString();
                newItem.DocCurr = reader["DocCur"].ToString();
                newItem.TipoTrans = reader["U_IDA_TipoTrans"].ToString();
                newItem.DocDate = Convert.ToDateTime(reader["DocDate"]);
                newItem.TaxDate = Convert.ToDateTime(reader["TaxDate"]);
                newItem.DocDueDate = Convert.ToDateTime(reader["DocDueDate"]);
                newItem.Address2 = reader["Address"].ToString();
                newItem.Comments = reader["Comments"].ToString();
                newItem.CtlAccount = reader["CtlAccount"].ToString();
                newItem.JrnlMemo = reader["JrnlMemo"].ToString();
                newItem.LicTradNum = reader["LicTradNum"].ToString();
                newItem.DocType = Convert.ToChar(reader["DocType"]);
                newItem.DocTotal = Convert.ToDecimal(reader["DocTotal"]);
                newItem.DocTotalFC = Convert.ToDecimal(reader["DocTotalFC"]);
                newItem.DocTotalSy = Convert.ToDecimal(reader["DocTotalSy"]);
                newItem.VatSum = Convert.ToDecimal(reader["VatSum"]);
                newItem.VatSumFC = Convert.ToDecimal(reader["VatSumFC"]);
                newItem.VatSumSy1 = Convert.ToDecimal(reader["VatSumSy"]);
                newItem.WTSum = Convert.ToDecimal(reader["WTSum"]);
                newItem.WTSumFC = Convert.ToDecimal(reader["WTSumFC"]);
                newItem.WTSumSC = Convert.ToDecimal(reader["WTSumSC"]);
                newItem.BaseAmnt = Convert.ToDecimal(reader["BaseAmnt"]);
                newItem.BaseAmntFC = Convert.ToDecimal(reader["BaseAmntFC"]);
                newItem.BaseAmntSC = Convert.ToDecimal(reader["BaseAmntFC"]);
                newItem.DocRate = Convert.ToDecimal(reader["DocRate"]);
                newItem.SysRate = Convert.ToDecimal(reader["SysRate"]);
                newItem.TransId = Convert.ToInt32(reader["TransId"]);

                newList.Add(newItem);

                return Tuple.Create(newList, error);

            }
            catch (Exception e)
            {
                return Tuple.Create(newList, e.Message);
            }
        }

        public Tuple<int, string> InsertPaymentMadePreliminar(List<Payment> payments)
        {
            //LoadDatatable OPCH_TEST

            dtOVPM = dataSet.Tables["OVPM_TEST"];

            int flag = 0;

            string error = null;

            try
            {
                foreach (Payment Payment in payments)
                {
                    int DocEntry = dtOVPM.Rows.Count;

                    DataRow newRow = dtOVPM.NewRow();

                    newRow["DocNum"] = Payment.DocNum;
                    newRow["DocDate"] = Payment.DocDate;
                    newRow["TaxDate"] = Payment.TaxDate;
                    newRow["DocDueDate"] = Payment.DocDueDate;
                    newRow["Comments"] = Payment.Comments;
                    newRow["DocType"] = Payment.DocType;
                    newRow["CANCELED"] = Payment.Canceled;
                    newRow["UserSign"] = Payment.UserSign;
                    newRow["UpdateDate"] = Payment.UpdateDate;
                    newRow["FinncPriod"] = Payment.FinncPriod;
                    newRow["Address"] = Payment.Address;
                    newRow["DocCurr"] = Payment.DocCurr;
                    newRow["ObjType"] = Payment.ObjType;
                    newRow["CardCode"] = Payment.CardCode;
                    newRow["CardName"] = Payment.CardName;
                    newRow["JrnlMemo"] = Payment.JrnlMemo;
                    newRow["TransId"] = Payment.TransId;
                    newRow["SysRate"] = Payment.SysRate;
                    newRow["DocRate"] = Payment.DocRate;
                    newRow["BpAct"] = Payment.BpAct;
                    newRow["DocTotal"] = Payment.DocTotal;
                    newRow["DocTotalFC"] = Payment.DocTotalFC;
                    newRow["DocTotalSy"] = Payment.DocTotalSy;
                    newRow["CashAcct"] = Payment.CashAcct;
                    newRow["TrsfrAcct"] = Payment.TrsfrAcct;
                    newRow["TrsfrDate"] = Payment.TrsfrDate;
                    newRow["TrsfrSumFC"] = Payment.TrsfrSumFC;
                    newRow["CashSumFC"] = Payment.CashSumFC;
                    newRow["CashSumSy"] = Payment.CashSumSy;
                    newRow["TrsfrSum"] = Payment.TrsfrSum;
                    newRow["TrsfrSumFC"] = Payment.TrsfrSumFC;
                    newRow["TrsfrSumSy"] = Payment.TrsfrSumSy;
                    newRow["CheckAcct"] = Payment.CheckAcct;
                    newRow["CheckSum"] = Payment.CheckSum;
                    newRow["CheckSumFC"] = Payment.CheckSumFC;
                    newRow["CheckSumSy"] = Payment.CheckSumSy;
                    newRow["PayNoDoc"] = Payment.PayNoDoc;
                    newRow["NoDocSum"] = Payment.NoDocSum;
                    newRow["NoDocSumFC"] = Payment.NoDocSumFC;
                    newRow["NoDocSumSy"] = Payment.NoDocSumSy;
                    newRow["CounterRef"] = Payment.CounterRef;

                    dtOVPM.Rows.Add(newRow);

                    if (dtOVPM.Rows.Count == DocEntry + 1)
                    {
                        flag = 1;
                    }
                    else
                    {
                        flag = 0;
                    }

                    dtOVPM.AcceptChanges();
                }

                return Tuple.Create(flag, error);

            }
            catch (Exception e)
            {

                return Tuple.Create(flag, e.Message);
            }
        }

        public Tuple<string, string> GetDocumentAccountPreliminar(int docNum, bool v)
        {
            string BpAct = null;

            string error = null;

            try
            {
                if (v == true)
                {
                    dtOPCH = dataSet.Tables["OPCH_TEST"];
                }
               
                DataRow dataRow = dtOPCH.AsEnumerable().Where(r => ((int)r["DocNum"]).Equals(docNum)).First();

                BpAct = dataRow["CtlAccount"].ToString();

                return Tuple.Create(BpAct, error);

            }
            catch (Exception e)
            {

                return Tuple.Create(BpAct, e.Message);

            }
        }

        public string CreateDataSetPreliminarPaymentMade()
        {
            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    dataSet = new DataSet("dsOINV");

                    data = new SqlDataAdapter("SELECT * FROM dbo.OJDT", Connection);

                    data.FillSchema(dataSet, SchemaType.Source, "OJDT_TEST");

                    data.Fill(dataSet, "OJDT_TEST");

                    data = new SqlDataAdapter("SELECT * FROM dbo.JDT1", Connection);

                    data.FillSchema(dataSet, SchemaType.Source, "JDT1_TEST");

                    data.Fill(dataSet, "JDT1_TEST");

                    data = new SqlDataAdapter("SELECT * FROM dbo.OVPM", Connection);

                    data.FillSchema(dataSet, SchemaType.Source, "OVPM_TEST");

                    data.Fill(dataSet, "OVPM_TEST");

                    data = new SqlDataAdapter("SELECT * FROM dbo.VPM2", Connection);

                    data.FillSchema(dataSet, SchemaType.Source, "VPM2_TEST");

                    data.Fill(dataSet, "VPM2_TEST");

                    data = new SqlDataAdapter("SELECT * FROM dbo.OPCH", Connection);

                    data.FillSchema(dataSet, SchemaType.Source, "OPCH_TEST");

                    data.Fill(dataSet, "OPCH_TEST");

                    data = new SqlDataAdapter("SELECT * FROM dbo.PCH1", Connection);

                    data.FillSchema(dataSet, SchemaType.Source, "PCH1_TEST");

                    data.Fill(dataSet, "PCH1_TEST");

                    data = new SqlDataAdapter("SELECT * FROM dbo.PCH5", Connection);

                    data.FillSchema(dataSet, SchemaType.Source, "PCH5_TEST");

                    data.Fill(dataSet, "PCH5_TEST");

                    CreateConstraintPurchaseInvoiceTAX("OPCH_TEST", "PCH5_TEST");

                    CreateDataRelationPurchaseInvoiceTAX("OPCH_TEST", "PCH5_TEST");

                    CreateConstraintPurchaseInvoice("OPCH_TEST", "PCH1_TEST");

                    CreateDataRelationPurchaseInvoice("OPCH_TEST", "PCH1_TEST");

                    CreateConstraintJournalEntry("OJDT_TEST", "JDT1_TEST");

                    CreateDataRelationJournalEntry("OJDT_TEST", "JDT1_TEST");

                    CreateConstraintPaymentMade("OVPM_TEST", "VPM2_TEST");

                    CreateDataRelationPaymentMade("OVPM_TEST", "VPM2_TEST");

                    dataSet.AcceptChanges();

                }

                Connection.Close();

                return error;

            }
            catch (Exception e)
            {

                Connection.Close();

                return e.Message;
            }
        }

        private void CreateDataRelationPaymentMade(string v1, string v2)
        {
            // Get the DataColumn objects from two DataTable objects
            // in a DataSet. Code to get the DataSet not shown here.
            DataColumn parentColumn = dataSet
                .Tables[v1].Columns["DocEntry"];
            DataColumn childColumn =
                dataSet.Tables[v2].Columns["DocEntry"];
            // Create DataRelation.
            DataRelation relCustOrder;
            relCustOrder = new DataRelation("PaymentMade",
                parentColumn, childColumn);
            // Add the relation to the DataSet.
            dataSet.Relations.Add(relCustOrder);
        }

        private void CreateConstraintPaymentMade(string v1, string v2)
        {
            // Declare parent column and child column variables.
            DataColumn parentColumn;
            DataColumn childColumn;
            ForeignKeyConstraint foreignKeyConstraint;

            // Set parent and child column variables.
            parentColumn = dataSet.Tables[v1].Columns["DocEntry"];
            childColumn = dataSet.Tables[v2].Columns["DocEntry"];
            foreignKeyConstraint = new ForeignKeyConstraint
               ("PaymentMadeConstraint", parentColumn, childColumn);

            // Set null values when a value is deleted.
            foreignKeyConstraint.DeleteRule = Rule.None;
            foreignKeyConstraint.UpdateRule = Rule.Cascade;
            foreignKeyConstraint.AcceptRejectRule = AcceptRejectRule.None;


            // Add the constraint, and set EnforceConstraints to true.
            dataSet.Tables[v2].Constraints.Add(foreignKeyConstraint);
            dataSet.EnforceConstraints = true;
        }

        public Tuple<int, string> UpdatePaymentMade(List<Payment> listaPayment)
        {
            string error = null;

            int flag = 0;


            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    foreach (Payment payment in listaPayment)
                    {
                        using (SqlCommand cmd = Connection.CreateCommand())
                        {
                            cmd.CommandText = "UpdatePaymentMade";

                            cmd.CommandType = CommandType.StoredProcedure;


                            cmd.Parameters.AddWithValue("@DocEntry", payment.DocEntry);
                            cmd.Parameters.AddWithValue("@DocDate", payment.DocDate);
                            cmd.Parameters.AddWithValue("@TaxDate", payment.TaxDate);
                            cmd.Parameters.AddWithValue("@DocDueDate", payment.DocDueDate);
                            cmd.Parameters.AddWithValue("@CardCode", payment.CardCode);
                            cmd.Parameters.AddWithValue("@CardName", payment.CardName);
                            cmd.Parameters.AddWithValue("@Address", payment.Address);
                            cmd.Parameters.AddWithValue("@CounterRef", payment.CounterRef);
                            cmd.Parameters.AddWithValue("@JrnlMemo", payment.JrnlMemo);
                          
                            flag = cmd.ExecuteNonQuery();

                        }
                    }

                }

                Connection.Close();

                return Tuple.Create(flag,error);

            }
            catch (Exception e)
            {

                Connection.Close();

                return Tuple.Create(flag,e.Message);
            }
        }

        public Tuple<int, string> UpdatePaymentMadePurchase(PaymentDetails paymentDetails)
        {
            int flag = 0;

            int i = 0;

            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    
                        using (SqlCommand cmd = Connection.CreateCommand())
                        {
                            cmd.CommandText = "UpdatePaymentMadePurchase";

                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@DocEntry", paymentDetails.DocEntry);
                            cmd.Parameters.AddWithValue("@PaidToDate", paymentDetails.SumApplied);
                            cmd.Parameters.AddWithValue("@PaidFC", paymentDetails.AppliedFC);
                            cmd.Parameters.AddWithValue("@PaidSys", paymentDetails.AppliedSys);
                            cmd.Parameters.AddWithValue("@PaidSum", paymentDetails.SumApplied);
                            cmd.Parameters.AddWithValue("@PaidSumFc", paymentDetails.AppliedFC);
                            cmd.Parameters.AddWithValue("@PaidSumSc", paymentDetails.AppliedSys);

                            flag = cmd.ExecuteNonQuery();

                            i = i + flag;

                        }                  
                }

                Connection.Close();

                return Tuple.Create(i, error);

            }
            catch (Exception e)
            {

                Connection.Close();

                return Tuple.Create(i, e.Message);
            }
            finally
            {
                Connection.Close();
            }
        }

        public Tuple<int, string> DeletePaymentMade(int docNum)
        {
            int flag = 0;

            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                   
                        using (SqlCommand cmd = Connection.CreateCommand())
                        {
                            cmd.CommandText = "DeletePaymentMade";

                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@DocNum", docNum);
                           
                            flag = cmd.ExecuteNonQuery();

                        }
                   

                }

                Connection.Close();

                return Tuple.Create(flag, error);

            }
            catch (Exception e)
            {

                Connection.Close();

                return Tuple.Create(flag, e.Message);
            }
        }

        public Tuple<int, string> InsertPaymentMadeLines(List<PaymentDetails> listPaymentDetails)
        {
            int flag = 0;

            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    foreach (PaymentDetails paymentDetails in listPaymentDetails)
                    {
                        using (SqlCommand cmd = Connection.CreateCommand())
                        {
                            cmd.CommandText = "InsertPaymentMadeLines";

                            cmd.CommandType = CommandType.StoredProcedure;                          

                            cmd.Parameters.AddWithValue("@DocNum", paymentDetails.DocNum);
                            cmd.Parameters.AddWithValue("@InvoiceId", paymentDetails.InvoiceId);
                            cmd.Parameters.AddWithValue("@DocEntry", paymentDetails.DocEntry);
                            cmd.Parameters.AddWithValue("@SumApplied", paymentDetails.SumApplied);
                            cmd.Parameters.AddWithValue("@AppliedFC", paymentDetails.AppliedFC);
                            cmd.Parameters.AddWithValue("@AppliedSys", paymentDetails.AppliedSys);
                            cmd.Parameters.AddWithValue("@VatApplied", paymentDetails.VatApplied);
                            cmd.Parameters.AddWithValue("@VatAppldFC", paymentDetails.VatAppldFC);
                            cmd.Parameters.AddWithValue("@VatAppldSy", paymentDetails.VatAppldSy);
                            cmd.Parameters.AddWithValue("@WtInvCatS", paymentDetails.WtInvCatS);
                            cmd.Parameters.AddWithValue("@WtInvCatSF", paymentDetails.WtInvCatSF);
                            cmd.Parameters.AddWithValue("@WtInvCatSS", paymentDetails.WtInvCatSS);
                            cmd.Parameters.AddWithValue("@InvType", paymentDetails.InvType);
                            cmd.Parameters.AddWithValue("@ObjType", paymentDetails.ObjType);
                            cmd.Parameters.AddWithValue("@DocSubType", paymentDetails.DocSubType);
                            cmd.Parameters.AddWithValue("@DocTransId", paymentDetails.DocTransId);
                            cmd.Parameters.AddWithValue("@DocRate", paymentDetails.DocRate);
                            cmd.Parameters.AddWithValue("@U_IDA_CompIVA", paymentDetails.U_IDA_CompIVA);
                            cmd.Parameters.AddWithValue("@U_IDA_MontoCompIVA", paymentDetails.U_IDA_MontoCompIVA);
                            cmd.Parameters.AddWithValue("@U_IDA_CompISLR", paymentDetails.U_IDA_CompISLR);


                            if (String.IsNullOrWhiteSpace(paymentDetails.U_IDA_FechaComp.ToString()) == false)
                            {
                                cmd.Parameters.AddWithValue("@U_IDA_FechaComp", paymentDetails.U_IDA_FechaComp);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@U_IDA_FechaComp", DBNull.Value);
                            }

                          
                            if (String.IsNullOrWhiteSpace(paymentDetails.U_IDA_DateCompISLR.ToString()) == false)
                            {
                                cmd.Parameters.AddWithValue("@U_IDA_DateCompISLR", paymentDetails.U_IDA_DateCompISLR);
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@U_IDA_DateCompISLR", DBNull.Value);
                            }

                                                       

                            flag = cmd.ExecuteNonQuery();

                        }
                    }

                }

                Connection.Close();

                return Tuple.Create(flag, error);

            }
            catch (Exception e)
            {

                Connection.Close();

                return Tuple.Create(flag, e.Message);
            }
           
          
        }

        public Tuple<List<DocumentoCabecera>, string> FindPurchaseInvoiceSpecific(DataTable dtDocument)
        {
            List<DocumentoCabecera> newListPurchase = new List<DocumentoCabecera>();

            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    foreach (DataRow row in dtDocument.Rows)
                    {


                        using (SqlCommand cmd = Connection.CreateCommand())
                        {
                            cmd.CommandText = "FindPurchaseSpecific";

                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@DocEntry", row["DocEntry"]);

                            cmd.Parameters.AddWithValue("@TransType", row["TransType"]);

                            SqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                DocumentoCabecera newPurchase = new DocumentoCabecera();

                                newPurchase.DocEntry = Convert.ToInt32(reader["DocEntry"]);
                                newPurchase.DocNum = Convert.ToInt32(reader["DocNum"]);                                
                                newPurchase.DocCurr = reader["DocCur"].ToString();        
                                newPurchase.CtlAccount = reader["CtlAccount"].ToString();                                 
                                newPurchase.DocTotal = Convert.ToDecimal(reader["DocTotal"]);
                                newPurchase.DocTotalFC = Convert.ToDecimal(reader["DocTotalFC"]);
                                newPurchase.DocTotalSy = Convert.ToDecimal(reader["DocTotalSy"]);
                                newPurchase.VatSum = Convert.ToDecimal(reader["VatSum"]);
                                newPurchase.VatSumFC = Convert.ToDecimal(reader["VatSumFC"]);
                                newPurchase.VatSumSy1 = Convert.ToDecimal(reader["VatSumSy"]);
                                newPurchase.WTSum = Convert.ToDecimal(reader["WTSum"]);
                                newPurchase.WTSumFC = Convert.ToDecimal(reader["WTSumFC"]);
                                newPurchase.WTSumSC = Convert.ToDecimal(reader["WTSumSC"]);                               
                                newPurchase.DocRate = Convert.ToDecimal(reader["DocRate"]);
                                newPurchase.SysRate = Convert.ToDecimal(reader["SysRate"]);
                                newPurchase.TransId = Convert.ToInt32(reader["TransId"]);
                                newPurchase.ObjType = reader["ObjType"].ToString();

                                newListPurchase.Add(newPurchase);

                            }

                            reader.Close();
                        }

                    }

                }

                Connection.Close();

                return Tuple.Create(newListPurchase, error);

            }
            catch (Exception e)
            {

                Connection.Close();

                return Tuple.Create(newListPurchase, e.Message);
            }
        }

        public Tuple<int, string> InsertPaymentMade(List<Payment> listPayment)
        {
            int flag = 0;

            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    foreach (Payment Payment in listPayment)
                    {
                        using (SqlCommand cmd = Connection.CreateCommand())
                        {
                            cmd.CommandText = "InsertPaymentMade";

                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@DocNum", Payment.DocNum);
                            cmd.Parameters.AddWithValue("@DocDate", Payment.DocDate);
                            cmd.Parameters.AddWithValue("@TaxDate", Payment.TaxDate);
                            cmd.Parameters.AddWithValue("@DocDueDate", Payment.DocDueDate);
                            cmd.Parameters.AddWithValue("@Comments", Payment.Comments);
                            cmd.Parameters.AddWithValue("@DocType", Payment.DocType);
                            cmd.Parameters.AddWithValue("@Canceled", Payment.Canceled);
                            cmd.Parameters.AddWithValue("@UserSign", Payment.UserSign);
                            cmd.Parameters.AddWithValue("@UpdateDate", Payment.UpdateDate);                           
                            cmd.Parameters.AddWithValue("@FinncPriod", Payment.FinncPriod);
                            cmd.Parameters.AddWithValue("@Address", Payment.Address);
                            cmd.Parameters.AddWithValue("@ObjType",Payment.ObjType);
                            cmd.Parameters.AddWithValue("@CardCode", Payment.CardCode);
                            cmd.Parameters.AddWithValue("@CardName", Payment.CardName);
                            cmd.Parameters.AddWithValue("@JrnlMemo", Payment.JrnlMemo);
                            cmd.Parameters.AddWithValue("@DocCurr", Payment.DocCurr);
                            cmd.Parameters.AddWithValue("@TransId", Payment.TransId);
                            cmd.Parameters.AddWithValue("@SysRate", Payment.SysRate);
                            cmd.Parameters.AddWithValue("@DocRate", Payment.DocRate);
                            cmd.Parameters.AddWithValue("@BpAct", Payment.BpAct);
                            cmd.Parameters.AddWithValue("@DocTotal", Payment.DocTotal);
                            cmd.Parameters.AddWithValue("@DocTotalFC", Payment.DocTotalFC);
                            cmd.Parameters.AddWithValue("@DocTotalSy", Payment.DocTotalSy);
                            cmd.Parameters.AddWithValue("@CashAcct", Payment.CashAcct);
                            cmd.Parameters.AddWithValue("@TrsfrAcct", Payment.TrsfrAcct);
                            cmd.Parameters.AddWithValue("@TrsfrDate",Payment.TrsfrDate);
                            cmd.Parameters.AddWithValue("@TrsfrRef", Payment.TrsfrRef);  
                            cmd.Parameters.AddWithValue("@CashSum", Payment.CashSum);                            
                            cmd.Parameters.AddWithValue("@CashSumFC", Payment.CashSumFC);
                            cmd.Parameters.AddWithValue("@CashSumSy", Payment.CashSumSy);
                            cmd.Parameters.AddWithValue("@TrsfrSum", Payment.TrsfrSum);
                            cmd.Parameters.AddWithValue("@TrsfrSumFC", Payment.TrsfrSumFC);
                            cmd.Parameters.AddWithValue("@TrsfrSumSy", Payment.TrsfrSumSy);
                            cmd.Parameters.AddWithValue("@CheckAcct", Payment.CheckAcct);
                            cmd.Parameters.AddWithValue("@CheckSum", Payment.CheckSum);
                            cmd.Parameters.AddWithValue("@CheckSumFC", Payment.CheckSumFC);
                            cmd.Parameters.AddWithValue("@CheckSumSy", Payment.CheckSumSy);
                            cmd.Parameters.AddWithValue("@PayNoDoc", Payment.PayNoDoc);
                            cmd.Parameters.AddWithValue("@NoDocSum", Payment.NoDocSum);
                            cmd.Parameters.AddWithValue("@NoDocSumFC", Payment.NoDocSumFC);
                            cmd.Parameters.AddWithValue("@NoDocSumSy", Payment.NoDocSumSy);                            
                            cmd.Parameters.AddWithValue("@CounterRef", Payment.CounterRef);
                           
                            flag = cmd.ExecuteNonQuery();

                        }
                    }

                }

                Connection.Close();

                return Tuple.Create(flag, error);

            }
            catch (Exception e)
            {

                Connection.Close();

                return Tuple.Create(flag, e.Message);
            }
        }

        public Tuple<string, string> GetDocumentAccount(int docEntry, string transType)
        {
            string BpAct = null;

            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    using (SqlCommand cmd = Connection.CreateCommand())
                    {
                        cmd.CommandText = "GetDocumentAccount";                       

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@DocEntry", docEntry);

                        cmd.Parameters.AddWithValue("@TransType", transType);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            BpAct = reader["CtlAccount"].ToString();

                        }

                        reader.Close();
                    }

                }

                Connection.Close();

                return Tuple.Create(BpAct, error);

            }
            catch (Exception e)
            {

                Connection.Close();

                return Tuple.Create(BpAct, e.Message);

            }
        }

        public Tuple<List<Payment>, string> FindFirstPaymentMade()
        {
            List<Payment> newListPayment = new List<Payment>();

            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    using (SqlCommand cmd = Connection.CreateCommand())
                    {
                        cmd.CommandText = "FirstPaymentMade";

                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Payment newPayment = new Payment();

                            newPayment.DocEntry = Convert.ToInt32(reader["DocEntry"]);
                            newPayment.DocNum = Convert.ToInt32(reader["DocNum"]);
                            newPayment.CardCode = reader["CardCode"].ToString();
                            newPayment.CardName = reader["CardName"].ToString();
                            newPayment.DocType = Convert.ToChar(reader["DocType"]);
                            newPayment.CashAcct = reader["CashAcct"].ToString();
                            newPayment.CashSum = Convert.ToDecimal(reader["CashSum"]);
                            newPayment.CashSumFC = Convert.ToDecimal(reader["CashSumFC"]);
                            newPayment.CashSumSy = Convert.ToDecimal(reader["CashSumSy"]);
                            newPayment.DocDate = Convert.ToDateTime(reader["DocDate"]);
                            newPayment.TaxDate = Convert.ToDateTime(reader["TaxDate"]);
                            newPayment.DocDueDate = Convert.ToDateTime(reader["DocDueDate"]);
                            newPayment.Address = reader["Address"].ToString();
                            newPayment.TrsfrAcct = reader["TrsfrAcct"].ToString();
                            newPayment.TrsfrSum = Convert.ToDecimal(reader["TrsfrSum"]);
                            newPayment.TrsfrSumFC = Convert.ToDecimal(reader["TrsfrSumFC"]);
                            newPayment.TrsfrSumSy = Convert.ToDecimal(reader["TrsfrSumSy"]);
                            newPayment.TrsfrDate = Convert.ToDateTime(reader["TrsfrDate"]);
                            newPayment.TrsfrRef = reader["TrsfrRef"].ToString();
                            newPayment.PayNoDoc = Convert.ToChar(reader["PayNoDoc"]);
                            newPayment.NoDocSum = Convert.ToDecimal(reader["NoDocSum"]);
                            newPayment.NoDocSumSy = Convert.ToDecimal(reader["NoDocSumSy"]);
                            newPayment.NoDocSumFC = Convert.ToDecimal(reader["NoDocSumFC"]);
                            newPayment.DocTotal = Convert.ToDecimal(reader["DocTotal"]);
                            newPayment.DocTotalFC = Convert.ToDecimal(reader["DocTotalFC"]);
                            newPayment.DocTotalSy = Convert.ToDecimal(reader["DocTotalSy"]);
                            newPayment.JrnlMemo = reader["JrnlMemo"].ToString();
                            newPayment.TransId = Convert.ToInt32(reader["TransId"]);
                            newPayment.CounterRef = reader["CounterRef"].ToString();
                            newPayment.BpAct = reader["BpAct"].ToString();
                            newPayment.DocCurr = reader["DocCurr"].ToString();

                            newListPayment.Add(newPayment);

                        }

                        reader.Close();
                    }

                }

                Connection.Close();

                return Tuple.Create(newListPayment, error);

            }
            catch (Exception e)
            {

                Connection.Close();

                return Tuple.Create(newListPayment, e.Message);
            }
        }

        public Tuple<List<Payment>, string> FindNextPaymentMade(string docNum)
        {
            List<Payment> newListPayment = new List<Payment>();

            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    using (SqlCommand cmd = Connection.CreateCommand())
                    {
                        cmd.CommandText = "NextPaymentMade";

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@DocNum", docNum);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Payment newPayment = new Payment();

                            newPayment.DocEntry = Convert.ToInt32(reader["DocEntry"]);
                            newPayment.DocNum = Convert.ToInt32(reader["DocNum"]);
                            newPayment.CardCode = reader["CardCode"].ToString();
                            newPayment.CardName = reader["CardName"].ToString();
                            newPayment.DocType = Convert.ToChar(reader["DocType"]);
                            newPayment.CashAcct = reader["CashAcct"].ToString();
                            newPayment.CashSum = Convert.ToDecimal(reader["CashSum"]);
                            newPayment.CashSumFC = Convert.ToDecimal(reader["CashSumFC"]);
                            newPayment.CashSumSy = Convert.ToDecimal(reader["CashSumSy"]);
                            newPayment.DocDate = Convert.ToDateTime(reader["DocDate"]);
                            newPayment.TaxDate = Convert.ToDateTime(reader["TaxDate"]);
                            newPayment.DocDueDate = Convert.ToDateTime(reader["DocDueDate"]);
                            newPayment.Address = reader["Address"].ToString();
                            newPayment.TrsfrAcct = reader["TrsfrAcct"].ToString();
                            newPayment.TrsfrSum = Convert.ToDecimal(reader["TrsfrSum"]);
                            newPayment.TrsfrSumFC = Convert.ToDecimal(reader["TrsfrSumFC"]);
                            newPayment.TrsfrSumSy = Convert.ToDecimal(reader["TrsfrSumSy"]);
                            newPayment.TrsfrDate = Convert.ToDateTime(reader["TrsfrDate"]);
                            newPayment.TrsfrRef = reader["TrsfrRef"].ToString();
                            newPayment.PayNoDoc = Convert.ToChar(reader["PayNoDoc"]);
                            newPayment.NoDocSum = Convert.ToDecimal(reader["NoDocSum"]);
                            newPayment.NoDocSumSy = Convert.ToDecimal(reader["NoDocSumSy"]);
                            newPayment.NoDocSumFC = Convert.ToDecimal(reader["NoDocSumFC"]);
                            newPayment.DocTotal = Convert.ToDecimal(reader["DocTotal"]);
                            newPayment.DocTotalFC = Convert.ToDecimal(reader["DocTotalFC"]);
                            newPayment.DocTotalSy = Convert.ToDecimal(reader["DocTotalSy"]);
                            newPayment.JrnlMemo = reader["JrnlMemo"].ToString();
                            newPayment.TransId = Convert.ToInt32(reader["TransId"]);
                            newPayment.CounterRef = reader["CounterRef"].ToString();
                            newPayment.BpAct = reader["BpAct"].ToString();
                            newPayment.DocCurr = reader["DocCurr"].ToString();

                            newListPayment.Add(newPayment);

                        }

                        reader.Close();
                    }

                }

                Connection.Close();

                return Tuple.Create(newListPayment, error);

            }
            catch (Exception e)
            {

                Connection.Close();

                return Tuple.Create(newListPayment, e.Message);
            }
        }

        public Tuple<List<Payment>, string> FindPreviousPaymentMade(string docNum)
        {
            List<Payment> newListPayment = new List<Payment>();

            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    using (SqlCommand cmd = Connection.CreateCommand())
                    {
                        cmd.CommandText = "PreviousPaymentMade";

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@DocNum", docNum);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Payment newPayment = new Payment();

                            newPayment.DocEntry = Convert.ToInt32(reader["DocEntry"]);
                            newPayment.DocNum = Convert.ToInt32(reader["DocNum"]);
                            newPayment.CardCode = reader["CardCode"].ToString();
                            newPayment.CardName = reader["CardName"].ToString();
                            newPayment.DocType = Convert.ToChar(reader["DocType"]);
                            newPayment.CashAcct = reader["CashAcct"].ToString();
                            newPayment.CashSum = Convert.ToDecimal(reader["CashSum"]);
                            newPayment.CashSumFC = Convert.ToDecimal(reader["CashSumFC"]);
                            newPayment.CashSumSy = Convert.ToDecimal(reader["CashSumSy"]);
                            newPayment.DocDate = Convert.ToDateTime(reader["DocDate"]);
                            newPayment.TaxDate = Convert.ToDateTime(reader["TaxDate"]);
                            newPayment.DocDueDate = Convert.ToDateTime(reader["DocDueDate"]);
                            newPayment.Address = reader["Address"].ToString();
                            newPayment.TrsfrAcct = reader["TrsfrAcct"].ToString();
                            newPayment.TrsfrSum = Convert.ToDecimal(reader["TrsfrSum"]);
                            newPayment.TrsfrSumFC = Convert.ToDecimal(reader["TrsfrSumFC"]);
                            newPayment.TrsfrSumSy = Convert.ToDecimal(reader["TrsfrSumSy"]);
                            newPayment.TrsfrDate = Convert.ToDateTime(reader["TrsfrDate"]);
                            newPayment.TrsfrRef = reader["TrsfrRef"].ToString();
                            newPayment.PayNoDoc = Convert.ToChar(reader["PayNoDoc"]);
                            newPayment.NoDocSum = Convert.ToDecimal(reader["NoDocSum"]);
                            newPayment.NoDocSumSy = Convert.ToDecimal(reader["NoDocSumSy"]);
                            newPayment.NoDocSumFC = Convert.ToDecimal(reader["NoDocSumFC"]);
                            newPayment.DocTotal = Convert.ToDecimal(reader["DocTotal"]);
                            newPayment.DocTotalFC = Convert.ToDecimal(reader["DocTotalFC"]);
                            newPayment.DocTotalSy = Convert.ToDecimal(reader["DocTotalSy"]);
                            newPayment.JrnlMemo = reader["JrnlMemo"].ToString();
                            newPayment.TransId = Convert.ToInt32(reader["TransId"]);
                            newPayment.CounterRef = reader["CounterRef"].ToString();
                            newPayment.BpAct = reader["BpAct"].ToString();
                            newPayment.DocCurr = reader["DocCurr"].ToString();

                            newListPayment.Add(newPayment);

                        }

                        reader.Close();
                    }

                }

                Connection.Close();

                return Tuple.Create(newListPayment, error);

            }
            catch (Exception e)
            {

                Connection.Close();

                return Tuple.Create(newListPayment, e.Message);
            }
        }

        public Tuple<DataTable, string> FindPurchaseInvoiceSupplier(string supplier)
        {
            DataTable tabla = new DataTable();

            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    using (SqlCommand cmd = Connection.CreateCommand())
                    {
                        cmd.CommandText = "FindPurchaseInvoiceBusinessPartner";

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CardCode", supplier);

                        data = new SqlDataAdapter(cmd);

                        data.Fill(tabla);

                    }

                }

                Connection.Close();

                return Tuple.Create(tabla, error);

            }
            catch (Exception e)
            {
                Connection.Close();

                return Tuple.Create(tabla, e.Message);
            }
        }

        public Tuple<int, string> SelectDocNum()
        {
            int DocNum = 0;

            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    using (SqlCommand cmd = Connection.CreateCommand())
                    {
                        cmd.CommandText = "SelectDocNumOVPM";

                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            DocNum = Convert.ToInt32(reader["DocNum"]);

                        }

                        reader.Close();
                    }

                }

                Connection.Close();

                return Tuple.Create(DocNum, error);

            }
            catch (Exception e)
            {

                Connection.Close();

                return Tuple.Create(DocNum, e.Message);

            }
        }

        public Tuple<List<Payment>, string> FindPayment(List<Payment> listPayment)
        {
            List<Payment> newListPayment = new List<Payment>();

            string error = null;

            try
            {

                using (Connection = new SqlConnection(connectionString))
                {

                    Connection.Open();

                    foreach (Payment payment in listPayment)
                    {
                        using (SqlCommand cmd = Connection.CreateCommand())
                        {
                            cmd.CommandText = "FindPayment";

                            cmd.CommandType = CommandType.StoredProcedure;

                            try
                            {
                                cmd.Parameters.AddWithValue("@DocNum", payment.DocNum);
                            }
                            catch(Exception ex)
                            {
                                cmd.Parameters.AddWithValue("@DocNum",0);
                            }

                            try
                            {
                                cmd.Parameters.AddWithValue("@DocDate", payment.DocDate);
                            }
                            catch (Exception ex)
                            {
                                cmd.Parameters.AddWithValue("@DocDate", DBNull.Value);
                            }

                            try
                            {
                                cmd.Parameters.AddWithValue("@TaxDate", payment.TaxDate);
                            }
                            catch (Exception ex)
                            {
                                cmd.Parameters.AddWithValue("@TaxDate", DBNull.Value);
                            }

                            try
                            {
                                cmd.Parameters.AddWithValue("@DocDueDate", payment.DocDueDate);
                            }
                            catch (Exception ex)
                            {
                                cmd.Parameters.AddWithValue("@DocDueDate", DBNull.Value);
                            }

                            try
                            {
                                cmd.Parameters.AddWithValue("@CardCode", payment.CardCode);
                            }
                            catch (Exception ex)
                            {
                                cmd.Parameters.AddWithValue("@CardCode", DBNull.Value);
                            }

                            try
                            {
                                cmd.Parameters.AddWithValue("@CardName", payment.CardName);
                            }
                            catch (Exception ex)
                            {
                                cmd.Parameters.AddWithValue("@CardName", DBNull.Value);
                            }

                            try
                            {
                                cmd.Parameters.AddWithValue("@Address", payment.Address);
                            }
                            catch (Exception ex)
                            {
                                cmd.Parameters.AddWithValue("@Address", DBNull.Value);
                            }

                            try
                            {
                                cmd.Parameters.AddWithValue("@CounterRef", payment.CounterRef);
                            }
                            catch (Exception ex)
                            {
                                cmd.Parameters.AddWithValue("@CounterRef", DBNull.Value);
                            }

                            try
                            {
                                cmd.Parameters.AddWithValue("@JrnlMemo", payment.JrnlMemo);
                            }
                            catch (Exception ex)
                            {
                                cmd.Parameters.AddWithValue("@JrnlMemo", DBNull.Value);
                            }

                            try
                            {
                                cmd.Parameters.AddWithValue("@TransId", payment.TransId);
                            }
                            catch (Exception ex)
                            {
                                cmd.Parameters.AddWithValue("@TransId", DBNull.Value);
                            }

                            SqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                Payment newPayment = new Payment();

                                newPayment.DocEntry = Convert.ToInt32(reader["DocEntry"]);
                                newPayment.DocNum = Convert.ToInt32(reader["DocNum"]);
                                newPayment.CardCode = reader["CardCode"].ToString();
                                newPayment.CardName = reader["CardName"].ToString();
                                newPayment.DocType = Convert.ToChar(reader["DocType"]);
                                newPayment.CashAcct = reader["CashAcct"].ToString();
                                newPayment.CashSum = Convert.ToDecimal(reader["CashSum"]);
                                newPayment.CashSumFC = Convert.ToDecimal(reader["CashSumFC"]);
                                newPayment.CashSumSy = Convert.ToDecimal(reader["CashSumSy"]);
                                newPayment.DocDate = Convert.ToDateTime(reader["DocDate"]);
                                newPayment.TaxDate = Convert.ToDateTime(reader["TaxDate"]);
                                newPayment.DocDueDate = Convert.ToDateTime(reader["DocDueDate"]);
                                newPayment.Address = reader["Address"].ToString();
                                newPayment.TrsfrAcct = reader["TrsfrAcct"].ToString();
                                newPayment.TrsfrSum = Convert.ToDecimal(reader["TrsfrSum"]);
                                newPayment.TrsfrSumFC =Convert.ToDecimal(reader["TrsfrSumFC"]);
                                newPayment.TrsfrSumSy = Convert.ToDecimal(reader["TrsfrSumSy"]);
                                newPayment.TrsfrDate = Convert.ToDateTime(reader["TrsfrDate"]);
                                newPayment.TrsfrRef= reader["TrsfrRef"].ToString();
                                newPayment.PayNoDoc = Convert.ToChar(reader["PayNoDoc"]);
                                newPayment.NoDocSum = Convert.ToDecimal(reader["NoDocSum"]);
                                newPayment.NoDocSumSy = Convert.ToDecimal(reader["NoDocSumSy"]);
                                newPayment.NoDocSumFC = Convert.ToDecimal(reader["NoDocSumFC"]);
                                newPayment.DocTotal = Convert.ToDecimal(reader["DocTotal"]);
                                newPayment.DocTotalFC = Convert.ToDecimal(reader["DocTotalFC"]);
                                newPayment.DocTotalSy = Convert.ToDecimal(reader["DocTotalSy"]);
                                newPayment.JrnlMemo =reader["JrnlMemo"].ToString();
                                newPayment.TransId = Convert.ToInt32(reader["TransId"]);
                                newPayment.CounterRef = reader["CounterRef"].ToString();
                                newPayment.BpAct = reader["BpAct"].ToString();
                                newPayment.DocCurr = reader["DocCurr"].ToString();

                                newListPayment.Add(newPayment);

                            }

                            reader.Close();
                        }
                    }

                }

                Connection.Close();

                return Tuple.Create(newListPayment, error);

            }
            catch (Exception e)
            {

                Connection.Close();

                return Tuple.Create(newListPayment, e.Message);
            }
        }
    }
}
