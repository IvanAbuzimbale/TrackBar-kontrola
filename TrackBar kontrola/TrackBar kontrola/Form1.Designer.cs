
namespace TrackBar_kontrola
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
            this.trackBar1_Scroll = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.TekstniBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1_Scroll)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1_Scroll
            // 
            this.trackBar1_Scroll.Location = new System.Drawing.Point(12, 12);
            this.trackBar1_Scroll.Maximum = 100;
            this.trackBar1_Scroll.Name = "trackBar1_Scroll";
            this.trackBar1_Scroll.Size = new System.Drawing.Size(216, 45);
            this.trackBar1_Scroll.SmallChange = 5;
            this.trackBar1_Scroll.TabIndex = 0;
            this.trackBar1_Scroll.TickFrequency = 10;
            this.trackBar1_Scroll.Scroll += new System.EventHandler(this.trackBar1_Scroll_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Postavljena vrijednost je: ";
            // 
            // TekstniBox
            // 
            this.TekstniBox.Location = new System.Drawing.Point(146, 61);
            this.TekstniBox.Name = "TekstniBox";
            this.TekstniBox.Size = new System.Drawing.Size(82, 20);
            this.TekstniBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TekstniBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1_Scroll);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1_Scroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1_Scroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TekstniBox;
    }
}

