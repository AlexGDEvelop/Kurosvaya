namespace Itog.querys
{
    partial class query2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(query2));
            this.dJDataSet = new Itog.DJDataSet();
            this.queryNetVeschBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queryNetVeschTableAdapter = new Itog.DJDataSetTableAdapters.QueryNetVeschTableAdapter();
            this.tableAdapterManager = new Itog.DJDataSetTableAdapters.TableAdapterManager();
            this.queryNetVeschBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.queryNetVeschBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.queryNetVeschDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel_filer_btn = new System.Windows.Forms.Button();
            this.filter_btn = new System.Windows.Forms.Button();
            this.gnrs_comb = new System.Windows.Forms.ComboBox();
            this.mscn_comb = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empTableAdapter = new Itog.DJDataSetTableAdapters.empTableAdapter();
            this.schdlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schdlTableAdapter = new Itog.DJDataSetTableAdapters.schdlTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryNetVeschBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryNetVeschBindingNavigator)).BeginInit();
            this.queryNetVeschBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryNetVeschDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schdlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dJDataSet
            // 
            this.dJDataSet.DataSetName = "DJDataSet";
            this.dJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // queryNetVeschBindingSource
            // 
            this.queryNetVeschBindingSource.DataMember = "QueryNetVesch";
            this.queryNetVeschBindingSource.DataSource = this.dJDataSet;
            // 
            // queryNetVeschTableAdapter
            // 
            this.queryNetVeschTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cmpstnTableAdapter = null;
            this.tableAdapterManager.empTableAdapter = this.empTableAdapter;
            this.tableAdapterManager.gnrsTableAdapter = null;
            this.tableAdapterManager.mscnTableAdapter = null;
            this.tableAdapterManager.pstionsTableAdapter = null;
            this.tableAdapterManager.schdlTableAdapter = this.schdlTableAdapter;
            this.tableAdapterManager.UpdateOrder = Itog.DJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // queryNetVeschBindingNavigator
            // 
            this.queryNetVeschBindingNavigator.AddNewItem = null;
            this.queryNetVeschBindingNavigator.BindingSource = this.queryNetVeschBindingSource;
            this.queryNetVeschBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.queryNetVeschBindingNavigator.DeleteItem = null;
            this.queryNetVeschBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.queryNetVeschBindingNavigatorSaveItem});
            this.queryNetVeschBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.queryNetVeschBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.queryNetVeschBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.queryNetVeschBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.queryNetVeschBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.queryNetVeschBindingNavigator.Name = "queryNetVeschBindingNavigator";
            this.queryNetVeschBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.queryNetVeschBindingNavigator.Size = new System.Drawing.Size(869, 25);
            this.queryNetVeschBindingNavigator.TabIndex = 0;
            this.queryNetVeschBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // queryNetVeschBindingNavigatorSaveItem
            // 
            this.queryNetVeschBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.queryNetVeschBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("queryNetVeschBindingNavigatorSaveItem.Image")));
            this.queryNetVeschBindingNavigatorSaveItem.Name = "queryNetVeschBindingNavigatorSaveItem";
            this.queryNetVeschBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.queryNetVeschBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.queryNetVeschBindingNavigatorSaveItem.ToolTipText = "Сгенерировать отчет";
            this.queryNetVeschBindingNavigatorSaveItem.Click += new System.EventHandler(this.queryNetVeschBindingNavigatorSaveItem_Click);
            // 
            // queryNetVeschDataGridView
            // 
            this.queryNetVeschDataGridView.AllowUserToAddRows = false;
            this.queryNetVeschDataGridView.AllowUserToDeleteRows = false;
            this.queryNetVeschDataGridView.AutoGenerateColumns = false;
            this.queryNetVeschDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryNetVeschDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.queryNetVeschDataGridView.DataSource = this.queryNetVeschBindingSource;
            this.queryNetVeschDataGridView.Location = new System.Drawing.Point(12, 32);
            this.queryNetVeschDataGridView.Name = "queryNetVeschDataGridView";
            this.queryNetVeschDataGridView.ReadOnly = true;
            this.queryNetVeschDataGridView.Size = new System.Drawing.Size(845, 406);
            this.queryNetVeschDataGridView.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(354, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "  Сотрудник,выбр";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "   Дата, выбрать";
            // 
            // cancel_filer_btn
            // 
            this.cancel_filer_btn.Location = new System.Drawing.Point(568, 5);
            this.cancel_filer_btn.Name = "cancel_filer_btn";
            this.cancel_filer_btn.Size = new System.Drawing.Size(121, 20);
            this.cancel_filer_btn.TabIndex = 11;
            this.cancel_filer_btn.Text = "Отмена фильтрации";
            this.cancel_filer_btn.UseVisualStyleBackColor = true;
            this.cancel_filer_btn.Click += new System.EventHandler(this.cancel_filer_btn_Click);
            // 
            // filter_btn
            // 
            this.filter_btn.Location = new System.Drawing.Point(472, 5);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Size = new System.Drawing.Size(90, 20);
            this.filter_btn.TabIndex = 10;
            this.filter_btn.Text = "Отфильровать";
            this.filter_btn.UseVisualStyleBackColor = true;
            this.filter_btn.Click += new System.EventHandler(this.filter_btn_Click);
            // 
            // gnrs_comb
            // 
            this.gnrs_comb.DataSource = this.empBindingSource;
            this.gnrs_comb.DisplayMember = "fn";
            this.gnrs_comb.FormattingEnabled = true;
            this.gnrs_comb.Location = new System.Drawing.Point(354, 5);
            this.gnrs_comb.Name = "gnrs_comb";
            this.gnrs_comb.Size = new System.Drawing.Size(112, 21);
            this.gnrs_comb.TabIndex = 9;
            this.gnrs_comb.SelectedIndexChanged += new System.EventHandler(this.gnrs_comb_SelectedIndexChanged);
            this.gnrs_comb.Click += new System.EventHandler(this.gnrs_comb_Click);
            // 
            // mscn_comb
            // 
            this.mscn_comb.DataSource = this.schdlBindingSource;
            this.mscn_comb.DisplayMember = "date";
            this.mscn_comb.FormattingEnabled = true;
            this.mscn_comb.Location = new System.Drawing.Point(236, 5);
            this.mscn_comb.Name = "mscn_comb";
            this.mscn_comb.Size = new System.Drawing.Size(112, 21);
            this.mscn_comb.TabIndex = 8;
            this.mscn_comb.SelectedIndexChanged += new System.EventHandler(this.mscn_comb_SelectedIndexChanged);
            this.mscn_comb.Click += new System.EventHandler(this.mscn_comb_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn1.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fn";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "time_1";
            this.dataGridViewTextBoxColumn3.HeaderText = "Время 1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "n_comp_1";
            this.dataGridViewTextBoxColumn4.HeaderText = "Запись 1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "time_2";
            this.dataGridViewTextBoxColumn5.HeaderText = "Время 2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "n_comp_2";
            this.dataGridViewTextBoxColumn6.HeaderText = "Запись 2";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "time_3";
            this.dataGridViewTextBoxColumn7.HeaderText = "Время 3";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "n_comp_3";
            this.dataGridViewTextBoxColumn8.HeaderText = "Запись 3";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // empBindingSource
            // 
            this.empBindingSource.DataMember = "emp";
            this.empBindingSource.DataSource = this.dJDataSet;
            // 
            // empTableAdapter
            // 
            this.empTableAdapter.ClearBeforeFill = true;
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
            // query2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_filer_btn);
            this.Controls.Add(this.filter_btn);
            this.Controls.Add(this.gnrs_comb);
            this.Controls.Add(this.mscn_comb);
            this.Controls.Add(this.queryNetVeschDataGridView);
            this.Controls.Add(this.queryNetVeschBindingNavigator);
            this.Name = "query2";
            this.Text = "Сетка вещания ";
            this.Load += new System.EventHandler(this.query2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryNetVeschBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryNetVeschBindingNavigator)).EndInit();
            this.queryNetVeschBindingNavigator.ResumeLayout(false);
            this.queryNetVeschBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryNetVeschDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schdlBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DJDataSet dJDataSet;
        private System.Windows.Forms.BindingSource queryNetVeschBindingSource;
        private DJDataSetTableAdapters.QueryNetVeschTableAdapter queryNetVeschTableAdapter;
        private DJDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator queryNetVeschBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton queryNetVeschBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView queryNetVeschDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel_filer_btn;
        private System.Windows.Forms.Button filter_btn;
        private System.Windows.Forms.ComboBox gnrs_comb;
        private System.Windows.Forms.ComboBox mscn_comb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DJDataSetTableAdapters.empTableAdapter empTableAdapter;
        private System.Windows.Forms.BindingSource empBindingSource;
        private DJDataSetTableAdapters.schdlTableAdapter schdlTableAdapter;
        private System.Windows.Forms.BindingSource schdlBindingSource;
    }
}