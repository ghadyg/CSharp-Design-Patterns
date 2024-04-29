
namespace App
{
    partial class OrderForm
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
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.PNBox = new System.Windows.Forms.TextBox();
            this.LNBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.confirmlbl = new System.Windows.Forms.Label();
            this.Confirmbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Mailbtn = new System.Windows.Forms.RadioButton();
            this.Numberbtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // FNameBox
            // 
            this.FNameBox.Location = new System.Drawing.Point(120, 48);
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(100, 23);
            this.FNameBox.TabIndex = 0;
            // 
            // PNBox
            // 
            this.PNBox.Location = new System.Drawing.Point(120, 133);
            this.PNBox.Name = "PNBox";
            this.PNBox.Size = new System.Drawing.Size(100, 23);
            this.PNBox.TabIndex = 1;
            // 
            // LNBox
            // 
            this.LNBox.Location = new System.Drawing.Point(120, 93);
            this.LNBox.Name = "LNBox";
            this.LNBox.Size = new System.Drawing.Size(100, 23);
            this.LNBox.TabIndex = 2;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(120, 173);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(193, 23);
            this.EmailBox.TabIndex = 3;
            // 
            // confirmlbl
            // 
            this.confirmlbl.AutoSize = true;
            this.confirmlbl.Location = new System.Drawing.Point(43, 221);
            this.confirmlbl.Name = "confirmlbl";
            this.confirmlbl.Size = new System.Drawing.Size(101, 15);
            this.confirmlbl.TabIndex = 6;
            this.confirmlbl.Text = "Confirm order by:";
            // 
            // Confirmbtn
            // 
            this.Confirmbtn.Location = new System.Drawing.Point(150, 294);
            this.Confirmbtn.Name = "Confirmbtn";
            this.Confirmbtn.Size = new System.Drawing.Size(75, 23);
            this.Confirmbtn.TabIndex = 7;
            this.Confirmbtn.Text = "Confirm";
            this.Confirmbtn.UseVisualStyleBackColor = true;
            this.Confirmbtn.Click += new System.EventHandler(this.Confirmbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "First Name:";
            // 
            // Mailbtn
            // 
            this.Mailbtn.AutoSize = true;
            this.Mailbtn.Location = new System.Drawing.Point(150, 258);
            this.Mailbtn.Name = "Mailbtn";
            this.Mailbtn.Size = new System.Drawing.Size(54, 19);
            this.Mailbtn.TabIndex = 12;
            this.Mailbtn.TabStop = true;
            this.Mailbtn.Text = "Email";
            this.Mailbtn.UseVisualStyleBackColor = true;
            // 
            // Numberbtn
            // 
            this.Numberbtn.AutoSize = true;
            this.Numberbtn.Location = new System.Drawing.Point(150, 221);
            this.Numberbtn.Name = "Numberbtn";
            this.Numberbtn.Size = new System.Drawing.Size(71, 19);
            this.Numberbtn.TabIndex = 13;
            this.Numberbtn.TabStop = true;
            this.Numberbtn.Text = "Message";
            this.Numberbtn.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(445, 406);
            this.Controls.Add(this.Numberbtn);
            this.Controls.Add(this.Mailbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Confirmbtn);
            this.Controls.Add(this.confirmlbl);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.LNBox);
            this.Controls.Add(this.PNBox);
            this.Controls.Add(this.FNameBox);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.TextBox PNBox;
        private System.Windows.Forms.TextBox LNBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label confirmlbl;
        private System.Windows.Forms.Button Confirmbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Mailbtn;
        private System.Windows.Forms.RadioButton Numberbtn;
    }
}