Public Class MDTransactionDALC
    Public Function GetMDStatementUnitWeek(ByVal amountOfRecords As Integer) As DataSet
        Dim rdm As New Random
        Dim ds As New DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim roomNum, weekNo, status, contractId, udf1, totalUnits As DataColumn

        dt = New DataTable("UnitWeek")
        roomNum = New DataColumn("RoomNum", Type.GetType("System.String"))
        weekNo = New DataColumn("WeekNo", Type.GetType("System.Int32"))
        status = New DataColumn("Status", Type.GetType("System.String"))
        contractId = New DataColumn("ContractId", Type.GetType("System.Int32"))
        udf1 = New DataColumn("UDF1", Type.GetType("System.String"))
        totalUnits = New DataColumn("TotalUnits", Type.GetType("System.Int32"))

        dt.Columns.Add(roomNum)
        dt.Columns.Add(weekNo)
        dt.Columns.Add(status)
        dt.Columns.Add(contractId)
        dt.Columns.Add(udf1)
        dt.Columns.Add(totalUnits)

        For index = 1 To amountOfRecords
            dr = dt.NewRow()
            dr("RoomNum") = rdm.Next(1, 300).ToString()
            dr("WeekNo") = rdm.Next(1, 53)
            dr("Status") = "Active"
            dr("ContractId") = rdm.Next(100, 1000)
            dr("UDF1") = "Test " + rdm.Next(100, 1000).ToString()
            dr("TotalUnits") = rdm.Next(1, 20)
            dt.Rows.Add(dr)
        Next

        ds.Tables.Add(dt)

        Return ds

    End Function

    Friend Function GetMDStatement(ByVal amountOfRecords As Integer) As DataSet
        Dim rdm As New Random
        Dim ds As New DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim lName, fName, mName, lName2, fName2, mName2, address, address1, address2, csz, country, phone, ownerId, contractId, scId, collectorId, trxNo, billCodeId, billCodeName, billCodeDesc, balance, amount, txType, salesContractDesc, age1, age2, age3, age4, secondaryBalance, mcAmount, secondaryage1, secondaryage2, secondaryage3, secondaryage4, roomNum, weekNo, ownerBalance, displayOrder, secondaryOwnerBal, colId, colDesc, collAddr1, collAddr2, collCSZ, colCountry, orderName, email, duesPaperlessStatement, fisrtRowCurrency, secondRowCurrency, isValidEmail As DataColumn

        dt = New DataTable("Statement")

        lName = New DataColumn("LName", Type.GetType("System.String"))
        fName = New DataColumn("FName", Type.GetType("System.String"))
        mName = New DataColumn("MName", Type.GetType("System.String"))
        lName2 = New DataColumn("LName2", Type.GetType("System.String"))
        fName2 = New DataColumn("FName2", Type.GetType("System.String"))
        mName2 = New DataColumn("MName2", Type.GetType("System.String"))
        address = New DataColumn("Address", Type.GetType("System.String"))
        address1 = New DataColumn("Address1", Type.GetType("System.String"))
        address2 = New DataColumn("Address2", Type.GetType("System.String"))
        csz = New DataColumn("CSZ", Type.GetType("System.String"))
        country = New DataColumn("Country", Type.GetType("System.String"))
        phone = New DataColumn("phone", Type.GetType("System.String"))
        ownerId = New DataColumn("ownerId", Type.GetType("System.String"))
        contractId = New DataColumn("contractId", Type.GetType("System.Int32"))
        scId = New DataColumn("scId", Type.GetType("System.Int32"))
        collectorId = New DataColumn("CollectorId", Type.GetType("System.Int32"))
        trxNo = New DataColumn("trxNo", Type.GetType("System.Int32"))
        billCodeId = New DataColumn("BillCodeId", Type.GetType("System.Int32"))
        billCodeName = New DataColumn("BillCodeName", Type.GetType("System.String"))
        billCodeDesc = New DataColumn("BillCodeDesc", Type.GetType("System.String"))
        balance = New DataColumn("Balance", Type.GetType("System.Decimal"))
        amount = New DataColumn("Amount", Type.GetType("System.Decimal"))
        txType = New DataColumn("TxType", Type.GetType("System.String"))
        salesContractDesc = New DataColumn("SalesContractDesc", Type.GetType("System.String"))
        age1 = New DataColumn("age1", Type.GetType("System.Decimal"))
        age2 = New DataColumn("age2", Type.GetType("System.Decimal"))
        age3 = New DataColumn("age3", Type.GetType("System.Decimal"))
        age4 = New DataColumn("age4", Type.GetType("System.Decimal"))
        secondaryBalance = New DataColumn("SecondaryBalance", Type.GetType("System.Decimal"))
        mcAmount = New DataColumn("mcAmount", Type.GetType("System.Decimal"))
        secondaryage1 = New DataColumn("secondaryage1", Type.GetType("System.Decimal"))
        secondaryage2 = New DataColumn("secondaryage2", Type.GetType("System.Decimal"))
        secondaryage3 = New DataColumn("secondaryage3", Type.GetType("System.Decimal"))
        secondaryage4 = New DataColumn("secondaryage4", Type.GetType("System.Decimal"))
        roomNum = New DataColumn("RoomNum", Type.GetType("System.String"))
        weekNo = New DataColumn("WeekNo", Type.GetType("System.Int32"))
        ownerBalance = New DataColumn("OwnerBalance", Type.GetType("System.Decimal"))
        displayOrder = New DataColumn("DisplayOrder", Type.GetType("System.Int32"))
        secondaryOwnerBal = New DataColumn("DecondaryOwnerBal", Type.GetType("System.Decimal"))
        colId = New DataColumn("colId", Type.GetType("System.String"))
        colDesc = New DataColumn("colDesc", Type.GetType("System.String"))
        collAddr1 = New DataColumn("CollAddr1", Type.GetType("System.String"))
        collAddr2 = New DataColumn("CollAddr2", Type.GetType("System.String"))
        collCSZ = New DataColumn("CollCSZ", Type.GetType("System.String"))
        colCountry = New DataColumn("ColCountry", Type.GetType("System.String"))
        orderName = New DataColumn("OrderName", Type.GetType("System.String"))
        email = New DataColumn("Email", Type.GetType("System.String"))
        duesPaperlessStatement = New DataColumn("DuesPaperlessStatement", Type.GetType("System.Boolean"))
        fisrtRowCurrency = New DataColumn("FisrtRowCurrency", Type.GetType("System.String"))
        secondRowCurrency = New DataColumn("SecondRowCurrency", Type.GetType("System.String"))
        isValidEmail = New DataColumn("IsValidEmail", Type.GetType("System.Boolean"))

        dt.Columns.Add(lName)
        dt.Columns.Add(fName)
        dt.Columns.Add(mName)
        dt.Columns.Add(lName2)
        dt.Columns.Add(fName2)
        dt.Columns.Add(mName2)
        dt.Columns.Add(address)
        dt.Columns.Add(address1)
        dt.Columns.Add(address2)
        dt.Columns.Add(csz)
        dt.Columns.Add(country)
        dt.Columns.Add(phone)
        dt.Columns.Add(ownerId)
        dt.Columns.Add(contractId)
        dt.Columns.Add(scId)
        dt.Columns.Add(collectorId)
        dt.Columns.Add(trxNo)
        dt.Columns.Add(billCodeId)
        dt.Columns.Add(billCodeName)
        dt.Columns.Add(billCodeDesc)
        dt.Columns.Add(balance)
        dt.Columns.Add(amount)
        dt.Columns.Add(txType)
        dt.Columns.Add(salesContractDesc)
        dt.Columns.Add(age1)
        dt.Columns.Add(age2)
        dt.Columns.Add(age3)
        dt.Columns.Add(age4)
        dt.Columns.Add(secondaryBalance)
        dt.Columns.Add(mcAmount)
        dt.Columns.Add(secondaryage1)
        dt.Columns.Add(secondaryage2)
        dt.Columns.Add(secondaryage3)
        dt.Columns.Add(secondaryage4)
        dt.Columns.Add(roomNum)
        dt.Columns.Add(weekNo)
        dt.Columns.Add(ownerBalance)
        dt.Columns.Add(displayOrder)
        dt.Columns.Add(secondaryOwnerBal)
        dt.Columns.Add(colId)
        dt.Columns.Add(colDesc)
        dt.Columns.Add(collAddr1)
        dt.Columns.Add(collAddr2)
        dt.Columns.Add(collCSZ)
        dt.Columns.Add(colCountry)
        dt.Columns.Add(orderName)
        dt.Columns.Add(email)
        dt.Columns.Add(duesPaperlessStatement)
        dt.Columns.Add(fisrtRowCurrency)
        dt.Columns.Add(secondRowCurrency)
        dt.Columns.Add(isValidEmail)



        For index = 1 To amountOfRecords
            dr = dt.NewRow()

            dr("LName") = "Henry"
            dr("FName") = "John"
            dr("MName") = ""
            dr("LName2") = ""
            dr("FName2") = ""
            dr("MName2") = ""
            dr("Address") = "Address Line 01"
            dr("Address1") = "Address Line 02"
            dr("Address2") = "Address Line 03"
            dr("CSZ") = "Miami, FL  65000"
            dr("Country") = "United States of America"
            dr("phone") = "1236547896"
            dr("ownerId") = "11818"
            dr("contractId") = rdm.Next(100, 1000)
            dr("scId") = rdm.Next(100, 1000)
            dr("CollectorId") = rdm.Next(100, 1000)
            dr("trxNo") = rdm.Next(100, 1000)
            dr("BillCodeId") = rdm.Next(100, 1000)
            dr("BillCodeName") = "Unapplied"
            dr("BillCodeDesc") = "Unapplied"
            dr("Balance") = rdm.Next(100, 1000)
            dr("Amount") = rdm.Next(100, 1000)
            dr("TxType") = "PMT"
            dr("SalesContractDesc") = "test"
            dr("age1") = rdm.Next(100, 1000)
            dr("age2") = rdm.Next(100, 1000)
            dr("age3") = rdm.Next(100, 1000)
            dr("age4") = rdm.Next(100, 1000)
            dr("SecondaryBalance") = rdm.Next(100, 1000)
            dr("mcAmount") = rdm.Next(100, 1000)
            dr("secondaryage1") = rdm.Next(100, 1000)
            dr("secondaryage2") = rdm.Next(100, 1000)
            dr("secondaryage3") = rdm.Next(100, 1000)
            dr("secondaryage4") = rdm.Next(100, 1000)
            dr("RoomNum") = rdm.Next(100, 1000).ToString()
            dr("WeekNo") = rdm.Next(1, 20)
            dr("OwnerBalance") = rdm.Next(100, 1000)
            dr("DisplayOrder") = rdm.Next(1, 20)
            dr("DecondaryOwnerBal") = rdm.Next(100, 1000)
            dr("colId") = ""
            dr("colDesc") = ""
            dr("CollAddr1") = ""
            dr("CollAddr2") = ""
            dr("CollCSZ") = ""
            dr("ColCountry") = ""
            dr("OrderName") = "Henry John "
            dr("Email") = "vinit.nishnarao@spiinc.com"
            dr("DuesPaperlessStatement") = False
            dr("FisrtRowCurrency") = ""
            dr("SecondRowCurrency") = ""
            dr("IsValidEmail") = True

            dt.Rows.Add(dr)
        Next

        ds.Tables.Add(dt)
        Return ds
    End Function

    Friend Function GetOwnerAdditionalContactsDetails(ByVal amountOfRecords As Integer) As DataSet
        Dim rdm As New Random
        Dim ds As New DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim id, contractNo, resort, status, secondary, dues, res, ownerRental, sharedPercent, fullName, roomNo, week As DataColumn

        dt = New DataTable("Details")

        id = New DataColumn("ID", Type.GetType("System.Int32"))
        contractNo = New DataColumn("ContractNo", Type.GetType("System.Int32"))
        resort = New DataColumn("ResortId", Type.GetType("System.String"))
        status = New DataColumn("Status", Type.GetType("System.String"))
        secondary = New DataColumn("Secondary", Type.GetType("System.Boolean"))
        dues = New DataColumn("Dues", Type.GetType("System.Boolean"))
        res = New DataColumn("Res", Type.GetType("System.Boolean"))
        ownerRental = New DataColumn("OwnerRental", Type.GetType("System.Boolean"))
        sharedPercent = New DataColumn("SharedPersent", Type.GetType("System.Decimal"))
        fullName = New DataColumn("FullName", Type.GetType("System.String"))
        roomNo = New DataColumn("RoomNo", Type.GetType("System.String"))
        week = New DataColumn("Week", Type.GetType("System.Int32"))

        dt.Columns.Add(id)
        dt.Columns.Add(contractNo)
        dt.Columns.Add(resort)
        dt.Columns.Add(status)
        dt.Columns.Add(secondary)
        dt.Columns.Add(dues)
        dt.Columns.Add(res)
        dt.Columns.Add(ownerRental)
        dt.Columns.Add(sharedPercent)
        dt.Columns.Add(fullName)
        dt.Columns.Add(roomNo)
        dt.Columns.Add(week)

        For index = 1 To amountOfRecords
            dr = dt.NewRow()
            dr("ID") = 2345
            dr("ContractNo") = rdm.Next(100, 1000)
            dr("ResortId") = "R1"
            dr("Status") = "Active"
            dr("Secondary") = True
            dr("Dues") = True
            dr("Res") = True
            dr("OwnerRental") = True
            dr("FullName") = "Souder, Marlene"
            dr("RoomNo") = rdm.Next(1, 100).ToString()
            dr("Week") = rdm.Next(1, 52)
            dt.Rows.Add(dr)
        Next

        ds.Tables.Add(dt)

        Return ds
    End Function
End Class
