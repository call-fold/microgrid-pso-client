namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    partial class PV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PV));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pv_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pv_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pv_P = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pv_Pmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pv_Pmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pv_num,
            this.bus_index,
            this.pv_time,
            this.pv_P,
            this.pv_Pmax,
            this.pv_Pmin});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(486, 199);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // pv_num
            // 
            this.pv_num.HeaderText = "pv编号";
            this.pv_num.Name = "pv_num";
            // 
            // bus_index
            // 
            this.bus_index.HeaderText = "母线编号";
            this.bus_index.Name = "bus_index";
            // 
            // pv_time
            // 
            this.pv_time.HeaderText = "pv时间段";
            this.pv_time.Name = "pv_time";
            // 
            // pv_P
            // 
            this.pv_P.HeaderText = "pv预测发电功率";
            this.pv_P.Name = "pv_P";
            // 
            // pv_Pmax
            // 
            this.pv_Pmax.HeaderText = "pv有功功率上限";
            this.pv_Pmax.Name = "pv_Pmax";
            // 
            // pv_Pmin
            // 
            this.pv_Pmin.HeaderText = "pv有功功率下限";
            this.pv_Pmin.Name = "pv_Pmin";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(43, 226);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "插入数据";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChange.Location = new System.Drawing.Point(379, 226);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 16;
            this.buttonChange.Text = "修改数据";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(210, 226);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "删除数据";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // PV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 261);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PV";
            this.Text = "PV";
            this.Load += new System.EventHandler(this.pv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn pv_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn pv_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn pv_P;
        private System.Windows.Forms.DataGridViewTextBoxColumn pv_Pmax;
        private System.Windows.Forms.DataGridViewTextBoxColumn pv_Pmin;
    }
}