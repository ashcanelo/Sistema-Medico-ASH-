namespace SistemaMedicoAshly
{
    partial class Menu_principal
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
            this.nametxt = new System.Windows.Forms.TextBox();
            this.lnametxt = new System.Windows.Forms.TextBox();
            this.Sicktxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Habtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.CitasC = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CitasC)).BeginInit();
            this.SuspendLayout();
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(63, 86);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(303, 27);
            this.nametxt.TabIndex = 0;
            // 
            // lnametxt
            // 
            this.lnametxt.Location = new System.Drawing.Point(408, 86);
            this.lnametxt.Name = "lnametxt";
            this.lnametxt.Size = new System.Drawing.Size(303, 27);
            this.lnametxt.TabIndex = 1;
            // 
            // Sicktxt
            // 
            this.Sicktxt.Location = new System.Drawing.Point(736, 86);
            this.Sicktxt.Name = "Sicktxt";
            this.Sicktxt.Size = new System.Drawing.Size(303, 27);
            this.Sicktxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre, Apellido.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(512, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(826, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Patología";
            // 
            // Habtxt
            // 
            this.Habtxt.Location = new System.Drawing.Point(408, 217);
            this.Habtxt.Name = "Habtxt";
            this.Habtxt.Size = new System.Drawing.Size(303, 27);
            this.Habtxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(512, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Habitación";
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(172, 296);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(194, 48);
            this.addbtn.TabIndex = 8;
            this.addbtn.Text = "Agregar";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(736, 296);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(194, 48);
            this.delbtn.TabIndex = 9;
            this.delbtn.Text = "Eliminar";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(928, 557);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(162, 37);
            this.closebtn.TabIndex = 10;
            this.closebtn.Text = "Cerrar";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click_1);
            // 
            // CitasC
            // 
            this.CitasC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CitasC.Location = new System.Drawing.Point(224, 363);
            this.CitasC.Name = "CitasC";
            this.CitasC.RowHeadersWidth = 51;
            this.CitasC.RowTemplate.Height = 29;
            this.CitasC.Size = new System.Drawing.Size(714, 188);
            this.CitasC.TabIndex = 11;
            // 
            // Menu_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 606);
            this.Controls.Add(this.CitasC);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Habtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sicktxt);
            this.Controls.Add(this.lnametxt);
            this.Controls.Add(this.nametxt);
            this.Name = "Menu_principal";
            this.Text = "Menu_principal";
            this.Load += new System.EventHandler(this.Menu_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CitasC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nametxt;
        private TextBox lnametxt;
        private TextBox Sicktxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Habtxt;
        private Label label4;
        private Button addbtn;
        private Button delbtn;
        private Button closebtn;
        private DataGridView CitasC;
    }
}