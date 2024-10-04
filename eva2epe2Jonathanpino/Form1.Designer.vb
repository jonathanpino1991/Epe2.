<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtRUT = New TextBox()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtCiudad = New TextBox()
        txtObservaciones = New TextBox()
        cmbComuna = New ComboBox()
        GroupBox1 = New GroupBox()
        rbtnNoEspecifica = New RadioButton()
        rbtnFemenino = New RadioButton()
        rbtnMasculino = New RadioButton()
        btnBuscar = New Button()
        btnGuardar = New Button()
        btnEditar = New Button()
        btnEliminar = New Button()
        btnMostrar = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 25)
        Label1.TabIndex = 0
        Label1.Text = "Rut"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 25)
        Label2.TabIndex = 1
        Label2.Text = "Nombres"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 25)
        Label3.TabIndex = 2
        Label3.Text = "Apellidos"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(52, 416)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 25)
        Label4.TabIndex = 3
        Label4.Text = "Comuna"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(52, 487)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 25)
        Label5.TabIndex = 4
        Label5.Text = "Ciudad"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(52, 562)
        Label6.Name = "Label6"
        Label6.Size = New Size(128, 25)
        Label6.TabIndex = 5
        Label6.Text = "Observaciones"
        ' 
        ' txtRUT
        ' 
        txtRUT.Location = New Point(146, 32)
        txtRUT.Name = "txtRUT"
        txtRUT.Size = New Size(150, 31)
        txtRUT.TabIndex = 6
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(146, 82)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(150, 31)
        txtNombre.TabIndex = 7
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(146, 134)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(150, 31)
        txtApellido.TabIndex = 8
        ' 
        ' txtCiudad
        ' 
        txtCiudad.Location = New Point(146, 496)
        txtCiudad.Name = "txtCiudad"
        txtCiudad.Size = New Size(150, 31)
        txtCiudad.TabIndex = 9
        ' 
        ' txtObservaciones
        ' 
        txtObservaciones.Location = New Point(146, 559)
        txtObservaciones.Name = "txtObservaciones"
        txtObservaciones.Size = New Size(150, 31)
        txtObservaciones.TabIndex = 10
        ' 
        ' cmbComuna
        ' 
        cmbComuna.FormattingEnabled = True
        cmbComuna.Location = New Point(146, 413)
        cmbComuna.Name = "cmbComuna"
        cmbComuna.Size = New Size(182, 33)
        cmbComuna.TabIndex = 11
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbtnNoEspecifica)
        GroupBox1.Controls.Add(rbtnFemenino)
        GroupBox1.Controls.Add(rbtnMasculino)
        GroupBox1.Location = New Point(52, 223)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(579, 150)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Sexo"
        ' 
        ' rbtnNoEspecifica
        ' 
        rbtnNoEspecifica.AutoSize = True
        rbtnNoEspecifica.Location = New Point(334, 78)
        rbtnNoEspecifica.Name = "rbtnNoEspecifica"
        rbtnNoEspecifica.Size = New Size(142, 29)
        rbtnNoEspecifica.TabIndex = 2
        rbtnNoEspecifica.TabStop = True
        rbtnNoEspecifica.Text = "No Especifica"
        rbtnNoEspecifica.UseVisualStyleBackColor = True
        ' 
        ' rbtnFemenino
        ' 
        rbtnFemenino.AutoSize = True
        rbtnFemenino.Location = New Point(178, 78)
        rbtnFemenino.Name = "rbtnFemenino"
        rbtnFemenino.Size = New Size(115, 29)
        rbtnFemenino.TabIndex = 1
        rbtnFemenino.TabStop = True
        rbtnFemenino.Text = "Femenino"
        rbtnFemenino.UseVisualStyleBackColor = True
        ' 
        ' rbtnMasculino
        ' 
        rbtnMasculino.AutoSize = True
        rbtnMasculino.Location = New Point(22, 78)
        rbtnMasculino.Name = "rbtnMasculino"
        rbtnMasculino.Size = New Size(117, 29)
        rbtnMasculino.TabIndex = 0
        rbtnMasculino.TabStop = True
        rbtnMasculino.Text = "Masculino"
        rbtnMasculino.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(405, 56)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(112, 83)
        btnBuscar.TabIndex = 13
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(323, 478)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(112, 34)
        btnGuardar.TabIndex = 14
        btnGuardar.Text = "Guardar SQL"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(323, 553)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(112, 34)
        btnEditar.TabIndex = 15
        btnEditar.Text = "Editar Usuario"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(491, 478)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(112, 34)
        btnEliminar.TabIndex = 16
        btnEliminar.Text = "Eliminar Usuario"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnMostrar
        ' 
        btnMostrar.Location = New Point(491, 553)
        btnMostrar.Name = "btnMostrar"
        btnMostrar.Size = New Size(112, 34)
        btnMostrar.TabIndex = 17
        btnMostrar.Text = "Mostrar tabla"
        btnMostrar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(655, 670)
        Controls.Add(btnMostrar)
        Controls.Add(btnEliminar)
        Controls.Add(btnEditar)
        Controls.Add(btnGuardar)
        Controls.Add(btnBuscar)
        Controls.Add(GroupBox1)
        Controls.Add(cmbComuna)
        Controls.Add(txtObservaciones)
        Controls.Add(txtCiudad)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Controls.Add(txtRUT)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "EPE_2 Jonathan Pino"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRUT As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents cmbComuna As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnNoEspecifica As RadioButton
    Friend WithEvents rbtnFemenino As RadioButton
    Friend WithEvents rbtnMasculino As RadioButton
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnMostrar As Button

End Class
