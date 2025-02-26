namespace NDP_Project
{
    partial class ClientSystem
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
            panel1 = new Panel();
            button_ClientList = new Button();
            button_CBook = new Button();
            button_CClientDelete = new Button();
            button_CClientRegister = new Button();
            button_BackMP = new Button();
            button_CFinishRegister = new Button();
            textBox_CContact = new TextBox();
            label_CContact = new Label();
            textBox_CSecondName = new TextBox();
            label_CSecondName = new Label();
            textBox_CName = new TextBox();
            label_CName = new Label();
            label_CSuccessRegister = new Label();
            label_CWarningRegister = new Label();
            label_CContactDelete = new Label();
            textBox_CContactDelete = new TextBox();
            button_CDelete = new Button();
            label_CWarningDelete = new Label();
            label_CSuccessDelete = new Label();
            tableLayoutPanel_CList = new TableLayoutPanel();
            label_CNameList = new Label();
            label_CSecondnameList = new Label();
            label_CContactList = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(button_ClientList);
            panel1.Controls.Add(button_CBook);
            panel1.Controls.Add(button_CClientDelete);
            panel1.Controls.Add(button_CClientRegister);
            panel1.Controls.Add(button_BackMP);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 476);
            panel1.TabIndex = 2;
            // 
            // button_ClientList
            // 
            button_ClientList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_ClientList.BackColor = Color.LightGoldenrodYellow;
            button_ClientList.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_ClientList.ForeColor = Color.Navy;
            button_ClientList.Location = new Point(21, 285);
            button_ClientList.Name = "button_ClientList";
            button_ClientList.Size = new Size(121, 62);
            button_ClientList.TabIndex = 4;
            button_ClientList.Text = "Müşteri Listele";
            button_ClientList.UseVisualStyleBackColor = false;
            button_ClientList.Click += button_ClientList_Click;
            // 
            // button_CBook
            // 
            button_CBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_CBook.BackColor = Color.LightGoldenrodYellow;
            button_CBook.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_CBook.ForeColor = Color.Navy;
            button_CBook.Location = new Point(21, 353);
            button_CBook.Name = "button_CBook";
            button_CBook.Size = new Size(121, 62);
            button_CBook.TabIndex = 4;
            button_CBook.Text = "Randevu Sistemi";
            button_CBook.UseVisualStyleBackColor = false;
            button_CBook.Click += button_CBook_Click;
            // 
            // button_CClientDelete
            // 
            button_CClientDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_CClientDelete.BackColor = Color.LightGoldenrodYellow;
            button_CClientDelete.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_CClientDelete.ForeColor = Color.Navy;
            button_CClientDelete.Location = new Point(21, 210);
            button_CClientDelete.Name = "button_CClientDelete";
            button_CClientDelete.Size = new Size(121, 69);
            button_CClientDelete.TabIndex = 4;
            button_CClientDelete.Text = "Müşteri Sil";
            button_CClientDelete.UseVisualStyleBackColor = false;
            button_CClientDelete.Click += button_CClientDelete_Click;
            // 
            // button_CClientRegister
            // 
            button_CClientRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_CClientRegister.BackColor = Color.LightGoldenrodYellow;
            button_CClientRegister.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_CClientRegister.ForeColor = Color.Navy;
            button_CClientRegister.Location = new Point(21, 135);
            button_CClientRegister.Name = "button_CClientRegister";
            button_CClientRegister.Size = new Size(121, 66);
            button_CClientRegister.TabIndex = 4;
            button_CClientRegister.Text = "Müşteri Ekle";
            button_CClientRegister.UseVisualStyleBackColor = false;
            button_CClientRegister.Click += button_CClientRegister_Click;
            // 
            // button_BackMP
            // 
            button_BackMP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_BackMP.BackColor = Color.LightGoldenrodYellow;
            button_BackMP.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_BackMP.ForeColor = Color.Navy;
            button_BackMP.Location = new Point(21, 435);
            button_BackMP.Name = "button_BackMP";
            button_BackMP.Size = new Size(121, 35);
            button_BackMP.TabIndex = 4;
            button_BackMP.Text = "Ana Sayfa";
            button_BackMP.UseVisualStyleBackColor = false;
            button_BackMP.Click += button_BackMP_Click;
            // 
            // button_CFinishRegister
            // 
            button_CFinishRegister.BackColor = Color.Navy;
            button_CFinishRegister.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_CFinishRegister.ForeColor = Color.LightGoldenrodYellow;
            button_CFinishRegister.Location = new Point(427, 350);
            button_CFinishRegister.Name = "button_CFinishRegister";
            button_CFinishRegister.Size = new Size(225, 65);
            button_CFinishRegister.TabIndex = 11;
            button_CFinishRegister.Text = "Kaydet";
            button_CFinishRegister.UseVisualStyleBackColor = false;
            button_CFinishRegister.Visible = false;
            button_CFinishRegister.Click += button_CFinishRegister_Click;
            // 
            // textBox_CContact
            // 
            textBox_CContact.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_CContact.ForeColor = Color.Navy;
            textBox_CContact.Location = new Point(427, 282);
            textBox_CContact.Name = "textBox_CContact";
            textBox_CContact.Size = new Size(225, 38);
            textBox_CContact.TabIndex = 12;
            textBox_CContact.Visible = false;
            // 
            // label_CContact
            // 
            label_CContact.AutoSize = true;
            label_CContact.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_CContact.ForeColor = Color.Navy;
            label_CContact.Location = new Point(427, 243);
            label_CContact.Name = "label_CContact";
            label_CContact.Size = new Size(164, 36);
            label_CContact.TabIndex = 13;
            label_CContact.Text = "İletisim No:";
            label_CContact.Visible = false;
            // 
            // textBox_CSecondName
            // 
            textBox_CSecondName.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_CSecondName.ForeColor = Color.Navy;
            textBox_CSecondName.Location = new Point(427, 199);
            textBox_CSecondName.Name = "textBox_CSecondName";
            textBox_CSecondName.Size = new Size(225, 38);
            textBox_CSecondName.TabIndex = 14;
            textBox_CSecondName.Visible = false;
            // 
            // label_CSecondName
            // 
            label_CSecondName.AutoSize = true;
            label_CSecondName.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_CSecondName.ForeColor = Color.Navy;
            label_CSecondName.Location = new Point(427, 160);
            label_CSecondName.Name = "label_CSecondName";
            label_CSecondName.Size = new Size(114, 36);
            label_CSecondName.TabIndex = 15;
            label_CSecondName.Text = "Soyadı :";
            label_CSecondName.Visible = false;
            // 
            // textBox_CName
            // 
            textBox_CName.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_CName.ForeColor = Color.Navy;
            textBox_CName.Location = new Point(427, 119);
            textBox_CName.Name = "textBox_CName";
            textBox_CName.Size = new Size(225, 38);
            textBox_CName.TabIndex = 16;
            textBox_CName.Visible = false;
            // 
            // label_CName
            // 
            label_CName.AutoSize = true;
            label_CName.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_CName.ForeColor = Color.Navy;
            label_CName.Location = new Point(427, 80);
            label_CName.Name = "label_CName";
            label_CName.Size = new Size(77, 36);
            label_CName.TabIndex = 17;
            label_CName.Text = "Adı :";
            label_CName.Visible = false;
            // 
            // label_CSuccessRegister
            // 
            label_CSuccessRegister.AutoSize = true;
            label_CSuccessRegister.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_CSuccessRegister.ForeColor = Color.Navy;
            label_CSuccessRegister.Location = new Point(301, 51);
            label_CSuccessRegister.Name = "label_CSuccessRegister";
            label_CSuccessRegister.Size = new Size(498, 29);
            label_CSuccessRegister.TabIndex = 18;
            label_CSuccessRegister.Text = "KAYIT İŞLEMİ BAŞARIYLA TAMAMLANDI!";
            label_CSuccessRegister.Visible = false;
            // 
            // label_CWarningRegister
            // 
            label_CWarningRegister.AutoSize = true;
            label_CWarningRegister.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_CWarningRegister.ForeColor = Color.Navy;
            label_CWarningRegister.Location = new Point(260, 51);
            label_CWarningRegister.Name = "label_CWarningRegister";
            label_CWarningRegister.Size = new Size(591, 29);
            label_CWarningRegister.TabIndex = 19;
            label_CWarningRegister.Text = "LÜTFEN TÜM ALANLARI EKSİKSİZ DOLDURUNUZ!";
            label_CWarningRegister.Visible = false;
            // 
            // label_CContactDelete
            // 
            label_CContactDelete.AutoSize = true;
            label_CContactDelete.Font = new Font("Sylfaen", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_CContactDelete.ForeColor = Color.Navy;
            label_CContactDelete.Location = new Point(427, 160);
            label_CContactDelete.Name = "label_CContactDelete";
            label_CContactDelete.Size = new Size(164, 36);
            label_CContactDelete.TabIndex = 13;
            label_CContactDelete.Text = "İletisim No:";
            label_CContactDelete.Visible = false;
            // 
            // textBox_CContactDelete
            // 
            textBox_CContactDelete.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox_CContactDelete.ForeColor = Color.Navy;
            textBox_CContactDelete.Location = new Point(427, 199);
            textBox_CContactDelete.Name = "textBox_CContactDelete";
            textBox_CContactDelete.Size = new Size(225, 38);
            textBox_CContactDelete.TabIndex = 12;
            textBox_CContactDelete.Visible = false;
            // 
            // button_CDelete
            // 
            button_CDelete.BackColor = Color.Navy;
            button_CDelete.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_CDelete.ForeColor = Color.LightGoldenrodYellow;
            button_CDelete.Location = new Point(427, 267);
            button_CDelete.Name = "button_CDelete";
            button_CDelete.Size = new Size(225, 65);
            button_CDelete.TabIndex = 20;
            button_CDelete.Text = "Sil";
            button_CDelete.UseVisualStyleBackColor = false;
            button_CDelete.Visible = false;
            button_CDelete.Click += button_CDelete_Click;
            // 
            // label_CWarningDelete
            // 
            label_CWarningDelete.AutoSize = true;
            label_CWarningDelete.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_CWarningDelete.ForeColor = Color.Navy;
            label_CWarningDelete.Location = new Point(328, 128);
            label_CWarningDelete.Name = "label_CWarningDelete";
            label_CWarningDelete.Size = new Size(396, 29);
            label_CWarningDelete.TabIndex = 21;
            label_CWarningDelete.Text = "KAYITLI MÜŞTERİ BULUNAMADI";
            label_CWarningDelete.Visible = false;
            // 
            // label_CSuccessDelete
            // 
            label_CSuccessDelete.AutoSize = true;
            label_CSuccessDelete.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_CSuccessDelete.ForeColor = Color.Navy;
            label_CSuccessDelete.Location = new Point(311, 128);
            label_CSuccessDelete.Name = "label_CSuccessDelete";
            label_CSuccessDelete.Size = new Size(452, 29);
            label_CSuccessDelete.TabIndex = 21;
            label_CSuccessDelete.Text = "İŞLEMİNİZ BAŞARIYLA TAMAMLANDI";
            label_CSuccessDelete.Visible = false;
            // 
            // tableLayoutPanel_CList
            // 
            tableLayoutPanel_CList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel_CList.BackColor = Color.LightYellow;
            tableLayoutPanel_CList.ColumnCount = 3;
            tableLayoutPanel_CList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel_CList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel_CList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tableLayoutPanel_CList.ForeColor = Color.Navy;
            tableLayoutPanel_CList.Location = new Point(246, 42);
            tableLayoutPanel_CList.Name = "tableLayoutPanel_CList";
            tableLayoutPanel_CList.RowCount = 1;
            tableLayoutPanel_CList.RowStyles.Add(new RowStyle());
            tableLayoutPanel_CList.Size = new Size(591, 422);
            tableLayoutPanel_CList.TabIndex = 22;
            tableLayoutPanel_CList.Visible = false;
            // 
            // label_CNameList
            // 
            label_CNameList.AutoSize = true;
            label_CNameList.Font = new Font("Sylfaen", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_CNameList.ForeColor = Color.Navy;
            label_CNameList.Location = new Point(246, 0);
            label_CNameList.Name = "label_CNameList";
            label_CNameList.Size = new Size(84, 44);
            label_CNameList.TabIndex = 23;
            label_CNameList.Text = "İsim";
            label_CNameList.Visible = false;
            // 
            // label_CSecondnameList
            // 
            label_CSecondnameList.AutoSize = true;
            label_CSecondnameList.Font = new Font("Sylfaen", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_CSecondnameList.ForeColor = Color.Navy;
            label_CSecondnameList.Location = new Point(441, 0);
            label_CSecondnameList.Name = "label_CSecondnameList";
            label_CSecondnameList.Size = new Size(136, 44);
            label_CSecondnameList.TabIndex = 23;
            label_CSecondnameList.Text = "Soyisim";
            label_CSecondnameList.Visible = false;
            // 
            // label_CContactList
            // 
            label_CContactList.AutoSize = true;
            label_CContactList.Font = new Font("Sylfaen", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_CContactList.ForeColor = Color.Navy;
            label_CContactList.Location = new Point(634, 0);
            label_CContactList.Name = "label_CContactList";
            label_CContactList.Size = new Size(189, 44);
            label_CContactList.TabIndex = 23;
            label_CContactList.Text = "İletisim No";
            label_CContactList.Visible = false;
            // 
            // ClientSystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(910, 476);
            Controls.Add(label_CContactList);
            Controls.Add(label_CSecondnameList);
            Controls.Add(label_CNameList);
            Controls.Add(tableLayoutPanel_CList);
            Controls.Add(label_CSuccessDelete);
            Controls.Add(label_CWarningDelete);
            Controls.Add(label_CContactDelete);
            Controls.Add(button_CDelete);
            Controls.Add(label_CSuccessRegister);
            Controls.Add(label_CName);
            Controls.Add(textBox_CName);
            Controls.Add(label_CSecondName);
            Controls.Add(textBox_CSecondName);
            Controls.Add(label_CContact);
            Controls.Add(textBox_CContactDelete);
            Controls.Add(textBox_CContact);
            Controls.Add(button_CFinishRegister);
            Controls.Add(panel1);
            Controls.Add(label_CWarningRegister);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClientSystem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClientSystem";
            Load += ClientSystem_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button_BackMP;
        private Button button_CBook;
        private Button button_CClientDelete;
        private Button button_CClientRegister;
        private Button button_CFinishRegister;
        private TextBox textBox_CContact;
        private Label label_CContact;
        private TextBox textBox_CSecondName;
        private Label label_CSecondName;
        private TextBox textBox_CName;
        private Label label_CName;
        private Label label_CSuccessRegister;
        private Label label_CWarningRegister;
        private Label label_CContactDelete;
        private TextBox textBox_CContactDelete;
        private Button button_CDelete;
        private Label label_CWarningDelete;
        private Label label_CSuccessDelete;
        private Button button_ClientList;
        private TableLayoutPanel tableLayoutPanel_CList;
        private Label label_CNameList;
        private Label label_CSecondnameList;
        private Label label_CContactList;
    }
}