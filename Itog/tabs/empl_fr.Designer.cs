namespace Itog
{
    partial class empl_fr
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
            System.Windows.Forms.Label id_empLabel;
            System.Windows.Forms.Label fnLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label adrsLabel;
            System.Windows.Forms.Label nmbrLabel;
            System.Windows.Forms.Label psprt_nmbrLabel;
            System.Windows.Forms.Label id_pstionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(empl_fr));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.empDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dJDataSet = new Itog.DJDataSet();
            this.n_ps_comb = new System.Windows.Forms.ComboBox();
            this.pstionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_empTextBox = new System.Windows.Forms.TextBox();
            this.fnTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.sexCheckBox = new System.Windows.Forms.CheckBox();
            this.adrsTextBox = new System.Windows.Forms.TextBox();
            this.nmbrTextBox = new System.Windows.Forms.TextBox();
            this.psprt_nmbrTextBox = new System.Windows.Forms.TextBox();
            this.id_pstionTextBox = new System.Windows.Forms.TextBox();
            this.empTableAdapter = new Itog.DJDataSetTableAdapters.empTableAdapter();
            this.tableAdapterManager = new Itog.DJDataSetTableAdapters.TableAdapterManager();
            this.pstionsTableAdapter = new Itog.DJDataSetTableAdapters.pstionsTableAdapter();
            this.empBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.empBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            id_empLabel = new System.Windows.Forms.Label();
            fnLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            adrsLabel = new System.Windows.Forms.Label();
            nmbrLabel = new System.Windows.Forms.Label();
            psprt_nmbrLabel = new System.Windows.Forms.Label();
            id_pstionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pstionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingNavigator)).BeginInit();
            this.empBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_empLabel
            // 
            id_empLabel.AutoSize = true;
            id_empLabel.Location = new System.Drawing.Point(25, 28);
            id_empLabel.Name = "id_empLabel";
            id_empLabel.Size = new System.Drawing.Size(91, 13);
            id_empLabel.TabIndex = 0;
            id_empLabel.Text = "Код Сотрудника:";
            // 
            // fnLabel
            // 
            fnLabel.AutoSize = true;
            fnLabel.Location = new System.Drawing.Point(25, 54);
            fnLabel.Name = "fnLabel";
            fnLabel.Size = new System.Drawing.Size(30, 13);
            fnLabel.TabIndex = 2;
            fnLabel.Text = "Фио";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(25, 80);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(52, 13);
            ageLabel.TabIndex = 4;
            ageLabel.Text = "Возраст:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(25, 108);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(30, 13);
            sexLabel.TabIndex = 6;
            sexLabel.Text = "Пол:";
            // 
            // adrsLabel
            // 
            adrsLabel.AutoSize = true;
            adrsLabel.Location = new System.Drawing.Point(25, 136);
            adrsLabel.Name = "adrsLabel";
            adrsLabel.Size = new System.Drawing.Size(41, 13);
            adrsLabel.TabIndex = 8;
            adrsLabel.Text = "Адрес:";
            // 
            // nmbrLabel
            // 
            nmbrLabel.AutoSize = true;
            nmbrLabel.Location = new System.Drawing.Point(25, 162);
            nmbrLabel.Name = "nmbrLabel";
            nmbrLabel.Size = new System.Drawing.Size(44, 13);
            nmbrLabel.TabIndex = 10;
            nmbrLabel.Text = "Номер:";
            // 
            // psprt_nmbrLabel
            // 
            psprt_nmbrLabel.AutoSize = true;
            psprt_nmbrLabel.Location = new System.Drawing.Point(25, 188);
            psprt_nmbrLabel.Name = "psprt_nmbrLabel";
            psprt_nmbrLabel.Size = new System.Drawing.Size(114, 13);
            psprt_nmbrLabel.TabIndex = 12;
            psprt_nmbrLabel.Text = "Паспортные данные:";
            // 
            // id_pstionLabel
            // 
            id_pstionLabel.AutoSize = true;
            id_pstionLabel.Location = new System.Drawing.Point(25, 214);
            id_pstionLabel.Name = "id_pstionLabel";
            id_pstionLabel.Size = new System.Drawing.Size(68, 13);
            id_pstionLabel.TabIndex = 14;
            id_pstionLabel.Text = "Должность:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.empDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.n_ps_comb);
            this.splitContainer1.Panel2.Controls.Add(id_empLabel);
            this.splitContainer1.Panel2.Controls.Add(this.id_empTextBox);
            this.splitContainer1.Panel2.Controls.Add(fnLabel);
            this.splitContainer1.Panel2.Controls.Add(this.fnTextBox);
            this.splitContainer1.Panel2.Controls.Add(ageLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ageTextBox);
            this.splitContainer1.Panel2.Controls.Add(sexLabel);
            this.splitContainer1.Panel2.Controls.Add(this.sexCheckBox);
            this.splitContainer1.Panel2.Controls.Add(adrsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.adrsTextBox);
            this.splitContainer1.Panel2.Controls.Add(nmbrLabel);
            this.splitContainer1.Panel2.Controls.Add(this.nmbrTextBox);
            this.splitContainer1.Panel2.Controls.Add(psprt_nmbrLabel);
            this.splitContainer1.Panel2.Controls.Add(this.psprt_nmbrTextBox);
            this.splitContainer1.Panel2.Controls.Add(id_pstionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.id_pstionTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 369);
            this.splitContainer1.SplitterDistance = 829;
            this.splitContainer1.TabIndex = 0;
            // 
            // empDataGridView
            // 
            this.empDataGridView.AutoGenerateColumns = false;
            this.empDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.empDataGridView.DataSource = this.empBindingSource;
            this.empDataGridView.Location = new System.Drawing.Point(0, 28);
            this.empDataGridView.Name = "empDataGridView";
            this.empDataGridView.Size = new System.Drawing.Size(826, 341);
            this.empDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_emp";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код сотрудника";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fn";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фио";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn3.HeaderText = "Возраст";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "sex";
            this.dataGridViewCheckBoxColumn1.FalseValue = "False";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Пол";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.TrueValue = "True";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "adrs";
            this.dataGridViewTextBoxColumn4.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nmbr";
            this.dataGridViewTextBoxColumn5.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "psprt_nmbr";
            this.dataGridViewTextBoxColumn6.HeaderText = "Папотрные данные";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_pstion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Код должности";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // empBindingSource
            // 
            this.empBindingSource.DataMember = "emp";
            this.empBindingSource.DataSource = this.dJDataSet;
            // 
            // dJDataSet
            // 
            this.dJDataSet.DataSetName = "DJDataSet";
            this.dJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // n_ps_comb
            // 
            this.n_ps_comb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.empBindingSource, "id_pstion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.n_ps_comb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empBindingSource, "id_pstion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.n_ps_comb.DataSource = this.pstionsBindingSource;
            this.n_ps_comb.DisplayMember = "pstion_n";
            this.n_ps_comb.FormattingEnabled = true;
            this.n_ps_comb.Location = new System.Drawing.Point(146, 214);
            this.n_ps_comb.Name = "n_ps_comb";
            this.n_ps_comb.Size = new System.Drawing.Size(104, 21);
            this.n_ps_comb.TabIndex = 16;
            this.n_ps_comb.SelectedIndexChanged += new System.EventHandler(this.n_ps_comb_SelectedIndexChanged);
            // 
            // pstionsBindingSource
            // 
            this.pstionsBindingSource.DataMember = "pstions";
            this.pstionsBindingSource.DataSource = this.dJDataSet;
            // 
            // id_empTextBox
            // 
            this.id_empTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empBindingSource, "id_emp", true));
            this.id_empTextBox.Location = new System.Drawing.Point(146, 25);
            this.id_empTextBox.Name = "id_empTextBox";
            this.id_empTextBox.Size = new System.Drawing.Size(104, 20);
            this.id_empTextBox.TabIndex = 1;
            // 
            // fnTextBox
            // 
            this.fnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empBindingSource, "fn", true));
            this.fnTextBox.Location = new System.Drawing.Point(146, 51);
            this.fnTextBox.Name = "fnTextBox";
            this.fnTextBox.Size = new System.Drawing.Size(104, 20);
            this.fnTextBox.TabIndex = 3;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empBindingSource, "age", true));
            this.ageTextBox.Location = new System.Drawing.Point(146, 77);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(104, 20);
            this.ageTextBox.TabIndex = 5;
            // 
            // sexCheckBox
            // 
            this.sexCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.empBindingSource, "sex", true));
            this.sexCheckBox.Location = new System.Drawing.Point(146, 103);
            this.sexCheckBox.Name = "sexCheckBox";
            this.sexCheckBox.Size = new System.Drawing.Size(205, 24);
            this.sexCheckBox.TabIndex = 7;
            this.sexCheckBox.Text = "(Наличе галочки - Муж, иначе Жен)";
            this.sexCheckBox.UseVisualStyleBackColor = true;
            // 
            // adrsTextBox
            // 
            this.adrsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empBindingSource, "adrs", true));
            this.adrsTextBox.Location = new System.Drawing.Point(146, 133);
            this.adrsTextBox.Name = "adrsTextBox";
            this.adrsTextBox.Size = new System.Drawing.Size(104, 20);
            this.adrsTextBox.TabIndex = 9;
            // 
            // nmbrTextBox
            // 
            this.nmbrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empBindingSource, "nmbr", true));
            this.nmbrTextBox.Location = new System.Drawing.Point(146, 159);
            this.nmbrTextBox.Name = "nmbrTextBox";
            this.nmbrTextBox.Size = new System.Drawing.Size(104, 20);
            this.nmbrTextBox.TabIndex = 11;
            // 
            // psprt_nmbrTextBox
            // 
            this.psprt_nmbrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empBindingSource, "psprt_nmbr", true));
            this.psprt_nmbrTextBox.Location = new System.Drawing.Point(146, 185);
            this.psprt_nmbrTextBox.Name = "psprt_nmbrTextBox";
            this.psprt_nmbrTextBox.Size = new System.Drawing.Size(104, 20);
            this.psprt_nmbrTextBox.TabIndex = 13;
            // 
            // id_pstionTextBox
            // 
            this.id_pstionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.id_pstionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_pstionTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.id_pstionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empBindingSource, "id_pstion", true));
            this.id_pstionTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.id_pstionTextBox.Location = new System.Drawing.Point(146, 397);
            this.id_pstionTextBox.Name = "id_pstionTextBox";
            this.id_pstionTextBox.Size = new System.Drawing.Size(104, 13);
            this.id_pstionTextBox.TabIndex = 15;
            // 
            // empTableAdapter
            // 
            this.empTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cmpstnTableAdapter = null;
            this.tableAdapterManager.empTableAdapter = this.empTableAdapter;
            this.tableAdapterManager.gnrsTableAdapter = null;
            this.tableAdapterManager.mscnTableAdapter = null;
            this.tableAdapterManager.pstionsTableAdapter = this.pstionsTableAdapter;
            this.tableAdapterManager.schdlTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Itog.DJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pstionsTableAdapter
            // 
            this.pstionsTableAdapter.ClearBeforeFill = true;
            // 
            // empBindingNavigator
            // 
            this.empBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.empBindingNavigator.BindingSource = this.empBindingSource;
            this.empBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.empBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.empBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.empBindingNavigatorSaveItem});
            this.empBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.empBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.empBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.empBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.empBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.empBindingNavigator.Name = "empBindingNavigator";
            this.empBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.empBindingNavigator.Size = new System.Drawing.Size(1184, 25);
            this.empBindingNavigator.TabIndex = 1;
            this.empBindingNavigator.Text = "bindingNavigator1";
            this.empBindingNavigator.RefreshItems += new System.EventHandler(this.empBindingNavigator_RefreshItems);
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
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
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
            // empBindingNavigatorSaveItem
            // 
            this.empBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.empBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("empBindingNavigatorSaveItem.Image")));
            this.empBindingNavigatorSaveItem.Name = "empBindingNavigatorSaveItem";
            this.empBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.empBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.empBindingNavigatorSaveItem.Click += new System.EventHandler(this.empBindingNavigatorSaveItem_Click);
            // 
            // empl_fr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 369);
            this.Controls.Add(this.empBindingNavigator);
            this.Controls.Add(this.splitContainer1);
            this.Name = "empl_fr";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.empl_fr_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pstionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingNavigator)).EndInit();
            this.empBindingNavigator.ResumeLayout(false);
            this.empBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DJDataSet dJDataSet;
        private System.Windows.Forms.BindingSource empBindingSource;
        private DJDataSetTableAdapters.empTableAdapter empTableAdapter;
        private DJDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator empBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton empBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView empDataGridView;
        private System.Windows.Forms.TextBox id_empTextBox;
        private System.Windows.Forms.TextBox fnTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.CheckBox sexCheckBox;
        private System.Windows.Forms.TextBox adrsTextBox;
        private System.Windows.Forms.TextBox nmbrTextBox;
        private System.Windows.Forms.TextBox psprt_nmbrTextBox;
        private System.Windows.Forms.TextBox id_pstionTextBox;
        private System.Windows.Forms.ComboBox n_ps_comb;
        private DJDataSetTableAdapters.pstionsTableAdapter pstionsTableAdapter;
        private System.Windows.Forms.BindingSource pstionsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}