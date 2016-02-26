namespace Rq.Dgrh
{
    partial class frmEvents
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEnlever = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.runningButton1 = new Rq.Dgrh.RunningButton();
            this.coloredButton2 = new Rq.Dgrh.ColoredButton();
            this.coloredButton1 = new Rq.Dgrh.ColoredButton();
            this.numericTextbox1 = new Rq.Dgrh.NumericTextbox();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(39, 33);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnEnlever
            // 
            this.btnEnlever.Location = new System.Drawing.Point(145, 32);
            this.btnEnlever.Name = "btnEnlever";
            this.btnEnlever.Size = new System.Drawing.Size(75, 23);
            this.btnEnlever.TabIndex = 1;
            this.btnEnlever.Text = "Enlever";
            this.btnEnlever.UseVisualStyleBackColor = true;
            this.btnEnlever.Click += new System.EventHandler(this.btnEnlever_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(91, 111);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // runningButton1
            // 
            this.runningButton1.Location = new System.Drawing.Point(197, 174);
            this.runningButton1.Name = "runningButton1";
            this.runningButton1.Size = new System.Drawing.Size(75, 23);
            this.runningButton1.TabIndex = 5;
            this.runningButton1.Text = "runningButton1";
            this.runningButton1.UseVisualStyleBackColor = true;
            // 
            // coloredButton2
            // 
            this.coloredButton2.Location = new System.Drawing.Point(39, 213);
            this.coloredButton2.Name = "coloredButton2";
            this.coloredButton2.Size = new System.Drawing.Size(75, 23);
            this.coloredButton2.TabIndex = 4;
            this.coloredButton2.Text = "coloredButton2";
            this.coloredButton2.UseVisualStyleBackColor = true;
            // 
            // coloredButton1
            // 
            this.coloredButton1.Location = new System.Drawing.Point(39, 174);
            this.coloredButton1.Name = "coloredButton1";
            this.coloredButton1.Size = new System.Drawing.Size(127, 23);
            this.coloredButton1.TabIndex = 3;
            this.coloredButton1.Text = "coloredButton1";
            this.coloredButton1.UseVisualStyleBackColor = true;
            // 
            // numericTextbox1
            // 
            this.numericTextbox1.Location = new System.Drawing.Point(39, 71);
            this.numericTextbox1.Name = "numericTextbox1";
            this.numericTextbox1.Size = new System.Drawing.Size(100, 20);
            this.numericTextbox1.TabIndex = 6;
            // 
            // frmEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.numericTextbox1);
            this.Controls.Add(this.runningButton1);
            this.Controls.Add(this.coloredButton2);
            this.Controls.Add(this.coloredButton1);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnEnlever);
            this.Controls.Add(this.btnAjouter);
            this.Name = "frmEvents";
            this.Text = "frmEvents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEnlever;
        private System.Windows.Forms.Button btnTest;
        private ColoredButton coloredButton1;
        private ColoredButton coloredButton2;
        private RunningButton runningButton1;
        private NumericTextbox numericTextbox1;
    }
}