<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnConnectar = New System.Windows.Forms.Button()
        Me.lblRes = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TbTo = New System.Windows.Forms.TextBox()
        Me.TbPort = New System.Windows.Forms.TextBox()
        Me.TBSend = New System.Windows.Forms.TextBox()
        Me.TBRcv = New System.Windows.Forms.TextBox()
        Me.dgTrabajadores = New System.Windows.Forms.DataGridView()
        Me.colid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPuesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtInNombre = New System.Windows.Forms.TextBox()
        Me.txtInPuesto = New System.Windows.Forms.TextBox()
        Me.txtInEdad = New System.Windows.Forms.TextBox()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.lblRes2 = New System.Windows.Forms.Label()
        CType(Me.dgTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConnectar
        '
        Me.btnConnectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnectar.Location = New System.Drawing.Point(94, 67)
        Me.btnConnectar.Name = "btnConnectar"
        Me.btnConnectar.Size = New System.Drawing.Size(117, 56)
        Me.btnConnectar.TabIndex = 0
        Me.btnConnectar.Text = "Conectar"
        Me.btnConnectar.UseVisualStyleBackColor = True
        '
        'lblRes
        '
        Me.lblRes.AutoSize = True
        Me.lblRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRes.Location = New System.Drawing.Point(234, 77)
        Me.lblRes.Name = "lblRes"
        Me.lblRes.Size = New System.Drawing.Size(72, 36)
        Me.lblRes.TabIndex = 1
        Me.lblRes.Text = "Test"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(638, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 63)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TbTo
        '
        Me.TbTo.Location = New System.Drawing.Point(661, 26)
        Me.TbTo.Name = "TbTo"
        Me.TbTo.Size = New System.Drawing.Size(100, 22)
        Me.TbTo.TabIndex = 3
        '
        'TbPort
        '
        Me.TbPort.Location = New System.Drawing.Point(661, 60)
        Me.TbPort.Name = "TbPort"
        Me.TbPort.Size = New System.Drawing.Size(100, 22)
        Me.TbPort.TabIndex = 4
        '
        'TBSend
        '
        Me.TBSend.Location = New System.Drawing.Point(661, 98)
        Me.TBSend.Name = "TBSend"
        Me.TBSend.Size = New System.Drawing.Size(100, 22)
        Me.TBSend.TabIndex = 5
        '
        'TBRcv
        '
        Me.TBRcv.Location = New System.Drawing.Point(661, 223)
        Me.TBRcv.Name = "TBRcv"
        Me.TBRcv.Size = New System.Drawing.Size(100, 22)
        Me.TBRcv.TabIndex = 6
        '
        'dgTrabajadores
        '
        Me.dgTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTrabajadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colid, Me.colNombre, Me.colPuesto, Me.colEdad})
        Me.dgTrabajadores.Location = New System.Drawing.Point(80, 152)
        Me.dgTrabajadores.Name = "dgTrabajadores"
        Me.dgTrabajadores.RowHeadersWidth = 51
        Me.dgTrabajadores.RowTemplate.Height = 24
        Me.dgTrabajadores.Size = New System.Drawing.Size(515, 188)
        Me.dgTrabajadores.TabIndex = 7
        '
        'colid
        '
        Me.colid.HeaderText = "id"
        Me.colid.MinimumWidth = 6
        Me.colid.Name = "colid"
        Me.colid.Visible = False
        Me.colid.Width = 125
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.MinimumWidth = 6
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Width = 125
        '
        'colPuesto
        '
        Me.colPuesto.HeaderText = "Puesto"
        Me.colPuesto.MinimumWidth = 6
        Me.colPuesto.Name = "colPuesto"
        Me.colPuesto.Width = 125
        '
        'colEdad
        '
        Me.colEdad.HeaderText = "Edad"
        Me.colEdad.MinimumWidth = 6
        Me.colEdad.Name = "colEdad"
        Me.colEdad.Width = 125
        '
        'txtInNombre
        '
        Me.txtInNombre.Location = New System.Drawing.Point(94, 429)
        Me.txtInNombre.Name = "txtInNombre"
        Me.txtInNombre.Size = New System.Drawing.Size(100, 22)
        Me.txtInNombre.TabIndex = 8
        '
        'txtInPuesto
        '
        Me.txtInPuesto.Location = New System.Drawing.Point(262, 428)
        Me.txtInPuesto.Name = "txtInPuesto"
        Me.txtInPuesto.Size = New System.Drawing.Size(100, 22)
        Me.txtInPuesto.TabIndex = 9
        '
        'txtInEdad
        '
        Me.txtInEdad.Location = New System.Drawing.Point(416, 428)
        Me.txtInEdad.Name = "txtInEdad"
        Me.txtInEdad.Size = New System.Drawing.Size(100, 22)
        Me.txtInEdad.TabIndex = 10
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(590, 427)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertar.TabIndex = 11
        Me.btnInsertar.Text = "Button2"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'lblRes2
        '
        Me.lblRes2.AutoSize = True
        Me.lblRes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRes2.Location = New System.Drawing.Point(307, 506)
        Me.lblRes2.Name = "lblRes2"
        Me.lblRes2.Size = New System.Drawing.Size(72, 36)
        Me.lblRes2.TabIndex = 12
        Me.lblRes2.Text = "Test"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 593)
        Me.Controls.Add(Me.lblRes2)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.txtInEdad)
        Me.Controls.Add(Me.txtInPuesto)
        Me.Controls.Add(Me.txtInNombre)
        Me.Controls.Add(Me.dgTrabajadores)
        Me.Controls.Add(Me.TBRcv)
        Me.Controls.Add(Me.TBSend)
        Me.Controls.Add(Me.TbPort)
        Me.Controls.Add(Me.TbTo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblRes)
        Me.Controls.Add(Me.btnConnectar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConnectar As Button
    Friend WithEvents lblRes As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents TbTo As TextBox
    Friend WithEvents TbPort As TextBox
    Friend WithEvents TBSend As TextBox
    Friend WithEvents TBRcv As TextBox
    Friend WithEvents dgTrabajadores As DataGridView
    Friend WithEvents colid As DataGridViewTextBoxColumn
    Friend WithEvents colNombre As DataGridViewTextBoxColumn
    Friend WithEvents colPuesto As DataGridViewTextBoxColumn
    Friend WithEvents colEdad As DataGridViewTextBoxColumn
    Friend WithEvents txtInNombre As TextBox
    Friend WithEvents txtInPuesto As TextBox
    Friend WithEvents txtInEdad As TextBox
    Friend WithEvents btnInsertar As Button
    Friend WithEvents lblRes2 As Label
End Class
