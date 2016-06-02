namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    partial class WindM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindM));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.windm_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windm_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windm_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windm_Pmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windm_Pmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.windm_num,
            this.bus_index,
            this.windm_time,
            this.windm_P,
            this.windm_Pmax,
            this.windm_Pmin});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(448, 178);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // windm_num
            // 
            this.windm_num.HeaderText = "风机编号";
            this.windm_num.Name = "windm_num";
            // 
            // bus_index
            // 
            this.bus_index.HeaderText = "母线编号";
            this.bus_index.Name = "bus_index";
            // 
            // windm_time
            // 
            this.windm_time.HeaderText = "风机时间段";
            this.windm_time.Name = "windm_time";
            // 
            // windm_P
            // 
            this.windm_P.HeaderText = "风机预测发电功率";
            this.windm_P.Name = "windm_P";
            // 
            // windm_Pmax
            // 
            this.windm_Pmax.HeaderText = "风机有功功率上限";
            this.windm_Pmax.Name = "windm_Pmax";
            // 
            // windm_Pmin
            // 
            this.windm_Pmin.HeaderText = "风机有功功率下限";
            this.windm_Pmin.Name = "windm_Pmin";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(38, 226);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "插入数据";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChange.Location = new System.Drawing.Point(354, 226);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 13;
            this.buttonChange.Text = "修改数据";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(199, 226);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "删除数据";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // WindM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 261);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindM";
            this.Text = "WindM";
            this.Load += new System.EventHandler(this.windm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn windm_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn windm_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn windm_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn windm_Pmax;
        private System.Windows.Forms.DataGridViewTextBoxColumn windm_Pmin;
    }
}