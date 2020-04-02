using System.Windows.Forms;

namespace SimpleTool.ToolWindows
{
    partial class InitialSetup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkDebug = new System.Windows.Forms.CheckBox();
            this.chkVM = new System.Windows.Forms.CheckBox();
            this.btnSetupDone = new System.Windows.Forms.Button();
            this.btnGenerateConKey = new System.Windows.Forms.Button();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.txtConKey = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkDebug);
            this.groupBox1.Controls.Add(this.chkVM);
            this.groupBox1.Controls.Add(this.btnSetupDone);
            this.groupBox1.Controls.Add(this.btnGenerateConKey);
            this.groupBox1.Controls.Add(this.btnGenerateKeys);
            this.groupBox1.Controls.Add(this.txtConKey);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Config Options";
            // 
            // chkDebug
            // 
            this.chkDebug.AutoSize = true;
            this.chkDebug.Location = new System.Drawing.Point(234, 125);
            this.chkDebug.Name = "chkDebug";
            this.chkDebug.Size = new System.Drawing.Size(99, 17);
            this.chkDebug.TabIndex = 9;
            this.chkDebug.Text = "Debug Logging";
            this.chkDebug.UseVisualStyleBackColor = true;
            // 
            // chkVM
            // 
            this.chkVM.AutoSize = true;
            this.chkVM.Location = new System.Drawing.Point(149, 125);
            this.chkVM.Name = "chkVM";
            this.chkVM.Size = new System.Drawing.Size(63, 17);
            this.chkVM.TabIndex = 8;
            this.chkVM.Text = "Anti VM";
            this.chkVM.UseVisualStyleBackColor = true;
            this.chkVM.CheckedChanged += new System.EventHandler(this.chkVM_CheckedChanged);
            // 
            // btnSetupDone
            // 
            this.btnSetupDone.Location = new System.Drawing.Point(359, 113);
            this.btnSetupDone.Name = "btnSetupDone";
            this.btnSetupDone.Size = new System.Drawing.Size(114, 38);
            this.btnSetupDone.TabIndex = 7;
            this.btnSetupDone.Text = "Save and continue!";
            this.btnSetupDone.UseVisualStyleBackColor = true;
            this.btnSetupDone.Click += new System.EventHandler(this.btnSetupDone_Click);
            // 
            // btnGenerateConKey
            // 
            this.btnGenerateConKey.Location = new System.Drawing.Point(359, 55);
            this.btnGenerateConKey.Name = "btnGenerateConKey";
            this.btnGenerateConKey.Size = new System.Drawing.Size(114, 23);
            this.btnGenerateConKey.TabIndex = 6;
            this.btnGenerateConKey.Text = "Generate Key";
            this.btnGenerateConKey.UseVisualStyleBackColor = true;
            this.btnGenerateConKey.Click += new System.EventHandler(this.btnGenerateConKey_Click);
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Location = new System.Drawing.Point(98, 91);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(114, 23);
            this.btnGenerateKeys.TabIndex = 5;
            this.btnGenerateKeys.Text = "Generate";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // txtConKey
            // 
            this.txtConKey.Location = new System.Drawing.Point(106, 57);
            this.txtConKey.Name = "txtConKey";
            this.txtConKey.Size = new System.Drawing.Size(247, 20);
            this.txtConKey.TabIndex = 4;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(50, 26);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Key Collection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Connection Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // InitialSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 179);
            this.Controls.Add(this.groupBox1);
            this.Name = "InitialSetup";
            this.Text = "InitialSetup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPort;
        private Button btnGenerateKeys;
        private TextBox txtConKey;
        private Button btnGenerateConKey;
        private Button btnSetupDone;
        private CheckBox chkDebug;
        private CheckBox chkVM;
    }
}