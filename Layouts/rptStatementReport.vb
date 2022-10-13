Imports GrapeCity.ActiveReports
Imports GrapeCity.ActiveReports.Document
Public Class rptStatementReport
    Inherits GrapeCity.ActiveReports.SectionReport

#Region "Private Variables"

    Private _itemName As ArrayList = New ArrayList
    Private _showHeaders As Boolean = True
    Private _firstTime As Boolean = True
    Private _convertCheckboxToText As Boolean = False

    Private _numOfUnitWeek As Integer
    Private _numOfOwners As Integer
    'lg-20588:Dev work: Allow Dues and Loan Statements to be printed in multiple languages
    Public totalAmountComment As String
    Private defualtLanguageCode As String
    Dim defaultlanguagedata As DataSet
    Dim languageds As DataSet = Nothing
    'Private _objExecHandler As New SpiLibrary.Common.ExceptionHandler
    Private _showCCInfo As Boolean
    Private _showAllContract As Boolean
    Private _contractFrom As Integer
    Private _contractTo As Integer
    Private _showComments As Boolean
    Private _showUnitWeek As Boolean
    Private _showSecondOwner As Boolean
    Private _showBarCode As Boolean
    'Private _showCustomerPhone As Boolean 'task:19311
    Private _showCollector As Boolean
    Private _showContractDesc As Boolean
    Private customerName As String
    Private secondCustomerName As String
    Private rptUnitWeek As rptStatementUnitWeek
    Private rptOwners As rptStatementOwners
    Private objMDTransactionDALC As MDTransactionDALC
    Private _clientName As String
    Private _clientNameRet As String
    Private _address1 As String
    Private _address2 As String
    Private _csz As String
    Private _country As String
    Private _address1Ret As String
    Private _address2Ret As String
    Private _cszRet As String
    Private _countryRet As String
    Private _age1 As Integer
    Private _age2 As Integer
    Private _age3 As Integer
    Private _age4 As Integer
    Private _UKStatement As Boolean
    'YT: Task 20953
    Private _showPhoneNo As Boolean
    Private _USPhoneFormat As Boolean
    Private _regularStatementComments As String
    Private _insStatementComments As String
    Private _defaultinsStatementComments As String
    Private _defaultregulerStatementComments As String
    Private _insStatementCommentsPrintAbove As Boolean
    Private _insMaintFeeBal As Decimal
    Private _insBillCodeID As Integer
    Private lstContracts As System.Collections.Generic.LinkedList(Of Integer)
    Private _ownerFooterPrinted As Boolean

    Private _showOMRMark As Boolean
    Private _showScanLine As Boolean
    Private _scanLine As String
    Private _scanLineFormatted As String
    Private _checkDegit As String
    Private _showPageHeader As Boolean
    Private _StatementToInvc As Boolean
    Private _resortID As String
    Private _isDuesLocalCurrencySet As Boolean
    Private customerAddress As String
    Private _showSubtotalbyContract As Boolean
    Private CurrentOwnerId As String
    Private _showCVV As Boolean
    Private _showUnit As Boolean
    Private _showWeek As Boolean
#End Region

