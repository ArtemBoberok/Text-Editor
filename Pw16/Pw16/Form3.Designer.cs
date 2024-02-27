
namespace Pw16
{
    partial class Form3
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
            this.buttonPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPDF
            // 
            this.buttonPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPDF.Location = new System.Drawing.Point(76, 60);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(124, 60);
            this.buttonPDF.TabIndex = 0;
            this.buttonPDF.Text = "Создать PDF";
            this.buttonPDF.UseVisualStyleBackColor = true;
            this.buttonPDF.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(280, 188);
            this.Controls.Add(this.buttonPDF);
            this.Name = "Form3";
            this.Text = "Создание PDF документа";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPDF;
    }
}