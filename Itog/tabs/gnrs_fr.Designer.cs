namespace Itog
{
    partial class gnrs_fr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gnrs_fr));
            System.Windows.Forms.Label id_gnrLabel;
            System.Windows.Forms.Label gnr_nLabel;
            System.Windows.Forms.Label gnr_abtLabel;
            this.dJDataSet = new Itog.DJDataSet();
            this.gnrsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gnrsTableAdapter = new Itog.DJDataSetTableAdapters.gnrsTableAdapter();
            this.tableAdapterManager = new Itog.DJDataSetTableAdapters.TableAdapterManager();
            this.gnrsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.gnrsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gnrsDataGridView = new System.Windows.Forms.DataGridView();
            this.id_gnrTextBox = new System.Windows.Forms.TextBox();
            this.gnr_nTextBox = new System.Windows.Forms.TextBox();
            this.gnr_abtTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_gnrLabel = new System.Windows.Forms.Label();
            gnr_nLabel = new System.Windows.Forms.Label();
            gnr_abtLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnrsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnrsBindingNavigator)).BeginInit();
            this.gnrsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gnrsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dJDataSet
            // 
            this.dJDataSet.DataSetName = "DJDataSet";
            this.dJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gnrsBindingSource
            // 
            this.gnrsBindingSource.DataMember = "gnrs";
            this.gnrsBindingSource.DataSource = this.dJDataSet;
            // 
            // gnrsTableAdapter
            // 
            this.gnrsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cmpstnTableAdapter = null;
            this.tableAdapterManager.empTableAdapter = null;
            this.tableAdapterManager.gnrsTableAdapter = this.gnrsTableAdapter;
            this.tableAdapterManager.mscnTableAdapter = null;
            this.tableAdapterManager.pstionsTableAdapter = null;
            this.tableAdapterManager.schdlTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Itog.DJDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gnrsBindingNavigator
            // 
            this.gnrsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gnrsBindingNavigator.BindingSource = this.gnrsBindingSource;
            this.gnrsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gnrsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gnrsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gnrsBindingNavigatorSaveItem});
            this.gnrsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gnrsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gnrsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gnrsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gnrsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gnrsBindingNavigator.Name = "gnrsBindingNavigator";
            this.gnrsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gnrsBindingNavigator.Size = new System.Drawing.Size(562, 25);
            this.gnrsBindingNavigator.TabIndex = 0;
            this.gnrsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // gnrsBindingNavigatorSaveItem
            // 
            this.gnrsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gnrsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gnrsBindingNavigatorSaveItem.Image")));
            this.gnrsBindingNavigatorSaveItem.Name = "gnrsBindingNavigatorSaveItem";
            this.gnrsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.gnrsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.gnrsBindingNavigatorSaveItem.Click += new System.EventHandler(this.gnrsBindingNavigatorSaveItem_Click);
            // 
            // gnrsDataGridView
            // 
            this.gnrsDataGridView.AutoGenerateColumns = false;
            this.gnrsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gnrsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.gnrsDataGridView.DataSource = this.gnrsBindingSource;
            this.gnrsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.gnrsDataGridView.Name = "gnrsDataGridView";
            this.gnrsDataGridView.Size = new System.Drawing.Size(345, 223);
            this.gnrsDataGridView.TabIndex = 1;
            this.gnrsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gnrsDataGridView_CellContentClick);
            // 
            // id_gnrLabel
            // 
            id_gnrLabel.AutoSize = true;
            id_gnrLabel.Location = new System.Drawing.Point(363, 28);
            id_gnrLabel.Name = "id_gnrLabel";
            id_gnrLabel.Size = new System.Drawing.Size(64, 13);
            id_gnrLabel.TabIndex = 2;
            id_gnrLabel.Text = "Код жанра:";
            // 
            // id_gnrTextBox
            // 
            this.id_gnrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gnrsBindingSource, "id_gnr", true));
            this.id_gnrTextBox.Location = new System.Drawing.Point(455, 28);
            this.id_gnrTextBox.Name = "id_gnrTextBox";
            this.id_gnrTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_gnrTextBox.TabIndex = 3;
            // 
            // gnr_nLabel
            // 
            gnr_nLabel.AutoSize = true;
            gnr_nLabel.Location = new System.Drawing.Point(363, 54);
            gnr_nLabel.Name = "gnr_nLabel";
            gnr_nLabel.Size = new System.Drawing.Size(86, 13);
            gnr_nLabel.TabIndex = 4;
            gnr_nLabel.Text = "Наименование:";
            // 
            // gnr_nTextBox
            // 
            this.gnr_nTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gnrsBindingSource, "gnr_n", true));
            this.gnr_nTextBox.Location = new System.Drawing.Point(455, 54);
            this.gnr_nTextBox.Name = "gnr_nTextBox";
            this.gnr_nTextBox.Size = new System.Drawing.Size(100, 20);
            this.gnr_nTextBox.TabIndex = 5;
            // 
            // gnr_abtLabel
            // 
            gnr_abtLabel.AutoSize = true;
            gnr_abtLabel.Location = new System.Drawing.Point(363, 80);
            gnr_abtLabel.Name = "gnr_abtLabel";
            gnr_abtLabel.Size = new System.Drawing.Size(53, 13);
            gnr_abtLabel.TabIndex = 6;
            gnr_abtLabel.Text = "О жанре:";
            // 
            // gnr_abtTextBox
            // 
            this.gnr_abtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gnrsBindingSource, "gnr_abt", true));
            this.gnr_abtTextBox.Location = new System.Drawing.Point(455, 80);
            this.gnr_abtTextBox.Name = "gnr_abtTextBox";
            this.gnr_abtTextBox.Size = new System.Drawing.Size(100, 20);
            this.gnr_abtTextBox.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_gnr";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код жанра";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "gnr_n";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "gnr_abt";
            this.dataGridViewTextBoxColumn3.HeaderText = "О жанре";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // gnrs_fr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 263);
            this.Controls.Add(id_gnrLabel);
            this.Controls.Add(this.id_gnrTextBox);
            this.Controls.Add(gnr_nLabel);
            this.Controls.Add(this.gnr_nTextBox);
            this.Controls.Add(gnr_abtLabel);
            this.Controls.Add(this.gnr_abtTextBox);
            this.Controls.Add(this.gnrsDataGridView);
            this.Controls.Add(this.gnrsBindingNavigator);
            this.Name = "gnrs_fr";
            this.Text = "Жанры";
            this.Load += new System.EventHandler(this.gnrs_fr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnrsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnrsBindingNavigator)).EndInit();
            this.gnrsBindingNavigator.ResumeLayout(false);
            this.gnrsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gnrsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DJDataSet dJDataSet;
        private System.Windows.Forms.BindingSource gnrsBindingSource;
        private DJDataSetTableAdapters.gnrsTableAdapter gnrsTableAdapter;
        private DJDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gnrsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gnrsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView gnrsDataGridView;
        private System.Windows.Forms.TextBox id_gnrTextBox;
        private System.Windows.Forms.TextBox gnr_nTextBox;
        private System.Windows.Forms.TextBox gnr_abtTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}