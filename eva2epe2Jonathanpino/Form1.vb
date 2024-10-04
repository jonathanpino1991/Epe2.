Imports MySql.Data.MySqlClient

Public Class Form1

    Public Class DatabaseConnection
        Private connectionString As String = "server=localhost;user id=root;password=;database=epe2"

        Public Function Connect() As MySqlConnection
            Dim conn As New MySqlConnection(connectionString)
            conn.Open()
            Return conn
        End Function
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarComunas()
        BloquearCampos()
    End Sub

    Private Sub BloquearCampos()
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        rbtnMasculino.Enabled = False
        rbtnFemenino.Enabled = False
        rbtnNoEspecifica.Enabled = False
        cmbComuna.Enabled = False
        txtCiudad.Enabled = False
        txtObservaciones.Enabled = False
    End Sub


    Private Sub CargarComunas()
        Using conn As MySqlConnection = New DatabaseConnection().Connect()
            Dim query As String = "SELECT NombreComuna FROM comuna"
            Using cmd As MySqlCommand = New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        cmbComuna.Items.Add(reader("NombreComuna").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If ValidarCampos() Then
            Using conn As MySqlConnection = New DatabaseConnection().Connect()
                Dim query As String = "INSERT INTO personas (RUT, Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion) VALUES (@RUT, @Nombre, @Apellido, @Sexo, @Comuna, @Ciudad, @Observacion)"
                Using cmd As MySqlCommand = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RUT", txtRUT.Text)
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                    cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text)
                    cmd.Parameters.AddWithValue("@Sexo", If(rbtnMasculino.Checked, "Masculino", If(rbtnFemenino.Checked, "Femenino", "No especifica")))
                    cmd.Parameters.AddWithValue("@Comuna", cmbComuna.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Ciudad", txtCiudad.Text)
                    cmd.Parameters.AddWithValue("@Observacion", txtObservaciones.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Datos guardados exitosamente.")
                    LimpiarFormulario()
                    txtRUT.Focus()
                End Using
            End Using
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Using conn As MySqlConnection = New DatabaseConnection().Connect()
            Dim query As String = "SELECT * FROM personas WHERE RUT = @RUT"
            Using cmd As MySqlCommand = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@RUT", txtRUT.Text)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtNombre.Text = reader("Nombre").ToString()
                        txtApellido.Text = reader("Apellido").ToString()
                        If reader("Sexo").ToString() = "Masculino" Then
                            rbtnMasculino.Checked = True
                        ElseIf reader("Sexo").ToString() = "Femenino" Then
                            rbtnFemenino.Checked = True
                        Else
                            rbtnNoEspecifica.Checked = True
                        End If
                        cmbComuna.SelectedItem = reader("Comuna").ToString()
                        txtCiudad.Text = reader("Ciudad").ToString()
                        txtObservaciones.Text = reader("Observacion").ToString()
                    Else
                        MessageBox.Show("RUT no encontrado.")
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If ValidarCampos() Then
            Using conn As MySqlConnection = New DatabaseConnection().Connect()
                Dim query As String = "UPDATE personas SET Nombre = @Nombre, Apellido = @Apellido, Sexo = @Sexo, Comuna = @Comuna, Ciudad = @Ciudad, Observacion = @Observacion WHERE RUT = @RUT"
                Using cmd As MySqlCommand = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RUT", txtRUT.Text)
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                    cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text)
                    cmd.Parameters.AddWithValue("@Sexo", If(rbtnMasculino.Checked, "Masculino", If(rbtnFemenino.Checked, "Femenino", "No especifica")))
                    cmd.Parameters.AddWithValue("@Comuna", cmbComuna.SelectedItem.ToString())
                    cmd.Parameters.AddWithValue("@Ciudad", txtCiudad.Text)
                    cmd.Parameters.AddWithValue("@Observacion", txtObservaciones.Text)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Datos modificados exitosamente.")
                End Using
            End Using
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If String.IsNullOrWhiteSpace(txtRUT.Text) Then
            MessageBox.Show("Por favor, ingresa el RUT del usuario a eliminar.")
            Return
        End If

        If MessageBox.Show("¿Estás seguro de que deseas eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using conn As MySqlConnection = New DatabaseConnection().Connect()
                Dim query As String = "DELETE FROM personas WHERE RUT = @RUT"
                Using cmd As MySqlCommand = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@RUT", txtRUT.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Usuario eliminado exitosamente.")
                    LimpiarFormulario()
                End Using
            End Using
        End If
    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(txtRUT.Text) OrElse String.IsNullOrWhiteSpace(txtNombre.Text) OrElse String.IsNullOrWhiteSpace(txtApellido.Text) OrElse cmbComuna.SelectedIndex = -1 Then
            MessageBox.Show("Todos los campos obligatorios deben estar completos.")
            Return False
        End If
        Return True
    End Function

    Private Sub LimpiarFormulario()
        txtRUT.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        rbtnMasculino.Checked = False
        rbtnFemenino.Checked = False
        rbtnNoEspecifica.Checked = False
        cmbComuna.SelectedIndex = -1
        txtCiudad.Clear()
        txtObservaciones.Clear()
    End Sub


    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim usuarios As New List(Of String)()

        Using conn As MySqlConnection = New DatabaseConnection().Connect()
            Dim query As String = "SELECT RUT, Nombre, Apellido FROM personas"
            Using cmd As MySqlCommand = New MySqlCommand(query, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim usuario As String = $"RUT: {reader("RUT")}, Nombre: {reader("Nombre")}, Apellido: {reader("Apellido")}"
                        usuarios.Add(usuario)
                    End While
                End Using
            End Using
        End Using

        If usuarios.Count > 0 Then
            MessageBox.Show(String.Join(Environment.NewLine, usuarios), "Lista de Usuarios")
        Else
            MessageBox.Show("No hay usuarios registrados.", "Lista de Usuarios")
        End If
    End Sub

End Class