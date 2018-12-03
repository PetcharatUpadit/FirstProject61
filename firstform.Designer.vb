<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class firstform
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
        Me.lblSale1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSale1 = New System.Windows.Forms.TextBox()
        Me.txtF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblCom = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAll = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSale1
        '
        Me.lblSale1.BackColor = System.Drawing.Color.Red
        Me.lblSale1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSale1.Location = New System.Drawing.Point(52, 55)
        Me.lblSale1.Name = "lblSale1"
        Me.lblSale1.Size = New System.Drawing.Size(210, 34)
        Me.lblSale1.TabIndex = 0
        Me.lblSale1.Text = "ยอดขาย Vistra Gluta "
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ยอดขาย Frista Glota"
        '
        'txtSale1
        '
        Me.txtSale1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSale1.Location = New System.Drawing.Point(299, 55)
        Me.txtSale1.Name = "txtSale1"
        Me.txtSale1.Size = New System.Drawing.Size(247, 29)
        Me.txtSale1.TabIndex = 0
        Me.txtSale1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtF
        '
        Me.txtF.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtF.Location = New System.Drawing.Point(299, 117)
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(247, 29)
        Me.txtF.TabIndex = 1
        Me.txtF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(146, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 34)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ยอดขายรวม"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 34)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ค่าคอมมิชชันรวม"
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(299, 173)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(247, 34)
        Me.lbltotal.TabIndex = 0
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCom
        '
        Me.lblCom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCom.Location = New System.Drawing.Point(299, 233)
        Me.lblCom.Name = "lblCom"
        Me.lblCom.Size = New System.Drawing.Size(247, 34)
        Me.lblCom.TabIndex = 0
        Me.lblCom.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.LawnGreen
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnGo.Location = New System.Drawing.Point(319, 341)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(82, 39)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.LawnGreen
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(434, 341)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(102, 39)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(106, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 34)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ยอดรวมทั้งหมด"
        '
        'lblAll
        '
        Me.lblAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblAll.Location = New System.Drawing.Point(299, 288)
        Me.lblAll.Name = "lblAll"
        Me.lblAll.Size = New System.Drawing.Size(247, 34)
        Me.lblAll.TabIndex = 0
        Me.lblAll.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'firstform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(656, 410)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtF)
        Me.Controls.Add(Me.txtSale1)
        Me.Controls.Add(Me.lblAll)
        Me.Controls.Add(Me.lblCom)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSale1)
        Me.Name = "firstform"
        Me.Text = "firstform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSale1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSale1 As System.Windows.Forms.TextBox
    Friend WithEvents txtF As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents lblCom As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblAll As System.Windows.Forms.Label
End Class
