namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    partial class Battery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battery));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bat_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bus_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bat_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bat_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bat_Pmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bat_Pmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.bat_num,
            this.bus_index,
            this.bat_time,
            this.bat_p,
            this.bat_Pmax,
            this.bat_Pmin});
            this.dataGridView.Location = new System.Drawing.Point(12, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(493, 219);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // bat_num
            // 
            this.bat_num.HeaderText = "编号";
            this.bat_num.Name = "bat_num";
            // 
            // bus_index
            // 
            this.bus_index.HeaderText = "母线编号";
            this.bus_index.Name = "bus_index";
            // 
            // bat_time
            // 
            this.bat_time.HeaderText = "时间段";
            this.bat_time.Name = "bat_time";
            // 
            // bat_p
            // 
            this.bat_p.HeaderText = "蓄电池功率";
            this.bat_p.Name = "bat_p";
            // 
            // bat_Pmax
            // 
            this.bat_Pmax.HeaderText = "有功功率上限";
            this.bat_Pmax.Name = "bat_Pmax";
            // 
            // bat_Pmin
            // 
            this.bat_Pmin.HeaderText = "有功功率下限";
            this.bat_Pmin.Name = "bat_Pmin";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(48, 253);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "插入数据";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChange.Location = new System.Drawing.Point(382, 253);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 19;
            this.buttonChange.Text = "修改数据";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(216, 253);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 18;
            this.buttonDelete.Text = "删除数据";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Battery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 288);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Battery";
            this.Text = "Battery";
            this.Load += new System.EventHandler(this.battery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn bat_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn bus_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn bat_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn bat_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn bat_Pmax;
        private System.Windows.Forms.DataGridViewTextBoxColumn bat_Pmin;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
    }
}