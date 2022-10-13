<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.vwrReport = New GrapeCity.ActiveReports.Viewer.Win.Viewer()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.chkPageHeader = New System.Windows.Forms.CheckBox()
		Me.chkUnitWeek = New System.Windows.Forms.CheckBox()
		Me.chkSecondOwner = New System.Windows.Forms.CheckBox()
		Me.numOwners = New System.Windows.Forms.NumericUpDown()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.numUnitWeek = New System.Windows.Forms.NumericUpDown()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.numTrans = New System.Windows.Forms.NumericUpDown()
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.numOwners, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numUnitWeek, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numTrans, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'vwrReport
		'
		Me.vwrReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.vwrReport.CurrentPage = 0
		Me.vwrReport.Location = New System.Drawing.Point(12, 154)
		Me.vwrReport.Name = "vwrReport"
		Me.vwrReport.PreviewPages = 0
		'
		'
		'
		'
		'
		'
		Me.vwrReport.Sidebar.ParametersPanel.ContextMenu = Nothing
		Me.vwrReport.Sidebar.ParametersPanel.Text = "Parameters"
		Me.vwrReport.Sidebar.ParametersPanel.Width = 200
		'
		'
		'
		Me.vwrReport.Sidebar.SearchPanel.ContextMenu = Nothing
		Me.vwrReport.Sidebar.SearchPanel.Text = "Search results"
		Me.vwrReport.Sidebar.SearchPanel.Width = 200
		'
		'
		'
		Me.vwrReport.Sidebar.ThumbnailsPanel.ContextMenu = Nothing
		Me.vwrReport.Sidebar.ThumbnailsPanel.Text = "Page thumbnails"
		Me.vwrReport.Sidebar.ThumbnailsPanel.Width = 200
		Me.vwrReport.Sidebar.ThumbnailsPanel.Zoom = 0.1R
		'
		'
		'
		Me.vwrReport.Sidebar.TocPanel.ContextMenu = Nothing
		Me.vwrReport.Sidebar.TocPanel.Expanded = True
		Me.vwrReport.Sidebar.TocPanel.Text = "Document map"
		Me.vwrReport.Sidebar.TocPanel.Width = 200
		Me.vwrReport.Sidebar.Width = 200
		Me.vwrReport.Size = New System.Drawing.Size(916, 326)
		Me.vwrReport.TabIndex = 1
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(558, 36)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(126, 23)
		Me.Button1.TabIndex = 397
		Me.Button1.Text = "Run Report"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'chkPageHeader
		'
		Me.chkPageHeader.AutoSize = True
		Me.chkPageHeader.BackColor = System.Drawing.Color.Transparent
		Me.chkPageHeader.Location = New System.Drawing.Point(39, 81)
		Me.chkPageHeader.Name = "chkPageHeader"
		Me.chkPageHeader.Size = New System.Drawing.Size(119, 17)
		Me.chkPageHeader.TabIndex = 396
		Me.chkPageHeader.Text = "Show Page Header"
		Me.chkPageHeader.UseVisualStyleBackColor = False
		'
		'chkUnitWeek
		'
		Me.chkUnitWeek.BackColor = System.Drawing.Color.Transparent
		Me.chkUnitWeek.Location = New System.Drawing.Point(39, 59)
		Me.chkUnitWeek.Name = "chkUnitWeek"
		Me.chkUnitWeek.Size = New System.Drawing.Size(216, 16)
		Me.chkUnitWeek.TabIndex = 395
		Me.chkUnitWeek.Text = "Show Unit Week"
		Me.chkUnitWeek.UseVisualStyleBackColor = False
		'
		'chkSecondOwner
		'
		Me.chkSecondOwner.BackColor = System.Drawing.Color.Transparent
		Me.chkSecondOwner.Location = New System.Drawing.Point(39, 37)
		Me.chkSecondOwner.Name = "chkSecondOwner"
		Me.chkSecondOwner.Size = New System.Drawing.Size(216, 16)
		Me.chkSecondOwner.TabIndex = 394
		Me.chkSecondOwner.Text = "Show 2nd Owner Name"
		Me.chkSecondOwner.UseVisualStyleBackColor = False
		'
		'numOwners
		'
		Me.numOwners.Location = New System.Drawing.Point(388, 88)
		Me.numOwners.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.numOwners.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numOwners.Name = "numOwners"
		Me.numOwners.Size = New System.Drawing.Size(77, 20)
		Me.numOwners.TabIndex = 406
		Me.numOwners.Value = New Decimal(New Integer() {5, 0, 0, 0})
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(263, 90)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(115, 13)
		Me.Label3.TabIndex = 405
		Me.Label3.Text = "Amount of 2nd Owners"
		'
		'numUnitWeek
		'
		Me.numUnitWeek.Location = New System.Drawing.Point(388, 62)
		Me.numUnitWeek.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.numUnitWeek.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numUnitWeek.Name = "numUnitWeek"
		Me.numUnitWeek.Size = New System.Drawing.Size(77, 20)
		Me.numUnitWeek.TabIndex = 404
		Me.numUnitWeek.Value = New Decimal(New Integer() {10, 0, 0, 0})
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(263, 64)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(109, 13)
		Me.Label2.TabIndex = 403
		Me.Label2.Text = "Amount of Unit Week"
		'
		'numTrans
		'
		Me.numTrans.Location = New System.Drawing.Point(388, 36)
		Me.numTrans.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
		Me.numTrans.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numTrans.Name = "numTrans"
		Me.numTrans.Size = New System.Drawing.Size(77, 20)
		Me.numTrans.TabIndex = 402
		Me.numTrans.Value = New Decimal(New Integer() {15, 0, 0, 0})
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(263, 38)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(119, 13)
		Me.Label1.TabIndex = 401
		Me.Label1.Text = "Amount of Transactions"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(940, 492)
		Me.Controls.Add(Me.numOwners)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.numUnitWeek)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.numTrans)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.chkPageHeader)
		Me.Controls.Add(Me.chkUnitWeek)
		Me.Controls.Add(Me.chkSecondOwner)
		Me.Controls.Add(Me.vwrReport)
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(Me.numOwners, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numUnitWeek, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numTrans, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents vwrReport As GrapeCity.ActiveReports.Viewer.Win.Viewer
	Friend WithEvents Button1 As Button
	Friend WithEvents chkPageHeader As CheckBox
	Friend WithEvents chkUnitWeek As CheckBox
	Friend WithEvents chkSecondOwner As CheckBox
	Friend WithEvents numOwners As NumericUpDown
	Friend WithEvents Label3 As Label
	Friend WithEvents numUnitWeek As NumericUpDown
	Friend WithEvents Label2 As Label
	Friend WithEvents numTrans As NumericUpDown
	Friend WithEvents Label1 As Label
End Class
