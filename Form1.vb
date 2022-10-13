Public Class Form1

    Private rptStatement As rptStatementReport
    Private _dsReportData As DataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RunReport()
    End Sub

    Private Sub RunReport()
        Dim objMDTransactionDALC As MDTransactionDALC

        Try

            _dsReportData = Nothing

            objMDTransactionDALC = New MDTransactionDALC
            Me.rptStatement = New rptStatementReport
            Me.rptStatement.NumOfUnitWeek = numUnitWeek.Value
            Me.rptStatement.NumOfOwners = numOwners.Value
            Me.rptStatement.lblBalance.Text = "Balance(USD)"

            _dsReportData = objMDTransactionDALC.GetMDStatement(numTrans.Value)

            If _dsReportData.Tables("Statement").Rows.Count > 0 Then


                Me.rptStatement.lblVGTPAmt.Visible = True
                Me.rptStatement.txtVGTPAmount.Visible = True
                Me.rptStatement.CheckBox1.Visible = True
                Me.rptStatement.lblAmtVGTP.Visible = True
                Me.rptStatement.txtAmtVGTP.Visible = True
                Me.rptStatement.txtVGTPAmount.Text = 159.0
                Me.rptStatement.txtAmtVGTP.Text = 159.0
                Me.rptStatement.Line25.Visible = True
                Me.rptStatement.txtVGTPAmount.Text = Format(Double.Parse(Me.rptStatement.txtVGTPAmount.Text), "###,###,##0.00")
                Me.rptStatement.txtAmtVGTP.Text = Format(Double.Parse(Me.rptStatement.txtAmtVGTP.Text), "###,###,##0.00")

                'lg 9439
                Me.rptStatement.IsDuesLocalCurrencySet = False


                Me.rptStatement.ShowCollector = False

                'YT: Task20953
                Me.rptStatement.ShowPhoneNo = False
                'YT: Task20953 - End

                'lma 24333
                ' Me.rptStatement.ClientName = Trim(cboResort.SelectedRow.Cells("Name").Value)
                Me.rptStatement.ClientName = "Caribbean Queen Resort"
                Me.rptStatement.ClientNameRet = rptStatement.ClientName


                Me.rptStatement.Address1 = "C/O ABC Resort Management"
                Me.rptStatement.Address2 = "P.O. Box 555"
                Me.rptStatement.CSZ = "Miami, FL, 33137"
                Me.rptStatement.Country = "United States"

                Me.rptStatement.Address1Ret = "C/O ABC Resort Management"
                Me.rptStatement.Address2Ret = "10293 W Elm Street - Ste 1010"
                Me.rptStatement.CSZRet = "Miami, FL 33137"
                Me.rptStatement.CountryRet = "United States"

                Me.rptStatement.ShowAmntPlusProtection = False
                Me.rptStatement.txtResortId.Text = "R1"
                Me.rptStatement.txtResortIdB.Text = "R1"
                Me.rptStatement.txtStmtDate.Text = "10/05/2022"
                Me.rptStatement.txtStmtDateB.Text = "10/05/2022"
                Me.rptStatement.txtDueDate.Text = "10/05/2022"
                Me.rptStatement.txtDueDateB.Text = "10/05/2022"
                Me.rptStatement.txtAgingDate.Text = "10/05/2022"
                Me.rptStatement.ShowCCInfo = False
                Me.rptStatement.ShowCVV = False
                Me.rptStatement.ShowAllContract = True
                Me.rptStatement.ContractFrom = 0
                Me.rptStatement.ContractTo = 0
                Me.rptStatement.ShowSecondOwner = chkSecondOwner.Checked
                Me.rptStatement.txtComments.Text = "AMOUNT DUE IS IN U.S. DOLLARS. On October 22, 2019, the Board of Directors adopted the 2020 Budget for ABC Resort Home Owner's Association. The fees are shown above. The $2 for ARDA-ROC and the $3 for Christel House are voluntary contributions (CONTRIBUTIONS TO ARDA-ROC ARE NOT DEDUCTIBLE FOR FEDERAL INCOME TAX PURPOSES). If you do not wish to participate in these contributions please deduct from total due (If shown itemized above). You can also submit payment online at www.abcresort.com - access the payment link from the ""Owner Login"" (a secure link). Your remittance is due by JANUARY 2, 2020. A Late Fee of $25 USD will be assessed if we do not receive payment by the due date. Failure to receive a statement does not relieve the owner of responsibility of payment or constitute cause for cancellation of assessments, penalties, and fees. It is the owner's responsibility to make sure the resort has the correct mailing address. If you have any questions, please call us at 1-800-222-6000 within the United States or 407-123-4567 EXT. 326 outside the U.S To insure credit to your account, please tear on the line above and make check payable to ABC Resort Owners Association." & vbCrLf & "*Additional bank fees will be charged to the owner for checks from a non U.S. Bank or checks that are returned for non-sufficient funds or other reasons." & vbCrLf & "**The 2020 Home Owners Association Meeting will be held on Tuesday, October 20, 2020 at 11am at the resort."
                Me.rptStatement.ShowBarCode = True
                Me.rptStatement.ShowUnitWeek = chkUnitWeek.Checked
                'Me.rptStatement.ShowCustomerPhone = chkOwnerPhone.Checked 'task:19311
                Me.rptStatement.ShowContractDesc = False
                Me.rptStatement.Age1 = 0
                Me.rptStatement.Age2 = 31
                Me.rptStatement.Age3 = 61
                Me.rptStatement.Age4 = 91
                Me.rptStatement.UKStatement = False
                Me.rptStatement.USPhoneFormat = False
                Me.rptStatement.ShowOMRMark = False
                Me.rptStatement.ShowScanLine = False
                Me.rptStatement.ShowPageHeader = Me.chkPageHeader.Checked
                Me.rptStatement.ShowSubtotalbyContract = False   ''lg 6661 Add option to Sub-total by Contract in Maintenance Dues Statements
                rptStatement.ResortID = "R1"
                Me.rptStatement.ShowUnit = False
                Me.rptStatement.ShowWeek = False
                Me.rptStatement.INSStatementComments = ""
                Me.rptStatement.INSStatementCommentsPrintAbove = True
                Me.rptStatement.INSBillCodeID = 0

                Me.rptStatement.DefaultINSStatementComments = ""
                Me.rptStatement.defaultregulerStatementComments = "AMOUNT DUE IS IN U.S. DOLLARS. On October 22, 2019, the Board of Directors adopted the 2020 Budget for ABC Resort Home Owner's Association. The fees are shown above. The $2 for ARDA-ROC and the $3 for Christel House are voluntary contributions (CONTRIBUTIONS TO ARDA-ROC ARE NOT DEDUCTIBLE FOR FEDERAL INCOME TAX PURPOSES). If you do not wish to participate in these contributions please deduct from total due (If shown itemized above). You can also submit payment online at www.abcresort.com - access the payment link from the ""Owner Login"" (a secure link). Your remittance is due by JANUARY 2, 2020. A Late Fee of $25 USD will be assessed if we do not receive payment by the due date. Failure to receive a statement does not relieve the owner of responsibility of payment or constitute cause for cancellation of assessments, penalties, and fees. It is the owner's responsibility to make sure the resort has the correct mailing address. If you have any questions, please call us at 1-800-222-6000 within the United States or 407-123-4567 EXT. 326 outside the U.S To insure credit to your account, please tear on the line above and make check payable to ABC Resort Owners Association." & vbCrLf & "*Additional bank fees will be charged to the owner for checks from a non U.S. Bank or checks that are returned for non-sufficient funds or other reasons." & vbCrLf & "**The 2020 Home Owners Association Meeting will be held on Tuesday, October 20, 2020 at 11am at the resort."
                rptStatement.StatementToInvc = True
                Me.rptStatement.DataSource = _dsReportData.Tables("Statement")
                Me.vwrReport.Document = Me.rptStatement.Document
                Me.rptStatement.Run()

            Else
                'MessageBox.Show("There is no data available for your selection criteria.", SpiLibrary.Common.Utility.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            'Me.exceptHandler.OnRegularException("An error occured in SubRoutine RunReport" + ex.ToString, SpiLibrary.Common.ExceptionHandler.PolicyLayer.UserInterface, ex)
        Finally

        End Try
    End Sub
End Class