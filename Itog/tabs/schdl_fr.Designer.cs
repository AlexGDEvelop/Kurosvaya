namespace Itog
{
    partial class schdl_fr
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label id_empLabel;
            System.Windows.Forms.Label time_1Label;
            System.Windows.Forms.Label id_cmpstn_1Label;
            System.Windows.Forms.Label time_2Label;
            System.Windows.Forms.Label id_cmpstn_2Label;
            System.Windows.Forms.Label time_3Label;
            System.Windows.Forms.Label id_cmpstn_3Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(schdl_fr));
            this.dJDataSet = new Itog.DJDataSet();
            this.schdlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schdlTableAdapter = new Itog.DJDataSetTableAdapters.schdlTableAdapter();
            this.tableAdapterManager = new Itog.DJDataSetTableAdapters.TableAdapterManager();
            this.schdlBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.schdlBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.schdlDataGridView = new System.Windows.Forms.DataGridView();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_empTextBox = new System.Windows.Forms.TextBox();
            this.time_1DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_cmpstn_1TextBox = new System.Windows.Forms.TextBox();
            this.time_2DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_cmpstn_2TextBox = new System.Windows.Forms.TextBox();
            this.time_3DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_cmpstn_3TextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dateLabel = new System.Windows.Forms.Label();
            id_empLabel = new System.Windows.Forms.Label();
            time_1Label = new System.Windows.Forms.Label();
            id_cmpstn_1Label = new System.Windows.Forms.Label();
            time_2Label = new System.Windows.Forms.Label();
            id_cmpstn_2Label = new System.Windows.Forms.Label();
            time_3Label = new System.Windows.Forms.Label();
            id_cmpstn_3Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schdlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schdlBindingNavigator)).BeginInit();
            this.schdlBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schdlDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(680, 28);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(36, 13);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Дата:";
            // 
            // id_empLabel
            // 
            id_empLabel.AutoSize = true;
            id_empLabel.Location = new System.Drawing.Point(680, 53);
            id_empLabel.Name = "id_empLabel";
            id_empLabel.Size = new System.Drawing.Size(63, 13);
            id_empLabel.TabIndex = 4;
            id_empLabel.Text = "Сотрудник:";
            // 
            // time_1Label
            // 
            time_1Label.AutoSize = true;
            time_1Label.Location = new System.Drawing.Point(680, 80);
            time_1Label.Name = "time_1Label";
            time_1Label.Size = new System.Drawing.Size(52, 13);
            time_1Label.TabIndex = 6;
            time_1Label.Text = "Время 1:";
            // 
            // id_cmpstn_1Label
            // 
            id_cmpstn_1Label.AutoSize = true;
            id_cmpstn_1Label.Location = new System.Drawing.Point(680, 105);
            id_cmpstn_1Label.Name = "id_cmpstn_1Label";
            id_cmpstn_1Label.Size = new System.Drawing.Size(56, 13);
            id_cmpstn_1Label.TabIndex = 8;
            id_cmpstn_1Label.Text = "Запись 1:";
            // 
            // time_2Label
            // 
            time_2Label.AutoSize = true;
            time_2Label.Location = new System.Drawing.Point(680, 132);
            time_2Label.Name = "time_2Label";
            time_2Label.Size = new System.Drawing.Size(52, 13);
            time_2Label.TabIndex = 10;
            time_2Label.Text = "Время 2:";
            // 
            // id_cmpstn_2Label
            // 
            id_cmpstn_2Label.AutoSize = true;
            id_cmpstn_2Label.Location = new System.Drawing.Point(680, 157);
            id_cmpstn_2Label.Name = "id_cmpstn_2Label";
            id_cmpstn_2Label.Size = new System.Drawing.Size(56, 13);
            id_cmpstn_2Label.TabIndex = 12;
            id_cmpstn_2Label.Text = "Запись 2:";
            // 
            // time_3Label
            // 
            time_3Label.AutoSize = true;
            time_3Label.Location = new System.Drawing.Point(680, 184);
            time_3Label.Name = "time_3Label";
            time_3Label.Size = new System.Drawing.Size(52, 13);
            time_3Label.TabIndex = 14;
            time_3Label.Text = "Время 3:";
            // 
            // id_cmpstn_3Label
            // 
            id_cmpstn_3Label.AutoSize = true;
            id_cmpstn_3Label.Location = new System.Drawing.Point(680, 209);
            id_cmpstn_3Label.Name = "id_cmpstn_3Label";
            id_cmpstn_3Label.Size = new System.Drawing.Size(56, 13);
            id_cmpstn_3Label.TabIndex = 16;
            id_cmpstn_3Label.Text = "Запись 3:";
            // 
            // dJDataSet
            // 
            this.dJDataSet.DataSetName = "DJDataSet";
            this.dJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schdlBindingSource
            // 
            this.schdlBindingSource.DataMember = "schdl";
            this.schdlBindingSource.DataSource = this.dJDataSet;
            // 
            // schdlTableAdapter
            // 
            this.schdlTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cmpstnTableAdapter = null;
            this.tableAdapterManager.empTableAdapter = null;
            this.tableAdapterManager.gnrsTableAdapter = null;
            this.tableAdapterManager.mscnTableAdapter = null;
            this.tableAdapterManager.pstionsTableAdapter = null;
            this.tableAdapterManager.schdlTableAdapter = this.schdlTableAdapter;
            this.tableAdapterManager.UpdateOrder = Itog.DJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // schdlBindingNavigator
            // 
            this.schdlBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.schdlBindingNavigator.BindingSource = this.schdlBindingSource;
            this.schdlBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.schdlBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.schdlBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.schdlBindingNavigatorSaveItem});
            this.schdlBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.schdlBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.schdlBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.schdlBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.schdlBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.schdlBindingNavigator.Name = "schdlBindingNavigator";
            this.schdlBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.schdlBindingNavigator.Size = new System.Drawing.Size(877, 25);
            this.schdlBindingNavigator.TabIndex = 0;
            this.schdlBindingNavigator.Text = "bindingNavigator1";
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
            // schdlBindingNavigatorSaveItem
            // 
            this.schdlBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.schdlBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("schdlBindingNavigatorSaveItem.Image")));
            this.schdlBindingNavigatorSaveItem.Name = "schdlBindingNavigatorSaveItem";
            this.schdlBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.schdlBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.schdlBindingNavigatorSaveItem.Click += new System.EventHandler(this.schdlBindingNavigatorSaveItem_Click);
            // 
            // schdlDataGridView
            // 
            this.schdlDataGridView.AutoGenerateColumns = false;
            this.schdlDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schdlDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.schdlDataGridView.DataSource = this.schdlBindingSource;
            this.schdlDataGridView.Location = new System.Drawing.Point(12, 28);
            this.schdlDataGridView.Name = "schdlDataGridView";
            this.schdlDataGridView.Size = new System.Drawing.Size(662, 231);
            this.schdlDataGridView.TabIndex = 1;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.schdlBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(750, 24);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.dateDateTimePicker.TabIndex = 3;
            // 
            // id_empTextBox
            // 
            this.id_empTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schdlBindingSource, "id_emp", true));
            this.id_empTextBox.Location = new System.Drawing.Point(750, 50);
            this.id_empTextBox.Name = "id_empTextBox";
            this.id_empTextBox.Size = new System.Drawing.Size(120, 20);
            this.id_empTextBox.TabIndex = 5;
            // 
            // time_1DateTimePicker
            // 
            this.time_1DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.schdlBindingSource, "time_1", true));
            this.time_1DateTimePicker.Location = new System.Drawing.Point(750, 76);
            this.time_1DateTimePicker.Name = "time_1DateTimePicker";
            this.time_1DateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.time_1DateTimePicker.TabIndex = 7;
            // 
            // id_cmpstn_1TextBox
            // 
            this.id_cmpstn_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schdlBindingSource, "id_cmpstn_1", true));
            this.id_cmpstn_1TextBox.Location = new System.Drawing.Point(750, 102);
            this.id_cmpstn_1TextBox.Name = "id_cmpstn_1TextBox";
            this.id_cmpstn_1TextBox.Size = new System.Drawing.Size(120, 20);
            this.id_cmpstn_1TextBox.TabIndex = 9;
            // 
            // time_2DateTimePicker
            // 
            this.time_2DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.schdlBindingSource, "time_2", true));
            this.time_2DateTimePicker.Location = new System.Drawing.Point(750, 128);
            this.time_2DateTimePicker.Name = "time_2DateTimePicker";
            this.time_2DateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.time_2DateTimePicker.TabIndex = 11;
            // 
            // id_cmpstn_2TextBox
            // 
            this.id_cmpstn_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schdlBindingSource, "id_cmpstn_2", true));
            this.id_cmpstn_2TextBox.Location = new System.Drawing.Point(750, 154);
            this.id_cmpstn_2TextBox.Name = "id_cmpstn_2TextBox";
            this.id_cmpstn_2TextBox.Size = new System.Drawing.Size(120, 20);
            this.id_cmpstn_2TextBox.TabIndex = 13;
            // 
            // time_3DateTimePicker
            // 
            this.time_3DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.schdlBindingSource, "time_3", true));
            this.time_3DateTimePicker.Location = new System.Drawing.Point(750, 180);
            this.time_3DateTimePicker.Name = "time_3DateTimePicker";
            this.time_3DateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.time_3DateTimePicker.TabIndex = 15;
            // 
            // id_cmpstn_3TextBox
            // 
            this.id_cmpstn_3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.schdlBindingSource, "id_cmpstn_3", true));
            this.id_cmpstn_3TextBox.Location = new System.Drawing.Point(750, 206);
            this.id_cmpstn_3TextBox.Name = "id_cmpstn_3TextBox";
            this.id_cmpstn_3TextBox.Size = new System.Drawing.Size(120, 20);
            this.id_cmpstn_3TextBox.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn1.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 58;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_emp";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код сотрудника";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 103;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "time_1";
            this.dataGridViewTextBoxColumn3.HeaderText = "Время 1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 69;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_cmpstn_1";
            this.dataGridViewTextBoxColumn4.HeaderText = "Код записи 1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 83;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "time_2";
            this.dataGridViewTextBoxColumn5.HeaderText = "Время 2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 69;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_cmpstn_2";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код записи 2";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 83;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "time_3";
            this.dataGridViewTextBoxColumn7.HeaderText = "Время 3";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 69;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id_cmpstn_3";
            this.dataGridViewTextBoxColumn8.HeaderText = "Код записи 3";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 83;
            // 
            // schdl_fr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 271);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(id_empLabel);
            this.Controls.Add(this.id_empTextBox);
            this.Controls.Add(time_1Label);
            this.Controls.Add(this.time_1DateTimePicker);
            this.Controls.Add(id_cmpstn_1Label);
            this.Controls.Add(this.id_cmpstn_1TextBox);
            this.Controls.Add(time_2Label);
            this.Controls.Add(this.time_2DateTimePicker);
            this.Controls.Add(id_cmpstn_2Label);
            this.Controls.Add(this.id_cmpstn_2TextBox);
            this.Controls.Add(time_3Label);
            this.Controls.Add(this.time_3DateTimePicker);
            this.Controls.Add(id_cmpstn_3Label);
            this.Controls.Add(this.id_cmpstn_3TextBox);
            this.Controls.Add(this.schdlDataGridView);
            this.Controls.Add(this.schdlBindingNavigator);
            this.Name = "schdl_fr";
            this.Text = "schdl_fr";
            this.Load += new System.EventHandler(this.schdl_fr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schdlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schdlBindingNavigator)).EndInit();
            this.schdlBindingNavigator.ResumeLayout(false);
            this.schdlBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schdlDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DJDataSet dJDataSet;
        private System.Windows.Forms.BindingSource schdlBindingSource;
        private DJDataSetTableAdapters.schdlTableAdapter schdlTableAdapter;
        private DJDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator schdlBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton schdlBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView schdlDataGridView;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox id_empTextBox;
        private System.Windows.Forms.DateTimePicker time_1DateTimePicker;
        private System.Windows.Forms.TextBox id_cmpstn_1TextBox;
        private System.Windows.Forms.DateTimePicker time_2DateTimePicker;
        private System.Windows.Forms.TextBox id_cmpstn_2TextBox;
        private System.Windows.Forms.DateTimePicker time_3DateTimePicker;
        private System.Windows.Forms.TextBox id_cmpstn_3TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}