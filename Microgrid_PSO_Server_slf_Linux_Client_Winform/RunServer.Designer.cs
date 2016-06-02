namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    partial class RunServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunServer));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OutputTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputBattery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputWindM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputExchange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonDrawResult = new System.Windows.Forms.Button();
            this.buttonFresh = new System.Windows.Forms.Button();
            this.buttonDrawOutput = new System.Windows.Forms.Button();
            this.buttonSOC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_algorithm_id = new System.Windows.Forms.ComboBox();
            this.buttonHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.n,
            this.f});
            this.dataGridView2.Location = new System.Drawing.Point(563, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(234, 280);
            this.dataGridView2.TabIndex = 4;
            // 
            // n
            // 
            this.n.HeaderText = "迭代次数";
            this.n.Name = "n";
            // 
            // f
            // 
            this.f.HeaderText = "运营成本";
            this.f.Name = "f";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OutputTime,
            this.OutputBattery,
            this.OutputPV,
            this.OutputWindM,
            this.OutputExchange,
            this.OutputTotal,
            this.SOC});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(531, 280);
            this.dataGridView1.TabIndex = 5;
            // 
            // OutputTime
            // 
            this.OutputTime.HeaderText = "时间段";
            this.OutputTime.Name = "OutputTime";
            // 
            // OutputBattery
            // 
            this.OutputBattery.HeaderText = "蓄电池出力";
            this.OutputBattery.Name = "OutputBattery";
            // 
            // OutputPV
            // 
            this.OutputPV.HeaderText = "光伏出力";
            this.OutputPV.Name = "OutputPV";
            // 
            // OutputWindM
            // 
            this.OutputWindM.HeaderText = "风电出力";
            this.OutputWindM.Name = "OutputWindM";
            // 
            // OutputExchange
            // 
            this.OutputExchange.HeaderText = "交换功率";
            this.OutputExchange.Name = "OutputExchange";
            // 
            // OutputTotal
            // 
            this.OutputTotal.HeaderText = "总出力";
            this.OutputTotal.Name = "OutputTotal";
            // 
            // SOC
            // 
            this.SOC.HeaderText = "蓄电池容量";
            this.SOC.Name = "SOC";
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(722, 320);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 7;
            this.buttonRun.Text = "开始运行";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonDrawResult
            // 
            this.buttonDrawResult.Location = new System.Drawing.Point(23, 320);
            this.buttonDrawResult.Name = "buttonDrawResult";
            this.buttonDrawResult.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawResult.TabIndex = 8;
            this.buttonDrawResult.Text = "收敛曲线";
            this.buttonDrawResult.UseVisualStyleBackColor = true;
            this.buttonDrawResult.Click += new System.EventHandler(this.buttonDrawResult_Click);
            // 
            // buttonFresh
            // 
            this.buttonFresh.Location = new System.Drawing.Point(307, 320);
            this.buttonFresh.Name = "buttonFresh";
            this.buttonFresh.Size = new System.Drawing.Size(75, 23);
            this.buttonFresh.TabIndex = 9;
            this.buttonFresh.Text = "刷新";
            this.buttonFresh.UseVisualStyleBackColor = true;
            this.buttonFresh.Click += new System.EventHandler(this.buttonFresh_Click);
            // 
            // buttonDrawOutput
            // 
            this.buttonDrawOutput.Location = new System.Drawing.Point(116, 320);
            this.buttonDrawOutput.Name = "buttonDrawOutput";
            this.buttonDrawOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonDrawOutput.TabIndex = 10;
            this.buttonDrawOutput.Text = "出力分配";
            this.buttonDrawOutput.UseVisualStyleBackColor = true;
            this.buttonDrawOutput.Click += new System.EventHandler(this.buttonDrawOutput_Click);
            // 
            // buttonSOC
            // 
            this.buttonSOC.Location = new System.Drawing.Point(211, 320);
            this.buttonSOC.Name = "buttonSOC";
            this.buttonSOC.Size = new System.Drawing.Size(75, 23);
            this.buttonSOC.TabIndex = 11;
            this.buttonSOC.Text = "蓄电池容量";
            this.buttonSOC.UseVisualStyleBackColor = true;
            this.buttonSOC.Click += new System.EventHandler(this.buttonSOC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(504, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "算法编号 = ";
            // 
            // comboBox_algorithm_id
            // 
            this.comboBox_algorithm_id.FormattingEnabled = true;
            this.comboBox_algorithm_id.Location = new System.Drawing.Point(581, 320);
            this.comboBox_algorithm_id.Name = "comboBox_algorithm_id";
            this.comboBox_algorithm_id.Size = new System.Drawing.Size(121, 20);
            this.comboBox_algorithm_id.TabIndex = 13;
            this.comboBox_algorithm_id.SelectedIndexChanged += new System.EventHandler(this.comboBox_algorithm_id_SelectedIndexChanged);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(403, 320);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(75, 23);
            this.buttonHistory.TabIndex = 14;
            this.buttonHistory.Text = "历史纪录";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // RunServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 355);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.comboBox_algorithm_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSOC);
            this.Controls.Add(this.buttonDrawOutput);
            this.Controls.Add(this.buttonFresh);
            this.Controls.Add(this.buttonDrawResult);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RunServer";
            this.Text = "RunServer";
            this.Load += new System.EventHandler(this.results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn n;
        private System.Windows.Forms.DataGridViewTextBoxColumn f;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonDrawResult;
        private System.Windows.Forms.Button buttonFresh;
        private System.Windows.Forms.Button buttonDrawOutput;
        private System.Windows.Forms.Button buttonSOC;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox_algorithm_id;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputBattery;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputPV;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputWindM;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputExchange;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOC;
    }
}