#Region " Properties "
    Public Property NumOfOwners() As Integer
        Get
            Return _numOfOwners
        End Get
        Set(ByVal value As Integer)
            _numOfOwners = value
        End Set
    End Property
    Public Property NumOfUnitWeek() As Integer
        Get
            Return _numOfUnitWeek
        End Get
        Set(ByVal value As Integer)
            _numOfUnitWeek = value
        End Set
    End Property
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

    Public Property ShowCCInfo() As Boolean
        Get
            Return _showCCInfo
        End Get
        Set(ByVal Value As Boolean)
            _showCCInfo = Value
        End Set
    End Property

    Public Property ShowAllContract() As Boolean
        Get
            Return _showAllContract
        End Get
        Set(ByVal Value As Boolean)
            _showAllContract = Value
        End Set
    End Property

    Public Property ContractFrom() As Integer
        Get
            Return _contractFrom
        End Get
        Set(ByVal Value As Integer)
            _contractFrom = Value
        End Set
    End Property

    Public Property ContractTo() As Integer
        Get
            Return _contractTo
        End Get
        Set(ByVal Value As Integer)
            _contractTo = Value
        End Set
    End Property

    Public Property ShowComments() As Boolean
        Get
            Return _showComments
        End Get
        Set(ByVal Value As Boolean)
            _showComments = Value
        End Set
    End Property

    Public Property ShowUnitWeek() As Boolean
        Get
            Return _showUnitWeek
        End Get
        Set(ByVal Value As Boolean)
            _showUnitWeek = Value
        End Set
    End Property

    Public Property ShowSecondOwner() As Boolean
        Get
            Return _showSecondOwner
        End Get
        Set(ByVal Value As Boolean)
            _showSecondOwner = Value
        End Set
    End Property

    ''lg 6661 Add option to Sub-total by Contract in Maintenance Dues Statements
    Public Property ShowSubtotalbyContract() As Boolean
        Get
            Return _showSubtotalbyContract
        End Get
        Set(ByVal Value As Boolean)
            _showSubtotalbyContract = Value
        End Set
    End Property

    Public Property ShowBarCode() As Boolean
        Get
            Return _showBarCode
        End Get
        Set(ByVal Value As Boolean)
            _showBarCode = Value
        End Set
    End Property

    'Public Property ShowCustomerPhone() As Boolean 'task:19311
    '    Get
    '        Return _showCustomerPhone
    '    End Get
    '    Set(ByVal Value As Boolean)
    '        _showCustomerPhone = Value
    '    End Set
    'End Property

    'YT: Task 20953
    Public Property ShowPhoneNo() As Boolean
        Get
            Return _showPhoneNo
        End Get
        Set(ByVal Value As Boolean)
            _showPhoneNo = Value
        End Set
    End Property
    'YT: Task 20953- End

    Public Property ShowCollector() As Boolean
        Get
            Return _showCollector
        End Get
        Set(ByVal Value As Boolean)
            _showCollector = Value
        End Set
    End Property

    Public Property ShowContractDesc() As Boolean
        Get
            Return _showContractDesc
        End Get
        Set(ByVal Value As Boolean)
            _showContractDesc = Value
        End Set
    End Property

    Public Property ClientName() As String
        Get
            Return _clientName
        End Get
        Set(ByVal Value As String)
            _clientName = Value
        End Set
    End Property
    Public Property ClientNameRet() As String
        Get
            Return _clientNameRet
        End Get
        Set(ByVal Value As String)
            _clientNameRet = Value
        End Set
    End Property

    Public Property Address1() As String
        Get
            Return _address1
        End Get
        Set(ByVal Value As String)
            _address1 = Value
        End Set
    End Property

    Public Property Address2() As String
        Get
            Return _address2
        End Get
        Set(ByVal Value As String)
            _address2 = Value
        End Set
    End Property

    Public Property CSZ() As String
        Get
            Return _csz
        End Get
        Set(ByVal Value As String)
            _csz = Value
        End Set
    End Property

    Public Property Country() As String
        Get
            Return _country
        End Get
        Set(ByVal Value As String)
            _country = Value
        End Set
    End Property
    Public Property Address1Ret() As String
        Get
            Return _address1Ret
        End Get
        Set(ByVal Value As String)
            _address1Ret = Value
        End Set
    End Property

    Public Property Address2Ret() As String
        Get
            Return _address2Ret
        End Get
        Set(ByVal Value As String)
            _address2Ret = Value
        End Set
    End Property

    Public Property CSZRet() As String
        Get
            Return _cszRet
        End Get
        Set(ByVal Value As String)
            _cszRet = Value
        End Set
    End Property

    Public Property CountryRet() As String
        Get
            Return _countryRet
        End Get
        Set(ByVal Value As String)
            _countryRet = Value
        End Set
    End Property
    Public Property Age1() As Integer
        Get
            Return _age1
        End Get
        Set(ByVal Value As Integer)
            _age1 = Value
        End Set
    End Property

    Public Property Age2() As Integer
        Get
            Return _age2
        End Get
        Set(ByVal Value As Integer)
            _age2 = Value
        End Set
    End Property

    Public Property Age3() As Integer
        Get
            Return _age3
        End Get
        Set(ByVal Value As Integer)
            _age3 = Value
        End Set
    End Property

    Public Property Age4() As Integer
        Get
            Return _age4
        End Get
        Set(ByVal Value As Integer)
            _age4 = Value
        End Set
    End Property

    Public Property UKStatement() As Boolean
        Get
            Return _UKStatement
        End Get
        Set(ByVal Value As Boolean)
            _UKStatement = Value
        End Set
    End Property

    Public Property USPhoneFormat() As Boolean  '21564 MLE
        Get
            USPhoneFormat = _USPhoneFormat
        End Get
        Set(ByVal value As Boolean)
            _USPhoneFormat = value
        End Set
    End Property

    Public Property INSStatementComments() As String
        Get
            Return _insStatementComments
        End Get
        Set(ByVal value As String)
            _insStatementComments = value
        End Set
    End Property
    Public Property DefaultINSStatementComments() As String
        Get
            Return _defaultinsStatementComments
        End Get
        Set(ByVal value As String)
            _defaultinsStatementComments = value
        End Set
    End Property
    Public Property defaultregulerStatementComments() As String
        Get
            Return _defaultregulerStatementComments
        End Get
        Set(ByVal value As String)
            _defaultregulerStatementComments = value
        End Set
    End Property

    Public Property INSStatementCommentsPrintAbove() As Boolean
        Get
            Return _insStatementCommentsPrintAbove
        End Get
        Set(ByVal value As Boolean)
            _insStatementCommentsPrintAbove = value
        End Set
    End Property

    Public Property INSBillCodeID() As Integer
        Get
            Return _insBillCodeID
        End Get
        Set(ByVal value As Integer)
            _insBillCodeID = value
        End Set
    End Property

    Public Property ShowOMRMark() As Boolean
        Get
            Return _showOMRMark
        End Get
        Set(ByVal value As Boolean)
            _showOMRMark = value
        End Set
    End Property

    Public Property ShowScanLine() As Boolean
        Get
            Return _showScanLine
        End Get
        Set(ByVal value As Boolean)
            _showScanLine = value
        End Set
    End Property

    Public Property ShowPageHeader() As Boolean
        Get
            Return _showPageHeader
        End Get
        Set(ByVal value As Boolean)
            _showPageHeader = value
        End Set
    End Property
    Public Property StatementToInvc() As Boolean
        Get
            Return _StatementToInvc
        End Get
        Set(ByVal Value As Boolean)
            _StatementToInvc = Value
        End Set
    End Property
    Public Property ResortID() As String
        Get
            Return _resortID
        End Get
        Set(ByVal Value As String)
            _resortID = Value
        End Set
    End Property
    Public Property IsDuesLocalCurrencySet() As Boolean
        Get
            Return _isDuesLocalCurrencySet
        End Get
        Set(ByVal Value As Boolean)
            _isDuesLocalCurrencySet = Value
        End Set
    End Property
    Public Property ShowCVV() As Boolean
        Get
            Return _showCVV
        End Get
        Set(ByVal Value As Boolean)
            _showCVV = Value
        End Set
    End Property

    Public Property ShowUnit() As Boolean
        Get
            Return _showUnit
        End Get
        Set(ByVal Value As Boolean)
            _showUnit = Value
        End Set
    End Property
    Public Property ShowWeek() As Boolean
        Get
            Return _showWeek
        End Get
        Set(ByVal Value As Boolean)
            _showWeek = Value
        End Set
    End Property

    Public Property ShowAmntPlusProtection As Boolean
