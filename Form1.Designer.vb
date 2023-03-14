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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Picbox = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.gropbx = New System.Windows.Forms.GroupBox()
        Me.radMeter = New System.Windows.Forms.RadioButton()
        Me.radInch = New System.Windows.Forms.RadioButton()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        CType(Me.Picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gropbx.SuspendLayout()
        Me.SuspendLayout()
        '
        'Picbox
        '
        Me.Picbox.BackgroundImage = CType(resources.GetObject("Picbox.BackgroundImage"), System.Drawing.Image)
        Me.Picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Picbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picbox.Location = New System.Drawing.Point(36, 28)
        Me.Picbox.Name = "Picbox"
        Me.Picbox.Size = New System.Drawing.Size(303, 213)
        Me.Picbox.TabIndex = 0
        Me.Picbox.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Notram", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(449, 28)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(216, 32)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Converter App"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(410, 70)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(162, 48)
        Me.lbl2.TabIndex = 2
        Me.lbl2.Text = "Enter a value and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "choose conversion"
        '
        'txtValue
        '
        Me.txtValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtValue.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txtValue.Location = New System.Drawing.Point(611, 70)
        Me.txtValue.Multiline = True
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(105, 48)
        Me.txtValue.TabIndex = 3
        '
        'gropbx
        '
        Me.gropbx.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gropbx.Controls.Add(Me.radMeter)
        Me.gropbx.Controls.Add(Me.radInch)
        Me.gropbx.Font = New System.Drawing.Font("Notram", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gropbx.Location = New System.Drawing.Point(414, 136)
        Me.gropbx.Name = "gropbx"
        Me.gropbx.Size = New System.Drawing.Size(302, 156)
        Me.gropbx.TabIndex = 4
        Me.gropbx.TabStop = False
        Me.gropbx.Text = "Convert Measurement"
        '
        'radMeter
        '
        Me.radMeter.AutoSize = True
        Me.radMeter.Location = New System.Drawing.Point(42, 96)
        Me.radMeter.Name = "radMeter"
        Me.radMeter.Size = New System.Drawing.Size(186, 27)
        Me.radMeter.TabIndex = 1
        Me.radMeter.TabStop = True
        Me.radMeter.Text = "Meters to Inches"
        Me.radMeter.UseVisualStyleBackColor = True
        '
        'radInch
        '
        Me.radInch.AutoSize = True
        Me.radInch.Location = New System.Drawing.Point(42, 42)
        Me.radInch.Name = "radInch"
        Me.radInch.Size = New System.Drawing.Size(186, 27)
        Me.radInch.TabIndex = 0
        Me.radInch.TabStop = True
        Me.radInch.Text = "Inches to Meters"
        Me.radInch.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnConvert.Font = New System.Drawing.Font("Notram", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(77, 370)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(162, 57)
        Me.btnConvert.TabIndex = 5
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Notram", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(314, 369)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(162, 59)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Notram", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(554, 370)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(162, 55)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(408, 307)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 32)
        Me.lblResult.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.gropbx)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.Picbox)
        Me.Name = "Form1"
        Me.Text = "Building Plans Conversion"
        CType(Me.Picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gropbx.ResumeLayout(False)
        Me.gropbx.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Picbox As PictureBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents gropbx As GroupBox
    Friend WithEvents radMeter As RadioButton
    Friend WithEvents radInch As RadioButton
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResult As Label
End Class
