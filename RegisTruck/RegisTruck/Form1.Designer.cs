﻿namespace RegisTruck
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tBox_PackageId = new System.Windows.Forms.TextBox();
            this.tBox_PackageDestination = new System.Windows.Forms.TextBox();
            this.tBox_PackageWeight = new System.Windows.Forms.TextBox();
            this.tBox_PackageDeadline = new System.Windows.Forms.TextBox();
            this.tBox_PackageType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBox_PackageDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(39, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 179);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tBox_PackageId
            // 
            this.tBox_PackageId.Location = new System.Drawing.Point(87, 36);
            this.tBox_PackageId.Name = "tBox_PackageId";
            this.tBox_PackageId.Size = new System.Drawing.Size(152, 20);
            this.tBox_PackageId.TabIndex = 1;
            // 
            // tBox_PackageDestination
            // 
            this.tBox_PackageDestination.Location = new System.Drawing.Point(87, 76);
            this.tBox_PackageDestination.Name = "tBox_PackageDestination";
            this.tBox_PackageDestination.Size = new System.Drawing.Size(152, 20);
            this.tBox_PackageDestination.TabIndex = 2;
            // 
            // tBox_PackageWeight
            // 
            this.tBox_PackageWeight.Location = new System.Drawing.Point(87, 116);
            this.tBox_PackageWeight.Name = "tBox_PackageWeight";
            this.tBox_PackageWeight.Size = new System.Drawing.Size(152, 20);
            this.tBox_PackageWeight.TabIndex = 3;
            // 
            // tBox_PackageDeadline
            // 
            this.tBox_PackageDeadline.Location = new System.Drawing.Point(87, 159);
            this.tBox_PackageDeadline.Name = "tBox_PackageDeadline";
            this.tBox_PackageDeadline.Size = new System.Drawing.Size(152, 20);
            this.tBox_PackageDeadline.TabIndex = 4;
            // 
            // tBox_PackageType
            // 
            this.tBox_PackageType.Location = new System.Drawing.Point(87, 200);
            this.tBox_PackageType.Name = "tBox_PackageType";
            this.tBox_PackageType.Size = new System.Drawing.Size(152, 20);
            this.tBox_PackageType.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destination:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Weight:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Deadline:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Type:";
            // 
            // tBox_PackageDescription
            // 
            this.tBox_PackageDescription.Location = new System.Drawing.Point(87, 243);
            this.tBox_PackageDescription.Multiline = true;
            this.tBox_PackageDescription.Name = "tBox_PackageDescription";
            this.tBox_PackageDescription.Size = new System.Drawing.Size(152, 99);
            this.tBox_PackageDescription.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Description:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBox_PackageDestination);
            this.groupBox1.Controls.Add(this.tBox_PackageDescription);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBox_PackageId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tBox_PackageWeight);
            this.groupBox1.Controls.Add(this.tBox_PackageType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tBox_PackageDeadline);
            this.groupBox1.Location = new System.Drawing.Point(494, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 354);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Read QR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tBox_PackageId;
        private System.Windows.Forms.TextBox tBox_PackageDestination;
        private System.Windows.Forms.TextBox tBox_PackageWeight;
        private System.Windows.Forms.TextBox tBox_PackageDeadline;
        private System.Windows.Forms.TextBox tBox_PackageType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBox_PackageDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}
