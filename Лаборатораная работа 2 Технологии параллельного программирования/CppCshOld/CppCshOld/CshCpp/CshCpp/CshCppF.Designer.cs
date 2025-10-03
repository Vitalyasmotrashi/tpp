namespace CshCpp
{
    partial class CshCppF
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
            this.lbl_CoI = new System.Windows.Forms.Label();
            this.tbCI = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnCsh = new System.Windows.Forms.Button();
            this.lblCsh = new System.Windows.Forms.Label();
            this.btnCpp = new System.Windows.Forms.Button();
            this.lblCpp = new System.Windows.Forms.Label();
            this.lblXMM = new System.Windows.Forms.Label();
            this.btnXMM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_CoI
            // 
            this.lbl_CoI.AutoSize = true;
            this.lbl_CoI.Location = new System.Drawing.Point(13, 21);
            this.lbl_CoI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CoI.Name = "lbl_CoI";
            this.lbl_CoI.Size = new System.Drawing.Size(62, 13);
            this.lbl_CoI.TabIndex = 0;
            this.lbl_CoI.Text = "Items count";
            // 
            // tbCI
            // 
            this.tbCI.Location = new System.Drawing.Point(92, 17);
            this.tbCI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCI.Name = "tbCI";
            this.tbCI.Size = new System.Drawing.Size(108, 20);
            this.tbCI.TabIndex = 1;
            this.tbCI.Text = "16";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(9, 47);
            this.btnGen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(56, 19);
            this.btnGen.TabIndex = 2;
            this.btnGen.Text = "Gen";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnCsh
            // 
            this.btnCsh.Location = new System.Drawing.Point(9, 82);
            this.btnCsh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCsh.Name = "btnCsh";
            this.btnCsh.Size = new System.Drawing.Size(56, 21);
            this.btnCsh.TabIndex = 3;
            this.btnCsh.Text = "C#";
            this.btnCsh.UseVisualStyleBackColor = true;
            this.btnCsh.Click += new System.EventHandler(this.btnCsh_Click);
            // 
            // lblCsh
            // 
            this.lblCsh.AutoSize = true;
            this.lblCsh.Location = new System.Drawing.Point(92, 82);
            this.lblCsh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCsh.Name = "lblCsh";
            this.lblCsh.Size = new System.Drawing.Size(40, 13);
            this.lblCsh.TabIndex = 4;
            this.lblCsh.Text = "Out c#";
            // 
            // btnCpp
            // 
            this.btnCpp.Location = new System.Drawing.Point(10, 116);
            this.btnCpp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCpp.Name = "btnCpp";
            this.btnCpp.Size = new System.Drawing.Size(56, 19);
            this.btnCpp.TabIndex = 5;
            this.btnCpp.Text = "C++";
            this.btnCpp.UseVisualStyleBackColor = true;
            this.btnCpp.Click += new System.EventHandler(this.btnCpp_Click);
            // 
            // lblCpp
            // 
            this.lblCpp.AutoSize = true;
            this.lblCpp.Location = new System.Drawing.Point(92, 119);
            this.lblCpp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpp.Name = "lblCpp";
            this.lblCpp.Size = new System.Drawing.Size(46, 13);
            this.lblCpp.TabIndex = 6;
            this.lblCpp.Text = "Out C++";
            // 
            // lblXMM
            // 
            this.lblXMM.AutoSize = true;
            this.lblXMM.Location = new System.Drawing.Point(93, 148);
            this.lblXMM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXMM.Name = "lblXMM";
            this.lblXMM.Size = new System.Drawing.Size(0, 13);
            this.lblXMM.TabIndex = 7;
            // 
            // btnXMM
            // 
            this.btnXMM.Location = new System.Drawing.Point(14, 145);
            this.btnXMM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXMM.Name = "btnXMM";
            this.btnXMM.Size = new System.Drawing.Size(52, 24);
            this.btnXMM.TabIndex = 8;
            this.btnXMM.Text = "XMM";
            this.btnXMM.UseVisualStyleBackColor = true;
            this.btnXMM.Click += new System.EventHandler(this.btnXMM_Click);
            // 
            // CshCppF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 206);
            this.Controls.Add(this.btnXMM);
            this.Controls.Add(this.lblXMM);
            this.Controls.Add(this.lblCpp);
            this.Controls.Add(this.btnCpp);
            this.Controls.Add(this.lblCsh);
            this.Controls.Add(this.btnCsh);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.tbCI);
            this.Controls.Add(this.lbl_CoI);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CshCppF";
            this.Text = "C# C++ DLL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CoI;
        private System.Windows.Forms.TextBox tbCI;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnCsh;
        private System.Windows.Forms.Label lblCsh;
        private System.Windows.Forms.Button btnCpp;
        private System.Windows.Forms.Label lblCpp;
        private System.Windows.Forms.Label lblXMM;
        private System.Windows.Forms.Button btnXMM;
    }
}

