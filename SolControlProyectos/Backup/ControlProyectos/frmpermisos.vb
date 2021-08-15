Public Class frmpermisos
    Public nodohijo As String = ""
    Public NameNode As String = ""
    Public NodeName As String = ""
    Public activo As Integer = 0
    Private Sub frmpermisos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.trwUser.ExpandAll()



    End Sub
    Sub limpiaTreeview()
        Try

            Dim nodes As TreeNodeCollection = trwUser.Nodes


          
            'Los recorres los nodos principales
            For Each n As TreeNode In nodes

                'Declaras un metodo para que recorra los hijos de los principales
                'Y los hijos de los hijos....Recorrido Total en pocas palabras
                PrintRecursiveClear(n)
            Next


          
        Catch ex As Exception
            MsgBox("error en funcion recorreTreeView()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try

    End Sub
    Sub recorreTreeView()
        Try
            limpiaTreeview()
            Dim srtnode As ADODB.Recordset
            Dim nodes As TreeNodeCollection = trwUser.Nodes
            ConexionSQL()

            srtnode = cntSQL.Execute("SELECT usuario,menuForm, nodo  FROM tab_proPermisoform left outer join tab_proMenuForm on menuForm=codMenu where usuario ='" & Me.tbxdni.Text & "' and activo=1")

            Do While Not srtnode.EOF

                nodohijo = srtnode.Fields("nodo").Value
                'Los recorres los nodos principales
                For Each n As TreeNode In nodes

                    'Declaras un metodo para que recorra los hijos de los principales
                    'Y los hijos de los hijos....Recorrido Total en pocas palabras
                    PrintRecursive(n)
                Next



                srtnode.MoveNext()
            Loop



        Catch ex As Exception
            MsgBox("error en funcion recorreTreeView()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try


    End Sub
    Private Sub PrintRecursive(ByVal treeNode As TreeNode)
        Try
            For Each tn As TreeNode In treeNode.Nodes
                If tn.Name = nodohijo Then
                    tn.Checked = True
               
                End If

            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub PrintRecursiveClear(ByVal treeNode As TreeNode)
        Try
            For Each tn As TreeNode In treeNode.Nodes
               
                tn.Checked = False


            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub PrintRecursiveUpdate(ByVal treeNode As TreeNode)
        Try
            For Each tn As TreeNode In treeNode.Nodes

                If tn.Checked = True Then
                    activo = 1
                Else
                    activo = 0
                End If
                NodeName = tn.Name
                activadesctUser()

            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub PrintRecursiveAdmin(ByVal treeNode As TreeNode)

        Try
            For Each tn As TreeNode In treeNode.Nodes

                'If tn.Checked = True Then
                '    tn.Checked = False
                'Else
                tn.Checked = True


                'End If


                activo = 1

                NodeName = tn.Name


            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
   
   
  
    Private Sub trwUser_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trwUser.AfterCheck

        ' El código sólo se ejecutará si el usuario causó
        ' el cambio del estado de verificación del nodo.
        '
        If (e.Action = TreeViewAction.Unknown) Then Return

        If (e.Node.Nodes.Count > 0) Then
            ' Llama al método CheckAllChildNodes, pasando el valor actual
            ' Chequeado del TreeNode cuyo estado marcado ha cambiado.
            Me.CheckAllChildNodes(e.Node, e.Node.Checked)

        Else
            ' Nodo padre del nodo hijo actual.
            Dim parent As TreeNode = e.Node.Parent
            If (Not parent Is Nothing) Then
                ' El nodo tiene un nodo padre válido.
                '
                If (Not e.Node.Checked) Then
                    ' El nodo hijo no está marcado; eliminamos la marca de
                    ' de verificación de su nodo padre.
                    parent.Checked = False

                Else
                    ' El nodo hijo está marcado; comprobamos si los restantes
                    ' nodos hijos están marcados para marcar también el
                    ' nodo padre.

                    Dim items As TreeNode() = (From item As TreeNode In parent.Nodes.OfType(Of TreeNode)() _
                                Where item.Checked _
                                Select item).ToArray()

                    parent.Checked = (items.Count = parent.Nodes.Count)

                End If
            End If

        End If

    End Sub
    Private Sub CheckAllChildNodes(ByVal treeNode As TreeNode, ByVal nodeChecked As Boolean)

        ' Actualiza de forma recursiva todos los nodos hijos.
        '
        For Each node As TreeNode In treeNode.Nodes
            node.Checked = nodeChecked
            If (node.Nodes.Count > 0) Then
                ' Si el node actual tiene nodos hijos, llamar
                ' recursivamente al método CheckAllChildNodes.
                Me.CheckAllChildNodes(node, nodeChecked)
            End If
        Next

    End Sub

    Private Sub btnCanc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        Me.Close()
    End Sub

    Private Sub tbxdni_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbxdni.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            btnBuscar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Usuario = Me.tbxdni.Text
        swUser = 2
        frmBuscaUser.ShowDialog()
        recorreTreeView()
        Usuario = ""

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If Me.tbxdni.Text <> "" Then
            recorreTreeViewUpdate()
        Else
            MsgBox("Debe seleccionar un usuario", MsgBoxStyle.Critical, "Control Proyectos")

        End If
    End Sub
    Sub activadesctUser()
        Try
            ConexionSQL()
            Dim strperUser As ADODB.Recordset
            Dim strperMenu As ADODB.Recordset
            Dim menu As String = ""

            Dim swUsuario As Integer = 0


            strperMenu = cntSQL.Execute("SELECT codMenu,descFormMenu,Menuproy,nodo  FROM tab_proMenuForm where nodo= '" & NodeName & "'")

            Do While Not strperMenu.EOF
                NameNode = IIf(strperMenu.Fields("nodo").Value Is DBNull.Value, "", strperMenu.Fields("nodo").Value)
                menu = IIf(strperMenu.Fields("codMenu").Value Is DBNull.Value, "", strperMenu.Fields("codMenu").Value)

                If NodeName = NameNode Then

                    strperUser = cntSQL.Execute("select usuario, menuForm, activo from tab_proPermisoform where usuario='" & Me.tbxdni.Text & "'")

                    If strperUser.EOF = False Then

                        cntSQL.Execute("update tab_proPermisoform  set activo=" & activo & " where usuario='" & Me.tbxdni.Text & "' and menuForm='" & menu & "'")

                    End If


                End If


                strperMenu.MoveNext()
            Loop

           
        Catch ex As Exception
            MsgBox("error en funcion guardarPermisoUser" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try
    End Sub

    Sub recorreTreeViewUpdate()
        Try
            Dim nodes As TreeNodeCollection = trwUser.Nodes

            'Los recorres los nodos principales
            For Each n As TreeNode In nodes

                PrintRecursiveUpdate(n)


            Next

            MsgBox("Usuario actualizado..", MsgBoxStyle.Information, "Control Proyectos")


        Catch ex As Exception
            MsgBox("error en funcion recorreTreeView()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try


    End Sub

    Private Sub chkAdmin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAdmin.CheckedChanged
        recorreTreeViewAdmin()
    End Sub
    Sub recorreTreeViewAdmin()
        Try
            Dim nodes As TreeNodeCollection = trwUser.Nodes

            'Los recorres los nodos principales
            For Each n As TreeNode In nodes

                PrintRecursiveAdmin(n)


            Next

            ' MsgBox("Usuario actualizado..", MsgBoxStyle.Information, "Control Proyectos")


        Catch ex As Exception
            MsgBox("error en funcion recorreTreeView()" & ex.Message, MsgBoxStyle.Critical, "Control Proyectos")

        End Try


    End Sub
End Class