
namespace FinalProject_Salvage
{
    partial class AMHome
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
            this.prod_col = new System.Windows.Forms.Button();
            this.checknew = new System.Windows.Forms.Button();
            this.additem = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prod_col
            // 
            this.prod_col.BackColor = System.Drawing.Color.LimeGreen;
            this.prod_col.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_col.ForeColor = System.Drawing.SystemColors.MenuText;
            this.prod_col.Location = new System.Drawing.Point(355, 122);
            this.prod_col.Name = "prod_col";
            this.prod_col.Size = new System.Drawing.Size(259, 64);
            this.prod_col.TabIndex = 0;
            this.prod_col.Text = "Product Collection";
            this.prod_col.UseVisualStyleBackColor = false;
            this.prod_col.Click += new System.EventHandler(this.prod_col_Click);
            // 
            // checknew
            // 
            this.checknew.BackColor = System.Drawing.Color.LimeGreen;
            this.checknew.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.checknew.Location = new System.Drawing.Point(355, 210);
            this.checknew.Name = "checknew";
            this.checknew.Size = new System.Drawing.Size(259, 64);
            this.checknew.TabIndex = 1;
            this.checknew.Text = "Check New Request";
            this.checknew.UseVisualStyleBackColor = false;
            this.checknew.Click += new System.EventHandler(this.checknew_Click);
            // 
            // additem
            // 
            this.additem.BackColor = System.Drawing.Color.LimeGreen;
            this.additem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.additem.Location = new System.Drawing.Point(355, 298);
            this.additem.Name = "additem";
            this.additem.Size = new System.Drawing.Size(259, 64);
            this.additem.TabIndex = 2;
            this.additem.Text = "Add New Item";
            this.additem.UseVisualStyleBackColor = false;
            this.additem.Click += new System.EventHandler(this.additem_Click);
            // 
            // money
            // 
            this.money.BackColor = System.Drawing.Color.LimeGreen;
            this.money.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.money.Location = new System.Drawing.Point(355, 386);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(259, 64);
            this.money.TabIndex = 3;
            this.money.Text = "Money Transaction";
            this.money.UseVisualStyleBackColor = false;
            this.money.Click += new System.EventHandler(this.money_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(281, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Area Manager Homepage";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Olive;
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(2, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 28);
            this.button3.TabIndex = 18;
            this.button3.Text = "Go Back";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // AMHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1023, 571);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.money);
            this.Controls.Add(this.additem);
            this.Controls.Add(this.checknew);
            this.Controls.Add(this.prod_col);
            this.Name = "AMHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AMHomepage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prod_col;
        private System.Windows.Forms.Button checknew;
        private System.Windows.Forms.Button additem;
        private System.Windows.Forms.Button money;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}

