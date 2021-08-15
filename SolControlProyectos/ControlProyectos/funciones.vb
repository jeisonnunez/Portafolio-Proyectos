Module funciones
    Public f1 As New frmMenuProyecto
    Public f2 As New frmMantenimientoProy
    Public f3 As New frmClientes
    Public f4 As New frmCobranzas
    Public f5 As New frmEmpresaCont
    Public UserLogin As String = ""
    Public StrNivel As Integer = 0
    Public tabla As String = ""
    Public errorconex As String = ""
    Public modTb As Integer = 0
    Public strNromant As String = ""
    'variables de los pagos
    '----------------------------------------------------------
    Public archivo As String = ""
    Public serieNro As String = ""
    Public DocPago As String = ""
    Public tPago As String = ""
    Public FecPago As Date
    Public tbxConc As String = ""
    Public tbxMonto As Decimal = 0
    Public pathContr As String = ""
    Public pathsinContr As String = ""
    Public lblCon As String = ""
    Public lblCli As String = ""
    Public sw As Integer = 0
    Public Usuario As String = ""
    Public userclave As String = ""
    Public swUser As Integer = 0
    Public swRpts As Integer = 0
    Public strall As String = ""
    Public status As String = ""
    Public sinConex As Integer = 0
    Public descr As String = ""

    'variables para la fecha de los reportes de estimacion de cobros
    Public intPorFecha As Integer = 0
    'si es 1 es por fecha de la cuenta
    'si es 2 es por fecha del recibo
    'si es 3 es por fecha de Inspeccion

    Public intPor As Integer = 0
    'se miden los periodos por: 1-. Ptrimestre, 2.-SegundoTrimestre, 3.-Tercer Trimestre, 4.- Trimestre, 5:- Mes actual

    'vaiables a mostrar en el rpt consolidado
    Public dano As String
    Public selecP As String

    '--------------adendas
    Public swAd As Integer = 0
    Public idAd As Integer = 0
    Public fechaad As Date
    Public fechaadendas As String = ""
    Public nroAd As String = ""
    Public montoAd As Decimal = 0
    Public obsAd As String = ""
    Public inttipoAd As Integer = 0
    Public intMontoProy As Decimal = 0
    Public intAdFin As Integer = 0
    Public intAdT As Integer = 0
    Public intAdTiempo As Integer = 0
    Public dtFechaOrig As Date
    Public intMonAd22 As Decimal = 0
    Public texto As String = ""
    '----------------------------------------------------------
    'PARAMETROS DE LOS REPORTES
    Public repP As Boolean = False
    Public repS As Boolean = False
    Public repT As Boolean = False
    Public repC As Boolean = False
    Public repAll As Integer = 0
    Public repDet As Integer = 0

    '----------------------------------------------------------cuentas 
    Public swCtaFac As Integer = 0
    Public intbloq As Integer = 0
    Public repNC As Integer = 0
    Public repFecFac As Integer = 0
    Public repCnro As Integer = 0
    Public repStatus As Integer = 0
    Public repNroRec As Integer = 0
    Public repMes As Integer = 0
    Public repNroProye As Integer = 0
    '  Public repDet As Integer = 0

    'Public repNroC As Integer = 0
    'Public repNroC As Integer = 0

    '----------------------------------------------------------

    Public swInput As Integer = 0
    Public f7 As New frmMenuProyectoConsulta
    Public Rec1 As String = ""
    Public Rec As String = ""
    'formularios de importacion
    Public f6 As New frmImportacion
    Public f11 As New frmImportacionClientes
    Public f12 As New frmImportacionContratista
    Public f14 As New frmContrRec
    Public f15 As New frmMenuProyectoIncluir
    Public f16 As New frmPresCtas
    Public f17 As New frmpermisos
    Public f18 As New frmClaves
    'Public f19 As New frmReportes
    Public f20 As New frmParamRepts
    Public f21 As New frm_manttbBasiscas
    Public f22 As New frmcarteraT
    Public f23 As New frmInicioproyectos
    Public f24 As New frmReportView
    Public f8 As New frmUsuarios
    Public f25 As New frmInsertaFactura
    Public f26 As frmImportacionFacturas
    Public f27 As frmImportacionResp
    Public fcall As String = ""
    Public swCambioP As Integer = 0
    Public swPagos As Integer = 0

    'Public swctaFac As Integer = 0

    Public swRec As Integer = 0
    'variables globales
    Public decValor As Double = 0
    Public swF As Integer = 0
    Public idProy As Integer = 0
    Public swMen As Integer = 0
    Public swc As Integer = 0
    Public CADENA As String = ""
    Public swExcel As Integer = 0
    Public swIninio As Integer = 0
    ' Public swuser As Integer = 0
    Public contratista As String = ""
    'VECTOR
    Public Dato(60) As String
    Public Proyecto As String = ""

    Public ProyNro As String = ""
    Public ContNro As String = ""
    Public RecNro As String = ""
    Public FactNro As String = ""
    Public FactNrocta As String = ""
    Public CqNro As String = ""
    Public DescProy As String = ""
    Public CtaNro As Double = 0
    Public swguar As Integer = 0

    Public swMenuPpal As Integer = 0
    Public bolValor As Boolean
    Public intk As Integer = 0
    'Variables de conexion
    Public strServer As String = ""
    Public strDB As String = ""
    Public strUser As String = ""
    Public strPass As String = ""

    'variables de sw 
    Public swChange As Integer = 0
    'variables del repore resumen


    Public sectorRes As String = ""
    Public statusRes As String = ""
    Public fechaRes As String = ""

    'variables publicas de Formularios
    Public strcodMenu As String = ""
    Public strCodProy As String = ""
    Public stridProy As String = ""
    Public strcontProy As String = ""
    Public strDescProy As String = ""
    Public strCodbus As String = ""
    Public strcodLoc As String = ""
    Public strdescLoc As String = ""
    Public strpathLoc As String = ""
    Public strCodCont As String = ""
    Public strDescCont As String = ""
    Public strCodCli As String = ""
    Public strDescCli As String = ""

    'variable que se utiliza para que el formulario frmMenuProyecto obtenga la informacion del modulo que lo llame
    Public strMenu As String = ""

    'conexion db
    Public cntSQL As New ADODB.Connection
    Public cntDBa2 As New ADODB.Connection
    Public cntsinDBa2 As New ADODB.Connection
    Public Function EstaAbierto(ByVal Myform As Form)
        Dim objForm As Form
        Dim blnAbierto As Boolean = False
        blnAbierto = False
        For Each objForm In My.Application.OpenForms
            If (Trim(objForm.Name) = Trim(Myform.Name)) Then
                blnAbierto = True

            End If
        Next
        Return blnAbierto
    End Function
    Sub llenarNroctas()
        Try
            ConexionSQL()
            Dim strDatos As New ADODB.Recordset
            Dim i As Integer = 0
            f7.ltwCtas.Items.Clear()

            strDatos = cntSQL.Execute("SELECT pro_nroContrato,[pro_nroCuenta],pro_serieCuenta ,[pro_NroFactura],[pro_FechaD] ,[pro_FechaH] ,[pro_TrabajoR],[pro_FechaR]  ,[pro_PresInsp] ,[pro_FechaP]  from tab_DatosPpalProy_Compl where pro_nroContrato='" & ContNro & "' and pro_nroProyecto='" & ProyNro & "'")

            Do While Not strDatos.EOF

                f7.ltwCtas.Items.Add(ProyNro)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_serieCuenta").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_NroFactura").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_nroContrato").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_FechaD").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_FechaH").Value)
                f7.ltwCtas.Items(i).SubItems.Add(decimales(strDatos.Fields("pro_TrabajoR").Value))
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_FechaR").Value)
                f7.ltwCtas.Items(i).SubItems.Add(decimales(strDatos.Fields("pro_PresInsp").Value))
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_FechaP").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_nroCuenta").Value)
                i += 1
                strDatos.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Error en buscar Nro de llenarNrocta()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub
    Public Function ConexionBDA2() As Boolean
        Try

            If cntDBa2.State = 1 Then
                cntDBa2.Close()
            End If

            cntDBa2.ConnectionString = "DRIVER={DBISAM 4 ODBC Driver};ConnectionType=Local;CatalogName=" & "" & pathContr & ""
            cntDBa2.ConnectionTimeout = 36000 'Dos minutos
            cntDBa2.CommandTimeout = 36000 ' Diez minutos
            cntDBa2.Open()

            ' cntOASIS.Close()

        Catch ex As Exception

            MsgBox("Error en conexion con Base de Datos '" & pathContr & "' Por favor Revise la Ruta de la Misma" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try
    End Function

    Public Function ConexionsincBDA2() As Boolean
        Try

            If cntsinDBa2.State = 1 Then
                cntsinDBa2.Close()
            End If

            cntsinDBa2.ConnectionString = "DRIVER={DBISAM 4 ODBC Driver};ConnectionType=Local;CatalogName=" & "" & pathsinContr & ""
            cntsinDBa2.ConnectionTimeout = 36000 'Dos minutos
            cntsinDBa2.CommandTimeout = 36000 ' Diez minutos
            cntsinDBa2.Open()

            ' cntOASIS.Close()

        Catch ex As Exception

            MsgBox("Error en conexion con Base de Datos '" & pathsinContr & "' Por favor Revise la Ruta de la Misma" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try
    End Function
    Sub habilita_deshabMenu()

        Try
            Dim strMenu As ADODB.Recordset
            Dim menu As String = ""
            ConexionSQL()
            strMenu = cntSQL.Execute("SELECT usuario,menuForm, descFormMenu  FROM tab_proPermisoform left outer join tab_proMenuForm on menuForm=codMenu where usuario ='" & UserLogin & "' and activo=1")

            frmExplorer.ToolStripButton1.Enabled = False
            frmExplorer.ToolStripButton22.Enabled = False
            frmExplorer.ToolStripButton13.Enabled = False
            frmExplorer.ToolStripButton15.Enabled = False
            frmExplorer.ToolStripButton16.Enabled = False
            frmExplorer.ToolStripButton17.Enabled = False
            frmExplorer.ToolStripButton24.Enabled = False
            frmExplorer.tsbtnMant1.Enabled = False
            frmExplorer.ToolStripButton18.Enabled = False
            frmExplorer.ToolStripButton19.Enabled = False
            frmExplorer.ToolStripButton20.Enabled = False
            frmExplorer.ToolStripButton26.Enabled = False
            frmExplorer.ToolStripButton8.Enabled = False
            frmExplorer.ToolStripButton9.Enabled = False
            frmExplorer.ToolStripButton10.Enabled = False

            frmExplorer.ToolStripButton29.Enabled = False
            frmExplorer.ToolStripButton30.Enabled = False

            frmExplorer.ToolStripButton27.Enabled = False
            frmExplorer.ToolStripButton28.Enabled = False
            frmExplorer.NewToolStripMenuItem.Enabled = False
            frmExplorer.ToolStripMenuItem1.Enabled = False
            frmExplorer.ToolStripMenuItem2.Enabled = False

            frmExplorer.ToolStripMenuItem3.Enabled = False
            frmExplorer.ToolStripMenuItem4.Enabled = False
            frmExplorer.ToolStripMenuItem6.Enabled = False
            frmExplorer.ToolStripMenuItem7.Enabled = False
            frmExplorer.ToolStripMenuItem8.Enabled = False
            frmExplorer.ToolStripMenuItemct.Enabled = False
            ' frmExplorer.ToolStripMenuItemxsec.Enabled = False
            frmExplorer.ToolStripMenuItemg.Enabled = False
            ' frmExplorer.ToolStripMenuItemt.Enabled = False
            frmExplorer.UsuariosToolStripMenuItem.Enabled = False
            frmExplorer.ImToolStripMenuItem.Enabled = False
            frmExplorer.HistToolStripMenuItem.Enabled = False
            frmExplorer.HistToolStripMenuItem.Enabled = False
            frmExplorer.PermisoAToolStripMenuItem.Enabled = False
            frmExplorer.FormularioToolStripMenuItem.Enabled = False

            Do While Not strMenu.EOF
                menu = strMenu.Fields("descFormMenu").Value


                If menu = "ToolStripButton1" Then
                    frmExplorer.ToolStripButton1.Enabled = True
                End If
                If menu = "ToolStripButton22" Then
                    frmExplorer.ToolStripButton22.Enabled = True
                End If
                If menu = "ToolStripButton24" Then
                    frmExplorer.ToolStripButton24.Enabled = True
                End If
                If menu = "ToolStripButton13" Then
                    frmExplorer.ToolStripButton13.Enabled = True
                End If
                If menu = "ToolStripButton15" Then
                    frmExplorer.ToolStripButton15.Enabled = True
                End If
                If menu = "ToolStripButton16" Then
                    frmExplorer.ToolStripButton16.Enabled = True
                End If
                If menu = "ToolStripButton17" Then
                    frmExplorer.ToolStripButton17.Enabled = True
                End If

                If menu = "tsbtnMant1" Then
                    frmExplorer.tsbtnMant1.Enabled = True
                End If
                If menu = "ToolStripButton18" Then
                    frmExplorer.ToolStripButton18.Enabled = True
                End If
                If menu = "ToolStripButton19" Then
                    frmExplorer.ToolStripButton19.Enabled = True
                End If
                If menu = "ToolStripButton20" Then
                    frmExplorer.ToolStripButton20.Enabled = True
                End If
                If menu = "ToolStripButton26" Then
                    frmExplorer.ToolStripButton26.Enabled = True
                End If
                If menu = "ToolStripButton8" Then
                    frmExplorer.ToolStripButton8.Enabled = True
                End If
                If menu = "ToolStripButton9" Then
                    frmExplorer.ToolStripButton9.Enabled = True
                End If
                If menu = "ToolStripButton10" Then
                    frmExplorer.ToolStripButton10.Enabled = True
                End If
                If menu = "ToolStripButton27" Then
                    frmExplorer.ToolStripButton27.Enabled = True
                End If
                If menu = "ToolStripButton28" Then
                    frmExplorer.ToolStripButton28.Enabled = True
                End If

                If menu = "ToolStripButton29" Then
                    frmExplorer.ToolStripButton29.Enabled = True
                End If
                If menu = "ToolStripButton30" Then
                    frmExplorer.ToolStripButton30.Enabled = True
                End If

                If menu = "NewToolStripMenuItem" Then
                    frmExplorer.NewToolStripMenuItem.Enabled = True
                End If

                If menu = "ToolStripMenuItem1" Then
                    frmExplorer.ToolStripMenuItem1.Enabled = True
                End If

                If menu = "ToolStripMenuItem2" Then
                    frmExplorer.ToolStripMenuItem2.Enabled = True
                End If

                If menu = "ToolStripMenuItem3" Then
                    frmExplorer.ToolStripMenuItem3.Enabled = True
                End If
                If menu = "ToolStripMenuItem4" Then
                    frmExplorer.ToolStripMenuItem4.Enabled = True
                End If
                If menu = "ToolStripMenuItem6" Then
                    frmExplorer.ToolStripMenuItem6.Enabled = True
                End If
                If menu = "ToolStripMenuItem7" Then
                    frmExplorer.ToolStripMenuItem7.Enabled = True
                End If
                If menu = "ToolStripMenuItem8" Then
                    frmExplorer.ToolStripMenuItem8.Enabled = True
                End If
                If menu = "ToolStripMenuItemct" Then
                    frmExplorer.ToolStripMenuItemct.Enabled = True
                End If
                'If menu = "ToolStripMenuItemxsec" Then
                '    frmExplorer.ToolStripMenuItemxsec.Enabled = True
                'End If
                If menu = "ToolStripMenuItemg" Then
                    frmExplorer.ToolStripMenuItemg.Enabled = True
                End If
                'If menu = "ToolStripMenuItemt" Then
                '    frmExplorer.ToolStripMenuItemt.Enabled = True
                'End If
                If menu = "UsuariosToolStripMenuItem" Then
                    frmExplorer.UsuariosToolStripMenuItem.Enabled = True
                End If
                If menu = "ImToolStripMenuItem" Then
                    frmExplorer.ImToolStripMenuItem.Enabled = True
                End If
                If menu = "HistToolStripMenuItem" Then
                    frmExplorer.HistToolStripMenuItem.Enabled = True
                End If
                If menu = "PermisoAToolStripMenuItem" Then
                    frmExplorer.PermisoAToolStripMenuItem.Enabled = True
                End If
                If menu = "FormularioToolStripMenuItem" Then
                    frmExplorer.FormularioToolStripMenuItem.Enabled = True
                End If

                strMenu.MoveNext()

            Loop




        Catch ex As Exception
            MsgBox("Error en funcion habilita_deshabMenu()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try
       
    End Sub

    Sub ConexionSQL()
        Try

            If cntSQL.State = 1 Then

                cntSQL.Close()
            End If
            'cntSQL.ConnectionString = "Provider=SQLOLEDB;Data Source=" & strServer & ";Initial Catalog=" & strDB & ";User ID=" & strUser & ";Password=" & strPass & ";Connect Timeout=15"
            cntSQL.ConnectionString = "DSN=ControlProyectos;Uid=cp_user;Pwd=cp_user;"
            'cntSQL.ConnectionTimeout = 100000
            cntSQL.Open()
        Catch exc As Exception
            MsgBox("No hay conexión con la base de datos de ControlProyectos, intente más tarde" & exc.Message, MsgBoxStyle.Critical, "Control Proyectos")
            cntSQL = Nothing
            Application.ExitThread()
        End Try

    End Sub

    Sub ExtraerRutaConex()
        Try

            'Dim i As Integer = 0

            'Dim lector As New IO.StreamReader("C:\ConexionSQL\ConexionSQL.ini")

            '' Leer el contenido mientras no se llegue al final
            'While lector.Peek() <> -1

            '    'leo variable de descompresion

            '    If i = 0 Then
            '        strServer = Trim(lector.ReadLine())
            '    End If
            '    ''leo variables de conexion          
            '    If i = 1 Then
            '        strDB = Trim(lector.ReadLine())
            '    End If
            '    If i = 2 Then
            '        strUser = Trim(lector.ReadLine())
            '    End If
            '    If i = 3 Then
            '        strPass = Trim(lector.ReadLine())
            '    End If
            '    If i = 3 Then
            '        Exit While
            '    End If
            '    i += 1

            'End While

            'lector.Close()
            frmPresentacion.Visible = False
            sinConex = 0
            '   frmExplorer.Show()
            frmLoginPass.Show()
        Catch ex As Exception
            sinConex = 1
            errorconex = ex.Message
            MsgBox("Error en funcion extraer ruta" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try ' Cerrar el fichero


    End Sub


    Sub guardaActProyeDFact()
        Try
            Dim strDFact As New ADODB.Recordset
            ConexionSQL()
            'pregunta si el proyecto no tiene cargado datos iniciales de facturas
            If CtaNro = 1 And swctaFac = 1 Then
                strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo='' ")

                If strDFact.EOF = False Then
                    cntSQL.Execute("UPDATE [tab_Aux_FactProy] SET [pro_NroContrato]='" & ContNro & "', " _
                                    & " [pro_NroRecibo]='" & f1.tbxNroReci.Text & "', " _
                                    & " pro_nroProyecto='" & ProyNro & "', " _
                                    & " [pro_FechaRes]= '" & Format(f1.dtpFecFac.Value, "yyyyMMdd") & "', " _
                                    & " [pro_NroFactura]='" & FactNro & "', " _
                                    & " [pro_FechaFact]='" & Format(f1.dtpFecREC.Value, "yyyyMMdd") & "', " _
                                    & " [pro_trabajoFac]=" & Replace(IIf(f1.tbxFac.Text = "", 0, f1.tbxFac.Text), ",", "") & ", " _
                                    & " [pro_Rete10]='" & f1.cmbRe10.SelectedIndex & "', " _
                                    & " [pro_MtoRete10]= " & Replace(IIf(f1.tbxMtoRet.Text = "", 0, f1.tbxMtoRet.Text), ",", "") & ", " _
                                    & " [pro_Anticipo]=" & Replace(IIf(f1.tbxAntMont.Text = "", 0, f1.tbxAntMont.Text), ",", "") & ", " _
                                    & " [pro_Penalizacion]=" & Replace(IIf(f1.tbxPena.Text = "", 0, f1.tbxPena.Text), ",", "") & ", " _
                                    & " [pro_RETdeITBMS]=" & Replace(IIf(f1.tbxRetMtoITBMS.Text = "", 0, f1.tbxRetMtoITBMS.Text), ",", "") & ", " _
                                    & " [pro_MontoITBMS]=" & Replace(IIf(f1.tbxMtoITBMS.Text = "", 0, f1.tbxMtoITBMS.Text), ",", "") & ", " _
                                    & " [pro_CuentaCobrar]=" & Replace(IIf(f1.tbxCxC.Text = "", 0, f1.tbxCxC.Text), ",", "") & ", " _
                                    & " [pro_EntrInsp]='" & f1.cmbEnInsp.SelectedIndex & "', " _
                                    & " [pro_FechaCliente]='" & Format(f1.dtpFecEnt.Value, "yyyyMMdd") & "', " _
                                    & " [pro_FechaCxc]='" & Format(f1.dtpCXC.Value, "yyyyMMdd") & "', " _
                                    & " [pro_FechaTes]='" & Format(f1.dtpFecTe.Value, "yyyyMMdd") & "', " _
                                    & " [pro_FechaPago]='" & Format(f1.dtpFecPago.Value, "yyyyMMdd") & "', " _
                                    & " pro_montoCheque=" & Replace(IIf(f1.tbxMtoCheq.Text = "", 0, f1.tbxMtoCheq.Text), ",", "") & " " _
                                    & "  where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo=''")

                Else
                    cntSQL.Execute("insert into [tab_Aux_FactProy] ([pro_idProyecto] ,pro_nroProyecto,[pro_NroContrato],[pro_NroRecibo],[pro_FechaRes],[pro_NroFactura]" _
                                         & " ,[pro_FechaFact],[pro_trabajoFac],[pro_Rete10],[pro_MtoRete10],[pro_Anticipo],[pro_Penalizacion]" _
                                         & " ,[pro_RETdeITBMS],[pro_MontoITBMS],[pro_CuentaCobrar],[pro_EntrInsp],[pro_FechaCliente],[pro_FechaCxc]" _
                                         & " ,[pro_FechaTes],[pro_FechaPago], pro_montoCheque, pro_manual) VALUES " _
                                         & "( " & stridProy & ", " _
                                         & " '" & ProyNro & "', " _
                                         & " '" & ContNro & "', " _
                                         & " '" & RecNro & "', " _
                                         & " '" & Format(f1.dtpFecFac.Value, "yyyyMMdd") & "', " _
                                         & " '" & FactNro & "', " _
                                         & " '" & Format(f1.dtpFecREC.Value, "yyyyMMdd") & "', " _
                                         & " " & Replace(IIf(f1.tbxFac.Text = "", 0, f1.tbxFac.Text), ",", "") & "," _
                                         & " " & f1.cmbRe10.SelectedIndex & "," _
                                         & " " & Replace(IIf(f1.tbxMtoRet.Text = "", 0, f1.tbxMtoRet.Text), ",", "") & ", " _
                                         & " " & Replace(IIf(f1.tbxAntMont.Text = "", 0, f1.tbxAntMont.Text), ",", "") & ", " _
                                         & " " & Replace(IIf(f1.tbxPena.Text = "", 0, f1.tbxPena.Text), ",", "") & ", " _
                                         & " " & Replace(IIf(f1.tbxRetMtoITBMS.Text = "", 0, f1.tbxRetMtoITBMS.Text), ",", "") & ",  " _
                                         & " " & Replace(IIf(f1.tbxMtoITBMS.Text = "", 0, f1.tbxMtoITBMS.Text), ",", "") & ",  " _
                                         & " " & Replace(IIf(f1.tbxCxC.Text = "", 0, f1.tbxCxC.Text), ",", "") & " ," _
                                         & " " & f1.cmbEnInsp.SelectedIndex & "," _
                                         & "'" & Format(f1.dtpFecEnt.Value, "yyyyMMdd") & "'  ," _
                                         & " '" & Format(f1.dtpCXC.Value, "yyyyMMdd") & "' ," _
                                         & " '" & Format(f1.dtpFecTe.Value, "yyyyMMdd") & "' ," _
                                         & " '" & Format(f1.dtpFecPago.Value, "yyyyMMdd") & "',  " _
                                         & " " & Replace(IIf(f1.tbxMtoCheq.Text = "", 0, f1.tbxMtoCheq.Text), ",", "") & "," & 0 & ")")
                End If
            Else



                If FactNro = "" And RecNro = "" Then

                    strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo='' ")

                    If strDFact.EOF = False Then
                        cntSQL.Execute("UPDATE [tab_Aux_FactProy] SET [pro_NroContrato]='" & ContNro & "', " _
                                        & " [pro_NroRecibo]='" & f1.tbxNroReci.Text & "', " _
                                        & " [pro_FechaRes]= '" & Format(f1.dtpFecFac.Value, "yyyyMMdd") & "', " _
                                        & " pro_nroProyecto='" & ProyNro & "', " _
                                        & " [pro_NroFactura]='" & FactNro & "', " _
                                        & " [pro_FechaFact]='" & Format(f1.dtpFecREC.Value, "yyyyMMdd") & "', " _
                                        & " [pro_trabajoFac]=" & Replace(IIf(f1.tbxFac.Text = "", 0, f1.tbxFac.Text), ",", "") & ", " _
                                        & " [pro_Rete10]='" & f1.cmbRe10.SelectedIndex & "', " _
                                        & " [pro_MtoRete10]= " & Replace(IIf(f1.tbxMtoRet.Text = "", 0, f1.tbxMtoRet.Text), ",", "") & ", " _
                                        & " [pro_Anticipo]=" & Replace(IIf(f1.tbxAntMont.Text = "", 0, f1.tbxAntMont.Text), ",", "") & ", " _
                                        & " [pro_Penalizacion]=" & Replace(IIf(f1.tbxPena.Text = "", 0, f1.tbxPena.Text), ",", "") & ", " _
                                        & " [pro_RETdeITBMS]=" & Replace(IIf(f1.tbxRetMtoITBMS.Text = "", 0, f1.tbxRetMtoITBMS.Text), ",", "") & ", " _
                                        & " [pro_MontoITBMS]=" & Replace(IIf(f1.tbxMtoITBMS.Text = "", 0, f1.tbxMtoITBMS.Text), ",", "") & ", " _
                                        & " [pro_CuentaCobrar]=" & Replace(IIf(f1.tbxCxC.Text = "", 0, f1.tbxCxC.Text), ",", "") & ", " _
                                        & " [pro_EntrInsp]='" & f1.cmbEnInsp.SelectedIndex & "', " _
                                        & " [pro_FechaCliente]='" & Format(f1.dtpFecEnt.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaCxc]='" & Format(f1.dtpCXC.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaTes]='" & Format(f1.dtpFecTe.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaPago]='" & Format(f1.dtpFecPago.Value, "yyyyMMdd") & "', " _
                                        & " pro_montoCheque=" & Replace(IIf(f1.tbxMtoCheq.Text = "", 0, f1.tbxMtoCheq.Text), ",", "") & " " _
                                        & "  where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo=''")

                    Else
                        cntSQL.Execute("insert into [tab_Aux_FactProy] ([pro_idProyecto] ,pro_nroProyecto,[pro_NroContrato],[pro_NroRecibo],[pro_FechaRes],[pro_NroFactura]" _
                                         & " ,[pro_FechaFact],[pro_trabajoFac],[pro_Rete10],[pro_MtoRete10],[pro_Anticipo],[pro_Penalizacion]" _
                                         & " ,[pro_RETdeITBMS],[pro_MontoITBMS],[pro_CuentaCobrar],[pro_EntrInsp],[pro_FechaCliente],[pro_FechaCxc]" _
                                         & " ,[pro_FechaTes],[pro_FechaPago],pro_montoCheque, pro_manual) VALUES " _
                                         & "( " & stridProy & ", " _
                                         & " '" & ProyNro & "', " _
                                         & " '" & ContNro & "', " _
                                         & " '" & RecNro & "', " _
                                         & " '" & Format(f1.dtpFecFac.Value, "yyyyMMdd") & "', " _
                                         & " '" & FactNro & "', " _
                                         & " '" & Format(f1.dtpFecREC.Value, "yyyyMMdd") & "', " _
                                         & " " & Replace(IIf(f1.tbxFac.Text = "", 0, f1.tbxFac.Text), ",", "") & "," _
                                         & " " & f1.cmbRe10.SelectedIndex & "," _
                                         & " " & Replace(IIf(f1.tbxMtoRet.Text = "", 0, f1.tbxMtoRet.Text), ",", "") & ", " _
                                         & " " & Replace(IIf(f1.tbxAntMont.Text = "", 0, f1.tbxAntMont.Text), ",", "") & ", " _
                                         & " " & Replace(IIf(f1.tbxPena.Text = "", 0, f1.tbxPena.Text), ",", "") & ", " _
                                         & " " & Replace(IIf(f1.tbxRetMtoITBMS.Text = "", 0, f1.tbxRetMtoITBMS.Text), ",", "") & ",  " _
                                         & " " & Replace(IIf(f1.tbxMtoITBMS.Text = "", 0, f1.tbxMtoITBMS.Text), ",", "") & ",  " _
                                         & " " & Replace(IIf(f1.tbxCxC.Text = "", 0, f1.tbxCxC.Text), ",", "") & " ," _
                                         & " " & f1.cmbEnInsp.SelectedIndex & "," _
                                         & "'" & Format(f1.dtpFecEnt.Value, "yyyyMMdd") & "'  ," _
                                         & " '" & Format(f1.dtpCXC.Value, "yyyyMMdd") & "' ," _
                                         & " '" & Format(f1.dtpFecTe.Value, "yyyyMMdd") & "' ," _
                                         & " '" & Format(f1.dtpFecPago.Value, "yyyyMMdd") & "',  " _
                                         & " " & Replace(IIf(f1.tbxMtoCheq.Text = "", 0, f1.tbxMtoCheq.Text), ",", "") & "," & 0 & ")")
                    End If


                End If


                If FactNro <> "" And RecNro = "" Then
                    strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='' ")

                    If strDFact.EOF = False Then
                        cntSQL.Execute("UPDATE [tab_Aux_FactProy] SET [pro_NroContrato]='" & ContNro & "', " _
                                       & " pro_nroProyecto='" & ProyNro & "', " _
                                        & " [pro_NroRecibo]='" & f1.tbxNroReci.Text & "', " _
                                        & " [pro_FechaRes]= '" & Format(f1.dtpFecFac.Value, "yyyyMMdd") & "', " _
                                        & " [pro_NroFactura]='" & f1.tbxNroFac.Text & "', " _
                                        & " [pro_FechaFact]='" & Format(f1.dtpFecREC.Value, "yyyyMMdd") & "', " _
                                        & " [pro_trabajoFac]=" & Replace(IIf(f1.tbxFac.Text = "", 0, f1.tbxFac.Text), ",", "") & ", " _
                                        & " [pro_Rete10]='" & f1.cmbRe10.SelectedIndex & "', " _
                                        & " [pro_MtoRete10]= " & Replace(IIf(f1.tbxMtoRet.Text = "", 0, f1.tbxMtoRet.Text), ",", "") & ", " _
                                        & " [pro_Anticipo]=" & Replace(IIf(f1.tbxAntMont.Text = "", 0, f1.tbxAntMont.Text), ",", "") & ", " _
                                        & " [pro_Penalizacion]=" & Replace(IIf(f1.tbxPena.Text = "", 0, f1.tbxPena.Text), ",", "") & ", " _
                                        & " [pro_RETdeITBMS]=" & Replace(IIf(f1.tbxRetMtoITBMS.Text = "", 0, f1.tbxRetMtoITBMS.Text), ",", "") & ", " _
                                        & " [pro_MontoITBMS]=" & Replace(IIf(f1.tbxMtoITBMS.Text = "", 0, f1.tbxMtoITBMS.Text), ",", "") & ", " _
                                        & " [pro_CuentaCobrar]=" & Replace(IIf(f1.tbxCxC.Text = "", 0, f1.tbxCxC.Text), ",", "") & ", " _
                                        & " [pro_EntrInsp]='" & f1.cmbEnInsp.SelectedIndex & "', " _
                                        & " [pro_FechaCliente]='" & Format(f1.dtpFecEnt.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaCxc]='" & Format(f1.dtpCXC.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaTes]='" & Format(f1.dtpFecTe.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaPago]='" & Format(f1.dtpFecPago.Value, "yyyyMMdd") & "', " _
                                          & " pro_montoCheque=" & Replace(IIf(f1.tbxMtoCheq.Text = "", 0, f1.tbxMtoCheq.Text), ",", "") & " " _
                                        & "  where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo=''")

                    Else
                        cntSQL.Execute("insert into [tab_Aux_FactProy] ([pro_idProyecto] ,pro_nroProyecto,[pro_NroContrato],[pro_NroRecibo],[pro_FechaRes],[pro_NroFactura]" _
                                         & " ,[pro_FechaFact],[pro_trabajoFac],[pro_Rete10],[pro_MtoRete10],[pro_Anticipo],[pro_Penalizacion]" _
                                         & " ,[pro_RETdeITBMS],[pro_MontoITBMS],[pro_CuentaCobrar],[pro_EntrInsp],[pro_FechaCliente],[pro_FechaCxc]" _
                                         & " ,[pro_FechaTes],[pro_FechaPago],pro_montoCheque, pro_manual) VALUES " _
                                         & "( " & stridProy & ", " _
                                         & " '" & ProyNro & "', " _
                                         & " '" & ContNro & "', " _
                                         & " '" & RecNro & "', " _
                                         & " '" & Format(f1.dtpFecFac.Value, "yyyyMMdd") & "', " _
                                         & " '" & FactNro & "', " _
                                         & " '" & Format(f1.dtpFecREC.Value, "yyyyMMdd") & "', " _
                                         & " " & Replace(IIf(f1.tbxFac.Text = "", 0, f1.tbxFac.Text), ",", "") & "," _
                                         & " " & f1.cmbRe10.SelectedIndex & "," _
                                         & " " & Replace(IIf(f1.tbxMtoRet.Text = "", 0, f1.tbxMtoRet.Text), ",", "") & ", " _
                                         & " " & Replace(IIf(f1.tbxAntMont.Text = "", 0, f1.tbxAntMont.Text), ",", "") & ", " _
                                         & " " & Replace(IIf(f1.tbxPena.Text = "", 0, f1.tbxPena.Text), ",", "") & ", " _
                                         & " " & Replace(IIf(f1.tbxRetMtoITBMS.Text = "", 0, f1.tbxRetMtoITBMS.Text), ",", "") & ",  " _
                                         & " " & Replace(IIf(f1.tbxMtoITBMS.Text = "", 0, f1.tbxMtoITBMS.Text), ",", "") & ",  " _
                                         & " " & Replace(IIf(f1.tbxCxC.Text = "", 0, f1.tbxCxC.Text), ",", "") & " ," _
                                         & " " & f1.cmbEnInsp.SelectedIndex & "," _
                                         & "'" & Format(f1.dtpFecEnt.Value, "yyyyMMdd") & "'  ," _
                                         & " '" & Format(f1.dtpCXC.Value, "yyyyMMdd") & "' ," _
                                         & " '" & Format(f1.dtpFecTe.Value, "yyyyMMdd") & "' ," _
                                         & " '" & Format(f1.dtpFecPago.Value, "yyyyMMdd") & "',  " _
                                         & " " & Replace(IIf(f1.tbxMtoCheq.Text = "", 0, f1.tbxMtoCheq.Text), ",", "") & "," & 0 & ")")
                    End If



                End If



                If FactNro <> "" And RecNro <> "" Then
                    strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & RecNro & "' ")

                    If strDFact.EOF = False Then
                        cntSQL.Execute("UPDATE [tab_Aux_FactProy] SET [pro_NroContrato]='" & ContNro & "', " _
                                        & " [pro_NroRecibo]='" & f1.tbxNroReci.Text & "', " _
                                        & " pro_nroProyecto='" & ProyNro & "', " _
                                        & " [pro_FechaRes]= '" & Format(f1.dtpFecFac.Value, "yyyyMMdd") & "', " _
                                        & " [pro_NroFactura]='" & f1.tbxNroFac.Text & "', " _
                                        & " [pro_FechaFact]='" & Format(f1.dtpFecREC.Value, "yyyyMMdd") & "', " _
                                        & " [pro_trabajoFac]=" & Replace(IIf(f1.tbxFac.Text = "", 0, f1.tbxFac.Text), ",", "") & ", " _
                                        & " [pro_Rete10]='" & f1.cmbRe10.SelectedIndex & "', " _
                                        & " [pro_MtoRete10]= " & Replace(IIf(f1.tbxMtoRet.Text = "", 0, f1.tbxMtoRet.Text), ",", "") & ", " _
                                        & " [pro_Anticipo]=" & Replace(IIf(f1.tbxAntMont.Text = "", 0, f1.tbxAntMont.Text), ",", "") & ", " _
                                        & " [pro_Penalizacion]=" & Replace(IIf(f1.tbxPena.Text = "", 0, f1.tbxPena.Text), ",", "") & ", " _
                                        & " [pro_RETdeITBMS]=" & Replace(IIf(f1.tbxRetMtoITBMS.Text = "", 0, f1.tbxRetMtoITBMS.Text), ",", "") & ", " _
                                        & " [pro_MontoITBMS]=" & Replace(IIf(f1.tbxMtoITBMS.Text = "", 0, f1.tbxMtoITBMS.Text), ",", "") & ", " _
                                        & " [pro_CuentaCobrar]=" & Replace(IIf(f1.tbxCxC.Text = "", 0, f1.tbxCxC.Text), ",", "") & ", " _
                                        & " [pro_EntrInsp]='" & f1.cmbEnInsp.SelectedIndex & "', " _
                                        & " [pro_FechaCliente]='" & Format(f1.dtpFecEnt.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaCxc]='" & Format(f1.dtpCXC.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaTes]='" & Format(f1.dtpFecTe.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaPago]='" & Format(f1.dtpFecPago.Value, "yyyyMMdd") & "', " _
                                          & " pro_montoCheque=" & Replace(IIf(f1.tbxMtoCheq.Text = "", 0, f1.tbxMtoCheq.Text), ",", "") & " " _
                                        & "  where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and  pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & RecNro & "'")

                    Else
                        cntSQL.Execute("insert into [tab_Aux_FactProy] ([pro_idProyecto] ,pro_nroProyecto,[pro_NroContrato],[pro_NroRecibo],[pro_FechaRes],[pro_NroFactura]" _
                                         & " ,[pro_FechaFact],[pro_trabajoFac],[pro_Rete10],[pro_MtoRete10],[pro_Anticipo],[pro_Penalizacion]" _
                                         & " ,[pro_RETdeITBMS],[pro_MontoITBMS],[pro_CuentaCobrar],[pro_EntrInsp],[pro_FechaCliente],[pro_FechaCxc]" _
                                         & " ,[pro_FechaTes],[pro_FechaPago], pro_montoCheque, pro_manual) VALUES " _
                                         & "( " & stridProy & ", " _
                                         & " '" & ProyNro & "', " _
                                         & " '" & ContNro & "', " _
                                         & " '" & RecNro & "', " _
                                         & " '" & Format(f1.dtpFecFac.Value, "yyyyMMdd") & "', " _
                                         & " '" & FactNro & "', " _
                                         & " '" & Format(f1.dtpFecREC.Value, "yyyyMMdd") & "', " _
                                         & " " & Replace(IIf(f1.tbxFac.Text = "", 0, f1.tbxFac.Text), ",", "") & "," _
                                         & " " & f1.cmbRe10.SelectedIndex & "," _
                                         & " " & Replace(IIf(f1.tbxMtoRet.Text = "", 0, f1.tbxMtoRet.Text), ",", "") & ", " _
                                         & " " & Replace(IIf(f1.tbxAntMont.Text = "", 0, f1.tbxAntMont.Text), ",", "") & ", " _
                                         & " " & Replace(IIf(f1.tbxPena.Text = "", 0, f1.tbxPena.Text), ",", "") & ", " _
                                         & " " & Replace(IIf(f1.tbxRetMtoITBMS.Text = "", 0, f1.tbxRetMtoITBMS.Text), ",", "") & ",  " _
                                         & " " & Replace(IIf(f1.tbxMtoITBMS.Text = "", 0, f1.tbxMtoITBMS.Text), ",", "") & ",  " _
                                         & " " & Replace(IIf(f1.tbxCxC.Text = "", 0, f1.tbxCxC.Text), ",", "") & " ," _
                                         & " " & f1.cmbEnInsp.SelectedIndex & "," _
                                         & "'" & Format(f1.dtpFecEnt.Value, "yyyyMMdd") & "'  ," _
                                         & " '" & Format(f1.dtpCXC.Value, "yyyyMMdd") & "' ," _
                                         & " '" & Format(f1.dtpFecTe.Value, "yyyyMMdd") & "' ," _
                                         & " '" & Format(f1.dtpFecPago.Value, "yyyyMMdd") & "',  " _
                                         & " " & Replace(IIf(f1.tbxMtoCheq.Text = "", 0, f1.tbxMtoCheq.Text), ",", "") & "," & 0 & ")")
                    End If

                End If


            End If

            swguar = 1
        Catch ex As Exception
            MsgBox("Error en funcion guardaActProyeDFact" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
        swguar = 0
        swctaFac = 0
    End Sub

    Sub guardaActProyeDFactf7()
        Try
            Dim strDFact As New ADODB.Recordset
            ConexionSQL()

            '   If FactNro = "" And RecNro = "" Then

            strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo='' ")

            If strDFact.EOF = False Then
                '    cntSQL.Execute("UPDATE [tab_Aux_FactProy] SET [pro_NroContrato]='" & ContNro & "', " _
                '                    & " [pro_NroRecibo]='" & f7.tbxNroReci.Text & "', " _
                '                    & " [pro_nroProyecto]='" & ProyNro & "', " _
                '                    & " [pro_FechaRes]= '" & Format(f7.dtpFecFac.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_NroFactura]='" & FactNro & "', " _
                '                    & " [pro_FechaFact]='" & Format(f7.dtpFecREC.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_trabajoFac]=" & Replace(IIf(f7.tbxFac.Text = "", 0, f7.tbxFac.Text), ",", "") & ", " _
                '                    & " [pro_Rete10]='" & f7.cmbRe10.SelectedIndex & "', " _
                '                    & " [pro_MtoRete10]= " & Replace(IIf(f7.tbxMtoRet.Text = "", 0, f7.tbxMtoRet.Text), ",", "") & ", " _
                '                    & " [pro_Anticipo]=" & Replace(IIf(f7.tbxAntMont.Text = "", 0, f7.tbxAntMont.Text), ",", "") & ", " _
                '                    & " [pro_Penalizacion]=" & Replace(IIf(f7.tbxPena.Text = "", 0, f7.tbxPena.Text), ",", "") & ", " _
                '                    & " [pro_RETdeITBMS]=" & Replace(IIf(f7.tbxRetMtoITBMS.Text = "", 0, f7.tbxRetMtoITBMS.Text), ",", "") & ", " _
                '                    & " [pro_MontoITBMS]=" & Replace(IIf(f7.tbxMtoITBMS.Text = "", 0, f7.tbxMtoITBMS.Text), ",", "") & ", " _
                '                    & " [pro_CuentaCobrar]=" & Replace(IIf(f7.tbxCxC.Text = "", 0, f7.tbxCxC.Text), ",", "") & ", " _
                '                    & " [pro_EntrInsp]='" & f7.cmbEnInsp.SelectedIndex & "', " _
                '                    & " [pro_FechaCliente]='" & Format(f7.dtpFecEnt.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_FechaCxc]='" & Format(f7.dtpCXC.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_FechaTes]='" & Format(f7.dtpFecTe.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_FechaPago]='" & Format(f7.dtpFecPago.Value, "yyyyMMdd") & "', " _
                '                      & " pro_montoCheque=" & Replace(IIf(f7.tbxMtoCheq.Text = "", 0, f7.tbxMtoCheq.Text), ",", "") & " " _
                '                    & "  where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo=''")

                'Else
                '    cntSQL.Execute("insert into [tab_Aux_FactProy] ([pro_idProyecto] ,pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo],[pro_FechaRes],[pro_NroFactura]" _
                '                     & " ,[pro_FechaFact],[pro_trabajoFac],[pro_Rete10],[pro_MtoRete10],[pro_Anticipo],[pro_Penalizacion]" _
                '                     & " ,[pro_RETdeITBMS],[pro_MontoITBMS],[pro_CuentaCobrar],[pro_EntrInsp],[pro_FechaCliente],[pro_FechaCxc]" _
                '                     & " ,[pro_FechaTes],[pro_FechaPago],pro_montoCheque, pro_manual) VALUES " _
                '                     & "( " & stridProy & ", " _
                '                      & " '" & ProyNro & "', " _
                '                     & " '" & ContNro & "', " _
                '                     & " '" & RecNro & "', " _
                '                     & " '" & Format(f7.dtpFecFac.Value, "yyyyMMdd") & "', " _
                '                     & " '" & FactNro & "', " _
                '                     & " '" & Format(f7.dtpFecREC.Value, "yyyyMMdd") & "', " _
                '                     & " " & Replace(IIf(f7.tbxFac.Text = "", 0, f7.tbxFac.Text), ",", "") & "," _
                '                     & " " & f7.cmbRe10.SelectedIndex & "," _
                '                     & " " & Replace(IIf(f7.tbxMtoRet.Text = "", 0, f7.tbxMtoRet.Text), ",", "") & ", " _
                '                     & " " & Replace(IIf(f7.tbxAntMont.Text = "", 0, f7.tbxAntMont.Text), ",", "") & ", " _
                '                     & " " & Replace(IIf(f7.tbxPena.Text = "", 0, f7.tbxPena.Text), ",", "") & ", " _
                '                     & " " & Replace(IIf(f7.tbxRetMtoITBMS.Text = "", 0, f7.tbxRetMtoITBMS.Text), ",", "") & ",  " _
                '                     & " " & Replace(IIf(f7.tbxMtoITBMS.Text = "", 0, f7.tbxMtoITBMS.Text), ",", "") & ",  " _
                '                     & " " & Replace(IIf(f7.tbxCxC.Text = "", 0, f7.tbxCxC.Text), ",", "") & " ," _
                '                     & " " & f7.cmbEnInsp.SelectedIndex & "," _
                '                     & "'" & Format(f7.dtpFecEnt.Value, "yyyyMMdd") & "'  ," _
                '                     & " '" & Format(f7.dtpCXC.Value, "yyyyMMdd") & "' ," _
                '                     & " '" & Format(f7.dtpFecTe.Value, "yyyyMMdd") & "' ," _
                '                     & " '" & Format(f7.dtpFecPago.Value, "yyyyMMdd") & "',  " _
                '                         & " " & Replace(IIf(f7.tbxMtoCheq.Text = "", 0, f7.tbxMtoCheq.Text), ",", "") & "," & 0 & ")")
                'End If


            End If


            '  If FactNro <> "" And RecNro = "" Then
            strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='' ")

            If strDFact.EOF = False Then
                '    cntSQL.Execute("UPDATE [tab_Aux_FactProy] SET [pro_NroContrato]='" & ContNro & "', " _
                '                    & " [pro_NroRecibo]='" & f7.tbxNroReci.Text & "', " _
                '                     & " [pro_nroProyecto]='" & ProyNro & "', " _
                '                    & " [pro_FechaRes]= '" & Format(f7.dtpFecFac.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_NroFactura]='" & f7.tbxNroFac.Text & "', " _
                '                    & " [pro_FechaFact]='" & Format(f7.dtpFecREC.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_trabajoFac]=" & Replace(IIf(f7.tbxFac.Text = "", 0, f7.tbxFac.Text), ",", "") & ", " _
                '                    & " [pro_Rete10]='" & f7.cmbRe10.SelectedIndex & "', " _
                '                    & " [pro_MtoRete10]= " & Replace(IIf(f7.tbxMtoRet.Text = "", 0, f7.tbxMtoRet.Text), ",", "") & ", " _
                '                    & " [pro_Anticipo]=" & Replace(IIf(f7.tbxAntMont.Text = "", 0, f7.tbxAntMont.Text), ",", "") & ", " _
                '                    & " [pro_Penalizacion]=" & Replace(IIf(f7.tbxPena.Text = "", 0, f7.tbxPena.Text), ",", "") & ", " _
                '                    & " [pro_RETdeITBMS]=" & Replace(IIf(f7.tbxRetMtoITBMS.Text = "", 0, f7.tbxRetMtoITBMS.Text), ",", "") & ", " _
                '                    & " [pro_MontoITBMS]=" & Replace(IIf(f7.tbxMtoITBMS.Text = "", 0, f7.tbxMtoITBMS.Text), ",", "") & ", " _
                '                    & " [pro_CuentaCobrar]=" & Replace(IIf(f7.tbxCxC.Text = "", 0, f7.tbxCxC.Text), ",", "") & ", " _
                '                    & " [pro_EntrInsp]='" & f7.cmbEnInsp.SelectedIndex & "', " _
                '                    & " [pro_FechaCliente]='" & Format(f7.dtpFecEnt.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_FechaCxc]='" & Format(f7.dtpCXC.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_FechaTes]='" & Format(f7.dtpFecTe.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_FechaPago]='" & Format(f7.dtpFecPago.Value, "yyyyMMdd") & "', " _
                '                      & " pro_montoCheque=" & Replace(IIf(f7.tbxMtoCheq.Text = "", 0, f7.tbxMtoCheq.Text), ",", "") & " " _
                '                    & "  where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo=''")

                'Else
                '    cntSQL.Execute("insert into [tab_Aux_FactProy] ([pro_idProyecto] ,pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo],[pro_FechaRes],[pro_NroFactura]" _
                '                     & " ,[pro_FechaFact],[pro_trabajoFac],[pro_Rete10],[pro_MtoRete10],[pro_Anticipo],[pro_Penalizacion]" _
                '                     & " ,[pro_RETdeITBMS],[pro_MontoITBMS],[pro_CuentaCobrar],[pro_EntrInsp],[pro_FechaCliente],[pro_FechaCxc]" _
                '                     & " ,[pro_FechaTes],[pro_FechaPago],pro_montoCheque, pro_manual) VALUES " _
                '                     & "( " & stridProy & ", " _
                '                      & " '" & ProyNro & "', " _
                '                     & " '" & ContNro & "', " _
                '                     & " '" & RecNro & "', " _
                '                     & " '" & Format(f7.dtpFecFac.Value, "yyyyMMdd") & "', " _
                '                     & " '" & FactNro & "', " _
                '                     & " '" & Format(f7.dtpFecREC.Value, "yyyyMMdd") & "', " _
                '                     & " " & Replace(IIf(f7.tbxFac.Text = "", 0, f7.tbxFac.Text), ",", "") & "," _
                '                     & " " & f7.cmbRe10.SelectedIndex & "," _
                '                     & " " & Replace(IIf(f7.tbxMtoRet.Text = "", 0, f7.tbxMtoRet.Text), ",", "") & ", " _
                '                     & " " & Replace(IIf(f7.tbxAntMont.Text = "", 0, f7.tbxAntMont.Text), ",", "") & ", " _
                '                     & " " & Replace(IIf(f7.tbxPena.Text = "", 0, f7.tbxPena.Text), ",", "") & ", " _
                '                     & " " & Replace(IIf(f7.tbxRetMtoITBMS.Text = "", 0, f7.tbxRetMtoITBMS.Text), ",", "") & ",  " _
                '                     & " " & Replace(IIf(f7.tbxMtoITBMS.Text = "", 0, f7.tbxMtoITBMS.Text), ",", "") & ",  " _
                '                     & " " & Replace(IIf(f7.tbxCxC.Text = "", 0, f7.tbxCxC.Text), ",", "") & " ," _
                '                     & " " & f7.cmbEnInsp.SelectedIndex & "," _
                '                     & "'" & Format(f7.dtpFecEnt.Value, "yyyyMMdd") & "'  ," _
                '                     & " '" & Format(f7.dtpCXC.Value, "yyyyMMdd") & "' ," _
                '                     & " '" & Format(f7.dtpFecTe.Value, "yyyyMMdd") & "' ," _
                '                     & " '" & Format(f7.dtpFecPago.Value, "yyyyMMdd") & "',  " _
                '                         & " " & Replace(IIf(f7.tbxMtoCheq.Text = "", 0, f7.tbxMtoCheq.Text), ",", "") & "," & 0 & ")")
                'End If



            End If



            ' If FactNro <> "" And RecNro <> "" Then
            strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & RecNro & "' ")

            If strDFact.EOF = False Then
                '    cntSQL.Execute("UPDATE [tab_Aux_FactProy] SET [pro_NroContrato]='" & ContNro & "', " _
                '                    & " [pro_NroRecibo]='" & f7.tbxNroReci.Text & "', " _
                '                     & " [pro_nroProyecto]='" & ProyNro & "', " _
                '                    & " [pro_FechaRes]= '" & Format(f7.dtpFecFac.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_NroFactura]='" & f7.tbxNroFac.Text & "', " _
                '                    & " [pro_FechaFact]='" & Format(f7.dtpFecREC.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_trabajoFac]=" & Replace(IIf(f7.tbxFac.Text = "", 0, f7.tbxFac.Text), ",", "") & ", " _
                '                    & " [pro_Rete10]='" & f7.cmbRe10.SelectedIndex & "', " _
                '                    & " [pro_MtoRete10]= " & Replace(IIf(f7.tbxMtoRet.Text = "", 0, f7.tbxMtoRet.Text), ",", "") & ", " _
                '                    & " [pro_Anticipo]=" & Replace(IIf(f7.tbxAntMont.Text = "", 0, f7.tbxAntMont.Text), ",", "") & ", " _
                '                    & " [pro_Penalizacion]=" & Replace(IIf(f7.tbxPena.Text = "", 0, f7.tbxPena.Text), ",", "") & ", " _
                '                    & " [pro_RETdeITBMS]=" & Replace(IIf(f7.tbxRetMtoITBMS.Text = "", 0, f7.tbxRetMtoITBMS.Text), ",", "") & ", " _
                '                    & " [pro_MontoITBMS]=" & Replace(IIf(f7.tbxMtoITBMS.Text = "", 0, f7.tbxMtoITBMS.Text), ",", "") & ", " _
                '                    & " [pro_CuentaCobrar]=" & Replace(IIf(f7.tbxCxC.Text = "", 0, f7.tbxCxC.Text), ",", "") & ", " _
                '                    & " [pro_EntrInsp]='" & f7.cmbEnInsp.SelectedIndex & "', " _
                '                    & " [pro_FechaCliente]='" & Format(f7.dtpFecEnt.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_FechaCxc]='" & Format(f7.dtpCXC.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_FechaTes]='" & Format(f7.dtpFecTe.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_FechaPago]='" & Format(f7.dtpFecPago.Value, "yyyyMMdd") & "', " _
                '                    & " pro_montoCheque=" & Replace(IIf(f7.tbxMtoCheq.Text = "", 0, f7.tbxMtoCheq.Text), ",", "") & "" _
                '                    & "  where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and  pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & RecNro & "'")

                'Else
                '    cntSQL.Execute("insert into [tab_Aux_FactProy] ([pro_idProyecto] ,pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo],[pro_FechaRes],[pro_NroFactura]" _
                '                     & " ,[pro_FechaFact],[pro_trabajoFac],[pro_Rete10],[pro_MtoRete10],[pro_Anticipo],[pro_Penalizacion]" _
                '                     & " ,[pro_RETdeITBMS],[pro_MontoITBMS],[pro_CuentaCobrar],[pro_EntrInsp],[pro_FechaCliente],[pro_FechaCxc]" _
                '                     & " ,[pro_FechaTes],[pro_FechaPago],pro_montoCheque, pro_manual) VALUES " _
                '                     & "( " & stridProy & ", " _
                '                      & " '" & ProyNro & "', " _
                '                     & " '" & ContNro & "', " _
                '                     & " '" & RecNro & "', " _
                '                     & " '" & Format(f7.dtpFecFac.Value, "yyyyMMdd") & "', " _
                '                     & " '" & FactNro & "', " _
                '                     & " '" & Format(f7.dtpFecREC.Value, "yyyyMMdd") & "', " _
                '                     & " " & Replace(IIf(f7.tbxFac.Text = "", 0, f7.tbxFac.Text), ",", "") & "," _
                '                     & " " & f7.cmbRe10.SelectedIndex & "," _
                '                     & " " & Replace(IIf(f7.tbxMtoRet.Text = "", 0, f7.tbxMtoRet.Text), ",", "") & ", " _
                '                     & " " & Replace(IIf(f7.tbxAntMont.Text = "", 0, f7.tbxAntMont.Text), ",", "") & ", " _
                '                     & " " & Replace(IIf(f7.tbxPena.Text = "", 0, f7.tbxPena.Text), ",", "") & ", " _
                '                     & " " & Replace(IIf(f7.tbxRetMtoITBMS.Text = "", 0, f7.tbxRetMtoITBMS.Text), ",", "") & ",  " _
                '                     & " " & Replace(IIf(f7.tbxMtoITBMS.Text = "", 0, f7.tbxMtoITBMS.Text), ",", "") & ",  " _
                '                     & " " & Replace(IIf(f7.tbxCxC.Text = "", 0, f7.tbxCxC.Text), ",", "") & " ," _
                '                     & " " & f7.cmbEnInsp.SelectedIndex & "," _
                '                     & "'" & Format(f7.dtpFecEnt.Value, "yyyyMMdd") & "'  ," _
                '                     & " '" & Format(f7.dtpCXC.Value, "yyyyMMdd") & "' ," _
                '                     & " '" & Format(f7.dtpFecTe.Value, "yyyyMMdd") & "' ," _
                '                     & " '" & Format(f7.dtpFecPago.Value, "yyyyMMdd") & "',  " _
                '                         & " " & Replace(IIf(f7.tbxMtoCheq.Text = "", 0, f7.tbxMtoCheq.Text), ",", "") & "," & 0 & ")")
                'End If

            End If




            swguar = 1
        Catch ex As Exception
            MsgBox("Error en funcion guardaActProyeDFact" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
        swguar = 0
    End Sub

    Sub guardaActProyeDFact15()
        Dim strDFact As New ADODB.Recordset
        ConexionSQL()
        Try

            If CtaNro = 1 And swctaFac = 1 Then
                strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo='' ")

                If strDFact.EOF = False Then
                    cntSQL.Execute("UPDATE [tab_Aux_FactProy] SET [pro_NroContrato]='" & ContNro & "', " _
                                    & " [pro_NroRecibo]='" & f15.tbxNroReci.Text & "', " _
                                    & " [pro_nroProyecto]='" & ProyNro & "', " _
                                    & " [pro_FechaRes]= '" & Format(f15.dtpFecREC.Value, "yyyyMMdd") & "', " _
                                    & " [pro_NroFactura]='" & FactNro & "', " _
                                    & " [pro_FechaFact]='" & Format(f15.dtpFecFac.Value, "yyyyMMdd") & "', " _
                                    & " [pro_trabajoFac]=" & Replace(IIf(f15.tbxFac.Text = "", 0, f15.tbxFac.Text), ",", "") & ", " _
                                    & " [pro_Rete10]='" & f15.cmbRe10.SelectedIndex & "', " _
                                    & " [pro_MtoRete10]= " & Replace(IIf(f15.tbxMtoRet.Text = "", 0, f15.tbxMtoRet.Text), ",", "") & ", " _
                                    & " [pro_Anticipo]=" & Replace(IIf(f15.tbxAntMont.Text = "", 0, f15.tbxAntMont.Text), ",", "") & ", " _
                                    & " [pro_Penalizacion]=" & Replace(IIf(f15.tbxPena.Text = "", 0, f15.tbxPena.Text), ",", "") & ", " _
                                    & " [pro_RETdeITBMS]=" & Replace(IIf(f15.tbxRetMtoITBMS.Text = "", 0, f15.tbxRetMtoITBMS.Text), ",", "") & ", " _
                                    & " [pro_MontoITBMS]=" & Replace(IIf(f15.tbxMtoITBMS.Text = "", 0, f15.tbxMtoITBMS.Text), ",", "") & ", " _
                                    & " [pro_CuentaCobrar]=" & Replace(IIf(f15.tbxCxC.Text = "", 0, f15.tbxCxC.Text), ",", "") & ", " _
                                    & " [pro_EntrInsp]='" & f15.cmbEnInsp.SelectedIndex & "', " _
                                    & " [pro_FechaCliente]='" & Format(f15.dtpFecEnt.Value, "yyyyMMdd") & "', " _
                                    & " [pro_FechaCxc]='" & Format(f15.dtpCXC.Value, "yyyyMMdd") & "', " _
                                    & " [pro_FechaTes]='" & Format(f15.dtpFecTe.Value, "yyyyMMdd") & "', " _
                                    & " [pro_FechaentrCGR]='" & Format(f15.dtpCgr.Value, "yyyyMMdd") & "', " _
                                    & " [pro_FechaPago]='" & Format(f15.dtpFecPago.Value, "yyyyMMdd") & "' " _
                                    & " pro_montoCheque=" & Replace(IIf(f15.tbxMtoCheq.Text = "", 0, f15.tbxMtoCheq.Text), ",", "") & " " _
                                    & "  where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo=''")

                Else
                    'cntSQL.Execute("insert into [tab_Aux_FactProy] ([pro_idProyecto], pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo],[pro_FechaRes],[pro_NroFactura]" _
                    '                     & " ,[pro_FechaFact],[pro_trabajoFac],[pro_Rete10],[pro_MtoRete10],[pro_Anticipo],[pro_Penalizacion]" _
                    '                     & " ,[pro_RETdeITBMS],[pro_MontoITBMS],[pro_CuentaCobrar],[pro_EntrInsp],[pro_FechaCliente],[pro_FechaCxc]" _
                    '                     & " ,[pro_FechaTes],[pro_FechaPago], pro_montoCheque, pro_manual) VALUES " _
                    '                     & "( " & stridProy & ", " _
                    '                     & " '" & ProyNro & "', " _
                    '                     & " '" & ContNro & "', " _
                    '                     & " '" & f15.tbxNroReci.Text & "', " _
                    '                     & " '" & Format(f1.dtpFecREC.Value, "yyyyMMdd") & "', " _
                    '                     & " '" & FactNro & "', " _
                    '                     & " '" & Format(f15.dtpFecFac.Value, "yyyyMMdd") & "', " _
                    '                     & " " & Replace(IIf(f15.tbxFac.Text = "", 0, f15.tbxFac.Text), ",", "") & "," _
                    '                     & " " & f15.cmbRe10.SelectedIndex & "," _
                    '                     & " " & Replace(IIf(f15.tbxMtoRet.Text = "", 0, f15.tbxMtoRet.Text), ",", "") & ", " _
                    '                     & " " & Replace(IIf(f15.tbxAntMont.Text = "", 0, f15.tbxAntMont.Text), ",", "") & ", " _
                    '                     & " " & Replace(IIf(f15.tbxPena.Text = "", 0, f15.tbxPena.Text), ",", "") & ", " _
                    '                     & " " & Replace(IIf(f15.tbxRetMtoITBMS.Text = "", 0, f15.tbxRetMtoITBMS.Text), ",", "") & ",  " _
                    '                     & " " & Replace(IIf(f15.tbxMtoITBMS.Text = "", 0, f15.tbxMtoITBMS.Text), ",", "") & ",  " _
                    '                     & " " & Replace(IIf(f15.tbxCxC.Text = "", 0, f15.tbxCxC.Text), ",", "") & " ," _
                    '                     & " " & f15.cmbEnInsp.SelectedIndex & "," _
                    '                     & "'" & Format(f15.dtpFecEnt.Value, "yyyyMMdd") & "'  ," _
                    '                     & " '" & Format(f15.dtpCXC.Value, "yyyyMMdd") & "' ," _
                    '                     & " '" & Format(f15.dtpFecTe.Value, "yyyyMMdd") & "' ," _
                    '                     & " '" & Format(f15.dtpFecPago.Value, "yyyyMMdd") & "',  " _
                    '                     & " " & Replace(IIf(f15.tbxMtoCheq.Text = "", 0, f15.tbxMtoCheq.Text), ",", "") & "," & 0 & ")")
                End If

            Else
                If FactNro = "" And RecNro = "" Then

                    strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo='' ")

                    If strDFact.EOF = False Then
                        cntSQL.Execute("UPDATE [tab_Aux_FactProy] SET [pro_NroContrato]='" & ContNro & "', " _
                                        & " [pro_NroRecibo]='" & f15.tbxNroReci.Text & "', " _
                                         & " [pro_nroProyecto]='" & ProyNro & "', " _
                                        & " [pro_FechaRes]= '" & Format(f15.dtpFecREC.Value, "yyyyMMdd") & "', " _
                                        & " [pro_NroFactura]='" & FactNro & "', " _
                                        & " [pro_FechaFact]='" & Format(f15.dtpFecFac.Value, "yyyyMMdd") & "', " _
                                        & " [pro_trabajoFac]=" & Replace(IIf(f15.tbxFac.Text = "", 0, f15.tbxFac.Text), ",", "") & ", " _
                                        & " [pro_Rete10]='" & f15.cmbRe10.SelectedIndex & "', " _
                                        & " [pro_MtoRete10]= " & Replace(IIf(f15.tbxMtoRet.Text = "", 0, f15.tbxMtoRet.Text), ",", "") & ", " _
                                        & " [pro_Anticipo]=" & Replace(IIf(f15.tbxAntMont.Text = "", 0, f15.tbxAntMont.Text), ",", "") & ", " _
                                        & " [pro_Penalizacion]=" & Replace(IIf(f15.tbxPena.Text = "", 0, f15.tbxPena.Text), ",", "") & ", " _
                                        & " [pro_RETdeITBMS]=" & Replace(IIf(f15.tbxRetMtoITBMS.Text = "", 0, f15.tbxRetMtoITBMS.Text), ",", "") & ", " _
                                        & " [pro_MontoITBMS]=" & Replace(IIf(f15.tbxMtoITBMS.Text = "", 0, f15.tbxMtoITBMS.Text), ",", "") & ", " _
                                        & " [pro_CuentaCobrar]=" & Replace(IIf(f15.tbxCxC.Text = "", 0, f15.tbxCxC.Text), ",", "") & ", " _
                                        & " [pro_EntrInsp]='" & f15.cmbEnInsp.SelectedIndex & "', " _
                                        & " [pro_FechaCliente]='" & Format(f15.dtpFecEnt.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaCxc]='" & Format(f15.dtpCXC.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaTes]='" & Format(f15.dtpFecTe.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaentrCGR]='" & Format(f15.dtpCgr.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaPago]='" & Format(f15.dtpFecPago.Value, "yyyyMMdd") & "', " _
                                          & " pro_montoCheque=" & Replace(IIf(f15.tbxMtoCheq.Text = "", 0, f15.tbxMtoCheq.Text), ",", "") & " " _
                                        & "  where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo=''")

                    Else
                        'cntSQL.Execute("insert into [tab_Aux_FactProy] ([pro_idProyecto], pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo],[pro_FechaRes],[pro_NroFactura]" _
                        '                 & " ,[pro_FechaFact],[pro_trabajoFac],[pro_Rete10],[pro_MtoRete10],[pro_Anticipo],[pro_Penalizacion]" _
                        '                 & " ,[pro_RETdeITBMS],[pro_MontoITBMS],[pro_CuentaCobrar],[pro_EntrInsp],[pro_FechaCliente],[pro_FechaCxc]" _
                        '                 & " ,[pro_FechaTes],[pro_FechaPago],pro_montoCheque, pro_manual) VALUES " _
                        '                 & "( " & stridProy & ", " _
                        '                 & " '" & ProyNro & "', " _
                        '                & " '" & ContNro & "', " _
                        '                 & " '" & f15.tbxNroReci.Text & "', " _
                        '                 & " '" & Format(f1.dtpFecREC.Value, "yyyyMMdd") & "', " _
                        '                 & " '" & FactNro & "', " _
                        '                 & " '" & Format(f15.dtpFecFac.Value, "yyyyMMdd") & "', " _
                        '                 & " " & Replace(IIf(f15.tbxFac.Text = "", 0, f15.tbxFac.Text), ",", "") & "," _
                        '                 & " " & f15.cmbRe10.SelectedIndex & "," _
                        '                 & " " & Replace(IIf(f15.tbxMtoRet.Text = "", 0, f15.tbxMtoRet.Text), ",", "") & ", " _
                        '                 & " " & Replace(IIf(f15.tbxAntMont.Text = "", 0, f15.tbxAntMont.Text), ",", "") & ", " _
                        '                 & " " & Replace(IIf(f15.tbxPena.Text = "", 0, f15.tbxPena.Text), ",", "") & ", " _
                        '                 & " " & Replace(IIf(f15.tbxRetMtoITBMS.Text = "", 0, f15.tbxRetMtoITBMS.Text), ",", "") & ",  " _
                        '                 & " " & Replace(IIf(f15.tbxMtoITBMS.Text = "", 0, f15.tbxMtoITBMS.Text), ",", "") & ",  " _
                        '                 & " " & Replace(IIf(f15.tbxCxC.Text = "", 0, f15.tbxCxC.Text), ",", "") & " ," _
                        '                 & " " & f15.cmbEnInsp.SelectedIndex & "," _
                        '                 & "'" & Format(f15.dtpFecEnt.Value, "yyyyMMdd") & "'  ," _
                        '                 & " '" & Format(f15.dtpCXC.Value, "yyyyMMdd") & "' ," _
                        '                 & " '" & Format(f15.dtpFecTe.Value, "yyyyMMdd") & "' ," _
                        '                 & " '" & Format(f15.dtpFecPago.Value, "yyyyMMdd") & "',  " _
                        '                 & " " & Replace(IIf(f15.tbxMtoCheq.Text = "", 0, f15.tbxMtoCheq.Text), ",", "") & "," & 0 & ")")
                    End If


                End If


                If FactNro <> "" And RecNro = "" Then
                    strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='' ")

                    If strDFact.EOF = False Then
                        cntSQL.Execute("UPDATE [tab_Aux_FactProy] SET [pro_NroContrato]='" & ContNro & "', " _
                                        & " [pro_NroRecibo]='" & f15.tbxNroReci.Text & "', " _
                                         & " [pro_nroProyecto]='" & ProyNro & "', " _
                                        & " [pro_FechaRes]= '" & Format(f15.dtpFecREC.Value, "yyyyMMdd") & "', " _
                                        & " [pro_NroFactura]='" & f15.tbxNroFac.Text & "', " _
                                        & " [pro_FechaFact]='" & Format(f15.dtpFecFac.Value, "yyyyMMdd") & "', " _
                                        & " [pro_trabajoFac]=" & Replace(IIf(f15.tbxFac.Text = "", 0, f15.tbxFac.Text), ",", "") & ", " _
                                        & " [pro_Rete10]='" & f15.cmbRe10.SelectedIndex & "', " _
                                        & " [pro_MtoRete10]= " & Replace(IIf(f15.tbxMtoRet.Text = "", 0, f15.tbxMtoRet.Text), ",", "") & ", " _
                                        & " [pro_Anticipo]=" & Replace(IIf(f15.tbxAntMont.Text = "", 0, f15.tbxAntMont.Text), ",", "") & ", " _
                                        & " [pro_Penalizacion]=" & Replace(IIf(f15.tbxPena.Text = "", 0, f15.tbxPena.Text), ",", "") & ", " _
                                        & " [pro_RETdeITBMS]=" & Replace(IIf(f15.tbxRetMtoITBMS.Text = "", 0, f15.tbxRetMtoITBMS.Text), ",", "") & ", " _
                                        & " [pro_MontoITBMS]=" & Replace(IIf(f15.tbxMtoITBMS.Text = "", 0, f15.tbxMtoITBMS.Text), ",", "") & ", " _
                                        & " [pro_CuentaCobrar]=" & Replace(IIf(f15.tbxCxC.Text = "", 0, f15.tbxCxC.Text), ",", "") & ", " _
                                        & " [pro_EntrInsp]='" & f15.cmbEnInsp.SelectedIndex & "', " _
                                        & " [pro_FechaCliente]='" & Format(f15.dtpFecEnt.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaCxc]='" & Format(f15.dtpCXC.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaTes]='" & Format(f15.dtpFecTe.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaentrCGR]='" & Format(f15.dtpCgr.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaPago]='" & Format(f15.dtpFecPago.Value, "yyyyMMdd") & "'," _
                                         & " pro_montoCheque=" & Replace(IIf(f15.tbxMtoCheq.Text = "", 0, f15.tbxMtoCheq.Text), ",", "") & " " _
                                        & "  where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo=''")

                    Else
                        'cntSQL.Execute("insert into [tab_Aux_FactProy] ([pro_idProyecto], pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo],[pro_FechaRes],[pro_NroFactura]" _
                        '                 & " ,[pro_FechaFact],[pro_trabajoFac],[pro_Rete10],[pro_MtoRete10],[pro_Anticipo],[pro_Penalizacion]" _
                        '                 & " ,[pro_RETdeITBMS],[pro_MontoITBMS],[pro_CuentaCobrar],[pro_EntrInsp],[pro_FechaCliente],[pro_FechaCxc]" _
                        '                 & " ,[pro_FechaTes],[pro_FechaPago],pro_montoCheque, pro_manual) VALUES " _
                        '                 & "( " & stridProy & ", " _
                        '                 & " '" & ProyNro & "', " _
                        '                 & " '" & ContNro & "', " _
                        '                 & " '" & f15.tbxNroReci.Text & "', " _
                        '                 & " '" & Format(f1.dtpFecREC.Value, "yyyyMMdd") & "', " _
                        '                 & " '" & FactNro & "', " _
                        '                 & " '" & Format(f15.dtpFecFac.Value, "yyyyMMdd") & "', " _
                        '                 & " " & Replace(IIf(f15.tbxFac.Text = "", 0, f15.tbxFac.Text), ",", "") & "," _
                        '                 & " " & f15.cmbRe10.SelectedIndex & "," _
                        '                 & " " & Replace(IIf(f15.tbxMtoRet.Text = "", 0, f15.tbxMtoRet.Text), ",", "") & ", " _
                        '                 & " " & Replace(IIf(f15.tbxAntMont.Text = "", 0, f15.tbxAntMont.Text), ",", "") & ", " _
                        '                 & " " & Replace(IIf(f15.tbxPena.Text = "", 0, f15.tbxPena.Text), ",", "") & ", " _
                        '                 & " " & Replace(IIf(f15.tbxRetMtoITBMS.Text = "", 0, f15.tbxRetMtoITBMS.Text), ",", "") & ",  " _
                        '                 & " " & Replace(IIf(f15.tbxMtoITBMS.Text = "", 0, f15.tbxMtoITBMS.Text), ",", "") & ",  " _
                        '                 & " " & Replace(IIf(f15.tbxCxC.Text = "", 0, f15.tbxCxC.Text), ",", "") & " ," _
                        '                 & " " & f15.cmbEnInsp.SelectedIndex & "," _
                        '                 & "'" & Format(f15.dtpFecEnt.Value, "yyyyMMdd") & "'  ," _
                        '                 & " '" & Format(f15.dtpCXC.Value, "yyyyMMdd") & "' ," _
                        '                 & " '" & Format(f15.dtpFecTe.Value, "yyyyMMdd") & "' ," _
                        '                 & " '" & Format(f15.dtpFecPago.Value, "yyyyMMdd") & "',  " _
                        '                 & " " & Replace(IIf(f15.tbxMtoCheq.Text = "", 0, f15.tbxMtoCheq.Text), ",", "") & "," & 0 & ")")
                    End If



                End If



                If FactNro <> "" And RecNro <> "" Then
                    strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & RecNro & "' ")

                    If strDFact.EOF = False Then
                        cntSQL.Execute("UPDATE [tab_Aux_FactProy] SET [pro_NroContrato]='" & ContNro & "', " _
                                        & " [pro_NroRecibo]='" & f15.tbxNroReci.Text & "', " _
                                         & " [pro_nroProyecto]='" & ProyNro & "', " _
                                        & " [pro_FechaRes]= '" & Format(f15.dtpFecREC.Value, "yyyyMMdd") & "', " _
                                        & " [pro_NroFactura]='" & f15.tbxNroFac.Text & "', " _
                                        & " [pro_FechaFact]='" & Format(f15.dtpFecFac.Value, "yyyyMMdd") & "', " _
                                        & " [pro_trabajoFac]=" & Replace(IIf(f15.tbxFac.Text = "", 0, f15.tbxFac.Text), ",", "") & ", " _
                                        & " [pro_Rete10]='" & f15.cmbRe10.SelectedIndex & "', " _
                                        & " [pro_MtoRete10]= " & Replace(IIf(f15.tbxMtoRet.Text = "", 0, f15.tbxMtoRet.Text), ",", "") & ", " _
                                        & " [pro_Anticipo]=" & Replace(IIf(f15.tbxAntMont.Text = "", 0, f15.tbxAntMont.Text), ",", "") & ", " _
                                        & " [pro_Penalizacion]=" & Replace(IIf(f15.tbxPena.Text = "", 0, f15.tbxPena.Text), ",", "") & ", " _
                                        & " [pro_RETdeITBMS]=" & Replace(IIf(f15.tbxRetMtoITBMS.Text = "", 0, f15.tbxRetMtoITBMS.Text), ",", "") & ", " _
                                        & " [pro_MontoITBMS]=" & Replace(IIf(f15.tbxMtoITBMS.Text = "", 0, f15.tbxMtoITBMS.Text), ",", "") & ", " _
                                        & " [pro_CuentaCobrar]=" & Replace(IIf(f15.tbxCxC.Text = "", 0, f15.tbxCxC.Text), ",", "") & ", " _
                                        & " [pro_EntrInsp]='" & f15.cmbEnInsp.SelectedIndex & "', " _
                                        & " [pro_FechaCliente]='" & Format(f15.dtpFecEnt.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaCxc]='" & Format(f15.dtpCXC.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaTes]='" & Format(f15.dtpFecTe.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaentrCGR]='" & Format(f15.dtpCgr.Value, "yyyyMMdd") & "', " _
                                        & " [pro_FechaPago]='" & Format(f15.dtpFecPago.Value, "yyyyMMdd") & "' ," _
                                         & " pro_montoCheque=" & Replace(IIf(f15.tbxMtoCheq.Text = "", 0, f15.tbxMtoCheq.Text), ",", "") & " " _
                                        & "  where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and  pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & RecNro & "'")

                    Else
                        'cntSQL.Execute("insert into [tab_Aux_FactProy] ([pro_idProyecto], pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo],[pro_FechaRes],[pro_NroFactura]" _
                        '                 & " ,[pro_FechaFact],[pro_trabajoFac],[pro_Rete10],[pro_MtoRete10],[pro_Anticipo],[pro_Penalizacion]" _
                        '                 & " ,[pro_RETdeITBMS],[pro_MontoITBMS],[pro_CuentaCobrar],[pro_EntrInsp],[pro_FechaCliente],[pro_FechaCxc]" _
                        '                 & " ,[pro_FechaTes],[pro_FechaPago], pro_montoCheque, pro_manual) VALUES " _
                        '                 & "( " & stridProy & ", " _
                        '                 & " '" & ProyNro & "', " _
                        '                 & " '" & ContNro & "', " _
                        '                 & " '" & f15.tbxNroReci.Text & "', " _
                        '                 & " '" & Format(f1.dtpFecREC.Value, "yyyyMMdd") & "', " _
                        '                 & " '" & FactNro & "', " _
                        '                 & " '" & Format(f15.dtpFecFac.Value, "yyyyMMdd") & "', " _
                        '                 & " " & Replace(IIf(f15.tbxFac.Text = "", 0, f15.tbxFac.Text), ",", "") & "," _
                        '                 & " " & f15.cmbRe10.SelectedIndex & "," _
                        '                 & " " & Replace(IIf(f15.tbxMtoRet.Text = "", 0, f15.tbxMtoRet.Text), ",", "") & ", " _
                        '                 & " " & Replace(IIf(f15.tbxAntMont.Text = "", 0, f15.tbxAntMont.Text), ",", "") & ", " _
                        '                 & " " & Replace(IIf(f15.tbxPena.Text = "", 0, f15.tbxPena.Text), ",", "") & ", " _
                        '                 & " " & Replace(IIf(f15.tbxRetMtoITBMS.Text = "", 0, f15.tbxRetMtoITBMS.Text), ",", "") & ",  " _
                        '                 & " " & Replace(IIf(f15.tbxMtoITBMS.Text = "", 0, f15.tbxMtoITBMS.Text), ",", "") & ",  " _
                        '                 & " " & Replace(IIf(f15.tbxCxC.Text = "", 0, f15.tbxCxC.Text), ",", "") & " ," _
                        '                 & " " & f15.cmbEnInsp.SelectedIndex & "," _
                        '                 & "'" & Format(f15.dtpFecEnt.Value, "yyyyMMdd") & "'  ," _
                        '                 & " '" & Format(f15.dtpCXC.Value, "yyyyMMdd") & "' ," _
                        '                 & " '" & Format(f15.dtpFecTe.Value, "yyyyMMdd") & "' ," _
                        '                 & " '" & Format(f15.dtpFecPago.Value, "yyyyMMdd") & "'),  " _
                        '                 & " " & Replace(IIf(f15.tbxMtoCheq.Text = "", 0, f15.tbxMtoCheq.Text), ",", "") & "," & 0 & ")")
                    End If

                End If




            End If


           

            swguar = 1
        Catch ex As Exception
            MsgBox("Error en funcion guardaActProyeDFactf15" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
        swguar = 0
        swctaFac = 0
    End Sub

    Sub guardaActProyeDFact25()
        Dim strDFact As New ADODB.Recordset
        ConexionSQL()
        Try

         

        


            If FactNro <> "" Then
                strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' ")

                If strDFact.EOF = False Then

                    MsgBox("Factura se encuentra registrada, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")

                Else
                    cntSQL.Execute("insert into [tab_Aux_FactProy] ([pro_idProyecto], pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo],[pro_FechaRes],[pro_NroFactura]" _
                                     & " ,[pro_FechaFact],[pro_trabajoFac],[pro_Rete10],[pro_MtoRete10],[pro_Anticipo],[pro_Penalizacion]" _
                                     & " ,[pro_RETdeITBMS],[pro_MontoITBMS],[pro_CuentaCobrar],[pro_EntrInsp],[pro_FechaCliente],[pro_FechaCxc]" _
                                     & " ,[pro_FechaTes],[pro_FechaPago],pro_montoCheque,pro_manual) VALUES " _
                                     & "( " & stridProy & ", " _
                                     & " '" & ProyNro & "', " _
                                     & " '" & ContNro & "', " _
                                     & " '" & f25.tbxNroReci.Text & "', " _
                                     & " '" & Format(f1.dtpFecREC.Value, "yyyyMMdd") & "', " _
                                     & " '" & FactNro & "', " _
                                     & " '" & Format(f25.dtpFecFac.Value, "yyyyMMdd") & "', " _
                                     & " " & Replace(IIf(f25.tbxFac.Text = "", 0, f25.tbxFac.Text), ",", "") & "," _
                                     & " " & 0 & "," _
                                     & " " & Replace(IIf(f25.tbxMtoRet.Text = "", 0, f25.tbxMtoRet.Text), ",", "") & ", " _
                                     & " " & Replace(IIf(f25.tbxAntMont.Text = "", 0, f25.tbxAntMont.Text), ",", "") & ", " _
                                     & " " & Replace(IIf(f25.tbxPena.Text = "", 0, f25.tbxPena.Text), ",", "") & ", " _
                                     & " " & Replace(IIf(f25.tbxRetMtoITBMS.Text = "", 0, f25.tbxRetMtoITBMS.Text), ",", "") & ",  " _
                                     & " " & Replace(IIf(f25.tbxMtoITBMS.Text = "", 0, f25.tbxMtoITBMS.Text), ",", "") & ",  " _
                                     & " " & Replace(IIf(f25.tbxCxC.Text = "", 0, f25.tbxCxC.Text), ",", "") & " ," _
                                     & " " & f25.cmbEnInsp.SelectedIndex & "," _
                                     & "'" & Format(f25.dtpFecEnt.Value, "yyyyMMdd") & "'  ," _
                                     & " '" & Format(f25.dtpCXC.Value, "yyyyMMdd") & "' ," _
                                     & " '" & Format(f25.dtpFecTe.Value, "yyyyMMdd") & "' ," _
                                     & " '" & Format(f25.dtpFecPago.Value, "yyyyMMdd") & "',  " _
                                     & " " & 0 & ", " _
                                     & " " & 1 & ")")


                    clearDCostos15()
                    clearDfact15()
                    f25.llenarFactPagosf25()
                    f25.clearDfact25()
                    f25.Close()

                End If



            End If



            swguar = 1
        Catch ex As Exception
            MsgBox("Error en funcion guardaActProyeDFactf25" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
        swguar = 0
        swCtaFac = 0
    End Sub

    Sub eliminaProyeDFact25()
        Dim strDFact As New ADODB.Recordset
        Dim preg As String = ""
        ConexionSQL()
        Try

            If FactNro <> "" Then
                strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' ")

                If strDFact.EOF = False Then
                    preg = MsgBox("Seguro que desea eliminar la Factura?", MsgBoxStyle.YesNo, "Control Proyectos")

                    If preg = 6 Then

                        cntSQL.Execute("delete from tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' ")
                        'eliminar los pagos
                        cntSQL.Execute("delete from tab_Rel_FacturasPagos where pro_NroContrato='" & ContNro & "' and pro_NroProyecto='" & ProyNro & "' and pro_NroFactura='" & FactNro & "'")
                        MsgBox("Factura Eliminada", MsgBoxStyle.Information, "Control Proyectos")
                        clearDCostos15()
                        clearDfact15()
                        f25.llenarFactPagosf25()
                        f25.clearDfact25()
                        f25.Close()
                    End If


                Else
                    MsgBox("Factura No se encuentra registrada, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")


                End If

            End If



            swguar = 1
        Catch ex As Exception
            MsgBox("Error en funcion guardaActProyeDFactf25" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
        swguar = 0
        swCtaFac = 0
    End Sub

    Sub ActProyeDFact25()
        Dim strDFact As New ADODB.Recordset
        ConexionSQL()
        Try

            If FactNro <> "" Then
                strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_FactProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "'  ")

                If strDFact.EOF = False Then


                    cntSQL.Execute("UPDATE [tab_Aux_FactProy] SET [pro_NroContrato]='" & ContNro & "', " _
                                    & " [pro_NroRecibo]='" & f25.tbxNroReci.Text & "', " _
                                     & " [pro_nroProyecto]='" & ProyNro & "', " _
                                    & " [pro_FechaRes]= '" & Format(f25.dtpFecREC.Value, "yyyyMMdd") & "', " _
                                    & " [pro_NroFactura]='" & f25.tbxNroFac.Text & "', " _
                                    & " [pro_FechaFact]='" & Format(f25.dtpFecFac.Value, "yyyyMMdd") & "', " _
                                    & " [pro_trabajoFac]=" & Replace(IIf(f25.tbxFac.Text = "", 0, f25.tbxFac.Text), ",", "") & ", " _
                                    & " [pro_Rete10]='" & 0 & "', " _
                                    & " [pro_MtoRete10]= " & Replace(IIf(f25.tbxMtoRet.Text = "", 0, f25.tbxMtoRet.Text), ",", "") & ", " _
                                    & " [pro_Anticipo]=" & Replace(IIf(f25.tbxAntMont.Text = "", 0, f25.tbxAntMont.Text), ",", "") & ", " _
                                    & " [pro_Penalizacion]=" & Replace(IIf(f25.tbxPena.Text = "", 0, f25.tbxPena.Text), ",", "") & ", " _
                                    & " [pro_RETdeITBMS]=" & Replace(IIf(f25.tbxRetMtoITBMS.Text = "", 0, f25.tbxRetMtoITBMS.Text), ",", "") & ", " _
                                    & " [pro_MontoITBMS]=" & Replace(IIf(f25.tbxMtoITBMS.Text = "", 0, f25.tbxMtoITBMS.Text), ",", "") & ", " _
                                    & " [pro_CuentaCobrar]=" & Replace(IIf(f25.tbxCxC.Text = "", 0, f25.tbxCxC.Text), ",", "") & ", " _
                                    & " [pro_EntrInsp]='" & f25.cmbEnInsp.SelectedIndex & "', " _
                                    & " [pro_FechaCliente]='" & Format(f25.dtpFecEnt.Value, "yyyyMMdd") & "', " _
                                    & " [pro_FechaCxc]='" & Format(f25.dtpCXC.Value, "yyyyMMdd") & "', " _
                                    & " [pro_FechaTes]='" & Format(f25.dtpFecTe.Value, "yyyyMMdd") & "', " _
                                    & " [pro_FechaPago]='" & Format(f25.dtpFecPago.Value, "yyyyMMdd") & "'," _
                                    & " pro_montoCheque=" & 0 & " ," _
                                    & " pro_manual =" & 1 & " " _
                                    & "  where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' ")


                    clearDCostos15()
                    clearDfact15()
                    f25.llenarFactPagosf25()
                    f25.clearDfact25()
                    f25.Close()

                Else
                    MsgBox("Facttura No se encuentra registrada, por favor verifique", MsgBoxStyle.Critical, "Control Proyectos")

                End If



            End If


            swguar = 1
        Catch ex As Exception
            MsgBox("Error en funcion ActProyeDFact25()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
        swguar = 0
        swCtaFac = 0
    End Sub



    Sub guardaActProyeEstCtas16()
        Dim strDFact As New ADODB.Recordset
        Dim cta As Integer = 0
        ConexionSQL()
        Try

            'budco el numero de cuenta
            strDFact = cntSQL.Execute("select max(pro_CtaNro) as pro_CtaNro from tab_Aux_EstCtasProy where pro_idProyecto='" & stridProy & "' and pro_NroProyecto='" & ProyNro & "' ")

            If strDFact.EOF = False Then
                cta = Val(IIf(strDFact.Fields("pro_CtaNro").Value Is DBNull.Value, 0, strDFact.Fields("pro_CtaNro").Value))
                cta += 1
            Else
                cta = 1
            End If


            strDFact = cntSQL.Execute("select pro_idProyecto from tab_Aux_EstCtasProy where pro_idProyecto='" & stridProy & "' and pro_NroProyecto='" & ProyNro & "'  and [pro_CtaNro]='" & f16.tbxCta.Text & "'")


            If strDFact.EOF = False Then
                cntSQL.Execute("UPDATE [tab_Aux_EstCtasProy] SET [pro_NroContrato]='" & ContNro & "', " _
                                & " [pro_PerCtas]= " & Replace(IIf(f16.tbxPerCta.Text = "", 0, f16.tbxPerCta.Text), ",", "") & ", " _
                                & " [pro_FechaEntScont]='" & Format(f16.dtpFecEntra.Value, "yyyyMMdd") & "', " _
                                & " [pro_Meta]=" & Replace(IIf(f16.tbxMeta.Text = "", 0, f16.tbxMeta.Text), ",", "") & ", " _
                                & " [pro_Meta1]=" & Replace(IIf(f16.tbxMeta1.Text = "", 0, f16.tbxMeta1.Text), ",", "") & ", " _
                                & " [pro_MetaFact]=" & Replace(IIf(f16.tbxMetFac.Text = "", 0, f16.tbxMetFac.Text), ",", "") & ", " _
                                & " [pro_porcCump]= " & Replace(IIf(f16.tbxCump.Text = "", 0, f16.tbxCump.Text), ",", "") & ", " _
                                & " [pro_FechaEntInsp]='" & Format(f16.dtpFechaEn.Value, "yyyyMMdd") & "', " _
                                & " [pro_MontoCtasInsp]=" & Replace(IIf(f16.tbxMont.Text = "", 0, f16.tbxMont.Text), ",", "") & ", " _
                                & " [pro_FechaCxc]='" & Format(f16.dtpFecEncxc.Value, "yyyyMMdd") & "', " _
                                & " [pro_MontoAproInsp]=" & Replace(IIf(f16.tbxMontoAp.Text = "", 0, f16.tbxMontoAp.Text), ",", "") & " " _
                                & "  where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "' and [pro_CtaNro]='" & f16.tbxCta.Text & "'")

            Else
                cntSQL.Execute("insert into [tab_Aux_EstCtasProy] ( [pro_idProyecto],[pro_NroProyecto],[pro_NroContrato],[pro_CtaNro],[pro_PerCtas]" _
                                & ",[pro_FechaEntScont] ,[pro_Meta],[pro_Meta1],[pro_MetaFact],[pro_porcCump],[pro_FechaEntInsp],[pro_MontoCtasInsp],[pro_FechaCxc],[pro_MontoAproInsp]) VALUES " _
                                & "( " & stridProy & ", " _
                                & " '" & ProyNro & "', " _
                                & " '" & ContNro & "', " _
                                & " '" & cta & "'," _
                                & " " & Replace(IIf(f16.tbxPerCta.Text = "", 0, f16.tbxPerCta.Text), ",", "") & ", " _
                                & " '" & Format(f16.dtpFecEntra.Value, "yyyyMMdd") & "', " _
                                & " " & Replace(IIf(f16.tbxMeta.Text = "", 0, f16.tbxMeta.Text), ",", "") & ", " _
                                & " " & Replace(IIf(f16.tbxMeta1.Text = "", 0, f16.tbxMeta1.Text), ",", "") & ", " _
                                & "" & Replace(IIf(f16.tbxMetFac.Text = "", 0, f16.tbxMetFac.Text), ",", "") & ", " _
                                & "  " & Replace(IIf(f16.tbxCump.Text = "", 0, f16.tbxCump.Text), ",", "") & ", " _
                                & "'" & Format(f16.dtpFechaEn.Value, "yyyyMMdd") & "', " _
                                & " " & Replace(IIf(f16.tbxMont.Text = "", 0, f16.tbxMont.Text), ",", "") & ", " _
                                & " '" & Format(f16.dtpFecEncxc.Value, "yyyyMMdd") & "', " _
                                & " " & Replace(IIf(f16.tbxMontoAp.Text = "", 0, f16.tbxMontoAp.Text), ",", "") & ")")
            End If



            swguar = 1
        Catch ex As Exception
            MsgBox("Error en funcion guardaActProyeEstCtas16()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
        swguar = 0
        swCtaFac = 0
    End Sub


    Sub guardaActProyeDResp()
        Try
            Dim strDResp As New ADODB.Recordset
            '  If ContNro = "" Then

            strDResp = cntSQL.Execute("SELECT [pro_idProyecto],[pro_NroContrato],[pro_NroRecibo],[pro_Contratista],[pro_Cliente]" _
                                   & ",[pro_Gerente],[pro_Ingeniero],[pro_CordCtasMop],[pro_Gobierno],[pro_EncGrupo]" _
                                   & ",[pro_Mtototal],[pro_FechaTreal],[pro_Fechaant],[pro_Mes],[pro_FechaPago],[pro_FechaPagoTra],pro_analistaCosto,pro_nroProyecto" _
                                   & " FROM [tab_Aux_EntesProy] where pro_idProyecto='" & stridProy & "'")

            If strDResp.EOF = False Then

             
                cntSQL.Execute("UPDATE [tab_Aux_EntesProy] SET [pro_NroContrato]='" & ContNro & "', " _
                                & " [pro_NroRecibo]='" & f1.tbxNroReci.Text & "', " _
                                & " [pro_Contratista]= '" & f1.tbxCont.Text & "', " _
                                & " [pro_Cliente]='" & f1.tbxClient.Text & "', " _
                                & " [pro_Gerente]='" & f1.tbxGProy.Text & "'," _
                                & " [pro_Ingeniero]='" & f1.tbxIng.Text & "', " _
                                & " [pro_CordCtasMop]='" & f1.tbxCorCMop.Text & "', " _
                                & " [pro_Gobierno]='" & f1.tbxGob.Text & "', " _
                                & " [pro_EncGrupo]='" & f1.tbxEncG.Text & "', " _
                                & " [pro_Mtototal]=" & Replace(IIf(f1.tbxMtoT.Text = "", 0, f1.tbxMtoT.Text), ",", "") & ", " _
                                & " [pro_FechaTreal]='" & Format(f1.dtpFecT.Value, "yyyyMMdd") & "', " _
                                & " [pro_Fechaant]='" & Format(f1.dtpAnAnt.Value, "yyyyMMdd") & "', " _
                                & " [pro_Mes]='" & f1.tbxMespro.Text & "', " _
                                & " [pro_FechaPago]='" & Format(f1.dtpfecTraFac.Value, "yyyyMMdd") & "', " _
                                & " [pro_FechaPagoTra]='" & Format(f1.dtpfecTraFac1.Value, "yyyyMMdd") & "', " _
                                & " [pro_analistaCosto]='" & f1.tbxAnalista.Text & "', " _
                                & " [pro_nroProyecto]='" & ProyNro & "' " _
                                & "  where pro_idProyecto='" & stridProy & "'")

            Else

                cntSQL.Execute("insert into tab_Aux_EntesProy ([pro_idProyecto],[pro_NroContrato],[pro_NroRecibo],[pro_Contratista],[pro_Cliente]" _
                                        & ",[pro_Gerente],[pro_Ingeniero],[pro_CordCtasMop],[pro_Gobierno],[pro_EncGrupo]" _
                                        & ",[pro_Mtototal],[pro_FechaTreal],[pro_Fechaant],[pro_Mes],[pro_FechaPago],[pro_FechaPagoTra],pro_analistaCosto, pro_nroProyecto) VALUES " _
                                        & "( " & stridProy & ", " _
                                        & " '" & ContNro & "', " _
                                        & " '" & f1.tbxNroReci.Text & "', " _
                                        & " '" & f1.tbxCont.Text & "', " _
                                        & " '" & f1.tbxClient.Text & "', " _
                                        & " '" & f1.tbxGProy.Text & "', " _
                                        & " '" & f1.tbxIng.Text & "', " _
                                        & " '" & f1.tbxCorCMop.Text & "', " _
                                        & " '" & f1.tbxGob.Text & "', " _
                                        & " '" & f1.tbxEncG.Text & "', " _
                                        & " '" & Replace(IIf(f1.tbxMtoT.Text = "", 0, f1.tbxMtoT.Text), ",", "") & "', " _
                                        & " '" & Format(f1.dtpFecT.Value, "yyyyMMdd") & "', " _
                                        & "'" & Format(f1.dtpAnAnt.Value, "yyyyMMdd") & "'," _
                                        & " '" & f1.tbxMespro.Text & "', " _
                                        & " '" & Format(f1.dtpfecTraFac.Value, "yyyyMMdd") & "', " _
                                        & "'" & Format(f1.dtpfecTraFac1.Value, "yyyyMMdd") & "','" & f1.tbxAnalista.Text & "','" & ProyNro & "')")
            End If



        Catch ex As Exception
            MsgBox("Error en funcion guardaActProyeDResp" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swguar = 1
        End Try

    End Sub

    Sub guardaActProyeDRespf7()
        Try
            Dim strDResp As New ADODB.Recordset
            '  If ContNro = "" Then

            strDResp = cntSQL.Execute("SELECT [pro_idProyecto],[pro_NroContrato],[pro_NroRecibo],[pro_Contratista],[pro_Cliente]" _
                                   & ",[pro_Gerente],[pro_Ingeniero],[pro_CordCtasMop],[pro_Gobierno],[pro_EncGrupo]" _
                                   & ",[pro_Mtototal],[pro_FechaTreal],[pro_Fechaant],[pro_Mes],[pro_FechaPago],[pro_FechaPagoTra],pro_analistaCosto,pro_nroProyecto " _
                                   & " FROM [tab_Aux_EntesProy] where pro_idProyecto='" & stridProy & "'")

            If strDResp.EOF = False Then

                cntSQL.Execute("UPDATE [tab_Aux_EntesProy] SET [pro_NroContrato]='" & f7.tbxNroCon.Text & "', " _
                                & " [pro_NroRecibo]=' 0 ', " _
                                & " [pro_Contratista]= '" & f7.tbxCont1.Text & "', " _
                                & " [pro_Cliente]='" & f7.tbxCliente.Text & "', " _
                                & " [pro_Gerente]='" & f7.tbxGProy1.Text & "'," _
                                & " [pro_Ingeniero]='" & f7.tbxIng1.Text & "', " _
                                & " [pro_CordCtasMop]='" & f7.tbxCorCMop1.Text & "', " _
                                & " [pro_Gobierno]='" & f7.tbxGob1.Text & "', " _
                                & " [pro_EncGrupo]='" & f7.tbxEncG1.Text & "', " _
                                & " [pro_Mtototal]=" & Replace(IIf(f7.tbxMtoT1.Text = "", 0, f7.tbxMtoT1.Text), ",", "") & ", " _
                                & " [pro_FechaTreal]='" & Format(f7.dtpFecT.Value, "yyyyMMdd") & "', " _
                                & " [pro_Fechaant]='" & Format(f7.dtpAnAnt1.Value, "yyyyMMdd") & "', " _
                                & " [pro_Mes]='" & f7.tbxMespro1.Text & "', " _
                                & " [pro_FechaPago]='" & Format(f7.dtpfecTraFac11.Value, "yyyyMMdd") & "', " _
                                & " [pro_FechaPagoTra]='" & Format(f7.dtpfecTraFac12.Value, "yyyyMMdd") & "', " _
                                & " [pro_analistaCosto]='" & f7.tbxAnalista.Text & "', " _
                                & " [pro_nroProyecto]='" & ProyNro & "' " _
                                & "  where pro_idProyecto='" & stridProy & "'")

            Else

                cntSQL.Execute("insert into tab_Aux_EntesProy ([pro_idProyecto],[pro_NroContrato],[pro_NroRecibo],[pro_Contratista],[pro_Cliente]" _
                                        & ",[pro_Gerente],[pro_Ingeniero],[pro_CordCtasMop],[pro_Gobierno],[pro_EncGrupo]" _
                                        & ",[pro_Mtototal],[pro_FechaTreal],[pro_Fechaant],[pro_Mes],[pro_FechaPago],[pro_FechaPagoTra],pro_analistaCosto) VALUES " _
                                        & "( " & stridProy & ", " _
                                        & " '" & ContNro & "', " _
                                        & " ' 0 ', " _
                                        & " '" & f7.tbxCont1.Text & "', " _
                                        & " '" & f7.tbxCliente.Text & "', " _
                                        & " '" & f7.tbxGProy1.Text & "', " _
                                        & " '" & f7.tbxIng1.Text & "', " _
                                        & " '" & f7.tbxCorCMop1.Text & "', " _
                                        & " '" & f7.tbxGob1.Text & "', " _
                                        & " '" & f7.tbxEncG1.Text & "', " _
                                        & " '" & Replace(IIf(f7.tbxMtoT1.Text = "", 0, f7.tbxMtoT1.Text), ",", "") & "', " _
                                        & " '" & Format(f7.dtpFecT1.Value, "yyyyMMdd") & "', " _
                                        & "'" & Format(f7.dtpAnAnt1.Value, "yyyyMMdd") & "'," _
                                        & " '" & f7.tbxMespro1.Text & "', " _
                                        & " '" & Format(f7.dtpfecTraFac11.Value, "yyyyMMdd") & "', " _
                                        & "'" & Format(f7.dtpfecTraFac12.Value, "yyyyMMdd") & "','" & f7.tbxAnalista.Text & "')")
            End If



        Catch ex As Exception
            MsgBox("Error en funcion guardaActProyeDRespf7" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swguar = 1
        End Try

    End Sub

    Sub guardaActProyeDResp15()
        'Try
        '    Dim strDResp As New ADODB.Recordset
        '    '  If ContNro = "" Then

        '    strDResp = cntSQL.Execute("SELECT [pro_idProyecto],[pro_NroContrato],[pro_NroRecibo],[pro_Contratista],[pro_Cliente]" _
        '                           & ",[pro_Gerente],[pro_Ingeniero],[pro_CordCtasMop],[pro_Gobierno],[pro_EncGrupo]" _
        '                           & ",[pro_Mtototal],[pro_FechaTreal],[pro_Fechaant],[pro_Mes],[pro_FechaPago],[pro_FechaPagoTra]" _
        '                           & " FROM [tab_Aux_EntesProy] where pro_idProyecto='" & stridProy & "'")

        '    If strDResp.EOF = False Then

        '        cntSQL.Execute("UPDATE [tab_Aux_EntesProy] SET [pro_NroContrato]='" & ContNro & "', " _
        '                        & " [pro_NroRecibo]='" & f15.tbxNroReci.Text & "', " _
        '                        & " [pro_Contratista]= '" & f15.tbxCont.Text & "', " _
        '                        & " [pro_Cliente]='" & f15.tbxClient.Text & "', " _
        '                        & " [pro_Gerente]='" & f15.tbxGProy.Text & "'," _
        '                        & " [pro_Ingeniero]='" & f15.tbxIng.Text & "', " _
        '                        & " [pro_CordCtasMop]='" & f15.tbxCorCMop.Text & "', " _
        '                        & " [pro_Gobierno]='" & f15.tbxGob.Text & "', " _
        '                        & " [pro_EncGrupo]='" & f15.tbxEncG.Text & "', " _
        '                        & " [pro_Mtototal]=" & Replace(IIf(f15.tbxMtoT.Text = "", 0, f15.tbxMtoT.Text), ",", "") & ", " _
        '                        & " [pro_FechaTreal]='" & Format(f15.dtpFecT.Value, "yyyyMMdd") & "', " _
        '                        & " [pro_Fechaant]='" & Format(f15.dtpAnAnt.Value, "yyyyMMdd") & "', " _
        '                        & " [pro_Mes]='" & f15.tbxMespro.Text & "', " _
        '                        & " [pro_FechaPago]='" & Format(f15.dtpfecTraFac.Value, "yyyyMMdd") & "', " _
        '                        & " [pro_FechaPagoTra]='" & Format(f15.dtpfecTraFac1.Value, "yyyyMMdd") & "' " _
        '                        & "  where pro_idProyecto='" & stridProy & "'")

        '    Else

        '        cntSQL.Execute("insert into tab_Aux_EntesProy ([pro_idProyecto],[pro_NroContrato],[pro_NroRecibo],[pro_Contratista],[pro_Cliente]" _
        '                                & ",[pro_Gerente],[pro_Ingeniero],[pro_CordCtasMop],[pro_Gobierno],[pro_EncGrupo]" _
        '                                & ",[pro_Mtototal],[pro_FechaTreal],[pro_Fechaant],[pro_Mes],[pro_FechaPago],[pro_FechaPagoTra]) VALUES " _
        '                                & "( " & stridProy & ", " _
        '                                & " '" & ContNro & "', " _
        '                                & " '" & f15.tbxNroReci.Text & "', " _
        '                                & " '" & f15.tbxCont.Text & "', " _
        '                                & " '" & f15.tbxClient.Text & "', " _
        '                                & " '" & f15.tbxGProy.Text & "', " _
        '                                & " '" & f15.tbxIng.Text & "', " _
        '                                & " '" & f15.tbxCorCMop.Text & "', " _
        '                                & " '" & f15.tbxGob.Text & "', " _
        '                                & " '" & f15.tbxEncG.Text & "', " _
        '                                & " '" & Replace(IIf(f15.tbxMtoT.Text = "", 0, f15.tbxMtoT.Text), ",", "") & "', " _
        '                                & " '" & Format(f15.dtpFecT.Value, "yyyyMMdd") & "', " _
        '                                & "'" & Format(f15.dtpAnAnt.Value, "yyyyMMdd") & "'," _
        '                                & " '" & f15.tbxMespro.Text & "', " _
        '                                & " '" & Format(f15.dtpfecTraFac.Value, "yyyyMMdd") & "', " _
        '                                & "'" & Format(f15.dtpfecTraFac1.Value, "yyyyMMdd") & "')")
        '    End If





        'Catch ex As Exception
        '    MsgBox("Error en funcion guardaActProyeDResp" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        '    swguar = 1
        'End Try

    End Sub

    Sub guardaActProyeDCostos()
        Try
            Dim strDCostos As New ADODB.Recordset

            'pregunta si el proyecto no tiene cargado datos iniciales de facturas
            If CtaNro = 1 And swCtaFac = 1 Then
                strDCostos = cntSQL.Execute("select * from tab_Aux_CostosFactProy where pro_idProyecto=" & stridProy & " and pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo=''")

                If strDCostos.EOF = False Then
                    cntSQL.Execute("UPDATE [tab_Aux_CostosFactProy] SET [pro_NroContrato]= '" & ContNro & "', " _
                                    & " [pro_NroRecibo]= '" & f1.tbxNroReci.Text & "', " _
                                    & " [pro_nroProyecto]= '" & ProyNro & "', " _
                                    & " [pro_NroFactura]= '" & FactNro & "', " _
                                    & " [pro_FechaCheque]='" & Format(f1.dtpfCheq.Value, "yyyyMMdd") & "', " _
                                    & " [pro_NroCheque]='" & f1.tbxNroCheque.Text & "', " _
                                    & " [pro_ControlRec]='" & f1.cmbCtrlRec.SelectedIndex & "', " _
                                    & " [pro_ControlCheq]='" & f1.cmbCtrlCheq.SelectedIndex & "', " _
                                    & " [pro_MtoCobrar]=" & Replace(IIf(f1.tbxMtoCxC.Text = "", 0, f1.tbxMtoCxC.Text), ",", "") & ", " _
                                    & " [pro_Rango1]='" & f1.cmbRango1.SelectedIndex & "', " _
                                    & " [pro_Rango2]='" & f1.cmbRango2.SelectedIndex & "', " _
                                    & " [pro_Rango]='" & f1.cmbRango.SelectedIndex & "', " _
                                    & " [pro_Monto2]=" & Replace(IIf(f1.tbxMonto2.Text = "", 0, f1.tbxMonto2.Text), ",", "") & ", " _
                                    & " [pro_Status]='" & f1.cmbstatus.SelectedIndex & "', " _
                                    & " [pro_MesEj]='" & f1.tbx_MesEje.Text & "', " _
                                    & " [pro_DocNext]='" & f1.tbxDocNext.Text & "', " _
                                    & " [pro_Scafid]='" & f1.tbxScafid.Text & "', " _
                                    & " [pro_FechaRefrendo]='" & Format(f1.dtpFecRefr.Value, "yyyyMMdd") & "' " _
                                    & "  where pro_idProyecto='" & stridProy & "' and  pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo=''")


                Else
                    cntSQL.Execute("insert into tab_Aux_CostosFactProy ( [pro_idProyecto] ,pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo], [pro_NroFactura],[pro_FechaCheque] ,[pro_NroCheque],[pro_ControlRec] ,[pro_ControlCheq]" _
                                       & ",[pro_MtoCobrar],[pro_Rango1] ,[pro_Rango2] ,[pro_Rango],[pro_Monto2] ,[pro_Status],[pro_MesEj],[pro_DocNext]" _
                                       & " ,[pro_Scafid]  ,[pro_FechaRefrendo]) VALUES " _
                                       & "( " & stridProy & ", " _
                                       & "'" & ProyNro & "', " _
                                       & " '" & ContNro & "', " _
                                       & " '" & RecNro & "', " _
                                       & " '" & FactNro & "', " _
                                       & " '" & Format(f1.dtpfCheq.Value, "yyyyMMdd") & "', " _
                                       & " '" & f1.tbxNroCheque.Text & "', " _
                                       & " '" & f1.cmbCtrlRec.SelectedIndex & "', " _
                                       & " '" & f1.cmbCtrlCheq.SelectedIndex & "', " _
                                       & " " & Replace(IIf(f1.tbxMtoCxC.Text = "", 0, f1.tbxMtoCxC.Text), ",", "") & ", " _
                                       & " '" & f1.cmbRango1.SelectedIndex & "', " _
                                       & " '" & f1.cmbRango2.SelectedIndex & "', " _
                                       & " '" & f1.cmbRango.SelectedIndex & "', " _
                                       & " " & Replace(IIf(f1.tbxMonto2.Text = "", 0, f1.tbxMonto2.Text), ",", "") & "," _
                                       & " '" & f1.cmbstatus.SelectedIndex & "', " _
                                       & " '" & f1.tbx_MesEje.Text & "', " _
                                       & " '" & f1.tbxDocNext.Text & "', " _
                                       & " '" & f1.tbxScafid.Text & "', " _
                                       & " '" & Format(f1.dtpFecRefr.Value, "yyyyMMdd") & "')")
                End If
            Else



                If FactNro = "" And RecNro = "" Then

                    strDCostos = cntSQL.Execute("select * from tab_Aux_CostosFactProy where pro_idProyecto=" & stridProy & " and pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo=''")

                    If strDCostos.EOF = False Then
                        cntSQL.Execute("UPDATE [tab_Aux_CostosFactProy] SET [pro_NroContrato]= '" & ContNro & "', " _
                                        & " [pro_NroRecibo]= '" & f1.tbxNroReci.Text & "', " _
                                            & " [pro_nroProyecto]= '" & ProyNro & "', " _
                                        & " [pro_NroFactura]= '" & FactNro & "', " _
                                        & " [pro_FechaCheque]='" & Format(f1.dtpfCheq.Value, "yyyyMMdd") & "', " _
                                        & " [pro_NroCheque]='" & f1.tbxNroCheque.Text & "', " _
                                        & " [pro_ControlRec]='" & f1.cmbCtrlRec.SelectedIndex & "', " _
                                        & " [pro_ControlCheq]='" & f1.cmbCtrlCheq.SelectedIndex & "', " _
                                        & " [pro_MtoCobrar]=" & Replace(IIf(f1.tbxMtoCxC.Text = "", 0, f1.tbxMtoCxC.Text), ",", "") & ", " _
                                        & " [pro_Rango1]='" & f1.cmbRango1.SelectedIndex & "', " _
                                        & " [pro_Rango2]='" & f1.cmbRango2.SelectedIndex & "', " _
                                        & " [pro_Rango]='" & f1.cmbRango.SelectedIndex & "', " _
                                        & " [pro_Monto2]=" & Replace(IIf(f1.tbxMonto2.Text = "", 0, f1.tbxMonto2.Text), ",", "") & ", " _
                                        & " [pro_Status]='" & f1.cmbstatus.SelectedIndex & "', " _
                                        & " [pro_MesEj]='" & f1.tbx_MesEje.Text & "', " _
                                        & " [pro_DocNext]='" & f1.tbxDocNext.Text & "', " _
                                        & " [pro_Scafid]='" & f1.tbxScafid.Text & "', " _
                                        & " [pro_FechaRefrendo]='" & Format(f1.dtpFecRefr.Value, "yyyyMMdd") & "' " _
                                        & "  where pro_idProyecto='" & stridProy & "' and  pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo=''")


                    Else
                        cntSQL.Execute("insert into tab_Aux_CostosFactProy ( [pro_idProyecto] ,pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo], [pro_NroFactura],[pro_FechaCheque] ,[pro_NroCheque],[pro_ControlRec] ,[pro_ControlCheq]" _
                                       & ",[pro_MtoCobrar],[pro_Rango1] ,[pro_Rango2] ,[pro_Rango],[pro_Monto2] ,[pro_Status],[pro_MesEj],[pro_DocNext]" _
                                       & " ,[pro_Scafid]  ,[pro_FechaRefrendo]) VALUES " _
                                       & "( " & stridProy & ", " _
                                       & "'" & ProyNro & "', " _
                                        & " '" & ContNro & "', " _
                                           & " '" & RecNro & "', " _
                                           & " '" & FactNro & "', " _
                                           & " '" & Format(f1.dtpfCheq.Value, "yyyyMMdd") & "', " _
                                           & " '" & f1.tbxNroCheque.Text & "', " _
                                           & " '" & f1.cmbCtrlRec.SelectedIndex & "', " _
                                           & " '" & f1.cmbCtrlCheq.SelectedIndex & "', " _
                                           & " " & Replace(IIf(f1.tbxMtoCxC.Text = "", 0, f1.tbxMtoCxC.Text), ",", "") & ", " _
                                           & " '" & f1.cmbRango1.SelectedIndex & "', " _
                                           & " '" & f1.cmbRango2.SelectedIndex & "', " _
                                           & " '" & f1.cmbRango.SelectedIndex & "', " _
                                           & " " & Replace(IIf(f1.tbxMonto2.Text = "", 0, f1.tbxMonto2.Text), ",", "") & "," _
                                           & " '" & f1.cmbstatus.SelectedIndex & "', " _
                                           & " '" & f1.tbx_MesEje.Text & "', " _
                                           & " '" & f1.tbxDocNext.Text & "', " _
                                           & " '" & f1.tbxScafid.Text & "', " _
                                           & " '" & Format(f1.dtpFecRefr.Value, "yyyyMMdd") & "')")
                    End If


                End If


                If FactNro <> "" And RecNro = "" Then
                    strDCostos = cntSQL.Execute("select * from tab_Aux_CostosFactProy where pro_idProyecto=" & stridProy & " and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo=''")

                    If strDCostos.EOF = False Then
                        cntSQL.Execute("UPDATE [tab_Aux_CostosFactProy] SET [pro_NroContrato]= '" & ContNro & "', " _
                                        & " [pro_NroRecibo]= '" & f1.tbxNroReci.Text & "', " _
                                            & " [pro_nroProyecto]= '" & ProyNro & "', " _
                                        & " [pro_NroFactura]= '" & f1.tbxNroFac.Text & "', " _
                                        & " [pro_FechaCheque]='" & Format(f1.dtpfCheq.Value, "yyyyMMdd") & "', " _
                                        & " [pro_NroCheque]='" & f1.tbxNroCheque.Text & "', " _
                                        & " [pro_ControlRec]='" & f1.cmbCtrlRec.SelectedIndex & "', " _
                                        & " [pro_ControlCheq]='" & f1.cmbCtrlCheq.SelectedIndex & "', " _
                                        & " [pro_MtoCobrar]=" & Replace(IIf(f1.tbxMtoCxC.Text = "", 0, f1.tbxMtoCxC.Text), ",", "") & ", " _
                                        & " [pro_Rango1]='" & f1.cmbRango1.SelectedIndex & "', " _
                                        & " [pro_Rango2]='" & f1.cmbRango2.SelectedIndex & "', " _
                                        & " [pro_Rango]='" & f1.cmbRango.SelectedIndex & "', " _
                                        & " [pro_Monto2]=" & Replace(IIf(f1.tbxMonto2.Text = "", 0, f1.tbxMonto2.Text), ",", "") & ", " _
                                        & " [pro_Status]='" & f1.cmbstatus.SelectedIndex & "', " _
                                        & " [pro_MesEj]='" & f1.tbx_MesEje.Text & "', " _
                                        & " [pro_DocNext]='" & f1.tbxDocNext.Text & "', " _
                                        & " [pro_Scafid]='" & f1.tbxScafid.Text & "', " _
                                        & " [pro_FechaRefrendo]='" & Format(f1.dtpFecRefr.Value, "yyyyMMdd") & "' " _
                                        & "  where pro_idProyecto='" & stridProy & "' and  pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo=''")


                    Else
                        cntSQL.Execute("insert into tab_Aux_CostosFactProy ( [pro_idProyecto] ,pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo], [pro_NroFactura],[pro_FechaCheque] ,[pro_NroCheque],[pro_ControlRec] ,[pro_ControlCheq]" _
                                       & ",[pro_MtoCobrar],[pro_Rango1] ,[pro_Rango2] ,[pro_Rango],[pro_Monto2] ,[pro_Status],[pro_MesEj],[pro_DocNext]" _
                                       & " ,[pro_Scafid]  ,[pro_FechaRefrendo]) VALUES " _
                                       & "( " & stridProy & ", " _
                                       & "'" & ProyNro & "', " _
                                            & " '" & ContNro & "', " _
                                           & " '" & RecNro & "', " _
                                           & " '" & FactNro & "', " _
                                           & " '" & Format(f1.dtpfCheq.Value, "yyyyMMdd") & "', " _
                                           & " '" & f1.tbxNroCheque.Text & "', " _
                                           & " '" & f1.cmbCtrlRec.SelectedIndex & "', " _
                                           & " '" & f1.cmbCtrlCheq.SelectedIndex & "', " _
                                           & " " & Replace(IIf(f1.tbxMtoCxC.Text = "", 0, f1.tbxMtoCxC.Text), ",", "") & ", " _
                                           & " '" & f1.cmbRango1.SelectedIndex & "', " _
                                           & " '" & f1.cmbRango2.SelectedIndex & "', " _
                                           & " '" & f1.cmbRango.SelectedIndex & "', " _
                                           & " " & Replace(IIf(f1.tbxMonto2.Text = "", 0, f1.tbxMonto2.Text), ",", "") & "," _
                                           & " '" & f1.cmbstatus.SelectedIndex & "', " _
                                           & " '" & f1.tbx_MesEje.Text & "', " _
                                           & " '" & f1.tbxDocNext.Text & "', " _
                                           & " '" & f1.tbxScafid.Text & "', " _
                                           & " '" & Format(f1.dtpFecRefr.Value, "yyyyMMdd") & "')")
                    End If

                End If


                If FactNro <> "" And RecNro <> "" Then

                    strDCostos = cntSQL.Execute("select * from tab_Aux_CostosFactProy where pro_idProyecto=" & stridProy & " and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & RecNro & "'")

                    If strDCostos.EOF = False Then
                        cntSQL.Execute("UPDATE [tab_Aux_CostosFactProy] SET [pro_NroContrato]= '" & ContNro & "', " _
                                        & " [pro_NroRecibo]= '" & f1.tbxNroReci.Text & "', " _
                                            & " [pro_nroProyecto]= '" & ProyNro & "', " _
                                        & " [pro_NroFactura]= '" & f1.tbxNroFac.Text & "', " _
                                        & " [pro_FechaCheque]='" & Format(f1.dtpfCheq.Value, "yyyyMMdd") & "', " _
                                        & " [pro_NroCheque]='" & f1.tbxNroCheque.Text & "', " _
                                        & " [pro_ControlRec]='" & f1.cmbCtrlRec.SelectedIndex & "', " _
                                        & " [pro_ControlCheq]='" & f1.cmbCtrlCheq.SelectedIndex & "', " _
                                        & " [pro_MtoCobrar]=" & Replace(IIf(f1.tbxMtoCxC.Text = "", 0, f1.tbxMtoCxC.Text), ",", "") & ", " _
                                        & " [pro_Rango1]='" & f1.cmbRango1.SelectedIndex & "', " _
                                        & " [pro_Rango2]='" & f1.cmbRango2.SelectedIndex & "', " _
                                        & " [pro_Rango]='" & f1.cmbRango.SelectedIndex & "', " _
                                        & " [pro_Monto2]=" & Replace(IIf(f1.tbxMonto2.Text = "", 0, f1.tbxMonto2.Text), ",", "") & ", " _
                                        & " [pro_Status]='" & f1.cmbstatus.SelectedIndex & "', " _
                                        & " [pro_MesEj]='" & f1.tbx_MesEje.Text & "', " _
                                        & " [pro_DocNext]='" & f1.tbxDocNext.Text & "', " _
                                        & " [pro_Scafid]='" & f1.tbxScafid.Text & "', " _
                                        & " [pro_FechaRefrendo]='" & Format(f1.dtpFecRefr.Value, "yyyyMMdd") & "' " _
                                        & "  where pro_idProyecto='" & stridProy & "' and  pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & RecNro & "'")



                    Else
                        cntSQL.Execute("insert into tab_Aux_CostosFactProy ( [pro_idProyecto] ,pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo], [pro_NroFactura],[pro_FechaCheque] ,[pro_NroCheque],[pro_ControlRec] ,[pro_ControlCheq]" _
                                       & ",[pro_MtoCobrar],[pro_Rango1] ,[pro_Rango2] ,[pro_Rango],[pro_Monto2] ,[pro_Status],[pro_MesEj],[pro_DocNext]" _
                                       & " ,[pro_Scafid]  ,[pro_FechaRefrendo]) VALUES " _
                                       & "( " & stridProy & ", " _
                                       & "'" & ProyNro & "', " _
                                            & " '" & ContNro & "', " _
                                           & " '" & RecNro & "', " _
                                           & " '" & FactNro & "', " _
                                           & " '" & Format(f1.dtpfCheq.Value, "yyyyMMdd") & "', " _
                                           & " '" & f1.tbxNroCheque.Text & "', " _
                                           & " '" & f1.cmbCtrlRec.SelectedIndex & "', " _
                                           & " '" & f1.cmbCtrlCheq.SelectedIndex & "', " _
                                           & " " & Replace(IIf(f1.tbxMtoCxC.Text = "", 0, f1.tbxMtoCxC.Text), ",", "") & ", " _
                                           & " '" & f1.cmbRango1.SelectedIndex & "', " _
                                           & " '" & f1.cmbRango2.SelectedIndex & "', " _
                                           & " '" & f1.cmbRango.SelectedIndex & "', " _
                                           & " " & Replace(IIf(f1.tbxMonto2.Text = "", 0, f1.tbxMonto2.Text), ",", "") & "," _
                                           & " '" & f1.cmbstatus.SelectedIndex & "', " _
                                           & " '" & f1.tbx_MesEje.Text & "', " _
                                           & " '" & f1.tbxDocNext.Text & "', " _
                                           & " '" & f1.tbxScafid.Text & "', " _
                                           & " '" & Format(f1.dtpFecRefr.Value, "yyyyMMdd") & "')")
                    End If


                End If

            End If

        Catch ex As Exception
            MsgBox("Error en funcion guardaActProyeDCostos" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swguar = 1
        End Try
        swCtaFac = 0
    End Sub

    Sub guardaActProyeDCostosf7()
        Try
            Dim strDCostos As New ADODB.Recordset

            If FactNro = "" And RecNro = "" Then

                strDCostos = cntSQL.Execute("select * from tab_Aux_CostosFactProy where pro_idProyecto=" & stridProy & " and pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo=''")

                'If strDCostos.EOF = False Then
                '    cntSQL.Execute("UPDATE [tab_Aux_CostosFactProy] SET [pro_NroContrato]= '" & ContNro & "', " _
                '                    & " [pro_NroRecibo]= '" & f7.tbxNroReci.Text & "', " _
                '                    & " [pro_NroFactura]= '" & FactNro & "', " _
                '                        & " [pro_nroProyecto]= '" & ProyNro & "', " _
                '                    & " [pro_FechaCheque]='" & Format(f7.dtpfCheq.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_NroCheque]='" & f7.tbxNroCheque.Text & "', " _
                '                    & " [pro_ControlRec]='" & f7.cmbCtrlRec.SelectedIndex & "', " _
                '                    & " [pro_ControlCheq]='" & f7.cmbCtrlCheq.SelectedIndex & "', " _
                '                    & " [pro_MtoCobrar]=" & Replace(IIf(f7.tbxMtoCxC.Text = "", 0, f7.tbxMtoCxC.Text), ",", "") & ", " _
                '                    & " [pro_Rango1]='" & f7.cmbRango1.SelectedIndex & "', " _
                '                    & " [pro_Rango2]='" & f7.cmbRango2.SelectedIndex & "', " _
                '                    & " [pro_Rango]='" & f7.cmbRango.SelectedIndex & "', " _
                '                    & " [pro_Monto2]=" & Replace(IIf(f7.tbxMonto2.Text = "", 0, f7.tbxMonto2.Text), ",", "") & ", " _
                '                    & " [pro_Status]='" & f7.cmbstatus.SelectedIndex & "', " _
                '                    & " [pro_MesEj]='" & f7.tbx_MesEje.Text & "', " _
                '                    & " [pro_DocNext]='" & f7.tbxDocNext.Text & "', " _
                '                    & " [pro_Scafid]='" & f7.tbxScafid.Text & "', " _
                '                    & " [pro_FechaRefrendo]='" & Format(f7.dtpFecRefr.Value, "yyyyMMdd") & "' " _
                '                    & "  where pro_idProyecto='" & stridProy & "' and  pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo=''")


                'Else
                '    cntSQL.Execute("insert into tab_Aux_CostosFactProy ( [pro_idProyecto] ,pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo], [pro_NroFactura],[pro_FechaCheque] ,[pro_NroCheque],[pro_ControlRec] ,[pro_ControlCheq]" _
                '                       & ",[pro_MtoCobrar],[pro_Rango1] ,[pro_Rango2] ,[pro_Rango],[pro_Monto2] ,[pro_Status],[pro_MesEj],[pro_DocNext]" _
                '                       & " ,[pro_Scafid]  ,[pro_FechaRefrendo]) VALUES " _
                '                       & "( " & stridProy & ", " _
                '                       & "'" & ProyNro & "', " _
                '                       & " '" & ContNro & "', " _
                '                       & " '" & RecNro & "', " _
                '                       & " '" & FactNro & "', " _
                '                       & " '" & Format(f7.dtpfCheq.Value, "yyyyMMdd") & "', " _
                '                       & " '" & f7.tbxNroCheque.Text & "', " _
                '                       & " '" & f7.cmbCtrlRec.SelectedIndex & "', " _
                '                       & " '" & f7.cmbCtrlCheq.SelectedIndex & "', " _
                '                       & " " & Replace(IIf(f7.tbxMtoCxC.Text = "", 0, f7.tbxMtoCxC.Text), ",", "") & ", " _
                '                       & " '" & f7.cmbRango1.SelectedIndex & "', " _
                '                       & " '" & f7.cmbRango2.SelectedIndex & "', " _
                '                       & " '" & f7.cmbRango.SelectedIndex & "', " _
                '                       & " " & Replace(IIf(f7.tbxMonto2.Text = "", 0, f7.tbxMonto2.Text), ",", "") & "," _
                '                       & " '" & f7.cmbstatus.SelectedIndex & "', " _
                '                       & " '" & f7.tbx_MesEje.Text & "', " _
                '                       & " '" & f7.tbxDocNext.Text & "', " _
                '                       & " '" & f7.tbxScafid.Text & "', " _
                '                       & " '" & Format(f7.dtpFecRefr.Value, "yyyyMMdd") & "')")
                'End If


            End If


            If FactNro <> "" And RecNro = "" Then
                strDCostos = cntSQL.Execute("select * from tab_Aux_CostosFactProy where pro_idProyecto=" & stridProy & " and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo=''")

                'If strDCostos.EOF = False Then
                '    cntSQL.Execute("UPDATE [tab_Aux_CostosFactProy] SET [pro_NroContrato]= '" & ContNro & "', " _
                '                    & " [pro_NroRecibo]= '" & f7.tbxNroReci.Text & "', " _
                '                        & " [pro_nroProyecto]= '" & ProyNro & "', " _
                '                    & " [pro_NroFactura]= '" & f7.tbxNroFac.Text & "', " _
                '                    & " [pro_FechaCheque]='" & Format(f7.dtpfCheq.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_NroCheque]='" & f7.tbxNroCheque.Text & "', " _
                '                    & " [pro_ControlRec]='" & f7.cmbCtrlRec.SelectedIndex & "', " _
                '                    & " [pro_ControlCheq]='" & f7.cmbCtrlCheq.SelectedIndex & "', " _
                '                    & " [pro_MtoCobrar]=" & Replace(IIf(f7.tbxMtoCxC.Text = "", 0, f7.tbxMtoCxC.Text), ",", "") & ", " _
                '                    & " [pro_Rango1]='" & f7.cmbRango1.SelectedIndex & "', " _
                '                    & " [pro_Rango2]='" & f7.cmbRango2.SelectedIndex & "', " _
                '                    & " [pro_Rango]='" & f7.cmbRango.SelectedIndex & "', " _
                '                    & " [pro_Monto2]=" & Replace(IIf(f7.tbxMonto2.Text = "", 0, f7.tbxMonto2.Text), ",", "") & ", " _
                '                    & " [pro_Status]='" & f7.cmbstatus.SelectedIndex & "', " _
                '                    & " [pro_MesEj]='" & f7.tbx_MesEje.Text & "', " _
                '                    & " [pro_DocNext]='" & f7.tbxDocNext.Text & "', " _
                '                    & " [pro_Scafid]='" & f7.tbxScafid.Text & "', " _
                '                    & " [pro_FechaRefrendo]='" & Format(f7.dtpFecRefr.Value, "yyyyMMdd") & "' " _
                '                    & "  where pro_idProyecto='" & stridProy & "' and  pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo=''")


                'Else
                '    cntSQL.Execute("insert into tab_Aux_CostosFactProy ( [pro_idProyecto] ,pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo], [pro_NroFactura],[pro_FechaCheque] ,[pro_NroCheque],[pro_ControlRec] ,[pro_ControlCheq]" _
                '                       & ",[pro_MtoCobrar],[pro_Rango1] ,[pro_Rango2] ,[pro_Rango],[pro_Monto2] ,[pro_Status],[pro_MesEj],[pro_DocNext]" _
                '                       & " ,[pro_Scafid]  ,[pro_FechaRefrendo]) VALUES " _
                '                       & "( " & stridProy & ", " _
                '                       & "'" & ProyNro & "', " _
                '                        & " '" & ContNro & "', " _
                '                       & " '" & RecNro & "', " _
                '                       & " '" & FactNro & "', " _
                '                       & " '" & Format(f7.dtpfCheq.Value, "yyyyMMdd") & "', " _
                '                       & " '" & f7.tbxNroCheque.Text & "', " _
                '                       & " '" & f7.cmbCtrlRec.SelectedIndex & "', " _
                '                       & " '" & f7.cmbCtrlCheq.SelectedIndex & "', " _
                '                       & " " & Replace(IIf(f7.tbxMtoCxC.Text = "", 0, f7.tbxMtoCxC.Text), ",", "") & ", " _
                '                       & " '" & f7.cmbRango1.SelectedIndex & "', " _
                '                       & " '" & f7.cmbRango2.SelectedIndex & "', " _
                '                       & " '" & f7.cmbRango.SelectedIndex & "', " _
                '                       & " " & Replace(IIf(f7.tbxMonto2.Text = "", 0, f7.tbxMonto2.Text), ",", "") & "," _
                '                       & " '" & f7.cmbstatus.SelectedIndex & "', " _
                '                       & " '" & f7.tbx_MesEje.Text & "', " _
                '                       & " '" & f7.tbxDocNext.Text & "', " _
                '                       & " '" & f7.tbxScafid.Text & "', " _
                '                       & " '" & Format(f7.dtpFecRefr.Value, "yyyyMMdd") & "')")
                'End If

            End If


            If FactNro <> "" And RecNro <> "" Then

                strDCostos = cntSQL.Execute("select * from tab_Aux_CostosFactProy where pro_idProyecto=" & stridProy & " and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & RecNro & "'")

                'If strDCostos.EOF = False Then
                '    cntSQL.Execute("UPDATE [tab_Aux_CostosFactProy] SET [pro_NroContrato]= '" & ContNro & "', " _
                '                    & " [pro_NroRecibo]= '" & f7.tbxNroReci.Text & "', " _
                '                        & " [pro_nroProyecto]= '" & ProyNro & "', " _
                '                    & " [pro_NroFactura]= '" & f7.tbxNroFac.Text & "', " _
                '                    & " [pro_FechaCheque]='" & Format(f7.dtpfCheq.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_NroCheque]='" & f7.tbxNroCheque.Text & "', " _
                '                    & " [pro_ControlRec]='" & f7.cmbCtrlRec.SelectedIndex & "', " _
                '                    & " [pro_ControlCheq]='" & f7.cmbCtrlCheq.SelectedIndex & "', " _
                '                    & " [pro_MtoCobrar]=" & Replace(IIf(f7.tbxMtoCxC.Text = "", 0, f7.tbxMtoCxC.Text), ",", "") & ", " _
                '                    & " [pro_Rango1]='" & f7.cmbRango1.SelectedIndex & "', " _
                '                    & " [pro_Rango2]='" & f7.cmbRango2.SelectedIndex & "', " _
                '                    & " [pro_Rango]='" & f7.cmbRango.SelectedIndex & "', " _
                '                    & " [pro_Monto2]=" & Replace(IIf(f7.tbxMonto2.Text = "", 0, f7.tbxMonto2.Text), ",", "") & ", " _
                '                    & " [pro_Status]='" & f7.cmbstatus.SelectedIndex & "', " _
                '                    & " [pro_MesEj]='" & f7.tbx_MesEje.Text & "', " _
                '                    & " [pro_DocNext]='" & f7.tbxDocNext.Text & "', " _
                '                    & " [pro_Scafid]='" & f7.tbxScafid.Text & "', " _
                '                    & " [pro_FechaRefrendo]='" & Format(f7.dtpFecRefr.Value, "yyyyMMdd") & "' " _
                '                    & "  where pro_idProyecto='" & stridProy & "' and  pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & RecNro & "'")



                'Else
                '    cntSQL.Execute("insert into tab_Aux_CostosFactProy ( [pro_idProyecto] ,pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo], [pro_NroFactura],[pro_FechaCheque] ,[pro_NroCheque],[pro_ControlRec] ,[pro_ControlCheq]" _
                '                       & ",[pro_MtoCobrar],[pro_Rango1] ,[pro_Rango2] ,[pro_Rango],[pro_Monto2] ,[pro_Status],[pro_MesEj],[pro_DocNext]" _
                '                       & " ,[pro_Scafid]  ,[pro_FechaRefrendo]) VALUES " _
                '                       & "( " & stridProy & ", " _
                '                       & "'" & ProyNro & "', " _
                '                        & " '" & ContNro & "', " _
                '                       & " '" & RecNro & "', " _
                '                       & " '" & FactNro & "', " _
                '                       & " '" & Format(f7.dtpfCheq.Value, "yyyyMMdd") & "', " _
                '                       & " '" & f7.tbxNroCheque.Text & "', " _
                '                       & " '" & f7.cmbCtrlRec.SelectedIndex & "', " _
                '                       & " '" & f7.cmbCtrlCheq.SelectedIndex & "', " _
                '                       & " " & Replace(IIf(f7.tbxMtoCxC.Text = "", 0, f7.tbxMtoCxC.Text), ",", "") & ", " _
                '                       & " '" & f7.cmbRango1.SelectedIndex & "', " _
                '                       & " '" & f7.cmbRango2.SelectedIndex & "', " _
                '                       & " '" & f7.cmbRango.SelectedIndex & "', " _
                '                       & " " & Replace(IIf(f7.tbxMonto2.Text = "", 0, f7.tbxMonto2.Text), ",", "") & "," _
                '                       & " '" & f7.cmbstatus.SelectedIndex & "', " _
                '                       & " '" & f7.tbx_MesEje.Text & "', " _
                '                       & " '" & f7.tbxDocNext.Text & "', " _
                '                       & " '" & f7.tbxScafid.Text & "', " _
                '                       & " '" & Format(f7.dtpFecRefr.Value, "yyyyMMdd") & "')")
                'End If


            End If


        Catch ex As Exception
            MsgBox("Error en funcion guardaActProyeDCostos" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swguar = 1
        End Try

    End Sub

    Sub guardaActProyeDCostos15()
        Try

            Dim strDCostos As New ADODB.Recordset

            If CtaNro = 1 And swCtaFac = 1 Then
                strDCostos = cntSQL.Execute("select * from tab_Aux_CostosFactProy where pro_idProyecto=" & stridProy & " and pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo=''")

                If strDCostos.EOF = False Then
                    cntSQL.Execute("UPDATE [tab_Aux_CostosFactProy] SET [pro_NroContrato]= '" & ContNro & "', " _
                                    & " [pro_NroRecibo]= '" & f15.tbxNroReci.Text & "', " _
                                     & " [pro_nroProyecto]= '" & ProyNro & "', " _
                                    & " [pro_NroFactura]= '" & FactNro & "', " _
                                    & " [pro_FechaCheque]='" & Format(f15.dtpfCheq.Value, "yyyyMMdd") & "', " _
                                    & " [pro_NroCheque]='" & f15.tbxNroCheque.Text & "', " _
                                    & " [pro_ControlRec]='" & f15.cmbCtrlRec.SelectedIndex & "', " _
                                    & " [pro_ControlCheq]='" & f15.cmbCtrlCheq.SelectedIndex & "', " _
                                    & " [pro_MtoCobrar]=" & Replace(IIf(f15.tbxMtoCxC.Text = "", 0, f15.tbxMtoCxC.Text), ",", "") & ", " _
                                    & " [pro_Rango1]='" & f15.cmbRango1.SelectedIndex & "', " _
                                    & " [pro_Rango2]='" & f15.cmbRango2.SelectedIndex & "', " _
                                    & " [pro_Rango]='" & f15.cmbRango.SelectedIndex & "', " _
                                    & " [pro_Monto2]=" & Replace(IIf(f15.tbxMonto2.Text = "", 0, f15.tbxMonto2.Text), ",", "") & ", " _
                                    & " [pro_Status]='" & f15.cmbstatus.SelectedIndex & "', " _
                                    & " [pro_MesEj]='" & f15.tbx_MesEje.Text & "', " _
                                    & " [pro_DocNext]='" & f15.tbxDocNext.Text & "', " _
                                    & " [pro_Scafid]='" & f15.tbxScafid.Text & "', " _
                                    & " [pro_FechaRefrendo]='" & Format(f15.dtpFecRefr.Value, "yyyyMMdd") & "' " _
                                    & "  where pro_idProyecto='" & stridProy & "' and  pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo=''")

                Else
                    cntSQL.Execute("insert into tab_Aux_CostosFactProy ( [pro_idProyecto] ,pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo], [pro_NroFactura],[pro_FechaCheque] ,[pro_NroCheque],[pro_ControlRec] ,[pro_ControlCheq]" _
                                       & ",[pro_MtoCobrar],[pro_Rango1] ,[pro_Rango2] ,[pro_Rango],[pro_Monto2] ,[pro_Status],[pro_MesEj],[pro_DocNext]" _
                                       & " ,[pro_Scafid]  ,[pro_FechaRefrendo]) VALUES " _
                                       & "( " & stridProy & ", " _
                                       & "'" & ProyNro & "', " _
                                       & " '" & ContNro & "', " _
                                       & " '" & f15.tbxNroReci.Text & "', " _
                                       & " '" & f15.tbxNroFac.Text & "', " _
                                       & " '" & Format(f15.dtpfCheq.Value, "yyyyMMdd") & "', " _
                                       & " '" & f15.tbxNroCheque.Text & "', " _
                                       & " '" & f15.cmbCtrlRec.SelectedIndex & "', " _
                                       & " '" & f15.cmbCtrlCheq.SelectedIndex & "', " _
                                       & " " & Replace(IIf(f15.tbxMtoCxC.Text = "", 0, f15.tbxMtoCxC.Text), ",", "") & ", " _
                                       & " '" & f15.cmbRango1.SelectedIndex & "', " _
                                       & " '" & f15.cmbRango2.SelectedIndex & "', " _
                                       & " '" & f15.cmbRango.SelectedIndex & "', " _
                                       & " " & Replace(IIf(f15.tbxMonto2.Text = "", 0, f15.tbxMonto2.Text), ",", "") & "," _
                                       & " '" & f15.cmbstatus.SelectedIndex & "', " _
                                       & " '" & f15.tbx_MesEje.Text & "', " _
                                       & " '" & f15.tbxDocNext.Text & "', " _
                                       & " '" & f15.tbxScafid.Text & "', " _
                                       & " '" & Format(f15.dtpFecRefr.Value, "yyyyMMdd") & "')")
                End If

            Else
                If FactNro = "" And RecNro = "" Then

                    strDCostos = cntSQL.Execute("select * from tab_Aux_CostosFactProy where pro_idProyecto=" & stridProy & " and pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo=''")

                    If strDCostos.EOF = False Then
                        cntSQL.Execute("UPDATE [tab_Aux_CostosFactProy] SET [pro_NroContrato]= '" & ContNro & "', " _
                                        & " [pro_NroRecibo]= '" & f15.tbxNroReci.Text & "', " _
                                         & " [pro_nroProyecto]= '" & ProyNro & "', " _
                                        & " [pro_NroFactura]= '" & FactNro & "', " _
                                        & " [pro_FechaCheque]='" & Format(f15.dtpfCheq.Value, "yyyyMMdd") & "', " _
                                        & " [pro_NroCheque]='" & f15.tbxNroCheque.Text & "', " _
                                        & " [pro_ControlRec]='" & f15.cmbCtrlRec.SelectedIndex & "', " _
                                        & " [pro_ControlCheq]='" & f15.cmbCtrlCheq.SelectedIndex & "', " _
                                        & " [pro_MtoCobrar]=" & Replace(IIf(f15.tbxMtoCxC.Text = "", 0, f15.tbxMtoCxC.Text), ",", "") & ", " _
                                        & " [pro_Rango1]='" & f15.cmbRango1.SelectedIndex & "', " _
                                        & " [pro_Rango2]='" & f15.cmbRango2.SelectedIndex & "', " _
                                        & " [pro_Rango]='" & f15.cmbRango.SelectedIndex & "', " _
                                        & " [pro_Monto2]=" & Replace(IIf(f15.tbxMonto2.Text = "", 0, f15.tbxMonto2.Text), ",", "") & ", " _
                                        & " [pro_Status]='" & f15.cmbstatus.SelectedIndex & "', " _
                                        & " [pro_MesEj]='" & f15.tbx_MesEje.Text & "', " _
                                        & " [pro_DocNext]='" & f15.tbxDocNext.Text & "', " _
                                        & " [pro_Scafid]='" & f15.tbxScafid.Text & "', " _
                                        & " [pro_FechaRefrendo]='" & Format(f15.dtpFecRefr.Value, "yyyyMMdd") & "' " _
                                        & "  where pro_idProyecto='" & stridProy & "' and  pro_NroContrato='" & ContNro & "' and pro_NroFactura='' and pro_NroRecibo=''")


                    Else
                        cntSQL.Execute("insert into tab_Aux_CostosFactProy ( [pro_idProyecto] ,pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo], [pro_NroFactura],[pro_FechaCheque] ,[pro_NroCheque],[pro_ControlRec] ,[pro_ControlCheq]" _
                                       & ",[pro_MtoCobrar],[pro_Rango1] ,[pro_Rango2] ,[pro_Rango],[pro_Monto2] ,[pro_Status],[pro_MesEj],[pro_DocNext]" _
                                       & " ,[pro_Scafid]  ,[pro_FechaRefrendo]) VALUES " _
                                       & "( " & stridProy & ", " _
                                       & "'" & ProyNro & "', " _
                                           & " '" & ContNro & "', " _
                                           & " '" & f15.tbxNroReci.Text & "', " _
                                           & " '" & f15.tbxNroFac.Text & "', " _
                                           & " '" & Format(f15.dtpfCheq.Value, "yyyyMMdd") & "', " _
                                           & " '" & f15.tbxNroCheque.Text & "', " _
                                           & " '" & f15.cmbCtrlRec.SelectedIndex & "', " _
                                           & " '" & f15.cmbCtrlCheq.SelectedIndex & "', " _
                                           & " " & Replace(IIf(f15.tbxMtoCxC.Text = "", 0, f15.tbxMtoCxC.Text), ",", "") & ", " _
                                           & " '" & f15.cmbRango1.SelectedIndex & "', " _
                                           & " '" & f15.cmbRango2.SelectedIndex & "', " _
                                           & " '" & f15.cmbRango.SelectedIndex & "', " _
                                           & " " & Replace(IIf(f15.tbxMonto2.Text = "", 0, f15.tbxMonto2.Text), ",", "") & "," _
                                           & " '" & f15.cmbstatus.SelectedIndex & "', " _
                                           & " '" & f15.tbx_MesEje.Text & "', " _
                                           & " '" & f15.tbxDocNext.Text & "', " _
                                           & " '" & f15.tbxScafid.Text & "', " _
                                           & " '" & Format(f15.dtpFecRefr.Value, "yyyyMMdd") & "')")
                    End If


                End If


                If FactNro <> "" And RecNro = "" Then
                    strDCostos = cntSQL.Execute("select * from tab_Aux_CostosFactProy where pro_idProyecto=" & stridProy & " and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo=''")

                    If strDCostos.EOF = False Then
                        cntSQL.Execute("UPDATE [tab_Aux_CostosFactProy] SET [pro_NroContrato]= '" & ContNro & "', " _
                                        & " [pro_NroRecibo]= '" & f15.tbxNroReci.Text & "', " _
                                         & " [pro_nroProyecto]= '" & ProyNro & "', " _
                                        & " [pro_NroFactura]= '" & f15.tbxNroFac.Text & "', " _
                                        & " [pro_FechaCheque]='" & Format(f15.dtpfCheq.Value, "yyyyMMdd") & "', " _
                                        & " [pro_NroCheque]='" & f15.tbxNroCheque.Text & "', " _
                                        & " [pro_ControlRec]='" & f15.cmbCtrlRec.SelectedIndex & "', " _
                                        & " [pro_ControlCheq]='" & f15.cmbCtrlCheq.SelectedIndex & "', " _
                                        & " [pro_MtoCobrar]=" & Replace(IIf(f15.tbxMtoCxC.Text = "", 0, f15.tbxMtoCxC.Text), ",", "") & ", " _
                                        & " [pro_Rango1]='" & f15.cmbRango1.SelectedIndex & "', " _
                                        & " [pro_Rango2]='" & f15.cmbRango2.SelectedIndex & "', " _
                                        & " [pro_Rango]='" & f15.cmbRango.SelectedIndex & "', " _
                                        & " [pro_Monto2]=" & Replace(IIf(f15.tbxMonto2.Text = "", 0, f15.tbxMonto2.Text), ",", "") & ", " _
                                        & " [pro_Status]='" & f15.cmbstatus.SelectedIndex & "', " _
                                        & " [pro_MesEj]='" & f15.tbx_MesEje.Text & "', " _
                                        & " [pro_DocNext]='" & f15.tbxDocNext.Text & "', " _
                                        & " [pro_Scafid]='" & f15.tbxScafid.Text & "', " _
                                        & " [pro_FechaRefrendo]='" & Format(f15.dtpFecRefr.Value, "yyyyMMdd") & "' " _
                                        & "  where pro_idProyecto='" & stridProy & "' and  pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo=''")


                    Else
                        cntSQL.Execute("insert into tab_Aux_CostosFactProy ( [pro_idProyecto] ,pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo], [pro_NroFactura],[pro_FechaCheque] ,[pro_NroCheque],[pro_ControlRec] ,[pro_ControlCheq]" _
                                       & ",[pro_MtoCobrar],[pro_Rango1] ,[pro_Rango2] ,[pro_Rango],[pro_Monto2] ,[pro_Status],[pro_MesEj],[pro_DocNext]" _
                                       & " ,[pro_Scafid]  ,[pro_FechaRefrendo]) VALUES " _
                                       & "( " & stridProy & ", " _
                                       & "'" & ProyNro & "', " _
                                           & " '" & ContNro & "', " _
                                           & " '" & f15.tbxNroReci.Text & "', " _
                                           & " '" & f15.tbxNroFac.Text & "', " _
                                           & " '" & Format(f15.dtpfCheq.Value, "yyyyMMdd") & "', " _
                                           & " '" & f15.tbxNroCheque.Text & "', " _
                                           & " '" & f15.cmbCtrlRec.SelectedIndex & "', " _
                                           & " '" & f15.cmbCtrlCheq.SelectedIndex & "', " _
                                           & " " & Replace(IIf(f15.tbxMtoCxC.Text = "", 0, f15.tbxMtoCxC.Text), ",", "") & ", " _
                                           & " '" & f15.cmbRango1.SelectedIndex & "', " _
                                           & " '" & f15.cmbRango2.SelectedIndex & "', " _
                                           & " '" & f15.cmbRango.SelectedIndex & "', " _
                                           & " " & Replace(IIf(f15.tbxMonto2.Text = "", 0, f15.tbxMonto2.Text), ",", "") & "," _
                                           & " '" & f15.cmbstatus.SelectedIndex & "', " _
                                           & " '" & f15.tbx_MesEje.Text & "', " _
                                           & " '" & f15.tbxDocNext.Text & "', " _
                                           & " '" & f15.tbxScafid.Text & "', " _
                                           & " '" & Format(f15.dtpFecRefr.Value, "yyyyMMdd") & "')")
                    End If

                End If


                If FactNro <> "" And RecNro <> "" Then

                    strDCostos = cntSQL.Execute("select * from tab_Aux_CostosFactProy where pro_idProyecto=" & stridProy & " and pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & RecNro & "'")

                    If strDCostos.EOF = False Then
                        cntSQL.Execute("UPDATE [tab_Aux_CostosFactProy] SET [pro_NroContrato]= '" & ContNro & "', " _
                                        & " [pro_NroRecibo]= '" & f15.tbxNroReci.Text & "', " _
                                         & " [pro_nroProyecto]= '" & ProyNro & "', " _
                                        & " [pro_NroFactura]= '" & f15.tbxNroFac.Text & "', " _
                                        & " [pro_FechaCheque]='" & Format(f15.dtpfCheq.Value, "yyyyMMdd") & "', " _
                                        & " [pro_NroCheque]='" & f15.tbxNroCheque.Text & "', " _
                                        & " [pro_ControlRec]='" & f15.cmbCtrlRec.SelectedIndex & "', " _
                                        & " [pro_ControlCheq]='" & f15.cmbCtrlCheq.SelectedIndex & "', " _
                                        & " [pro_MtoCobrar]=" & Replace(IIf(f15.tbxMtoCxC.Text = "", 0, f15.tbxMtoCxC.Text), ",", "") & ", " _
                                        & " [pro_Rango1]='" & f15.cmbRango1.SelectedIndex & "', " _
                                        & " [pro_Rango2]='" & f15.cmbRango2.SelectedIndex & "', " _
                                        & " [pro_Rango]='" & f15.cmbRango.SelectedIndex & "', " _
                                        & " [pro_Monto2]=" & Replace(IIf(f15.tbxMonto2.Text = "", 0, f15.tbxMonto2.Text), ",", "") & ", " _
                                        & " [pro_Status]='" & f15.cmbstatus.SelectedIndex & "', " _
                                        & " [pro_MesEj]='" & f15.tbx_MesEje.Text & "', " _
                                        & " [pro_DocNext]='" & f15.tbxDocNext.Text & "', " _
                                        & " [pro_Scafid]='" & f15.tbxScafid.Text & "', " _
                                        & " [pro_FechaRefrendo]='" & Format(f15.dtpFecRefr.Value, "yyyyMMdd") & "' " _
                                        & "  where pro_idProyecto='" & stridProy & "' and  pro_NroContrato='" & ContNro & "' and pro_NroFactura='" & FactNro & "' and pro_NroRecibo='" & RecNro & "'")



                    Else
                        cntSQL.Execute("insert into tab_Aux_CostosFactProy ( [pro_idProyecto] ,pro_nroProyecto, [pro_NroContrato],[pro_NroRecibo], [pro_NroFactura],[pro_FechaCheque] ,[pro_NroCheque],[pro_ControlRec] ,[pro_ControlCheq]" _
                                       & ",[pro_MtoCobrar],[pro_Rango1] ,[pro_Rango2] ,[pro_Rango],[pro_Monto2] ,[pro_Status],[pro_MesEj],[pro_DocNext]" _
                                       & " ,[pro_Scafid]  ,[pro_FechaRefrendo]) VALUES " _
                                       & "( " & stridProy & ", " _
                                       & "'" & ProyNro & "', " _
                                           & " '" & ContNro & "', " _
                                           & " '" & f15.tbxNroReci.Text & "', " _
                                           & " '" & f15.tbxNroFac.Text & "', " _
                                           & " '" & Format(f15.dtpfCheq.Value, "yyyyMMdd") & "', " _
                                           & " '" & f15.tbxNroCheque.Text & "', " _
                                           & " '" & f15.cmbCtrlRec.SelectedIndex & "', " _
                                           & " '" & f15.cmbCtrlCheq.SelectedIndex & "', " _
                                           & " " & Replace(IIf(f15.tbxMtoCxC.Text = "", 0, f15.tbxMtoCxC.Text), ",", "") & ", " _
                                           & " '" & f15.cmbRango1.SelectedIndex & "', " _
                                           & " '" & f15.cmbRango2.SelectedIndex & "', " _
                                           & " '" & f15.cmbRango.SelectedIndex & "', " _
                                           & " " & Replace(IIf(f15.tbxMonto2.Text = "", 0, f15.tbxMonto2.Text), ",", "") & "," _
                                           & " '" & f15.cmbstatus.SelectedIndex & "', " _
                                           & " '" & f15.tbx_MesEje.Text & "', " _
                                           & " '" & f15.tbxDocNext.Text & "', " _
                                           & " '" & f15.tbxScafid.Text & "', " _
                                           & " '" & Format(f15.dtpFecRefr.Value, "yyyyMMdd") & "')")
                    End If


                End If


            End If



        Catch ex As Exception
            MsgBox("Error en funcion guardaActProyeDCostos" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swguar = 1
        End Try
        swCtaFac = 0
    End Sub
    Sub guardaActProyeDFisc()
        Try
            Dim strDFisc As New ADODB.Recordset





            strDFisc = cntSQL.Execute("select pro_idProyecto from [tab_Aux_DatosFiscProy] where pro_idProyecto='" & stridProy & "'")

            If strDFisc.EOF = False Then
                '    cntSQL.Execute("UPDATE [tab_Aux_DatosFiscProy] SET [pro_CostosAsociados]=" & IIf(f1.tbxCtasoc.Text = "", 0, f1.tbxCtasoc.Text) & ", " _
                '                    & " [pro_AdquisicionServ]='" & f1.tbxAds.Text & "', " _
                '                    & " [pro_MontoMant]= " & IIf(f1.tbxMtoMan.Text = "", 0, f1.tbxMtoMan.Text) & ", " _
                '                    & " [pro_diasTransfechaentrReal]=" & IIf(f1.tbxDt.Text = "", 0, f1.tbxDt.Text) & ", " _
                '                    & " [pro_montoPorcAnt]=" & IIf(f1.tbxPor.Text = "", 0, f1.tbxPor.Text) & ", " _
                '                    & " [pro_montoAnt]=" & IIf(f1.tbxMtoAnt.Text = "", 0, f1.tbxMtoAnt.Text) & ", " _
                '                    & " [pro_PorcRete]=" & IIf(f1.tbxReten.Text = "", 0, f1.tbxReten.Text) & ", " _
                '                    & " [pro_FechaRet]='" & Format(f1.dtpFechaRet.Value, "yyyyMMdd") & "', " _
                '                    & " [pro_montoProMulta]=" & IIf(f1.tbxMulta.Text = "", 0, f1.tbxMulta.Text) & " " _
                '                    & "  where pro_idProyecto='" & stridProy & "'")

                'Else
                '    cntSQL.Execute("insert into tab_Aux_DatosFiscProy (pro_CostosAsociados, pro_AdquisicionServ, pro_MontoMant, pro_diasTransfechaentrReal, pro_montoPorcAnt, pro_montoAnt, " _
                '                   & " pro_PorcRete, pro_FechaRet, pro_montoProMulta,pro_idProyecto) VALUES " _
                '                   & "( " & Replace(IIf(f1.tbxCtasoc.Text = "", 0, f1.tbxCtasoc.Text), ",", ".") & ", " _
                '                   & " " & Replace(IIf(f1.tbxAds.Text = "", 0, f1.tbxAds.Text), ",", ".") & ", " _
                '                   & " " & Replace(IIf(f1.tbxMtoMan.Text = "", 0, f1.tbxMtoMan.Text), ",", ".") & ", " _
                '                   & " " & Replace(IIf(f1.tbxDt.Text = "", 0, f1.tbxDt.Text), ",", ".") & ", " _
                '                   & " " & Replace(IIf(f1.tbxPor.Text = "", 0, f1.tbxPor.Text), ",", ".") & ", " _
                '                   & " " & Replace(IIf(f1.tbxMtoAnt.Text = "", 0, f1.tbxMtoAnt.Text), ",", ".") & ", " _
                '                   & " " & Replace(IIf(f1.tbxReten.Text = "", 0, f1.tbxReten.Text), ",", ".") & ", " _
                '                   & " '" & Format(f1.dtpFechaRet.Value, "yyyyMMdd") & "', " _
                '                   & " " & Replace(IIf(f1.tbxMulta.Text = "", 0, f1.tbxMulta.Text), ",", ".") & ", " _
                '                   & "  '" & stridProy & "')")
            End If
        Catch ex As Exception
            MsgBox("Error en funcion guardaActProyeDFisc" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try
    End Sub
    Public Function llenarSector(ByVal valor As String)

        Dim dato As String = ""
        Dim i As Integer
        Try
            For i = 0 To f1.cmbClas.Items.Count

                If Mid(f1.cmbClas.SelectedItem, 1, 6) = valor Then
                    dato = f1.cmbClas.SelectedIndex
                End If

            Next


        Catch ex As Exception
            MsgBox("Error en funcion llenarSector" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
        Return dato
    End Function

    'CONSULTAS DE PROYECTOS


    Sub ConsultasDEntesFact()
        Try
            Dim strDFact As New ADODB.Recordset
            If swMenuPpal <> "2" Then


                strDFact = cntSQL.Execute("select  * from tab_Aux_EntesProy where pro_idProyecto='" & stridProy & "'")


                Do While Not strDFact.EOF

                    f1.tbxCont.Text = buscarCont(strDFact.Fields("pro_Contratista").Value)
                    f1.lblCont.Text = lblCon
                    f1.tbxClient.Text = buscarClient(strDFact.Fields("pro_Cliente").Value)
                    f1.lblClient.Text = lblCli
                    f1.tbxGProy.Text = strDFact.Fields("pro_Gerente").Value
                    f1.tbxIng.Text = strDFact.Fields("pro_Ingeniero").Value
                    f1.tbxCorCMop.Text = strDFact.Fields("pro_CordCtasMop").Value
                    f1.tbxGob.Text = strDFact.Fields("pro_Gobierno").Value
                    f1.tbxEncG.Text = strDFact.Fields("pro_EncGrupo").Value
                    f1.tbxMtoT.Text = decimales(Math.Round(strDFact.Fields("pro_Mtototal").Value, 2))
                    f1.dtpFecT.Value = strDFact.Fields("pro_FechaTreal").Value
                    f1.dtpAnAnt.Value = strDFact.Fields("pro_Fechaant").Value
                    f1.tbxMespro.Text = strDFact.Fields("pro_Mes").Value
                    f1.dtpfecTraFac1.Value = strDFact.Fields("pro_FechaPago").Value
                    f1.dtpfecTraFac.Value = strDFact.Fields("pro_FechaPagoTra").Value


                    Exit Do
                    strDFact.MoveNext()
                Loop
            End If

        Catch ex As Exception
            MsgBox("Error en funcion ConsultasDFact" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Sub ConsultasDEntesFactf7()
        Try
            ConexionSQL()
            Dim strDFact As New ADODB.Recordset

            strDFact = cntSQL.Execute("select  * from tab_Aux_EntesProy where pro_idProyecto='" & stridProy & "'")


            Do While Not strDFact.EOF

                f7.tbxCont1.Text = buscarCont(strDFact.Fields("pro_Contratista").Value)
                f7.lblcont1.Text = lblCon
                f7.tbxCliente.Text = buscarClient(strDFact.Fields("pro_Cliente").Value)
                f7.lblclient1.Text = lblCli
                f7.tbxGProy1.Text = strDFact.Fields("pro_Gerente").Value
                f7.tbxIng1.Text = strDFact.Fields("pro_Ingeniero").Value
                f7.tbxCorCMop1.Text = strDFact.Fields("pro_CordCtasMop").Value
                f7.tbxGob1.Text = strDFact.Fields("pro_Gobierno").Value
                f7.tbxEncG1.Text = strDFact.Fields("pro_EncGrupo").Value
                f7.tbxMtoT1.Text = decimales(Math.Round(strDFact.Fields("pro_Mtototal").Value, 2))
                f7.dtpFecT1.Value = strDFact.Fields("pro_FechaTreal").Value
                f7.dtpAnAnt1.Value = strDFact.Fields("pro_Fechaant").Value
                f7.tbxMespro1.Text = strDFact.Fields("pro_Mes").Value
                f7.dtpfecTraFac11.Value = strDFact.Fields("pro_FechaPago").Value
                f7.dtpfecTraFac12.Value = strDFact.Fields("pro_FechaPagoTra").Value
                f7.tbxAnalista.Text = strDFact.Fields("pro_analistaCosto").Value

                Exit Do
                strDFact.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion ConsultasDFact" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Sub ConsultasDEntesFactf15()
        Try
            ConexionSQL()
            Dim strDFact As New ADODB.Recordset

            strDFact = cntSQL.Execute("select  * from tab_Aux_EntesProy where pro_idProyecto='" & stridProy & "'")


            Do While Not strDFact.EOF

                strCodCont = strDFact.Fields("pro_Contratista").Value


                Exit Do
                strDFact.MoveNext()
            Loop

            buscarCont(strCodCont)

        Catch ex As Exception
            MsgBox("Error en funcion ConsultasDFact" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Sub ConsultasDFact()
        Try
            ConexionSQL()
            Dim strDFact As New ADODB.Recordset

            If swMenuPpal <> "2" Then
                strDFact = cntSQL.Execute("select  * from [tab_Aux_FactProy] where pro_idProyecto='" & stridProy & "' and [pro_NroContrato]='" & ContNro & "' and [pro_NroRecibo]='" & RecNro & "'")


                Do While Not strDFact.EOF

                    f1.tbxNroFac.Text = strDFact.Fields("pro_NroFactura").Value
                    f1.dtpFecFac.Value = strDFact.Fields("pro_FechaFact").Value
                    f1.tbxNroReci.Text = strDFact.Fields("pro_NroRecibo").Value
                    f1.dtpFecREC.Value = strDFact.Fields("pro_FechaRes").Value
                    f1.tbxFac.Text = decimales(Math.Round(strDFact.Fields("pro_trabajoFac").Value, 2))
                    f1.cmbRe10.SelectedIndex = strDFact.Fields("pro_Rete10").Value

                    f1.tbxMtoRet.Text = decimales(Math.Round(strDFact.Fields("pro_MtoRete10").Value, 2))
                    f1.tbxAntMont.Text = decimales(Math.Round(strDFact.Fields("pro_Anticipo").Value, 2))
                    f1.tbxPena.Text = decimales(Math.Round(strDFact.Fields("pro_Penalizacion").Value, 2))
                    f1.tbxRetMtoITBMS.Text = decimales(Math.Round(strDFact.Fields("pro_RETdeITBMS").Value, 2))
                    f1.tbxMtoITBMS.Text = decimales(Math.Round(strDFact.Fields("pro_MontoITBMS").Value, 2))
                    f1.tbxCxC.Text = decimales(Math.Round(strDFact.Fields("pro_CuentaCobrar").Value, 2))

                    f1.cmbEnInsp.SelectedIndex = strDFact.Fields("pro_EntrInsp").Value
                    f1.dtpFecEnt.Value = strDFact.Fields("pro_FechaCliente").Value
                    f1.dtpCXC.Value = strDFact.Fields("pro_FechaCxc").Value
                    f1.dtpFecTe.Value = strDFact.Fields("pro_FechaTes").Value
                    f1.dtpFecPago.Value = strDFact.Fields("pro_FechaPago").Value

                    Exit Do
                    strDFact.MoveNext()
                Loop

            End If
        Catch ex As Exception
            MsgBox("Error en funcion ConsultasDFact" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Sub ConsultasDFactf7()
        Try
            ConexionSQL()
            Dim strDFact As New ADODB.Recordset
            strDFact = cntSQL.Execute("select  * from [tab_Aux_FactProy] where pro_idProyecto='" & stridProy & "' and [pro_NroContrato]='" & ContNro & "' and [pro_NroRecibo]='" & RecNro & "'")


            Do While Not strDFact.EOF

                'f7.tbxNroFac.Text = strDFact.Fields("pro_NroFactura").Value
                'f7.dtpFecFac.Value = strDFact.Fields("pro_FechaFact").Value
                'f7.tbxNroReci.Text = strDFact.Fields("pro_NroRecibo").Value
                'f7.dtpFecREC.Value = strDFact.Fields("pro_FechaRes").Value
                'f7.tbxFac.Text = decimales(Math.Round(strDFact.Fields("pro_trabajoFac").Value, 2))
                'f7.cmbRe10.SelectedIndex = strDFact.Fields("pro_Rete10").Value

                'f7.tbxMtoRet.Text = decimales(Math.Round(strDFact.Fields("pro_MtoRete10").Value, 2))
                'f7.tbxAntMont.Text = decimales(Math.Round(strDFact.Fields("pro_Anticipo").Value, 2))
                'f7.tbxPena.Text = decimales(Math.Round(strDFact.Fields("pro_Penalizacion").Value, 2))
                'f7.tbxRetMtoITBMS.Text = decimales(Math.Round(strDFact.Fields("pro_RETdeITBMS").Value, 2))
                'f7.tbxMtoITBMS.Text = decimales(Math.Round(strDFact.Fields("pro_MontoITBMS").Value, 2))
                'f7.tbxCxC.Text = decimales(Math.Round(strDFact.Fields("pro_CuentaCobrar").Value, 2))

                'f7.cmbEnInsp.SelectedIndex = strDFact.Fields("pro_EntrInsp").Value
                'f7.dtpFecEnt.Value = strDFact.Fields("pro_FechaCliente").Value
                'f7.dtpCXC.Value = strDFact.Fields("pro_FechaCxc").Value
                'f7.dtpFecTe.Value = strDFact.Fields("pro_FechaTes").Value
                'f7.dtpFecPago.Value = strDFact.Fields("pro_FechaPago").Value
                '  f7.tbxMtocheq.Text = decimales(Math.Round(strDFact.Fields("pro_montoCheque").Value, 2))
                Exit Do
                strDFact.MoveNext()
            Loop


        Catch ex As Exception
            MsgBox("Error en funcion ConsultasDFact" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Sub ConsultasDFactf15()
        Try
            ConexionSQL()
            Dim strDFact As New ADODB.Recordset

            strDFact = cntSQL.Execute("select DISTINCT pro_serieCuenta, tab_Aux_FactProy.pro_NroFactura, pro_FechaFact, pro_NroRecibo, pro_FechaRes, pro_trabajoFac, pro_Rete10, pro_MtoRete10, pro_Anticipo, " _
            & " pro_Penalizacion, pro_RETdeITBMS, pro_MontoITBMS, pro_CuentaCobrar, pro_EntrInsp, pro_FechaCliente, pro_FechaCxc, pro_FechaTes, pro_FechaPago, pro_FechaentrCGR, pro_FechaD, pro_FechaH from tab_Aux_FactProy left outer join tab_DatosPpalProy_Compl " _
            & " on tab_Aux_FactProy.pro_idProyecto=tab_DatosPpalProy_Compl.pro_idProyecto" _
            & " and tab_DatosPpalProy_Compl.pro_NroFactura =tab_Aux_FactProy.pro_NroFactura" _
            & " and tab_DatosPpalProy_Compl.pro_nroContrato =tab_Aux_FactProy.pro_NroContrato where tab_Aux_FactProy.pro_idProyecto='" & stridProy & "' and tab_Aux_FactProy.pro_NroContrato='" & ContNro & "' and  tab_Aux_FactProy.pro_NroFactura='" & FactNro & "'")
            ' strDFact = cntSQL.Execute("select  * from [tab_Aux_FactProy] where pro_idProyecto='" & stridProy & "' and [pro_NroContrato]='" & ContNro & "' and [pro_NroRecibo]='" & RecNro & "' and [pro_NroFactura]='" & FactNro & "'")


            Do While Not strDFact.EOF

                f15.tbxNroFac.Text = strDFact.Fields("pro_NroFactura").Value
                f15.dtpFecFac.Value = strDFact.Fields("pro_FechaFact").Value
                f15.tbxNroReci.Text = strDFact.Fields("pro_NroRecibo").Value
                f15.dtpFecREC.Value = strDFact.Fields("pro_FechaRes").Value
                f15.tbxFac.Text = decimales(Math.Round(strDFact.Fields("pro_trabajoFac").Value, 2))
                f15.cmbRe10.SelectedIndex = strDFact.Fields("pro_Rete10").Value

                f15.tbxMtoRet.Text = decimales(Math.Round(strDFact.Fields("pro_MtoRete10").Value, 2))
                f15.tbxAntMont.Text = decimales(Math.Round(strDFact.Fields("pro_Anticipo").Value, 2))
                f15.tbxPena.Text = decimales(Math.Round(strDFact.Fields("pro_Penalizacion").Value, 2))
                f15.tbxRetMtoITBMS.Text = decimales(Math.Round(strDFact.Fields("pro_RETdeITBMS").Value, 2))
                f15.tbxMtoITBMS.Text = decimales(Math.Round(strDFact.Fields("pro_MontoITBMS").Value, 2))
                f15.tbxCxC.Text = decimales(Math.Round(strDFact.Fields("pro_CuentaCobrar").Value, 2))

                f15.cmbEnInsp.SelectedIndex = strDFact.Fields("pro_EntrInsp").Value
                f15.dtpFecEnt.Value = strDFact.Fields("pro_FechaCliente").Value
                f15.dtpCXC.Value = strDFact.Fields("pro_FechaCxc").Value
                f15.dtpFecTe.Value = strDFact.Fields("pro_FechaTes").Value
                f15.dtpFecPago.Value = strDFact.Fields("pro_FechaPago").Value
                f15.dtpCgr.Value = IIf(strDFact.Fields("pro_FechaentrCGR").Value Is DBNull.Value, "1900-01-01", strDFact.Fields("pro_FechaentrCGR").Value)
                f15.dtpFechai.Value = IIf(strDFact.Fields("pro_FechaD").Value Is DBNull.Value, "1900-01-01", strDFact.Fields("pro_FechaD").Value)
                f15.dtpFechaf.Value = IIf(strDFact.Fields("pro_FechaH").Value Is DBNull.Value, "1900-01-01", strDFact.Fields("pro_FechaH").Value)
                f15.tbxNrocta.Text = IIf(strDFact.Fields("pro_serieCuenta").Value Is DBNull.Value, "", strDFact.Fields("pro_serieCuenta").Value)
                '  f15.dtpFecEs.Value = IIf(strDFact.Fields("pro_FechaEstimacion").Value Is DBNull.Value, "1900-01-01", strDFact.Fields("pro_FechaEstimacion").Value)
                f15.cmbCtrlRec.SelectedIndex = IIf(strDFact.Fields("pro_NroRecibo").Value <> "", 0, 1)
                Exit Do
                strDFact.MoveNext()
            Loop

            ' f15.llenarFactf15()

        Catch ex As Exception
            MsgBox("Error en funcion ConsultasDFact" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub
    Sub ConsultasDFactf151()
        Try
            ConexionSQL()
            Dim strDFact As New ADODB.Recordset

            strDFact = cntSQL.Execute("select DISTINCT pro_serieCuenta, tab_Aux_FactProy.pro_NroFactura, pro_FechaFact, pro_NroRecibo, pro_FechaRes, pro_trabajoFac, pro_Rete10, pro_MtoRete10, pro_Anticipo, " _
            & " pro_Penalizacion, pro_RETdeITBMS, pro_MontoITBMS, pro_CuentaCobrar, pro_EntrInsp, pro_FechaCliente, pro_FechaCxc, pro_FechaTes, pro_FechaPago, pro_FechaentrCGR  from tab_Aux_FactProy left outer join tab_DatosPpalProy_Compl " _
            & " on tab_Aux_FactProy.pro_idProyecto=tab_DatosPpalProy_Compl.pro_idProyecto" _
            & " and tab_DatosPpalProy_Compl.pro_NroFactura =tab_Aux_FactProy.pro_NroFactura" _
            & " and tab_DatosPpalProy_Compl.pro_nroContrato =tab_Aux_FactProy.pro_NroContrato where tab_Aux_FactProy.pro_idProyecto='" & stridProy & "' and tab_Aux_FactProy.pro_NroContrato='" & ContNro & "' and tab_Aux_FactProy.pro_NroRecibo='" & RecNro & "' and tab_Aux_FactProy.pro_NroFactura='" & FactNro & "'")
            ' strDFact = cntSQL.Execute("select  * from [tab_Aux_FactProy] where pro_idProyecto='" & stridProy & "' and [pro_NroContrato]='" & ContNro & "' and [pro_NroRecibo]='" & RecNro & "' and [pro_NroFactura]='" & FactNro & "'")


            Do While Not strDFact.EOF

                f15.tbxNroFac.Text = strDFact.Fields("pro_NroFactura").Value
                f15.dtpFecFac.Value = strDFact.Fields("pro_FechaFact").Value
                f15.tbxNroReci.Text = strDFact.Fields("pro_NroRecibo").Value
                f15.dtpFecREC.Value = strDFact.Fields("pro_FechaRes").Value
                f15.tbxFac.Text = decimales(Math.Round(strDFact.Fields("pro_trabajoFac").Value, 2))
                f15.cmbRe10.SelectedIndex = strDFact.Fields("pro_Rete10").Value

                f15.tbxMtoRet.Text = decimales(Math.Round(strDFact.Fields("pro_MtoRete10").Value, 2))
                f15.tbxAntMont.Text = decimales(Math.Round(strDFact.Fields("pro_Anticipo").Value, 2))
                f15.tbxPena.Text = decimales(Math.Round(strDFact.Fields("pro_Penalizacion").Value, 2))
                f15.tbxRetMtoITBMS.Text = decimales(Math.Round(strDFact.Fields("pro_RETdeITBMS").Value, 2))
                f15.tbxMtoITBMS.Text = decimales(Math.Round(strDFact.Fields("pro_MontoITBMS").Value, 2))
                f15.tbxCxC.Text = decimales(Math.Round(strDFact.Fields("pro_CuentaCobrar").Value, 2))

                f15.cmbEnInsp.SelectedIndex = strDFact.Fields("pro_EntrInsp").Value
                f15.dtpFecEnt.Value = strDFact.Fields("pro_FechaCliente").Value
                f15.dtpCXC.Value = strDFact.Fields("pro_FechaCxc").Value
                f15.dtpFecTe.Value = strDFact.Fields("pro_FechaTes").Value
                f15.dtpCgr.Value = strDFact.Fields("pro_FechaentrCGR").Value

                f15.dtpFechai.Value = IIf(strDFact.Fields("pro_FechaD").Value Is DBNull.Value, "1900-01-01", strDFact.Fields("pro_FechaD").Value)
                f15.dtpFechaf.Value = IIf(strDFact.Fields("pro_FechaH").Value Is DBNull.Value, "1900-01-01", strDFact.Fields("pro_FechaH").Value)
                f15.dtpFecPago.Value = strDFact.Fields("pro_FechaPago").Value
                'f15.tbxNrocta.Text = IIf(strDFact.Fields("pro_serieCuenta").Value Is DBNull.Value, "", strDFact.Fields("pro_serieCuenta").Value)
                f15.dtpFecEs.Value = "1900-01-01"
         
                Exit Do
                strDFact.MoveNext()
            Loop



        Catch ex As Exception
            MsgBox("Error en funcion ConsultasDFact" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub
    Sub ConsultasDCostos()
        Try
            ConexionSQL()
            Dim strDCostos As New ADODB.Recordset


            strDCostos = cntSQL.Execute("select  * from [tab_Aux_CostosFactProy] where pro_idProyecto=" & stridProy & " and [pro_NroContrato]='" & ContNro & "' and [pro_NroFactura]='" & FactNro & "'")

            If swMenuPpal <> "2" Then

                Do While Not strDCostos.EOF

                    f1.dtpfCheq.Value = strDCostos.Fields("pro_FechaCheque").Value
                    f1.tbxNroCheque.Text = strDCostos.Fields("pro_NroCheque").Value
                    f1.cmbCtrlRec.SelectedIndex = strDCostos.Fields("pro_ControlRec").Value
                    f1.cmbCtrlCheq.SelectedIndex = strDCostos.Fields("pro_ControlCheq").Value
                    f1.tbxMtoCxC.Text = decimales(Math.Round(strDCostos.Fields("pro_MtoCobrar").Value, 2))
                    'f1.cmbRango1.SelectedIndex = strDCostos.Fields("pro_Rango1").Value
                    'f1.cmbRango2.SelectedIndex = strDCostos.Fields("pro_Rango2").Value
                    'f1.cmbRango.SelectedIndex = strDCostos.Fields("pro_Rango").Value
                    f1.tbxMonto2.Text = decimales(Math.Round(strDCostos.Fields("pro_Monto2").Value, 2))

                    f1.cmbstatus.SelectedItem = buscaComboStatus(strDCostos.Fields("pro_Status").Value)
                    f1.tbx_MesEje.Text = strDCostos.Fields("pro_MesEj").Value
                    f1.tbxDocNext.Text = strDCostos.Fields("pro_DocNext").Value
                    f1.tbxScafid.Text = strDCostos.Fields("pro_Scafid").Value
                    f1.dtpFecRefr.Value = strDCostos.Fields("pro_FechaRefrendo").Value
                    Exit Do
                    strDCostos.MoveNext()
                Loop

            End If
        Catch ex As Exception
            MsgBox("Error en funcion ConsultasDCostos" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Sub ConsultasDAdf7()
        Try
            ConexionSQL()
            Dim intMonAd As Decimal = 0
            Dim intMonAd1 As Decimal = 0
            Dim intMonAd2 As Decimal = 0
            Dim intMonpAd1 As Decimal = 0
            Dim intMonpAd2 As Decimal = 0
            Dim intMonpAd3 As Decimal = 0
            Dim difer As Integer = 0
            Dim strAd As New ADODB.Recordset

            Dim intMonAd3 As Decimal = 0
            revisaFechaOrigProy()

            'calculo el monto de la adenda de tiempo
            strAd = cntSQL.Execute("select  sum(pro_monto)as pro_monto from [tab_AdendasProy] where pro_idProyecto=" & stridProy & " and pro_nroContrato='" & ContNro & "' and pro_Financiera=0 ")

            Do While Not strAd.EOF

                f7.tbxAdendas.Text = decimales(IIf(strAd.Fields("pro_monto").Value Is DBNull.Value, 0, strAd.Fields("pro_monto").Value))

                Exit Do
                strAd.MoveNext()
            Loop

            intMonAd = intMontoProy
            intMonAd1 = IIf(f7.tbxAdendas.Text = "", 0, f7.tbxAdendas.Text)

            f7.txtItbAd.Text = decimales((intMonAd1 * f7.cmbImbs.Text) / 100 + IIf(f7.txtITBMS.Text = "", 0, f7.txtITBMS.Text))

            'adenda de fecha



            intMonpAd1 = IIf(f7.txtMonto.Text = "", 0, f7.txtMonto.Text)
            intMonpAd2 = IIf(f7.txtItbAd.Text = "", 0, f7.txtItbAd.Text)
            intMonpAd3 = IIf(f7.tbxAdendas.Text = "", 0, f7.tbxAdendas.Text)

            f7.txtItbContAd.Text = decimales(intMonpAd1 + intMonpAd2 + intMonpAd3)



            f7.txtAdT.Text = 0
            'calculo el tiempo del proyecto con la adenda de tiempo
            strAd = cntSQL.Execute("select  max(pro_adendaFecha),sum(tiempoAdf) from [tab_AdendasProy] where pro_idProyecto=" & stridProy & " and pro_nroContrato='" & ContNro & "'  and pro_Financiera=0 ")

            Do While Not strAd.EOF


                intMonAd2 = decimales(IIf(strAd.Fields(1).Value Is DBNull.Value, 0, strAd.Fields(1).Value))

                f7.txtAdT.Text = decimales(IIf(strAd.Fields(1).Value Is DBNull.Value, 0, strAd.Fields(1).Value))
                Exit Do
                strAd.MoveNext()
            Loop


        
            intMonAd3 = IIf(f7.txtDurOri.Text = "", 0, f7.txtDurOri.Text)

            f7.txtDurCont.Text = intMonAd2 + intMonAd3
            f7.dtpFecF.Value = f7.dtpFecI.Value.AddDays(intMonAd2 + intMonAd3)


        Catch ex As Exception
            MsgBox("Error en funcion ConsultasDAdf7" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Sub revisaFechaOrigProy()
        Try
            ConexionSQL()
            Dim intMonAd As Decimal = 0
            Dim intMonAd1 As Decimal = 0
            Dim intMonAd2 As Decimal = 0
            Dim strAd As New ADODB.Recordset

            Dim intMonAd3 As Decimal = 0



            'calculo el tiempo del proyecto con la adenda de tiempo
            strAd = cntSQL.Execute("select  max(pro_adendaFecha),sum(tiempoAdf) from [tab_AdendasProy] where pro_idProyecto=" & stridProy & " and pro_nroContrato='" & ContNro & "' and pro_tipoAdendas = '0' ")

            Do While Not strAd.EOF


                intMonAd2 = decimales(IIf(strAd.Fields(1).Value Is DBNull.Value, 0, strAd.Fields(1).Value))

                f7.txtAdT.Text = decimales(IIf(strAd.Fields(1).Value Is DBNull.Value, 0, strAd.Fields(1).Value))
                Exit Do
                strAd.MoveNext()
            Loop


            If intMonAd2 = 0 Then
                f7.dtpOriF.Value = f7.dtpOriF.Value
            End If

          


        Catch ex As Exception
            MsgBox("Error en funcion ConsultasDAdf7" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub
    Sub ConsultasDCostosf7()
        Try
            ConexionSQL()
            Dim strDCostos As New ADODB.Recordset


            strDCostos = cntSQL.Execute("select  * from [tab_Aux_CostosFactProy] where pro_idProyecto=" & stridProy & " and [pro_NroContrato]='" & ContNro & "' and [pro_NroFactura]='" & FactNro & "'")

            Do While Not strDCostos.EOF

                'f7.dtpfCheq.Value = strDCostos.Fields("pro_FechaCheque").Value
                'f7.tbxNroCheque.Text = strDCostos.Fields("pro_NroCheque").Value
                'f7.cmbCtrlRec.SelectedIndex = strDCostos.Fields("pro_ControlRec").Value
                'f7.cmbCtrlCheq.SelectedIndex = strDCostos.Fields("pro_ControlCheq").Value
                'f7.tbxMtoCxC.Text = decimales(Math.Round(strDCostos.Fields("pro_MtoCobrar").Value, 2))
                ''f7.cmbRango1.SelectedIndex = strDCostos.Fields("pro_Rango1").Value
                ''f7.cmbRango2.SelectedIndex = strDCostos.Fields("pro_Rango2").Value
                ''f7.cmbRango.SelectedIndex = strDCostos.Fields("pro_Rango").Value
                'f7.tbxMonto2.Text = decimales(Math.Round(strDCostos.Fields("pro_Monto2").Value, 2))
                '' Me.cmbSt.SelectedItem = buscaComboStatus(strCtas.Fields("pro_status").Value)
                'f7.cmbstatus.SelectedItem = buscaComboStatus(strDCostos.Fields("pro_Status").Value)
                'f7.tbx_MesEje.Text = strDCostos.Fields("pro_MesEj").Value
                'f7.tbxDocNext.Text = strDCostos.Fields("pro_DocNext").Value
                'f7.tbxScafid.Text = strDCostos.Fields("pro_Scafid").Value
                'f7.dtpFecRefr.Value = strDCostos.Fields("pro_FechaRefrendo").Value
                Exit Do
                strDCostos.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox("Error en funcion ConsultasDCostosf7" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub


    Sub GuardarALLproy15()
        swguar = 0

        Try
            'If f15.tbxDescr.Text <> "" Then
            'guardaActDPpalProy15()
            'guardaActProyeDResp15()

            'tablas que crecen segun los datos de Facturas y Recibos

            guardaActProyeDFact15()
            guardaActProyeDCostos15()


            'Else
            'MsgBox("Debe Ingresar Descripción del Proyecto....")
            '' f15.tbxDescr.Focus()
            'End If
        Catch ex As Exception
            MsgBox("Error en funcion GuardarALLproy15" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub
    Sub GuardarALLproy()
        swguar = 0

        Try
            If f1.tbxDescr.Text <> "" Then
                guardaActDPpalProy()
                guardaActProyeDResp()

                'tablas que crecen segun los datos de Facturas y Recibos

                guardaActProyeDFact()
                guardaActProyeDCostos()


            Else
                MsgBox("Debe Ingresar Descripción del Proyecto....")
                f1.tbxDescr.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error en funcion GuardarALLproy" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub
    Sub insertaDatosComplProyf15()
        ConexionSQL()
        Try
            Dim strPpal As New ADODB.Recordset
            Dim id As Integer = 0

            If ContNro = "" Then
                id = Val(f7.lblid.Text)
                stridProy = id
                id = idProyecto(id)
                ConexionSQL()

                'VALIDA QUE NO EXISTA NRO DE PROYECTO
                strPpal = cntSQL.Execute("select pro_idProyecto from tab_DatosPpalProy_Compl where pro_idProyecto='" & stridProy & "' and pro_nroCuenta='" & CtaNro & "'")


                If strPpal.EOF = False Then
                    cntSQL.Execute("UPDATE tab_DatosPpalProy_Compl SET pro_nroCuenta='" & CtaNro & "', " _
                                    & " pro_serieCuenta='" & serieNro & "' " _
                                    & " where pro_idProyecto=" & stridProy & " and pro_nroCuenta='" & CtaNro & "'")

                    stridProy = id
                End If
            End If


            If ContNro <> "" Then
                id = Val(f7.lblid.Text)
                stridProy = id
                id = idProyecto(id)
                ConexionSQL()

                'VALIDA QUE NO EXISTA NRO DE PROYECTO
                strPpal = cntSQL.Execute("select pro_idProyecto from tab_DatosPpalProy_Compl where pro_idProyecto='" & stridProy & "' and pro_nroContrato='" & ContNro & "' and pro_nroCuenta='" & CtaNro & "'")


                If strPpal.EOF = False Then
                    cntSQL.Execute("UPDATE tab_DatosPpalProy_Compl SET pro_nroCuenta='" & CtaNro & "', " _
                                     & " pro_serieCuenta='" & serieNro & "' " _
                                     & " where pro_idProyecto=" & stridProy & " and pro_nroContrato='" & ContNro & "' and pro_nroCuenta='" & CtaNro & "'")


                    stridProy = id
                End If
            End If


        Catch ex As Exception
            MsgBox("Error en funcion insertaDatosComplProyf7()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swguar = 1
        End Try
    End Sub
    Sub insertaDatosComplProyf7()
        ConexionSQL()
        Try
            Dim strPpal As New ADODB.Recordset
            Dim id As Integer = 0

            If ContNro = "" Then
                id = Val(f7.lblid.Text)
                stridProy = id
                id = idProyecto(id)
                ConexionSQL()

                'VALIDA QUE NO EXISTA NRO DE PROYECTO
                strPpal = cntSQL.Execute("select pro_idProyecto from tab_DatosPpalProy_Compl where pro_idProyecto='" & stridProy & "' and pro_nroCuenta='" & CtaNro & "'")


                If strPpal.EOF = False Then
                    cntSQL.Execute("UPDATE tab_DatosPpalProy_Compl SET pro_nroProyecto='" & f7.tbxCodp.Text & "', " _
                                    & " pro_nroContrato='" & f7.tbxNroCon.Text & "', " _
                                    & " pro_nroCuenta='" & CtaNro & "', " _
                                    & " pro_serieCuenta='" & f7.txtCuenta1.Text & "', " _
                                    & " pro_FechaD='" & Format(f7.dtpFd1.Value, "yyyyMMdd") & "', " _
                                    & " pro_FechaH='" & Format(f7.dtpFH1.Value, "yyyyMMdd") & "', " _
                                    & " pro_TrabajoR=" & Replace(IIf(f7.tbxTraR1.Text = "", 0, f7.tbxTraR1.Text), ",", "") & ", " _
                                    & " pro_FechaR='" & Format(f7.dtpFechaR1.Value, "yyyyMMdd") & "', " _
                                    & " pro_PresInsp= " & Replace(IIf(f7.txtInsp1.Text = "", 0, f7.txtInsp1.Text), ",", "") & ", " _
                                    & " pro_FechaP='" & Format(f7.dtpPIns1.Value, "yyyyMMdd") & "', " _
                                    & " pro_status='" & buscaComboStatusC(f7.cmbStatus.SelectedItem) & "' " _
                                    & " where pro_idProyecto=" & stridProy & " and pro_nroCuenta='" & CtaNro & "'")

                Else

                    id = Val(f7.lblid.Text)
                    stridProy = id
                    id = idProyecto(id)
                    ConexionSQL()
                    cntSQL.Execute("insert into tab_DatosPpalProy_Compl (pro_idProyecto,pro_nroProyecto,pro_nroContrato," _
                                 & " pro_nroCuenta,pro_serieCuenta, pro_FechaD,pro_FechaH,pro_TrabajoR,pro_FechaR,pro_PresInsp,pro_FechaP,pro_NroFactura, pro_status) values (  '" & id & "', " _
                                       & " '" & f7.tbxCodp.Text & "', " _
                                       & " '" & f7.tbxNroCon.Text & "', " _
                                       & " '" & CtaNro & "', " _
                                       & " '" & f7.txtCuenta1.Text & "', " _
                                       & " '" & Format(f7.dtpFd1.Value, "yyyyMMdd") & "', " _
                                       & " '" & Format(f7.dtpFH1.Value, "yyyyMMdd") & "', " _
                                       & "  " & Replace(IIf(f7.tbxTraR1.Text = "", 0, f7.tbxTraR1.Text), ",", "") & ", " _
                                       & " '" & Format(f7.dtpFechaR1.Value, "yyyyMMdd") & "', " _
                                       & "  " & Replace(IIf(f7.txtInsp1.Text = "", 0, f7.txtInsp1.Text), ",", "") & ", " _
                                       & " '" & Format(f7.dtpPIns1.Value, "yyyyMMdd") & "', " _
                                       & " '' , " _
                                       & " '" & guardaComboStatusC(f7.cmbStatus.SelectedItem) & "')")

                    stridProy = id
                End If
            End If


            If ContNro <> "" Then
                id = Val(f7.lblid.Text)
                stridProy = id
                id = idProyecto(id)
                ConexionSQL()

                'VALIDA QUE NO EXISTA NRO DE PROYECTO
                strPpal = cntSQL.Execute("select pro_idProyecto from tab_DatosPpalProy_Compl where pro_idProyecto='" & stridProy & "' and pro_nroContrato='" & ContNro & "' and pro_nroCuenta='" & CtaNro & "'")


                If strPpal.EOF = False Then
                    cntSQL.Execute("UPDATE tab_DatosPpalProy_Compl SET pro_nroProyecto='" & f7.tbxCodp.Text & "', " _
                                    & " pro_nroContrato='" & f7.tbxNroCon.Text & "', " _
                                    & " pro_nroCuenta='" & CtaNro & "', " _
                                    & " pro_serieCuenta='" & f7.txtCuenta1.Text & "', " _
                                    & " pro_FechaD='" & Format(f7.dtpFd1.Value, "yyyyMMdd") & "', " _
                                    & " pro_FechaH='" & Format(f7.dtpFH1.Value, "yyyyMMdd") & "', " _
                                    & " pro_TrabajoR=" & Replace(IIf(f7.tbxTraR1.Text = "", 0, f7.tbxTraR1.Text), ",", "") & ", " _
                                    & " pro_FechaR='" & Format(f7.dtpFechaR1.Value, "yyyyMMdd") & "', " _
                                    & " pro_PresInsp= " & Replace(IIf(f7.txtInsp1.Text = "", 0, f7.txtInsp1.Text), ",", "") & ", " _
                                    & " pro_FechaP='" & Format(f7.dtpPIns1.Value, "yyyyMMdd") & "', " _
                                    & " pro_status='" & guardaComboStatusC(f7.cmbStatus.SelectedItem) & "' " _
                                    & " where pro_idProyecto=" & stridProy & " and pro_nroContrato='" & ContNro & "' and pro_nroCuenta='" & CtaNro & "'")

                Else
                    id = Val(f7.lblid.Text)
                    stridProy = id
                    id = idProyecto(id)
                    ConexionSQL()
                    cntSQL.Execute("insert into tab_DatosPpalProy_Compl (pro_idProyecto,	pro_nroProyecto,pro_nroContrato," _
                                 & " pro_nroCuenta,pro_serieCuenta,pro_FechaD,pro_FechaH,pro_TrabajoR,pro_FechaR,pro_PresInsp,pro_FechaP, pro_NroFactura,pro_status) values (  '" & id & "', " _
                                       & "'" & f7.tbxCodp.Text & "', " _
                                       & " '" & f7.tbxNroCon.Text & "', " _
                                       & " '" & CtaNro & "', " _
                                       & " '" & f7.txtCuenta1.Text & "', " _
                                       & " '" & Format(f7.dtpFd1.Value, "yyyyMMdd") & "', " _
                                       & " '" & Format(f7.dtpFH1.Value, "yyyyMMdd") & "', " _
                                       & "  " & Replace(IIf(f7.tbxTraR1.Text = "", 0, f7.tbxTraR1.Text), ",", "") & ", " _
                                       & " '" & Format(f7.dtpFechaR1.Value, "yyyyMMdd") & "', " _
                                       & "  " & Replace(IIf(f7.txtInsp1.Text = "", 0, f7.txtInsp1.Text), ",", "") & ", " _
                                       & " '" & Format(f7.dtpPIns1.Value, "yyyyMMdd") & "', " _
                                       & " '' , " _
                                       & " '" & guardaComboStatusC(f7.cmbStatus.SelectedItem) & "')")

                    stridProy = id
                End If
            End If


        Catch ex As Exception
            MsgBox("Error en funcion insertaDatosComplProyf7()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swguar = 1
        End Try
    End Sub



    Sub GuardarALLproyf7()
        swguar = 0
        ConexionSQL()
        Try
            If f7.tbxDescr.Text <> "" Then
                guardaActDPpalProyf7()
                guardaActProyeDRespf7()

                'tablas que crecen segun los datos de Facturas y Recibos

                'guardaActProyeDFactf7()
                'guardaActProyeDCostosf7()


            Else
                MsgBox("Debe Ingresar Descripción del Proyecto....")
                f7.tbxDescr.Focus()
            End If
        Catch ex As Exception
            MsgBox("Error en funcion GuardarALLproy" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Sub ConsultarALLproy()


        Try
            If swMenuPpal = "3" Then
                clearFormularios1()
            Else
                ConsultasDPpal()
                ConsultasDEntesFact()
                ConsultasDFact()
                ConsultasDCostos()
            End If


        Catch ex As Exception
            MsgBox("Error en funcion ConsultarALLproy" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub
    Sub ConsultarALLproyF7()
        Try


            ConsultasDPpalf7()
            ConsultasDEntesFactf7()
            ConsultasDFactf7()
            ConsultasDCostosf7()
            ConsultasDAdf7()


        Catch ex As Exception
            MsgBox("Error en funcion ConsultarALLproyf7" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub
    Sub llenarNrocta()
        Try
            ConexionSQL()
            Dim strDatos As New ADODB.Recordset
            Dim i As Integer = 0
            f7.ltwCtas.Items.Clear()

            strDatos = cntSQL.Execute("select [pro_nroProyecto] ,[pro_nroContrato] ,[pro_nroCuenta], pro_serieCuenta, isnull(pro_NroFactura,'') pro_NroFactura from tab_DatosPpalProy_Compl where pro_nroContrato='" & ContNro & "' and pro_nroProyecto='" & ProyNro & "'")

            Do While Not strDatos.EOF

                f7.ltwCtas.Items.Add(ProyNro)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_nroContrato").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_nroCuenta").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_serieCuenta").Value)
                f7.ltwCtas.Items(i).SubItems.Add(strDatos.Fields("pro_NroFactura").Value)
                i += 1
                strDatos.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Error en buscar Nro de llenarNrocta()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub
    Sub ConsultasDCostosf15()
        'Try
        '    ConexionSQL()
        '    Dim strDCostos As New ADODB.Recordset
        '    strDCostos = cntSQL.Execute("select  * from tab_Aux_CostosFactProy where pro_idProyecto=" & stridProy & " and [pro_NroContrato]='" & ContNro & "' and [pro_NroRecibo]='" & RecNro & "' and [pro_NroFactura]='" & FactNro & "'")


        '    Do While Not strDCostos.EOF

        '        f15.dtpfCheq.Value = strDCostos.Fields("pro_FechaCheque").Value
        '        f15.tbxNroCheque.Text = strDCostos.Fields("pro_NroCheque").Value
        '        f15.cmbCtrlRec.SelectedIndex = strDCostos.Fields("pro_ControlRec").Value
        '        f15.cmbCtrlCheq.SelectedIndex = strDCostos.Fields("pro_ControlCheq").Value
        '        f15.tbxMtoCxC.Text = decimales(Math.Round(strDCostos.Fields("pro_MtoCobrar").Value, 2))
        '        'f15.cmbRango1.SelectedIndex = strDCostos.Fields("pro_Rango1").Value
        '        'f15.cmbRango2.SelectedIndex = strDCostos.Fields("pro_Rango2").Value
        '        'f15.cmbRango.SelectedIndex = strDCostos.Fields("pro_Rango").Value
        '        f15.tbxMonto2.Text = decimales(Math.Round(strDCostos.Fields("pro_Monto2").Value, 2))

        '        f15.cmbstatus.SelectedItem = buscaComboStatus(strDCostos.Fields("pro_Status").Value)
        '        f15.tbx_MesEje.Text = strDCostos.Fields("pro_MesEj").Value
        '        f15.tbxDocNext.Text = strDCostos.Fields("pro_DocNext").Value
        '        f15.tbxScafid.Text = strDCostos.Fields("pro_Scafid").Value
        '        f15.dtpFecRefr.Value = strDCostos.Fields("pro_FechaRefrendo").Value
        '        Exit Do
        '        strDCostos.MoveNext()
        '    Loop
        'Catch ex As Exception
        '    MsgBox("Error en funcion ConsultasDCostosf15" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        'End Try
    End Sub

    Sub ConsultarALLproyF15()
        Try



            ConsultasDPpalf15()

            If swMenuPpal <> 3 Then
                ConsultasDEntesFactf15()
                ConsultasDFactf151()
                ConsultasDCostosf15()
                'f15.llenarFactf15()
            Else
                '  f15.tbxCodp.Focus()
            End If


        Catch ex As Exception
            MsgBox("Error en funcion ConsultarALLproyf15" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub
    Sub clearFormularios()

        Try
            CtaNro = 0
            ProyNro = ""
            ContNro = ""
            RecNro = ""
            FactNro = ""
            idProy = 0
            clearDPpal()
            clearEntes()
            clearDfact()
            clearDCostos()



        Catch ex As Exception
            MsgBox("Error en funcion clearFormularios()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try


    End Sub
    Sub clearFormularios15()

        Try
            CtaNro = 0
            ProyNro = ""
            ContNro = ""
            RecNro = ""
            FactNro = ""
            idProy = 0
            clearDPpal15()
            clearEntes15()
            clearDfact15()
            clearDCostos15()

        Catch ex As Exception
            MsgBox("Error en funcion clearFormularios()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try


    End Sub
    Sub clearFormularios1()

        Try
            CtaNro = 0
            ProyNro = ""
            ContNro = ""
            RecNro = ""
            FactNro = ""
            idProy = 0
            clearDPpal1()
            clearComplDppal()
            clearEntes()
            clearDfact()
            clearDCostos()

        Catch ex As Exception
            MsgBox("Error en funcion clearFormularios()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try


    End Sub
    'Sub clearFormularios1()

    '    Try
    '        CtaNro = 0
    '        ProyNro = ""
    '        ContNro = ""
    '        RecNro = ""
    '        FactNro = ""
    '        idProy = 0
    '        clearDPpal1()
    '        clearEntes()
    '        clearDfact()
    '        clearDCostos()

    '    Catch ex As Exception
    '        MsgBox("Error en funcion clearFormularios()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
    '    End Try


    'End Sub
    Sub clearFormularios1f7()

        Try
            CtaNro = 0
            ProyNro = ""
            ContNro = ""
            RecNro = ""
            FactNro = ""
            f7.lbltiproy.Text = "."
            idProy = 0
            clearDPpal1f7()
            clearDcompl()
            clearEntesf7()
            clearDfactf7()
            clearDCostosf7()

        Catch ex As Exception
            MsgBox("Error en funcion clearFormulariosf7()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try


    End Sub
    Sub clearEntes()


        f1.tbxCont.Text = ""
        f1.tbxClient.Text = ""
        f1.tbxGProy.Text = ""
        f1.tbxIng.Text = ""
        f1.tbxCorCMop.Text = ""
        f1.tbxGob.Text = ""
        f1.tbxEncG.Text = ""
        f1.tbxMtoT.Text = ""
        f1.dtpFecT.Value = Date.Now
        f1.dtpAnAnt.Value = Date.Now
        f1.dtpfecTraFac1.Value = Date.Now
        f1.dtpfecTraFac.Value = Date.Now
        f1.tbxMespro.Text = ""
        f1.tbxAnalista.Text = ""
    End Sub
    Sub clearEntesf7()


        f7.tbxCont1.Text = ""
        f7.tbxCliente.Text = ""
        f7.tbxGProy.Text = ""
        f7.tbxIng1.Text = ""
        f7.tbxCorCMop1.Text = ""
        f7.tbxGob1.Text = ""
        f7.tbxEncG1.Text = ""
        f7.tbxGProy1.Text = ""
        f7.tbxMtoT1.Text = ""
        f7.dtpFecT1.Value = Date.Now
        f7.dtpAnAnt1.Value = Date.Now
        f7.dtpfecTraFac11.Value = Date.Now
        f7.dtpfecTraFac12.Value = Date.Now
        f7.tbxMespro1.Text = ""
        f7.tbxAnalista.Text = ""

    End Sub
    Sub clearEntes15()


        'f15.tbxCont.Text = ""
        'f15.tbxClient.Text = ""
        'f15.tbxGProy.Text = ""
        'f15.tbxIng.Text = ""
        'f15.tbxCorCMop.Text = ""
        'f15.tbxGob.Text = ""
        'f15.tbxEncG.Text = ""
        'f15.tbxMtoT.Text = ""
        'f15.dtpFecT.Value = Date.Now
        'f15.dtpAnAnt.Value = Date.Now
        'f15.dtpfecTraFac.Value = Date.Now
        'f15.dtpfecTraFac1.Value = Date.Now
        'f15.tbxMespro.Text = ""

    End Sub
    Sub clearDFisc()
        'f1.tbxCtasoc.Text = ""
        'f1.tbxAds.Text = ""
        'f1.tbxMtoMan.Text = ""
        'f1.tbxDt.Text = ""
        'f1.tbxPor.Text = ""
        'f1.tbxMtoAnt.Text = ""
        'f1.tbxReten.Text = ""
        'f1.dtpFechaRet.Value = Date.Now
        'f1.tbxMulta.Text = ""
    End Sub
    Sub clearDCostos()

        'f1.dtpfCheq.Value = Date.Now
        f1.tbxNroCheque.Text = ""
        f1.tbxMtoCxC.Text = ""
        f1.tbxMonto2.Text = ""
        f1.tbx_MesEje.Text = ""
        f1.tbxDocNext.Text = ""
        f1.tbxScafid.Text = ""
        ' f1.dtpFecRefr.Value = Date.Now
        f1.cmbCtrlRec.SelectedIndex = -1
        f1.cmbCtrlCheq.SelectedIndex = -1
        f1.cmbRango1.SelectedIndex = -1
        f1.cmbRango2.SelectedIndex = -1
        f1.cmbRango.SelectedIndex = -1

        f1.cmbstatus.SelectedIndex = -1

    End Sub
    Sub clearDCostosf7()

        'f7.dtpfCheq.Value = Date.Now
        'f7.tbxNroCheque.Text = ""
        'f7.tbxMtoCxC.Text = ""
        'f7.tbxMonto2.Text = ""
        'f7.tbx_MesEje.Text = ""
        'f7.tbxDocNext.Text = ""
        'f7.tbxScafid.Text = ""
        'f7.dtpFecRefr.Value = Date.Now
        'f7.cmbCtrlRec.SelectedIndex = -1
        'f7.cmbCtrlCheq.SelectedIndex = -1
        'f7.cmbRango1.SelectedIndex = -1
        'f7.cmbRango2.SelectedIndex = -1
        'f7.cmbRango.SelectedIndex = -1

        'f7.cmbstatus.SelectedIndex = -1

    End Sub
    Sub clearDCostos15()

        ' f15.dtpfCheq.Value = Date.Now
        f15.tbxMtoITBMS.Text = "0"

        f15.tbxNroCheque.Text = "0"
        f15.tbxMtoCxC.Text = "0"
        f15.tbxMonto2.Text = "0"
        f15.tbx_MesEje.Text = ""
        f15.tbxDocNext.Text = ""
        f15.tbxScafid.Text = ""
        ' f15.dtpFecRefr.Value = Date.Now
        f15.tbxMtoCheq.Text = "0"
        f15.cmbCtrlRec.SelectedIndex = -1
        f15.cmbCtrlCheq.Text = "Seleccione"
        f15.cmbRango1.SelectedIndex = -1
        f15.cmbRango2.SelectedIndex = -1
        f15.cmbRango.SelectedIndex = -1
        f15.tbxNrocta.Text = ""
        f15.dtpFecEs.Value = Date.Now
        f15.cmbstatus.SelectedIndex = -1
        f15.chkrec.Checked = True

    End Sub
    Sub clearDfact()

        f1.tbxNroReci.Text = ""

        f1.tbxNroFac.Text = ""

        f1.tbxFac.Text = ""
        f1.cmbRe10.SelectedIndex = -1
        f1.tbxMtoRet.Text = ""
        f1.tbxAntMont.Text = ""
        f1.tbxPena.Text = ""
        f1.tbxDocNext.Text = ""
        f1.tbxRetMtoITBMS.Text = ""
        f1.tbxCxC.Text = ""
        f1.cmbEnInsp.SelectedIndex = -1


    End Sub
    'Sub clearDfactf7()

    '    f7.tbxNroReci.Text = ""

    '    f7.tbxNroFac.Text = ""

    '    f7.tbxFac.Text = ""
    '    f7.cmbRe10.SelectedIndex = -1
    '    f7.tbxMtoRet.Text = ""
    '    f7.tbxAntMont.Text = ""
    '    f7.tbxPena.Text = ""
    '    f7.tbxDocNext.Text = ""
    '    f7.tbxRetMtoITBMS.Text = ""
    '    f7.tbxCxC.Text = ""
    '    f7.cmbEnInsp.SelectedIndex = -1


    'End Sub
    Sub clearDfactf7()

        'f7.tbxNroReci.Text = ""

        'f7.tbxNroFac.Text = ""

        'f7.tbxFac.Text = ""
        'f7.cmbRe10.SelectedIndex = -1
        'f7.tbxMtoRet.Text = ""
        'f7.tbxAntMont.Text = ""
        'f7.tbxPena.Text = ""
        'f7.tbxDocNext.Text = ""
        'f7.tbxRetMtoITBMS.Text = ""
        'f7.tbxCxC.Text = ""
        'f7.cmbEnInsp.SelectedIndex = -1


    End Sub
    Sub clearDfact15()

        f15.tbxNroReci.Text = ""

        f15.tbxNroFac.Text = ""
        f15.tbxSaldoFact.Text = ""
        f15.tbxFac.Text = "0"
        f15.cmbRe10.SelectedIndex = -1
        f15.tbxMtoRet.Text = "0"
        f15.tbxAntMont.Text = "0"
        f15.tbxPena.Text = "0"
        f15.tbxDocNext.Text = ""
        f15.tbxRetMtoITBMS.Text = "0"
        f15.tbxCxC.Text = "0"
        f15.cmbEnInsp.SelectedIndex = -1
        f15.tbxNrocta.Text = ""
        f15.dtpFecEnt.Value = "1900-01-01"


    End Sub

    Sub clearDPpal()
        f1.tbxCodp.Text = ""
        ' If swc = 1 Then
        f1.tbxDescr.Text = ""
        f1.tbxNroCon.Text = ContNro

        ' Else
        f1.cmbClas.SelectedIndex = -1
        f1.tbxNroCon.Text = ""
        f1.tbxUbi.Text = ""
        f1.txtMonto.Text = ""
        '  f1.txtCuenta.Text = ""

        '   f1.tbxTraR.Text = ""

        ' f1.txtInsp.Text = ""

        'f1.cmbperPagCtas.SelectedIndex = -1
        'f1.txtDur.Text = ""

        'f1.cmbxSta.SelectedIndex = -1
        ' f1.cmbTipo.SelectedIndex = -1
        ' End If

        swc = 0
    End Sub
    Sub clearDPpal1()

        f1.tbxCodp.Text = ""
        f1.cmbClas.SelectedIndex = -1
        f1.tbxDescr.Text = ""
        f1.tbxNroCon.Text = ""
        f1.tbxUbi.Text = ""
        f1.txtMonto.Text = ""

        ' End If

        swc = 0
    End Sub
    Sub clearComplDppal()

        ' f1.tbxTraR.Text = ""
        f1.lblClient.Text = ""
        f1.lblCont.Text = ""
        ' f1.txtInsp.Text = ""

        ' f1.cmbperPagCtas.SelectedIndex = -1
        'f1.txtDur.Text = ""


        ' f1.cmbxSta.SelectedIndex = -1
        'f1.cmbTipo.SelectedIndex = -1
        swc = 0
    End Sub
    Public Function buscarCont(ByVal strCodContrat As String)

        Dim strcon As ADODB.Recordset
        Try

            strcon = cntSQL.Execute("select pro_codContratista, pro_DescrContratista, path_conexion from  [tab_Contratistaproy] where [pro_codContratista]='" & strCodContrat & "'")

            If strcon.EOF = True Then
                pathContr = ""
            Else
                Do While Not strcon.EOF
                    contratista = strcon.Fields("pro_codContratista").Value
                    pathContr = strcon.Fields("path_conexion").Value
                    lblCon = strcon.Fields("pro_DescrContratista").Value
                    Exit Do
                Loop
            End If


        Catch ex As Exception
            MsgBox("Error en funcion buscarCont" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

        Return contratista
    End Function

    Public Function buscarClient(ByVal strCodClient As String)
        Dim cliente As String = ""
        Dim strcli As ADODB.Recordset
        Try

            strcli = cntSQL.Execute("select  pro_codCliente, pro_DescripcionCliente from  [tab_ClienteProy] where [pro_codCliente]='" & strCodClient & "'")


            Do While Not strcli.EOF
                cliente = strcli.Fields("pro_codCliente").Value
                lblCli = strcli.Fields("pro_DescripcionCliente").Value
                strcli.MoveNext()
            Loop

        Catch ex As Exception
            MsgBox("Error en funcion buscarClient" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

        Return cliente
    End Function

    Sub clearDPpal1f7()

        f7.tbxCodp.Text = ""
        f7.cmbClas.SelectedIndex = -1
        f7.tbxDescr.Text = ""
        f7.tbxNroCon.Text = ""
        f7.tbxUbi.Text = ""
        f7.txtMonto.Text = ""
        f7.tbxAdendas.Text = ""
        f7.tbxAdendas.Text = ""
        f7.txtItbAd.Text = ""
        f7.txtAdT.Text = ""
        f7.txtItbContAd.Text = ""
        f7.txtDurCont.Text = ""
        f7.txtDurOri.Text = ""
        swc = 0

    End Sub
    Sub clearDcompl()
        f7.txtCuenta1.Text = ""
        f7.lblclient1.Text = ""
        f7.lblcont1.Text = ""
        f7.tbxTraR1.Text = ""
        f7.txtInsp1.Text = ""
        f7.txtDurCont.Text = ""
        f7.txtDurOri.Text = ""
        swc = 0
    End Sub
    Sub clearCtas()
        f7.ltwCtas.Items.Clear()
        f7.txtCuenta1.Text = ""
        f7.dtpFd1.Value = Date.Now
        f7.dtpFH1.Value = Date.Now
        f7.tbxTraR1.Text = ""
        f7.dtpFechaR1.Value = Date.Now
        f7.txtInsp1.Text = ""
        f7.dtpPIns1.Value = Date.Now

    End Sub
    Sub clearDPpal15()

        swc = 0
    End Sub

    Public Function idProyecto(ByVal id As Integer)
        ConexionSQL()
        Try
            Dim strId As New ADODB.Recordset
            strId = cntSQL.Execute("select max([id_proyecto])as id_proyecto from [tab_idProyecto] where Nro_proyecto='" & ProyNro & "'")


            Do While Not strId.EOF
                idProy = IIf(strId.Fields("id_proyecto").Value Is DBNull.Value, 0, strId.Fields("id_proyecto").Value)
                strId.MoveNext()
            Loop


            If idProy = 0 Then

                strId = cntSQL.Execute("select max([id_proyecto])as id_proyecto from [tab_idProyecto]")

                Do While Not strId.EOF
                    idProy = strId.Fields("id_proyecto").Value
                    idProy += 1
                    strId.MoveNext()
                Loop
                cntSQL.Execute("insert into tab_idProyecto(id_proyecto, Nro_proyecto,desc_Proyecto ) values (" & idProy & ", '" & strCodProy & "', '" & UCase(strDescProy) & "')")
            Else

                cntSQL.Execute("Update tab_idProyecto set desc_Proyecto='" & UCase(strDescProy) & "' where id_proyecto= " & idProy & " and Nro_proyecto= '" & strCodProy & "'")
            End If



            f1.lblid.Text = idProy
            stridProy = idProy

            strId.Close()
            strId = Nothing

        Catch ex As Exception
            MsgBox("Error en funcion idProyecto" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try


        Return idProy

    End Function

    Public Function insertNroRec(ByVal id As Decimal, ByVal NroProy As String, ByVal NroCont As String, ByVal Rec As String, ByVal Fact As String)
        ConexionSQL()
        Dim sw As Integer = 0
        Try
            Dim strNro As New ADODB.Recordset
            Dim preg As String = ""
            Dim strcta As New ADODB.Recordset
            Dim i As Integer = 1
            'si no existe los datos del nro proyecto y el nro de contrato

            'inserta nro de recibo
            If swRec = 1 Then
                strNro = cntSQL.Execute("SELECT cta_Nro, [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]  FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='" & Fact & "' ")

                'inserta la factura
                If strNro.EOF = False Then

                    strcta = cntSQL.Execute("SELECT max(cta_Nro) as cta_Nro FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "'")

                    If strcta.EOF = False Then
                        i = i + Val(IIf(strcta.Fields("cta_Nro").Value Is DBNull.Value, 0, strcta.Fields("cta_Nro").Value))
                    End If


                    cntSQL.Execute("insert into [tab_NrosReciboProy](cta_Nro,[id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]) values (" & i & "," & id & ", '" & NroProy & "', '" & NroCont & "','" & Rec & "', '" & Fact & "')")
                    FactNro = Fact

                    CtaNro = i
                End If
                RecNro = Rec


            End If

            'actualiza nro de recibo
            If swRec = 2 Then



                'luego preguntamos si ya esta cargado un dato del contrato
                strNro = cntSQL.Execute("SELECT cta_Nro, [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]  FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='" & Fact & "' and nro_recibo='" & Rec1 & "'")

                If strNro.EOF = False Then

                    cntSQL.Execute("UPDATE [tab_NrosReciboProy] SET nro_recibo='" & Rec & "' WHERE [id_proyecto] =" & id & " and [nro_proyecto]= '" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='" & Fact & "' and nro_recibo='" & Rec1 & "' ")
                    RecNro = Rec1
                End If


                'verificamos que exista la factura en la tabla de recibos
                strNro = cntSQL.Execute("SELECT cta_Nro, [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]  FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='" & Fact & "' ")

                'inserta la factura
                If strNro.EOF = False Then

                    strcta = cntSQL.Execute("SELECT max(cta_Nro) as cta_Nro FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "'")

                    If strcta.EOF = False Then
                        i = i + Val(IIf(strcta.Fields("cta_Nro").Value Is DBNull.Value, 0, strcta.Fields("cta_Nro").Value))
                    End If

                    cntSQL.Execute("insert into [tab_NrosReciboProy](cta_Nro,[id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]) values (" & i & "," & id & ", '" & NroProy & "', '" & NroCont & "','" & Rec & "', '" & Fact & "')")
                    FactNro = Fact

                    CtaNro = i

                End If



            End If




            If swMenuPpal = 0 Then
                f1.tbxNroReci.Text = Rec
                f1.tbxNroFac.Text = Fact
            End If

            If swMenuPpal = 1 Then
                f15.tbxNroReci.Text = Rec
                f15.tbxNroFac.Text = Fact
            End If
            If swMenuPpal = 2 Then
                'f7.tbxNroReci.Text = Rec
                'f7.tbxNroFac.Text = Fact
            End If

        Catch

        End Try
        swRec = 0
        Return RecNro

    End Function
    Public Function insertNroFact(ByVal id As Decimal, ByVal NroProy As String, ByVal NroCont As String, ByVal Rec As String, ByVal Fact As String)
        ConexionSQL()
        Dim sw As Integer = 0
        Try
            Dim strNro As New ADODB.Recordset
            Dim preg As String = ""
            Dim swfact As Integer = 0
            Dim strcta As New ADODB.Recordset
            Dim i As Integer = 1
            'si no existe los datos del nro proyecto y el nro de contrato

            If NroCont <> "" Then


                strNro = cntSQL.Execute("SELECT cta_Nro, [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]  FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' ")

                'preguntar si es la primera factura añadida al contrato con el nro de cuenta 1
                Do While Not strNro.EOF

                    If strNro.Fields("cta_Nro").Value = 1 And strNro.Fields("nro_Factura").Value = "" And FactNro <> "" Then


                        '  frmInputRec.ShowDialog()


                        If swInput = 0 Then
                            swfact = 1
                            cntSQL.Execute("update [tab_NrosReciboProy]set [nro_Factura] ='" & Fact & "', nro_recibo='" & RecNro & "' where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='' AND  nro_recibo=''")
                            CtaNro = 1
                            swCtaFac = 1
                            If swMenuPpal = 0 Then
                                f1.tbxNroReci.Text = RecNro
                                f1.tbxNroFac.Text = Fact
                            End If

                            If swMenuPpal = 1 Then
                                f15.tbxNroReci.Text = RecNro
                                f15.tbxNroFac.Text = Fact
                            End If
                            If swMenuPpal = 2 Then
                                'f7.tbxNroReci.Text = RecNro
                                'f7.tbxNroFac.Text = Fact
                            End If

                            If swMenuPpal = 5 Then
                                f25.tbxNroReci.Text = RecNro
                                f25.tbxNroFac.Text = Fact
                            End If

                            swfact = 1

                        End If
                    End If




                    If strNro.Fields("cta_Nro").Value = 1 And strNro.Fields("nro_Factura").Value = "" And FactNro = "" And swfact = 0 Then

                        ' frmInputbox.ShowDialog()

                        If swInput = 0 Then
                            ' frmInputRec.ShowDialog()

                            swfact = 1
                            cntSQL.Execute("update [tab_NrosReciboProy]set [nro_Factura] ='" & Fact & "', nro_recibo='" & Rec & "' where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='' AND  nro_recibo=''")
                            CtaNro = 1

                            If swMenuPpal = 0 Then
                                f1.tbxNroReci.Text = RecNro
                                f1.tbxNroFac.Text = Fact
                            End If

                            If swMenuPpal = 1 Then
                                f15.tbxNroReci.Text = RecNro
                                f15.tbxNroFac.Text = Fact
                            End If
                            If swMenuPpal = 2 Then
                                'f7.tbxNroReci.Text = RecNro
                                'f7.tbxNroFac.Text = Fact
                            End If

                            If swMenuPpal = 5 Then
                                f25.tbxNroReci.Text = RecNro
                                f25.tbxNroFac.Text = Fact
                            End If
                            swfact = 1
                        End If

                        If strNro.Fields("nro_Factura").Value = Fact And Rec = "" Then
                            cntSQL.Execute("update [tab_NrosReciboProy]set [nro_Factura] ='" & Fact & "' where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='" & Fact & "'")
                            Exit Try
                        End If


                    End If
                    strNro.MoveNext()
                Loop



                If swfact = 0 Then
                    strNro = cntSQL.Execute("SELECT cta_Nro, [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]  FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' AND  [nro_Factura]='" & Fact & "'")

                    If strNro.EOF = True Then

                        preg = MsgBox("Nuevo Nro de Factura, desea Insertar ??? ", MsgBoxStyle.YesNo)

                        If preg = 6 Then


                            '  frmInputRec.ShowDialog()


                            If swMenuPpal = 0 Then
                                f1.tbxNroReci.Text = RecNro
                                f1.tbxNroFac.Text = Fact
                            End If

                            If swMenuPpal = 1 Then
                                f15.tbxNroReci.Text = RecNro
                                f15.tbxNroFac.Text = Fact
                            End If
                            If swMenuPpal = 2 Then
                                'f7.tbxNroReci.Text = RecNro
                                'f7.tbxNroFac.Text = Fact
                            End If
                            If swMenuPpal = 5 Then
                                f25.tbxNroReci.Text = RecNro
                                f25.tbxNroFac.Text = Fact
                            End If

                            strcta = cntSQL.Execute("SELECT max(cta_Nro) as cta_Nro FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' ")

                            If strcta.EOF = False Then
                                i = i + Val(IIf(strcta.Fields("cta_Nro").Value Is DBNull.Value, 0, strcta.Fields("cta_Nro").Value))
                            End If

                            cntSQL.Execute("insert into [tab_NrosReciboProy](cta_Nro,[id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]) values (" & i & "," & id & ", '" & NroProy & "', '" & NroCont & "','" & RecNro & "', '" & Fact & "')")
                            FactNro = Fact
                        End If
                        CtaNro = i

                    End If

                End If

            Else
                MsgBox("Debe indicar un Numero de Contrato", MsgBoxStyle.Critical, "Control Proyectos")
            End If

            FactNro = Fact


        Catch ex As Exception
            MsgBox("Error en funcion insertNroFact" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try


        Return idProy

    End Function
    Public Function insertNroCont(ByVal id As Decimal, ByVal NroProy As String, ByVal NroCont As String, ByVal Rec As String, ByVal Fact As String)
        ConexionSQL()
        Dim sw As Integer = 0
        Try
            Dim strNro As New ADODB.Recordset
            Dim ctaNro As Integer = 1
            Dim i As Integer = 0
            Dim preg As String = ""
            'si no existe los datos del nro proyecto y el nro de contrato
            Dim strcta As New ADODB.Recordset

            strNro = cntSQL.Execute("SELECT cta_Nro, [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura] FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' ")


            If strNro.EOF = True Then

                '    preg = MsgBox("Nuevo Nro de Contrato, desea Insertar ??? ", MsgBoxStyle.YesNo)

                '    If preg = 6 Then
                '        strcta = cntSQL.Execute("SELECT max(cta_Nro) as cta_Nro FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' ")

                '        If strcta.EOF = False Then
                '            i = i + Val(IIf(strcta.Fields("cta_Nro").Value Is DBNull.Value, 1, strcta.Fields("cta_Nro").Value))
                '            cntSQL.Execute("insert into [tab_NrosReciboProy](cta_Nro,[id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]) values (" & i & "," & id & ", '" & NroProy & "', '" & NroCont & "','', '')")
                '        End If

                '        RecNro = Rec

                '    End If
                '    ctaNro = i
                '    swc = 1


                '    'codigo agregado para cargar contrato nuevo 2019-01-21

                'Else
                strcta = cntSQL.Execute("SELECT max(cta_Nro) as cta_Nro FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' ")

                If strcta.EOF = False Then
                    i = i + Val(IIf(strcta.Fields("cta_Nro").Value Is DBNull.Value, 1, strcta.Fields("cta_Nro").Value))
                End If

                cntSQL.Execute("insert into [tab_NrosReciboProy](cta_Nro,[id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]) values (" & i & "," & id & ", '" & NroProy & "', '" & NroCont & "','', '')")
                RecNro = Rec

            End If

            ctaNro = i
            swc = 1

            ContNro = NroCont

        Catch ex As Exception
            MsgBox("Error en funcion insertNroCont" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try


        Return ContNro

    End Function
    Public Function Numeros(ByVal dato As String)
        Try


            If (dato <> String.Empty) Then
                ' Convertimos a Decimal el valor del control TextBox. Si
                ' el valor no se puede convertir a Decimal, se mostrará
                ' un 0 en lugar de producirse un error.
                '
                Dim importe As Decimal
                Decimal.TryParse(dato, importe)
                ' Formateamos a entero, sin decimales, el valor decimal obtenido.
                '
                dato = String.Format("{0:n}", importe)
                ' Establecemos el punto de inserción al final del valor del control TextBox.                '
                'dato.SelectionStart = dato.TextLength

            End If

        Catch ex As Exception
            MsgBox("Error en funcion Numeros" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

        Return dato
    End Function

    Public Function insertNroContimp(ByVal id As Decimal, ByVal NroProy As String, ByVal NroCont As String, ByVal Rec As String, ByVal Fact As String)
        ConexionSQL()
        Dim sw As Integer = 0
        Try
            Dim strNro As New ADODB.Recordset
            Dim ctaNro As Integer = 1
            Dim i As Integer = 0

            'si no existe los datos del nro proyecto y el nro de contrato
            Dim strcta As New ADODB.Recordset

            strNro = cntSQL.Execute("SELECT cta_Nro, [id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura] FROM tab_NrosReciboProy where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' ")


            If strNro.EOF = True Then


                strcta = cntSQL.Execute("SELECT max(cta_Nro) as cta_Nro FROM [dbo].[tab_NrosReciboProy] where [nro_proyecto] ='" & NroProy & "' and [nro_contrato]='" & NroCont & "' ")

                If strcta.EOF = False Then
                    i = i + Val(IIf(strcta.Fields("cta_Nro").Value Is DBNull.Value, 1, strcta.Fields("cta_Nro").Value))
                End If

                cntSQL.Execute("insert into [tab_NrosReciboProy](cta_Nro,[id_proyecto] ,[nro_proyecto] ,[nro_contrato],[nro_recibo],[nro_Factura]) values (" & i & "," & id & ", '" & NroProy & "', '" & NroCont & "','', '')")
                RecNro = Rec

                ctaNro = i
                swc = 1

            End If

        Catch ex As Exception
            MsgBox("Error en funcion insertNroCont" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try


        Return idProy

    End Function


    'CONSULTAS DE PROYECTOS   



    Sub guardaDPpalProy()
        ConexionSQL()
        Try
            Dim strPpal As New ADODB.Recordset

            strPpal = cntSQL.Execute("select pro_idProyecto from tab_DatosPpalProy where pro_idProyecto='" & stridProy & "' and pro_nroContrato='" & ContNro & "'")

            If strPpal.EOF = True Then

                Dim id As Integer = 0

                id = Val(f1.lblid.Text)
                stridProy = id

                'cntSQL.Execute("insert into tab_DatosPpalProy (pro_idProyecto,	pro_nroProyecto,pro_descripcion,pro_Sector,pro_nroContrato,pro_Provincia,pro_monto," _
                '             & " pro_nroCuenta,pro_FechaD,pro_FechaH,pro_TrabajoR,pro_FechaR,pro_PresInsp,pro_FechaP,pro_periodoCuenta," _
                '                & " pro_duracionProy, pro_FechaInicio, pro_FechaFinOrig, pro_status, pro_tipo) values (  '" & id & "', " _
                '                   & "'" & f1.tbxCodp.Text & "', " _
                '                   & " '" & f1.tbxDescr.Text & "', " _
                '                   & " '" & guardaComboSector(f1.cmbClas.SelectedIndex) & "', " _
                '                   & " '" & f1.tbxNroCon.Text & "', " _
                '                   & " '" & f1.tbxUbi.Text & "', " _
                '                   & "  " & Replace(IIf(f1.txtMonto.Text = "", 0, f1.txtMonto.Text), ",", ".") & ", " _
                '                   & " '" & f1.txtCuenta.Text & "', " _
                '                   & " '" & Format(f1.dtpFd.Value, "yyyyMMdd") & "', " _
                '                   & " '" & Format(f1.dtpFH.Value, "yyyyMMdd") & "', " _
                '                   & "  " & Replace(IIf(f1.tbxTraR.Text = "", 0, f1.tbxTraR.Text), ",", ".") & ", " _
                '                   & " '" & Format(f1.dtpFechaR.Value, "yyyyMMdd") & "', " _
                '                   & "  " & Replace(IIf(f1.txtInsp.Text = "", 0, f1.txtInsp.Text), ",", ".") & ", " _
                '                   & " '" & Format(f1.dtpPIns.Value, "yyyyMMdd") & "', " _
                '                   & " '" & guardacmbperPagCtas(f1.cmbperPagCtas.SelectedItem) & "', " _
                '                   & " '" & f1.txtDur.Text & "', " _
                '                   & " '" & Format(f1.dtpFechai.Value, "yyyyMMdd") & "', " _
                '                   & " '" & Format(f1.dtpFfOp.Value, "yyyyMMdd") & "', " _
                '                   & " '" & guardaComboStatus(f1.cmbxSta.SelectedItem) & "', " _
                '                   & " '" & guardaComboTipo(f1.cmbTipo.SelectedItem) & "')")

                stridProy = id
            End If

        Catch ex As Exception
            MsgBox("Error en funcion guardaActDPpalProy" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swguar = 1
        End Try

    End Sub
    Sub guardaActDPpalProy()
        ConexionSQL()
        Try
            Dim strPpal As New ADODB.Recordset
            Dim id As Integer = 0

            If ContNro = "" Then
                id = Val(f1.lblid.Text)
                stridProy = id
                id = idProyecto(id)
                ConexionSQL()

                'VALIDA QUE NO EXISTA NRO DE PROYECTO
                strPpal = cntSQL.Execute("select pro_idProyecto from tab_DatosPpalProy where pro_idProyecto='" & stridProy & "'")


                If strPpal.EOF = False Then

                    MsgBox("Proyecto se encuentra Registrado, por favor verifique!!", MsgBoxStyle.Critical, "Control Proyectos")

                Else

                    id = Val(f1.lblid.Text)
                    stridProy = id
                    id = idProyecto(id)
                    ConexionSQL()
                    cntSQL.Execute("insert into tab_DatosPpalProy (pro_idProyecto,	pro_nroProyecto,pro_descripcion,pro_Sector,pro_nroContrato,pro_Provincia,pro_monto,pro_Adendasmonto, pro_AdendasmontoITBMS,pro_AdendasContITBMS,pro_AdendasTiempo,pro_duracionCont, " _
                                 & " pro_FechaD, pro_FechaH,pro_FechaOrg, pro_status, pro_tipo, pro_duracionOriginalCont,pro_ITBMS) values (  '" & id & "', " _
                                     & " '" & f1.tbxCodp.Text & "', " _
                                     & " '" & f1.tbxDescr.Text & "', " _
                                     & " '" & guardaComboSector(f1.cmbClas.SelectedItem) & "', " _
                                     & " '" & f1.tbxNroCon.Text & "', " _
                                     & " '" & f1.tbxUbi.Text & "', " _
                                     & "  " & Replace(IIf(f1.txtMonto.Text = "", 0, f1.txtMonto.Text), ",", "") & " , " _
                                     & " 0, " _
                                     & " 0, " _
                                     & " 0, " _
                                     & " 0, " _
                                     & " 0, " _
                                     & " '19000101', " _
                                     & " '19000101', " _
                                     & " '19000101', " _
                                     & " 0, " _
                                     & " 0, " _
                                     & " 0,0)")

                    stridProy = id
                End If
            End If


            If ContNro <> "" Then
                id = Val(f1.lblid.Text)
                stridProy = id
                id = idProyecto(id)
                ConexionSQL()

                'VALIDA QUE NO EXISTA NRO DE PROYECTO
                strPpal = cntSQL.Execute("select pro_idProyecto from tab_DatosPpalProy where pro_idProyecto='" & stridProy & "' and pro_nroContrato='" & ContNro & "'")


                If strPpal.EOF = False Then
                  
                    MsgBox("Proyecto se encuentra Registrado, por favor verifique!!", MsgBoxStyle.Critical, "Control Proyectos")
                Else
                    id = Val(f1.lblid.Text)
                    stridProy = id
                    id = idProyecto(id)
                    ConexionSQL()

                    cntSQL.Execute("insert into tab_DatosPpalProy (pro_idProyecto,	pro_nroProyecto,pro_descripcion,pro_Sector,pro_nroContrato,pro_Provincia,pro_monto,pro_Adendasmonto, pro_AdendasmontoITBMS,pro_AdendasContITBMS,pro_AdendasTiempo,pro_duracionCont, " _
                                   & " pro_FechaD, pro_FechaH,pro_FechaOrg, pro_status, pro_tipo, pro_duracionOriginalCont,pro_ITBMS) values (  '" & id & "', " _
                                       & " '" & f1.tbxCodp.Text & "', " _
                                       & " '" & f1.tbxDescr.Text & "', " _
                                       & " '" & guardaComboSector(f1.cmbClas.SelectedItem) & "', " _
                                       & " '" & f1.tbxNroCon.Text & "', " _
                                       & " '" & f1.tbxUbi.Text & "', " _
                                       & "  " & Replace(IIf(f1.txtMonto.Text = "", 0, f1.txtMonto.Text), ",", "") & " , " _
                                       & " 0, " _
                                       & " 0, " _
                                       & " 0, " _
                                       & " 0, " _
                                       & " 0, " _
                                       & " '19000101', " _
                                       & " '19000101', " _
                                       & " '19000101', " _
                                       & " 0, " _
                                       & " 0, " _
                                       & " 0, 0)")

                    stridProy = id

                End If
            End If


        Catch ex As Exception
            MsgBox("Error en funcion guardaActDPpalProy" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swguar = 1
        End Try

    End Sub

    Sub guardaActDPpalProyf7()
        'ConexionSQL()
        Try
            Dim strPpal As New ADODB.Recordset
            Dim id As Integer = 0

            strDescProy = f7.tbxDescr.Text

            If ContNro = "" Then
                id = Val(f7.lblid.Text)
                stridProy = id
                id = idProyecto(id)
                ConexionSQL()
                'VALIDA QUE NO EXISTA NRO DE PROYECTO
                strPpal = cntSQL.Execute("select pro_idProyecto from tab_DatosPpalProy where pro_idProyecto='" & stridProy & "'")


                If strPpal.EOF = False Then
                    cntSQL.Execute("UPDATE tab_DatosPpalProy SET pro_nroProyecto='" & f7.tbxCodp.Text & "', " _
                                    & " pro_nroContrato='" & f7.tbxNroCon.Text & "', " _
                                    & " pro_descripcion='" & f7.tbxDescr.Text & "', " _
                                    & " pro_Sector= '" & guardaComboSector(f7.cmbClas.SelectedItem) & "', " _
                                    & " pro_Provincia='" & f7.tbxUbi.Text & "', " _
                                    & " pro_monto=" & Replace(IIf(f7.txtMonto.Text = "", 0, f7.txtMonto.Text), ",", "") & ", " _
                                    & " pro_Adendasmonto=" & f7.tbxAdendas.Text & ", " _
                                    & " pro_AdendasmontoITBMS=" & f7.txtItbAd.Text & ", " _
                                    & " pro_AdendasContITBMS= " & f7.txtItbContAd.Text & ", " _
                                    & " pro_AdendasTiempo=" & f7.txtAdT.Text & ", " _
                                    & " pro_duracionCont=" & Replace(IIf(f7.txtDurCont.Text = "", 0, f7.txtDurCont.Text), ",", "") & ", " _
                                    & " pro_FechaD='" & Format(f7.dtpFecI.Value, "yyyyMMdd") & "', " _
                                    & " pro_FechaH='" & Format(f7.dtpFecF.Value, "yyyyMMdd") & "', " _
                                    & " pro_FechaOrg='" & Format(f7.dtpOriF.Value, "yyyyMMdd") & "', " _
                                    & " pro_status= " & guardaComboStatus(f7.cmbSt.SelectedItem) & ", " _
                                    & " pro_tipo=" & guardaComboTipo(f7.cmbTp.SelectedItem) & ", " _
                                    & " pro_duracionOriginalCont=" & Replace(IIf(f7.txtDurOri.Text = "", 0, f7.txtDurOri.Text), ",", "") & ", " _
                                    & " pro_ITBMS=" & Replace(IIf(f7.txtITBMS.Text = "", 0, f7.txtITBMS.Text), ",", "") & ", " _
                                    & " pro_diasCredito ='" & f7.tbxCreditos.Text & "' " _
                                    & " where pro_idProyecto=" & stridProy & "")

                Else

                    id = Val(f7.lblid.Text)
                    stridProy = id
                    id = idProyecto(id)
                    ConexionSQL()
                    cntSQL.Execute("insert into tab_DatosPpalProy (pro_idProyecto,	pro_nroProyecto,pro_descripcion,pro_Sector,pro_nroContrato,pro_Provincia,pro_monto,pro_Adendasmonto, pro_AdendasmontoITBMS,pro_AdendasContITBMS,pro_AdendasTiempo,pro_duracionCont, " _
                                   & " pro_FechaD, pro_FechaH, pro_FechaOrg, pro_status, pro_tipo, pro_duracionOriginalCont,pro_diasCredito) values (  '" & id & "', " _
                                       & " '" & f7.tbxCodp.Text & "', " _
                                       & " '" & f7.tbxDescr.Text & "', " _
                                       & " '" & guardaComboSector(f7.cmbClas.SelectedItem) & "', " _
                                       & " '" & f7.tbxNroCon.Text & "', " _
                                       & " '" & f7.tbxUbi.Text & "', " _
                                       & "  " & Replace(IIf(f7.txtMonto.Text = "", 0, f7.txtMonto.Text), ",", "") & " , " _
                                       & " " & f7.tbxAdendas.Text & ", " _
                                       & " " & f7.txtItbAd.Text & ", " _
                                       & " " & f7.tbxAdendas.Text & ", " _
                                       & " " & f7.txtItbAd.Text & ", " _
                                       & " " & Replace(IIf(f7.txtDurCont.Text = "", 0, f7.txtDurCont.Text), ",", "") & " ," _
                                       & " '" & Format(f7.dtpFecI.Value, "yyyyMMdd") & "', " _
                                       & " '" & Format(f7.dtpFecF.Value, "yyyyMMdd") & "', " _
                                        & " '" & Format(f7.dtpOriF.Value, "yyyyMMdd") & "', " _
                                       & " " & f7.tbxAdendas.Text & ", " _
                                       & " " & f7.txtItbAd.Text & ", " _
                                       & " " & guardaComboStatus(f7.cmbSt.SelectedItem) & "', " _
                                       & " " & guardaComboTipo(f7.cmbTp.SelectedItem) & "', " _
                                       & "" & Replace(IIf(f7.txtDurOri.Text = "", 0, f7.txtDurOri.Text), ",", "") & "," & Replace(IIf(f7.txtITBMS.Text = "", 0, f7.txtITBMS.Text), ",", "") & ",'" & f7.tbxCreditos.Text & "' )")

                    stridProy = id
                End If
            End If


            If ContNro <> "" Then
                id = Val(f7.lblid.Text)
                stridProy = id
                id = idProyecto(id)

                'VALIDA QUE NO EXISTA NRO DE PROYECTO
                ConexionSQL()
                strPpal = cntSQL.Execute("select pro_idProyecto from tab_DatosPpalProy where pro_idProyecto='" & stridProy & "' and pro_nroContrato='" & ContNro & "'")



                If strPpal.EOF = False Then
                    cntSQL.Execute("UPDATE tab_DatosPpalProy SET pro_nroProyecto='" & f7.tbxCodp.Text & "', " _
                                    & " pro_nroContrato='" & f7.tbxNroCon.Text & "', " _
                                    & " pro_descripcion='" & f7.tbxDescr.Text & "', " _
                                    & " pro_Sector= '" & guardaComboSector(f7.cmbClas.SelectedItem) & "', " _
                                    & " pro_Provincia='" & f7.tbxUbi.Text & "', " _
                                    & " pro_monto=" & Replace(IIf(f7.txtMonto.Text = "", 0, f7.txtMonto.Text), ",", "") & ", " _
                                    & " pro_Adendasmonto=" & Replace(IIf(f7.tbxAdendas.Text = "", 0, f7.tbxAdendas.Text), ",", "") & ", " _
                                    & " pro_AdendasmontoITBMS=" & Replace(IIf(f7.txtItbAd.Text = "", 0, f7.txtItbAd.Text), ",", "") & ", " _
                                    & " pro_AdendasContITBMS= " & Replace(IIf(f7.txtItbContAd.Text = "", 0, f7.txtItbContAd.Text), ",", "") & ", " _
                                    & " pro_AdendasTiempo=" & Replace(IIf(f7.txtAdT.Text = "", 0, f7.txtAdT.Text), ",", "") & ", " _
                                    & " pro_duracionCont=" & Replace(IIf(f7.txtDurCont.Text = "", 0, f7.txtDurCont.Text), ",", "") & ", " _
                                    & " pro_FechaD='" & Format(f7.dtpFecI.Value, "yyyyMMdd") & "', " _
                                    & " pro_FechaH='" & Format(f7.dtpFecF.Value, "yyyyMMdd") & "', " _
                                    & " pro_FechaOrg='" & Format(f7.dtpOriF.Value, "yyyyMMdd") & "', " _
                                    & " pro_status= " & guardaComboStatus(f7.cmbSt.SelectedItem) & ", " _
                                    & " pro_tipo=" & guardaComboTipo(f7.cmbTp.SelectedItem) & ", " _
                                    & " pro_duracionOriginalCont=" & Replace(IIf(f7.txtDurOri.Text = "", 0, f7.txtDurOri.Text), ",", "") & " , " _
                                    & " pro_ITBMS=" & Replace(IIf(f7.txtITBMS.Text = "", 0, f7.txtITBMS.Text), ",", "") & ", " _
                                    & " pro_diasCredito ='" & f7.tbxCreditos.Text & "' " _
                                    & " where pro_idProyecto=" & stridProy & " and pro_nroContrato='" & ContNro & "'")

                Else

                    id = Val(f7.lblid.Text)
                    stridProy = id
                    id = idProyecto(id)
                    ConexionSQL()
                    cntSQL.Execute("insert into tab_DatosPpalProy (pro_idProyecto,	pro_nroProyecto,pro_descripcion,pro_Sector,pro_nroContrato,pro_Provincia,pro_monto,pro_Adendasmonto, pro_AdendasmontoITBMS,pro_AdendasContITBMS,pro_AdendasTiempo,pro_duracionCont, " _
                                 & " pro_FechaD, pro_FechaH,pro_FechaOrg, pro_status, pro_tipo, pro_duracionOriginalCont,pro_diasCredito) values (  '" & id & "', " _
                                     & " '" & f7.tbxCodp.Text & "', " _
                                     & " '" & f7.tbxDescr.Text & "', " _
                                     & " '" & guardaComboSector(f7.cmbClas.SelectedItem) & "', " _
                                     & " '" & f7.tbxNroCon.Text & "', " _
                                     & " '" & f7.tbxUbi.Text & "', " _
                                     & "  " & Replace(IIf(f7.txtMonto.Text = "", 0, f7.txtMonto.Text), ",", "") & " , " _
                                     & " " & f7.tbxAdendas.Text & ", " _
                                     & " " & f7.txtItbAd.Text & ", " _
                                     & " " & f7.tbxAdendas.Text & ", " _
                                     & " " & f7.txtItbAd.Text & ", " _
                                     & " " & Replace(IIf(f7.txtDurCont.Text = "", 0, f7.txtDurCont.Text), ",", "") & ", " _
                                     & " '" & Format(f7.dtpFecI.Value, "yyyyMMdd") & "', " _
                                     & " '" & Format(f7.dtpFecF.Value, "yyyyMMdd") & "', " _
                                     & " '" & Format(f7.dtpOriF.Value, "yyyyMMdd") & "', " _
                                     & " " & guardaComboStatus(f7.cmbSt.SelectedItem) & ", " _
                                     & " " & guardaComboTipo(f7.cmbTp.SelectedItem) & ", " _
                                     & "" & Replace(IIf(f7.txtDurOri.Text = "", 0, f7.txtDurOri.Text), ",", "") & "," & Replace(IIf(f7.txtITBMS.Text = "", 0, f7.txtITBMS.Text), ",", "") & ",'" & f7.tbxCreditos.Text & "')")


                    stridProy = id
                End If
            End If


        Catch ex As Exception
            MsgBox("Error en funcion guardaActDPpalProyF7" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swguar = 1
        End Try

    End Sub

    Sub guardaActDPpalProy15()
        ConexionSQL()
        Try
            Dim strPpal As New ADODB.Recordset

            'If ContNro = "" Then

            '    'VALIDA QUE NO EXISTA NRO DE PROYECTO
            '    strPpal = cntSQL.Execute("select pro_idProyecto from tab_DatosPpalProy where pro_idProyecto='" & stridProy & "'")


            '    If strPpal.EOF = False Then
            '        cntSQL.Execute("UPDATE tab_DatosPpalProy SET pro_nroProyecto='" & f15.tbxCodp.Text & "', " _
            '                        & " pro_nroContrato='" & f15.tbxNroCon.Text & "', " _
            '                        & " pro_descripcion='" & f15.tbxDescr.Text & "', " _
            '                        & " pro_Sector= '" & f15.cmbClas.SelectedIndex & "', " _
            '                        & " pro_Provincia='" & f15.tbxUbi.Text & "', " _
            '                        & " pro_monto=" & Replace(IIf(f15.txtMonto.Text = "", 0, f15.txtMonto.Text), ",", "") & ", " _
            '                        & " pro_nroCuenta=" & IIf(f15.txtCuenta.Text = "", 1, f15.txtCuenta.Text) & ", " _
            '                        & " pro_FechaD='" & Format(f15.dtpFd.Value, "yyyyMMdd") & "', " _
            '                        & " pro_FechaH='" & Format(f15.dtpFH.Value, "yyyyMMdd") & "', " _
            '                        & " pro_TrabajoR=" & Replace(IIf(f15.tbxTraR.Text = "", 0, f15.tbxTraR.Text), ",", "") & ", " _
            '                        & " pro_FechaR='" & Format(f15.dtpFechaR.Value, "yyyyMMdd") & "', " _
            '                        & " pro_PresInsp= " & Replace(IIf(f15.txtInsp.Text = "", 0, f15.txtInsp.Text), ",", "") & ", " _
            '                        & " pro_FechaP='" & Format(f15.dtpPIns.Value, "yyyyMMdd") & "', " _
            '                        & " pro_periodoCuenta=" & Replace(IIf(f15.txtPercta.Text = "", 0, f15.txtPercta.Text), ",", "") & ", " _
            '                        & " pro_duracionProy=" & Replace(IIf(f15.txtDur.Text = "", 0, f15.txtDur.Text), ",", "") & ", " _
            '                        & " pro_FechaInicio ='" & Format(f15.dtpPIns.Value, "yyyyMMdd") & "', " _
            '                        & " pro_FechaFinOrig ='" & Format(f15.dtpFfOp.Value, "yyyyMMdd") & "', " _
            '                        & " pro_status='" & f15.cmbxSta.SelectedIndex & "', " _
            '                        & " pro_tipo='" & f15.cmbTipo.SelectedIndex & "' " _
            '                        & " where pro_idProyecto=" & stridProy & "")

            '    Else
            '        Dim id As Integer = 0
            '        id = f15.lblid.Text
            '        stridProy = id
            '        ' id = idProyecto(id)
            '        cntSQL.Execute("insert into tab_DatosPpalProy (pro_idProyecto,	pro_nroProyecto,pro_descripcion,pro_Sector,pro_nroContrato,pro_Provincia,pro_monto," _
            '                     & " pro_nroCuenta,pro_FechaD,pro_FechaH,pro_TrabajoR,pro_FechaR,pro_PresInsp,pro_FechaP,pro_periodoCuenta," _
            '                        & " pro_duracionProy, pro_FechaInicio, pro_FechaFinOrig, pro_status, pro_tipo) values (  '" & id & "', " _
            '                           & " '" & f15.tbxCodp.Text & "', " _
            '                           & " '" & f15.tbxDescr.Text & "', " _
            '                           & " '" & f15.cmbClas.SelectedIndex & "', " _
            '                           & " '" & f15.tbxNroCon.Text & "', " _
            '                           & " '" & f15.tbxUbi.Text & "', " _
            '                           & "  " & Replace(IIf(f15.txtMonto.Text = "", 0, f15.txtMonto.Text), ",", "") & ", " _
            '                           & " '" & f15.txtCuenta.Text & "', " _
            '                           & " '" & Format(f15.dtpFd.Value, "yyyyMMdd") & "', " _
            '                           & " '" & Format(f15.dtpFH.Value, "yyyyMMdd") & "', " _
            '                           & "  " & Replace(IIf(f15.tbxTraR.Text = "", 0, f15.tbxTraR.Text), ",", "") & ", " _
            '                           & " '" & Format(f15.dtpFechaR.Value, "yyyyMMdd") & "', " _
            '                           & "  " & Replace(IIf(f15.txtInsp.Text = "", 0, f15.txtInsp.Text), ",", "") & ", " _
            '                           & " '" & Format(f15.dtpPIns.Value, "yyyyMMdd") & "', " _
            '                           & " " & Replace(IIf(f15.txtPercta.Text = "", 0, f15.txtPercta.Text), ",", "") & ", " _
            '                           & " '" & f15.txtDur.Text & "', " _
            '                           & " '" & Format(f15.dtpFechai.Value, "yyyyMMdd") & "', " _
            '                           & " '" & Format(f15.dtpFfOp.Value, "yyyyMMdd") & "', " _
            '                           & " '" & f15.cmbxSta.SelectedIndex & "', " _
            '                           & " '" & f15.cmbTipo.SelectedIndex & "')")

            '        stridProy = id
            '    End If
            'End If


            'If ContNro <> "" Then

            '    'VALIDA QUE NO EXISTA NRO DE PROYECTO
            '    strPpal = cntSQL.Execute("select pro_idProyecto from tab_DatosPpalProy where pro_idProyecto='" & stridProy & "' and pro_nroContrato='" & ContNro & "'")


            '    If strPpal.EOF = False Then
            '        cntSQL.Execute("UPDATE tab_DatosPpalProy SET pro_nroProyecto='" & f15.tbxCodp.Text & "', " _
            '                           & " pro_nroContrato='" & f15.tbxNroCon.Text & "', " _
            '                        & " pro_descripcion='" & f15.tbxDescr.Text & "', " _
            '                        & " pro_Sector= '" & f15.cmbClas.SelectedIndex & "', " _
            '                        & " pro_Provincia='" & f15.tbxUbi.Text & "', " _
            '                        & " pro_monto=" & Replace(IIf(f15.txtMonto.Text = "", 0, f15.txtMonto.Text), ",", "") & ", " _
            '                        & " pro_nroCuenta=" & IIf(f15.txtCuenta.Text = "", 1, f15.txtCuenta.Text) & ", " _
            '                        & " pro_FechaD='" & Format(f15.dtpFd.Value, "yyyyMMdd") & "', " _
            '                        & " pro_FechaH='" & Format(f15.dtpFH.Value, "yyyyMMdd") & "', " _
            '                        & " pro_TrabajoR=" & Replace(IIf(f15.tbxTraR.Text = "", 0, f15.tbxTraR.Text), ",", "") & ", " _
            '                        & " pro_FechaR='" & Format(f15.dtpFechaR.Value, "yyyyMMdd") & "', " _
            '                        & " pro_PresInsp= " & Replace(IIf(f15.txtInsp.Text = "", 0, f15.txtInsp.Text), ",", "") & ", " _
            '                        & " pro_FechaP='" & Format(f15.dtpPIns.Value, "yyyyMMdd") & "', " _
            '                        & " pro_periodoCuenta=" & Replace(IIf(f15.txtPercta.Text = "", 0, f15.txtPercta.Text), ",", "") & ", " _
            '                        & " pro_duracionProy=" & Replace(IIf(f15.txtDur.Text = "", 0, f15.txtDur.Text), ",", "") & ", " _
            '                        & " pro_FechaInicio ='" & Format(f15.dtpPIns.Value, "yyyyMMdd") & "', " _
            '                        & " pro_FechaFinOrig ='" & Format(f15.dtpFfOp.Value, "yyyyMMdd") & "', " _
            '                        & " pro_status='" & f15.cmbxSta.SelectedIndex & "', " _
            '                        & " pro_tipo='" & f15.cmbTipo.SelectedIndex & "' " _
            '                        & " where pro_idProyecto=" & stridProy & " and pro_nroContrato='" & ContNro & "'")

            '    Else
            '        Dim id As Integer = 0
            '        id = f15.lblid.Text
            '        stridProy = id
            '        ' id = idProyecto(id)
            '        cntSQL.Execute("insert into tab_DatosPpalProy (pro_idProyecto,	pro_nroProyecto,pro_descripcion,pro_Sector,pro_nroContrato,pro_Provincia,pro_monto," _
            '                     & " pro_nroCuenta,pro_FechaD,pro_FechaH,pro_TrabajoR,pro_FechaR,pro_PresInsp,pro_FechaP,pro_periodoCuenta," _
            '                        & " pro_duracionProy, pro_FechaInicio, pro_FechaFinOrig, pro_status, pro_tipo) values (  '" & id & "', " _
            '                           & "'" & f15.tbxCodp.Text & "', " _
            '                           & " '" & f15.tbxDescr.Text & "', " _
            '                           & " '" & f15.cmbClas.SelectedIndex & "', " _
            '                           & " '" & f15.tbxNroCon.Text & "', " _
            '                           & " '" & f15.tbxUbi.Text & "', " _
            '                           & "  " & Replace(IIf(f15.txtMonto.Text = "", 0, f15.txtMonto.Text), ",", "") & ", " _
            '                           & " '" & f15.txtCuenta.Text & "', " _
            '                           & " '" & Format(f15.dtpFd.Value, "yyyyMMdd") & "', " _
            '                           & " '" & Format(f15.dtpFH.Value, "yyyyMMdd") & "', " _
            '                           & "  " & Replace(IIf(f15.tbxTraR.Text = "", 0, f15.tbxTraR.Text), ",", "") & ", " _
            '                           & " '" & Format(f15.dtpFechaR.Value, "yyyyMMdd") & "', " _
            '                           & "  " & Replace(IIf(f15.txtInsp.Text = "", 0, f15.txtInsp.Text), ",", "") & ", " _
            '                           & " '" & Format(f15.dtpPIns.Value, "yyyyMMdd") & "', " _
            '                           & " " & Replace(IIf(f15.txtPercta.Text = "", 0, f15.txtPercta.Text), ",", "") & ", " _
            '                           & " '" & f15.txtDur.Text & "', " _
            '                           & " '" & Format(f15.dtpFechai.Value, "yyyyMMdd") & "', " _
            '                           & " '" & Format(f15.dtpFfOp.Value, "yyyyMMdd") & "', " _
            '                           & " '" & f15.cmbxSta.SelectedIndex & "', " _
            '                           & " '" & f15.cmbTipo.SelectedIndex & "')")

            '        stridProy = id
            '    End If
            'End If


        Catch ex As Exception
            MsgBox("Error en funcion guardaActDPpalProy" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
            swguar = 1
        End Try

    End Sub

    'CONSULTAS DE PROYECTOS

    Sub ConsultasDPpal()
        ConexionSQL()
        Try
            Dim strPpal As New ADODB.Recordset
            Dim strNroRec As New ADODB.Recordset
            Dim swRec As Integer = 0
            If swMenuPpal <> "2" Then
                strPpal = cntSQL.Execute("select * from tab_DatosPpalProy where pro_idProyecto='" & stridProy & "'")


                Do While Not strPpal.EOF


                    strNroRec = cntSQL.Execute("select * from tab_NrosReciboProy where id_proyecto='" & stridProy & "'")

                    Do While Not strNroRec.EOF

                        swRec += 1

                        strNroRec.MoveNext()
                    Loop



                    If swRec = 0 Then

                        f1.tbxCodp.Text = strPpal.Fields("pro_nroProyecto").Value
                        f1.tbxDescr.Text = strPpal.Fields("pro_descripcion").Value

                        f1.cmbClas.SelectedItem = buscaComboSector(strPpal.Fields("pro_Sector").Value)
                        f1.tbxNroCon.Text = strPpal.Fields("pro_nroContrato").Value
                        f1.tbxUbi.Text = strPpal.Fields("pro_Provincia").Value
                        f1.txtMonto.Text = decimales(Math.Round(strPpal.Fields("pro_monto").Value, 2))


                        'f1.txtCuenta.Text = CtaNro 'strPpal.Fields("pro_nroCuenta").Value
                        'f1.dtpFd.Value = strPpal.Fields("pro_FechaD").Value
                        'f1.dtpFH.Value = strPpal.Fields("pro_FechaH").Value
                        'f1.tbxTraR.Text = decimales(Math.Round(strPpal.Fields("pro_TrabajoR").Value, 2))
                        'f1.dtpFechaR.Value = strPpal.Fields("pro_FechaR").Value
                        'f1.txtInsp.Text = decimales(Math.Round(strPpal.Fields("pro_PresInsp").Value, 2))
                        'f1.dtpPIns.Value = strPpal.Fields("pro_FechaP").Value
                        'f1.cmbperPagCtas.SelectedIndex = IIf(strPpal.Fields("pro_periodoCuenta").Value = "", 0, strPpal.Fields("pro_periodoCuenta").Value)
                        'f1.txtDur.Text = strPpal.Fields("pro_duracionProy").Value
                        'f1.dtpFechai.Value = strPpal.Fields("pro_FechaInicio").Value
                        'f1.dtpFfOp.Value = strPpal.Fields("pro_FechaFinOrig").Value
                        'f1.cmbxSta.SelectedIndex = IIf(strPpal.Fields("pro_status").Value = "", 0, strPpal.Fields("pro_status").Value)
                        'guardaComboTipo(f1.cmbTipo.SelectedItem)  = IIf(strPpal.Fields("pro_tipo").Value = "", 0, strPpal.Fields("pro_tipo").Value)

                        Exit Do

                    Else

                        f14 = frmContrRec
                        fcall = f14.Name
                        frmExplorer.cerrarForm()
                        frmSubmenup.Close()
                        f14.ShowDialog()
                        swF = 0

                        If swMenuPpal <> "2" Then
                            f14.consultaProyDppal()
                            Exit Do
                        Else
                            clearFormularios1()
                            Exit Do
                        End If

                    End If


                    strPpal.MoveNext()
                Loop


            End If

        Catch ex As Exception
            MsgBox("Error en funcion ConsultasDPpal" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub
    Public Function decimales(ByVal dato As String)

        If (dato <> String.Empty) Then
            ' Convertimos a Decimal el valor del control TextBox. Si
            ' el valor no se puede convertir a Decimal, se mostrará
            ' un 0 en lugar de producirse un error.
            '
            Dim importe As Decimal
            Decimal.TryParse(dato, importe)
            ' Formateamos a entero, sin decimales, el valor decimal obtenido.
            '
            dato = String.Format("{0:n}", importe)
            ' Establecemos el punto de inserción al final del valor del control TextBox.                '
            'dato.SelectionStart = dato.TextLength

        End If
        Return dato
    End Function

    Sub consultaProyDppalf16()
        Try
            Dim strPpal As New ADODB.Recordset



            strPpal = cntSQL.Execute("select * from tab_Aux_EstCtasProy where [pro_NroProyecto]='" & ProyNro & "' and  [pro_idProyecto]='" & stridProy & "'")

            Do While Not strPpal.EOF

                f16.tbxCta.Text = strPpal.Fields("pro_CtaNro").Value
                f16.tbxNrP.Text = strPpal.Fields("pro_NroProyecto").Value
                f16.tbxDescP.Text = strDescProy
                f16.tbxPerCta.Text = decimales(Math.Round(strPpal.Fields("pro_PerCtas").Value, 2))
                f16.dtpFecEntra.Value = strPpal.Fields("pro_FechaEntScont").Value
                f16.tbxMeta.Text = decimales(Math.Round(strPpal.Fields("pro_Meta").Value, 2))
                f16.tbxMeta1.Text = decimales(Math.Round(strPpal.Fields("pro_Meta1").Value, 2))
                f16.tbxMetFac.Text = decimales(Math.Round(strPpal.Fields("pro_MetaFact").Value, 2))
                f16.tbxCump.Text = decimales(Math.Round(strPpal.Fields("pro_porcCump").Value, 2))
                f16.dtpFechaEn.Value = strPpal.Fields("pro_FechaEntInsp").Value

                f16.tbxMont.Text = decimales(Math.Round(strPpal.Fields("pro_MontoCtasInsp").Value, 2))
                f16.dtpFecEncxc.Value = strPpal.Fields("pro_FechaCxc").Value

                f16.tbxMontoAp.Text = strPpal.Fields("pro_MontoAproInsp").Value

                strPpal.MoveNext()
                'Exit Do


            Loop
            'End If
            f16.llenarFactestCtas()


        Catch ex As Exception
            MsgBox("Error en funcion consultaProyDppalf7()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub

    Sub consultaProyDppalf16_1()
        Try
            Dim strPpal As New ADODB.Recordset


            strPpal = cntSQL.Execute("select * from tab_Aux_EstCtasProy where [pro_NroProyecto]='" & ProyNro & "' and  [pro_idProyecto]='" & stridProy & "' and pro_CtaNro='" & f16.tbxCta.Text & "' ")

            Do While Not strPpal.EOF

                f16.tbxCta.Text = strPpal.Fields("pro_CtaNro").Value
                f16.tbxNrP.Text = strPpal.Fields("pro_NroProyecto").Value
                f16.tbxDescP.Text = strDescProy
                f16.tbxPerCta.Text = decimales(Math.Round(strPpal.Fields("pro_PerCtas").Value, 2))
                f16.dtpFecEntra.Value = strPpal.Fields("pro_FechaEntScont").Value
                f16.tbxMeta.Text = decimales(Math.Round(strPpal.Fields("pro_Meta").Value, 2))
                f16.tbxMeta1.Text = decimales(Math.Round(strPpal.Fields("pro_Meta1").Value, 2))
                f16.tbxMetFac.Text = decimales(Math.Round(strPpal.Fields("pro_MetaFact").Value, 2))
                f16.tbxCump.Text = decimales(Math.Round(strPpal.Fields("pro_porcCump").Value, 2))
                f16.dtpFechaEn.Value = strPpal.Fields("pro_FechaEntInsp").Value

                f16.tbxMont.Text = decimales(Math.Round(strPpal.Fields("pro_MontoCtasInsp").Value, 2))
                f16.dtpFecEncxc.Value = strPpal.Fields("pro_FechaCxc").Value

                f16.tbxMontoAp.Text = decimales(Math.Round(strPpal.Fields("pro_MontoAproInsp").Value, 2))

                strPpal.MoveNext()
                'Exit Do


            Loop
            'End If
            f16.llenarFactestCtas()


        Catch ex As Exception
            MsgBox("Error en funcion consultaProyDppalf7()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try

    End Sub
    Sub ConsultasDPpalf7()
        ConexionSQL()
        Try
            Dim strPpal As New ADODB.Recordset
            Dim strNroRec As New ADODB.Recordset
            Dim swRec As Integer = 0

            strPpal = cntSQL.Execute("select * from tab_DatosPpalProy where pro_idProyecto='" & stridProy & "'")


            Do While Not strPpal.EOF


                strNroRec = cntSQL.Execute("select * from tab_NrosReciboProy where id_proyecto='" & stridProy & "'")

                Do While Not strNroRec.EOF

                    swRec += 1

                    strNroRec.MoveNext()
                Loop



                If swRec = 0 Then

                    f7.tbxCodp.Text = strPpal.Fields("pro_nroProyecto").Value
                    f7.tbxDescr.Text = strPpal.Fields("pro_descripcion").Value
                    ContNro = strPpal.Fields("pro_nroContrato").Value
                    f7.cmbClas.SelectedItem = buscaComboSector(strPpal.Fields("pro_Sector").Value)

                    f7.tbxNroCon.Text = strPpal.Fields("pro_nroContrato").Value
                    f7.tbxUbi.Text = strPpal.Fields("pro_Provincia").Value

                    f7.txtMonto.Text = decimales(Math.Round(strPpal.Fields("pro_monto").Value, 2))
                    intMontoProy = decimales(Math.Round(strPpal.Fields("pro_monto").Value, 2))
                    f7.tbxAdendas.Text = decimales(Math.Round(strPpal.Fields("pro_Adendasmonto").Value, 2))
                    f7.txtItbAd.Text = decimales(Math.Round(strPpal.Fields("pro_AdendasmontoITBMS").Value, 2))
                    f7.txtItbContAd.Text = decimales(Math.Round(strPpal.Fields("pro_AdendasContITBMS").Value, 2))
                    f7.txtAdT.Text = decimales(Math.Round(strPpal.Fields("pro_AdendasTiempo").Value, 2))

                    f7.txtDurCont.Text = decimales(Math.Round(strPpal.Fields("pro_duracionCont").Value, 2))
                    f7.dtpOriF.Value = strPpal.Fields("pro_FechaOrg").Value
                    dtFechaOrig = strPpal.Fields("pro_FechaOrg").Value
                    f7.txtITBMS.Text = decimales(Math.Round(strPpal.Fields("pro_ITBMS").Value, 2))

                    f7.txtDurOri.Text = decimales(Math.Round(strPpal.Fields("pro_duracionOriginalCont").Value, 2))
                    f7.dtpFecI.Value = strPpal.Fields("pro_FechaD").Value
                    f7.dtpFecF.Value = strPpal.Fields("pro_FechaH").Value
                    f7.cmbSt.SelectedItem = buscaComboStatus(strPpal.Fields("pro_status").Value)
                    f7.cmbTp.SelectedItem = buscaComboTipo(strPpal.Fields("pro_tipo").Value)
                    f7.tbxCreditos.Text = strPpal.Fields("pro_diasCredito").Value

                    Dim difer As Integer
                    f7.dtpFecF.Value = f7.dtpFecI.Value.AddDays(Val(f7.txtDurOri.Text) + Val(f7.txtAdT.Text))
                    difer = DateDiff(DateInterval.Day, f7.dtpFecI.Value, f7.dtpFecF.Value.AddDays(Val(f7.txtDurOri.Text) + Val(f7.txtAdT.Text)))

                    f7.dtpFecF.Value = f7.dtpFecI.Value.AddDays(difer)

                   

                    Exit Do

                Else

                    f14 = frmContrRec
                    fcall = f14.Name
                    frmExplorer.cerrarForm()
                    frmSubmenup.Close()
                    f14.ShowDialog()
                    swF = 0

                    If swMenuPpal <> 3 Then
                        f14.consultaProyDppalf7()
                    Else
                        f7.tbxCodp.Text = ""
                        f7.tbxDescr.Text = ""

                    End If

                    If swMenuPpal = 3 Then
                        f7.Close()

                    End If
                    Exit Do
                End If


                strPpal.MoveNext()
            Loop

            'insertNroCont(f1.lblid.Text, f1.tbxCodp.Text, f1.tbxNroCon.Text, f1.tbxNroReci.Text, f1.tbxNroFac.Text)


        Catch ex As Exception
            MsgBox("Error en funcion ConsultasDPpal" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Sub ConsultasDPpalf15()
        Try
            ConexionSQL()
            Dim strPpal As New ADODB.Recordset
            Dim strNroRec As New ADODB.Recordset
            Dim swRec As Integer = 0

            strPpal = cntSQL.Execute("select * from tab_DatosPpalProy where pro_idProyecto='" & stridProy & "'")


            Do While Not strPpal.EOF


                strNroRec = cntSQL.Execute("select * from tab_NrosReciboProy where id_proyecto='" & stridProy & "'")

                Do While Not strNroRec.EOF

                    swRec += 1

                    strNroRec.MoveNext()
                Loop



                If swRec = 0 Then

                Else

                    f14 = frmContrRec
                    fcall = f14.Name
                    frmExplorer.cerrarForm()
                    frmSubmenup.Close()
                    f14.ShowDialog()
                    swF = 0

                    If swMenuPpal <> 3 Then
                        f14.consultaProyDppalf15()
                    End If
                    If swMenuPpal = 3 Then
                        f15.Close()
                    End If
                    Exit Do

                End If


                strPpal.MoveNext()
            Loop



        Catch ex As Exception
            MsgBox("Error en funcion ConsultasDPpal" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub



    Sub ConsultasEstCtasf16()
        Try
            ConexionSQL()
            Dim strPpal As New ADODB.Recordset
            Dim strPpales As New ADODB.Recordset
            Dim strNroRec As New ADODB.Recordset
            Dim swRec As Integer = 0

            'sacar los datos principales del proyecto
            strPpales = cntSQL.Execute("select * from tab_DatosPpalProy where pro_idProyecto='" & stridProy & "'")


            If strPpales.EOF = True Then


                Do While Not strPpales.EOF
                    ContNro = strPpales.Fields("pro_nroContrato").Value

                    Exit Do

                Loop

            End If

            strPpal = cntSQL.Execute("select * from tab_Aux_EstCtasProy where pro_idProyecto='" & stridProy & "'")



            If strPpal.EOF = True Then


                Dim strDFact As New ADODB.Recordset
                Dim cta As Integer = 0
                ConexionSQL()


                'budco el numero de cuenta
                strDFact = cntSQL.Execute("select max(pro_CtaNro) as pro_CtaNro from tab_Aux_EstCtasProy where pro_idProyecto='" & stridProy & "' and pro_NroContrato='" & ContNro & "'")

                If strDFact.EOF = False Then
                    cta = Val(IIf(strDFact.Fields("pro_CtaNro").Value Is DBNull.Value, 0, strDFact.Fields("pro_CtaNro").Value))
                    cta += 1
                Else
                    cta = 1
                End If

                f16.tbxCta.Text = cta
                f16.tbxNrP.Text = ProyNro
                f16.tbxDescP.Text = strDescProy

                f16.tbxPerCta.Focus()

            Else
                Do While Not strPpal.EOF


                    strNroRec = cntSQL.Execute("select * from tab_NrosReciboProy where id_proyecto='" & stridProy & "'")

                    Do While Not strNroRec.EOF

                        swRec += 1

                        strNroRec.MoveNext()
                    Loop



                    If swRec = 0 Then


                    Else

                        f14 = frmContrRec
                        fcall = f14.Name
                        frmExplorer.cerrarForm()
                        frmSubmenup.Close()
                        f14.ShowDialog()
                        swF = 0

                        If swMenuPpal <> 3 Then
                            f14.consultaProyDppalf16()
                        End If
                        If swMenuPpal = 3 Then
                            f16.Close()
                        End If
                        Exit Do

                    End If


                    strPpal.MoveNext()
                Loop


            End If



        Catch ex As Exception
            MsgBox("Error en funcion ConsultasDPpal" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")
        End Try
    End Sub

    Public Function buscaComboSector(ByVal index As Integer)
        Dim idx As String = ""
        Try
            Dim strSector As New ADODB.Recordset

            strSector = cntSQL.Execute("SELECT  [des_Sector] FROM [dbo].[tab_Sector] where id='" & index & "' ")

            Do While Not strSector.EOF

                idx = strSector.Fields(0).Value
                strSector.MoveNext()

            Loop

            'f7.cmbClas.SelectedText = idx
        Catch ex As Exception
            MsgBox("Error en funcion llenarComboSector" & ex.Message)
        End Try
        Return idx

    End Function


    Public Function guardaComboSector(ByVal idx As String)
        Dim id As Integer
        Try
            Dim strSector As New ADODB.Recordset

            strSector = cntSQL.Execute("SELECT  id FROM [dbo].[tab_Sector] where des_Sector='" & idx & "' ")

            Do While Not strSector.EOF

                id = strSector.Fields(0).Value
                strSector.MoveNext()

            Loop

            'f7.cmbClas.SelectedText = idx
        Catch ex As Exception
            MsgBox("Error en funcion llenarComboSector" & ex.Message)
        End Try
        Return id

    End Function

    Public Function buscaComboCq(ByVal index As Integer)
        Dim idx As String = ""
        Try
            Dim strSector As New ADODB.Recordset

            strSector = cntSQL.Execute("SELECT  [des_CtrlCheque] FROM [dbo].[tab_CtrlCheque] where id='" & index & "' ")

            Do While Not strSector.EOF

                idx = strSector.Fields(0).Value
                strSector.MoveNext()

            Loop

            'f7.cmbClas.SelectedText = idx
        Catch ex As Exception
            MsgBox("Error en funcion llenarComboSector" & ex.Message)
        End Try
        Return idx

    End Function


    Public Function guardaComboCq(ByVal idx As String)
        Dim id As Integer
        Try
            Dim strSector As New ADODB.Recordset

            strSector = cntSQL.Execute("SELECT  id FROM [dbo].[tab_CtrlCheque] where des_CtrlCheque='" & idx & "' ")

            Do While Not strSector.EOF

                id = strSector.Fields(0).Value
                strSector.MoveNext()

            Loop

            'f7.cmbClas.SelectedText = idx
        Catch ex As Exception
            MsgBox("Error en funcion llenarComboSector" & ex.Message)
        End Try
        Return id

    End Function

    Public Function buscaComboStatus(ByVal index As Integer)
        Dim idx As String = ""
        Try
            Dim strSector As New ADODB.Recordset

            strSector = cntSQL.Execute("SELECT  [des_Status] FROM [dbo].[tab_Status] where id='" & index & "' ")

            Do While Not strSector.EOF

                idx = strSector.Fields(0).Value
                strSector.MoveNext()

            Loop

            'f7.cmbClas.SelectedText = idx
        Catch ex As Exception
            MsgBox("Error en funcion buscaComboStatus" & ex.Message)
        End Try
        Return idx

    End Function
    Public Function buscaComboStatusC(ByVal index As Integer)
        Dim idx As String = ""
        Try
            Dim strSector As New ADODB.Recordset

            strSector = cntSQL.Execute("SELECT  [des_Status] FROM [dbo].[tab_Status_Cuentas] where id='" & index & "' ")

            Do While Not strSector.EOF

                idx = strSector.Fields(0).Value
                strSector.MoveNext()

            Loop

            'f7.cmbClas.SelectedText = idx
        Catch ex As Exception
            MsgBox("Error en funcion buscaComboStatus" & ex.Message)
        End Try
        Return idx

    End Function

    Public Function guardaComboStatus(ByVal idx As String)
        Dim id As Integer
        Try
            Dim strSector As New ADODB.Recordset

            strSector = cntSQL.Execute("SELECT  id FROM [dbo].[tab_Status] where des_Status='" & idx & "' ")

            Do While Not strSector.EOF

                id = strSector.Fields(0).Value
                strSector.MoveNext()

            Loop

            'f7.cmbClas.SelectedText = idx
        Catch ex As Exception
            MsgBox("Error en funcion guardaComboStatus" & ex.Message)
        End Try
        Return id

    End Function

    Public Function guardaComboStatusC(ByVal idx As String)
        Dim id As Integer
        Try
            Dim strSector As New ADODB.Recordset

            strSector = cntSQL.Execute("SELECT  id FROM [dbo].[tab_Status_Cuentas] where des_Status='" & idx & "' ")

            Do While Not strSector.EOF

                id = strSector.Fields(0).Value
                strSector.MoveNext()

            Loop

            'f7.cmbClas.SelectedText = idx
        Catch ex As Exception
            MsgBox("Error en funcion guardaComboStatus" & ex.Message)
        End Try
        Return id

    End Function




    Public Function buscaComboTipo(ByVal index As Integer)
        Dim idx As String = ""
        Try
            Dim strSector As New ADODB.Recordset

            strSector = cntSQL.Execute("SELECT  [des_tipo] FROM [dbo].[tab_Tipo] where id='" & index & "' ")

            Do While Not strSector.EOF

                idx = strSector.Fields(0).Value
                strSector.MoveNext()

            Loop

            'f7.cmbClas.SelectedText = idx
        Catch ex As Exception
            MsgBox("Error en funcion buscaComboTipo" & ex.Message)
        End Try
        Return idx

    End Function

    Public Function guardaComboTipo(ByVal idx As String)
        Dim id As Integer
        Try
            Dim strSector As New ADODB.Recordset

            strSector = cntSQL.Execute("SELECT  id FROM [dbo].[tab_Tipo] where des_tipo='" & idx & "' ")

            Do While Not strSector.EOF

                id = strSector.Fields(0).Value
                strSector.MoveNext()

            Loop

            'f7.cmbClas.SelectedText = idx
        Catch ex As Exception
            MsgBox("Error en funcion guardaComboTipo" & ex.Message)
        End Try
        Return id

    End Function


    Public Function buscacmbperPagCtas(ByVal index As Integer)
        Dim idx As String = ""
        Try
            Dim strSector As New ADODB.Recordset

            strSector = cntSQL.Execute("SELECT  [des_perpagoCuentas] FROM tab_perpagoCuentas where id='" & index & "' ")

            Do While Not strSector.EOF

                idx = strSector.Fields(0).Value
                strSector.MoveNext()

            Loop

            'f7.cmbClas.SelectedText = idx
        Catch ex As Exception
            MsgBox("Error en funcion buscacmbperPagCtas" & ex.Message)
        End Try
        Return idx

    End Function

    Public Function guardacmbperPagCtas(ByVal idx As String)
        Dim id As Integer
        Try
            Dim strSector As New ADODB.Recordset

            strSector = cntSQL.Execute("SELECT  id FROM tab_perpagoCuentas where des_perpagoCuentas='" & idx & "' ")

            Do While Not strSector.EOF

                id = strSector.Fields(0).Value
                strSector.MoveNext()

            Loop

            'f7.cmbClas.SelectedText = idx
        Catch ex As Exception
            MsgBox("Error en funcion guardacmbperPagCtas" & ex.Message)
        End Try
        Return id

    End Function

End Module