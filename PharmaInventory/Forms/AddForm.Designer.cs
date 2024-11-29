namespace PharmaInventory.Forms
{
    partial class AddForm
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
            txtMedname = new TextBox();
            txtmedDescription = new TextBox();
            txtManufactureDate = new DateTimePicker();
            txtExpiryDate = new DateTimePicker();
            addBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtMedname
            // 
            txtMedname.Anchor = AnchorStyles.Top;
            txtMedname.Location = new Point(250, 88);
            txtMedname.Name = "txtMedname";
            txtMedname.Size = new Size(200, 23);
            txtMedname.TabIndex = 0;
            // 
            // txtmedDescription
            // 
            txtmedDescription.Anchor = AnchorStyles.Top;
            txtmedDescription.Location = new Point(250, 230);
            txtmedDescription.Multiline = true;
            txtmedDescription.Name = "txtmedDescription";
            txtmedDescription.Size = new Size(200, 59);
            txtmedDescription.TabIndex = 1;
            // 
            // txtManufactureDate
            // 
            txtManufactureDate.Anchor = AnchorStyles.Top;
            txtManufactureDate.Location = new Point(250, 131);
            txtManufactureDate.Name = "txtManufactureDate";
            txtManufactureDate.Size = new Size(200, 23);
            txtManufactureDate.TabIndex = 2;
            // 
            // txtExpiryDate
            // 
            txtExpiryDate.Anchor = AnchorStyles.Top;
            txtExpiryDate.Location = new Point(250, 180);
            txtExpiryDate.Name = "txtExpiryDate";
            txtExpiryDate.Size = new Size(200, 23);
            txtExpiryDate.TabIndex = 3;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Top;
            addBtn.BackColor = Color.PaleTurquoise;
            addBtn.Location = new Point(341, 308);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(109, 23);
            addBtn.TabIndex = 4;
            addBtn.Text = "Add Medicine";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(163, 23);
            label1.Name = "label1";
            label1.Size = new Size(274, 41);
            label1.TabIndex = 5;
            label1.Text = "Pharmacy Add Form";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(118, 94);
            label2.Name = "label2";
            label2.Size = new Size(87, 17);
            label2.TabIndex = 6;
            label2.Text = "Medicine Name :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(100, 137);
            label3.Name = "label3";
            label3.Size = new Size(105, 17);
            label3.TabIndex = 7;
            label3.Text = "Manufactured Date :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(138, 186);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 8;
            label4.Text = "Expiry Date :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(137, 230);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 9;
            label5.Text = "Description :\r\n";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(606, 365);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addBtn);
            Controls.Add(txtExpiryDate);
            Controls.Add(txtManufactureDate);
            Controls.Add(txtmedDescription);
            Controls.Add(txtMedname);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMedname;
        private TextBox txtmedDescription;
        private DateTimePicker txtManufactureDate;
        private DateTimePicker txtExpiryDate;
        private Button addBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}