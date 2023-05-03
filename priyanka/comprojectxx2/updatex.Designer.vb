<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updatex
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PriyankaDatabase2DataSet = New comprojectxx2.priyankaDatabase2DataSet()
        Me.BotnyTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BotnyTable1TableAdapter = New comprojectxx2.priyankaDatabase2DataSetTableAdapters.botnyTable1TableAdapter()
        Me.TableAdapterManager = New comprojectxx2.priyankaDatabase2DataSetTableAdapters.TableAdapterManager()
        Me.BotnyTable1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PriyankaDatabase2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BotnyTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BotnyTable1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(744, 58)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bio Botniacal information about trees"
        '
        'PriyankaDatabase2DataSet
        '
        Me.PriyankaDatabase2DataSet.DataSetName = "priyankaDatabase2DataSet"
        Me.PriyankaDatabase2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BotnyTable1BindingSource
        '
        Me.BotnyTable1BindingSource.DataMember = "botnyTable1"
        Me.BotnyTable1BindingSource.DataSource = Me.PriyankaDatabase2DataSet
        '
        'BotnyTable1TableAdapter
        '
        Me.BotnyTable1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.botnyTable1TableAdapter = Me.BotnyTable1TableAdapter
        Me.TableAdapterManager.UpdateOrder = comprojectxx2.priyankaDatabase2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BotnyTable1DataGridView
        '
        Me.BotnyTable1DataGridView.AutoGenerateColumns = False
        Me.BotnyTable1DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BotnyTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BotnyTable1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.BotnyTable1DataGridView.DataSource = Me.BotnyTable1BindingSource
        Me.BotnyTable1DataGridView.Location = New System.Drawing.Point(66, 130)
        Me.BotnyTable1DataGridView.Name = "BotnyTable1DataGridView"
        Me.BotnyTable1DataGridView.Size = New System.Drawing.Size(707, 593)
        Me.BotnyTable1DataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "treename"
        Me.DataGridViewTextBoxColumn2.HeaderText = "treename"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "foundon"
        Me.DataGridViewTextBoxColumn3.HeaderText = "foundon"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "usedfor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "usedfor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "needwheather"
        Me.DataGridViewTextBoxColumn5.HeaderText = "needwheather"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fruitflowergive"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fruitflowergive"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "species"
        Me.DataGridViewTextBoxColumn7.HeaderText = "species"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "about"
        Me.DataGridViewTextBoxColumn8.HeaderText = "about"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button1.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(908, 549)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add The Tree"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button2.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1071, 549)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 31)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Update tree Info."
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button3.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1216, 549)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 31)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Delete the Tree Info."
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button4.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1071, 637)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(126, 31)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Save all entries"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BotnyTable1BindingSource, "ID", True))
        Me.TextBox1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1002, 130)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(229, 26)
        Me.TextBox1.TabIndex = 8
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BotnyTable1BindingSource, "treename", True))
        Me.TextBox2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(1002, 160)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(229, 26)
        Me.TextBox2.TabIndex = 9
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BotnyTable1BindingSource, "foundon", True))
        Me.TextBox3.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(1002, 190)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(229, 26)
        Me.TextBox3.TabIndex = 10
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BotnyTable1BindingSource, "usedfor", True))
        Me.TextBox4.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(1002, 226)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(229, 26)
        Me.TextBox4.TabIndex = 11
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BotnyTable1BindingSource, "fruitflowergive", True))
        Me.TextBox5.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(1002, 263)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(229, 26)
        Me.TextBox5.TabIndex = 12
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BotnyTable1BindingSource, "species", True))
        Me.TextBox6.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(1002, 307)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(229, 26)
        Me.TextBox6.TabIndex = 13
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BotnyTable1BindingSource, "needwheather", True))
        Me.TextBox7.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(1002, 351)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(349, 26)
        Me.TextBox7.TabIndex = 14
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BotnyTable1BindingSource, "about", True))
        Me.TextBox8.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(1002, 397)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox8.Size = New System.Drawing.Size(349, 134)
        Me.TextBox8.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(843, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(841, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Tree Name "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(841, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Location"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(843, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Uses"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(843, 351)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Wheather condition"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(843, 270)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Fruit / Flower"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(843, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Species"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(843, 392)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 20)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "About"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LemonChiffon
        Me.Button5.Font = New System.Drawing.Font("Lucida Calligraphy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(1191, 35)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(151, 54)
        Me.Button5.TabIndex = 24
        Me.Button5.Text = "Log Out"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button6.Font = New System.Drawing.Font("Lucida Handwriting", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(1216, 637)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(126, 31)
        Me.Button6.TabIndex = 25
        Me.Button6.Text = "Clear"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1085, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 25)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "About"
        '
        'update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.comprojectxx2.My.Resources.Resources.mainbackground1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1363, 749)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BotnyTable1DataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Name = "update"
        Me.Text = "update"
        CType(Me.PriyankaDatabase2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BotnyTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BotnyTable1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PriyankaDatabase2DataSet As priyankaDatabase2DataSet
    Friend WithEvents BotnyTable1BindingSource As BindingSource
    Friend WithEvents BotnyTable1TableAdapter As priyankaDatabase2DataSetTableAdapters.botnyTable1TableAdapter
    Friend WithEvents TableAdapterManager As priyankaDatabase2DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BotnyTable1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label10 As Label
End Class
