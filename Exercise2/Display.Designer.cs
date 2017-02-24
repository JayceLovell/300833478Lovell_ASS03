namespace Exercise2
{
    partial class Display
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
            this.authorDataGridView = new System.Windows.Forms.DataGridView();
            this.btnSort1 = new System.Windows.Forms.Button();
            this.btnQuestion2 = new System.Windows.Forms.Button();
            this.btnQuestion3 = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.authorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // authorDataGridView
            // 
            this.authorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.authorDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.authorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.authorDataGridView.Location = new System.Drawing.Point(0, 12);
            this.authorDataGridView.Name = "authorDataGridView";
            this.authorDataGridView.Size = new System.Drawing.Size(1041, 220);
            this.authorDataGridView.TabIndex = 1;
            // 
            // btnSort1
            // 
            this.btnSort1.Location = new System.Drawing.Point(0, 238);
            this.btnSort1.Name = "btnSort1";
            this.btnSort1.Size = new System.Drawing.Size(116, 38);
            this.btnSort1.TabIndex = 2;
            this.btnSort1.Text = "Question 1";
            this.btnSort1.UseVisualStyleBackColor = true;
            this.btnSort1.Click += new System.EventHandler(this.btnSort1_Click);
            // 
            // btnQuestion2
            // 
            this.btnQuestion2.Location = new System.Drawing.Point(482, 238);
            this.btnQuestion2.Name = "btnQuestion2";
            this.btnQuestion2.Size = new System.Drawing.Size(115, 38);
            this.btnQuestion2.TabIndex = 3;
            this.btnQuestion2.Text = "Question 2";
            this.btnQuestion2.UseVisualStyleBackColor = true;
            this.btnQuestion2.Click += new System.EventHandler(this.btnSort2_Click);
            // 
            // btnQuestion3
            // 
            this.btnQuestion3.Location = new System.Drawing.Point(922, 239);
            this.btnQuestion3.Name = "btnQuestion3";
            this.btnQuestion3.Size = new System.Drawing.Size(119, 37);
            this.btnQuestion3.TabIndex = 4;
            this.btnQuestion3.Text = "Question 3";
            this.btnQuestion3.UseVisualStyleBackColor = true;
            this.btnQuestion3.Click += new System.EventHandler(this.btnSort3_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(0, 283);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(1041, 34);
            this.btnViewAll.TabIndex = 5;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 513);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnQuestion3);
            this.Controls.Add(this.btnQuestion2);
            this.Controls.Add(this.btnSort1);
            this.Controls.Add(this.authorDataGridView);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Display";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Display";
            ((System.ComponentModel.ISupportInitialize)(this.authorDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView authorDataGridView;
        private System.Windows.Forms.Button btnSort1;
        private System.Windows.Forms.Button btnQuestion2;
        private System.Windows.Forms.Button btnQuestion3;
        private System.Windows.Forms.Button btnViewAll;
    }
}