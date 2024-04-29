
namespace App
{
    partial class RInterface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MiniBBox = new System.Windows.Forms.TextBox();
            this.PizzeriaBox = new System.Windows.Forms.TextBox();
            this.BledorBox = new System.Windows.Forms.TextBox();
            this.subwaybox = new System.Windows.Forms.TextBox();
            this.MiniBMenu = new System.Windows.Forms.Button();
            this.SubwayMenu = new System.Windows.Forms.Button();
            this.PizzeriaMenu = new System.Windows.Forms.Button();
            this.BledorMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MiniBBox
            // 
            this.MiniBBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MiniBBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MiniBBox.Enabled = false;
            this.MiniBBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MiniBBox.Location = new System.Drawing.Point(27, 32);
            this.MiniBBox.Multiline = true;
            this.MiniBBox.Name = "MiniBBox";
            this.MiniBBox.ReadOnly = true;
            this.MiniBBox.Size = new System.Drawing.Size(191, 97);
            this.MiniBBox.TabIndex = 0;
            // 
            // PizzeriaBox
            // 
            this.PizzeriaBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PizzeriaBox.Enabled = false;
            this.PizzeriaBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PizzeriaBox.Location = new System.Drawing.Point(27, 135);
            this.PizzeriaBox.Multiline = true;
            this.PizzeriaBox.Name = "PizzeriaBox";
            this.PizzeriaBox.ReadOnly = true;
            this.PizzeriaBox.Size = new System.Drawing.Size(191, 97);
            this.PizzeriaBox.TabIndex = 1;
            // 
            // BledorBox
            // 
            this.BledorBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BledorBox.Enabled = false;
            this.BledorBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BledorBox.Location = new System.Drawing.Point(27, 341);
            this.BledorBox.Multiline = true;
            this.BledorBox.Name = "BledorBox";
            this.BledorBox.ReadOnly = true;
            this.BledorBox.Size = new System.Drawing.Size(191, 97);
            this.BledorBox.TabIndex = 2;
            // 
            // subwaybox
            // 
            this.subwaybox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subwaybox.Enabled = false;
            this.subwaybox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.subwaybox.Location = new System.Drawing.Point(27, 238);
            this.subwaybox.Multiline = true;
            this.subwaybox.Name = "subwaybox";
            this.subwaybox.ReadOnly = true;
            this.subwaybox.Size = new System.Drawing.Size(191, 97);
            this.subwaybox.TabIndex = 3;
            // 
            // MiniBMenu
            // 
            this.MiniBMenu.Location = new System.Drawing.Point(243, 32);
            this.MiniBMenu.Name = "MiniBMenu";
            this.MiniBMenu.Size = new System.Drawing.Size(75, 23);
            this.MiniBMenu.TabIndex = 4;
            this.MiniBMenu.Text = "MiniB";
            this.MiniBMenu.UseVisualStyleBackColor = true;
            this.MiniBMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubwayMenu
            // 
            this.SubwayMenu.Location = new System.Drawing.Point(243, 238);
            this.SubwayMenu.Name = "SubwayMenu";
            this.SubwayMenu.Size = new System.Drawing.Size(75, 23);
            this.SubwayMenu.TabIndex = 5;
            this.SubwayMenu.Text = "subway";
            this.SubwayMenu.UseVisualStyleBackColor = true;
            this.SubwayMenu.Click += new System.EventHandler(this.SubwayMenu_Click);
            // 
            // PizzeriaMenu
            // 
            this.PizzeriaMenu.Location = new System.Drawing.Point(243, 135);
            this.PizzeriaMenu.Name = "PizzeriaMenu";
            this.PizzeriaMenu.Size = new System.Drawing.Size(75, 23);
            this.PizzeriaMenu.TabIndex = 6;
            this.PizzeriaMenu.Text = "Pizzeria";
            this.PizzeriaMenu.UseVisualStyleBackColor = true;
            this.PizzeriaMenu.Click += new System.EventHandler(this.PizzeriaMenu_Click);
            // 
            // BledorMenu
            // 
            this.BledorMenu.Location = new System.Drawing.Point(243, 341);
            this.BledorMenu.Name = "BledorMenu";
            this.BledorMenu.Size = new System.Drawing.Size(75, 23);
            this.BledorMenu.TabIndex = 7;
            this.BledorMenu.Text = "Bledor";
            this.BledorMenu.UseVisualStyleBackColor = true;
            this.BledorMenu.Click += new System.EventHandler(this.BledorMenu_Click);
            // 
            // RInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.BledorMenu);
            this.Controls.Add(this.PizzeriaMenu);
            this.Controls.Add(this.SubwayMenu);
            this.Controls.Add(this.MiniBMenu);
            this.Controls.Add(this.subwaybox);
            this.Controls.Add(this.BledorBox);
            this.Controls.Add(this.PizzeriaBox);
            this.Controls.Add(this.MiniBBox);
            this.Name = "RInterface";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MiniBBox;
        private System.Windows.Forms.TextBox PizzeriaBox;
        private System.Windows.Forms.TextBox BledorBox;
        private System.Windows.Forms.TextBox subwaybox;
        private System.Windows.Forms.Button MiniBMenu;
        private System.Windows.Forms.Button SubwayMenu;
        private System.Windows.Forms.Button PizzeriaMenu;
        private System.Windows.Forms.Button BledorMenu;
    }
}

