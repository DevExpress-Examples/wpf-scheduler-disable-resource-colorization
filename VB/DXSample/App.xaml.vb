Imports System.Collections.Generic
Imports System.Windows
Imports DevExpress.Xpf.Core

Namespace DXSample

    Public Partial Class App
        Inherits Application

        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
            HideClassicThemes()
            MyBase.OnStartup(e)
        End Sub

        Private Sub HideClassicThemes()
            Dim ModernThemeCaterogies As List(Of String) = New List(Of String)() From {Theme.Office2016Category, Theme.Office2016SECategory, Theme.Office2019Category, Theme.VisualStudioCategory, Theme.MetropolisCategory}
            For Each theme As Theme In Theme.Themes
                theme.ShowInThemeSelector = ModernThemeCaterogies.Contains(theme.Category)
            Next
        End Sub
    End Class
End Namespace
