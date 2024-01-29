namespace verifica_MySQL
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodFarnell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColonnaCodiceProduttore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantità = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodFarnell,
            this.ColonnaCodiceProduttore,
            this.Quantità,
            this.Prezzo,
            this.ID});
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(701, 352);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CodFarnell
            // 
            this.CodFarnell.HeaderText = "CodFarnell";
            this.CodFarnell.Name = "CodFarnell";
            this.CodFarnell.ReadOnly = true;
            // 
            // ColonnaCodiceProduttore
            // 
            this.ColonnaCodiceProduttore.HeaderText = "CodiceProduttore";
            this.ColonnaCodiceProduttore.Name = "ColonnaCodiceProduttore";
            this.ColonnaCodiceProduttore.ReadOnly = true;
            // 
            // Quantità
            // 
            this.Quantità.HeaderText = "Quantità";
            this.Quantità.Name = "Quantità";
            this.Quantità.ReadOnly = true;
            // 
            // Prezzo
            // 
            this.Prezzo.HeaderText = "Prezzo";
            this.Prezzo.Name = "Prezzo";
            this.Prezzo.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CodFarnell;
        private DataGridViewTextBoxColumn ColonnaCodiceProduttore;
        private DataGridViewTextBoxColumn Quantità;
        private DataGridViewTextBoxColumn Prezzo;
        private DataGridViewTextBoxColumn ID;
    }
}