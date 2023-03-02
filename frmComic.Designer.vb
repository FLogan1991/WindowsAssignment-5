<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComic))
        Me.picSuperhero = New System.Windows.Forms.PictureBox()
        Me.lblComicConvention = New System.Windows.Forms.Label()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.txtGroup = New System.Windows.Forms.TextBox()
        Me.rad_Superhero = New System.Windows.Forms.RadioButton()
        Me.rad_Autographs = New System.Windows.Forms.RadioButton()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.grpBoxRad = New System.Windows.Forms.GroupBox()
        Me.lblRegistration = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        CType(Me.picSuperhero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxRad.SuspendLayout()
        Me.SuspendLayout()
        '
        'picSuperhero
        '
        Me.picSuperhero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picSuperhero.Cursor = System.Windows.Forms.Cursors.Default
        Me.picSuperhero.Image = CType(resources.GetObject("picSuperhero.Image"), System.Drawing.Image)
        Me.picSuperhero.Location = New System.Drawing.Point(0, 2)
        Me.picSuperhero.Name = "picSuperhero"
        Me.picSuperhero.Size = New System.Drawing.Size(559, 183)
        Me.picSuperhero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSuperhero.TabIndex = 0
        Me.picSuperhero.TabStop = False
        '
        'lblComicConvention
        '
        Me.lblComicConvention.AutoSize = True
        Me.lblComicConvention.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComicConvention.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblComicConvention.Location = New System.Drawing.Point(82, 200)
        Me.lblComicConvention.Name = "lblComicConvention"
        Me.lblComicConvention.Size = New System.Drawing.Size(408, 38)
        Me.lblComicConvention.TabIndex = 1
        Me.lblComicConvention.Text = "Comic Convention Registration"
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroup.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblGroup.Location = New System.Drawing.Point(153, 256)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(122, 21)
        Me.lblGroup.TabIndex = 2
        Me.lblGroup.Text = "Group Size:"
        '
        'txtGroup
        '
        Me.txtGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGroup.Font = New System.Drawing.Font("Cooper Black", 14.0!)
        Me.txtGroup.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtGroup.Location = New System.Drawing.Point(313, 252)
        Me.txtGroup.MaxLength = 40
        Me.txtGroup.Multiline = True
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtGroup.Size = New System.Drawing.Size(37, 29)
        Me.txtGroup.TabIndex = 5
        Me.txtGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rad_Superhero
        '
        Me.rad_Superhero.AutoSize = True
        Me.rad_Superhero.Checked = True
        Me.rad_Superhero.Cursor = System.Windows.Forms.Cursors.Default
        Me.rad_Superhero.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.rad_Superhero.ForeColor = System.Drawing.Color.OrangeRed
        Me.rad_Superhero.Location = New System.Drawing.Point(43, 32)
        Me.rad_Superhero.Name = "rad_Superhero"
        Me.rad_Superhero.Size = New System.Drawing.Size(322, 23)
        Me.rad_Superhero.TabIndex = 6
        Me.rad_Superhero.TabStop = True
        Me.rad_Superhero.Text = "Convention + Superhero Experience"
        Me.rad_Superhero.UseVisualStyleBackColor = True
        '
        'rad_Autographs
        '
        Me.rad_Autographs.AutoSize = True
        Me.rad_Autographs.Cursor = System.Windows.Forms.Cursors.Default
        Me.rad_Autographs.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.rad_Autographs.ForeColor = System.Drawing.Color.OrangeRed
        Me.rad_Autographs.Location = New System.Drawing.Point(43, 62)
        Me.rad_Autographs.Name = "rad_Autographs"
        Me.rad_Autographs.Size = New System.Drawing.Size(239, 23)
        Me.rad_Autographs.TabIndex = 7
        Me.rad_Autographs.Text = "Convention + Autographs"
        Me.rad_Autographs.UseVisualStyleBackColor = True
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Cursor = System.Windows.Forms.Cursors.Default
        Me.radConvention.Font = New System.Drawing.Font("Cooper Black", 12.0!)
        Me.radConvention.ForeColor = System.Drawing.Color.OrangeRed
        Me.radConvention.Location = New System.Drawing.Point(43, 93)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(123, 23)
        Me.radConvention.TabIndex = 8
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'grpBoxRad
        '
        Me.grpBoxRad.BackColor = System.Drawing.Color.SkyBlue
        Me.grpBoxRad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grpBoxRad.Controls.Add(Me.radConvention)
        Me.grpBoxRad.Controls.Add(Me.rad_Autographs)
        Me.grpBoxRad.Controls.Add(Me.rad_Superhero)
        Me.grpBoxRad.Cursor = System.Windows.Forms.Cursors.Default
        Me.grpBoxRad.Font = New System.Drawing.Font("Cooper Black", 13.0!)
        Me.grpBoxRad.ForeColor = System.Drawing.Color.OrangeRed
        Me.grpBoxRad.Location = New System.Drawing.Point(96, 291)
        Me.grpBoxRad.Name = "grpBoxRad"
        Me.grpBoxRad.Size = New System.Drawing.Size(383, 130)
        Me.grpBoxRad.TabIndex = 10
        Me.grpBoxRad.TabStop = False
        Me.grpBoxRad.Text = "Select Badge Type:"
        '
        'lblRegistration
        '
        Me.lblRegistration.AutoSize = True
        Me.lblRegistration.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistration.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblRegistration.Location = New System.Drawing.Point(112, 466)
        Me.lblRegistration.Name = "lblRegistration"
        Me.lblRegistration.Size = New System.Drawing.Size(186, 21)
        Me.lblRegistration.TabIndex = 11
        Me.lblRegistration.Text = "Registration Cost:"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnCalculate.ForeColor = System.Drawing.Color.Black
        Me.btnCalculate.Location = New System.Drawing.Point(96, 528)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(140, 35)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(313, 528)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(140, 35)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Cooper Black", 14.0!)
        Me.lblTotal.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblTotal.Location = New System.Drawing.Point(333, 466)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(93, 21)
        Me.lblTotal.TabIndex = 14
        Me.lblTotal.Text = "$0000.00"
        '
        'frmComic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(559, 586)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblRegistration)
        Me.Controls.Add(Me.txtGroup)
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.lblComicConvention)
        Me.Controls.Add(Me.picSuperhero)
        Me.Controls.Add(Me.grpBoxRad)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "frmComic"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comic Convention Registration"
        CType(Me.picSuperhero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxRad.ResumeLayout(False)
        Me.grpBoxRad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSuperhero As PictureBox
    Friend WithEvents lblComicConvention As Label
    Friend WithEvents lblGroup As Label
    Friend WithEvents txtGroup As TextBox
    Friend WithEvents rad_Autographs As RadioButton
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents grpBoxRad As GroupBox
    Friend WithEvents lblRegistration As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents rad_Superhero As RadioButton
End Class
