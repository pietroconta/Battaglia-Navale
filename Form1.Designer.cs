
namespace Battaglia_Navale
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_play = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_esc = new System.Windows.Forms.Button();
            this.btn_rules = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Font = new System.Drawing.Font("Niagara Solid", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.Location = new System.Drawing.Point(38, 58);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(130, 35);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "Gioca";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btn_rules);
            this.panel1.Controls.Add(this.btn_esc);
            this.panel1.Controls.Add(this.btn_play);
            this.panel1.Location = new System.Drawing.Point(192, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 343);
            this.panel1.TabIndex = 1;
            // 
            // btn_esc
            // 
            this.btn_esc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_esc.Font = new System.Drawing.Font("Niagara Solid", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_esc.Location = new System.Drawing.Point(38, 243);
            this.btn_esc.Name = "btn_esc";
            this.btn_esc.Size = new System.Drawing.Size(130, 35);
            this.btn_esc.TabIndex = 1;
            this.btn_esc.Text = "Esci";
            this.btn_esc.UseVisualStyleBackColor = true;
            this.btn_esc.Click += new System.EventHandler(this.btn_esc_Click);
            // 
            // btn_rules
            // 
            this.btn_rules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rules.Font = new System.Drawing.Font("Niagara Solid", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rules.Location = new System.Drawing.Point(38, 148);
            this.btn_rules.Name = "btn_rules";
            this.btn_rules.Size = new System.Drawing.Size(130, 35);
            this.btn_rules.TabIndex = 2;
            this.btn_rules.Text = "Regole";
            this.btn_rules.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 103);
            this.label1.TabIndex = 2;
            this.label1.Text = "Battaglia Navale";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(615, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_rules;
        private System.Windows.Forms.Button btn_esc;
        private System.Windows.Forms.Label label1;
    }
}

