Public Class frmKokyaku
    Inherits System.Windows.Forms.Form

#Region " Windows �t�H�[�� �f�U�C�i�Ő������ꂽ�R�[�h "

    Public Sub New()
        MyBase.New()

        ' ���̌Ăяo���� Windows �t�H�[�� �f�U�C�i�ŕK�v�ł��B
        InitializeComponent()

        ' InitializeComponent() �Ăяo���̌�ɏ�������ǉ����܂��B

    End Sub

    ' Form �� dispose ���I�[�o�[���C�h���ăR���|�[�l���g�ꗗ���������܂��B
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Windows �t�H�[�� �f�U�C�i�ŕK�v�ł��B
    Private components As System.ComponentModel.IContainer

    ' ���� : �ȉ��̃v���V�[�W���́AWindows �t�H�[�� �f�U�C�i�ŕK�v�ł��B
    ' Windows �t�H�[�� �f�U�C�i���g���ĕύX���Ă��������B  
    ' �R�[�h �G�f�B�^�͎g�p���Ȃ��ł��������B
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents DsSample1 As SampleAppli.dsSample
    Friend WithEvents dvHurigana As System.Data.DataView
    Friend WithEvents dbgKokyaku As System.Windows.Forms.DataGrid
    Friend WithEvents tabHurigana As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileLoad As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileSave As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileStep As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileQuit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditFind As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditFindID As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEditFindTel As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileLoad = New System.Windows.Forms.MenuItem()
        Me.mnuFileSave = New System.Windows.Forms.MenuItem()
        Me.mnuFileStep = New System.Windows.Forms.MenuItem()
        Me.mnuFileQuit = New System.Windows.Forms.MenuItem()
        Me.mnuEdit = New System.Windows.Forms.MenuItem()
        Me.mnuEditFind = New System.Windows.Forms.MenuItem()
        Me.mnuEditFindID = New System.Windows.Forms.MenuItem()
        Me.mnuEditFindTel = New System.Windows.Forms.MenuItem()
        Me.DsSample1 = New SampleAppli.dsSample()
        Me.dvHurigana = New System.Data.DataView()
        Me.dbgKokyaku = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.tabHurigana = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.DsSample1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvHurigana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbgKokyaku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabHurigana.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuEdit})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileLoad, Me.mnuFileSave, Me.mnuFileStep, Me.mnuFileQuit})
        Me.mnuFile.Text = "�t�@�C���i&F�j"
        '
        'mnuFileLoad
        '
        Me.mnuFileLoad.Index = 0
        Me.mnuFileLoad.Text = "�ă��[�h�i&L�j"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Index = 1
        Me.mnuFileSave.Text = "�㏑���ۑ��i&S�j"
        '
        'mnuFileStep
        '
        Me.mnuFileStep.Index = 2
        Me.mnuFileStep.Text = "-"
        '
        'mnuFileQuit
        '
        Me.mnuFileQuit.Index = 3
        Me.mnuFileQuit.Text = "����i&Q�j"
        '
        'mnuEdit
        '
        Me.mnuEdit.Index = 1
        Me.mnuEdit.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuEditFind})
        Me.mnuEdit.Text = "�ҏW�i&E�j"
        '
        'mnuEditFind
        '
        Me.mnuEditFind.Index = 0
        Me.mnuEditFind.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuEditFindID, Me.mnuEditFindTel})
        Me.mnuEditFind.Text = "�����i&F�j"
        '
        'mnuEditFindID
        '
        Me.mnuEditFindID.Index = 0
        Me.mnuEditFindID.Text = "�ڋqID�i&I�j..."
        '
        'mnuEditFindTel
        '
        Me.mnuEditFindTel.Index = 1
        Me.mnuEditFindTel.Text = "�d�b�ԍ��i&T�j..."
        '
        'DsSample1
        '
        Me.DsSample1.DataSetName = "dsSample"
        Me.DsSample1.Locale = New System.Globalization.CultureInfo("ja-JP")
        Me.DsSample1.Namespace = "http://www.tempuri.org/dsSample.xsd"
        '
        'dvHurigana
        '
        Me.dvHurigana.Table = Me.DsSample1.T_�ڋq
        '
        'dbgKokyaku
        '
        Me.dbgKokyaku.DataMember = ""
        Me.dbgKokyaku.DataSource = Me.dvHurigana
        Me.dbgKokyaku.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgKokyaku.Location = New System.Drawing.Point(16, 40)
        Me.dbgKokyaku.Name = "dbgKokyaku"
        Me.dbgKokyaku.Size = New System.Drawing.Size(672, 312)
        Me.dbgKokyaku.TabIndex = 3
        Me.dbgKokyaku.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dbgKokyaku
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "T_�ڋq"
        '
        'tabHurigana
        '
        Me.tabHurigana.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabPage1, Me.TabPage2, Me.TabPage3, Me.TabPage4, Me.TabPage5, Me.TabPage6, Me.TabPage7, Me.TabPage8, Me.TabPage9, Me.TabPage10, Me.TabPage11})
        Me.tabHurigana.Location = New System.Drawing.Point(16, 16)
        Me.tabHurigana.Name = "tabHurigana"
        Me.tabHurigana.SelectedIndex = 0
        Me.tabHurigana.Size = New System.Drawing.Size(672, 24)
        Me.tabHurigana.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 21)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(664, 0)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "�S"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 21)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(664, -1)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "��"
        Me.TabPage2.Visible = False
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 21)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(664, -1)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "��"
        Me.TabPage3.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 21)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(664, -1)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "��"
        Me.TabPage4.Visible = False
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 21)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(664, -1)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "��"
        Me.TabPage5.Visible = False
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 21)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(664, -1)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "��"
        Me.TabPage6.Visible = False
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(4, 21)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(664, -1)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "��"
        Me.TabPage7.Visible = False
        '
        'TabPage8
        '
        Me.TabPage8.Location = New System.Drawing.Point(4, 21)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(664, -1)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "��"
        Me.TabPage8.Visible = False
        '
        'TabPage9
        '
        Me.TabPage9.Location = New System.Drawing.Point(4, 21)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(664, -1)
        Me.TabPage9.TabIndex = 8
        Me.TabPage9.Text = "��"
        Me.TabPage9.Visible = False
        '
        'TabPage10
        '
        Me.TabPage10.Location = New System.Drawing.Point(4, 21)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(664, -1)
        Me.TabPage10.TabIndex = 9
        Me.TabPage10.Text = "��"
        Me.TabPage10.Visible = False
        '
        'TabPage11
        '
        Me.TabPage11.Location = New System.Drawing.Point(4, 21)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Size = New System.Drawing.Size(664, -1)
        Me.TabPage11.TabIndex = 10
        Me.TabPage11.Text = "��"
        Me.TabPage11.Visible = False
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "�ڋqID"
        Me.DataGridTextBoxColumn1.MappingName = "�ڋqID"
        Me.DataGridTextBoxColumn1.Width = 50
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "����"
        Me.DataGridTextBoxColumn2.MappingName = "����"
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "�t���K�i"
        Me.DataGridTextBoxColumn3.MappingName = "�t���K�i"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "���ԍ�"
        Me.DataGridTextBoxColumn4.MappingName = "�X�֔ԍ�"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "�s���{��"
        Me.DataGridTextBoxColumn5.MappingName = "�s���{��"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "�Z��"
        Me.DataGridTextBoxColumn6.MappingName = "�Z��"
        Me.DataGridTextBoxColumn6.Width = 160
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "�d�b�ԍ�"
        Me.DataGridTextBoxColumn7.MappingName = "�d�b�ԍ�"
        Me.DataGridTextBoxColumn7.Width = 90
        '
        'frmKokyaku
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(704, 369)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.dbgKokyaku, Me.tabHurigana})
        Me.Menu = Me.MainMenu1
        Me.Name = "frmKokyaku"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "�ڋq�o�^"
        CType(Me.DsSample1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvHurigana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbgKokyaku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabHurigana.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    '----------------------
    '���W���[�����x���ϐ�
    Private m_fm As Form1


    '---------------
    '�N����
    '
    Private Sub frmKokyaku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form1 ���Q��
        m_fm = Form1.ActiveForm

        '�f�[�^�ǂݍ���
        m_fm.odaKokyaku.Fill(DsSample1, "T_�ڋq")
    End Sub


    '
    '�m����n���j���[
    '
    Private Sub mnuFileQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileQuit.Click
        Me.Close()
    End Sub


End Class
