Public Class Form1
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
    Friend WithEvents odaMain As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents MainSelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents MainInsertCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents MainUpdateCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents MainDelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents ocnSample As System.Data.OleDb.OleDbConnection
    Friend WithEvents odaSub As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents SubSelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents SubInsertCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents SubDelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents SubUpdateCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents odaShohin As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents ShohinSelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents ShohinInsertCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents ShohinUpdateCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents ShohinDelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents odaShain As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents ShainSelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents ShainInsertCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents ShainUpdateCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents ShainDelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents DsSample1 As SampleAppli.dsSample
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileInput As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileStep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileFind As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileStep2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrepare As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrepareShohin As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrepareKokyaku As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrepareShain As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTool As System.Windows.Forms.MenuItem
    Friend WithEvents mnuToolExport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuToolExportCsv As System.Windows.Forms.MenuItem
    Friend WithEvents mnuToolExportXml As System.Windows.Forms.MenuItem
    Friend WithEvents odaKokyaku As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents KokyakuSelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents KokyakuInsertCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents KokyakuUpdateCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents KokyakuDelCmd As System.Data.OleDb.OleDbCommand
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFileInput = New System.Windows.Forms.MenuItem()
        Me.mnuFileStep1 = New System.Windows.Forms.MenuItem()
        Me.mnuFileFind = New System.Windows.Forms.MenuItem()
        Me.mnuFileStep2 = New System.Windows.Forms.MenuItem()
        Me.mnuFileExit = New System.Windows.Forms.MenuItem()
        Me.mnuPrepare = New System.Windows.Forms.MenuItem()
        Me.mnuPrepareShohin = New System.Windows.Forms.MenuItem()
        Me.mnuPrepareKokyaku = New System.Windows.Forms.MenuItem()
        Me.mnuPrepareShain = New System.Windows.Forms.MenuItem()
        Me.mnuTool = New System.Windows.Forms.MenuItem()
        Me.mnuToolExport = New System.Windows.Forms.MenuItem()
        Me.mnuToolExportCsv = New System.Windows.Forms.MenuItem()
        Me.mnuToolExportXml = New System.Windows.Forms.MenuItem()
        Me.odaMain = New System.Data.OleDb.OleDbDataAdapter()
        Me.MainDelCmd = New System.Data.OleDb.OleDbCommand()
        Me.ocnSample = New System.Data.OleDb.OleDbConnection()
        Me.MainInsertCmd = New System.Data.OleDb.OleDbCommand()
        Me.MainSelCmd = New System.Data.OleDb.OleDbCommand()
        Me.MainUpdateCmd = New System.Data.OleDb.OleDbCommand()
        Me.odaSub = New System.Data.OleDb.OleDbDataAdapter()
        Me.SubDelCmd = New System.Data.OleDb.OleDbCommand()
        Me.SubInsertCmd = New System.Data.OleDb.OleDbCommand()
        Me.SubSelCmd = New System.Data.OleDb.OleDbCommand()
        Me.SubUpdateCmd = New System.Data.OleDb.OleDbCommand()
        Me.odaShohin = New System.Data.OleDb.OleDbDataAdapter()
        Me.ShohinDelCmd = New System.Data.OleDb.OleDbCommand()
        Me.ShohinInsertCmd = New System.Data.OleDb.OleDbCommand()
        Me.ShohinSelCmd = New System.Data.OleDb.OleDbCommand()
        Me.ShohinUpdateCmd = New System.Data.OleDb.OleDbCommand()
        Me.odaShain = New System.Data.OleDb.OleDbDataAdapter()
        Me.ShainDelCmd = New System.Data.OleDb.OleDbCommand()
        Me.ShainInsertCmd = New System.Data.OleDb.OleDbCommand()
        Me.ShainSelCmd = New System.Data.OleDb.OleDbCommand()
        Me.ShainUpdateCmd = New System.Data.OleDb.OleDbCommand()
        Me.DsSample1 = New SampleAppli.dsSample()
        Me.odaKokyaku = New System.Data.OleDb.OleDbDataAdapter()
        Me.KokyakuDelCmd = New System.Data.OleDb.OleDbCommand()
        Me.KokyakuInsertCmd = New System.Data.OleDb.OleDbCommand()
        Me.KokyakuSelCmd = New System.Data.OleDb.OleDbCommand()
        Me.KokyakuUpdateCmd = New System.Data.OleDb.OleDbCommand()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DsSample1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuPrepare, Me.mnuTool})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileInput, Me.mnuFileStep1, Me.mnuFileFind, Me.mnuFileStep2, Me.mnuFileExit})
        Me.mnuFile.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuFile.Text = "�t�@�C���i&F�j"
        '
        'mnuFileInput
        '
        Me.mnuFileInput.Index = 0
        Me.mnuFileInput.Text = "�`�[���́i&I�j"
        '
        'mnuFileStep1
        '
        Me.mnuFileStep1.Index = 1
        Me.mnuFileStep1.Text = "-"
        '
        'mnuFileFind
        '
        Me.mnuFileFind.Index = 2
        Me.mnuFileFind.Text = "�ڋq�����i&F�j"
        '
        'mnuFileStep2
        '
        Me.mnuFileStep2.Index = 3
        Me.mnuFileStep2.Text = "-"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Index = 4
        Me.mnuFileExit.Text = "�I���i&X�j"
        '
        'mnuPrepare
        '
        Me.mnuPrepare.Index = 1
        Me.mnuPrepare.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuPrepareShohin, Me.mnuPrepareKokyaku, Me.mnuPrepareShain})
        Me.mnuPrepare.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuPrepare.Text = "�����i&P�j"
        '
        'mnuPrepareShohin
        '
        Me.mnuPrepareShohin.Index = 0
        Me.mnuPrepareShohin.Text = "���i�o�^�i&G�j"
        '
        'mnuPrepareKokyaku
        '
        Me.mnuPrepareKokyaku.Index = 1
        Me.mnuPrepareKokyaku.Text = "�ڋq�o�^�i&C�j"
        '
        'mnuPrepareShain
        '
        Me.mnuPrepareShain.Index = 2
        Me.mnuPrepareShain.Text = "�Ј��o�^�i&E�j"
        '
        'mnuTool
        '
        Me.mnuTool.Index = 2
        Me.mnuTool.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuToolExport})
        Me.mnuTool.MergeType = System.Windows.Forms.MenuMerge.Remove
        Me.mnuTool.Text = "�c�[���i&T�j"
        '
        'mnuToolExport
        '
        Me.mnuToolExport.Index = 0
        Me.mnuToolExport.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuToolExportCsv, Me.mnuToolExportXml})
        Me.mnuToolExport.Text = "�G�N�X�|�[�g�i&E�j"
        '
        'mnuToolExportCsv
        '
        Me.mnuToolExportCsv.Index = 0
        Me.mnuToolExportCsv.Text = "CSV�`���i&C�j..."
        '
        'mnuToolExportXml
        '
        Me.mnuToolExportXml.Index = 1
        Me.mnuToolExportXml.Text = "XML�`���iX�j..."
        '
        'odaMain
        '
        Me.odaMain.DeleteCommand = Me.MainDelCmd
        Me.odaMain.InsertCommand = Me.MainInsertCmd
        Me.odaMain.SelectCommand = Me.MainSelCmd
        Me.odaMain.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_���C��", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("����NO", "����NO"), New System.Data.Common.DataColumnMapping("���t", "���t"), New System.Data.Common.DataColumnMapping("�ڋqID", "�ڋqID"), New System.Data.Common.DataColumnMapping("�Ј�ID", "�Ј�ID")})})
        Me.odaMain.UpdateCommand = Me.MainUpdateCmd
        '
        'MainDelCmd
        '
        Me.MainDelCmd.CommandText = "DELETE FROM [T_���C��] WHERE (����NO = ?) AND (���t = ? OR ? IS NULL AND ���t IS NULL)"
        Me.MainDelCmd.Connection = Me.ocnSample
        Me.MainDelCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_����NO", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "����NO", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_���t", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���t", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_���t1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���t", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ocnSample
        '
        Me.ocnSample.ConnectionString = resources.GetString("ocnSample.ConnectionString")
        '
        'MainInsertCmd
        '
        Me.MainInsertCmd.CommandText = "INSERT INTO [T_���C��] (����NO, ���t, �ڋqID, �Ј�ID) VALUES (?, ?, ?, ?)"
        Me.MainInsertCmd.Connection = Me.ocnSample
        Me.MainInsertCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("����NO", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "����NO", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("���t", System.Data.OleDb.OleDbType.DBDate, 0, "���t"), New System.Data.OleDb.OleDbParameter("�ڋqID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "�ڋqID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("�Ј�ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "�Ј�ID", System.Data.DataRowVersion.Current, Nothing)})
        '
        'MainSelCmd
        '
        Me.MainSelCmd.CommandText = "SELECT ����NO, ���t, �ڋqID, �Ј�ID FROM [T_���C��]"
        Me.MainSelCmd.Connection = Me.ocnSample
        '
        'MainUpdateCmd
        '
        Me.MainUpdateCmd.CommandText = "UPDATE [T_���C��] SET ����NO = ?, ���t = ?, �ڋqID = ?, �Ј�ID = ? WHERE (����NO = ?) AND (���t " &
    "= ? OR ? IS NULL AND ���t IS NULL)"
        Me.MainUpdateCmd.Connection = Me.ocnSample
        Me.MainUpdateCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("����NO", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "����NO", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("���t", System.Data.OleDb.OleDbType.DBDate, 0, "���t"), New System.Data.OleDb.OleDbParameter("�ڋqID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "�ڋqID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("�Ј�ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "�Ј�ID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("Original_����NO", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "����NO", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_���t", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���t", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_���t1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���t", System.Data.DataRowVersion.Original, Nothing)})
        '
        'odaSub
        '
        Me.odaSub.DeleteCommand = Me.SubDelCmd
        Me.odaSub.InsertCommand = Me.SubInsertCmd
        Me.odaSub.SelectCommand = Me.SubSelCmd
        Me.odaSub.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_�T�u", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("����NO", "����NO"), New System.Data.Common.DataColumnMapping("���i�ԍ�", "���i�ԍ�"), New System.Data.Common.DataColumnMapping("���i��", "���i��"), New System.Data.Common.DataColumnMapping("�P��", "�P��"), New System.Data.Common.DataColumnMapping("����", "����"), New System.Data.Common.DataColumnMapping("���z", "���z")})})
        Me.odaSub.UpdateCommand = Me.SubUpdateCmd
        '
        'SubDelCmd
        '
        Me.SubDelCmd.CommandText = "DELETE FROM [T_�T�u] WHERE (����NO = ?) AND (���i�ԍ� = ?) AND (���� = ?)"
        Me.SubDelCmd.Connection = Me.ocnSample
        Me.SubDelCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("����NO", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "����NO", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("���i�ԍ�", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���i�ԍ�", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("����", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SubInsertCmd
        '
        Me.SubInsertCmd.CommandText = "INSERT INTO [T_�T�u] (����NO, ���i�ԍ�, ����) VALUES (?, ?, ?)"
        Me.SubInsertCmd.Connection = Me.ocnSample
        Me.SubInsertCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("����NO", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "����NO", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("���i�ԍ�", System.Data.OleDb.OleDbType.VarWChar, 10, "���i�ԍ�"), New System.Data.OleDb.OleDbParameter("����", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Current, Nothing)})
        '
        'SubSelCmd
        '
        Me.SubSelCmd.CommandText = "SELECT [T_�T�u].����NO, [T_�T�u].���i�ԍ�, [T_���i].���i��, [T_���i].�P��, [T_�T�u].����, [T_���i].�P�� * [T" &
    "_�T�u].���� AS ���z FROM [T_�T�u] INNER JOIN [T_���i] ON [T_�T�u].���i�ԍ� = [T_���i].���i�ԍ�"
        Me.SubSelCmd.Connection = Me.ocnSample
        '
        'SubUpdateCmd
        '
        Me.SubUpdateCmd.CommandText = "UPDATE [T_�T�u] SET ����NO = ?, ���i�ԍ� = ?, ���� = ? WHERE (����NO = ?) AND (���i�ԍ� = ?) AND " &
    "(���� = ?)"
        Me.SubUpdateCmd.Connection = Me.ocnSample
        Me.SubUpdateCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("����NO", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "����NO", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("���i�ԍ�", System.Data.OleDb.OleDbType.VarWChar, 10, "���i�ԍ�"), New System.Data.OleDb.OleDbParameter("����", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("Original_����NO", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "����NO", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_���i�ԍ�", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���i�ԍ�", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_����", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing)})
        '
        'odaShohin
        '
        Me.odaShohin.DeleteCommand = Me.ShohinDelCmd
        Me.odaShohin.InsertCommand = Me.ShohinInsertCmd
        Me.odaShohin.SelectCommand = Me.ShohinSelCmd
        Me.odaShohin.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_���i", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("���i�ԍ�", "���i�ԍ�"), New System.Data.Common.DataColumnMapping("���i��", "���i��"), New System.Data.Common.DataColumnMapping("�P��", "�P��"), New System.Data.Common.DataColumnMapping("���i�O���[�v", "���i�O���[�v")})})
        Me.odaShohin.UpdateCommand = Me.ShohinUpdateCmd
        '
        'ShohinDelCmd
        '
        Me.ShohinDelCmd.CommandText = "DELETE FROM [T_���i] WHERE (���i�ԍ� = ?) AND (�P�� = ? OR ? IS NULL AND �P�� IS NULL) AND " &
    "([���i�O���[�v] = ? OR ? IS NULL AND [���i�O���[�v] IS NULL) AND (���i�� = ? OR ? IS NULL AND ��" &
    "�i�� IS NULL)"
        Me.ShohinDelCmd.Connection = Me.ocnSample
        Me.ShohinDelCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_���i�ԍ�", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���i�ԍ�", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�P��", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "�P��", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�P��1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "�P��", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_���i�O���[�v", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���i�O���[�v", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_���i�O���[�v1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���i�O���[�v", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_���i��", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���i��", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_���i��1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���i��", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ShohinInsertCmd
        '
        Me.ShohinInsertCmd.CommandText = "INSERT INTO [T_���i] (���i�ԍ�, ���i��, �P��, [���i�O���[�v]) VALUES (?, ?, ?, ?)"
        Me.ShohinInsertCmd.Connection = Me.ocnSample
        Me.ShohinInsertCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("���i�ԍ�", System.Data.OleDb.OleDbType.VarWChar, 10, "���i�ԍ�"), New System.Data.OleDb.OleDbParameter("���i��", System.Data.OleDb.OleDbType.VarWChar, 20, "���i��"), New System.Data.OleDb.OleDbParameter("�P��", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "�P��", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("���i�O���[�v", System.Data.OleDb.OleDbType.VarWChar, 10, "���i�O���[�v")})
        '
        'ShohinSelCmd
        '
        Me.ShohinSelCmd.CommandText = "SELECT ���i�ԍ�, ���i��, �P��, [���i�O���[�v] FROM [T_���i]"
        Me.ShohinSelCmd.Connection = Me.ocnSample
        '
        'ShohinUpdateCmd
        '
        Me.ShohinUpdateCmd.CommandText = resources.GetString("ShohinUpdateCmd.CommandText")
        Me.ShohinUpdateCmd.Connection = Me.ocnSample
        Me.ShohinUpdateCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("���i�ԍ�", System.Data.OleDb.OleDbType.VarWChar, 10, "���i�ԍ�"), New System.Data.OleDb.OleDbParameter("���i��", System.Data.OleDb.OleDbType.VarWChar, 20, "���i��"), New System.Data.OleDb.OleDbParameter("�P��", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "�P��", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("���i�O���[�v", System.Data.OleDb.OleDbType.VarWChar, 10, "���i�O���[�v"), New System.Data.OleDb.OleDbParameter("Original_���i�ԍ�", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���i�ԍ�", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�P��", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "�P��", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�P��1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "�P��", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_���i�O���[�v", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���i�O���[�v", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_���i�O���[�v1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���i�O���[�v", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_���i��", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���i��", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_���i��1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "���i��", System.Data.DataRowVersion.Original, Nothing)})
        '
        'odaShain
        '
        Me.odaShain.DeleteCommand = Me.ShainDelCmd
        Me.odaShain.InsertCommand = Me.ShainInsertCmd
        Me.odaShain.SelectCommand = Me.ShainSelCmd
        Me.odaShain.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_�Ј�", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("�Ј�ID", "�Ј�ID"), New System.Data.Common.DataColumnMapping("����", "����"), New System.Data.Common.DataColumnMapping("�t���K�i", "�t���K�i")})})
        Me.odaShain.UpdateCommand = Me.ShainUpdateCmd
        '
        'ShainDelCmd
        '
        Me.ShainDelCmd.CommandText = "DELETE FROM [T_�Ј�] WHERE (�Ј�ID = ?) AND (�t���K�i = ? OR ? IS NULL AND �t���K�i IS NULL) " &
    "AND (���� = ? OR ? IS NULL AND ���� IS NULL)"
        Me.ShainDelCmd.Connection = Me.ocnSample
        Me.ShainDelCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_�Ј�ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "�Ј�ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�t���K�i", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�t���K�i", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�t���K�i1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�t���K�i", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_����", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_����1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ShainInsertCmd
        '
        Me.ShainInsertCmd.CommandText = "INSERT INTO [T_�Ј�] (�Ј�ID, ����, �t���K�i) VALUES (?, ?, ?)"
        Me.ShainInsertCmd.Connection = Me.ocnSample
        Me.ShainInsertCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("�Ј�ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "�Ј�ID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("����", System.Data.OleDb.OleDbType.VarWChar, 20, "����"), New System.Data.OleDb.OleDbParameter("�t���K�i", System.Data.OleDb.OleDbType.VarWChar, 20, "�t���K�i")})
        '
        'ShainSelCmd
        '
        Me.ShainSelCmd.CommandText = "SELECT �Ј�ID, ����, �t���K�i FROM [T_�Ј�]"
        Me.ShainSelCmd.Connection = Me.ocnSample
        '
        'ShainUpdateCmd
        '
        Me.ShainUpdateCmd.CommandText = "UPDATE [T_�Ј�] SET �Ј�ID = ?, ���� = ?, �t���K�i = ? WHERE (�Ј�ID = ?) AND (�t���K�i = ? OR ? " &
    "IS NULL AND �t���K�i IS NULL) AND (���� = ? OR ? IS NULL AND ���� IS NULL)"
        Me.ShainUpdateCmd.Connection = Me.ocnSample
        Me.ShainUpdateCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("�Ј�ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "�Ј�ID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("����", System.Data.OleDb.OleDbType.VarWChar, 20, "����"), New System.Data.OleDb.OleDbParameter("�t���K�i", System.Data.OleDb.OleDbType.VarWChar, 20, "�t���K�i"), New System.Data.OleDb.OleDbParameter("Original_�Ј�ID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "�Ј�ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�t���K�i", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�t���K�i", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�t���K�i1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�t���K�i", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_����", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_����1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing)})
        '
        'DsSample1
        '
        Me.DsSample1.DataSetName = "dsSample"
        Me.DsSample1.Locale = New System.Globalization.CultureInfo("ja-JP")
        Me.DsSample1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'odaKokyaku
        '
        Me.odaKokyaku.DeleteCommand = Me.KokyakuDelCmd
        Me.odaKokyaku.InsertCommand = Me.KokyakuInsertCmd
        Me.odaKokyaku.SelectCommand = Me.KokyakuSelCmd
        Me.odaKokyaku.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "T_�ڋq", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("�ڋqID", "�ڋqID"), New System.Data.Common.DataColumnMapping("����", "����"), New System.Data.Common.DataColumnMapping("�t���K�i", "�t���K�i"), New System.Data.Common.DataColumnMapping("�X�֔ԍ�", "�X�֔ԍ�"), New System.Data.Common.DataColumnMapping("�s���{��", "�s���{��"), New System.Data.Common.DataColumnMapping("�Z��", "�Z��"), New System.Data.Common.DataColumnMapping("�d�b�ԍ�", "�d�b�ԍ�")})})
        Me.odaKokyaku.UpdateCommand = Me.KokyakuUpdateCmd
        '
        'KokyakuDelCmd
        '
        Me.KokyakuDelCmd.CommandText = resources.GetString("KokyakuDelCmd.CommandText")
        Me.KokyakuDelCmd.Connection = Me.ocnSample
        Me.KokyakuDelCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_�ڋqID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "�ڋqID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�t���K�i", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�t���K�i", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�t���K�i1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�t���K�i", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�Z��", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�Z��", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�Z��1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�Z��", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_����", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_����1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�X�֔ԍ�", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�X�֔ԍ�", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�X�֔ԍ�1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�X�֔ԍ�", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�s���{��", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�s���{��", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�s���{��1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�s���{��", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�d�b�ԍ�", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�d�b�ԍ�", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�d�b�ԍ�1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�d�b�ԍ�", System.Data.DataRowVersion.Original, Nothing)})
        '
        'KokyakuInsertCmd
        '
        Me.KokyakuInsertCmd.CommandText = "INSERT INTO [T_�ڋq] (�ڋqID, ����, �t���K�i, �X�֔ԍ�, �s���{��, �Z��, �d�b�ԍ�) VALUES (?, ?, ?, ?, ?, " &
    "?, ?)"
        Me.KokyakuInsertCmd.Connection = Me.ocnSample
        Me.KokyakuInsertCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("�ڋqID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "�ڋqID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("����", System.Data.OleDb.OleDbType.VarWChar, 20, "����"), New System.Data.OleDb.OleDbParameter("�t���K�i", System.Data.OleDb.OleDbType.VarWChar, 20, "�t���K�i"), New System.Data.OleDb.OleDbParameter("�X�֔ԍ�", System.Data.OleDb.OleDbType.VarWChar, 8, "�X�֔ԍ�"), New System.Data.OleDb.OleDbParameter("�s���{��", System.Data.OleDb.OleDbType.VarWChar, 10, "�s���{��"), New System.Data.OleDb.OleDbParameter("�Z��", System.Data.OleDb.OleDbType.VarWChar, 50, "�Z��"), New System.Data.OleDb.OleDbParameter("�d�b�ԍ�", System.Data.OleDb.OleDbType.VarWChar, 15, "�d�b�ԍ�")})
        '
        'KokyakuSelCmd
        '
        Me.KokyakuSelCmd.CommandText = "SELECT �ڋqID, ����, �t���K�i, �X�֔ԍ�, �s���{��, �Z��, �d�b�ԍ� FROM [T_�ڋq]"
        Me.KokyakuSelCmd.Connection = Me.ocnSample
        '
        'KokyakuUpdateCmd
        '
        Me.KokyakuUpdateCmd.CommandText = resources.GetString("KokyakuUpdateCmd.CommandText")
        Me.KokyakuUpdateCmd.Connection = Me.ocnSample
        Me.KokyakuUpdateCmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("�ڋqID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "�ڋqID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("����", System.Data.OleDb.OleDbType.VarWChar, 20, "����"), New System.Data.OleDb.OleDbParameter("�t���K�i", System.Data.OleDb.OleDbType.VarWChar, 20, "�t���K�i"), New System.Data.OleDb.OleDbParameter("�X�֔ԍ�", System.Data.OleDb.OleDbType.VarWChar, 8, "�X�֔ԍ�"), New System.Data.OleDb.OleDbParameter("�s���{��", System.Data.OleDb.OleDbType.VarWChar, 10, "�s���{��"), New System.Data.OleDb.OleDbParameter("�Z��", System.Data.OleDb.OleDbType.VarWChar, 50, "�Z��"), New System.Data.OleDb.OleDbParameter("�d�b�ԍ�", System.Data.OleDb.OleDbType.VarWChar, 15, "�d�b�ԍ�"), New System.Data.OleDb.OleDbParameter("Original_�ڋqID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "�ڋqID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�t���K�i", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�t���K�i", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�t���K�i1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�t���K�i", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�Z��", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�Z��", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�Z��1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�Z��", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_����", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_����1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "����", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�X�֔ԍ�", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�X�֔ԍ�", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�X�֔ԍ�1", System.Data.OleDb.OleDbType.VarWChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�X�֔ԍ�", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�s���{��", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�s���{��", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�s���{��1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�s���{��", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�d�b�ԍ�", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�d�b�ԍ�", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_�d�b�ԍ�1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "�d�b�ԍ�", System.Data.DataRowVersion.Original, Nothing)})
        '
        'dlgSave
        '
        Me.dlgSave.FileName = "doc1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(736, 505)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "�����Ǘ�"
        CType(Me.DsSample1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    '-----------------------------------
    '�m�`�[���́n���j���[
    '
    Private Sub mnuFileInput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileInput.Click
        '�`�[���̓t�H�[�����J��
        Dim fm As New frmDenpyo()
        fm.MdiParent = Me
        fm.Show()
    End Sub

    '
    '�m�ڋq�����n���j���[
    '
    Private Sub mnuFileFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileFind.Click
        '�ڋq�����t�H�[�����J��
        Dim fm As New frmList()
        fm.MdiParent = Me
        fm.Show()
    End Sub

    '
    '�m�I���n���j���[
    '
    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        '�A�v���P�[�V�������I������
        Application.Exit()
    End Sub

    '-----------------------------------
    '�m���i�o�^�n���j���[
    '
    Private Sub mnuPrepareShohin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrepareShohin.Click
        '���i�o�^�t�H�[�����J��
        Dim fm As New frmShohin()
        fm.MdiParent = Me
        fm.Show()
    End Sub

    '
    '�m�ڋq�o�^�n���j���[
    '
    Private Sub mnuPrepareKokyaku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrepareKokyaku.Click
        '�ڋq�o�^�t�H�[�����J��
        Dim fm As New frmKokyaku()
        fm.MdiParent = Me
        fm.Show()
    End Sub

    '
    '�m�Ј��o�^�n���j���[
    '
    Private Sub mnuPrepareShain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrepareShain.Click
        '�Ј��o�^�t�H�[�����J��
        Dim fm As New frmShain()
        fm.MdiParent = Me
        fm.Show()
    End Sub

End Class
