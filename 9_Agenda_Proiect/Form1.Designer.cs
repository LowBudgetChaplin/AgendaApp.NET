namespace _9_Agenda_Proiect
{
    partial class Agenda
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
            this.numeBox = new System.Windows.Forms.TextBox();
            this.descriereBox = new System.Windows.Forms.TextBox();
            this.labelNume = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.activitatiVechi = new System.Windows.Forms.DataGridView();
            this.afiseasaButton = new System.Windows.Forms.Button();
            this.stergeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.nouButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activitatiVechi)).BeginInit();
            this.SuspendLayout();
            // 
            // numeBox
            // 
            this.numeBox.Location = new System.Drawing.Point(12, 56);
            this.numeBox.Name = "numeBox";
            this.numeBox.Size = new System.Drawing.Size(378, 20);
            this.numeBox.TabIndex = 0;
            this.numeBox.Text = " ";
            // 
            // descriereBox
            // 
            this.descriereBox.Location = new System.Drawing.Point(12, 115);
            this.descriereBox.Multiline = true;
            this.descriereBox.Name = "descriereBox";
            this.descriereBox.Size = new System.Drawing.Size(378, 323);
            this.descriereBox.TabIndex = 1;
            this.descriereBox.Text = " ";
            // 
            // labelNume
            // 
            this.labelNume.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume.Location = new System.Drawing.Point(8, 30);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(342, 23);
            this.labelNume.TabIndex = 2;
            this.labelNume.Text = "Numele activitatii:";
            this.labelNume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "DATA / ORA / LOCATIE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // activitatiVechi
            // 
            this.activitatiVechi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.activitatiVechi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.activitatiVechi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitatiVechi.Location = new System.Drawing.Point(395, 12);
            this.activitatiVechi.Name = "activitatiVechi";
            this.activitatiVechi.Size = new System.Drawing.Size(392, 339);
            this.activitatiVechi.TabIndex = 4;
            this.activitatiVechi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.activitatiVechi_CellDoubleClick);
            // 
            // afiseasaButton
            // 
            this.afiseasaButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.afiseasaButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afiseasaButton.ForeColor = System.Drawing.SystemColors.Window;
            this.afiseasaButton.Location = new System.Drawing.Point(396, 399);
            this.afiseasaButton.Name = "afiseasaButton";
            this.afiseasaButton.Size = new System.Drawing.Size(190, 39);
            this.afiseasaButton.TabIndex = 5;
            this.afiseasaButton.Text = "Afiseaza";
            this.afiseasaButton.UseVisualStyleBackColor = false;
            this.afiseasaButton.Click += new System.EventHandler(this.afiseasaButton_Click);
            // 
            // stergeButton
            // 
            this.stergeButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stergeButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergeButton.ForeColor = System.Drawing.SystemColors.Window;
            this.stergeButton.Location = new System.Drawing.Point(592, 399);
            this.stergeButton.Name = "stergeButton";
            this.stergeButton.Size = new System.Drawing.Size(196, 39);
            this.stergeButton.TabIndex = 5;
            this.stergeButton.Text = "Sterge";
            this.stergeButton.UseVisualStyleBackColor = false;
            this.stergeButton.Click += new System.EventHandler(this.stergeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.Window;
            this.saveButton.Location = new System.Drawing.Point(396, 357);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(190, 36);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Salveaza";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nouButton
            // 
            this.nouButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nouButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouButton.ForeColor = System.Drawing.SystemColors.Window;
            this.nouButton.Location = new System.Drawing.Point(592, 357);
            this.nouButton.Name = "nouButton";
            this.nouButton.Size = new System.Drawing.Size(196, 36);
            this.nouButton.TabIndex = 5;
            this.nouButton.Text = "Adauga";
            this.nouButton.UseVisualStyleBackColor = false;
            this.nouButton.Click += new System.EventHandler(this.nouButton_Click);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nouButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.stergeButton);
            this.Controls.Add(this.afiseasaButton);
            this.Controls.Add(this.activitatiVechi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.descriereBox);
            this.Controls.Add(this.numeBox);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activitatiVechi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numeBox;
        private System.Windows.Forms.TextBox descriereBox;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView activitatiVechi;
        private System.Windows.Forms.Button afiseasaButton;
        private System.Windows.Forms.Button stergeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button nouButton;
    }
}

