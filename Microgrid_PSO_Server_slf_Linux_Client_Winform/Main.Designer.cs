namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonAlgorithm = new System.Windows.Forms.Button();
            this.buttonDatabase = new System.Windows.Forms.Button();
            this.buttonComponent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRun.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRun.Location = new System.Drawing.Point(205, 151);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 10;
            this.buttonRun.Text = "运行入口";
            this.buttonRun.UseVisualStyleBackColor = false;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonAlgorithm
            // 
            this.buttonAlgorithm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAlgorithm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAlgorithm.Location = new System.Drawing.Point(55, 151);
            this.buttonAlgorithm.Name = "buttonAlgorithm";
            this.buttonAlgorithm.Size = new System.Drawing.Size(75, 23);
            this.buttonAlgorithm.TabIndex = 11;
            this.buttonAlgorithm.Text = "算法参数";
            this.buttonAlgorithm.UseVisualStyleBackColor = false;
            this.buttonAlgorithm.Click += new System.EventHandler(this.buttonAlgorithm_Click);
            // 
            // buttonDatabase
            // 
            this.buttonDatabase.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDatabase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDatabase.Location = new System.Drawing.Point(205, 88);
            this.buttonDatabase.Name = "buttonDatabase";
            this.buttonDatabase.Size = new System.Drawing.Size(75, 23);
            this.buttonDatabase.TabIndex = 12;
            this.buttonDatabase.Text = "数据库参数";
            this.buttonDatabase.UseVisualStyleBackColor = false;
            this.buttonDatabase.Click += new System.EventHandler(this.buttonDatabase_Click);
            // 
            // buttonComponent
            // 
            this.buttonComponent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonComponent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonComponent.Location = new System.Drawing.Point(55, 88);
            this.buttonComponent.Name = "buttonComponent";
            this.buttonComponent.Size = new System.Drawing.Size(75, 23);
            this.buttonComponent.TabIndex = 13;
            this.buttonComponent.Text = "各部件参数";
            this.buttonComponent.UseVisualStyleBackColor = false;
            this.buttonComponent.Click += new System.EventHandler(this.buttonComponent_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 261);
            this.Controls.Add(this.buttonComponent);
            this.Controls.Add(this.buttonDatabase);
            this.Controls.Add(this.buttonAlgorithm);
            this.Controls.Add(this.buttonRun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonAlgorithm;
        private System.Windows.Forms.Button buttonDatabase;
        private System.Windows.Forms.Button buttonComponent;
    }
}