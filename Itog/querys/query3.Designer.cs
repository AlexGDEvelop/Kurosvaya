namespace Itog.querys
{
    partial class query3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(query3));
            this.dJDataSet = new Itog.DJDataSet();
            this.queryOtdelKadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.queryOtdelKadTableAdapter = new Itog.DJDataSetTableAdapters.QueryOtdelKadTableAdapter();
            this.tableAdapterManager = new Itog.DJDataSetTableAdapters.TableAdapterManager();
            this.queryOtdelKadBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.queryOtdelKadBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.queryOtdelKadDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.gnrs_comb = new System.Windows.Forms.ComboBox();
            this.filter_btn = new System.Windows.Forms.Button();
            this.cancel_filer_btn = new System.Windows.Forms.Button();
            this.pstionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pstionsTableAdapter = new Itog.DJDataSetTableAdapters.pstionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryOtdelKadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryOtdelKadBindingNavigator)).BeginInit();
            this.queryOtdelKadBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryOtdelKadDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pstionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dJDataSet
            // 
            this.dJDataSet.DataSetName = "DJDataSet";
            this.dJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // queryOtdelKadBindingSource
            // 
            this.queryOtdelKadBindingSource.DataMember = "QueryOtdelKad";
            this.queryOtdelKadBindingSource.DataSource = this.dJDataSet;
            // 
            // queryOtdelKadTableAdapter
            // 
            this.queryOtdelKadTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cmpstnTableAdapter = null;
            this.tableAdapterManager.empTableAdapter = null;
            this.tableAdapterManager.gnrsTableAdapter = null;
            this.tableAdapterManager.mscnTableAdapter = null;
            this.tableAdapterManager.pstionsTableAdapter = this.pstionsTableAdapter;
            this.tableAdapterManager.schdlTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Itog.DJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // queryOtdelKadBindingNavigator
            // 
            this.queryOtdelKadBindingNavigator.AddNewItem = null;
            this.queryOtdelKadBindingNavigator.BindingSource = this.queryOtdelKadBindingSource;
            this.queryOtdelKadBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.queryOtdelKadBindingNavigator.DeleteItem = null;
            this.queryOtdelKadBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.queryOtdelKadBindingNavigatorSaveItem});
            this.queryOtdelKadBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.queryOtdelKadBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.queryOtdelKadBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.queryOtdelKadBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.queryOtdelKadBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.queryOtdelKadBindingNavigator.Name = "queryOtdelKadBindingNavigator";
            this.queryOtdelKadBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.queryOtdelKadBindingNavigator.Size = new System.Drawing.Size(869, 25);
            this.queryOtdelKadBindingNavigator.TabIndex = 0;
            this.queryOtdelKadBindingNavigator.Text = "bindingNavigator1";
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
            // queryOtdelKadBindingNavigatorSaveItem
            // 
            this.queryOtdelKadBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.queryOtdelKadBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("queryOtdelKadBindingNavigatorSaveItem.Image")));
            this.queryOtdelKadBindingNavigatorSaveItem.Name = "queryOtdelKadBindingNavigatorSaveItem";
            this.queryOtdelKadBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.queryOtdelKadBindingNavigatorSaveItem.Text = "Сгенерировать отчет";
            this.queryOtdelKadBindingNavigatorSaveItem.Click += new System.EventHandler(this.queryOtdelKadBindingNavigatorSaveItem_Click);
            // 
            // queryOtdelKadDataGridView
            // 
            this.queryOtdelKadDataGridView.AllowUserToAddRows = false;
            this.queryOtdelKadDataGridView.AllowUserToDeleteRows = false;
            this.queryOtdelKadDataGridView.AutoGenerateColumns = false;
            this.queryOtdelKadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryOtdelKadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.queryOtdelKadDataGridView.DataSource = this.queryOtdelKadBindingSource;
            this.queryOtdelKadDataGridView.Location = new System.Drawing.Point(12, 31);
            this.queryOtdelKadDataGridView.Name = "queryOtdelKadDataGridView";
            this.queryOtdelKadDataGridView.ReadOnly = true;
            this.queryOtdelKadDataGridView.Size = new System.Drawing.Size(845, 407);
            this.queryOtdelKadDataGridView.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "pstion_n";
            this.dataGridViewTextBoxColumn3.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn4.HeaderText = "Возраст";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "sex";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Пол";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "adrs";
            this.dataGridViewTextBoxColumn5.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nmbr";
            this.dataGridViewTextBoxColumn6.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "psprt_nmbr";
            this.dataGridViewTextBoxColumn7.HeaderText = "Паспортные данные";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(243, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Должность, выбр";
            // 
            // gnrs_comb
            // 
            this.gnrs_comb.DataSource = this.pstionsBindingSource;
            this.gnrs_comb.DisplayMember = "pstion_n";
            this.gnrs_comb.FormattingEnabled = true;
            this.gnrs_comb.Location = new System.Drawing.Point(243, 4);
            this.gnrs_comb.Name = "gnrs_comb";
            this.gnrs_comb.Size = new System.Drawing.Size(112, 21);
            this.gnrs_comb.TabIndex = 15;
            this.gnrs_comb.SelectedIndexChanged += new System.EventHandler(this.gnrs_comb_SelectedIndexChanged);
            this.gnrs_comb.Click += new System.EventHandler(this.gnrs_comb_Click);
            // 
            // filter_btn
            // 
            this.filter_btn.Location = new System.Drawing.Point(361, 4);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Size = new System.Drawing.Size(90, 20);
            this.filter_btn.TabIndex = 16;
            this.filter_btn.Text = "Отфильровать";
            this.filter_btn.UseVisualStyleBackColor = true;
            this.filter_btn.Click += new System.EventHandler(this.filter_btn_Click);
            // 
            // cancel_filer_btn
            // 
            this.cancel_filer_btn.Location = new System.Drawing.Point(457, 4);
            this.cancel_filer_btn.Name = "cancel_filer_btn";
            this.cancel_filer_btn.Size = new System.Drawing.Size(121, 20);
            this.cancel_filer_btn.TabIndex = 17;
            this.cancel_filer_btn.Text = "Отмена фильтрации";
            this.cancel_filer_btn.UseVisualStyleBackColor = true;
            this.cancel_filer_btn.Click += new System.EventHandler(this.cancel_filer_btn_Click);
            // 
            // pstionsBindingSource
            // 
            this.pstionsBindingSource.DataMember = "pstions";
            this.pstionsBindingSource.DataSource = this.dJDataSet;
            // 
            // pstionsTableAdapter
            // 
            this.pstionsTableAdapter.ClearBeforeFill = true;
            // 
            // query3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel_filer_btn);
            this.Controls.Add(this.filter_btn);
            this.Controls.Add(this.gnrs_comb);
            this.Controls.Add(this.queryOtdelKadDataGridView);
            this.Controls.Add(this.queryOtdelKadBindingNavigator);
            this.Name = "query3";
            this.Text = "Отдел кадров";
            this.Load += new System.EventHandler(this.query3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryOtdelKadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryOtdelKadBindingNavigator)).EndInit();
            this.queryOtdelKadBindingNavigator.ResumeLayout(false);
            this.queryOtdelKadBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryOtdelKadDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pstionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DJDataSet dJDataSet;
        private System.Windows.Forms.BindingSource queryOtdelKadBindingSource;
        private DJDataSetTableAdapters.QueryOtdelKadTableAdapter queryOtdelKadTableAdapter;
        private DJDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator queryOtdelKadBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton queryOtdelKadBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView queryOtdelKadDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox gnrs_comb;
        private System.Windows.Forms.Button filter_btn;
        private System.Windows.Forms.Button cancel_filer_btn;
        private DJDataSetTableAdapters.pstionsTableAdapter pstionsTableAdapter;
        private System.Windows.Forms.BindingSource pstionsBindingSource;
    }
}