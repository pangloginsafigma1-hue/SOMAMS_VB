Imports System.IO

Public Class frmSettings

    Private _admin As Admin

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Navigator.WireSidebar(Me)
        txtNewPassword.UseSystemPasswordChar = True
        txtConfirmPassword.UseSystemPasswordChar = True
        pbPhoto.SizeMode = PictureBoxSizeMode.Zoom

        _admin = SettingsController.GetById(Session.CurrentAdmin.AdminId)
        ShowProfile()
    End Sub

    Private Sub ShowProfile()
        lblFullNameDisplay.Text = _admin.FullName
        txtFullName.Text = _admin.FullName
        txtUsername.Text = _admin.Username
        txtEmail.Text = _admin.Email
        txtNewPassword.Clear()
        txtConfirmPassword.Clear()

        If _admin.Photo IsNot Nothing AndAlso _admin.Photo.Length > 0 Then
            Using ms As New MemoryStream(_admin.Photo)
                pbPhoto.Image = New Bitmap(Image.FromStream(ms))
            End Using
        End If
    End Sub

    Private Sub btnChangePhoto_Click(sender As Object, e As EventArgs) Handles btnChangePhoto.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Images (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
            If ofd.ShowDialog() <> DialogResult.OK Then Return
            Dim bytes As Byte() = File.ReadAllBytes(ofd.FileName)
            If bytes.Length > 4 * 1024 * 1024 Then
                MessageBox.Show("Please choose an image smaller than 4 MB.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            _admin.Photo = bytes                       ' saved when you click Save Changes
            Using ms As New MemoryStream(bytes)
                pbPhoto.Image = New Bitmap(Image.FromStream(ms))
            End Using
        End Using
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        If txtFullName.Text.Trim() = "" OrElse txtUsername.Text.Trim() = "" OrElse txtEmail.Text.Trim() = "" Then
            MessageBox.Show("Full name, username and email are required.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If SettingsController.UsernameTaken(txtUsername.Text.Trim(), _admin.AdminId) Then
            MessageBox.Show("That username is already taken.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If txtNewPassword.Text <> "" Then
            If txtNewPassword.Text.Length < 6 Then
                MessageBox.Show("The new password must be at least 6 characters.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If txtNewPassword.Text <> txtConfirmPassword.Text Then
                MessageBox.Show("The passwords do not match.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        _admin.FullName = txtFullName.Text.Trim()
        _admin.Username = txtUsername.Text.Trim()
        _admin.Email = txtEmail.Text.Trim()
        SettingsController.Update(_admin, txtNewPassword.Text)

        Session.CurrentAdmin = _admin
        ShowProfile()
        MessageBox.Show("Changes saved.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
