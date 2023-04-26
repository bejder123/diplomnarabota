namespace Stanibogat
{
    partial class Form1
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
            this.BtnP = new System.Windows.Forms.Button();
            this.BtnR = new System.Windows.Forms.Button();
            this.BtnE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnP
            // 
            this.BtnP.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnP.Location = new System.Drawing.Point(8, 51);
            this.BtnP.Name = "BtnP";
            this.BtnP.Size = new System.Drawing.Size(167, 49);
            this.BtnP.TabIndex = 0;
            this.BtnP.Text = "Нова игра";
            this.BtnP.UseVisualStyleBackColor = false;
            this.BtnP.Click += new System.EventHandler(this.BtnP_Click);
            // 
            // BtnR
            // 
            this.BtnR.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnR.Location = new System.Drawing.Point(8, 106);
            this.BtnR.Name = "BtnR";
            this.BtnR.Size = new System.Drawing.Size(167, 49);
            this.BtnR.TabIndex = 1;
            this.BtnR.Text = "Продължи";
            this.BtnR.UseVisualStyleBackColor = false;
            // 
            // BtnE
            // 
            this.BtnE.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnE.Location = new System.Drawing.Point(8, 161);
            this.BtnE.Name = "BtnE";
            this.BtnE.Size = new System.Drawing.Size(167, 49);
            this.BtnE.TabIndex = 2;
            this.BtnE.Text = "Изход";
            this.BtnE.UseVisualStyleBackColor = false;
            this.BtnE.Click += new System.EventHandler(this.BtnE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Стани богат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(185, 215);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnE);
            this.Controls.Add(this.BtnR);
            this.Controls.Add(this.BtnP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnP;
        private Button BtnR;
        private Button BtnE;
        private Label label1;
    }
}