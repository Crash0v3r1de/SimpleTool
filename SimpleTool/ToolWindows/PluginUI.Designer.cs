namespace SimpleTool.ToolWindows
{
    partial class PluginUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSendPluginData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstNamespaces = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstClasses = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstFunctions = new System.Windows.Forms.ListBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File:";
            // 
            // txtLocation
            // 
            this.txtLocation.Enabled = false;
            this.txtLocation.Location = new System.Drawing.Point(53, 18);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(419, 20);
            this.txtLocation.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(478, 16);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSendPluginData);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lstNamespaces);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lstClasses);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lstFunctions);
            this.groupBox1.Controls.Add(this.lblFileName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(53, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 124);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plugin Details";
            // 
            // btnSendPluginData
            // 
            this.btnSendPluginData.Location = new System.Drawing.Point(281, 13);
            this.btnSendPluginData.Name = "btnSendPluginData";
            this.btnSendPluginData.Size = new System.Drawing.Size(213, 27);
            this.btnSendPluginData.TabIndex = 8;
            this.btnSendPluginData.Text = "Send Selected Plugin Functions";
            this.btnSendPluginData.UseVisualStyleBackColor = true;
            this.btnSendPluginData.Click += new System.EventHandler(this.btnSendPluginData_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Namespace\'s";
            // 
            // lstNamespaces
            // 
            this.lstNamespaces.FormattingEnabled = true;
            this.lstNamespaces.Location = new System.Drawing.Point(335, 57);
            this.lstNamespaces.Name = "lstNamespaces";
            this.lstNamespaces.Size = new System.Drawing.Size(159, 56);
            this.lstNamespaces.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Public Classes";
            // 
            // lstClasses
            // 
            this.lstClasses.FormattingEnabled = true;
            this.lstClasses.Location = new System.Drawing.Point(18, 57);
            this.lstClasses.Name = "lstClasses";
            this.lstClasses.Size = new System.Drawing.Size(147, 56);
            this.lstClasses.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Public Functions";
            // 
            // lstFunctions
            // 
            this.lstFunctions.FormattingEnabled = true;
            this.lstFunctions.Location = new System.Drawing.Point(171, 57);
            this.lstFunctions.Name = "lstFunctions";
            this.lstFunctions.Size = new System.Drawing.Size(158, 56);
            this.lstFunctions.TabIndex = 2;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(70, 19);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(61, 13);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "File name...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "File Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(507, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PluginUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 198);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label1);
            this.Name = "PluginUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PluginUI";
            this.Load += new System.EventHandler(this.PluginUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstNamespaces;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstClasses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstFunctions;
        private System.Windows.Forms.Button btnSendPluginData;
        private System.Windows.Forms.Button btnCancel;
    }
}