Imports DevExpress.XtraCharts
Imports System
Imports System.Windows.Forms

Namespace ArgumentCountDetectionSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#ValuesCount"
        Private Sub chartControl1_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles chartControl1.ObjectSelected
            If e.HitInfo.InSeries Then
                Dim count As Integer = e.HitInfo.Series.View.ValuesCount
                MessageBox.Show(Me, String.Format("The selected series is ploted using {0} series point values.", count))
            End If
        End Sub
        #End Region ' #ValuesCount
    End Class
End Namespace
