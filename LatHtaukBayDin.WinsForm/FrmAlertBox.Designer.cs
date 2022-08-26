namespace LatHtaukBayDin.WinsForm
{
    partial class FrmAlertBox
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAsk = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Pyidaungsu", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1246, 103);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "လက်ထောက်ဗေဒင်";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(156)))), ((int)(((byte)(169)))));
            this.panel1.Controls.Add(this.btnAsk);
            this.panel1.Controls.Add(this.lblAnswer);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 361);
            this.panel1.TabIndex = 2;
            // 
            // btnAsk
            // 
            this.btnAsk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(67)))), ((int)(((byte)(78)))));
            this.btnAsk.FlatAppearance.BorderSize = 0;
            this.btnAsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsk.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAsk.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAsk.Location = new System.Drawing.Point(12, 290);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(1222, 59);
            this.btnAsk.TabIndex = 3;
            this.btnAsk.Text = "မေးမည်";
            this.btnAsk.UseVisualStyleBackColor = false;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(156)))), ((int)(((byte)(169)))));
            this.lblAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnswer.Font = new System.Drawing.Font("Pyidaungsu", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnswer.ForeColor = System.Drawing.Color.White;
            this.lblAnswer.Location = new System.Drawing.Point(0, 0);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(1246, 275);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1246, 86);
            this.panel2.TabIndex = 4;
            // 
            // AlertBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Pyidaungsu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlertBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTitle;
        private Panel panel1;
        private Label lblAnswer;
        private Button btnAsk;
        private Panel panel2;
    }
}