namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    partial class Bus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bus));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bus_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sys_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus_Vm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus_Va = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus_PG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus_QG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus_Vmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus_Vmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bus_index,
            this.sys_num,
            this.bus_type,
            this.bus_Vm,
            this.bus_Va,
            this.bus_PG,
            this.bus_QG,
            this.bus_Vmax,
            this.bus_Vmin});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(526, 125);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // bus_index
            // 
            this.bus_index.HeaderText = "母线编号";
            this.bus_index.Name = "bus_index";
            // 
            // sys_num
            // 
            this.sys_num.HeaderText = "系统编号";
            this.sys_num.Name = "sys_num";
            // 
            // bus_type
            // 
            this.bus_type.HeaderText = "母线类型";
            this.bus_type.Name = "bus_type";
            // 
            // bus_Vm
            // 
            this.bus_Vm.HeaderText = "电压幅值";
            this.bus_Vm.Name = "bus_Vm";
            // 
            // bus_Va
            // 
            this.bus_Va.HeaderText = "电压相角";
            this.bus_Va.Name = "bus_Va";
            // 
            // bus_PG
            // 
            this.bus_PG.HeaderText = "有功供应";
            this.bus_PG.Name = "bus_PG";
            // 
            // bus_QG
            // 
            this.bus_QG.HeaderText = "无功供应";
            this.bus_QG.Name = "bus_QG";
            // 
            // bus_Vmax
            // 
            this.bus_Vmax.HeaderText = "电压上限";
            this.bus_Vmax.Name = "bus_Vmax";
            // 
            // bus_Vmin
            // 
            this.bus_Vmin.HeaderText = "电压下限";
            this.bus_Vmin.Name = "bus_Vmin";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(63, 181);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "插入数据";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChange.Location = new System.Drawing.Point(416, 181);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 10;
            this.buttonChange.Text = "修改数据";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(236, 181);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "删除数据";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 216);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bus";
            this.Text = "Bus";
            this.Load += new System.EventHandler(this.bus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn sys_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus_Vm;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus_Va;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus_PG;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus_QG;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus_Vmax;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus_Vmin;
    }
}