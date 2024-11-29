namespace PharmaInventory.Forms
{
    partial class UpdateForm
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
            uptmedName = new TextBox();
            uptexpiryDate = new DateTimePicker();
            updateMedBtn = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            uptmanufacturedDate = new DateTimePicker();
            uptDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // uptmedName
            // 
            uptmedName.Anchor = AnchorStyles.Top;
            uptmedName.Location = new Point(199, 89);
            uptmedName.Name = "uptmedName";
            uptmedName.Size = new Size(227, 23);
            uptmedName.TabIndex = 1;
            // 
            // uptexpiryDate
            // 
            uptexpiryDate.Anchor = AnchorStyles.Top;
            uptexpiryDate.Location = new Point(199, 190);
            uptexpiryDate.Name = "uptexpiryDate";
            uptexpiryDate.Size = new Size(227, 23);
            uptexpiryDate.TabIndex = 3;
            // 
            // updateMedBtn
            // 
            updateMedBtn.Anchor = AnchorStyles.Top;
            updateMedBtn.Location = new Point(313, 318);
            updateMedBtn.Name = "updateMedBtn";
            updateMedBtn.Size = new Size(113, 23);
            updateMedBtn.TabIndex = 4;
            updateMedBtn.Text = "Update Medicine";
            updateMedBtn.UseVisualStyleBackColor = true;
            updateMedBtn.Click += updateMedBtn_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // uptmanufacturedDate
            // 
            uptmanufacturedDate.Anchor = AnchorStyles.Top;
            uptmanufacturedDate.Location = new Point(199, 137);
            uptmanufacturedDate.Name = "uptmanufacturedDate";
            uptmanufacturedDate.Size = new Size(227, 23);
            uptmanufacturedDate.TabIndex = 5;
            // 
            // uptDescription
            // 
            uptDescription.Anchor = AnchorStyles.Top;
            uptDescription.Location = new Point(199, 236);
            uptDescription.Multiline = true;
            uptDescription.Name = "uptDescription";
            uptDescription.Size = new Size(227, 62);
            uptDescription.TabIndex = 6;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 22);
            label1.Name = "label1";
            label1.Size = new Size(318, 41);
            label1.TabIndex = 7;
            label1.Text = "Pharmacy Update Form";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(79, 95);
            label2.Name = "label2";
            label2.Size = new Size(87, 17);
            label2.TabIndex = 8;
            label2.Text = "Medicine Name :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 143);
            label3.Name = "label3";
            label3.Size = new Size(105, 17);
            label3.TabIndex = 9;
            label3.Text = "Manufactured Date :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(99, 195);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 10;
            label4.Text = "Expiry Date :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(98, 236);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 11;
            label5.Text = "Description :\r\n";
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(571, 383);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(uptDescription);
            Controls.Add(uptmanufacturedDate);
            Controls.Add(updateMedBtn);
            Controls.Add(uptexpiryDate);
            Controls.Add(uptmedName);
            Name = "UpdateForm";
            Text = "UpdatePharmaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox uptmedName;
        private DateTimePicker uptexpiryDate;
        private Button updateMedBtn;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DateTimePicker uptmanufacturedDate;
        private TextBox uptDescription;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}