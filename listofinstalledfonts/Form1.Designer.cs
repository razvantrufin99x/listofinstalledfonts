namespace listofinstalledfonts
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
            this.button1 = new System.Windows.Forms.Button();
            this.pnlFonts = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fontLabelx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 89);
            this.button1.TabIndex = 1;
            this.button1.Text = "ShowAllFonts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlFonts
            // 
            this.pnlFonts.AutoScroll = true;
            this.pnlFonts.BackColor = System.Drawing.Color.White;
            this.pnlFonts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFonts.Location = new System.Drawing.Point(93, 107);
            this.pnlFonts.Name = "pnlFonts";
            this.pnlFonts.Size = new System.Drawing.Size(432, 311);
            this.pnlFonts.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(432, 39);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseMove);
            // 
            // fontLabelx
            // 
            this.fontLabelx.AutoSize = true;
            this.fontLabelx.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontLabelx.Location = new System.Drawing.Point(93, 13);
            this.fontLabelx.Name = "fontLabelx";
            this.fontLabelx.Size = new System.Drawing.Size(72, 31);
            this.fontLabelx.TabIndex = 4;
            this.fontLabelx.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 442);
            this.Controls.Add(this.fontLabelx);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pnlFonts);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Fonts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlFonts;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label fontLabelx;
    }
}

