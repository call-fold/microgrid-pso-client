namespace Microgrid_PSO_Server_slf_Linux_Client_Winform
{
    partial class Component
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Component));
            this.buttonWindM = new System.Windows.Forms.Button();
            this.buttonPV = new System.Windows.Forms.Button();
            this.buttonBat = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonBus = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonWindM
            // 
            this.buttonWindM.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonWindM.Location = new System.Drawing.Point(162, 51);
            this.buttonWindM.Name = "buttonWindM";
            this.buttonWindM.Size = new System.Drawing.Size(77, 23);
            this.buttonWindM.TabIndex = 14;
            this.buttonWindM.Text = "风机参数";
            this.buttonWindM.UseVisualStyleBackColor = false;
            this.buttonWindM.Click += new System.EventHandler(this.buttonWindM_Click);
            // 
            // buttonPV
            // 
            this.buttonPV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPV.Location = new System.Drawing.Point(164, 116);
            this.buttonPV.Name = "buttonPV";
            this.buttonPV.Size = new System.Drawing.Size(75, 23);
            this.buttonPV.TabIndex = 9;
            this.buttonPV.Text = "光伏参数";
            this.buttonPV.UseVisualStyleBackColor = false;
            this.buttonPV.Click += new System.EventHandler(this.buttonPV_Click);
            // 
            // buttonBat
            // 
            this.buttonBat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBat.Location = new System.Drawing.Point(164, 187);
            this.buttonBat.Name = "buttonBat";
            this.buttonBat.Size = new System.Drawing.Size(75, 23);
            this.buttonBat.TabIndex = 10;
            this.buttonBat.Text = "蓄电池参数";
            this.buttonBat.UseVisualStyleBackColor = false;
            this.buttonBat.Click += new System.EventHandler(this.buttonBat_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLoad.Location = new System.Drawing.Point(44, 187);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 11;
            this.buttonLoad.Text = "负载参数";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonBus
            // 
            this.buttonBus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBus.Location = new System.Drawing.Point(44, 116);
            this.buttonBus.Name = "buttonBus";
            this.buttonBus.Size = new System.Drawing.Size(75, 23);
            this.buttonBus.TabIndex = 12;
            this.buttonBus.Text = "母线参数";
            this.buttonBus.UseVisualStyleBackColor = false;
            this.buttonBus.Click += new System.EventHandler(this.buttonBus_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLine.Location = new System.Drawing.Point(44, 51);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(75, 23);
            this.buttonLine.TabIndex = 13;
            this.buttonLine.Text = "线路参数";
            this.buttonLine.UseVisualStyleBackColor = false;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // Component
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonWindM);
            this.Controls.Add(this.buttonPV);
            this.Controls.Add(this.buttonBat);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonBus);
            this.Controls.Add(this.buttonLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Component";
            this.Text = "Component";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWindM;
        private System.Windows.Forms.Button buttonPV;
        private System.Windows.Forms.Button buttonBat;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonBus;
        private System.Windows.Forms.Button buttonLine;
    }
}