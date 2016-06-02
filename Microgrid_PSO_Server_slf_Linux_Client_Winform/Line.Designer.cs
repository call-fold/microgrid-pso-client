namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    partial class Line
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Line));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.line_index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sys_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line_fbus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line_tbus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line_r = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line_g = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line_ratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.line_pmax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(46, 266);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "插入数据";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChange.Location = new System.Drawing.Point(510, 266);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 7;
            this.buttonChange.Text = "修改数据";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(266, 266);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "删除数据";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.line_index,
            this.sys_num,
            this.line_fbus,
            this.line_tbus,
            this.line_r,
            this.line_x,
            this.line_g,
            this.line_b,
            this.line_ratio,
            this.line_pmax});
            this.dataGridView.Location = new System.Drawing.Point(12, 28);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(620, 198);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // line_index
            // 
            this.line_index.HeaderText = "线路编号";
            this.line_index.Name = "line_index";
            // 
            // sys_num
            // 
            this.sys_num.HeaderText = "系统编号";
            this.sys_num.Name = "sys_num";
            // 
            // line_fbus
            // 
            this.line_fbus.HeaderText = "上接母线编号";
            this.line_fbus.Name = "line_fbus";
            // 
            // line_tbus
            // 
            this.line_tbus.HeaderText = "下接母线编号";
            this.line_tbus.Name = "line_tbus";
            // 
            // line_r
            // 
            this.line_r.HeaderText = "母线电阻";
            this.line_r.Name = "line_r";
            // 
            // line_x
            // 
            this.line_x.HeaderText = "母线电抗";
            this.line_x.Name = "line_x";
            // 
            // line_g
            // 
            this.line_g.HeaderText = "对地电导";
            this.line_g.Name = "line_g";
            // 
            // line_b
            // 
            this.line_b.HeaderText = "对地电纳";
            this.line_b.Name = "line_b";
            // 
            // line_ratio
            // 
            this.line_ratio.HeaderText = "变压器变比";
            this.line_ratio.Name = "line_ratio";
            // 
            // line_pmax
            // 
            this.line_pmax.HeaderText = "线路功率最大值";
            this.line_pmax.Name = "line_pmax";
            // 
            // Line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 343);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonDelete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Line";
            this.Text = "Line";
            this.Load += new System.EventHandler(this.line_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn line_index;
        private System.Windows.Forms.DataGridViewTextBoxColumn sys_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn line_fbus;
        private System.Windows.Forms.DataGridViewTextBoxColumn line_tbus;
        private System.Windows.Forms.DataGridViewTextBoxColumn line_r;
        private System.Windows.Forms.DataGridViewTextBoxColumn line_x;
        private System.Windows.Forms.DataGridViewTextBoxColumn line_g;
        private System.Windows.Forms.DataGridViewTextBoxColumn line_b;
        private System.Windows.Forms.DataGridViewTextBoxColumn line_ratio;
        private System.Windows.Forms.DataGridViewTextBoxColumn line_pmax;
    }
}