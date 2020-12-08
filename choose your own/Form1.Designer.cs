namespace choose_your_own
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.greenButtonOutputLabel = new System.Windows.Forms.Label();
            this.redButtonOutputLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("mono 07_55", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Green;
            this.outputLabel.Location = new System.Drawing.Point(3, 9);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(366, 102);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "you are trapped in a resturaunt with Gordon Ramsey ";
            // 
            // greenButtonOutputLabel
            // 
            this.greenButtonOutputLabel.AutoSize = true;
            this.greenButtonOutputLabel.ForeColor = System.Drawing.Color.Green;
            this.greenButtonOutputLabel.Location = new System.Drawing.Point(83, 319);
            this.greenButtonOutputLabel.Name = "greenButtonOutputLabel";
            this.greenButtonOutputLabel.Size = new System.Drawing.Size(26, 13);
            this.greenButtonOutputLabel.TabIndex = 3;
            this.greenButtonOutputLabel.Text = "play";
            // 
            // redButtonOutputLabel
            // 
            this.redButtonOutputLabel.AutoSize = true;
            this.redButtonOutputLabel.ForeColor = System.Drawing.Color.Red;
            this.redButtonOutputLabel.Location = new System.Drawing.Point(83, 356);
            this.redButtonOutputLabel.Name = "redButtonOutputLabel";
            this.redButtonOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.redButtonOutputLabel.TabIndex = 4;
            // 
            // greenLabel
            // 
            this.greenLabel.BackColor = System.Drawing.Color.Green;
            this.greenLabel.Location = new System.Drawing.Point(29, 308);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(27, 24);
            this.greenLabel.TabIndex = 5;
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.Color.Red;
            this.redLabel.Location = new System.Drawing.Point(29, 356);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(27, 24);
            this.redLabel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(7, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 161);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.redButtonOutputLabel);
            this.Controls.Add(this.greenButtonOutputLabel);
            this.Controls.Add(this.outputLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label greenButtonOutputLabel;
        private System.Windows.Forms.Label redButtonOutputLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

