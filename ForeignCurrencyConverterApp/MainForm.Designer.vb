<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.singaporeCurrencyTextBox = New System.Windows.Forms.TextBox()
        Me.convertButton = New System.Windows.Forms.Button()
        Me.targetCurrencyComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.targetForeignCurrencyLabel = New System.Windows.Forms.Label()
        Me.convertedForeignCurrencyValueTextBox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(120, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(579, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Foreign Currency Converter By Terence Lee"
        '
        'singaporeCurrencyTextBox
        '
        Me.singaporeCurrencyTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.singaporeCurrencyTextBox.Location = New System.Drawing.Point(74, 201)
        Me.singaporeCurrencyTextBox.Name = "singaporeCurrencyTextBox"
        Me.singaporeCurrencyTextBox.Size = New System.Drawing.Size(201, 39)
        Me.singaporeCurrencyTextBox.TabIndex = 2
        Me.singaporeCurrencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'convertButton
        '
        Me.convertButton.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.convertButton.Location = New System.Drawing.Point(343, 248)
        Me.convertButton.Name = "convertButton"
        Me.convertButton.Size = New System.Drawing.Size(131, 42)
        Me.convertButton.TabIndex = 3
        Me.convertButton.Text = "Convert"
        Me.convertButton.UseVisualStyleBackColor = True
        '
        'targetCurrencyComboBox
        '
        Me.targetCurrencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.targetCurrencyComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.targetCurrencyComboBox.Location = New System.Drawing.Point(301, 116)
        Me.targetCurrencyComboBox.Name = "targetCurrencyComboBox"
        Me.targetCurrencyComboBox.Size = New System.Drawing.Size(182, 36)
        Me.targetCurrencyComboBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(261, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 28)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select your target currency"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(64, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Enter amount in SGD"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ForeignCurrencyConverterApp.My.Resources.Resources.right_arrow
        Me.PictureBox1.Location = New System.Drawing.Point(301, 189)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(207, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'targetForeignCurrencyLabel
        '
        Me.targetForeignCurrencyLabel.AutoSize = True
        Me.targetForeignCurrencyLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.targetForeignCurrencyLabel.Location = New System.Drawing.Point(526, 170)
        Me.targetForeignCurrencyLabel.Name = "targetForeignCurrencyLabel"
        Me.targetForeignCurrencyLabel.Size = New System.Drawing.Size(262, 28)
        Me.targetForeignCurrencyLabel.TabIndex = 8
        Me.targetForeignCurrencyLabel.Text = "Converted amount in AUD"
        '
        'convertedForeignCurrencyValueTextBox
        '
        Me.convertedForeignCurrencyValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.convertedForeignCurrencyValueTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.convertedForeignCurrencyValueTextBox.Location = New System.Drawing.Point(560, 201)
        Me.convertedForeignCurrencyValueTextBox.Name = "convertedForeignCurrencyValueTextBox"
        Me.convertedForeignCurrencyValueTextBox.ReadOnly = True
        Me.convertedForeignCurrencyValueTextBox.Size = New System.Drawing.Size(201, 39)
        Me.convertedForeignCurrencyValueTextBox.TabIndex = 9
        Me.convertedForeignCurrencyValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 322)
        Me.Controls.Add(Me.convertedForeignCurrencyValueTextBox)
        Me.Controls.Add(Me.targetForeignCurrencyLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.targetCurrencyComboBox)
        Me.Controls.Add(Me.convertButton)
        Me.Controls.Add(Me.singaporeCurrencyTextBox)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Foreign Currency Converter By Terence Lee"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents singaporeCurrencyTextBox As TextBox
    Friend WithEvents convertButton As Button
    Private WithEvents targetCurrencyComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents targetForeignCurrencyLabel As Label
    Friend WithEvents convertedForeignCurrencyValueTextBox As TextBox
End Class
