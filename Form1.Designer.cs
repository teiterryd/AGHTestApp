namespace AGHTestApp
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
            this.btnDoNotTouch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDoNotTouch
            // 
            this.btnDoNotTouch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDoNotTouch.Location = new System.Drawing.Point(115, 99);
            this.btnDoNotTouch.Name = "btnDoNotTouch";
            this.btnDoNotTouch.Size = new System.Drawing.Size(157, 23);
            this.btnDoNotTouch.TabIndex = 0;
            this.btnDoNotTouch.Text = "Do Not Touch!";
            this.btnDoNotTouch.UseVisualStyleBackColor = false;
            this.btnDoNotTouch.Click += new System.EventHandler(this.BtnDoNotTouch_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(135, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "zzzzz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 218);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoNotTouch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoNotTouch;
        private System.Windows.Forms.Label label1;
    }
}

