Module MainModule

    Public oCompany As New SAPbobsCOM.Company
    Public oCmpSrv As SAPbobsCOM.CompanyService

    Sub Main()

        Dim frm As New StartupForm

        frm.ShowDialog()

    End Sub



End Module
