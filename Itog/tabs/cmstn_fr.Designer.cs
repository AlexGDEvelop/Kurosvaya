namespace Itog
{
    partial class cmstn_fr
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_cmpstnLabel;
            System.Windows.Forms.Label cmpstn_nLabel;
            System.Windows.Forms.Label id_mscnLabel;
            System.Windows.Forms.Label albumLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label id_gnrLabel;
            System.Windows.Forms.Label rec_dateLabel;
            System.Windows.Forms.Label lenghtLabel;
            System.Windows.Forms.Label ratingLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cmstn_fr));
            this.dJDataSet = new Itog.DJDataSet();
            this.cmpstnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmpstnTableAdapter = new Itog.DJDataSetTableAdapters.cmpstnTableAdapter();
            this.tableAdapterManager = new Itog.DJDataSetTableAdapters.TableAdapterManager();
            this.cmpstnBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmpstnBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cmpstnDataGridView = new System.Windows.Forms.DataGridView();
            this.id_cmpstnTextBox = new System.Windows.Forms.TextBox();
            this.cmpstn_nTextBox = new System.Windows.Forms.TextBox();
            this.id_mscnTextBox = new System.Windows.Forms.TextBox();
            this.albumTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.id_gnrTextBox = new System.Windows.Forms.TextBox();
            this.rec_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lenghtTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_cmpstnLabel = new System.Windows.Forms.Label();
            cmpstn_nLabel = new System.Windows.Forms.Label();
            id_mscnLabel = new System.Windows.Forms.Label();
            albumLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            id_gnrLabel = new System.Windows.Forms.Label();
            rec_dateLabel = new System.Windows.Forms.Label();
            lenghtLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmpstnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmpstnBindingNavigator)).BeginInit();
            this.cmpstnBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmpstnDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_cmpstnLabel
            // 
            id_cmpstnLabel.AutoSize = true;
            id_cmpstnLabel.Location = new System.Drawing.Point(837, 28);
            id_cmpstnLabel.Name = "id_cmpstnLabel";
            id_cmpstnLabel.Size = new System.Drawing.Size(68, 13);
            id_cmpstnLabel.TabIndex = 2;
            id_cmpstnLabel.Text = "Код записи:";
            id_cmpstnLabel.Click += new System.EventHandler(this.id_cmpstnLabel_Click);
            // 
            // cmpstn_nLabel
            // 
            cmpstn_nLabel.AutoSize = true;
            cmpstn_nLabel.Location = new System.Drawing.Point(837, 54);
            cmpstn_nLabel.Name = "cmpstn_nLabel";
            cmpstn_nLabel.Size = new System.Drawing.Size(86, 13);
            cmpstn_nLabel.TabIndex = 4;
            cmpstn_nLabel.Text = "Наименование:";
            // 
            // id_mscnLabel
            // 
            id_mscnLabel.AutoSize = true;
            id_mscnLabel.Location = new System.Drawing.Point(837, 80);
            id_mscnLabel.Name = "id_mscnLabel";
            id_mscnLabel.Size = new System.Drawing.Size(77, 13);
            id_mscnLabel.TabIndex = 6;
            id_mscnLabel.Text = "Исполнитель:";
            // 
            // albumLabel
            // 
            albumLabel.AutoSize = true;
            albumLabel.Location = new System.Drawing.Point(837, 106);
            albumLabel.Name = "albumLabel";
            albumLabel.Size = new System.Drawing.Size(49, 13);
            albumLabel.TabIndex = 8;
            albumLabel.Text = "Альбом:";
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(837, 132);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(28, 13);
            yearLabel.TabIndex = 10;
            yearLabel.Text = "Год:";
            // 
            // id_gnrLabel
            // 
            id_gnrLabel.AutoSize = true;
            id_gnrLabel.Location = new System.Drawing.Point(837, 158);
            id_gnrLabel.Name = "id_gnrLabel";
            id_gnrLabel.Size = new System.Drawing.Size(39, 13);
            id_gnrLabel.TabIndex = 12;
            id_gnrLabel.Text = "Жанр:";
            // 
            // rec_dateLabel
            // 
            rec_dateLabel.AutoSize = true;
            rec_dateLabel.Location = new System.Drawing.Point(837, 185);
            rec_dateLabel.Name = "rec_dateLabel";
            rec_dateLabel.Size = new System.Drawing.Size(75, 13);
            rec_dateLabel.TabIndex = 14;
            rec_dateLabel.Text = "Дата записи:";
            // 
            // lenghtLabel
            // 
            lenghtLabel.AutoSize = true;
            lenghtLabel.Location = new System.Drawing.Point(837, 210);
            lenghtLabel.Name = "lenghtLabel";
            lenghtLabel.Size = new System.Drawing.Size(114, 13);
            lenghtLabel.TabIndex = 16;
            lenghtLabel.Text = "Продолжительность:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(837, 236);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(48, 13);
            ratingLabel.TabIndex = 18;
            ratingLabel.Text = "Рейтинг";
            // 
            // dJDataSet
            // 
            this.dJDataSet.DataSetName = "DJDataSet";
            this.dJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmpstnBindingSource
            // 
            this.cmpstnBindingSource.DataMember = "cmpstn";
            this.cmpstnBindingSource.DataSource = this.dJDataSet;
            // 
            // cmpstnTableAdapter
            // 
            this.cmpstnTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cmpstnTableAdapter = this.cmpstnTableAdapter;
            this.tableAdapterManager.empTableAdapter = null;
            this.tableAdapterManager.gnrsTableAdapter = null;
            this.tableAdapterManager.mscnTableAdapter = null;
            this.tableAdapterManager.pstionsTableAdapter = null;
            this.tableAdapterManager.schdlTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Itog.DJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmpstnBindingNavigator
            // 
            this.cmpstnBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cmpstnBindingNavigator.BindingSource = this.cmpstnBindingSource;
            this.cmpstnBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cmpstnBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cmpstnBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cmpstnBindingNavigatorSaveItem});
            this.cmpstnBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cmpstnBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cmpstnBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cmpstnBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cmpstnBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cmpstnBindingNavigator.Name = "cmpstnBindingNavigator";
            this.cmpstnBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cmpstnBindingNavigator.Size = new System.Drawing.Size(1105, 25);
            this.cmpstnBindingNavigator.TabIndex = 0;
            this.cmpstnBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cmpstnBindingNavigatorSaveItem
            // 
            this.cmpstnBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmpstnBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cmpstnBindingNavigatorSaveItem.Image")));
            this.cmpstnBindingNavigatorSaveItem.Name = "cmpstnBindingNavigatorSaveItem";
            this.cmpstnBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cmpstnBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.cmpstnBindingNavigatorSaveItem.Click += new System.EventHandler(this.cmpstnBindingNavigatorSaveItem_Click);
            // 
            // cmpstnDataGridView
            // 
            this.cmpstnDataGridView.AutoGenerateColumns = false;
            this.cmpstnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cmpstnDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.cmpstnDataGridView.DataSource = this.cmpstnBindingSource;
            this.cmpstnDataGridView.Location = new System.Drawing.Point(0, 28);
            this.cmpstnDataGridView.Name = "cmpstnDataGridView";
            this.cmpstnDataGridView.Size = new System.Drawing.Size(831, 221);
            this.cmpstnDataGridView.TabIndex = 1;
            this.cmpstnDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cmpstnDataGridView_CellContentClick);
            // 
            // id_cmpstnTextBox
            // 
            this.id_cmpstnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cmpstnBindingSource, "id_cmpstn", true));
            this.id_cmpstnTextBox.Location = new System.Drawing.Point(955, 25);
            this.id_cmpstnTextBox.Name = "id_cmpstnTextBox";
            this.id_cmpstnTextBox.Size = new System.Drawing.Size(140, 20);
            this.id_cmpstnTextBox.TabIndex = 3;
            // 
            // cmpstn_nTextBox
            // 
            this.cmpstn_nTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cmpstnBindingSource, "cmpstn_n", true));
            this.cmpstn_nTextBox.Location = new System.Drawing.Point(955, 51);
            this.cmpstn_nTextBox.Name = "cmpstn_nTextBox";
            this.cmpstn_nTextBox.Size = new System.Drawing.Size(140, 20);
            this.cmpstn_nTextBox.TabIndex = 5;
            // 
            // id_mscnTextBox
            // 
            this.id_mscnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cmpstnBindingSource, "id_mscn", true));
            this.id_mscnTextBox.Location = new System.Drawing.Point(955, 77);
            this.id_mscnTextBox.Name = "id_mscnTextBox";
            this.id_mscnTextBox.Size = new System.Drawing.Size(140, 20);
            this.id_mscnTextBox.TabIndex = 7;
            // 
            // albumTextBox
            // 
            this.albumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cmpstnBindingSource, "album", true));
            this.albumTextBox.Location = new System.Drawing.Point(955, 103);
            this.albumTextBox.Name = "albumTextBox";
            this.albumTextBox.Size = new System.Drawing.Size(140, 20);
            this.albumTextBox.TabIndex = 9;
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cmpstnBindingSource, "year", true));
            this.yearTextBox.Location = new System.Drawing.Point(955, 129);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(140, 20);
            this.yearTextBox.TabIndex = 11;
            // 
            // id_gnrTextBox
            // 
            this.id_gnrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cmpstnBindingSource, "id_gnr", true));
            this.id_gnrTextBox.Location = new System.Drawing.Point(955, 155);
            this.id_gnrTextBox.Name = "id_gnrTextBox";
            this.id_gnrTextBox.Size = new System.Drawing.Size(140, 20);
            this.id_gnrTextBox.TabIndex = 13;
            // 
            // rec_dateDateTimePicker
            // 
            this.rec_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cmpstnBindingSource, "rec_date", true));
            this.rec_dateDateTimePicker.Location = new System.Drawing.Point(955, 181);
            this.rec_dateDateTimePicker.Name = "rec_dateDateTimePicker";
            this.rec_dateDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.rec_dateDateTimePicker.TabIndex = 15;
            // 
            // lenghtTextBox
            // 
            this.lenghtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cmpstnBindingSource, "lenght", true));
            this.lenghtTextBox.Location = new System.Drawing.Point(955, 207);
            this.lenghtTextBox.Name = "lenghtTextBox";
            this.lenghtTextBox.Size = new System.Drawing.Size(140, 20);
            this.lenghtTextBox.TabIndex = 17;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cmpstnBindingSource, "rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(955, 233);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(140, 20);
            this.ratingTextBox.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_cmpstn";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код записи";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 71;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cmpstn_n";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 108;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_mscn";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код исполнителя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 109;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "album";
            this.dataGridViewTextBoxColumn4.HeaderText = "Альбом";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 71;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "year";
            this.dataGridViewTextBoxColumn5.HeaderText = "Год";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_gnr";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код жанра";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 79;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "rec_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата записи";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 89;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "lenght";
            this.dataGridViewTextBoxColumn8.HeaderText = "Продолжительность";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 136;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "rating";
            this.dataGridViewTextBoxColumn9.HeaderText = "Рейтинг";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 73;
            // 
            // cmstn_fr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 259);
            this.Controls.Add(id_cmpstnLabel);
            this.Controls.Add(this.id_cmpstnTextBox);
            this.Controls.Add(cmpstn_nLabel);
            this.Controls.Add(this.cmpstn_nTextBox);
            this.Controls.Add(id_mscnLabel);
            this.Controls.Add(this.id_mscnTextBox);
            this.Controls.Add(albumLabel);
            this.Controls.Add(this.albumTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(id_gnrLabel);
            this.Controls.Add(this.id_gnrTextBox);
            this.Controls.Add(rec_dateLabel);
            this.Controls.Add(this.rec_dateDateTimePicker);
            this.Controls.Add(lenghtLabel);
            this.Controls.Add(this.lenghtTextBox);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.cmpstnDataGridView);
            this.Controls.Add(this.cmpstnBindingNavigator);
            this.Name = "cmstn_fr";
            this.Text = "cmstn_fr";
            this.Load += new System.EventHandler(this.cmstn_fr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmpstnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmpstnBindingNavigator)).EndInit();
            this.cmpstnBindingNavigator.ResumeLayout(false);
            this.cmpstnBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmpstnDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DJDataSet dJDataSet;
        private System.Windows.Forms.BindingSource cmpstnBindingSource;
        private DJDataSetTableAdapters.cmpstnTableAdapter cmpstnTableAdapter;
        private DJDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cmpstnBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cmpstnBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cmpstnDataGridView;
        private System.Windows.Forms.TextBox id_cmpstnTextBox;
        private System.Windows.Forms.TextBox cmpstn_nTextBox;
        private System.Windows.Forms.TextBox id_mscnTextBox;
        private System.Windows.Forms.TextBox albumTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox id_gnrTextBox;
        private System.Windows.Forms.DateTimePicker rec_dateDateTimePicker;
        private System.Windows.Forms.TextBox lenghtTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}