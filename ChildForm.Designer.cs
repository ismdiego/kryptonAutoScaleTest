namespace AutoScaleTest
{
    partial class ChildForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStd1 = new System.Windows.Forms.Label();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.lblStd2 = new System.Windows.Forms.Label();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "200 x 100 px (original)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(9, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // lblStd1
            // 
            this.lblStd1.AutoSize = true;
            this.lblStd1.Location = new System.Drawing.Point(212, 20);
            this.lblStd1.Name = "lblStd1";
            this.lblStd1.Size = new System.Drawing.Size(173, 13);
            this.lblStd1.TabIndex = 5;
            this.lblStd1.Text = "Standard label at base font (8.25pt)";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(15, 174);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(207, 20);
            this.kryptonLabel1.TabIndex = 6;
            this.kryptonLabel1.Values.Text = "Krypton Label (style Normal - panel)";
            // 
            // lblStd2
            // 
            this.lblStd2.AutoSize = true;
            this.lblStd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStd2.Location = new System.Drawing.Point(212, 46);
            this.lblStd2.Name = "lblStd2";
            this.lblStd2.Size = new System.Drawing.Size(297, 29);
            this.lblStd2.TabIndex = 7;
            this.lblStd2.Text = "Standard label at 18 points";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(15, 200);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(303, 29);
            this.kryptonLabel2.TabIndex = 8;
            this.kryptonLabel2.Values.Text = "Krypton Label (style Title - panel)";
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 250);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.lblStd2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.lblStd1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStd1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.Label lblStd2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}