namespace Itog.querys
{
    partial class query1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(query1));
            this.queryMusArchBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.queryMusArchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dJDataSet = new Itog.DJDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.queryMusArchBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.queryMusArchDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mscn_comb = new System.Windows.Forms.ComboBox();
            this.mscnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gnrs_comb = new System.Windows.Forms.ComboBox();
            this.gnrsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filter_btn = new System.Windows.Forms.Button();
            this.cancel_filer_btn = new System.Windows.Forms.Button();
            this.queryMusArchTableAdapter = new Itog.DJDataSetTableAdapters.QueryMusArchTableAdapter();
            this.tableAdapterManager = new Itog.DJDataSetTableAdapters.TableAdapterManager();
            this.mscnTableAdapter = new Itog.DJDataSetTableAdapters.mscnTableAdapter();
            this.gnrsTableAdapter = new Itog.DJDataSetTableAdapters.gnrsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.queryMusArchBindingNavigator)).BeginInit();
            this.queryMusArchBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryMusArchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryMusArchDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mscnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnrsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // queryMusArchBindingNavigator
            // 
            this.queryMusArchBindingNavigator.AddNewItem = null;
            this.queryMusArchBindingNavigator.BindingSource = this.queryMusArchBindingSource;
            this.queryMusArchBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.queryMusArchBindingNavigator.DeleteItem = null;
            this.queryMusArchBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.queryMusArchBindingNavigatorSaveItem});
            this.queryMusArchBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.queryMusArchBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.queryMusArchBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.queryMusArchBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.queryMusArchBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.queryMusArchBindingNavigator.Name = "queryMusArchBindingNavigator";
            this.queryMusArchBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.queryMusArchBindingNavigator.Size = new System.Drawing.Size(875, 25);
            this.queryMusArchBindingNavigator.TabIndex = 0;
            this.queryMusArchBindingNavigator.Text = "bindingNavigator1";
            this.queryMusArchBindingNavigator.RefreshItems += new System.EventHandler(this.queryMusArchBindingNavigator_RefreshItems);
            // 
            // queryMusArchBindingSource
            // 
            this.queryMusArchBindingSource.DataMember = "QueryMusArch";
            this.queryMusArchBindingSource.DataSource = this.dJDataSet;
            // 
            // dJDataSet
            // 
            this.dJDataSet.DataSetName = "DJDataSet";
            this.dJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // queryMusArchBindingNavigatorSaveItem
            // 
            this.queryMusArchBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.queryMusArchBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("queryMusArchBindingNavigatorSaveItem.Image")));
            this.queryMusArchBindingNavigatorSaveItem.Name = "queryMusArchBindingNavigatorSaveItem";
            this.queryMusArchBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.queryMusArchBindingNavigatorSaveItem.Text = "Сгенерировать отчет";
            this.queryMusArchBindingNavigatorSaveItem.Click += new System.EventHandler(this.queryMusArchBindingNavigatorSaveItem_Click);
            // 
            // queryMusArchDataGridView
            // 
            this.queryMusArchDataGridView.AllowUserToAddRows = false;
            this.queryMusArchDataGridView.AllowUserToDeleteRows = false;
            this.queryMusArchDataGridView.AutoGenerateColumns = false;
            this.queryMusArchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryMusArchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.queryMusArchDataGridView.DataSource = this.queryMusArchBindingSource;
            this.queryMusArchDataGridView.Location = new System.Drawing.Point(12, 31);
            this.queryMusArchDataGridView.Name = "queryMusArchDataGridView";
            this.queryMusArchDataGridView.ReadOnly = true;
            this.queryMusArchDataGridView.Size = new System.Drawing.Size(851, 418);
            this.queryMusArchDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_cmpstn";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код записи";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cmpstn_n";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "mscn_n";
            this.dataGridViewTextBoxColumn3.HeaderText = "Исполнитель";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "gnr_n";
            this.dataGridViewTextBoxColumn4.HeaderText = "Жанр";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "album";
            this.dataGridViewTextBoxColumn5.HeaderText = "Альбом";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "year";
            this.dataGridViewTextBoxColumn6.HeaderText = "Год";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "rec_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата записи";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "rating";
            this.dataGridViewTextBoxColumn8.HeaderText = "Рейтинг";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // mscn_comb
            // 
            this.mscn_comb.DataSource = this.mscnBindingSource;
            this.mscn_comb.DisplayMember = "mscn_n";
            this.mscn_comb.FormattingEnabled = true;
            this.mscn_comb.Location = new System.Drawing.Point(241, 5);
            this.mscn_comb.Name = "mscn_comb";
            this.mscn_comb.Size = new System.Drawing.Size(112, 21);
            this.mscn_comb.TabIndex = 2;
            this.mscn_comb.SelectedIndexChanged += new System.EventHandler(this.mscn_comb_SelectedIndexChanged);
            this.mscn_comb.Click += new System.EventHandler(this.mscn_comb_Click);
            // 
            // mscnBindingSource
            // 
            this.mscnBindingSource.DataMember = "mscn";
            this.mscnBindingSource.DataSource = this.dJDataSet;
            // 
            // gnrs_comb
            // 
            this.gnrs_comb.DataSource = this.gnrsBindingSource;
            this.gnrs_comb.DisplayMember = "gnr_n";
            this.gnrs_comb.FormattingEnabled = true;
            this.gnrs_comb.Location = new System.Drawing.Point(359, 5);
            this.gnrs_comb.Name = "gnrs_comb";
            this.gnrs_comb.Size = new System.Drawing.Size(112, 21);
            this.gnrs_comb.TabIndex = 3;
            this.gnrs_comb.SelectedIndexChanged += new System.EventHandler(this.gnrs_comb_SelectedIndexChanged);
            this.gnrs_comb.Click += new System.EventHandler(this.gnrs_comb_Click);
            // 
            // gnrsBindingSource
            // 
            this.gnrsBindingSource.DataMember = "gnrs";
            this.gnrsBindingSource.DataSource = this.dJDataSet;
            // 
            // filter_btn
            // 
            this.filter_btn.Location = new System.Drawing.Point(477, 5);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Size = new System.Drawing.Size(90, 20);
            this.filter_btn.TabIndex = 4;
            this.filter_btn.Text = "Отфильровать";
            this.filter_btn.UseVisualStyleBackColor = true;
            this.filter_btn.Click += new System.EventHandler(this.filter_btn_Click);
            // 
            // cancel_filer_btn
            // 
            this.cancel_filer_btn.Location = new System.Drawing.Point(573, 5);
            this.cancel_filer_btn.Name = "cancel_filer_btn";
            this.cancel_filer_btn.Size = new System.Drawing.Size(121, 20);
            this.cancel_filer_btn.TabIndex = 5;
            this.cancel_filer_btn.Text = "Отмена фильтрации";
            this.cancel_filer_btn.UseVisualStyleBackColor = true;
            this.cancel_filer_btn.Click += new System.EventHandler(this.cancel_filer_btn_Click);
            // 
            // queryMusArchTableAdapter
            // 
            this.queryMusArchTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cmpstnTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.empTableAdapter = null;
            this.tableAdapterManager.gnrsTableAdapter = null;
            this.tableAdapterManager.mscnTableAdapter = null;
            this.tableAdapterManager.pstionsTableAdapter = null;
            this.tableAdapterManager.schdlTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Itog.DJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mscnTableAdapter
            // 
            this.mscnTableAdapter.ClearBeforeFill = true;
            // 
            // gnrsTableAdapter
            // 
            this.gnrsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ипсолнитель, выб";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(359, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Жанр, выберете";
            // 
            // query1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_filer_btn);
            this.Controls.Add(this.filter_btn);
            this.Controls.Add(this.gnrs_comb);
            this.Controls.Add(this.mscn_comb);
            this.Controls.Add(this.queryMusArchDataGridView);
            this.Controls.Add(this.queryMusArchBindingNavigator);
            this.Name = "query1";
            this.Text = "Музыкальный архив";
            this.Load += new System.EventHandler(this.query1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.queryMusArchBindingNavigator)).EndInit();
            this.queryMusArchBindingNavigator.ResumeLayout(false);
            this.queryMusArchBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryMusArchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryMusArchDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mscnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnrsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DJDataSet dJDataSet;
        private System.Windows.Forms.BindingSource queryMusArchBindingSource;
        private DJDataSetTableAdapters.QueryMusArchTableAdapter queryMusArchTableAdapter;
        private DJDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator queryMusArchBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView queryMusArchDataGridView;
        private System.Windows.Forms.ToolStripButton queryMusArchBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox mscn_comb;
        private System.Windows.Forms.ComboBox gnrs_comb;
        private System.Windows.Forms.Button filter_btn;
        private System.Windows.Forms.BindingSource mscnBindingSource;
        private DJDataSetTableAdapters.mscnTableAdapter mscnTableAdapter;
        private System.Windows.Forms.BindingSource gnrsBindingSource;
        private DJDataSetTableAdapters.gnrsTableAdapter gnrsTableAdapter;
        private System.Windows.Forms.Button cancel_filer_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
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