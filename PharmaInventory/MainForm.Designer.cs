namespace PharmaInventory
{
    partial class MainForm
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
            flowLayoutPanel = new FlowLayoutPanel();
            addBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel.BackColor = Color.PaleTurquoise;
            flowLayoutPanel.Location = new Point(0, 116);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(919, 404);
            flowLayoutPanel.TabIndex = 1;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addBtn.BackColor = Color.PaleTurquoise;
            addBtn.Location = new Point(739, 55);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(102, 23);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add Medicine";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 38);
            label1.Name = "label1";
            label1.Size = new Size(371, 41);
            label1.TabIndex = 1;
            label1.Text = "Pharmacy Inventory System";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(919, 521);
            Controls.Add(addBtn);
            Controls.Add(flowLayoutPanel);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel;
        private Button addBtn;
        private Label label1;
    }
}