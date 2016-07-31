<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EjercicioOrdenCompra
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstOrden = New System.Windows.Forms.ListBox()
        Me.lstDescuento = New System.Windows.Forms.ListBox()
        Me.btnDesplegar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Monto (USD):"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ORDEN DE COMPRA"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(90, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 5
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(90, 58)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(100, 20)
        Me.txtDir.TabIndex = 6
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(90, 84)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(100, 20)
        Me.txtDate.TabIndex = 7
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(90, 110)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(100, 20)
        Me.txtMonto.TabIndex = 8
        '
        'txtDes
        '
        Me.txtDes.Location = New System.Drawing.Point(384, 109)
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(46, 20)
        Me.txtDes.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(302, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Descuento(%):"
        '
        'btnDes
        '
        Me.btnDes.Location = New System.Drawing.Point(319, 283)
        Me.btnDes.Name = "btnDes"
        Me.btnDes.Size = New System.Drawing.Size(111, 23)
        Me.btnDes.TabIndex = 11
        Me.btnDes.Text = "Realizar Descuento"
        Me.btnDes.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(196, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Ingresar Cliente"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lstOrden
        '
        Me.lstOrden.FormattingEnabled = True
        Me.lstOrden.Location = New System.Drawing.Point(12, 136)
        Me.lstOrden.Name = "lstOrden"
        Me.lstOrden.Size = New System.Drawing.Size(222, 134)
        Me.lstOrden.TabIndex = 13
        '
        'lstDescuento
        '
        Me.lstDescuento.FormattingEnabled = True
        Me.lstDescuento.Location = New System.Drawing.Point(254, 136)
        Me.lstDescuento.Name = "lstDescuento"
        Me.lstDescuento.Size = New System.Drawing.Size(212, 134)
        Me.lstDescuento.TabIndex = 14
        '
        'btnDesplegar
        '
        Me.btnDesplegar.Location = New System.Drawing.Point(75, 283)
        Me.btnDesplegar.Name = "btnDesplegar"
        Me.btnDesplegar.Size = New System.Drawing.Size(75, 23)
        Me.btnDesplegar.TabIndex = 15
        Me.btnDesplegar.Text = "Desplegar"
        Me.btnDesplegar.UseVisualStyleBackColor = True
        '
        'EjercicioOrdenCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 318)
        Me.Controls.Add(Me.btnDesplegar)
        Me.Controls.Add(Me.lstDescuento)
        Me.Controls.Add(Me.lstOrden)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EjercicioOrdenCompra"
        Me.Text = "EjercicioOrdenCompra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtDes As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDes As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstOrden As System.Windows.Forms.ListBox
    Friend WithEvents lstDescuento As System.Windows.Forms.ListBox
    Friend WithEvents btnDesplegar As System.Windows.Forms.Button
End Class
