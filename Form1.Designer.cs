namespace activity2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.TextBox();
            this.YourWeightOnMars = new System.Windows.Forms.Label();
            this.marsWeight = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Weight On Earth:";
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(194, 9);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(100, 20);
            this.Weight.TabIndex = 1;
            this.Weight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Weight.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // YourWeightOnMars
            // 
            this.YourWeightOnMars.AutoSize = true;
            this.YourWeightOnMars.Location = new System.Drawing.Point(12, 65);
            this.YourWeightOnMars.Name = "YourWeightOnMars";
            this.YourWeightOnMars.Size = new System.Drawing.Size(123, 13);
            this.YourWeightOnMars.TabIndex = 2;
            this.YourWeightOnMars.Text = "Your Weight On Mars Is:";
            // 
            // marsWeight
            // 
            this.marsWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.marsWeight.Location = new System.Drawing.Point(194, 65);
            this.marsWeight.Name = "marsWeight";
            this.marsWeight.Size = new System.Drawing.Size(100, 23);
            this.marsWeight.TabIndex = 3;
            this.marsWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.marsWeight.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.marsWeight);
            this.Controls.Add(this.YourWeightOnMars);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.Label YourWeightOnMars;
        private System.Windows.Forms.Label marsWeight;
        private System.Windows.Forms.Button button1;
    }
}