#End Region

#Region "Basic Functions"
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

#End Region

    Private Sub grpOwnerFooter_AfterPrint(sender As Object, e As System.EventArgs) Handles grpOwnerFooter.AfterPrint
        'GetCustomerNameAddress()
    End Sub
    Private Sub grpOwnerFooter_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles grpOwnerFooter.BeforePrint


        _ownerFooterPrinted = True
        txtOwnerIdB.Text = txtOwnerId.Text
        txtCustNameB.Text = txtCustName.Text
        txtAmtDueB.Text = txtBal2.Text

        If Me.ShowScanLine Then
            _scanLine = ""

            _scanLine = txtResortIdB.Text.Trim.PadLeft(4, "0"c) & txtOwnerIdB.Text.Trim.PadLeft(8, "0"c) & CType(CType((CType(txtAmtDueB.Text, Decimal) * 100), Integer), String).PadLeft(8, "0"c)

            If IsNumeric(_scanLine) Then
                _scanLineFormatted = txtResortIdB.Text.Trim.PadLeft(4, "0"c) & txtOwnerIdB.Text.Trim.PadLeft(8, "0"c) & CType(CType((CType(IIf(IsNumeric(txtAmtDueB.Text), txtAmtDueB.Text, 0), Decimal) * 100), Integer), String).PadLeft(8, "0"c) & _checkDegit
                TextBox2.Top = 3.1!

                TextBox2.Text = _scanLineFormatted

            Else
                TextBox2.Text = ""
            End If
        End If

        If ShowBarCode Then
            'Barcode.Text = Right("00000000" & txtOwnerId.Text, 8) & Right(("0000000000" & LTrim(Str(txtAmtDueB.Text * 100))), 10)
            'YV: 17492
            Barcode.Text = Right("00000000" & txtOwnerId.Text, 8) & Right(("0000000000" & LTrim(Str(txtBal2.Value * 100))), 10)
        Else
            Barcode.Visible = False
        End If
    End Sub

    Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.BeforePrint

        If Not lstContracts.Contains(Me.Fields("ScID").Value) Then
            Me._insMaintFeeBal = Me._insMaintFeeBal + 1000.0
            lstContracts.AddLast(Me.Fields("ScID").Value)
        End If
    End Sub

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        If Not IsDBNull(txtRef.Value) AndAlso txtRef.Value < 0 Then
            txtRef.Visible = False
            txtDate.Visible = False
            txtAmount.Visible = False
            txtBal.Visible = False
        Else
            txtRef.Visible = True
            txtDate.Visible = True
            txtAmount.Visible = True
            txtBal.Visible = True
        End If

    End Sub

    Private Sub rptStatementReport_PageEnd(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PageEnd

        If ShowOMRMark Then
            'Print two marks when the owner footer gets printed, otherwise print one.
            If _ownerFooterPrinted Then

                Me.CurrentPage.Font = New System.Drawing.Font("OMRFont", 48)

                Me.CurrentPage.ForeColor = System.Drawing.Color.Black

                Me.CurrentPage.DrawText("_________", 0.1F, 9.0F, 0.8F, 0.8F)

                Me.CurrentPage.DrawText("_________", 0.1F, 9.2F, 0.8F, 0.8F)

            Else
                Me.CurrentPage.Font = New System.Drawing.Font("OMRFont", 48)

                Me.CurrentPage.ForeColor = System.Drawing.Color.Black

                Me.CurrentPage.DrawText("_________", 0.1F, 9.0F, 0.8F, 0.8F)

            End If
        End If

    End Sub

    Private Sub rptStatementReport_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart

        If StatementToInvc Then
            lblReportName.Text = "INVOICE"
            lblStmtDate.Text = "INVOICE DATE:"
            Label9.Text = "Invoice Date:"
        End If
        objMDTransactionDALC = New MDTransactionDALC

        _regularStatementComments = Me.txtComments.Text

        'Display CC Info
        lblCCNo.Visible = ShowCCInfo
        lblCCExp.Visible = ShowCCInfo
        ShapeCCExp.Visible = ShowCCInfo
        ShapeCCNo.Visible = ShowCCInfo
        lineSignature.Visible = ShowCCInfo
        lblSignature.Visible = ShowCCInfo
        Barcode.Visible = ShowBarCode

        lblCVV.Visible = ShowCVV
        ShapeCVV.Visible = ShowCVV

        lblAge1.Text = CStr(Age1) & "-" & CStr(Age2 - 1) & " Days"
        lblAge2.Text = CStr(Age2) & "-" & CStr(Age3 - 1) & " Days"
        lblAge3.Text = CStr(Age3) & "-" & CStr(Age4 - 1) & " Days"
        lblAge4.Text = "Over " & CStr(Age4) & " Days"

        If (Not ShowContractDesc And Not ShowWeek And Not ShowUnit) Then
            hideUnitWeekAndContractDesc()
        ElseIf Not ShowContractDesc And Not ShowUnit Then
            hideContractDescAndUnit()
        ElseIf Not ShowContractDesc And Not ShowWeek Then
            hideContractDescAndWeek()
        ElseIf Not ShowContractDesc Then
            hideContractDesc()
        ElseIf Not ShowUnit And Not ShowWeek Then
            hideUnitWeek()
        ElseIf Not ShowUnit Then
            hideUnit()
        ElseIf Not ShowWeek Then
            hideWeek()
        End If

        If ShowPageHeader Then
            grpOwnerHeader.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPageIncludeNoDetail
        Else
            grpOwnerHeader.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.None
        End If

        ''lg 6661 Add option to Sub-total by Contract in Maintenance Dues Statements
        GroupFooter2.Visible = False
        If ShowSubtotalbyContract Then
            GroupFooter2.Visible = True
        End If

    End Sub

    Private Sub hideWeek(Optional realign As Boolean = True)
        lblWeekNo.Visible = False
        txtWeekNo.Visible = False

        Line18.Visible = False
        Line4.Visible = False

        If realign Then
            Dim startPoint As Double = txtWeekNo.Location.X

            lblContractDesc.Location = New System.Drawing.PointF(startPoint, lblContractDesc.Location.Y)
            txtContractDesc.Location = New System.Drawing.PointF(startPoint, txtContractDesc.Location.Y)

            startPoint = startPoint + txtContractDesc.Size.Width + 0.03

            Line23.Location = New System.Drawing.PointF(startPoint, Line23.Location.Y)
            Line24.Location = New System.Drawing.PointF(startPoint, Line24.Location.Y)

            fixColumns(startPoint, txtRoomNo.Size.Width + txtDescription.Size.Width)

        End If
    End Sub

    Private Sub hideUnit(Optional realign As Boolean = True)
        txtRoomNo.Visible = False
        lblRoomNo.Visible = False

        Line33.Visible = False
        Line13.Visible = False

        If realign Then
            Dim startPoint As Double = txtRoomNo.Location.X

            lblWeekNo.Location = New System.Drawing.PointF(startPoint, lblWeekNo.Location.Y)
            txtWeekNo.Location = New System.Drawing.PointF(startPoint, txtWeekNo.Location.Y)

            startPoint = startPoint + txtWeekNo.Size.Width + 0.03

            Line18.Location = New System.Drawing.PointF(startPoint, Line18.Location.Y)
            Line4.Location = New System.Drawing.PointF(startPoint, Line4.Location.Y)

            startPoint = startPoint + 0.03

            lblContractDesc.Location = New System.Drawing.PointF(startPoint, lblContractDesc.Location.Y)
            txtContractDesc.Location = New System.Drawing.PointF(startPoint, txtContractDesc.Location.Y)

            startPoint = startPoint + txtContractDesc.Size.Width + 0.03

            Line23.Location = New System.Drawing.PointF(startPoint, Line23.Location.Y)
            Line24.Location = New System.Drawing.PointF(startPoint, Line24.Location.Y)

            fixColumns(startPoint, txtRoomNo.Size.Width + txtDescription.Size.Width)

        End If
    End Sub

    Private Sub hideUnitWeek()

        hideWeek(False)
        hideUnit(False)

        Dim startPoint As Double = txtRoomNo.Location.X

        lblContractDesc.Location = New System.Drawing.PointF(startPoint, lblContractDesc.Location.Y)
        txtContractDesc.Location = New System.Drawing.PointF(startPoint, txtContractDesc.Location.Y)

        startPoint = startPoint + txtContractDesc.Size.Width + 0.03

        Line23.Location = New System.Drawing.PointF(startPoint, Line23.Location.Y)
        Line24.Location = New System.Drawing.PointF(startPoint, Line24.Location.Y)

        fixColumns(startPoint, txtWeekNo.Size.Width + txtRoomNo.Size.Width + txtDescription.Size.Width)

    End Sub

    Private Sub hideContractDesc(Optional realign As Boolean = True)
        lblContractDesc.Visible = False
        txtContractDesc.Visible = False

        Line23.Visible = False
        Line24.Visible = False

        If realign Then
            fixColumns(txtContractDesc.Location.X, txtContractDesc.Size.Width)
        End If
    End Sub

    Private Sub hideContractDescAndWeek()
        hideWeek(False)
        hideContractDesc(False)

        fixColumns(txtWeekNo.Location.X, txtWeekNo.Size.Width + txtDescription.Size.Width)

    End Sub

    Private Sub hideContractDescAndUnit()
        hideUnit(False)
        hideContractDesc(False)

        Dim startPoint As Double = txtRoomNo.Location.X

        lblWeekNo.Location = New System.Drawing.PointF(startPoint, lblWeekNo.Location.Y)
        txtWeekNo.Location = New System.Drawing.PointF(startPoint, txtWeekNo.Location.Y)

        startPoint = startPoint + txtWeekNo.Size.Width + 0.03

        Line18.Location = New System.Drawing.PointF(startPoint, Line18.Location.Y)
        Line4.Location = New System.Drawing.PointF(startPoint, Line4.Location.Y)

        fixColumns(startPoint, txtRoomNo.Size.Width + txtDescription.Size.Width)
    End Sub

    Private Sub hideUnitWeekAndContractDesc()

        hideUnit(False)
        hideWeek(False)
        hideContractDesc(False)

        fixColumns(txtRoomNo.Location.X, txtContractDesc.Size.Width + txtWeekNo.Size.Width + txtRoomNo.Size.Width)

    End Sub

    Private Sub fixColumns(ByVal startPoint As Double, ByVal descriptionSize As Double)
        startPoint = startPoint + 0.03

        lblDate.Location = New System.Drawing.PointF(startPoint, lblDate.Location.Y)
        txtDate.Location = New System.Drawing.PointF(startPoint, txtDate.Location.Y)

        startPoint = startPoint + txtDate.Size.Width + 0.03

        Line19.Location = New System.Drawing.PointF(startPoint, Line19.Location.Y)
        Line16.Location = New System.Drawing.PointF(startPoint, Line16.Location.Y)

        startPoint = startPoint + 0.03

        lblType.Location = New System.Drawing.PointF(startPoint, lblType.Location.Y)
        txtTrxType.Location = New System.Drawing.PointF(startPoint, txtTrxType.Location.Y)

        startPoint = startPoint + txtTrxType.Size.Width + 0.03

        Line20.Location = New System.Drawing.PointF(startPoint, Line20.Location.Y)
        Line1.Location = New System.Drawing.PointF(startPoint, Line1.Location.Y)

        startPoint = startPoint + 0.03

        lblBillcodeDesc.Location = New System.Drawing.PointF(startPoint, lblBillcodeDesc.Location.Y)
        txtDescription.Location = New System.Drawing.PointF(startPoint, txtDescription.Location.Y)

        lblBillcodeDesc.Size = New System.Drawing.SizeF(descriptionSize, 0.16)
        txtDescription.Size = New System.Drawing.SizeF(descriptionSize, 0.16)
    End Sub

    Private Sub grpOwnerHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles grpOwnerHeader.Format
        Dim ds As DataSet

        _ownerFooterPrinted = False
        If Me.txtOwnerId.Text <> Me.CurrentOwnerId Then
            GetCustomerNameAddress()
            Me.CurrentOwnerId = Me.txtOwnerId.Text
        End If
        _insMaintFeeBal = 0
        lstContracts = New System.Collections.Generic.LinkedList(Of Integer)

        If UKStatement Then
            Label19.Text = "Please ensure that you have placed your Owner ID on your cheque."
            'YV: 20362
            Me.logo.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Stretch
        Else
            Label19.Text = "Please ensure that you have placed your Owner ID on your check."
            'YV: 20362
            Me.logo.SizeMode = GrapeCity.ActiveReports.SectionReportModel.SizeModes.Zoom
        End If


        txtCustName.Value = customerName


        Me.txtCustAddr1.Value = customerAddress


        txtOwnerAddr.Text = customerAddress
        'RESORT INFORMATION
        Me.lblClientName.Text = ClientNameRet
        Me.txtResortAddress1.Text = Address1Ret

        If Address2Ret <> "" Then
            Me.txtResortAddress2.Text = Address2Ret
            Me.txtResortCSZ.Text = CSZRet
            Me.txtResortCountry.Text = CountryRet
        Else
            Me.txtResortAddress2.Text = CSZRet
            Me.txtResortCSZ.Text = CountryRet
            Me.txtResortCountry.Text = ""
        End If

        If ShowCollector AndAlso txtColID.Text <> "" Then
            Me.lblClientNameB.Text = txtColName.Text
            Me.txtResortAddress1B.Text = txtColAddr1.Text

            If txtColAddr2.Text <> "" Then
                Me.txtResortAddress2B.Text = txtColAddr2.Text
                Me.txtResortCSZB.Text = txtColCSZ.Text
                Me.txtResortCountryB.Text = txtColCountry.Text
            Else
                Me.txtResortAddress2B.Text = txtColCSZ.Text
                Me.txtResortCSZB.Text = txtColCountry.Text
                Me.txtResortCountryB.Text = ""
            End If
        Else
            Me.lblClientNameB.Text = ClientName
            Me.txtResortAddress1B.Text = Address1

            If Address2 <> "" Then
                Me.txtResortAddress2B.Text = Address2
                Me.txtResortCSZB.Text = CSZ
                Me.txtResortCountryB.Text = Country
            Else
                Me.txtResortAddress2B.Text = CSZ
                Me.txtResortCSZB.Text = Country
                Me.txtResortCountryB.Text = ""
            End If
        End If
        'lg-20588:Dev work: Allow Dues and Loan Statements to be printed in multiple languages
        rptOwners = New rptStatementOwners

        If ShowSecondOwner Then
            ds = objMDTransactionDALC.GetOwnerAdditionalContactsDetails(NumOfOwners)
            Dim dv As DataView
            Dim dvSOwner As DataView
            Dim countSecondartOwner As Integer = 0
            Dim strSecondartOwner As String = ""

            dvSOwner = New DataView(ds.Tables(0), "Secondary = 1", "ID", DataViewRowState.CurrentRows)
            If dvSOwner.ToTable().Rows.Count > 0 Then
                For Each Rw As DataRow In dvSOwner.ToTable().Rows
                    If strSecondartOwner <> Rw("FullName") Then
                        countSecondartOwner = countSecondartOwner + 1
                        strSecondartOwner = Rw("FullName")
                    End If
                Next
            End If
            If countSecondartOwner = 1 Then
                dv = New DataView(ds.Tables(0), "Dues = 1 and Secondary = 1", "ID", DataViewRowState.CurrentRows)
            Else
                dv = New DataView(ds.Tables(0), "Dues = 1 Or Secondary = 1", "ID", DataViewRowState.CurrentRows)
            End If

            If dv.ToTable().Rows.Count > 0 Then
                'rptOwners = New rptStatementOwners
                rptOwners.DataSource = dv
                SubReportOwners.Report = rptOwners
                SubReportOwners.Visible = True
            Else
                SubReportOwners.Visible = False
            End If
        End If

    End Sub
    Private Sub GetCustomerNameAddress()

        customerName = "Angelina Rumayor"
        secondCustomerName = "Milan Rumayor"
        customerAddress = GetCustomerAddress()
    End Sub
    Private Function GetCustomerAddress() As String
        'lma 23883
        Dim address As New Text.StringBuilder
        Try

            If Fields("address").Value.ToString.Trim.Length > 0 Then
                address.Append(Fields("address").Value.ToString & vbNewLine)
            End If

            If Fields("address1").Value.ToString.Trim.Length > 0 Then
                address.Append(Fields("address1").Value.ToString & vbNewLine)
            End If

            If Fields("address2").Value.ToString.Trim.Length > 0 Then
                address.Append(Fields("address2").Value.ToString & vbNewLine)
            End If

            If Fields("csz").Value.ToString.Trim.Length > 0 Then
                address.Append(Fields("csz").Value.ToString & vbNewLine)
            End If

            If Fields("COUNTRY").Value.Trim.Length > 0 Then
                address.Append(Fields("COUNTRY").Value.ToString & vbNewLine)
            End If

            If ShowPhoneNo Then
                Dim phoneValue As String
                If Fields("phone").Value.ToString.Trim.Length > 0 Then
                    phoneValue = Fields("phone").Value.ToString

                    If phoneValue.Length <> 10 OrElse Not USPhoneFormat Then
                        phoneValue = Fields("phone").Value.ToString
                    Else
                        phoneValue = String.Format("({0}) {1}-{2}",
                                            phoneValue.Substring(0, 3),
                                            phoneValue.Substring(3, 3),
                                            phoneValue.Substring(6))
                    End If
                    address.Append(phoneValue & vbNewLine)
                End If
            End If



            Return address.ToString

        Catch ex As Exception
            'Log.Error(ex.Message, ex) 'lg 13129
            Return ""
        End Try
    End Function

    Private Sub GroupFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        Dim showINSComments As Boolean
        'Dim totalAmountComment As String = ""
        Dim _insPrice As Decimal

        lnSecAge.Visible = IsDuesLocalCurrencySet
        lnSecAge1.Visible = IsDuesLocalCurrencySet
        lnSecAge2.Visible = IsDuesLocalCurrencySet
        lnSecAge3.Visible = IsDuesLocalCurrencySet
        lnSecAge4.Visible = IsDuesLocalCurrencySet
        lnSecAge5.Visible = IsDuesLocalCurrencySet
        txtAge21.Visible = IsDuesLocalCurrencySet
        txtAge22.Visible = IsDuesLocalCurrencySet
        txtAge23.Visible = IsDuesLocalCurrencySet
        txtAge24.Visible = IsDuesLocalCurrencySet
        Label2.Visible = IsDuesLocalCurrencySet
        txtTotalDueBal2.Visible = IsDuesLocalCurrencySet
        txtTotalDueSecndCurr.Visible = IsDuesLocalCurrencySet

        If Not IsDuesLocalCurrencySet Then
            'Move Up Days Panel
            Line14.Location = New PointF(Me.Line14.Location.X, Me.Line14.Location.Y - 0.2)
            LineAge2.Location = New PointF(Me.LineAge2.Location.X, Me.LineAge2.Location.Y - 0.2)
            LineAge3.Location = New PointF(Me.LineAge3.Location.X, Me.LineAge3.Location.Y - 0.2)
            LineAge4.Location = New PointF(Me.LineAge4.Location.X, Me.LineAge4.Location.Y - 0.2)
            Line32.Location = New PointF(Me.Line32.Location.X, Me.Line32.Location.Y - 0.2)
            LineAge6.Location = New PointF(Me.LineAge6.Location.X, Me.LineAge6.Location.Y - 0.2)
            lblAging.Location = New PointF(Me.lblAging.Location.X, Me.lblAging.Location.Y - 0.2)
            lblAge1.Location = New PointF(Me.lblAge1.Location.X, Me.lblAge1.Location.Y - 0.2)
            lblAge2.Location = New PointF(Me.lblAge2.Location.X, Me.lblAge2.Location.Y - 0.2)
            lblAge3.Location = New PointF(Me.lblAge3.Location.X, Me.lblAge3.Location.Y - 0.2)
            lblAge4.Location = New PointF(Me.lblAge4.Location.X, Me.lblAge4.Location.Y - 0.2)
            txtAge1.Location = New PointF(Me.txtAge1.Location.X, Me.txtAge1.Location.Y - 0.2)
            txtAge2.Location = New PointF(Me.txtAge2.Location.X, Me.txtAge2.Location.Y - 0.2)
            txtAge3.Location = New PointF(Me.txtAge3.Location.X, Me.txtAge3.Location.Y - 0.2)
            txtAge4.Location = New PointF(Me.txtAge4.Location.X, Me.txtAge4.Location.Y - 0.2)
            txtAge1Curr.Location = New PointF(Me.txtAge1Curr.Location.X, Me.txtAge1Curr.Location.Y - 0.2)
            txtAge2Curr.Location = New PointF(Me.txtAge2Curr.Location.X, Me.txtAge2Curr.Location.Y - 0.2)
            txtAge3Curr.Location = New PointF(Me.txtAge3Curr.Location.X, Me.txtAge3Curr.Location.Y - 0.2)
            txtAge4Curr.Location = New PointF(Me.txtAge4Curr.Location.X, Me.txtAge4Curr.Location.Y - 0.2)

            'Move up Total amount Plus Protection Plan value
            lblVGTPAmt.Location = New PointF(Me.lblVGTPAmt.Location.X, Me.lblVGTPAmt.Location.Y - 0.45)
            txtVGTPAmount.Location = New PointF(Me.txtVGTPAmount.Location.X, Me.txtVGTPAmount.Location.Y - 0.45)
            TextBox5.Location = New PointF(Me.TextBox5.Location.X, Me.TextBox5.Location.Y - 0.45)
            Shape1.Location = New PointF(Me.Shape1.Location.X, Me.Shape1.Location.Y - 0.45)
            'Move up comments
            Me.txtComments.Location = New PointF(Me.txtComments.Location.X, Me.txtComments.Location.Y - 0.4)
            'SubReportUnitWeek.Location = New PointF(Me.SubReportUnitWeek.Location.X, Me.SubReportUnitWeek.Location.Y - 0.4)
            'SubReportOwners.Location = New PointF(Me.SubReportOwners.Location.X, Me.SubReportOwners.Location.Y - 0.4)

            GroupFooter1.Height = GroupFooter1.Height - 0.4
        End If

        'YRA 1152
        If txtVGTPAmount.Text <> "" AndAlso ShowAmntPlusProtection Then
            lblVGTPAmt.Visible = True
            txtVGTPAmount.Visible = True
            TextBox5.Visible = True
            Shape1.Visible = True
        Else
            Me.txtComments.Location = New PointF(Me.txtComments.Location.X, Me.txtComments.Location.Y - 0.2)
            lblVGTPAmt.Visible = False
            txtVGTPAmount.Visible = False
            TextBox5.Visible = False
            Shape1.Visible = False
        End If


        'Assigning the SubReport within the GroupFooter Format event (earlier was assigned in the GroupHeader Format event which was causing it to reassign when the GroupHeader was getting formatted in the new page)
        rptUnitWeek = New rptStatementUnitWeek
        'ChangeLanguage()
        If ShowUnitWeek Then
            'rptUnitWeek = New rptStatementUnitWeek
            rptUnitWeek.DataSource = objMDTransactionDALC.GetMDStatementUnitWeek(NumOfUnitWeek).Tables("UnitWeek")
            SubReportUnitWeek.Report = rptUnitWeek
        End If

    End Sub

    Private Sub grpOwnerFooter_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpOwnerFooter.Format

        Me.chkDeclineTravelInsurance.Visible = False
    End Sub
    Private Sub setcontrol()
        If Not languageds.Tables(0) Is Nothing AndAlso languageds.Tables(0).Rows.Count > 0 AndAlso languageds.Tables(0).Columns.Contains("lableName") AndAlso languageds.Tables(0).Columns.Contains("defaultText") Then
            For i As Integer = 0 To languageds.Tables(0).Rows.Count - 1
                If "rptOwners" & rptOwners.Label1.Name.ToString() = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = "rptOwners" & rptOwners.Label1.Name
                    rptOwners.Label1.Text = languageds.Tables(0).Rows(i)("FieldName")
                End If
                If "rptOwners" & rptOwners.Label2.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = "rptOwners" & rptOwners.Label2.Name
                    rptOwners.Label2.Text = languageds.Tables(0).Rows(i)("FieldName")
                End If
                If "rptOwners" & rptOwners.Label3.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = "rptOwners" & rptOwners.Label3.Name
                    rptOwners.Label3.Text = languageds.Tables(0).Rows(i)("FieldName")
                End If

                If "rptUnitWeek" & rptUnitWeek.Label1.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = "rptUnitWeek" & rptUnitWeek.Label1.Name
                    rptUnitWeek.Label1.Text = defaultlanguagedata.Tables(0).Rows(i)("FieldName")
                End If
                If "rptUnitWeek" & rptUnitWeek.Label2.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = "rptUnitWeek" & rptUnitWeek.Label2.Name
                    rptUnitWeek.Label2.Text = defaultlanguagedata.Tables(0).Rows(i)("FieldName")
                End If
                If "rptUnitWeek" & rptUnitWeek.Label3.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = "rptUnitWeek" & rptUnitWeek.Label3.Name
                    rptUnitWeek.Label3.Text = defaultlanguagedata.Tables(0).Rows(i)("FieldName")
                End If
                If "rptUnitWeek" & rptUnitWeek.Label4.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = "rptUnitWeek" & rptUnitWeek.Label4.Name
                    rptUnitWeek.Label4.Text = defaultlanguagedata.Tables(0).Rows(i)("FieldName")
                End If
                If "rptUnitWeek" & rptUnitWeek.LabelUDF.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = "rptUnitWeek" & rptUnitWeek.LabelUDF.Name
                    rptUnitWeek.LabelUDF.Text = defaultlanguagedata.Tables(0).Rows(i)("FieldName")
                End If

                If Me.lblReportName.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblReportName.Name
                    Me.lblReportName.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblStmtDate.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblStmtDate.Name
                    Me.lblStmtDate.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                    Me.Label9.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblDueDate.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblDueDate.Name
                    Me.lblDueDate.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                    Me.Label10.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblAgingDate.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblAgingDate.Name
                    Me.lblAgingDate.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblResortHeader.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblResortHeader.Name
                    Me.lblResortHeader.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblOwnerId.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblOwnerId.Name
                    Me.lblOwnerId.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                    Me.Label13.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblAmtDue.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblAmtDue.Name
                    Me.lblAmtDue.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                    Me.Label14.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblPaid.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblPaid.Name
                    Me.lblPaid.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblTransNo.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblTransNo.Name
                    Me.lblTransNo.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblContractNo.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblContractNo.Name
                    Me.lblContractNo.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblRoomNo.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblRoomNo.Name
                    Me.lblRoomNo.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblWeekNo.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblWeekNo.Name
                    Me.lblWeekNo.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.Label1.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = Label1.Name
                    Me.Label1.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblDate.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblDate.Name
                    Me.lblDate.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.Label2.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = Label2.Name
                    Me.Label2.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.Label19.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = Label19.Name
                    Me.Label19.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.Label7.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = Label7.Name
                    Me.Label7.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblType.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblType.Name
                    Me.lblType.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.Label8.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = Label8.Name
                    Me.Label8.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.Label9.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = Label9.Name
                    Me.Label9.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                    Me.lblStmtDate.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblCCNo.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblCCNo.Name
                    Me.lblCCNo.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.Label11.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = Label11.Name
                    Me.Label11.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblBillcodeDesc.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblBillcodeDesc.Name
                    Me.lblBillcodeDesc.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblBalance.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblBalance.Name
                    Me.lblBalance.Text = Replace(Me.lblBalance.Text.ToString(), languageds.Tables(0).Rows(i)("Translation").ToString(), languageds.Tables(0).Rows(i)("FieldName").ToString())
                End If
                If Me.lblAmount.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblAmount.Name
                    Me.lblAmount.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.Label10.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = Label10.Name
                    Me.Label10.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                    Me.lblDueDate.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblResortFooter.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblResortFooter.Name
                    Me.lblResortFooter.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.Label13.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = Label13.Name
                    Me.Label13.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                    Me.lblOwnerId.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.Label14.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = Label14.Name
                    Me.Label14.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                    Me.lblAmtDue.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblAmtVGTP.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblAmtVGTP.Name
                    Me.lblAmtVGTP.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.Label15.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = Label15.Name
                    Me.Label15.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblCCNo.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblCCNo.Name
                    Me.lblCCNo.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblCCExp.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblCCExp.Name
                    Me.lblCCExp.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.Label.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = Label.Name
                    Me.Label.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblSignature.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblSignature.Name
                    Me.lblSignature.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblContractDesc.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblContractDesc.Name
                    Me.lblContractDesc.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If Me.lblVGTPAmt.Name = languageds.Tables(0).Rows(i)("lableName").ToString() Then
                    languageds.Tables(0).Rows(i)("LableName") = lblVGTPAmt.Name
                    Me.lblVGTPAmt.Text = languageds.Tables(0).Rows(i)("FieldName").ToString()
                End If
                If totalAmountComment IsNot Nothing AndAlso totalAmountComment.ToString().Contains(languageds.Tables(0).Rows(i)("Translation").ToString()) Then
                    totalAmountComment = Replace(totalAmountComment, languageds.Tables(0).Rows(i)("Translation").ToString(), languageds.Tables(0).Rows(i)("FieldName").ToString())
                End If

            Next
            lblAge1.Text = CStr(Age1) & "-" & CStr(Age2 - 1) & " Days"
            lblAge2.Text = CStr(Age2) & "-" & CStr(Age3 - 1) & " Days"
            lblAge3.Text = CStr(Age3) & "-" & CStr(Age4 - 1) & " Days"
            lblAge4.Text = "Over " & CStr(Age4) & " Days"
        End If
    End Sub
End Class
