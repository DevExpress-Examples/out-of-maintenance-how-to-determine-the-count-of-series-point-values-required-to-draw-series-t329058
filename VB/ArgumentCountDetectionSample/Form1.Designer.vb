Namespace ArgumentCountDetectionSample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(1R, New Object() { (DirectCast(1R, Object))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(2R, New Object() { (DirectCast(2R, Object))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(3R, New Object() { (DirectCast(3R, Object))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(4R, New Object() { (DirectCast(4R, Object))})
            Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
            Dim series2 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(1R, New Object() { (DirectCast(3R, Object)), (DirectCast(2R, Object))})
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(2R, New Object() { (DirectCast(2.5R, Object)), (DirectCast(3R, Object))})
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(3R, New Object() { (DirectCast(1.5R, Object)), (DirectCast(4R, Object))})
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(4R, New Object() { (DirectCast(5R, Object)), (DirectCast(1R, Object))})
            Dim bubbleSeriesView1 As New DevExpress.XtraCharts.BubbleSeriesView()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(bubbleSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.DataBindings = Nothing
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4})
            lineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.True
            series1.View = lineSeriesView1
            series2.Name = "Series 2"
            series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
            series2.View = bubbleSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
            Me.chartControl1.Size = New System.Drawing.Size(624, 321)
            Me.chartControl1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(624, 321)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(bubbleSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace

