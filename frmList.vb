Public Class frmList
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
    Friend WithEvents btnDetail As System.Windows.Forms.Button
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dbgDetail As System.Windows.Forms.DataGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstDate As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtAddr As System.Windows.Forms.TextBox
    Friend WithEvents txtPref As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtHurigana As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents DsSample1 As SampleAppli.dsSample
    Friend WithEvents dvDetail As System.Data.DataView
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileQuit As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnDetail = New System.Windows.Forms.Button()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dbgDetail = New System.Windows.Forms.DataGrid()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstDate = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtAddr = New System.Windows.Forms.TextBox()
        Me.txtPref = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtHurigana = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileQuit = New System.Windows.Forms.MenuItem()
        Me.DsSample1 = New SampleAppli.dsSample()
        Me.dvDetail = New System.Data.DataView()
        CType(Me.dbgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSample1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dvDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDetail
        '
        Me.btnDetail.Location = New System.Drawing.Point(384, 192)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.TabIndex = 33
        Me.btnDetail.Text = "�ڍו\��"
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(312, 192)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(56, 19)
        Me.txtNo.TabIndex = 32
        Me.txtNo.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(256, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "����NO"
        '
        'dbgDetail
        '
        Me.dbgDetail.DataMember = ""
        Me.dbgDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgDetail.Location = New System.Drawing.Point(80, 232)
        Me.dbgDetail.Name = "dbgDetail"
        Me.dbgDetail.ReadOnly = True
        Me.dbgDetail.Size = New System.Drawing.Size(384, 160)
        Me.dbgDetail.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "�����ڍ�"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "�ڋq���"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "��������"
        '
        'lstDate
        '
        Me.lstDate.Enabled = False
        Me.lstDate.ItemHeight = 12
        Me.lstDate.Location = New System.Drawing.Point(80, 128)
        Me.lstDate.Name = "lstDate"
        Me.lstDate.Size = New System.Drawing.Size(168, 88)
        Me.lstDate.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 23)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "�ڋqID"
        '
        'txtTel
        '
        Me.txtTel.Enabled = False
        Me.txtTel.Location = New System.Drawing.Point(80, 96)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(96, 19)
        Me.txtTel.TabIndex = 24
        Me.txtTel.Text = ""
        '
        'txtAddr
        '
        Me.txtAddr.Enabled = False
        Me.txtAddr.Location = New System.Drawing.Point(256, 72)
        Me.txtAddr.Name = "txtAddr"
        Me.txtAddr.Size = New System.Drawing.Size(200, 19)
        Me.txtAddr.TabIndex = 23
        Me.txtAddr.Text = ""
        '
        'txtPref
        '
        Me.txtPref.Enabled = False
        Me.txtPref.Location = New System.Drawing.Point(184, 72)
        Me.txtPref.Name = "txtPref"
        Me.txtPref.Size = New System.Drawing.Size(64, 19)
        Me.txtPref.TabIndex = 22
        Me.txtPref.Text = ""
        '
        'txtZip
        '
        Me.txtZip.Enabled = False
        Me.txtZip.Location = New System.Drawing.Point(80, 72)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(96, 19)
        Me.txtZip.TabIndex = 21
        Me.txtZip.Text = ""
        '
        'txtHurigana
        '
        Me.txtHurigana.Enabled = False
        Me.txtHurigana.Location = New System.Drawing.Point(184, 48)
        Me.txtHurigana.Name = "txtHurigana"
        Me.txtHurigana.Size = New System.Drawing.Size(96, 19)
        Me.txtHurigana.TabIndex = 20
        Me.txtHurigana.Text = ""
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(80, 48)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(96, 19)
        Me.txtName.TabIndex = 19
        Me.txtName.Text = ""
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(144, 16)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.TabIndex = 18
        Me.btnFind.Text = "����"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(80, 16)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(56, 19)
        Me.txtID.TabIndex = 17
        Me.txtID.Text = ""
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileQuit})
        Me.mnuFile.Text = "�t�@�C���i&F�j"
        '
        'mnuFileQuit
        '
        Me.mnuFileQuit.Index = 0
        Me.mnuFileQuit.Text = "����i&Q�j"
        '
        'DsSample1
        '
        Me.DsSample1.DataSetName = "dsSample"
        Me.DsSample1.Locale = New System.Globalization.CultureInfo("ja-JP")
        Me.DsSample1.Namespace = "http://www.tempuri.org/dsSample.xsd"
        '
        'dvDetail
        '
        Me.dvDetail.Table = Me.DsSample1.T_�T�u
        '
        'frmList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(488, 406)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnDetail, Me.txtNo, Me.Label5, Me.dbgDetail, Me.Label4, Me.Label3, Me.Label2, Me.lstDate, Me.Label1, Me.txtTel, Me.txtAddr, Me.txtPref, Me.txtZip, Me.txtHurigana, Me.txtName, Me.btnFind, Me.txtID})
        Me.Menu = Me.MainMenu1
        Me.Name = "frmList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "�ڋq����"
        CType(Me.dbgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSample1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dvDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    '------------------
    '���W���[�����x���ϐ�
    Private m_fm As Form1


    '-------------------
    '�N����
    '
    Private Sub frmList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Form1 ���Q��
        m_fm = Form1.ActiveForm

        '�f�[�^�ǂݍ���
        m_fm.odaMain.Fill(DsSample1, "T_���C��")
        m_fm.odaSub.Fill(DsSample1, "T_�T�u")
        m_fm.odaKokyaku.Fill(DsSample1, "T_�ڋq")
    End Sub


    '----------------------
    '�m����n���j���[
    '
    Private Sub mnuFileQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileQuit.Click
        Me.Close()
    End Sub


End Class
