
namespace SimpleChiaPlotter
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.lblDeamonDirectory = new System.Windows.Forms.Label();
            this.textBoxDeamonDirectory = new System.Windows.Forms.TextBox();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblExecutable = new System.Windows.Forms.Label();
            this.btnExecutable = new System.Windows.Forms.Button();
            this.textBoxExecutable = new System.Windows.Forms.TextBox();
            this.groupBoxSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeamonDirectory
            // 
            this.lblDeamonDirectory.AutoSize = true;
            this.lblDeamonDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeamonDirectory.Location = new System.Drawing.Point(57, 45);
            this.lblDeamonDirectory.Name = "lblDeamonDirectory";
            this.lblDeamonDirectory.Size = new System.Drawing.Size(136, 13);
            this.lblDeamonDirectory.TabIndex = 0;
            this.lblDeamonDirectory.Text = "MADMAX plotter folder";
            // 
            // textBoxDeamonDirectory
            // 
            this.textBoxDeamonDirectory.Location = new System.Drawing.Point(60, 62);
            this.textBoxDeamonDirectory.Name = "textBoxDeamonDirectory";
            this.textBoxDeamonDirectory.Size = new System.Drawing.Size(163, 20);
            this.textBoxDeamonDirectory.TabIndex = 1;
            // 
            // btnDirectory
            // 
            this.btnDirectory.Location = new System.Drawing.Point(229, 61);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(60, 22);
            this.btnDirectory.TabIndex = 2;
            this.btnDirectory.Text = "Browse";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.btnSave);
            this.groupBoxSettings.Controls.Add(this.lblExecutable);
            this.groupBoxSettings.Controls.Add(this.btnExecutable);
            this.groupBoxSettings.Controls.Add(this.lblDeamonDirectory);
            this.groupBoxSettings.Controls.Add(this.textBoxExecutable);
            this.groupBoxSettings.Controls.Add(this.btnDirectory);
            this.groupBoxSettings.Controls.Add(this.textBoxDeamonDirectory);
            this.groupBoxSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(342, 196);
            this.groupBoxSettings.TabIndex = 3;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(107, 139);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(132, 51);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblExecutable
            // 
            this.lblExecutable.AutoSize = true;
            this.lblExecutable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExecutable.Location = new System.Drawing.Point(57, 85);
            this.lblExecutable.Name = "lblExecutable";
            this.lblExecutable.Size = new System.Drawing.Size(127, 13);
            this.lblExecutable.TabIndex = 0;
            this.lblExecutable.Text = "MADMAX Executable";
            // 
            // btnExecutable
            // 
            this.btnExecutable.Location = new System.Drawing.Point(229, 101);
            this.btnExecutable.Name = "btnExecutable";
            this.btnExecutable.Size = new System.Drawing.Size(60, 22);
            this.btnExecutable.TabIndex = 2;
            this.btnExecutable.Text = "Browse";
            this.btnExecutable.UseVisualStyleBackColor = true;
            this.btnExecutable.Click += new System.EventHandler(this.btnExecutable_Click);
            // 
            // textBoxExecutable
            // 
            this.textBoxExecutable.Location = new System.Drawing.Point(60, 102);
            this.textBoxExecutable.Name = "textBoxExecutable";
            this.textBoxExecutable.Size = new System.Drawing.Size(163, 20);
            this.textBoxExecutable.TabIndex = 1;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 218);
            this.Controls.Add(this.groupBoxSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSettings";
            this.Text = "Simple Chia MADMAX Plotter GUI Settings";
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDeamonDirectory;
        private System.Windows.Forms.TextBox textBoxDeamonDirectory;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Label lblExecutable;
        private System.Windows.Forms.Button btnExecutable;
        private System.Windows.Forms.TextBox textBoxExecutable;
        private System.Windows.Forms.Button btnSave;
    }
}