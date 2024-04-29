
namespace App
{
    partial class PizzeriaForm
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
            this.undobtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.PPquantity = new System.Windows.Forms.TextBox();
            this.quantitybox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChPquantity = new System.Windows.Forms.TextBox();
            this.LPquantity = new System.Windows.Forms.TextBox();
            this.SPquantity = new System.Windows.Forms.TextBox();
            this.BPquantity = new System.Windows.Forms.TextBox();
            this.BPPrice = new System.Windows.Forms.TextBox();
            this.SPPrice = new System.Windows.Forms.TextBox();
            this.LPPrice = new System.Windows.Forms.TextBox();
            this.ChPPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Pricebtn = new System.Windows.Forms.Button();
            this.TPTxt = new System.Windows.Forms.TextBox();
            this.PPPrice = new System.Windows.Forms.TextBox();
            this.PizzeriaMenuBox = new System.Windows.Forms.TextBox();
            this.Order = new System.Windows.Forms.Button();
            this.quantitybox.SuspendLayout();
            this.SuspendLayout();
            // 
            // undobtn
            // 
            this.undobtn.Location = new System.Drawing.Point(357, 405);
            this.undobtn.Name = "undobtn";
            this.undobtn.Size = new System.Drawing.Size(101, 23);
            this.undobtn.TabIndex = 41;
            this.undobtn.Text = "Undo";
            this.undobtn.UseVisualStyleBackColor = true;
            this.undobtn.Visible = false;
            this.undobtn.Click += new System.EventHandler(this.undobtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(696, 420);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 39;
            this.exitbtn.Text = "EXIT";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // PPquantity
            // 
            this.PPquantity.Location = new System.Drawing.Point(13, 27);
            this.PPquantity.Name = "PPquantity";
            this.PPquantity.Size = new System.Drawing.Size(53, 23);
            this.PPquantity.TabIndex = 22;
            this.PPquantity.Text = "0";
            // 
            // quantitybox
            // 
            this.quantitybox.BackColor = System.Drawing.Color.Transparent;
            this.quantitybox.Controls.Add(this.PPquantity);
            this.quantitybox.Controls.Add(this.label5);
            this.quantitybox.Controls.Add(this.label4);
            this.quantitybox.Controls.Add(this.label3);
            this.quantitybox.Controls.Add(this.label2);
            this.quantitybox.Controls.Add(this.label1);
            this.quantitybox.Controls.Add(this.ChPquantity);
            this.quantitybox.Controls.Add(this.LPquantity);
            this.quantitybox.Controls.Add(this.SPquantity);
            this.quantitybox.Controls.Add(this.BPquantity);
            this.quantitybox.Location = new System.Drawing.Point(456, 7);
            this.quantitybox.Name = "quantitybox";
            this.quantitybox.Size = new System.Drawing.Size(79, 322);
            this.quantitybox.TabIndex = 40;
            this.quantitybox.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(13, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantity";
            // 
            // ChPquantity
            // 
            this.ChPquantity.Location = new System.Drawing.Point(13, 291);
            this.ChPquantity.Name = "ChPquantity";
            this.ChPquantity.Size = new System.Drawing.Size(53, 23);
            this.ChPquantity.TabIndex = 5;
            this.ChPquantity.Text = "0";
            // 
            // LPquantity
            // 
            this.LPquantity.Location = new System.Drawing.Point(13, 221);
            this.LPquantity.Name = "LPquantity";
            this.LPquantity.Size = new System.Drawing.Size(53, 23);
            this.LPquantity.TabIndex = 4;
            this.LPquantity.Text = "0";
            // 
            // SPquantity
            // 
            this.SPquantity.Location = new System.Drawing.Point(13, 156);
            this.SPquantity.Name = "SPquantity";
            this.SPquantity.Size = new System.Drawing.Size(53, 23);
            this.SPquantity.TabIndex = 3;
            this.SPquantity.Text = "0";
            // 
            // BPquantity
            // 
            this.BPquantity.Location = new System.Drawing.Point(13, 86);
            this.BPquantity.Name = "BPquantity";
            this.BPquantity.Size = new System.Drawing.Size(53, 23);
            this.BPquantity.TabIndex = 2;
            this.BPquantity.Text = "0";
            // 
            // BPPrice
            // 
            this.BPPrice.Enabled = false;
            this.BPPrice.Location = new System.Drawing.Point(396, 93);
            this.BPPrice.Name = "BPPrice";
            this.BPPrice.Size = new System.Drawing.Size(53, 23);
            this.BPPrice.TabIndex = 38;
            this.BPPrice.Text = "0";
            // 
            // SPPrice
            // 
            this.SPPrice.Enabled = false;
            this.SPPrice.Location = new System.Drawing.Point(396, 163);
            this.SPPrice.Name = "SPPrice";
            this.SPPrice.Size = new System.Drawing.Size(53, 23);
            this.SPPrice.TabIndex = 37;
            this.SPPrice.Text = "0";
            // 
            // LPPrice
            // 
            this.LPPrice.Enabled = false;
            this.LPPrice.Location = new System.Drawing.Point(396, 228);
            this.LPPrice.Name = "LPPrice";
            this.LPPrice.Size = new System.Drawing.Size(53, 23);
            this.LPPrice.TabIndex = 36;
            this.LPPrice.Text = "0";
            // 
            // ChPPrice
            // 
            this.ChPPrice.Enabled = false;
            this.ChPPrice.Location = new System.Drawing.Point(396, 298);
            this.ChPPrice.Name = "ChPPrice";
            this.ChPPrice.Size = new System.Drawing.Size(53, 23);
            this.ChPPrice.TabIndex = 35;
            this.ChPPrice.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 34;
            this.label10.Text = "Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Price:";
            // 
            // Pricebtn
            // 
            this.Pricebtn.Location = new System.Drawing.Point(357, 376);
            this.Pricebtn.Name = "Pricebtn";
            this.Pricebtn.Size = new System.Drawing.Size(101, 23);
            this.Pricebtn.TabIndex = 29;
            this.Pricebtn.Text = "Check Price";
            this.Pricebtn.UseVisualStyleBackColor = true;
            this.Pricebtn.Click += new System.EventHandler(this.Pricebtn_Click);
            // 
            // TPTxt
            // 
            this.TPTxt.Enabled = false;
            this.TPTxt.Location = new System.Drawing.Point(469, 376);
            this.TPTxt.Name = "TPTxt";
            this.TPTxt.Size = new System.Drawing.Size(82, 23);
            this.TPTxt.TabIndex = 28;
            this.TPTxt.Text = "0";
            // 
            // PPPrice
            // 
            this.PPPrice.Enabled = false;
            this.PPPrice.Location = new System.Drawing.Point(397, 34);
            this.PPPrice.Name = "PPPrice";
            this.PPPrice.Size = new System.Drawing.Size(53, 23);
            this.PPPrice.TabIndex = 27;
            this.PPPrice.Text = "0";
            // 
            // PizzeriaMenuBox
            // 
            this.PizzeriaMenuBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PizzeriaMenuBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PizzeriaMenuBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PizzeriaMenuBox.Enabled = false;
            this.PizzeriaMenuBox.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PizzeriaMenuBox.Location = new System.Drawing.Point(30, 18);
            this.PizzeriaMenuBox.Multiline = true;
            this.PizzeriaMenuBox.Name = "PizzeriaMenuBox";
            this.PizzeriaMenuBox.ReadOnly = true;
            this.PizzeriaMenuBox.Size = new System.Drawing.Size(360, 332);
            this.PizzeriaMenuBox.TabIndex = 26;
            // 
            // Order
            // 
            this.Order.Location = new System.Drawing.Point(464, 405);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(87, 23);
            this.Order.TabIndex = 42;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Visible = false;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // PizzeriaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.Properties.Resources.Pizzeria_logo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.undobtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.quantitybox);
            this.Controls.Add(this.BPPrice);
            this.Controls.Add(this.SPPrice);
            this.Controls.Add(this.LPPrice);
            this.Controls.Add(this.ChPPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Pricebtn);
            this.Controls.Add(this.TPTxt);
            this.Controls.Add(this.PPPrice);
            this.Controls.Add(this.PizzeriaMenuBox);
            this.Name = "PizzeriaForm";
            this.Text = "PizzeriaForm";
            this.quantitybox.ResumeLayout(false);
            this.quantitybox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button undobtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.TextBox PPquantity;
        private System.Windows.Forms.GroupBox quantitybox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ChPquantity;
        private System.Windows.Forms.TextBox LPquantity;
        private System.Windows.Forms.TextBox SPquantity;
        private System.Windows.Forms.TextBox BPquantity;
        private System.Windows.Forms.TextBox BPPrice;
        private System.Windows.Forms.TextBox SPPrice;
        private System.Windows.Forms.TextBox LPPrice;
        private System.Windows.Forms.TextBox ChPPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Pricebtn;
        private System.Windows.Forms.TextBox TPTxt;
        private System.Windows.Forms.TextBox PPPrice;
        private System.Windows.Forms.TextBox PizzeriaMenuBox;
        private System.Windows.Forms.Button Order;
    }
}