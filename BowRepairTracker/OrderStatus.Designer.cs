
namespace BowRepairTracker
{
    partial class OrderStatus
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(532, 11);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(167, 59);
            this.reportButton.TabIndex = 9;
            this.reportButton.Text = "REPORTS";
            this.reportButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(359, 10);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(167, 59);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "ADD ORDER";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // statusButton
            // 
            this.statusButton.Location = new System.Drawing.Point(186, 10);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(167, 59);
            this.statusButton.TabIndex = 7;
            this.statusButton.Text = "ORDER STATUS";
            this.statusButton.UseVisualStyleBackColor = true;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(13, 11);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(167, 59);
            this.homeButton.TabIndex = 6;
            this.homeButton.Text = "HOME";
            this.homeButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1211, 598);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter Order Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 26);
            this.textBox1.TabIndex = 10;
            // 
            // OrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 685);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderStatus";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}