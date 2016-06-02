namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.history_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.algorithm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gather_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.g_max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.process_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonMoreThings = new System.Windows.Forms.Button();
            this.buttonFresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.history_id,
            this.algorithm_id,
            this.cost_time,
            this.result,
            this.iter,
            this.gather_num,
            this.g_max,
            this.process_num,
            this.date_time});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(929, 227);
            this.dataGridView.TabIndex = 3;
            // 
            // history_id
            // 
            this.history_id.HeaderText = "记录编号";
            this.history_id.Name = "history_id";
            // 
            // algorithm_id
            // 
            this.algorithm_id.HeaderText = "算法编号";
            this.algorithm_id.Name = "algorithm_id";
            // 
            // cost_time
            // 
            this.cost_time.HeaderText = "运行时间";
            this.cost_time.Name = "cost_time";
            // 
            // result
            // 
            this.result.HeaderText = "计算结果";
            this.result.Name = "result";
            // 
            // iter
            // 
            this.iter.HeaderText = "迭代次数";
            this.iter.Name = "iter";
            // 
            // gather_num
            // 
            this.gather_num.HeaderText = "集合次数";
            this.gather_num.Name = "gather_num";
            // 
            // g_max
            // 
            this.g_max.HeaderText = "粒子数";
            this.g_max.Name = "g_max";
            // 
            // process_num
            // 
            this.process_num.HeaderText = "进程数";
            this.process_num.Name = "process_num";
            // 
            // date_time
            // 
            this.date_time.HeaderText = "记录时间";
            this.date_time.Name = "date_time";
            this.date_time.Width = 200;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(576, 249);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "删除记录";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonMoreThings
            // 
            this.buttonMoreThings.Location = new System.Drawing.Point(306, 249);
            this.buttonMoreThings.Name = "buttonMoreThings";
            this.buttonMoreThings.Size = new System.Drawing.Size(75, 23);
            this.buttonMoreThings.TabIndex = 6;
            this.buttonMoreThings.Text = "详细信息";
            this.buttonMoreThings.UseVisualStyleBackColor = true;
            this.buttonMoreThings.Click += new System.EventHandler(this.buttonMoreThings_Click);
            // 
            // buttonFresh
            // 
            this.buttonFresh.Location = new System.Drawing.Point(442, 249);
            this.buttonFresh.Name = "buttonFresh";
            this.buttonFresh.Size = new System.Drawing.Size(75, 23);
            this.buttonFresh.TabIndex = 7;
            this.buttonFresh.Text = "刷新";
            this.buttonFresh.UseVisualStyleBackColor = true;
            this.buttonFresh.Click += new System.EventHandler(this.buttonFresh_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 284);
            this.Controls.Add(this.buttonFresh);
            this.Controls.Add(this.buttonMoreThings);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn history_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn algorithm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn iter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gather_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn g_max;
        private System.Windows.Forms.DataGridViewTextBoxColumn process_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_time;
        private System.Windows.Forms.Button buttonMoreThings;
        private System.Windows.Forms.Button buttonFresh;
    }
}