namespace SimpleTool.ToolWindows
{
    partial class KeyGeneration
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
            this.btnGenNSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numKeysToMake = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKeysToMake)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenNSave
            // 
            this.btnGenNSave.Location = new System.Drawing.Point(64, 60);
            this.btnGenNSave.Name = "btnGenNSave";
            this.btnGenNSave.Size = new System.Drawing.Size(120, 60);
            this.btnGenNSave.TabIndex = 0;
            this.btnGenNSave.Text = "Generate and Save";
            this.btnGenNSave.UseVisualStyleBackColor = true;
            this.btnGenNSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "How many keys should we generate and save?";
            // 
            // numKeysToMake
            // 
            this.numKeysToMake.Location = new System.Drawing.Point(64, 34);
            this.numKeysToMake.Name = "numKeysToMake";
            this.numKeysToMake.Size = new System.Drawing.Size(120, 20);
            this.numKeysToMake.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(64, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // KeyGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 157);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.numKeysToMake);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenNSave);
            this.Name = "KeyGeneration";
            this.Text = "KeyGeneration";
            ((System.ComponentModel.ISupportInitialize)(this.numKeysToMake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenNSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numKeysToMake;
        private System.Windows.Forms.Button btnCancel;
    }
}