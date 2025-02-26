namespace NDP_Project
{
    partial class BookList
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
            label_Client = new Label();
            label_Personel = new Label();
            label_Service = new Label();
            label_Date = new Label();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            SuspendLayout();
            // 
            // label_Client
            // 
            label_Client.AutoSize = true;
            label_Client.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_Client.ForeColor = Color.LightGoldenrodYellow;
            label_Client.Location = new Point(12, 6);
            label_Client.Name = "label_Client";
            label_Client.Size = new Size(123, 39);
            label_Client.TabIndex = 1;
            label_Client.Text = "Müşteri";
            // 
            // label_Personel
            // 
            label_Personel.AutoSize = true;
            label_Personel.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_Personel.ForeColor = Color.LightGoldenrodYellow;
            label_Personel.Location = new Point(233, 6);
            label_Personel.Name = "label_Personel";
            label_Personel.Size = new Size(134, 39);
            label_Personel.TabIndex = 1;
            label_Personel.Text = "Personel";
            // 
            // label_Service
            // 
            label_Service.AutoSize = true;
            label_Service.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_Service.ForeColor = Color.LightGoldenrodYellow;
            label_Service.Location = new Point(454, 6);
            label_Service.Name = "label_Service";
            label_Service.Size = new Size(92, 39);
            label_Service.TabIndex = 1;
            label_Service.Text = "İşlem";
            // 
            // label_Date
            // 
            label_Date.AutoSize = true;
            label_Date.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_Date.ForeColor = Color.LightGoldenrodYellow;
            label_Date.Location = new Point(678, 6);
            label_Date.Name = "label_Date";
            label_Date.Size = new Size(90, 39);
            label_Date.TabIndex = 1;
            label_Date.Text = "Tarih";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGoldenrodYellow;
            button1.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(739, 427);
            button1.Name = "button1";
            button1.Size = new Size(159, 45);
            button1.TabIndex = 2;
            button1.Text = "Geri Dön";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.BackColor = Color.LightYellow;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ForeColor = Color.Navy;
            tableLayoutPanel1.Location = new Point(12, 48);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(886, 362);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // BookList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(910, 476);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(label_Date);
            Controls.Add(label_Service);
            Controls.Add(label_Personel);
            Controls.Add(label_Client);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookList";
            Load += BookList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_Client;
        private Label label_Personel;
        private Label label_Service;
        private Label label_Date;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}