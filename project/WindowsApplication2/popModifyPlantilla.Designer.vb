﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class popModifyPlantilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(popModifyPlantilla))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbxRoom = New System.Windows.Forms.TextBox()
        Me.txtbxEndTime = New System.Windows.Forms.TextBox()
        Me.txtbxStartTime = New System.Windows.Forms.TextBox()
        Me.txtbxDay = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtbxCourseCode = New System.Windows.Forms.TextBox()
        Me.txtbxSection = New System.Windows.Forms.TextBox()
        Me.txtbxUnit = New System.Windows.Forms.TextBox()
        Me.bttnCourseModify = New System.Windows.Forms.Button()
        Me.bttnCourseBack = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtbxCourseFacID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbxFacName = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(41, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 20)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Course Code:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(89, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Section:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(118, 170)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 20)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Unit:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.txtbxRoom)
        Me.GroupBox1.Controls.Add(Me.txtbxEndTime)
        Me.GroupBox1.Controls.Add(Me.txtbxStartTime)
        Me.GroupBox1.Controls.Add(Me.txtbxDay)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(45, 202)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 116)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Schedule"
        '
        'txtbxRoom
        '
        Me.txtbxRoom.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxRoom.Location = New System.Drawing.Point(363, 29)
        Me.txtbxRoom.Name = "txtbxRoom"
        Me.txtbxRoom.Size = New System.Drawing.Size(94, 26)
        Me.txtbxRoom.TabIndex = 26
        '
        'txtbxEndTime
        '
        Me.txtbxEndTime.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEndTime.Location = New System.Drawing.Point(363, 64)
        Me.txtbxEndTime.MaxLength = 4
        Me.txtbxEndTime.Name = "txtbxEndTime"
        Me.txtbxEndTime.Size = New System.Drawing.Size(94, 26)
        Me.txtbxEndTime.TabIndex = 25
        '
        'txtbxStartTime
        '
        Me.txtbxStartTime.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxStartTime.Location = New System.Drawing.Point(150, 61)
        Me.txtbxStartTime.MaxLength = 4
        Me.txtbxStartTime.Name = "txtbxStartTime"
        Me.txtbxStartTime.Size = New System.Drawing.Size(94, 26)
        Me.txtbxStartTime.TabIndex = 20
        '
        'txtbxDay
        '
        Me.txtbxDay.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDay.Location = New System.Drawing.Point(150, 29)
        Me.txtbxDay.Name = "txtbxDay"
        Me.txtbxDay.Size = New System.Drawing.Size(94, 26)
        Me.txtbxDay.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(96, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 20)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Day:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(259, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 20)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "End Time:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(36, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 20)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Start Time:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(292, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 20)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Room:"
        '
        'txtbxCourseCode
        '
        Me.txtbxCourseCode.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxCourseCode.Location = New System.Drawing.Point(176, 106)
        Me.txtbxCourseCode.MaxLength = 7
        Me.txtbxCourseCode.Name = "txtbxCourseCode"
        Me.txtbxCourseCode.Size = New System.Drawing.Size(350, 26)
        Me.txtbxCourseCode.TabIndex = 22
        '
        'txtbxSection
        '
        Me.txtbxSection.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSection.Location = New System.Drawing.Point(176, 138)
        Me.txtbxSection.Name = "txtbxSection"
        Me.txtbxSection.Size = New System.Drawing.Size(350, 26)
        Me.txtbxSection.TabIndex = 23
        '
        'txtbxUnit
        '
        Me.txtbxUnit.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxUnit.Location = New System.Drawing.Point(176, 170)
        Me.txtbxUnit.MaxLength = 1
        Me.txtbxUnit.Name = "txtbxUnit"
        Me.txtbxUnit.Size = New System.Drawing.Size(350, 26)
        Me.txtbxUnit.TabIndex = 24
        '
        'bttnCourseModify
        '
        Me.bttnCourseModify.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnCourseModify.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCourseModify.Location = New System.Drawing.Point(167, 339)
        Me.bttnCourseModify.Name = "bttnCourseModify"
        Me.bttnCourseModify.Size = New System.Drawing.Size(105, 29)
        Me.bttnCourseModify.TabIndex = 27
        Me.bttnCourseModify.Text = "Modify"
        Me.bttnCourseModify.UseVisualStyleBackColor = False
        '
        'bttnCourseBack
        '
        Me.bttnCourseBack.BackColor = System.Drawing.Color.WhiteSmoke
        Me.bttnCourseBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttnCourseBack.Location = New System.Drawing.Point(308, 339)
        Me.bttnCourseBack.Name = "bttnCourseBack"
        Me.bttnCourseBack.Size = New System.Drawing.Size(105, 29)
        Me.bttnCourseBack.TabIndex = 28
        Me.bttnCourseBack.Text = "Back"
        Me.bttnCourseBack.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(68, 41)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(102, 20)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Faculty ID:"
        '
        'txtbxCourseFacID
        '
        Me.txtbxCourseFacID.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxCourseFacID.Location = New System.Drawing.Point(176, 39)
        Me.txtbxCourseFacID.Name = "txtbxCourseFacID"
        Me.txtbxCourseFacID.Size = New System.Drawing.Size(350, 26)
        Me.txtbxCourseFacID.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 20)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Faculty Name:"
        '
        'txtbxFacName
        '
        Me.txtbxFacName.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxFacName.Location = New System.Drawing.Point(176, 71)
        Me.txtbxFacName.Name = "txtbxFacName"
        Me.txtbxFacName.Size = New System.Drawing.Size(350, 26)
        Me.txtbxFacName.TabIndex = 36
        '
        'popModifyPlantilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(555, 385)
        Me.Controls.Add(Me.txtbxFacName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtbxCourseFacID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtbxUnit)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtbxSection)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtbxCourseCode)
        Me.Controls.Add(Me.bttnCourseModify)
        Me.Controls.Add(Me.bttnCourseBack)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label22)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "popModifyPlantilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modify Plantilla"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbxRoom As TextBox
    Friend WithEvents txtbxEndTime As TextBox
    Friend WithEvents txtbxStartTime As TextBox
    Friend WithEvents txtbxDay As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtbxCourseCode As TextBox
    Friend WithEvents txtbxSection As TextBox
    Friend WithEvents txtbxUnit As TextBox
    Friend WithEvents bttnCourseModify As Button
    Friend WithEvents bttnCourseBack As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents txtbxCourseFacID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbxFacName As TextBox
End Class
