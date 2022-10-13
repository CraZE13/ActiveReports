<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptStatementUnitWeek
    Inherits GrapeCity.ActiveReports.SectionReport

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader = Nothing
    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader = Nothing
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail = Nothing
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter = Nothing
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter = Nothing
    Public Label1 As GrapeCity.ActiveReports.SectionReportModel.Label = Nothing
    Public Label2 As GrapeCity.ActiveReports.SectionReportModel.Label = Nothing
    Public Label3 As GrapeCity.ActiveReports.SectionReportModel.Label = Nothing
    Public Label4 As GrapeCity.ActiveReports.SectionReportModel.Label = Nothing
    Private Shape1 As GrapeCity.ActiveReports.SectionReportModel.Shape = Nothing
    Private txtRoom As GrapeCity.ActiveReports.SectionReportModel.TextBox = Nothing
    Private txtContract As GrapeCity.ActiveReports.SectionReportModel.TextBox = Nothing
    Private txtWeek As GrapeCity.ActiveReports.SectionReportModel.TextBox = Nothing
    Private txtStatus As GrapeCity.ActiveReports.SectionReportModel.TextBox = Nothing
    Private txtTotalUnit As GrapeCity.ActiveReports.SectionReportModel.TextBox = Nothing
    Private Line3 As GrapeCity.ActiveReports.SectionReportModel.Line = Nothing
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line = Nothing
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line = Nothing
    Public WithEvents LabelUDF As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents txtUDF1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Shape2 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Private lblAdditiional As GrapeCity.ActiveReports.SectionReportModel.Label = Nothing
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptStatementUnitWeek))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.Shape1 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.txtRoom = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtContract = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtWeek = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtStatus = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtTotalUnit = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.txtUDF1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.LabelUDF = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.lblAdditiional = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Shape2 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        CType(Me.txtRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtContract, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWeek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabelUDF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblAdditiional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Shape1, Me.txtRoom, Me.txtContract, Me.txtWeek, Me.txtStatus, Me.txtTotalUnit, Me.Line3, Me.Line4, Me.Line5, Me.txtUDF1, Me.Shape2})
        Me.Detail.Height = 0.24!
        Me.Detail.Name = "Detail"
        Me.Detail.KeepTogether = False
        '
        'Shape1
        '
        Me.Shape1.Height = 0.24!
        Me.Shape1.Left = 0.109375!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.999999!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape1.Top = 0!
        Me.Shape1.Width = 3.359625!
        '
        'txtRoom
        '
        Me.txtRoom.DataField = "RoomNum"
        Me.txtRoom.Height = 0.2!
        Me.txtRoom.Left = 0.964!
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Style = "font-size: 8pt"
        Me.txtRoom.Text = Nothing
        Me.txtRoom.Top = 0.015625!
        Me.txtRoom.Width = 0.8170001!
        '
        'txtContract
        '
        Me.txtContract.DataField = "contractid"
        Me.txtContract.Height = 0.2!
        Me.txtContract.Left = 0.125!
        Me.txtContract.Name = "txtContract"
        Me.txtContract.Style = "font-size: 8pt"
        Me.txtContract.Text = Nothing
        Me.txtContract.Top = 0.015625!
        Me.txtContract.Width = 0.771!
        '
        'txtWeek
        '
        Me.txtWeek.CanGrow = False
        Me.txtWeek.DataField = "WeekNo"
        Me.txtWeek.Height = 0.2!
        Me.txtWeek.Left = 1.844!
        Me.txtWeek.Name = "txtWeek"
        'Me.txtWeek.OutputFormat = resources.GetString("txtWeek.OutputFormat")
        Me.txtWeek.Style = "font-size: 8pt"
        Me.txtWeek.Text = Nothing
        Me.txtWeek.Top = 0.015625!
        Me.txtWeek.Width = 0.5469999!
        '
        'txtStatus
        '
        Me.txtStatus.CanGrow = False
        Me.txtStatus.DataField = "Status"
        Me.txtStatus.Height = 0.2!
        Me.txtStatus.Left = 2.474!
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Style = "font-size: 8pt"
        Me.txtStatus.Text = Nothing
        Me.txtStatus.Top = 0.015625!
        Me.txtStatus.Width = 0.9630001!
        '
        'txtTotalUnit
        '
        Me.txtTotalUnit.Height = 0.1875!
        Me.txtTotalUnit.Left = 6.312!
        Me.txtTotalUnit.Name = "txtTotalUnit"
        Me.txtTotalUnit.Text = Nothing
        Me.txtTotalUnit.Top = 0.042!
        Me.txtTotalUnit.Visible = False
        Me.txtTotalUnit.Width = 0.1350002!
        '
        'Line3
        '
        Me.Line3.Height = 0.24!
        Me.Line3.Left = 0.9220001!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0!
        Me.Line3.Width = 0!
        Me.Line3.X1 = 0.9220001!
        Me.Line3.X2 = 0.9220001!
        Me.Line3.Y1 = 0!
        Me.Line3.Y2 = 0.24!
        '
        'Line4
        '
        Me.Line4.Height = 0.24!
        Me.Line4.Left = 1.812!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0!
        Me.Line4.Width = 0!
        Me.Line4.X1 = 1.812!
        Me.Line4.X2 = 1.812!
        Me.Line4.Y1 = 0!
        Me.Line4.Y2 = 0.24!
        '
        'Line5
        '
        Me.Line5.Height = 0.24!
        Me.Line5.Left = 2.437!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0!
        Me.Line5.Width = 0!
        Me.Line5.X1 = 2.437!
        Me.Line5.X2 = 2.437!
        Me.Line5.Y1 = 0!
        Me.Line5.Y2 = 0.24!
        '
        'txtUDF1
        '
        Me.txtUDF1.CanGrow = False
        Me.txtUDF1.DataField = "UDF1"
        Me.txtUDF1.Height = 0.2!
        Me.txtUDF1.Left = 3.5!
        Me.txtUDF1.Name = "txtUDF1"
        Me.txtUDF1.Style = "font-size: 8pt"
        Me.txtUDF1.Text = Nothing
        Me.txtUDF1.Top = 0.025!
        Me.txtUDF1.Width = 1.818!
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.Height = 0!
        Me.PageFooter.Name = "PageFooter"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.LabelUDF})
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.All
        '
        'Label1
        '
        Me.Label1.Height = 0.25!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.109!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "background-color: DimGray; color: White; font-size: 8.25pt; font-weight: bold; te" &
    "xt-align: center; vertical-align: middle"
        Me.Label1.Text = "Contract No."
        Me.Label1.Top = 0!
        Me.Label1.Width = 0.8130001!
        '
        'Label2
        '
        Me.Label2.Height = 0.25!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.9220001!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "background-color: DimGray; color: White; font-size: 8.25pt; font-weight: bold; te" &
    "xt-align: center; vertical-align: middle"
        Me.Label2.Text = "Room No."
        Me.Label2.Top = 0!
        Me.Label2.Width = 0.89!
        '
        'Label3
        '
        Me.Label3.Height = 0.25!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 1.812!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "background-color: DimGray; color: White; font-size: 8.25pt; font-weight: bold; te" &
    "xt-align: center; vertical-align: middle"
        Me.Label3.Text = "Week No."
        Me.Label3.Top = 0!
        Me.Label3.Width = 0.625!
        '
        'Label4
        '
        Me.Label4.Height = 0.25!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 2.437!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "background-color: DimGray; color: White; font-size: 8.25pt; font-weight: bold; te" &
    "xt-align: center; vertical-align: middle"
        Me.Label4.Text = "Status"
        Me.Label4.Top = 0!
        Me.Label4.Width = 1.032!
        '
        'LabelUDF
        '
        Me.LabelUDF.Height = 0.25!
        Me.LabelUDF.HyperLink = Nothing
        Me.LabelUDF.Left = 3.469!
        Me.LabelUDF.Name = "LabelUDF"
        Me.LabelUDF.Style = "background-color: DimGray; color: White; font-size: 8.25pt; font-weight: bold; te" &
    "xt-align: left; vertical-align: middle"
        Me.LabelUDF.Text = "Deed Name"
        Me.LabelUDF.Top = 0!
        Me.LabelUDF.Width = 1.89!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.lblAdditiional})
        Me.GroupFooter1.Height = 0.2076389!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'lblAdditiional
        '
        Me.lblAdditiional.Height = 0.2!
        Me.lblAdditiional.HyperLink = Nothing
        Me.lblAdditiional.Left = 0.125!
        Me.lblAdditiional.Name = "lblAdditiional"
        Me.lblAdditiional.Style = "font-family: Lucida\000020Console; font-size: 8pt; font-weight: bold"
        Me.lblAdditiional.Text = "Owner has additional unit/weeks."
        Me.lblAdditiional.Top = 0!
        Me.lblAdditiional.Width = 3.3125!
        '
        'Shape2
        '
        Me.Shape2.Height = 0.24!
        Me.Shape2.Left = 3.469!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.999999!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape2.Top = 0!
        Me.Shape2.Width = 1.89!
        '
        'rptStatementUnitWeek
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        'Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" &
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"))
        CType(Me.txtRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtContract, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWeek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUDF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabelUDF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblAdditiional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region
End Class
