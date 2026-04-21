namespace Products
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProductID = new TextBox();
            txtProductName = new TextBox();
            numProductPrice = new NumericUpDown();
            listBox1 = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnRead = new Button();
            ((System.ComponentModel.ISupportInitialize)numProductPrice).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(409, 9);
            label1.Name = "label1";
            label1.Size = new Size(176, 50);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(147, 171);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 1;
            label2.Text = "Product ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(147, 235);
            label3.Name = "label3";
            label3.Size = new Size(142, 28);
            label3.TabIndex = 2;
            label3.Text = "Product Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(148, 293);
            label4.Name = "label4";
            label4.Size = new Size(132, 28);
            label4.TabIndex = 3;
            label4.Text = "Product Price:";
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductID.Location = new Point(295, 175);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(178, 34);
            txtProductID.TabIndex = 4;
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(295, 235);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(178, 34);
            txtProductName.TabIndex = 5;
            // 
            // numProductPrice
            // 
            numProductPrice.DecimalPlaces = 2;
            numProductPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numProductPrice.Location = new Point(295, 293);
            numProductPrice.Name = "numProductPrice";
            numProductPrice.Size = new Size(178, 34);
            numProductPrice.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(510, 123);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(360, 256);
            listBox1.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Location = new Point(262, 448);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 51);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.Location = new Point(482, 448);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 51);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SandyBrown;
            btnUpdate.Location = new Point(372, 448);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 51);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.PaleTurquoise;
            btnRead.Location = new Point(595, 448);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(107, 51);
            btnRead.TabIndex = 11;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 631);
            Controls.Add(btnRead);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(listBox1);
            Controls.Add(numProductPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtProductID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numProductPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProductID;
        private TextBox txtProductName;
        private NumericUpDown numProductPrice;
        private ListBox listBox1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnRead;
    }
}
