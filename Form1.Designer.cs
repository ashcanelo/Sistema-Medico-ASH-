namespace SistemaMedicoAshly
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserNtxt = new System.Windows.Forms.TextBox();
            this.PassWtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EntrarBTN = new System.Windows.Forms.Button();
            this.CerrarBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Violet;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 502);
            this.panel1.TabIndex = 0;
            // 
            // UserNtxt
            // 
            this.UserNtxt.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNtxt.Location = new System.Drawing.Point(448, 123);
            this.UserNtxt.Name = "UserNtxt";
            this.UserNtxt.Size = new System.Drawing.Size(287, 52);
            this.UserNtxt.TabIndex = 1;
            this.UserNtxt.TextChanged += new System.EventHandler(this.tbusername_TextChanged_1);
            // 
            // PassWtxt
            // 
            this.PassWtxt.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassWtxt.Location = new System.Drawing.Point(464, 263);
            this.PassWtxt.Name = "PassWtxt";
            this.PassWtxt.Size = new System.Drawing.Size(259, 52);
            this.PassWtxt.TabIndex = 2;
            this.PassWtxt.TextChanged += new System.EventHandler(this.tbcontraseña_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(527, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(509, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EntrarBTN
            // 
            this.EntrarBTN.Location = new System.Drawing.Point(448, 408);
            this.EntrarBTN.Name = "EntrarBTN";
            this.EntrarBTN.Size = new System.Drawing.Size(94, 29);
            this.EntrarBTN.TabIndex = 5;
            this.EntrarBTN.Text = "Acceder";
            this.EntrarBTN.UseVisualStyleBackColor = true;
            this.EntrarBTN.Click += new System.EventHandler(this.EntrarBTN_Click);
            // 
            // CerrarBTN
            // 
            this.CerrarBTN.Location = new System.Drawing.Point(629, 408);
            this.CerrarBTN.Name = "CerrarBTN";
            this.CerrarBTN.Size = new System.Drawing.Size(94, 29);
            this.CerrarBTN.TabIndex = 6;
            this.CerrarBTN.Text = "Cerrar";
            this.CerrarBTN.UseVisualStyleBackColor = true;
            this.CerrarBTN.Click += new System.EventHandler(this.CerrarBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(996, 502);
            this.Controls.Add(this.CerrarBTN);
            this.Controls.Add(this.EntrarBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassWtxt);
            this.Controls.Add(this.UserNtxt);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox UserNtxt;
        private TextBox PassWtxt;
        private Label label1;
        private Label label2;
        private Button EntrarBTN;
        private Button CerrarBTN;
    }
}