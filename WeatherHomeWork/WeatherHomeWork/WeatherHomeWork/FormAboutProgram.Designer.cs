namespace WeatherHomeWork
{
    partial class FormAboutProgram
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
            this.lblAboutProgram = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAboutProgram
            // 
            this.lblAboutProgram.AutoSize = true;
            this.lblAboutProgram.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAboutProgram.Location = new System.Drawing.Point(60, 49);
            this.lblAboutProgram.Name = "lblAboutProgram";
            this.lblAboutProgram.Size = new System.Drawing.Size(51, 19);
            this.lblAboutProgram.TabIndex = 0;
            this.lblAboutProgram.Text = "label1";
            // 
            // FormAboutProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 369);
            this.Controls.Add(this.lblAboutProgram);
            this.Name = "FormAboutProgram";
            this.Text = "FormAboutProgram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAboutProgram;
    }
}