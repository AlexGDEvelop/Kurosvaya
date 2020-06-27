namespace Itog
{
    partial class pstions_fr
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
            System.Windows.Forms.Label id_pstionLabel;
            System.Windows.Forms.Label pstion_nLabel;
            System.Windows.Forms.Label slryLabel;
            System.Windows.Forms.Label rspnsLabel;
            System.Windows.Forms.Label rqrmntsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pstions_fr));
            this.dJDataSet = new Itog.DJDataSet();
            this.pstionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pstionsTableAdapter = new Itog.DJDataSetTableAdapters.pstionsTableAdapter();
            this.tableAdapterManager = new Itog.DJDataSetTableAdapters.TableAdapterManager();
            this.pstionsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pstionsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pstionsDataGridView = new System.Windows.Forms.DataGridView();
            this.id_pstionTextBox = new System.Windows.Forms.TextBox();
            this.pstion_nTextBox = new System.Windows.Forms.TextBox();
            this.slryTextBox = new System.Windows.Forms.TextBox();
            this.rspnsTextBox = new System.Windows.Forms.TextBox();
            this.rqrmntsTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_pstionLabel = new System.Windows.Forms.Label();
            pstion_nLabel = new System.Windows.Forms.Label();
            slryLabel = new System.Windows.Forms.Label();
            rspnsLabel = new System.Windows.Forms.Label();
            rqrmntsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dJDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pstionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pstionsBindingNavigator)).BeginInit();
            this.pstionsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pstionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_pstionLabel
            // 
            id_pstionLabel.AutoSize = true;
            id_pstionLabel.Location = new System.Drawing.Point(563, 28);
            id_pstionLabel.Name = "id_pstionLabel";
            id_pstionLabel.Size = new System.Drawing.Size(87, 13);
            id_pstionLabel.TabIndex = 2;
            id_pstionLabel.Text = "Код должности:";
            // 
            // pstion_nLabel
            // 
            pstion_nLabel.AutoSize = true;
            pstion_nLabel.Location = new System.Drawing.Point(563, 54);
            pstion_nLabel.Name = "pstion_nLabel";
            pstion_nLabel.Size = new System.Drawing.Size(86, 13);
            pstion_nLabel.TabIndex = 4;
            pstion_nLabel.Text = "Наименование:";
            // 
            // slryLabel
            // 
            slryLabel.AutoSize = true;
            slryLabel.Location = new System.Drawing.Point(563, 80);
            slryLabel.Name = "slryLabel";
            slryLabel.Size = new System.Drawing.Size(58, 13);
            slryLabel.TabIndex = 6;
            slryLabel.Text = "Зарплата:";
            // 
            // rspnsLabel
            // 
            rspnsLabel.AutoSize = true;
            rspnsLabel.Location = new System.Drawing.Point(563, 106);
            rspnsLabel.Name = "rspnsLabel";
            rspnsLabel.Size = new System.Drawing.Size(77, 13);
            rspnsLabel.TabIndex = 8;
            rspnsLabel.Text = "Обязанности:";
            // 
            // rqrmntsLabel
            // 
            rqrmntsLabel.AutoSize = true;
            rqrmntsLabel.Location = new System.Drawing.Point(563, 132);
            rqrmntsLabel.Name = "rqrmntsLabel";
            rqrmntsLabel.Size = new System.Drawing.Size(71, 13);
            rqrmntsLabel.TabIndex = 10;
            rqrmntsLabel.Text = "Требования:";
            // 
            // dJDataSet
            // 
            this.dJDataSet.DataSetName = "DJDataSet";
            this.dJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // pstionsBindingNavigator
            // 
            this.pstionsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pstionsBindingNavigator.BindingSource = this.pstionsBindingSource;
            this.pstionsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pstionsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pstionsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pstionsBindingNavigatorSaveItem});
            this.pstionsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pstionsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pstionsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pstionsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pstionsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pstionsBindingNavigator.Name = "pstionsBindingNavigator";
            this.pstionsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pstionsBindingNavigator.Size = new System.Drawing.Size(764, 25);
            this.pstionsBindingNavigator.TabIndex = 0;
            this.pstionsBindingNavigator.Text = "bindingNavigator1";
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
            // pstionsBindingNavigatorSaveItem
            // 
            this.pstionsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pstionsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pstionsBindingNavigatorSaveItem.Image")));
            this.pstionsBindingNavigatorSaveItem.Name = "pstionsBindingNavigatorSaveItem";
            this.pstionsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pstionsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.pstionsBindingNavigatorSaveItem.Click += new System.EventHandler(this.pstionsBindingNavigatorSaveItem_Click);
            // 
            // pstionsDataGridView
            // 
            this.pstionsDataGridView.AutoGenerateColumns = false;
            this.pstionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pstionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.pstionsDataGridView.DataSource = this.pstionsBindingSource;
            this.pstionsDataGridView.Location = new System.Drawing.Point(12, 28);
            this.pstionsDataGridView.Name = "pstionsDataGridView";
            this.pstionsDataGridView.Size = new System.Drawing.Size(545, 247);
            this.pstionsDataGridView.TabIndex = 1;
            this.pstionsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pstionsDataGridView_CellContentClick);
            // 
            // id_pstionTextBox
            // 
            this.id_pstionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pstionsBindingSource, "id_pstion", true));
            this.id_pstionTextBox.Location = new System.Drawing.Point(656, 28);
            this.id_pstionTextBox.Name = "id_pstionTextBox";
            this.id_pstionTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_pstionTextBox.TabIndex = 3;
            // 
            // pstion_nTextBox
            // 
            this.pstion_nTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pstionsBindingSource, "pstion_n", true));
            this.pstion_nTextBox.Location = new System.Drawing.Point(656, 54);
            this.pstion_nTextBox.Name = "pstion_nTextBox";
            this.pstion_nTextBox.Size = new System.Drawing.Size(100, 20);
            this.pstion_nTextBox.TabIndex = 5;
            // 
            // slryTextBox
            // 
            this.slryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pstionsBindingSource, "slry", true));
            this.slryTextBox.Location = new System.Drawing.Point(656, 80);
            this.slryTextBox.Name = "slryTextBox";
            this.slryTextBox.Size = new System.Drawing.Size(100, 20);
            this.slryTextBox.TabIndex = 7;
            // 
            // rspnsTextBox
            // 
            this.rspnsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pstionsBindingSource, "rspns", true));
            this.rspnsTextBox.Location = new System.Drawing.Point(656, 106);
            this.rspnsTextBox.Name = "rspnsTextBox";
            this.rspnsTextBox.Size = new System.Drawing.Size(100, 20);
            this.rspnsTextBox.TabIndex = 9;
            // 
            // rqrmntsTextBox
            // 
            this.rqrmntsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pstionsBindingSource, "rqrmnts", true));
            this.rqrmntsTextBox.Location = new System.Drawing.Point(656, 132);
            this.rqrmntsTextBox.Name = "rqrmntsTextBox";
            this.rqrmntsTextBox.Size = new System.Drawing.Size(100, 20);
            this.rqrmntsTextBox.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_pstion";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код должности";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "pstion_n";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "slry";
            this.dataGridViewTextBoxColumn3.HeaderText = "Зарплата";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "rspns";
            this.dataGridViewTextBoxColumn4.HeaderText = "Обязанности";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "rqrmnts";
            this.dataGridViewTextBoxColumn5.HeaderText = "Требования";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // pstions_fr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 287);
            this.Controls.Add(id_pstionLabel);
            this.Controls.Add(this.id_pstionTextBox);
            this.Controls.Add(pstion_nLabel);
            this.Controls.Add(this.pstion_nTextBox);
            this.Controls.Add(slryLabel);
            this.Controls.Add(this.slryTextBox);
            this.Controls.Add(rspnsLabel);
            this.Controls.Add(this.rspnsTextBox);
            this.Controls.Add(rqrmntsLabel);
            this.Controls.Add(this.rqrmntsTextBox);
            this.Controls.Add(this.pstionsDataGridView);
            this.Controls.Add(this.pstionsBindingNavigator);
            this.Name = "pstions_fr";
            this.Text = "pstions_fr";
            this.Load += new System.EventHandler(this.pstions_fr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dJDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pstionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pstionsBindingNavigator)).EndInit();
            this.pstionsBindingNavigator.ResumeLayout(false);
            this.pstionsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pstionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DJDataSet dJDataSet;
        private System.Windows.Forms.BindingSource pstionsBindingSource;
        private DJDataSetTableAdapters.pstionsTableAdapter pstionsTableAdapter;
        private DJDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pstionsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pstionsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pstionsDataGridView;
        private System.Windows.Forms.TextBox id_pstionTextBox;
        private System.Windows.Forms.TextBox pstion_nTextBox;
        private System.Windows.Forms.TextBox slryTextBox;
        private System.Windows.Forms.TextBox rspnsTextBox;
        private System.Windows.Forms.TextBox rqrmntsTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}