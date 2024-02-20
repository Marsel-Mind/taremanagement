
namespace TareManagement_app
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufDepthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufHeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufWidthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufUnitnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tareManagementDataSet = new TareManagement_app.TareManagementDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.whseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custseqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custaddrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.techreqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parmID9790879DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addparmID9790879DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxWeightInContainerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxWeightInContBoxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxWeightInContPaletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nMShipProdSelContCustSeqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new TareManagement_app.TareManagementDataSetTableAdapters.ItemTableAdapter();
            this.nMShipProdSelContCustSeqTableAdapter = new TareManagement_app.TareManagementDataSetTableAdapters.NMShipProdSelContCustSeqTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMShipProdSelContCustSeqBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.unitweightDataGridViewTextBoxColumn,
            this.ufDepthDataGridViewTextBoxColumn,
            this.ufHeightDataGridViewTextBoxColumn,
            this.ufWidthDataGridViewTextBoxColumn,
            this.ufUnitnumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(773, 287);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CheckBoxColumn
            // 
            this.CheckBoxColumn.HeaderText = "";
            this.CheckBoxColumn.Name = "CheckBoxColumn";
            this.CheckBoxColumn.Width = 20;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // unitweightDataGridViewTextBoxColumn
            // 
            this.unitweightDataGridViewTextBoxColumn.DataPropertyName = "unit_weight";
            this.unitweightDataGridViewTextBoxColumn.HeaderText = "unit_weight";
            this.unitweightDataGridViewTextBoxColumn.Name = "unitweightDataGridViewTextBoxColumn";
            // 
            // ufDepthDataGridViewTextBoxColumn
            // 
            this.ufDepthDataGridViewTextBoxColumn.DataPropertyName = "Uf_Depth";
            this.ufDepthDataGridViewTextBoxColumn.HeaderText = "Uf_Depth";
            this.ufDepthDataGridViewTextBoxColumn.Name = "ufDepthDataGridViewTextBoxColumn";
            // 
            // ufHeightDataGridViewTextBoxColumn
            // 
            this.ufHeightDataGridViewTextBoxColumn.DataPropertyName = "Uf_Height";
            this.ufHeightDataGridViewTextBoxColumn.HeaderText = "Uf_Height";
            this.ufHeightDataGridViewTextBoxColumn.Name = "ufHeightDataGridViewTextBoxColumn";
            // 
            // ufWidthDataGridViewTextBoxColumn
            // 
            this.ufWidthDataGridViewTextBoxColumn.DataPropertyName = "Uf_Width";
            this.ufWidthDataGridViewTextBoxColumn.HeaderText = "Uf_Width";
            this.ufWidthDataGridViewTextBoxColumn.Name = "ufWidthDataGridViewTextBoxColumn";
            // 
            // ufUnitnumDataGridViewTextBoxColumn
            // 
            this.ufUnitnumDataGridViewTextBoxColumn.DataPropertyName = "Uf_Unit_num";
            this.ufUnitnumDataGridViewTextBoxColumn.HeaderText = "Uf_Unit_num";
            this.ufUnitnumDataGridViewTextBoxColumn.Name = "ufUnitnumDataGridViewTextBoxColumn";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.tareManagementDataSet;
            // 
            // tareManagementDataSet
            // 
            this.tareManagementDataSet.DataSetName = "TareManagementDataSet";
            this.tareManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.whseDataGridViewTextBoxColumn,
            this.custnumDataGridViewTextBoxColumn,
            this.custseqDataGridViewTextBoxColumn,
            this.custnameDataGridViewTextBoxColumn,
            this.custaddrDataGridViewTextBoxColumn,
            this.techreqDataGridViewTextBoxColumn,
            this.parmID9790879DataGridViewTextBoxColumn,
            this.addparmID9790879DataGridViewTextBoxColumn,
            this.maxWeightInContainerDataGridViewTextBoxColumn,
            this.maxWeightInContBoxDataGridViewTextBoxColumn,
            this.maxWeightInContPaletaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.nMShipProdSelContCustSeqBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 296);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1143, 267);
            this.dataGridView2.TabIndex = 1;
            // 
            // whseDataGridViewTextBoxColumn
            // 
            this.whseDataGridViewTextBoxColumn.DataPropertyName = "Whse";
            this.whseDataGridViewTextBoxColumn.HeaderText = "Whse";
            this.whseDataGridViewTextBoxColumn.Name = "whseDataGridViewTextBoxColumn";
            this.whseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custnumDataGridViewTextBoxColumn
            // 
            this.custnumDataGridViewTextBoxColumn.DataPropertyName = "cust_num";
            this.custnumDataGridViewTextBoxColumn.HeaderText = "cust_num";
            this.custnumDataGridViewTextBoxColumn.Name = "custnumDataGridViewTextBoxColumn";
            this.custnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custseqDataGridViewTextBoxColumn
            // 
            this.custseqDataGridViewTextBoxColumn.DataPropertyName = "cust_seq";
            this.custseqDataGridViewTextBoxColumn.HeaderText = "cust_seq";
            this.custseqDataGridViewTextBoxColumn.Name = "custseqDataGridViewTextBoxColumn";
            this.custseqDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custnameDataGridViewTextBoxColumn
            // 
            this.custnameDataGridViewTextBoxColumn.DataPropertyName = "cust_name";
            this.custnameDataGridViewTextBoxColumn.HeaderText = "cust_name";
            this.custnameDataGridViewTextBoxColumn.Name = "custnameDataGridViewTextBoxColumn";
            this.custnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custaddrDataGridViewTextBoxColumn
            // 
            this.custaddrDataGridViewTextBoxColumn.DataPropertyName = "cust_addr";
            this.custaddrDataGridViewTextBoxColumn.HeaderText = "cust_addr";
            this.custaddrDataGridViewTextBoxColumn.Name = "custaddrDataGridViewTextBoxColumn";
            this.custaddrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // techreqDataGridViewTextBoxColumn
            // 
            this.techreqDataGridViewTextBoxColumn.DataPropertyName = "tech_req";
            this.techreqDataGridViewTextBoxColumn.HeaderText = "tech_req";
            this.techreqDataGridViewTextBoxColumn.Name = "techreqDataGridViewTextBoxColumn";
            this.techreqDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parmID9790879DataGridViewTextBoxColumn
            // 
            this.parmID9790879DataGridViewTextBoxColumn.DataPropertyName = "parmID_9790_879";
            this.parmID9790879DataGridViewTextBoxColumn.HeaderText = "parmID_9790_879";
            this.parmID9790879DataGridViewTextBoxColumn.Name = "parmID9790879DataGridViewTextBoxColumn";
            this.parmID9790879DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addparmID9790879DataGridViewTextBoxColumn
            // 
            this.addparmID9790879DataGridViewTextBoxColumn.DataPropertyName = "add_parmID_9790_879";
            this.addparmID9790879DataGridViewTextBoxColumn.HeaderText = "add_parmID_9790_879";
            this.addparmID9790879DataGridViewTextBoxColumn.Name = "addparmID9790879DataGridViewTextBoxColumn";
            this.addparmID9790879DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxWeightInContainerDataGridViewTextBoxColumn
            // 
            this.maxWeightInContainerDataGridViewTextBoxColumn.DataPropertyName = "MaxWeightInContainer";
            this.maxWeightInContainerDataGridViewTextBoxColumn.HeaderText = "MaxWeightInContainer";
            this.maxWeightInContainerDataGridViewTextBoxColumn.Name = "maxWeightInContainerDataGridViewTextBoxColumn";
            this.maxWeightInContainerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxWeightInContBoxDataGridViewTextBoxColumn
            // 
            this.maxWeightInContBoxDataGridViewTextBoxColumn.DataPropertyName = "MaxWeightInContBox";
            this.maxWeightInContBoxDataGridViewTextBoxColumn.HeaderText = "MaxWeightInContBox";
            this.maxWeightInContBoxDataGridViewTextBoxColumn.Name = "maxWeightInContBoxDataGridViewTextBoxColumn";
            this.maxWeightInContBoxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxWeightInContPaletaDataGridViewTextBoxColumn
            // 
            this.maxWeightInContPaletaDataGridViewTextBoxColumn.DataPropertyName = "MaxWeightInContPaleta";
            this.maxWeightInContPaletaDataGridViewTextBoxColumn.HeaderText = "MaxWeightInContPaleta";
            this.maxWeightInContPaletaDataGridViewTextBoxColumn.Name = "maxWeightInContPaletaDataGridViewTextBoxColumn";
            this.maxWeightInContPaletaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nMShipProdSelContCustSeqBindingSource
            // 
            this.nMShipProdSelContCustSeqBindingSource.DataMember = "NMShipProdSelContCustSeq";
            this.nMShipProdSelContCustSeqBindingSource.DataSource = this.tareManagementDataSet;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // nMShipProdSelContCustSeqTableAdapter
            // 
            this.nMShipProdSelContCustSeqTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(791, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Рассчитать количество упаковок ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(791, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 59);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отправить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 592);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tareManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nMShipProdSelContCustSeqBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private TareManagementDataSet tareManagementDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private TareManagementDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.BindingSource nMShipProdSelContCustSeqBindingSource;
        private TareManagementDataSetTableAdapters.NMShipProdSelContCustSeqTableAdapter nMShipProdSelContCustSeqTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn whseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custseqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custaddrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn techreqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parmID9790879DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addparmID9790879DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxWeightInContainerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxWeightInContBoxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxWeightInContPaletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufDepthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufHeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufWidthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufUnitnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}

