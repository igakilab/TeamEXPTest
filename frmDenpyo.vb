Public Class frmDenpyo
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
  Friend WithEvents dbgSub As System.Windows.Forms.DataGrid
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtPosition As System.Windows.Forms.TextBox
  Friend WithEvents txtShainName As System.Windows.Forms.TextBox
  Friend WithEvents txtKokyakuName As System.Windows.Forms.TextBox
  Friend WithEvents txtShainID As System.Windows.Forms.TextBox
  Friend WithEvents txtKokyakuID As System.Windows.Forms.TextBox
  Friend WithEvents txtDate As System.Windows.Forms.TextBox
  Friend WithEvents txtNo As System.Windows.Forms.TextBox
  Friend WithEvents btnLast As System.Windows.Forms.Button
  Friend WithEvents btnNext As System.Windows.Forms.Button
  Friend WithEvents btnNew As System.Windows.Forms.Button
  Friend WithEvents btnPrevious As System.Windows.Forms.Button
  Friend WithEvents btnFirst As System.Windows.Forms.Button
  Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
  Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
  Friend WithEvents mnuFileLoad As System.Windows.Forms.MenuItem
  Friend WithEvents mnuFileSave As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileStep2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileQuit As System.Windows.Forms.MenuItem
  Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
  Friend WithEvents mnuEditFind As System.Windows.Forms.MenuItem
  Friend WithEvents mnuEditStep As System.Windows.Forms.MenuItem
  Friend WithEvents mnuEditDelete As System.Windows.Forms.MenuItem
  Friend WithEvents DsSample1 As SampleAppli.dsSample
  Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
  Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
  Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
  Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
  Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
  Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
  Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dbgSub = New System.Windows.Forms.DataGrid()
        Me.DsSample1 = New SampleAppli.dsSample()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtShainName = New System.Windows.Forms.TextBox()
        Me.txtKokyakuName = New System.Windows.Forms.TextBox()
        Me.txtShainID = New System.Windows.Forms.TextBox()
        Me.txtKokyakuID = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileLoad = New System.Windows.Forms.MenuItem()
        Me.mnuFileSave = New System.Windows.Forms.MenuItem()
        Me.mnuFileStep2 = New System.Windows.Forms.MenuItem()
        Me.mnuFileQuit = New System.Windows.Forms.MenuItem()
        Me.mnuEdit = New System.Windows.Forms.MenuItem()
        Me.mnuEditFind = New System.Windows.Forms.MenuItem()
        Me.mnuEditStep = New System.Windows.Forms.MenuItem()
        Me.mnuEditDelete = New System.Windows.Forms.MenuItem()
        CType(Me.dbgSub, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSample1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbgSub
        '
        Me.dbgSub.DataMember = "T_���C��.relMainSub"
        Me.dbgSub.DataSource = Me.DsSample1
        Me.dbgSub.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgSub.Location = New System.Drawing.Point(22, 200)
        Me.dbgSub.Name = "dbgSub"
        Me.dbgSub.Size = New System.Drawing.Size(751, 280)
        Me.dbgSub.TabIndex = 19
        Me.dbgSub.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DsSample1
        '
        Me.DsSample1.DataSetName = "dsSample"
        Me.DsSample1.Locale = New System.Globalization.CultureInfo("ja-JP")
        Me.DsSample1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dbgSub
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "T_�T�u"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "����NO"
        Me.DataGridTextBoxColumn1.MappingName = "����NO"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "���i�ԍ�"
        Me.DataGridTextBoxColumn2.MappingName = "���i�ԍ�"
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "���i��"
        Me.DataGridTextBoxColumn3.MappingName = "���i��"
        Me.DataGridTextBoxColumn3.Width = 160
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = "###,###"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "�P��"
        Me.DataGridTextBoxColumn4.MappingName = "�P��"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn5.Format = "###,###"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "����"
        Me.DataGridTextBoxColumn5.MappingName = "����"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = "###,###"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "���z"
        Me.DataGridTextBoxColumn6.MappingName = "���z"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(22, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 29)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "�Ј�"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(22, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 29)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "�ڋq"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(22, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 29)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "������"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(22, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 29)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "����NO"
        '
        'txtPosition
        '
        Me.txtPosition.Enabled = False
        Me.txtPosition.Location = New System.Drawing.Point(134, 20)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(112, 22)
        Me.txtPosition.TabIndex = 28
        Me.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtShainName
        '
        Me.txtShainName.Enabled = False
        Me.txtShainName.Location = New System.Drawing.Point(213, 160)
        Me.txtShainName.Name = "txtShainName"
        Me.txtShainName.Size = New System.Drawing.Size(213, 22)
        Me.txtShainName.TabIndex = 27
        '
        'txtKokyakuName
        '
        Me.txtKokyakuName.Enabled = False
        Me.txtKokyakuName.Location = New System.Drawing.Point(213, 130)
        Me.txtKokyakuName.Name = "txtKokyakuName"
        Me.txtKokyakuName.Size = New System.Drawing.Size(213, 22)
        Me.txtKokyakuName.TabIndex = 26
        '
        'txtShainID
        '
        Me.txtShainID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsSample1, "T_���C��.�Ј�ID", True))
        Me.txtShainID.Location = New System.Drawing.Point(123, 160)
        Me.txtShainID.Name = "txtShainID"
        Me.txtShainID.Size = New System.Drawing.Size(79, 22)
        Me.txtShainID.TabIndex = 18
        '
        'txtKokyakuID
        '
        Me.txtKokyakuID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsSample1, "T_���C��.�ڋqID", True))
        Me.txtKokyakuID.Location = New System.Drawing.Point(123, 130)
        Me.txtKokyakuID.Name = "txtKokyakuID"
        Me.txtKokyakuID.Size = New System.Drawing.Size(79, 22)
        Me.txtKokyakuID.TabIndex = 17
        '
        'txtDate
        '
        Me.txtDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsSample1, "T_���C��.���t", True))
        Me.txtDate.Location = New System.Drawing.Point(123, 100)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(303, 22)
        Me.txtDate.TabIndex = 16
        '
        'txtNo
        '
        Me.txtNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsSample1, "T_���C��.����NO", True))
        Me.txtNo.Enabled = False
        Me.txtNo.Location = New System.Drawing.Point(123, 70)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(79, 22)
        Me.txtNo.TabIndex = 22
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(302, 20)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(56, 29)
        Me.btnLast.TabIndex = 24
        Me.btnLast.Text = ">>"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(246, 20)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(56, 29)
        Me.btnNext.TabIndex = 23
        Me.btnNext.Text = ">"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(358, 20)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(56, 29)
        Me.btnNew.TabIndex = 25
        Me.btnNew.Text = ">��"
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(78, 20)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(56, 29)
        Me.btnPrevious.TabIndex = 21
        Me.btnPrevious.Text = "<"
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(22, 20)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(56, 29)
        Me.btnFirst.TabIndex = 20
        Me.btnFirst.Text = "<<"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuEdit})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileLoad, Me.mnuFileSave, Me.mnuFileStep2, Me.mnuFileQuit})
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
        'mnuFileStep2
        '
        Me.mnuFileStep2.Index = 2
        Me.mnuFileStep2.Text = "-"
        '
        'mnuFileQuit
        '
        Me.mnuFileQuit.Index = 3
        Me.mnuFileQuit.Text = "����i&Q�j"
        '
        'mnuEdit
        '
        Me.mnuEdit.Index = 1
        Me.mnuEdit.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuEditFind, Me.mnuEditStep, Me.mnuEditDelete})
        Me.mnuEdit.Text = "�ҏW�i&E�j"
        '
        'mnuEditFind
        '
        Me.mnuEditFind.Index = 0
        Me.mnuEditFind.Text = "�`�[�����i&F�j..."
        '
        'mnuEditStep
        '
        Me.mnuEditStep.Index = 1
        Me.mnuEditStep.Text = "-"
        '
        'mnuEditDelete
        '
        Me.mnuEditDelete.Index = 2
        Me.mnuEditDelete.Text = "�`�[�폜�i&D�j"
        '
        'frmDenpyo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(568, 398)
        Me.Controls.Add(Me.dbgSub)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtShainName)
        Me.Controls.Add(Me.txtKokyakuName)
        Me.Controls.Add(Me.txtShainID)
        Me.Controls.Add(Me.txtKokyakuID)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmDenpyo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "�`�[����"
        CType(Me.dbgSub, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSample1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    '���W���[�����x���ϐ�
    Private m_fm As Form1       'Form1
  Private m_iNo As Integer    '����NO
  Private m_bNew As Boolean   '�V�K�t���O

  '-------------------
  '�N����
  '
  Private Sub frmDenpyo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim iCnt As Integer   '�mT_���C���n�e�[�u���̃��R�[�h��

    'Form1 ���Q��
    m_fm = Form1.ActiveForm

    '�f�[�^�ǂݍ���
    m_fm.odaMain.Fill(DsSample1, "T_���C��")
    m_fm.odaSub.Fill(DsSample1, "T_�T�u")
    m_fm.odaKokyaku.Fill(DsSample1, "T_�ڋq")
    m_fm.odaShain.Fill(DsSample1, "T_�Ј�")
    m_fm.odaShohin.Fill(DsSample1, "T_���i")   '���|�[�g�p

    '���Z�t�B�[���h
    DsSample1.T_�T�u.Columns("���z").Expression = "�P��*����"

    '������
    DispPosition()
    DispName()
    m_bNew = False

    '����NO�̏����l
    iCnt = DsSample1.T_���C��.Rows.Count
    If icnt = 0 Then
      m_iNo = 0
    Else
      m_iNo = DsSample1.T_���C��.Rows(iCnt - 1)("����NO")
    End If
  End Sub


    '
    '�m����n���j���[
    '
    Private Sub mnuFileQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileQuit.Click
        Me.Close()
    End Sub


    '
    '�m���iID�n����͂����Ƃ�
    '
    Private Sub dbgSub_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dbgSub.CurrentCellChanged
        Dim iRow As Integer   '�s�ԍ�
        Dim iCol As Integer   '��ԍ�
        Dim r As DataRow  '�����������R�[�h

        '�J�����g�Z���ʒu
        iRow = dbgSub.CurrentCell.RowNumber
        iCol = dbgSub.CurrentCell.ColumnNumber

        '���i���E�P���̕\��
        Select Case iCol
            Case 2  '���i��
                r = DsSample1.T_���i.Rows.Find(dbgSub(iRow, 1))
                If IsNothing(r) Then
                    MessageBox.Show("�Y������m���i�ԍ��n�͂���܂���B", "�`�[����")
                Else
                    dbgSub(iRow, 2) = r("���i��")
                    dbgSub(iRow, 3) = r("�P��")
                End If
        End Select
        Me.BindingContext(DsSample1, "T_�T�u").EndCurrentEdit()  '�Čv�Z
    End Sub


    '-------------------
    '���R�[�h�ԍ��E���R�[�h�ʒu�̕\��
    '
    Private Sub DispPosition()
        Dim iPos As Integer   '���R�[�h�ԍ�
        Dim iCnt As Integer   '���R�[�h��

        '���R�[�h�ԍ��E���R�[�h���̎擾
        iPos = Me.BindingContext(DsSample1, "T_���C��").Position + 1
        iCnt = Me.BindingContext(DsSample1, "T_���C��").Count

        '�\��
        txtPosition.Text = iPos & " / " & iCnt
    End Sub

    '
    '�ڋq���E�Ј����̕\��
    '
    Private Sub DispName()
        Dim rKokyaku As DataRow   '���������ڋq
        Dim rShain As DataRow     '���������Ј�

        '�ڋq��
        rKokyaku = DsSample1.T_�ڋq.Rows.Find(txtKokyakuID.Text)
        If IsNothing(rKokyaku) Then
            MessageBox.Show("�Y������m�ڋqID�n�͌�����܂���", "�`�[����")
            txtKokyakuName.Text = ""
        Else
            txtKokyakuName.Text = rKokyaku("����")
        End If

        '�Ј���
        rShain = DsSample1.T_�Ј�.Rows.Find(txtShainID.Text)
        If IsNothing(rShain) Then
            MessageBox.Show("�Y������m�Ј�ID�n�͌�����܂���", "�`�[����")
            txtShainName.Text = ""
        Else
            txtShainName.Text = rShain("����")
        End If
    End Sub

    '
    '�ҏW��Ԃ̊m�F
    '
    Private Sub ChkModified()
        Dim iPos As Integer   '�ҏW���̃��R�[�h�ԍ�

        '�V�������R�[�h
        If m_bNew = True Then
            '�ҏW�����Ƃ�
            If ((txtDate.Modified = True) Or
              (txtKokyakuID.Modified = True) Or (txtShainID.Modified = True)) Then
                Me.BindingContext(DsSample1, "T_���C��").EndCurrentEdit()

                '�ҏW���Ă��Ȃ��Ƃ�
            Else
                '�ǉ��������R�[�h�̍폜
                iPos = Me.BindingContext(DsSample1, "T_���C��").Position
                Me.BindingContext(DsSample1, "T_���C��").RemoveAt(iPos)
                m_iNo = m_iNo - 1
            End If

            '�������R�[�h
        Else
            Me.BindingContext(DsSample1, "T_���C��").EndCurrentEdit()
        End If

        '������
        m_bNew = False
        btnPrevious.Enabled = True
    End Sub
End Class
