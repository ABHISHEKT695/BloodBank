<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BloodBank
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BloodBank))
        Dim PidLabel As System.Windows.Forms.Label
        Dim PnameLabel As System.Windows.Forms.Label
        Dim PAgeLabel As System.Windows.Forms.Label
        Dim PBloodGroupLabel As System.Windows.Forms.Label
        Dim PDiseaseLabel As System.Windows.Forms.Label
        Dim PNumLabel As System.Windows.Forms.Label
        Dim PAddrLabel As System.Windows.Forms.Label
        Dim DidLabel As System.Windows.Forms.Label
        Dim PidLabel1 As System.Windows.Forms.Label
        Dim DnameLabel As System.Windows.Forms.Label
        Dim DAgeLabel As System.Windows.Forms.Label
        Dim DBloodGroupLabel As System.Windows.Forms.Label
        Dim DNumLabel As System.Windows.Forms.Label
        Dim DAddrLabel As System.Windows.Forms.Label
        Dim BidLabel As System.Windows.Forms.Label
        Dim BloodGroupsLabel As System.Windows.Forms.Label
        Dim DocNameLabel As System.Windows.Forms.Label
        Dim DocNumLabel As System.Windows.Forms.Label
        Dim DocEmailLabel As System.Windows.Forms.Label
        Dim BnameLabel As System.Windows.Forms.Label
        Dim BAddrLabel As System.Windows.Forms.Label
        Dim BemailLabel As System.Windows.Forms.Label
        Dim BnumLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Database1DataSet = New BloodBank.Database1DataSet()
        Me.PATIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PATIENTTableAdapter = New BloodBank.Database1DataSetTableAdapters.PATIENTTableAdapter()
        Me.TableAdapterManager = New BloodBank.Database1DataSetTableAdapters.TableAdapterManager()
        Me.PATIENTBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PATIENTBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PidTextBox = New System.Windows.Forms.TextBox()
        Me.PnameTextBox = New System.Windows.Forms.TextBox()
        Me.PAgeTextBox = New System.Windows.Forms.TextBox()
        Me.PBloodGroupTextBox = New System.Windows.Forms.TextBox()
        Me.PDiseaseTextBox = New System.Windows.Forms.TextBox()
        Me.PNumTextBox = New System.Windows.Forms.TextBox()
        Me.PAddrTextBox = New System.Windows.Forms.TextBox()
        Me.DONORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DONORTableAdapter = New BloodBank.Database1DataSetTableAdapters.DONORTableAdapter()
        Me.DidTextBox = New System.Windows.Forms.TextBox()
        Me.PidTextBox1 = New System.Windows.Forms.TextBox()
        Me.DnameTextBox = New System.Windows.Forms.TextBox()
        Me.DAgeTextBox = New System.Windows.Forms.TextBox()
        Me.DBloodGroupTextBox = New System.Windows.Forms.TextBox()
        Me.DNumTextBox = New System.Windows.Forms.TextBox()
        Me.DAddrTextBox = New System.Windows.Forms.TextBox()
        Me.BloodGroupsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloodGroupsTableAdapter = New BloodBank.Database1DataSetTableAdapters.BloodGroupsTableAdapter()
        Me.BidTextBox = New System.Windows.Forms.TextBox()
        Me.BloodGroupsTextBox = New System.Windows.Forms.TextBox()
        Me.DOCTORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DOCTORTableAdapter = New BloodBank.Database1DataSetTableAdapters.DOCTORTableAdapter()
        Me.DocNameTextBox = New System.Windows.Forms.TextBox()
        Me.DocNumTextBox = New System.Windows.Forms.TextBox()
        Me.DocEmailTextBox = New System.Windows.Forms.TextBox()
        Me.BloodBankDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BloodBankDataTableAdapter = New BloodBank.Database1DataSetTableAdapters.BloodBankDataTableAdapter()
        Me.BnameTextBox = New System.Windows.Forms.TextBox()
        Me.BAddrTextBox = New System.Windows.Forms.TextBox()
        Me.BemailTextBox = New System.Windows.Forms.TextBox()
        Me.BnumTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.PATIENTDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        PidLabel = New System.Windows.Forms.Label()
        PnameLabel = New System.Windows.Forms.Label()
        PAgeLabel = New System.Windows.Forms.Label()
        PBloodGroupLabel = New System.Windows.Forms.Label()
        PDiseaseLabel = New System.Windows.Forms.Label()
        PNumLabel = New System.Windows.Forms.Label()
        PAddrLabel = New System.Windows.Forms.Label()
        DidLabel = New System.Windows.Forms.Label()
        PidLabel1 = New System.Windows.Forms.Label()
        DnameLabel = New System.Windows.Forms.Label()
        DAgeLabel = New System.Windows.Forms.Label()
        DBloodGroupLabel = New System.Windows.Forms.Label()
        DNumLabel = New System.Windows.Forms.Label()
        DAddrLabel = New System.Windows.Forms.Label()
        BidLabel = New System.Windows.Forms.Label()
        BloodGroupsLabel = New System.Windows.Forms.Label()
        DocNameLabel = New System.Windows.Forms.Label()
        DocNumLabel = New System.Windows.Forms.Label()
        DocEmailLabel = New System.Windows.Forms.Label()
        BnameLabel = New System.Windows.Forms.Label()
        BAddrLabel = New System.Windows.Forms.Label()
        BemailLabel = New System.Windows.Forms.Label()
        BnumLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PATIENTBindingNavigator.SuspendLayout()
        CType(Me.DONORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodGroupsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DOCTORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BloodBankDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.PATIENTDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(970, 57)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox2.Location = New System.Drawing.Point(24, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(96, 377)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.TabControl1)
        Me.GroupBox3.Location = New System.Drawing.Point(126, 75)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(868, 377)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Records"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(18, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(833, 331)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(PidLabel)
        Me.TabPage1.Controls.Add(Me.PidTextBox)
        Me.TabPage1.Controls.Add(PnameLabel)
        Me.TabPage1.Controls.Add(Me.PnameTextBox)
        Me.TabPage1.Controls.Add(PAgeLabel)
        Me.TabPage1.Controls.Add(Me.PAgeTextBox)
        Me.TabPage1.Controls.Add(PBloodGroupLabel)
        Me.TabPage1.Controls.Add(Me.PBloodGroupTextBox)
        Me.TabPage1.Controls.Add(PDiseaseLabel)
        Me.TabPage1.Controls.Add(Me.PDiseaseTextBox)
        Me.TabPage1.Controls.Add(PNumLabel)
        Me.TabPage1.Controls.Add(Me.PNumTextBox)
        Me.TabPage1.Controls.Add(PAddrLabel)
        Me.TabPage1.Controls.Add(Me.PAddrTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(825, 305)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Patients"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(DidLabel)
        Me.TabPage2.Controls.Add(Me.DidTextBox)
        Me.TabPage2.Controls.Add(PidLabel1)
        Me.TabPage2.Controls.Add(Me.PidTextBox1)
        Me.TabPage2.Controls.Add(DnameLabel)
        Me.TabPage2.Controls.Add(Me.DnameTextBox)
        Me.TabPage2.Controls.Add(DAgeLabel)
        Me.TabPage2.Controls.Add(Me.DAgeTextBox)
        Me.TabPage2.Controls.Add(DBloodGroupLabel)
        Me.TabPage2.Controls.Add(Me.DBloodGroupTextBox)
        Me.TabPage2.Controls.Add(DNumLabel)
        Me.TabPage2.Controls.Add(Me.DNumTextBox)
        Me.TabPage2.Controls.Add(DAddrLabel)
        Me.TabPage2.Controls.Add(Me.DAddrTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(825, 305)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Donor"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.IndianRed
        Me.TabPage3.Controls.Add(BidLabel)
        Me.TabPage3.Controls.Add(Me.BidTextBox)
        Me.TabPage3.Controls.Add(BloodGroupsLabel)
        Me.TabPage3.Controls.Add(Me.BloodGroupsTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(825, 305)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "BloodGroup"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.Silver
        Me.TabPage4.Controls.Add(DocNameLabel)
        Me.TabPage4.Controls.Add(Me.DocNameTextBox)
        Me.TabPage4.Controls.Add(DocNumLabel)
        Me.TabPage4.Controls.Add(Me.DocNumTextBox)
        Me.TabPage4.Controls.Add(DocEmailLabel)
        Me.TabPage4.Controls.Add(Me.DocEmailTextBox)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(825, 305)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Doctor"
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.Silver
        Me.TabPage5.Controls.Add(BnameLabel)
        Me.TabPage5.Controls.Add(Me.BnameTextBox)
        Me.TabPage5.Controls.Add(BAddrLabel)
        Me.TabPage5.Controls.Add(Me.BAddrTextBox)
        Me.TabPage5.Controls.Add(BemailLabel)
        Me.TabPage5.Controls.Add(Me.BemailTextBox)
        Me.TabPage5.Controls.Add(BnumLabel)
        Me.TabPage5.Controls.Add(Me.BnumTextBox)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(825, 305)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "BankData"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.GrayText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(24, 460)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(969, 76)
        Me.Panel1.TabIndex = 3
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PATIENTBindingSource
        '
        Me.PATIENTBindingSource.DataMember = "PATIENT"
        Me.PATIENTBindingSource.DataSource = Me.Database1DataSet
        '
        'PATIENTTableAdapter
        '
        Me.PATIENTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BloodBankDataTableAdapter = Me.BloodBankDataTableAdapter
        Me.TableAdapterManager.BloodGroupsTableAdapter = Me.BloodGroupsTableAdapter
        Me.TableAdapterManager.DOCTORTableAdapter = Me.DOCTORTableAdapter
        Me.TableAdapterManager.DONORTableAdapter = Me.DONORTableAdapter
        Me.TableAdapterManager.PATIENTTableAdapter = Me.PATIENTTableAdapter
        Me.TableAdapterManager.UpdateOrder = BloodBank.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PATIENTBindingNavigator
        '
        Me.PATIENTBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PATIENTBindingNavigator.BindingSource = Me.PATIENTBindingSource
        Me.PATIENTBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PATIENTBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PATIENTBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PATIENTBindingNavigatorSaveItem})
        Me.PATIENTBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PATIENTBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PATIENTBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PATIENTBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PATIENTBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PATIENTBindingNavigator.Name = "PATIENTBindingNavigator"
        Me.PATIENTBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PATIENTBindingNavigator.Size = New System.Drawing.Size(1083, 25)
        Me.PATIENTBindingNavigator.TabIndex = 4
        Me.PATIENTBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PATIENTBindingNavigatorSaveItem
        '
        Me.PATIENTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PATIENTBindingNavigatorSaveItem.Image = CType(resources.GetObject("PATIENTBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PATIENTBindingNavigatorSaveItem.Name = "PATIENTBindingNavigatorSaveItem"
        Me.PATIENTBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PATIENTBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PidLabel
        '
        PidLabel.AutoSize = True
        PidLabel.Location = New System.Drawing.Point(24, 32)
        PidLabel.Name = "PidLabel"
        PidLabel.Size = New System.Drawing.Size(25, 13)
        PidLabel.TabIndex = 0
        PidLabel.Text = "Pid:"
        '
        'PidTextBox
        '
        Me.PidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "Pid", True))
        Me.PidTextBox.Location = New System.Drawing.Point(106, 29)
        Me.PidTextBox.Name = "PidTextBox"
        Me.PidTextBox.Size = New System.Drawing.Size(48, 20)
        Me.PidTextBox.TabIndex = 1
        '
        'PnameLabel
        '
        PnameLabel.AutoSize = True
        PnameLabel.Location = New System.Drawing.Point(271, 36)
        PnameLabel.Name = "PnameLabel"
        PnameLabel.Size = New System.Drawing.Size(43, 13)
        PnameLabel.TabIndex = 2
        PnameLabel.Text = "Pname:"
        '
        'PnameTextBox
        '
        Me.PnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "Pname", True))
        Me.PnameTextBox.Location = New System.Drawing.Point(353, 33)
        Me.PnameTextBox.Name = "PnameTextBox"
        Me.PnameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PnameTextBox.TabIndex = 3
        '
        'PAgeLabel
        '
        PAgeLabel.AutoSize = True
        PAgeLabel.Location = New System.Drawing.Point(271, 73)
        PAgeLabel.Name = "PAgeLabel"
        PAgeLabel.Size = New System.Drawing.Size(36, 13)
        PAgeLabel.TabIndex = 4
        PAgeLabel.Text = "PAge:"
        '
        'PAgeTextBox
        '
        Me.PAgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "PAge", True))
        Me.PAgeTextBox.Location = New System.Drawing.Point(353, 70)
        Me.PAgeTextBox.Name = "PAgeTextBox"
        Me.PAgeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PAgeTextBox.TabIndex = 5
        '
        'PBloodGroupLabel
        '
        PBloodGroupLabel.AutoSize = True
        PBloodGroupLabel.Location = New System.Drawing.Point(24, 77)
        PBloodGroupLabel.Name = "PBloodGroupLabel"
        PBloodGroupLabel.Size = New System.Drawing.Size(76, 13)
        PBloodGroupLabel.TabIndex = 6
        PBloodGroupLabel.Text = "PBlood Group:"
        '
        'PBloodGroupTextBox
        '
        Me.PBloodGroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "PBloodGroup", True))
        Me.PBloodGroupTextBox.Location = New System.Drawing.Point(101, 74)
        Me.PBloodGroupTextBox.Name = "PBloodGroupTextBox"
        Me.PBloodGroupTextBox.Size = New System.Drawing.Size(53, 20)
        Me.PBloodGroupTextBox.TabIndex = 7
        '
        'PDiseaseLabel
        '
        PDiseaseLabel.AutoSize = True
        PDiseaseLabel.Location = New System.Drawing.Point(271, 115)
        PDiseaseLabel.Name = "PDiseaseLabel"
        PDiseaseLabel.Size = New System.Drawing.Size(55, 13)
        PDiseaseLabel.TabIndex = 8
        PDiseaseLabel.Text = "PDisease:"
        '
        'PDiseaseTextBox
        '
        Me.PDiseaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "PDisease", True))
        Me.PDiseaseTextBox.Location = New System.Drawing.Point(353, 112)
        Me.PDiseaseTextBox.Name = "PDiseaseTextBox"
        Me.PDiseaseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PDiseaseTextBox.TabIndex = 9
        '
        'PNumLabel
        '
        PNumLabel.AutoSize = True
        PNumLabel.Location = New System.Drawing.Point(271, 161)
        PNumLabel.Name = "PNumLabel"
        PNumLabel.Size = New System.Drawing.Size(39, 13)
        PNumLabel.TabIndex = 10
        PNumLabel.Text = "PNum:"
        '
        'PNumTextBox
        '
        Me.PNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "PNum", True))
        Me.PNumTextBox.Location = New System.Drawing.Point(353, 158)
        Me.PNumTextBox.Name = "PNumTextBox"
        Me.PNumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PNumTextBox.TabIndex = 11
        '
        'PAddrLabel
        '
        PAddrLabel.AutoSize = True
        PAddrLabel.Location = New System.Drawing.Point(271, 204)
        PAddrLabel.Name = "PAddrLabel"
        PAddrLabel.Size = New System.Drawing.Size(39, 13)
        PAddrLabel.TabIndex = 12
        PAddrLabel.Text = "PAddr:"
        '
        'PAddrTextBox
        '
        Me.PAddrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PATIENTBindingSource, "PAddr", True))
        Me.PAddrTextBox.Location = New System.Drawing.Point(353, 201)
        Me.PAddrTextBox.Name = "PAddrTextBox"
        Me.PAddrTextBox.Size = New System.Drawing.Size(407, 20)
        Me.PAddrTextBox.TabIndex = 13
        '
        'DONORBindingSource
        '
        Me.DONORBindingSource.DataMember = "DONOR"
        Me.DONORBindingSource.DataSource = Me.Database1DataSet
        '
        'DONORTableAdapter
        '
        Me.DONORTableAdapter.ClearBeforeFill = True
        '
        'DidLabel
        '
        DidLabel.AutoSize = True
        DidLabel.Location = New System.Drawing.Point(19, 26)
        DidLabel.Name = "DidLabel"
        DidLabel.Size = New System.Drawing.Size(26, 13)
        DidLabel.TabIndex = 0
        DidLabel.Text = "Did:"
        '
        'DidTextBox
        '
        Me.DidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DONORBindingSource, "Did", True))
        Me.DidTextBox.Location = New System.Drawing.Point(102, 19)
        Me.DidTextBox.Name = "DidTextBox"
        Me.DidTextBox.Size = New System.Drawing.Size(57, 20)
        Me.DidTextBox.TabIndex = 1
        '
        'PidLabel1
        '
        PidLabel1.AutoSize = True
        PidLabel1.Location = New System.Drawing.Point(188, 22)
        PidLabel1.Name = "PidLabel1"
        PidLabel1.Size = New System.Drawing.Size(25, 13)
        PidLabel1.TabIndex = 2
        PidLabel1.Text = "Pid:"
        '
        'PidTextBox1
        '
        Me.PidTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DONORBindingSource, "Pid", True))
        Me.PidTextBox1.Location = New System.Drawing.Point(271, 19)
        Me.PidTextBox1.Name = "PidTextBox1"
        Me.PidTextBox1.Size = New System.Drawing.Size(57, 20)
        Me.PidTextBox1.TabIndex = 3
        '
        'DnameLabel
        '
        DnameLabel.AutoSize = True
        DnameLabel.Location = New System.Drawing.Point(417, 26)
        DnameLabel.Name = "DnameLabel"
        DnameLabel.Size = New System.Drawing.Size(44, 13)
        DnameLabel.TabIndex = 4
        DnameLabel.Text = "Dname:"
        '
        'DnameTextBox
        '
        Me.DnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DONORBindingSource, "Dname", True))
        Me.DnameTextBox.Location = New System.Drawing.Point(500, 23)
        Me.DnameTextBox.Name = "DnameTextBox"
        Me.DnameTextBox.Size = New System.Drawing.Size(126, 20)
        Me.DnameTextBox.TabIndex = 5
        '
        'DAgeLabel
        '
        DAgeLabel.AutoSize = True
        DAgeLabel.Location = New System.Drawing.Point(424, 76)
        DAgeLabel.Name = "DAgeLabel"
        DAgeLabel.Size = New System.Drawing.Size(37, 13)
        DAgeLabel.TabIndex = 6
        DAgeLabel.Text = "DAge:"
        '
        'DAgeTextBox
        '
        Me.DAgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DONORBindingSource, "DAge", True))
        Me.DAgeTextBox.Location = New System.Drawing.Point(507, 73)
        Me.DAgeTextBox.Name = "DAgeTextBox"
        Me.DAgeTextBox.Size = New System.Drawing.Size(50, 20)
        Me.DAgeTextBox.TabIndex = 7
        '
        'DBloodGroupLabel
        '
        DBloodGroupLabel.AutoSize = True
        DBloodGroupLabel.Location = New System.Drawing.Point(19, 89)
        DBloodGroupLabel.Name = "DBloodGroupLabel"
        DBloodGroupLabel.Size = New System.Drawing.Size(77, 13)
        DBloodGroupLabel.TabIndex = 8
        DBloodGroupLabel.Text = "DBlood Group:"
        '
        'DBloodGroupTextBox
        '
        Me.DBloodGroupTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DONORBindingSource, "DBloodGroup", True))
        Me.DBloodGroupTextBox.Location = New System.Drawing.Point(102, 86)
        Me.DBloodGroupTextBox.Name = "DBloodGroupTextBox"
        Me.DBloodGroupTextBox.Size = New System.Drawing.Size(49, 20)
        Me.DBloodGroupTextBox.TabIndex = 9
        '
        'DNumLabel
        '
        DNumLabel.AutoSize = True
        DNumLabel.Location = New System.Drawing.Point(417, 137)
        DNumLabel.Name = "DNumLabel"
        DNumLabel.Size = New System.Drawing.Size(40, 13)
        DNumLabel.TabIndex = 10
        DNumLabel.Text = "DNum:"
        '
        'DNumTextBox
        '
        Me.DNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DONORBindingSource, "DNum", True))
        Me.DNumTextBox.Location = New System.Drawing.Point(500, 134)
        Me.DNumTextBox.Name = "DNumTextBox"
        Me.DNumTextBox.Size = New System.Drawing.Size(126, 20)
        Me.DNumTextBox.TabIndex = 11
        '
        'DAddrLabel
        '
        DAddrLabel.AutoSize = True
        DAddrLabel.Location = New System.Drawing.Point(421, 203)
        DAddrLabel.Name = "DAddrLabel"
        DAddrLabel.Size = New System.Drawing.Size(40, 13)
        DAddrLabel.TabIndex = 12
        DAddrLabel.Text = "DAddr:"
        '
        'DAddrTextBox
        '
        Me.DAddrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DONORBindingSource, "DAddr", True))
        Me.DAddrTextBox.Location = New System.Drawing.Point(504, 200)
        Me.DAddrTextBox.Name = "DAddrTextBox"
        Me.DAddrTextBox.Size = New System.Drawing.Size(307, 20)
        Me.DAddrTextBox.TabIndex = 13
        '
        'BloodGroupsBindingSource
        '
        Me.BloodGroupsBindingSource.DataMember = "BloodGroups"
        Me.BloodGroupsBindingSource.DataSource = Me.Database1DataSet
        '
        'BloodGroupsTableAdapter
        '
        Me.BloodGroupsTableAdapter.ClearBeforeFill = True
        '
        'BidLabel
        '
        BidLabel.AutoSize = True
        BidLabel.Location = New System.Drawing.Point(321, 135)
        BidLabel.Name = "BidLabel"
        BidLabel.Size = New System.Drawing.Size(25, 13)
        BidLabel.TabIndex = 0
        BidLabel.Text = "Bid:"
        '
        'BidTextBox
        '
        Me.BidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloodGroupsBindingSource, "Bid", True))
        Me.BidTextBox.Location = New System.Drawing.Point(401, 132)
        Me.BidTextBox.Name = "BidTextBox"
        Me.BidTextBox.Size = New System.Drawing.Size(36, 20)
        Me.BidTextBox.TabIndex = 1
        '
        'BloodGroupsLabel
        '
        BloodGroupsLabel.AutoSize = True
        BloodGroupsLabel.Location = New System.Drawing.Point(321, 161)
        BloodGroupsLabel.Name = "BloodGroupsLabel"
        BloodGroupsLabel.Size = New System.Drawing.Size(74, 13)
        BloodGroupsLabel.TabIndex = 2
        BloodGroupsLabel.Text = "Blood Groups:"
        '
        'BloodGroupsTextBox
        '
        Me.BloodGroupsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloodGroupsBindingSource, "BloodGroups", True))
        Me.BloodGroupsTextBox.Location = New System.Drawing.Point(401, 158)
        Me.BloodGroupsTextBox.Name = "BloodGroupsTextBox"
        Me.BloodGroupsTextBox.Size = New System.Drawing.Size(36, 20)
        Me.BloodGroupsTextBox.TabIndex = 3
        '
        'DOCTORBindingSource
        '
        Me.DOCTORBindingSource.DataMember = "DOCTOR"
        Me.DOCTORBindingSource.DataSource = Me.Database1DataSet
        '
        'DOCTORTableAdapter
        '
        Me.DOCTORTableAdapter.ClearBeforeFill = True
        '
        'DocNameLabel
        '
        DocNameLabel.AutoSize = True
        DocNameLabel.Location = New System.Drawing.Point(317, 111)
        DocNameLabel.Name = "DocNameLabel"
        DocNameLabel.Size = New System.Drawing.Size(61, 13)
        DocNameLabel.TabIndex = 0
        DocNameLabel.Text = "Doc Name:"
        '
        'DocNameTextBox
        '
        Me.DocNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DOCTORBindingSource, "DocName", True))
        Me.DocNameTextBox.Location = New System.Drawing.Point(384, 108)
        Me.DocNameTextBox.Name = "DocNameTextBox"
        Me.DocNameTextBox.Size = New System.Drawing.Size(159, 20)
        Me.DocNameTextBox.TabIndex = 1
        '
        'DocNumLabel
        '
        DocNumLabel.AutoSize = True
        DocNumLabel.Location = New System.Drawing.Point(317, 137)
        DocNumLabel.Name = "DocNumLabel"
        DocNumLabel.Size = New System.Drawing.Size(55, 13)
        DocNumLabel.TabIndex = 2
        DocNumLabel.Text = "Doc Num:"
        '
        'DocNumTextBox
        '
        Me.DocNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DOCTORBindingSource, "DocNum", True))
        Me.DocNumTextBox.Location = New System.Drawing.Point(384, 134)
        Me.DocNumTextBox.Name = "DocNumTextBox"
        Me.DocNumTextBox.Size = New System.Drawing.Size(159, 20)
        Me.DocNumTextBox.TabIndex = 3
        '
        'DocEmailLabel
        '
        DocEmailLabel.AutoSize = True
        DocEmailLabel.Location = New System.Drawing.Point(317, 163)
        DocEmailLabel.Name = "DocEmailLabel"
        DocEmailLabel.Size = New System.Drawing.Size(58, 13)
        DocEmailLabel.TabIndex = 4
        DocEmailLabel.Text = "Doc Email:"
        '
        'DocEmailTextBox
        '
        Me.DocEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DOCTORBindingSource, "DocEmail", True))
        Me.DocEmailTextBox.Location = New System.Drawing.Point(384, 160)
        Me.DocEmailTextBox.Name = "DocEmailTextBox"
        Me.DocEmailTextBox.Size = New System.Drawing.Size(159, 20)
        Me.DocEmailTextBox.TabIndex = 5
        '
        'BloodBankDataBindingSource
        '
        Me.BloodBankDataBindingSource.DataMember = "BloodBankData"
        Me.BloodBankDataBindingSource.DataSource = Me.Database1DataSet
        '
        'BloodBankDataTableAdapter
        '
        Me.BloodBankDataTableAdapter.ClearBeforeFill = True
        '
        'BnameLabel
        '
        BnameLabel.AutoSize = True
        BnameLabel.Location = New System.Drawing.Point(270, 108)
        BnameLabel.Name = "BnameLabel"
        BnameLabel.Size = New System.Drawing.Size(43, 13)
        BnameLabel.TabIndex = 0
        BnameLabel.Text = "Bname:"
        '
        'BnameTextBox
        '
        Me.BnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloodBankDataBindingSource, "Bname", True))
        Me.BnameTextBox.Location = New System.Drawing.Point(319, 105)
        Me.BnameTextBox.Name = "BnameTextBox"
        Me.BnameTextBox.Size = New System.Drawing.Size(135, 20)
        Me.BnameTextBox.TabIndex = 1
        '
        'BAddrLabel
        '
        BAddrLabel.AutoSize = True
        BAddrLabel.Location = New System.Drawing.Point(270, 134)
        BAddrLabel.Name = "BAddrLabel"
        BAddrLabel.Size = New System.Drawing.Size(39, 13)
        BAddrLabel.TabIndex = 2
        BAddrLabel.Text = "BAddr:"
        '
        'BAddrTextBox
        '
        Me.BAddrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloodBankDataBindingSource, "BAddr", True))
        Me.BAddrTextBox.Location = New System.Drawing.Point(319, 131)
        Me.BAddrTextBox.Name = "BAddrTextBox"
        Me.BAddrTextBox.Size = New System.Drawing.Size(415, 20)
        Me.BAddrTextBox.TabIndex = 3
        '
        'BemailLabel
        '
        BemailLabel.AutoSize = True
        BemailLabel.Location = New System.Drawing.Point(270, 160)
        BemailLabel.Name = "BemailLabel"
        BemailLabel.Size = New System.Drawing.Size(41, 13)
        BemailLabel.TabIndex = 4
        BemailLabel.Text = "Bemail:"
        '
        'BemailTextBox
        '
        Me.BemailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloodBankDataBindingSource, "Bemail", True))
        Me.BemailTextBox.Location = New System.Drawing.Point(319, 157)
        Me.BemailTextBox.Name = "BemailTextBox"
        Me.BemailTextBox.Size = New System.Drawing.Size(135, 20)
        Me.BemailTextBox.TabIndex = 5
        '
        'BnumLabel
        '
        BnumLabel.AutoSize = True
        BnumLabel.Location = New System.Drawing.Point(270, 186)
        BnumLabel.Name = "BnumLabel"
        BnumLabel.Size = New System.Drawing.Size(37, 13)
        BnumLabel.TabIndex = 6
        BnumLabel.Text = "Bnum:"
        '
        'BnumTextBox
        '
        Me.BnumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BloodBankDataBindingSource, "Bnum", True))
        Me.BnumTextBox.Location = New System.Drawing.Point(319, 183)
        Me.BnumTextBox.Name = "BnumTextBox"
        Me.BnumTextBox.Size = New System.Drawing.Size(135, 20)
        Me.BnumTextBox.TabIndex = 7
        '
        'TabPage6
        '
        Me.TabPage6.AutoScroll = True
        Me.TabPage6.Controls.Add(Me.PATIENTDataGridView)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(825, 305)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "View"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'PATIENTDataGridView
        '
        Me.PATIENTDataGridView.AutoGenerateColumns = False
        Me.PATIENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PATIENTDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PATIENTDataGridView.DataSource = Me.PATIENTBindingSource
        Me.PATIENTDataGridView.Location = New System.Drawing.Point(44, 3)
        Me.PATIENTDataGridView.Name = "PATIENTDataGridView"
        Me.PATIENTDataGridView.Size = New System.Drawing.Size(744, 204)
        Me.PATIENTDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Pid"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Pid"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Pname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Pname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PAge"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PAge"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PBloodGroup"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PBloodGroup"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PDisease"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PDisease"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PNum"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PNum"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "PAddr"
        Me.DataGridViewTextBoxColumn7.HeaderText = "PAddr"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'BloodBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1083, 562)
        Me.Controls.Add(Me.PATIENTBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "BloodBank"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BloodBank"
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PATIENTBindingNavigator.ResumeLayout(False)
        Me.PATIENTBindingNavigator.PerformLayout()
        CType(Me.DONORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodGroupsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DOCTORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BloodBankDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.PATIENTDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Database1DataSet As BloodBank.Database1DataSet
    Friend WithEvents PATIENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PATIENTTableAdapter As BloodBank.Database1DataSetTableAdapters.PATIENTTableAdapter
    Friend WithEvents TableAdapterManager As BloodBank.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PATIENTBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PATIENTBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PAgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PBloodGroupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PDiseaseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PAddrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DONORTableAdapter As BloodBank.Database1DataSetTableAdapters.DONORTableAdapter
    Friend WithEvents DONORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PidTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DAgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DBloodGroupTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DAddrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BloodGroupsTableAdapter As BloodBank.Database1DataSetTableAdapters.BloodGroupsTableAdapter
    Friend WithEvents BloodGroupsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BloodGroupsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOCTORTableAdapter As BloodBank.Database1DataSetTableAdapters.DOCTORTableAdapter
    Friend WithEvents DOCTORBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DocNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DocNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DocEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BloodBankDataTableAdapter As BloodBank.Database1DataSetTableAdapters.BloodBankDataTableAdapter
    Friend WithEvents BloodBankDataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BAddrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BemailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BnumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents PATIENTDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
