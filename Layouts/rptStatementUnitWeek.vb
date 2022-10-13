Imports GrapeCity.ActiveReports
Imports GrapeCity.ActiveReports.Document

Public Class rptStatementUnitWeek
    Inherits GrapeCity.ActiveReports.SectionReport

#Region "Private Variables"

    Private _itemName As ArrayList = New ArrayList
    Private _showHeaders As Boolean = True
    Private _firstTime As Boolean = True
    Private _convertCheckboxToText As Boolean = False
#End Region

#Region " Properties "
    Public Property ShowHeaders() As Boolean
        Get
            Return _showHeaders
        End Get
        Set(ByVal value As Boolean)
            _showHeaders = value
        End Set
    End Property

    Public Property ConvertCheckboxToText() As Boolean
        Get
            Return _convertCheckboxToText
        End Get
        Set(ByVal value As Boolean)
            _convertCheckboxToText = value
        End Set
    End Property
#End Region

    Private Sub BaseReport_PageEnd(sender As Object, e As System.EventArgs) Handles Me.PageEnd

        If _firstTime Then
            _firstTime = False
            For Each r As GrapeCity.ActiveReports.SectionReportModel.Section In Me.Sections
                If r.Type = Section.SectionType.PageHeader Then
                    r.Visible = ShowHeaders
                End If
            Next
        End If

    End Sub

    Private Sub BaseReport_ReportStart(sender As Object, e As System.EventArgs) Handles Me.ReportStart
        Dim ctrl As String

        _firstTime = True

        _itemName.Add("lblPrintedOn")
        _itemName.Add("txtDateAndTime")
        _itemName.Add("lblClientName")
        _itemName.Add("lblPage")
        _itemName.Add("txtCurrentPage")
        _itemName.Add("lblOf")
        _itemName.Add("txtTotalNumberOfPages")
        _itemName.Add("lblReportName")

        For Each r As GrapeCity.ActiveReports.SectionReportModel.Section In Me.Sections
            If r.Type = Section.SectionType.ReportHeader Or r.Type = Section.SectionType.PageFooter Then
                r.Visible = ShowHeaders
            ElseIf r.Type = Section.SectionType.PageHeader Then
                r.Visible = True
                For Each c As Object In r.Controls
                    For Each ctrl In _itemName
                        If c.name = ctrl Then
                            c.visible = ShowHeaders
                        End If
                    Next
                Next
            End If
        Next

        Me.Document.Printer.PrinterName = String.Empty


    End Sub

    Public Sub ConvertAllCheckboxesToText()

        If Me.ConvertCheckboxToText Then

            Dim r As GrapeCity.ActiveReports.SectionReportModel.Section = Me.Sections("Detail")     'GrapeCity.ActiveReports.SectionReportModel.Section("Detail")

            For Each c As Object In r.Controls
                If c.GetType.Name = "CheckBox" Then
                    Dim chk As GrapeCity.ActiveReports.SectionReportModel.CheckBox = c
                    If chk.Checked Then
                        chk.Text = "Y"
                    Else
                        chk.Text = ""
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As Object, ByVal e As System.EventArgs)
        If txtTotalUnit.Value > 10 Then
            lblAdditiional.Visible = True
        Else
            lblAdditiional.Visible = False
        End If
    End Sub


    Private Sub rptStatementUnitWeek_ReportStart(sender As Object, e As EventArgs) Handles Me.ReportStart
        'Dim showUDF1 As Boolean

        'showUDF1 = PropertyDALC.CheckMod("PrintDeedNameUDFOnStatement")
        'Shape2.Visible = showUDF1
        'txtUDF1.Visible = showUDF1
        'LabelUDF.Visible = showUDF1

    End Sub


End Class
