<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class rptStatementOwners
    Inherits GrapeCity.ActiveReports.SectionReport

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
#Region "ActiveReports Designer generated code"
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader = Nothing
    Private WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader = Nothing
    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail = Nothing
    Private WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter = Nothing
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter = Nothing
    Public Label1 As GrapeCity.ActiveReports.SectionReportModel.Label = Nothing
    Public Label2 As GrapeCity.ActiveReports.SectionReportModel.Label = Nothing
    Public Label3 As GrapeCity.ActiveReports.SectionReportModel.Label = Nothing
    Private Shape1 As GrapeCity.ActiveReports.SectionReportModel.Shape = Nothing
    Private txtContract As GrapeCity.ActiveReports.SectionReportModel.TextBox = Nothing
    Private txtName As GrapeCity.ActiveReports.SectionReportModel.TextBox = Nothing
    Private Line4 As GrapeCity.ActiveReports.SectionReportModel.Line = Nothing
    Private WithEvents chkSecondary As GrapeCity.ActiveReports.SectionReportModel.CheckBox
    Private Line5 As GrapeCity.ActiveReports.SectionReportModel.Line = Nothing

#End Region

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptStatementOwners))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.Shape1 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.txtContract = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.txtName = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.chkSecondary = New GrapeCity.ActiveReports.SectionReportModel.CheckBox()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        CType(Me.txtContract, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSecondary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Shape1, Me.txtContract, Me.txtName, Me.Line4, Me.Line5, Me.chkSecondary})
        Me.Detail.Height = 0.25!
        Me.Detail.Name = "Detail"
        '
        'Shape1
        '
        Me.Shape1.Height = 0.24!
        Me.Shape1.Left = 0.109375!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.999999!, Nothing, Nothing, Nothing, Nothing)
        Me.Shape1.Top = 0!
        Me.Shape1.Width = 3.514625!
        '
        'txtContract
        '
        Me.txtContract.DataField = "ContractNo"
        Me.txtContract.Height = 0.2!
        Me.txtContract.Left = 2.027!
        Me.txtContract.Name = "txtContract"
        Me.txtContract.Style = "color: Black; font-family: Arial; font-size: 10pt"
        Me.txtContract.Text = Nothing
        Me.txtContract.Top = 0.015625!
        Me.txtContract.Width = 0.9099998!
        '
        'txtName
        '
        Me.txtName.DataField = "FullName"
        Me.txtName.Height = 0.2!
        Me.txtName.Left = 0.21875!
        Me.txtName.Name = "txtName"
        Me.txtName.Style = "color: Black; font-family: Arial; font-size: 10pt"
        Me.txtName.Text = Nothing
        Me.txtName.Top = 0.015625!
        Me.txtName.Width = 1.75025!
        '
        'Line4
        '
        Me.Line4.Height = 0.23!
        Me.Line4.Left = 2.027!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0!
        Me.Line4.Width = 0!
        Me.Line4.X1 = 2.027!
        Me.Line4.X2 = 2.027!
        Me.Line4.Y1 = 0!
        Me.Line4.Y2 = 0.23!
        '
        'Line5
        '
        Me.Line5.Height = 0.23!
        Me.Line5.Left = 2.937!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0!
        Me.Line5.Width = 0!
        Me.Line5.X1 = 2.937!
        Me.Line5.X2 = 2.937!
        Me.Line5.Y1 = 0!
        Me.Line5.Y2 = 0.23!
        '
        'chkSecondary
        '
        Me.chkSecondary.DataField = "Secondary"
        Me.chkSecondary.Height = 0.2!
        Me.chkSecondary.Left = 3.135!
        Me.chkSecondary.Name = "chkSecondary"
        Me.chkSecondary.Style = "color: Black; font-family: Arial"
        Me.chkSecondary.Text = ""
        Me.chkSecondary.Top = 0.016!
        Me.chkSecondary.Width = 0.4890001!
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
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label1, Me.Label2, Me.Label3})
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'Label1
        '
        Me.Label1.Height = 0.25!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.109!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "background-color: DimGray; color: White; font-size: 8.25pt; font-weight: bold; te" &
    "xt-align: center; vertical-align: middle"
        Me.Label1.Text = "Co-Owner"
        Me.Label1.Top = 0!
        Me.Label1.Width = 1.918!
        '
        'Label2
        '
        Me.Label2.Height = 0.25!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 2.027!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "background-color: DimGray; color: White; font-size: 8.25pt; font-weight: bold; te" &
    "xt-align: center; vertical-align: middle"
        Me.Label2.Text = "Contract #"
        Me.Label2.Top = 0!
        Me.Label2.Width = 0.9099998!
        '
        'Label3
        '
        Me.Label3.Height = 0.25!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.937!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "background-color: DimGray; color: White; font-size: 8.25pt; font-weight: bold; te" &
    "xt-align: center; vertical-align: middle"
        Me.Label3.Text = "Secondary"
        Me.Label3.Top = 0!
        Me.Label3.Width = 0.6875!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'rptStatementOwners
        '
        Me.MasterReport = False
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" &
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"))
        CType(Me.txtContract, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSecondary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
End Class
