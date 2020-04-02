namespace SimpleTool.ToolWindows
{
    partial class AllClientWorkUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbExecution = new System.Windows.Forms.TabPage();
            this.tbRecovery = new System.Windows.Forms.TabPage();
            this.tbOther = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.grpPlugin = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNamespace = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblFunction = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbExecution.SuspendLayout();
            this.tbRecovery.SuspendLayout();
            this.tbOther.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpPlugin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbExecution);
            this.tabControl1.Controls.Add(this.tbRecovery);
            this.tabControl1.Controls.Add(this.tbOther);
            this.tabControl1.Location = new System.Drawing.Point(12, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 317);
            this.tabControl1.TabIndex = 0;
            // 
            // tbExecution
            // 
            this.tbExecution.Controls.Add(this.groupBox1);
            this.tbExecution.Controls.Add(this.btnBrowse);
            this.tbExecution.Controls.Add(this.txtFilePath);
            this.tbExecution.Controls.Add(this.label1);
            this.tbExecution.Location = new System.Drawing.Point(4, 22);
            this.tbExecution.Name = "tbExecution";
            this.tbExecution.Padding = new System.Windows.Forms.Padding(3);
            this.tbExecution.Size = new System.Drawing.Size(489, 291);
            this.tbExecution.TabIndex = 0;
            this.tbExecution.Text = "Execution";
            this.tbExecution.UseVisualStyleBackColor = true;
            // 
            // tbRecovery
            // 
            this.tbRecovery.Controls.Add(this.button13);
            this.tbRecovery.Controls.Add(this.button12);
            this.tbRecovery.Controls.Add(this.button11);
            this.tbRecovery.Controls.Add(this.button10);
            this.tbRecovery.Location = new System.Drawing.Point(4, 22);
            this.tbRecovery.Name = "tbRecovery";
            this.tbRecovery.Padding = new System.Windows.Forms.Padding(3);
            this.tbRecovery.Size = new System.Drawing.Size(489, 291);
            this.tbRecovery.TabIndex = 1;
            this.tbRecovery.Text = "Recovery";
            this.tbRecovery.UseVisualStyleBackColor = true;
            // 
            // tbOther
            // 
            this.tbOther.Controls.Add(this.button9);
            this.tbOther.Controls.Add(this.button8);
            this.tbOther.Controls.Add(this.button7);
            this.tbOther.Controls.Add(this.groupBox2);
            this.tbOther.Location = new System.Drawing.Point(4, 22);
            this.tbOther.Name = "tbOther";
            this.tbOther.Size = new System.Drawing.Size(489, 291);
            this.tbOther.TabIndex = 2;
            this.tbOther.Text = "Other...";
            this.tbOther.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(31, 29);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(371, 20);
            this.txtFilePath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(408, 27);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(345, 8);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(429, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpPlugin);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(31, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 175);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Work Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Execution Type:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(96, 25);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(16, 13);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "File Size:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(246, 25);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(16, 13);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "...";
            // 
            // grpPlugin
            // 
            this.grpPlugin.Controls.Add(this.lblFunction);
            this.grpPlugin.Controls.Add(this.label6);
            this.grpPlugin.Controls.Add(this.lblClass);
            this.grpPlugin.Controls.Add(this.label5);
            this.grpPlugin.Controls.Add(this.lblNamespace);
            this.grpPlugin.Controls.Add(this.label4);
            this.grpPlugin.Location = new System.Drawing.Point(24, 63);
            this.grpPlugin.Name = "grpPlugin";
            this.grpPlugin.Size = new System.Drawing.Size(323, 90);
            this.grpPlugin.TabIndex = 4;
            this.grpPlugin.TabStop = false;
            this.grpPlugin.Text = "Plugin Details";
            this.grpPlugin.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Namespace:";
            // 
            // lblNamespace
            // 
            this.lblNamespace.AutoSize = true;
            this.lblNamespace.Location = new System.Drawing.Point(79, 22);
            this.lblNamespace.Name = "lblNamespace";
            this.lblNamespace.Size = new System.Drawing.Size(16, 13);
            this.lblNamespace.TabIndex = 1;
            this.lblNamespace.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Class:";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(46, 40);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(16, 13);
            this.lblClass.TabIndex = 3;
            this.lblClass.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Function:";
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(60, 59);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(16, 13);
            this.lblFunction.TabIndex = 5;
            this.lblFunction.Text = "...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(19, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 83);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Killers and Disablers";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kill Bots";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Disable/Stop TaskManagers";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(286, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Disable/Stop Cmd";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 48);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Disable WD";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(104, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Disable/Stop RegEdit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(286, 48);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Disable Browsers";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(111, 105);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 44);
            this.button7.TabIndex = 1;
            this.button7.Text = "Send Message";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(209, 105);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 44);
            this.button8.TabIndex = 2;
            this.button8.Text = "Open Website";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(307, 105);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 44);
            this.button9.TabIndex = 3;
            this.button9.Text = "Wipe Temp Files";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(41, 19);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(96, 35);
            this.button10.TabIndex = 0;
            this.button10.Text = "Steam Session Files";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(143, 19);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(96, 35);
            this.button11.TabIndex = 1;
            this.button11.Text = "Potential Crypto Wallet Keys";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(245, 19);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(96, 35);
            this.button12.TabIndex = 2;
            this.button12.Text = "Browser SQLite DB\'s";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(347, 19);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(96, 35);
            this.button13.TabIndex = 3;
            this.button13.Text = "FTP and SSH logins and keys";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // AllClientWorkUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 340);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tabControl1);
            this.Name = "AllClientWorkUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create a task for all clients";
            this.tabControl1.ResumeLayout(false);
            this.tbExecution.ResumeLayout(false);
            this.tbExecution.PerformLayout();
            this.tbRecovery.ResumeLayout(false);
            this.tbOther.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpPlugin.ResumeLayout(false);
            this.grpPlugin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbExecution;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbRecovery;
        private System.Windows.Forms.TabPage tbOther;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.GroupBox grpPlugin;
        private System.Windows.Forms.Label lblNamespace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
    }
}