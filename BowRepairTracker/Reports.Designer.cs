
namespace BowRepairTracker
{
    partial class Reports
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
            this.reportButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.statusButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(531, 12);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(167, 59);
            this.reportButton.TabIndex = 9;
            this.reportButton.Text = "REPORTS";
            this.reportButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(358, 11);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(167, 59);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "ADD ORDER";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // statusButton
            // 
            this.statusButton.Location = new System.Drawing.Point(185, 11);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(167, 59);
            this.statusButton.TabIndex = 7;
            this.statusButton.Text = "ORDER STATUS";
            this.statusButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(12, 12);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(167, 59);
            this.homeButton.TabIndex = 6;
            this.homeButton.Text = "HOME";
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1211, 598);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(334, 39);
            this.button3.TabIndex = 32;
            this.button3.Text = "GENERATE SALES REPORT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 39);
            this.button1.TabIndex = 33;
            this.button1.Text = "GENERATE REPAIR REPORT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(334, 39);
            this.button2.TabIndex = 34;
            this.button2.Text = "GENERATE CUSTOMER REPORT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 686);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reports";
            this.Text = "REPORTS";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}