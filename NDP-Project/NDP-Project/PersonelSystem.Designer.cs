namespace NDP_Project
{
    partial class PersonelSystem
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
            label_PName = new Label();
            textBox_PName = new TextBox();
            label_PSecondName = new Label();
            textBox_PSecondName = new TextBox();
            label_PContact = new Label();
            textBox_PContact = new TextBox();
            button_PFinishRegister = new Button();
            label_PWarningRegister = new Label();
            label_PSuccessRegister = new Label();
            label_PContactDelete = new Label();
            textBox_PContactDelete = new TextBox();
            button_PDelete = new Button();
            tableLayoutPanel_PList = new TableLayoutPanel();
            label_PTableName = new Label();
            label_PTableSecondName = new Label();
            label_PTableContact = new Label();
            label_PWarningDelete = new Label();
            label_PSuccessDelete = new Label();
            button_RegisterPersonel = new Button();
            button_PersonelDelete = new Button();
            button_PesonelList = new Button();
            button_BackMP = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_PName
            // 
            label_PName.AutoSize = true;
            label_PName.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_PName.ForeColor = Color.Navy;
            label_PName.Location = new Point(423, 81);
            label_PName.Name = "label_PName";
            label_PName.Size = new Size(77, 36);
            label_PName.TabIndex = 4;
            label_PName.Text = "Adı :";
            label_PName.Visible = false;
            // 
            // textBox_PName
            // 
            textBox_PName.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_PName.ForeColor = Color.Navy;
            textBox_PName.Location = new Point(423, 120);
            textBox_PName.Name = "textBox_PName";
            textBox_PName.Size = new Size(225, 38);
            textBox_PName.TabIndex = 5;
            textBox_PName.Visible = false;
            // 
            // label_PSecondName
            // 
            label_PSecondName.AutoSize = true;
            label_PSecondName.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_PSecondName.ForeColor = Color.Navy;
            label_PSecondName.Location = new Point(423, 161);
            label_PSecondName.Name = "label_PSecondName";
            label_PSecondName.Size = new Size(114, 36);
            label_PSecondName.TabIndex = 6;
            label_PSecondName.Text = "Soyadı :";
            label_PSecondName.Visible = false;
            // 
            // textBox_PSecondName
            // 
            textBox_PSecondName.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_PSecondName.ForeColor = Color.Navy;
            textBox_PSecondName.Location = new Point(423, 200);
            textBox_PSecondName.Name = "textBox_PSecondName";
            textBox_PSecondName.Size = new Size(225, 38);
            textBox_PSecondName.TabIndex = 7;
            textBox_PSecondName.Visible = false;
            // 
            // label_PContact
            // 
            label_PContact.AutoSize = true;
            label_PContact.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_PContact.ForeColor = Color.Navy;
            label_PContact.Location = new Point(423, 241);
            label_PContact.Name = "label_PContact";
            label_PContact.Size = new Size(164, 36);
            label_PContact.TabIndex = 8;
            label_PContact.Text = "İletisim No:";
            label_PContact.Visible = false;
            // 
            // textBox_PContact
            // 
            textBox_PContact.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_PContact.ForeColor = Color.Navy;
            textBox_PContact.Location = new Point(423, 280);
            textBox_PContact.Name = "textBox_PContact";
            textBox_PContact.Size = new Size(225, 38);
            textBox_PContact.TabIndex = 9;
            textBox_PContact.Visible = false;
            // 
            // button_PFinishRegister
            // 
            button_PFinishRegister.BackColor = Color.Navy;
            button_PFinishRegister.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_PFinishRegister.ForeColor = Color.LightGoldenrodYellow;
            button_PFinishRegister.Location = new Point(423, 334);
            button_PFinishRegister.Name = "button_PFinishRegister";
            button_PFinishRegister.Size = new Size(225, 65);
            button_PFinishRegister.TabIndex = 10;
            button_PFinishRegister.Text = "Kaydet";
            button_PFinishRegister.UseVisualStyleBackColor = false;
            button_PFinishRegister.Visible = false;
            button_PFinishRegister.Click += button_PFinishRegister_Click;
            // 
            // label_PWarningRegister
            // 
            label_PWarningRegister.AutoSize = true;
            label_PWarningRegister.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_PWarningRegister.ForeColor = Color.Navy;
            label_PWarningRegister.Location = new Point(254, 29);
            label_PWarningRegister.Name = "label_PWarningRegister";
            label_PWarningRegister.Size = new Size(591, 29);
            label_PWarningRegister.TabIndex = 11;
            label_PWarningRegister.Text = "LÜTFEN TÜM ALANLARI EKSİKSİZ DOLDURUNUZ!";
            label_PWarningRegister.Visible = false;
            // 
            // label_PSuccessRegister
            // 
            label_PSuccessRegister.AutoSize = true;
            label_PSuccessRegister.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_PSuccessRegister.ForeColor = Color.Navy;
            label_PSuccessRegister.Location = new Point(311, 29);
            label_PSuccessRegister.Name = "label_PSuccessRegister";
            label_PSuccessRegister.Size = new Size(498, 29);
            label_PSuccessRegister.TabIndex = 12;
            label_PSuccessRegister.Text = "KAYIT İŞLEMİ BAŞARIYLA TAMAMLANDI!";
            label_PSuccessRegister.Visible = false;
            // 
            // label_PContactDelete
            // 
            label_PContactDelete.AutoSize = true;
            label_PContactDelete.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_PContactDelete.ForeColor = Color.Navy;
            label_PContactDelete.Location = new Point(423, 161);
            label_PContactDelete.Name = "label_PContactDelete";
            label_PContactDelete.Size = new Size(164, 36);
            label_PContactDelete.TabIndex = 8;
            label_PContactDelete.Text = "İletisim No:";
            label_PContactDelete.Visible = false;
            // 
            // textBox_PContactDelete
            // 
            textBox_PContactDelete.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_PContactDelete.ForeColor = Color.Navy;
            textBox_PContactDelete.Location = new Point(423, 200);
            textBox_PContactDelete.Name = "textBox_PContactDelete";
            textBox_PContactDelete.Size = new Size(225, 38);
            textBox_PContactDelete.TabIndex = 9;
            textBox_PContactDelete.Visible = false;
            // 
            // button_PDelete
            // 
            button_PDelete.BackColor = Color.Navy;
            button_PDelete.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_PDelete.ForeColor = Color.LightGoldenrodYellow;
            button_PDelete.Location = new Point(423, 280);
            button_PDelete.Name = "button_PDelete";
            button_PDelete.Size = new Size(225, 65);
            button_PDelete.TabIndex = 10;
            button_PDelete.Text = "Sil";
            button_PDelete.UseVisualStyleBackColor = false;
            button_PDelete.Visible = false;
            button_PDelete.Click += button_PDelete_Click;
            // 
            // tableLayoutPanel_PList
            // 
            tableLayoutPanel_PList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel_PList.BackColor = Color.LightYellow;
            tableLayoutPanel_PList.ColumnCount = 3;
            tableLayoutPanel_PList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel_PList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel_PList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel_PList.ForeColor = Color.Navy;
            tableLayoutPanel_PList.Location = new Point(254, 29);
            tableLayoutPanel_PList.Name = "tableLayoutPanel_PList";
            tableLayoutPanel_PList.RowCount = 1;
            tableLayoutPanel_PList.RowStyles.Add(new RowStyle());
            tableLayoutPanel_PList.Size = new Size(591, 422);
            tableLayoutPanel_PList.TabIndex = 14;
            tableLayoutPanel_PList.Visible = false;
            // 
            // label_PTableName
            // 
            label_PTableName.AutoSize = true;
            label_PTableName.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_PTableName.ForeColor = Color.MidnightBlue;
            label_PTableName.Location = new Point(254, 0);
            label_PTableName.Name = "label_PTableName";
            label_PTableName.Size = new Size(77, 36);
            label_PTableName.TabIndex = 15;
            label_PTableName.Text = "İSİM";
            label_PTableName.Visible = false;
            // 
            // label_PTableSecondName
            // 
            label_PTableSecondName.AutoSize = true;
            label_PTableSecondName.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_PTableSecondName.ForeColor = Color.MidnightBlue;
            label_PTableSecondName.Location = new Point(454, 0);
            label_PTableSecondName.Name = "label_PTableSecondName";
            label_PTableSecondName.Size = new Size(133, 36);
            label_PTableSecondName.TabIndex = 15;
            label_PTableSecondName.Text = "SOYİSİM";
            label_PTableSecondName.Visible = false;
            // 
            // label_PTableContact
            // 
            label_PTableContact.AutoSize = true;
            label_PTableContact.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_PTableContact.ForeColor = Color.MidnightBlue;
            label_PTableContact.Location = new Point(645, 0);
            label_PTableContact.Name = "label_PTableContact";
            label_PTableContact.Size = new Size(190, 36);
            label_PTableContact.TabIndex = 15;
            label_PTableContact.Text = "İLETİSİM NO";
            label_PTableContact.Visible = false;
            // 
            // label_PWarningDelete
            // 
            label_PWarningDelete.AutoSize = true;
            label_PWarningDelete.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_PWarningDelete.ForeColor = Color.Navy;
            label_PWarningDelete.Location = new Point(311, 132);
            label_PWarningDelete.Name = "label_PWarningDelete";
            label_PWarningDelete.Size = new Size(411, 29);
            label_PWarningDelete.TabIndex = 16;
            label_PWarningDelete.Text = "KAYITLI PERSONEL BULUNAMADI";
            label_PWarningDelete.Visible = false;
            // 
            // label_PSuccessDelete
            // 
            label_PSuccessDelete.AutoSize = true;
            label_PSuccessDelete.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_PSuccessDelete.ForeColor = Color.Navy;
            label_PSuccessDelete.Location = new Point(311, 132);
            label_PSuccessDelete.Name = "label_PSuccessDelete";
            label_PSuccessDelete.Size = new Size(452, 29);
            label_PSuccessDelete.TabIndex = 16;
            label_PSuccessDelete.Text = "İŞLEMİNİZ BAŞARIYLA TAMAMLANDI";
            label_PSuccessDelete.Visible = false;
            // 
            // button_RegisterPersonel
            // 
            button_RegisterPersonel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_RegisterPersonel.BackColor = Color.LightGoldenrodYellow;
            button_RegisterPersonel.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_RegisterPersonel.ForeColor = Color.Navy;
            button_RegisterPersonel.Location = new Point(25, 158);
            button_RegisterPersonel.Name = "button_RegisterPersonel";
            button_RegisterPersonel.Size = new Size(121, 69);
            button_RegisterPersonel.TabIndex = 2;
            button_RegisterPersonel.Text = "Personel Kayıt";
            button_RegisterPersonel.UseVisualStyleBackColor = false;
            button_RegisterPersonel.Click += button_RegisterPersonel_Click;
            // 
            // button_PersonelDelete
            // 
            button_PersonelDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_PersonelDelete.BackColor = Color.LightGoldenrodYellow;
            button_PersonelDelete.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_PersonelDelete.ForeColor = Color.Navy;
            button_PersonelDelete.Location = new Point(25, 241);
            button_PersonelDelete.Name = "button_PersonelDelete";
            button_PersonelDelete.Size = new Size(121, 63);
            button_PersonelDelete.TabIndex = 2;
            button_PersonelDelete.Text = "Personel Sil";
            button_PersonelDelete.UseVisualStyleBackColor = false;
            button_PersonelDelete.Click += button_PersonelDelete_Click;
            // 
            // button_PesonelList
            // 
            button_PesonelList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_PesonelList.BackColor = Color.LightGoldenrodYellow;
            button_PesonelList.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_PesonelList.ForeColor = Color.Navy;
            button_PesonelList.Location = new Point(25, 325);
            button_PesonelList.Name = "button_PesonelList";
            button_PesonelList.Size = new Size(121, 63);
            button_PesonelList.TabIndex = 2;
            button_PesonelList.Text = "Personel Listele";
            button_PesonelList.UseVisualStyleBackColor = false;
            button_PesonelList.Click += button_PesonelList_Click;
            // 
            // button_BackMP
            // 
            button_BackMP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_BackMP.BackColor = Color.LightGoldenrodYellow;
            button_BackMP.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_BackMP.ForeColor = Color.Navy;
            button_BackMP.Location = new Point(25, 416);
            button_BackMP.Name = "button_BackMP";
            button_BackMP.Size = new Size(121, 48);
            button_BackMP.TabIndex = 3;
            button_BackMP.Text = "Ana Sayfa";
            button_BackMP.UseVisualStyleBackColor = false;
            button_BackMP.Click += button_BackMP_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(button_BackMP);
            panel1.Controls.Add(button_PesonelList);
            panel1.Controls.Add(button_PersonelDelete);
            panel1.Controls.Add(button_RegisterPersonel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 476);
            panel1.TabIndex = 3;
            // 
            // PersonelSystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(910, 476);
            Controls.Add(tableLayoutPanel_PList);
            Controls.Add(label_PSuccessDelete);
            Controls.Add(label_PWarningDelete);
            Controls.Add(button_PDelete);
            Controls.Add(label_PContactDelete);
            Controls.Add(label_PTableSecondName);
            Controls.Add(label_PTableContact);
            Controls.Add(label_PTableName);
            Controls.Add(label_PSuccessRegister);
            Controls.Add(label_PWarningRegister);
            Controls.Add(button_PFinishRegister);
            Controls.Add(textBox_PContactDelete);
            Controls.Add(textBox_PContact);
            Controls.Add(label_PContact);
            Controls.Add(textBox_PSecondName);
            Controls.Add(label_PSecondName);
            Controls.Add(textBox_PName);
            Controls.Add(label_PName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonelSystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PersonelSystem";
            Load += PersonelSystem_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_DeletePersonel;
        private Button button_Personel;
        private Label label_PName;
        private TextBox textBox_PName;
        private Label label_PSecondName;
        private TextBox textBox_PSecondName;
        private Label label_PContact;
        private TextBox textBox_PContact;
        private Button button_PFinishRegister;
        private Label label_PWarningRegister;
        private Label label_PSuccessRegister;
        private Label label_PContactDelete;
        private TextBox textBox_PContactDelete;
        private Button button_PDelete;
        private TableLayoutPanel tableLayoutPanel_PList;
        private Label label_PTableName;
        private Label label_PTableSecondName;
        private Label label_PTableContact;
        private Label label_PWarningDelete;
        private Label label_PSuccessDelete;
        private Button button_RegisterPersonel;
        private Button button_PersonelDelete;
        private Button button_PesonelList;
        private Button button_BackMP;
        private Panel panel1;
    }
}