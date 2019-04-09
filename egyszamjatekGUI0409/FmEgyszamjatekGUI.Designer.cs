namespace egyszamjatekGUI0409
{
    partial class FmEgyszamjatekGUI
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
            this.lblDb = new System.Windows.Forms.Label();
            this.btnHozaad = new System.Windows.Forms.Button();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbTippek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(78, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Játékos neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(78, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Játékos pontjai:";
            // 
            // lblDb
            // 
            this.lblDb.AutoSize = true;
            this.lblDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDb.Location = new System.Drawing.Point(529, 130);
            this.lblDb.Name = "lblDb";
            this.lblDb.Size = new System.Drawing.Size(27, 20);
            this.lblDb.TabIndex = 0;
            this.lblDb.Text = "db";
            // 
            // btnHozaad
            // 
            this.btnHozaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHozaad.Location = new System.Drawing.Point(82, 176);
            this.btnHozaad.Name = "btnHozaad";
            this.btnHozaad.Size = new System.Drawing.Size(474, 43);
            this.btnHozaad.TabIndex = 1;
            this.btnHozaad.Text = "Játékos hozzáadása";
            this.btnHozaad.UseVisualStyleBackColor = true;
            this.btnHozaad.Click += new System.EventHandler(this.btnHozaad_Click);
            // 
            // tbNev
            // 
            this.tbNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNev.Location = new System.Drawing.Point(204, 79);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(266, 26);
            this.tbNev.TabIndex = 2;
            // 
            // tbTippek
            // 
            this.tbTippek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTippek.Location = new System.Drawing.Point(204, 127);
            this.tbTippek.Name = "tbTippek";
            this.tbTippek.Size = new System.Drawing.Size(295, 26);
            this.tbTippek.TabIndex = 2;
            this.tbTippek.TextChanged += new System.EventHandler(this.tbTippek_TextChanged);
            // 
            // FmEgyszamjatekGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 328);
            this.Controls.Add(this.tbTippek);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.btnHozaad);
            this.Controls.Add(this.lblDb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FmEgyszamjatekGUI";
            this.Text = "Egyszámjáték GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDb;
        private System.Windows.Forms.Button btnHozaad;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbTippek;
    }
}

