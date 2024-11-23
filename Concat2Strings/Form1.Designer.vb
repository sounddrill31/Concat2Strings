<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Clear = New Button()
        Result = New Button()
        exitBtn = New Button()
        FirstNameBox = New TextBox()
        LastNameBox = New TextBox()
        ResultBox = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(334, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 15)
        Label1.TabIndex = 0
        Label1.Text = "Program to Display Full Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(260, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 15)
        Label2.TabIndex = 1
        Label2.Text = "Enter First Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(260, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 15)
        Label3.TabIndex = 2
        Label3.Text = "Enter Last Name"
        ' 
        ' Clear
        ' 
        Clear.Location = New Point(260, 201)
        Clear.Name = "Clear"
        Clear.Size = New Size(75, 23)
        Clear.TabIndex = 3
        Clear.Text = "Clear"
        Clear.UseVisualStyleBackColor = True
        ' 
        ' Result
        ' 
        Result.Location = New Point(476, 102)
        Result.Name = "Result"
        Result.Size = New Size(75, 72)
        Result.TabIndex = 4
        Result.Text = "Result"
        Result.UseVisualStyleBackColor = True
        ' 
        ' exitBtn
        ' 
        exitBtn.Location = New Point(476, 201)
        exitBtn.Name = "exitBtn"
        exitBtn.Size = New Size(75, 23)
        exitBtn.TabIndex = 5
        exitBtn.Text = "Exit"
        exitBtn.UseVisualStyleBackColor = True
        ' 
        ' FirstNameBox
        ' 
        FirstNameBox.Location = New Point(370, 109)
        FirstNameBox.Name = "FirstNameBox"
        FirstNameBox.Size = New Size(100, 23)
        FirstNameBox.TabIndex = 6
        ' 
        ' LastNameBox
        ' 
        LastNameBox.Location = New Point(370, 146)
        LastNameBox.Name = "LastNameBox"
        LastNameBox.Size = New Size(100, 23)
        LastNameBox.TabIndex = 7
        ' 
        ' ResultBox
        ' 
        ResultBox.Location = New Point(260, 250)
        ResultBox.Name = "ResultBox"
        ResultBox.Size = New Size(291, 23)
        ResultBox.TabIndex = 8
        ResultBox.Text = "Result"
        ResultBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ResultBox)
        Controls.Add(LastNameBox)
        Controls.Add(FirstNameBox)
        Controls.Add(exitBtn)
        Controls.Add(Result)
        Controls.Add(Clear)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Clear As Button
    Friend WithEvents Result As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents FirstNameBox As TextBox
    Friend WithEvents LastNameBox As TextBox
    Friend WithEvents ResultBox As TextBox

End Class
