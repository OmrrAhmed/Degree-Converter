namespace DegreeConverter
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtLongD = new System.Windows.Forms.TextBox();
            this.txtLongM = new System.Windows.Forms.TextBox();
            this.txtLongS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLatD = new System.Windows.Forms.TextBox();
            this.txtLatM = new System.Windows.Forms.TextBox();
            this.txtLatS = new System.Windows.Forms.TextBox();
            this.Convert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDDX = new System.Windows.Forms.TextBox();
            this.txtDDY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Degree Converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitude : ";
            // 
            // txtLongD
            // 
            this.txtLongD.Location = new System.Drawing.Point(173, 75);
            this.txtLongD.Name = "txtLongD";
            this.txtLongD.Size = new System.Drawing.Size(44, 27);
            this.txtLongD.TabIndex = 2;
            // 
            // txtLongM
            // 
            this.txtLongM.Location = new System.Drawing.Point(236, 75);
            this.txtLongM.Name = "txtLongM";
            this.txtLongM.Size = new System.Drawing.Size(44, 27);
            this.txtLongM.TabIndex = 2;
            // 
            // txtLongS
            // 
            this.txtLongS.Location = new System.Drawing.Point(300, 75);
            this.txtLongS.Name = "txtLongS";
            this.txtLongS.Size = new System.Drawing.Size(44, 27);
            this.txtLongS.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Latitude : ";
            // 
            // txtLatD
            // 
            this.txtLatD.Location = new System.Drawing.Point(173, 135);
            this.txtLatD.Name = "txtLatD";
            this.txtLatD.Size = new System.Drawing.Size(44, 27);
            this.txtLatD.TabIndex = 2;
            // 
            // txtLatM
            // 
            this.txtLatM.Location = new System.Drawing.Point(236, 135);
            this.txtLatM.Name = "txtLatM";
            this.txtLatM.Size = new System.Drawing.Size(44, 27);
            this.txtLatM.TabIndex = 2;
            // 
            // txtLatS
            // 
            this.txtLatS.Location = new System.Drawing.Point(300, 135);
            this.txtLatS.Name = "txtLatS";
            this.txtLatS.Size = new System.Drawing.Size(44, 27);
            this.txtLatS.TabIndex = 2;
            // 
            // Convert
            // 
            this.Convert.Location = new System.Drawing.Point(137, 186);
            this.Convert.Name = "Convert";
            this.Convert.Size = new System.Drawing.Size(118, 33);
            this.Convert.TabIndex = 3;
            this.Convert.Text = "Convert";
            this.Convert.UseVisualStyleBackColor = true;
            this.Convert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(39, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "X : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(39, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Y : ";
            // 
            // txtDDX
            // 
            this.txtDDX.Location = new System.Drawing.Point(173, 243);
            this.txtDDX.Name = "txtDDX";
            this.txtDDX.Size = new System.Drawing.Size(171, 27);
            this.txtDDX.TabIndex = 2;
            // 
            // txtDDY
            // 
            this.txtDDY.Location = new System.Drawing.Point(173, 292);
            this.txtDDY.Name = "txtDDY";
            this.txtDDY.Size = new System.Drawing.Size(171, 27);
            this.txtDDY.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 362);
            this.Controls.Add(this.Convert);
            this.Controls.Add(this.txtLatS);
            this.Controls.Add(this.txtLongS);
            this.Controls.Add(this.txtLatM);
            this.Controls.Add(this.txtLongM);
            this.Controls.Add(this.txtDDY);
            this.Controls.Add(this.txtDDX);
            this.Controls.Add(this.txtLatD);
            this.Controls.Add(this.txtLongD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Degree Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLongD;
        private System.Windows.Forms.TextBox txtLongM;
        private System.Windows.Forms.TextBox txtLongS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLatD;
        private System.Windows.Forms.TextBox txtLatM;
        private System.Windows.Forms.TextBox txtLatS;
        private System.Windows.Forms.Button Convert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDDX;
        private System.Windows.Forms.TextBox txtDDY;
    }
}

