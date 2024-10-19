namespace WinformsPOS
{
    partial class Menu
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
            btnGetProductosData = new Button();
            productsTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)productsTable).BeginInit();
            SuspendLayout();
            // 
            // btnGetProductosData
            // 
            btnGetProductosData.Location = new Point(33, 27);
            btnGetProductosData.Name = "btnGetProductosData";
            btnGetProductosData.Size = new Size(163, 29);
            btnGetProductosData.TabIndex = 0;
            btnGetProductosData.Text = "Obtener Productos";
            btnGetProductosData.UseVisualStyleBackColor = true;
            btnGetProductosData.Click += btnGetProductosData_Click;
            // 
            // productsTable
            // 
            productsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsTable.Location = new Point(33, 80);
            productsTable.Name = "productsTable";
            productsTable.RowHeadersWidth = 51;
            productsTable.Size = new Size(929, 398);
            productsTable.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 515);
            Controls.Add(productsTable);
            Controls.Add(btnGetProductosData);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)productsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGetProductosData;
        private DataGridView productsTable;
    }
}
