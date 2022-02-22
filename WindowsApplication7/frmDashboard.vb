Public Class frmDashboard
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        '   New(100)

        ' Add any initialization after the InitializeComponent() call.
        Me.Width = Screen.GetWorkingArea(Me).Width
        Me.Height = Screen.GetWorkingArea(Me).Height + 1

        DoubleBufferedControl(main_panel)
    End Sub

    Sub closeForms()
        For i As Integer = My.Application.OpenForms.Count - 1 To 0 Step -1
            If My.Application.OpenForms(i) IsNot Me Then My.Application.OpenForms(i).Dispose()

        Next
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmHome.Name Then Return
        Next
        closeForms()
        With frmHome
            .Width = main_panel.Width
            .Height = main_panel.Height
            .TopLevel = False
            main_panel.Controls.Add(frmHome)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        For Each f As Form In My.Application.OpenForms
            If f.Name = frmSettings.Name Then Return
        Next
        closeForms()
        With frmSettings
            .Width = main_panel.Width
            .Height = main_panel.Height
            .TopLevel = False
            main_panel.Controls.Add(frmSettings)
            .BringToFront()
            .Show()

        End With
    End Sub
End Class