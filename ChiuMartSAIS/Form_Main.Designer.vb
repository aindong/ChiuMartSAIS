<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnClient = New System.Windows.Forms.Button()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.btnOR = New System.Windows.Forms.Button()
        Me.btnUnits = New System.Windows.Forms.Button()
        Me.btnProductCategory = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1255, 91)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1255, 91)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chiumart Sales And Inventory System"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 730)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1255, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnUsers)
        Me.Panel2.Controls.Add(Me.btnClient)
        Me.Panel2.Controls.Add(Me.btnSupplier)
        Me.Panel2.Controls.Add(Me.btnOR)
        Me.Panel2.Controls.Add(Me.btnUnits)
        Me.Panel2.Controls.Add(Me.btnProductCategory)
        Me.Panel2.Controls.Add(Me.btnProduct)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(36, 122)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(356, 375)
        Me.Panel2.TabIndex = 2
        '
        'btnClient
        '
        Me.btnClient.Location = New System.Drawing.Point(12, 234)
        Me.btnClient.Name = "btnClient"
        Me.btnClient.Size = New System.Drawing.Size(159, 61)
        Me.btnClient.TabIndex = 4
        Me.btnClient.Text = "Client"
        Me.btnClient.UseVisualStyleBackColor = True
        '
        'btnSupplier
        '
        Me.btnSupplier.Location = New System.Drawing.Point(12, 170)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(331, 61)
        Me.btnSupplier.TabIndex = 3
        Me.btnSupplier.Text = "Supplier"
        Me.btnSupplier.UseVisualStyleBackColor = True
        '
        'btnOR
        '
        Me.btnOR.Location = New System.Drawing.Point(177, 300)
        Me.btnOR.Name = "btnOR"
        Me.btnOR.Size = New System.Drawing.Size(165, 61)
        Me.btnOR.TabIndex = 6
        Me.btnOR.Text = "Official Receipt"
        Me.btnOR.UseVisualStyleBackColor = True
        '
        'btnUnits
        '
        Me.btnUnits.Location = New System.Drawing.Point(12, 300)
        Me.btnUnits.Name = "btnUnits"
        Me.btnUnits.Size = New System.Drawing.Size(159, 61)
        Me.btnUnits.TabIndex = 5
        Me.btnUnits.Text = "Units"
        Me.btnUnits.UseVisualStyleBackColor = True
        '
        'btnProductCategory
        '
        Me.btnProductCategory.Location = New System.Drawing.Point(12, 41)
        Me.btnProductCategory.Name = "btnProductCategory"
        Me.btnProductCategory.Size = New System.Drawing.Size(331, 61)
        Me.btnProductCategory.TabIndex = 1
        Me.btnProductCategory.Text = "Category"
        Me.btnProductCategory.UseVisualStyleBackColor = True
        '
        'btnProduct
        '
        Me.btnProduct.Location = New System.Drawing.Point(11, 106)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(331, 61)
        Me.btnProduct.TabIndex = 2
        Me.btnProduct.Text = "Product"
        Me.btnProduct.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkOrange
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(354, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "File Maintenance"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button8)
        Me.Panel3.Controls.Add(Me.Button11)
        Me.Panel3.Controls.Add(Me.Button12)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(432, 123)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(356, 375)
        Me.Panel3.TabIndex = 3
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(12, 170)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(331, 61)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "Stock Adjustment"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(12, 41)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(331, 61)
        Me.Button11.TabIndex = 1
        Me.Button11.Text = "Point of Sale"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(11, 106)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(331, 61)
        Me.Button12.TabIndex = 2
        Me.Button12.Text = "Purchase Order"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Crimson
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(354, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Transactions"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Button13)
        Me.Panel4.Controls.Add(Me.Button7)
        Me.Panel4.Controls.Add(Me.Button9)
        Me.Panel4.Controls.Add(Me.Button10)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(825, 124)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(356, 375)
        Me.Panel4.TabIndex = 4
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 104)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(163, 61)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "Supplier List"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(12, 41)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(163, 61)
        Me.Button9.TabIndex = 1
        Me.Button9.Text = "Product List"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(181, 41)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(162, 61)
        Me.Button10.TabIndex = 2
        Me.Button10.Text = "Client List"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.Label4.Size = New System.Drawing.Size(354, 28)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Reports"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(180, 104)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(163, 61)
        Me.Button13.TabIndex = 4
        Me.Button13.Text = "Sales Report"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.Location = New System.Drawing.Point(177, 236)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(166, 61)
        Me.btnUsers.TabIndex = 7
        Me.btnUsers.Text = "Users"
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'Form_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1255, 752)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnProductCategory As System.Windows.Forms.Button
    Friend WithEvents btnProduct As System.Windows.Forms.Button
    Friend WithEvents btnUnits As System.Windows.Forms.Button
    Friend WithEvents btnOR As System.Windows.Forms.Button
    Friend WithEvents btnSupplier As System.Windows.Forms.Button
    Friend WithEvents btnClient As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button

End Class
