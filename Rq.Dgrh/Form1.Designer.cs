namespace Rq.Dgrh
{
    partial class Form1
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
            this.btnStringBuilder = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStringBuilder
            // 
            this.btnStringBuilder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStringBuilder.Location = new System.Drawing.Point(12, 41);
            this.btnStringBuilder.Name = "btnStringBuilder";
            this.btnStringBuilder.Size = new System.Drawing.Size(658, 233);
            this.btnStringBuilder.TabIndex = 0;
            this.btnStringBuilder.Text = "StringBuilder";
            this.btnStringBuilder.UseVisualStyleBackColor = false;
            this.btnStringBuilder.Click += new System.EventHandler(this.btnStringBuilder_Click);
            // 
            // btnString
            // 
            this.btnString.BackColor = System.Drawing.SystemColors.Info;
            this.btnString.Location = new System.Drawing.Point(12, 12);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(658, 23);
            this.btnString.TabIndex = 1;
            this.btnString.Text = "String";
            this.btnString.UseVisualStyleBackColor = false;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 286);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.btnStringBuilder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStringBuilder;
        private System.Windows.Forms.Button btnString;
    }
}

