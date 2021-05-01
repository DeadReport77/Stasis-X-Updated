
Public Class Global_IP


    Private Sub Global_IP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Const IE11 As Integer = 11001
        Const IE10 As Integer = 10001
        Const IE9 As Integer = 9999
        Dim IEVer As Integer = IE10 '<- change this
        Dim regKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION", True)
        Dim binVal As Integer
        binVal = regKey.GetValue(My.Application.Info.Title & ".exe")
        If binVal <> IEVer Then regKey.SetValue(My.Application.Info.Title & ".exe", IEVer) 'for exe
        binVal = regKey.GetValue(My.Application.Info.Title & "Stasis X.vshost.exe")
        If binVal <> IEVer Then regKey.SetValue(My.Application.Info.Title & "Stasis X.vshost.exe", IEVer) 'for IDE debug

        WebBrowser1.ScriptErrorsSuppressed = True
        WebBrowser1.Navigate("https://www.ipfingerprints.com/")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Static_X.Show()
    End Sub


End Class