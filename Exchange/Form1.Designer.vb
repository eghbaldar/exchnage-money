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
        Me.btn = New System.Windows.Forms.Button()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtArz = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDolar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.L_Kol = New System.Windows.Forms.Label()
        Me.L_10 = New System.Windows.Forms.Label()
        Me.L_Static = New System.Windows.Forms.Label()
        Me.L_Result = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.L_Final = New System.Windows.Forms.Label()
        Me._add = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(157, 20)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(75, 75)
        Me.btn.TabIndex = 0
        Me.btn.Text = "Result"
        Me.btn.UseVisualStyleBackColor = True
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(51, 20)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(100, 21)
        Me.txtValue.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "مقدار:"
        '
        'txtArz
        '
        Me.txtArz.Location = New System.Drawing.Point(51, 47)
        Me.txtArz.Name = "txtArz"
        Me.txtArz.Size = New System.Drawing.Size(100, 21)
        Me.txtArz.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ارز:"
        '
        'txtDolar
        '
        Me.txtDolar.Location = New System.Drawing.Point(51, 74)
        Me.txtDolar.Name = "txtDolar"
        Me.txtDolar.Size = New System.Drawing.Size(78, 21)
        Me.txtDolar.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "دلار:"
        '
        'L_Kol
        '
        Me.L_Kol.AutoSize = True
        Me.L_Kol.Location = New System.Drawing.Point(304, 24)
        Me.L_Kol.Name = "L_Kol"
        Me.L_Kol.Size = New System.Drawing.Size(0, 13)
        Me.L_Kol.TabIndex = 7
        '
        'L_10
        '
        Me.L_10.AutoSize = True
        Me.L_10.Location = New System.Drawing.Point(304, 51)
        Me.L_10.Name = "L_10"
        Me.L_10.Size = New System.Drawing.Size(0, 13)
        Me.L_10.TabIndex = 8
        '
        'L_Static
        '
        Me.L_Static.AutoSize = True
        Me.L_Static.Location = New System.Drawing.Point(304, 78)
        Me.L_Static.Name = "L_Static"
        Me.L_Static.Size = New System.Drawing.Size(0, 13)
        Me.L_Static.TabIndex = 9
        '
        'L_Result
        '
        Me.L_Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Result.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Result.ForeColor = System.Drawing.Color.Red
        Me.L_Result.Location = New System.Drawing.Point(373, 21)
        Me.L_Result.Name = "L_Result"
        Me.L_Result.Size = New System.Drawing.Size(123, 72)
        Me.L_Result.TabIndex = 10
        Me.L_Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(239, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "کل:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(238, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "10%:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(239, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "3 دلار:"
        '
        'L_Final
        '
        Me.L_Final.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L_Final.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Final.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.L_Final.Location = New System.Drawing.Point(515, 21)
        Me.L_Final.Name = "L_Final"
        Me.L_Final.Size = New System.Drawing.Size(123, 72)
        Me.L_Final.TabIndex = 14
        Me.L_Final.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_add
        '
        Me._add.Location = New System.Drawing.Point(133, 74)
        Me._add.Name = "_add"
        Me._add.Size = New System.Drawing.Size(18, 21)
        Me._add.TabIndex = 15
        Me._add.Text = "3"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 111)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(679, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(336, 17)
        Me.ToolStripStatusLabel1.Text = "فرمول: (مقدار*ارز) + 10% (مقدار * ارز) + (عدد ثابت کارمزد*دلار)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 133)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me._add)
        Me.Controls.Add(Me.L_Final)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.L_Result)
        Me.Controls.Add(Me.L_Static)
        Me.Controls.Add(Me.L_10)
        Me.Controls.Add(Me.L_Kol)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDolar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtArz)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.btn)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Echange . . ."
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn As System.Windows.Forms.Button
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtArz As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDolar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents L_Kol As System.Windows.Forms.Label
    Friend WithEvents L_10 As System.Windows.Forms.Label
    Friend WithEvents L_Static As System.Windows.Forms.Label
    Friend WithEvents L_Result As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents L_Final As System.Windows.Forms.Label
    Friend WithEvents _add As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel

End Class
