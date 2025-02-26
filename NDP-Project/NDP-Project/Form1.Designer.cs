namespace NDP_Project
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
            label_Head1 = new Label();
            label2 = new Label();
            label_Head2 = new Label();
            button_Personel = new Button();
            button_Client = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_Head1
            // 
            label_Head1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Head1.AutoSize = true;
            label_Head1.Font = new Font("Stencil", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label_Head1.ForeColor = Color.Navy;
            label_Head1.Location = new Point(254, 145);
            label_Head1.Name = "label_Head1";
            label_Head1.Size = new Size(595, 71);
            label_Head1.TabIndex = 0;
            label_Head1.Text = "Güzellik Merkezi";
            label_Head1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 82);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 0;
            // 
            // label_Head2
            // 
            label_Head2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_Head2.AutoSize = true;
            label_Head2.Font = new Font("Stencil", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Head2.ForeColor = Color.Navy;
            label_Head2.Location = new Point(329, 216);
            label_Head2.Name = "label_Head2";
            label_Head2.Size = new Size(418, 56);
            label_Head2.TabIndex = 2;
            label_Head2.Text = "YÖNETİM SİSTEMİ";
            label_Head2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Personel
            // 
            button_Personel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Personel.BackColor = Color.LightGoldenrodYellow;
            button_Personel.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_Personel.ForeColor = Color.Navy;
            button_Personel.Location = new Point(23, 181);
            button_Personel.Name = "button_Personel";
            button_Personel.Size = new Size(121, 65);
            button_Personel.TabIndex = 1;
            button_Personel.Text = "Personel İşlemleri";
            button_Personel.UseVisualStyleBackColor = false;
            button_Personel.Click += button_Personel_Click;
            // 
            // button_Client
            // 
            button_Client.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Client.BackColor = Color.LightGoldenrodYellow;
            button_Client.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_Client.ForeColor = Color.Navy;
            button_Client.Location = new Point(23, 288);
            button_Client.Name = "button_Client";
            button_Client.Size = new Size(121, 63);
            button_Client.TabIndex = 1;
            button_Client.Text = "Müşteri İşlemleri";
            button_Client.UseVisualStyleBackColor = false;
            button_Client.Click += button_Client_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(button_Client);
            panel1.Controls.Add(button_Personel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 476);
            panel1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(910, 476);
            Controls.Add(label_Head2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label_Head1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Head1;
        private Label label2;
        private Label label_Head2;
        private Button button_Personel;
        private Button button_Client;
        private Panel panel1;
    }
}
