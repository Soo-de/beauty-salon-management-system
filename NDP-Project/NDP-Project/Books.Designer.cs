namespace NDP_Project
{
    partial class Books
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
            button_BBooksList = new Button();
            button_BakMP = new Button();
            button_Back = new Button();
            button_BBookDelete = new Button();
            button_CBook = new Button();
            monthCalendar_BookDate = new MonthCalendar();
            comboBox_BClient = new ComboBox();
            comboBox_BPersonel = new ComboBox();
            label_BDate = new Label();
            label_BClient = new Label();
            label_BPersonel = new Label();
            label_BServices = new Label();
            listBox_BFee = new ListBox();
            button_BFinishChoise = new Button();
            checkedListBox_BServices = new CheckedListBox();
            label_BClientWarning = new Label();
            label_BListFee = new Label();
            button_BAddList = new Button();
            button_BFinishBook = new Button();
            button_BDeleteItems = new Button();
            label_BBookWarning = new Label();
            label_BBookSuccess = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(button_BBooksList);
            panel1.Controls.Add(button_BakMP);
            panel1.Controls.Add(button_Back);
            panel1.Controls.Add(button_BBookDelete);
            panel1.Controls.Add(button_CBook);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 79);
            panel1.TabIndex = 0;
            // 
            // button_BBooksList
            // 
            button_BBooksList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_BBooksList.BackColor = Color.LightGoldenrodYellow;
            button_BBooksList.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_BBooksList.ForeColor = Color.Navy;
            button_BBooksList.Location = new Point(110, 3);
            button_BBooksList.Name = "button_BBooksList";
            button_BBooksList.Size = new Size(141, 62);
            button_BBooksList.TabIndex = 5;
            button_BBooksList.Text = "Randevuları Listele";
            button_BBooksList.UseVisualStyleBackColor = false;
            button_BBooksList.Click += button_BBooksList_Click;
            // 
            // button_BakMP
            // 
            button_BakMP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_BakMP.BackColor = Color.LightGoldenrodYellow;
            button_BakMP.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_BakMP.ForeColor = Color.Navy;
            button_BakMP.Location = new Point(757, 3);
            button_BakMP.Name = "button_BakMP";
            button_BakMP.Size = new Size(141, 62);
            button_BakMP.TabIndex = 5;
            button_BakMP.Text = "Ana Sayfa";
            button_BakMP.UseVisualStyleBackColor = false;
            button_BakMP.Click += button_BakMP_Click;
            // 
            // button_Back
            // 
            button_Back.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_Back.BackColor = Color.LightGoldenrodYellow;
            button_Back.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_Back.ForeColor = Color.Navy;
            button_Back.Location = new Point(600, 3);
            button_Back.Name = "button_Back";
            button_Back.Size = new Size(141, 62);
            button_Back.TabIndex = 5;
            button_Back.Text = "Geri Dön";
            button_Back.UseVisualStyleBackColor = false;
            button_Back.Click += button_Back_Click;
            // 
            // button_BBookDelete
            // 
            button_BBookDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_BBookDelete.BackColor = Color.LightGoldenrodYellow;
            button_BBookDelete.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_BBookDelete.ForeColor = Color.Navy;
            button_BBookDelete.Location = new Point(440, 3);
            button_BBookDelete.Name = "button_BBookDelete";
            button_BBookDelete.Size = new Size(141, 62);
            button_BBookDelete.TabIndex = 5;
            button_BBookDelete.Text = "Randevu İptal";
            button_BBookDelete.UseVisualStyleBackColor = false;
            button_BBookDelete.Click += button_BBookDelete_Click;
            // 
            // button_CBook
            // 
            button_CBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button_CBook.BackColor = Color.LightGoldenrodYellow;
            button_CBook.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_CBook.ForeColor = Color.Navy;
            button_CBook.Location = new Point(273, 3);
            button_CBook.Name = "button_CBook";
            button_CBook.Size = new Size(141, 62);
            button_CBook.TabIndex = 5;
            button_CBook.Text = "Randevu Oluştur";
            button_CBook.UseVisualStyleBackColor = false;
            button_CBook.Click += button_CBook_Click;
            // 
            // monthCalendar_BookDate
            // 
            monthCalendar_BookDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            monthCalendar_BookDate.Cursor = Cursors.Hand;
            monthCalendar_BookDate.Location = new Point(319, 159);
            monthCalendar_BookDate.Name = "monthCalendar_BookDate";
            monthCalendar_BookDate.TabIndex = 1;
            monthCalendar_BookDate.Visible = false;
            // 
            // comboBox_BClient
            // 
            comboBox_BClient.Cursor = Cursors.Hand;
            comboBox_BClient.ForeColor = Color.Navy;
            comboBox_BClient.FormattingEnabled = true;
            comboBox_BClient.Location = new Point(12, 159);
            comboBox_BClient.Name = "comboBox_BClient";
            comboBox_BClient.Size = new Size(216, 28);
            comboBox_BClient.TabIndex = 2;
            comboBox_BClient.Visible = false;
            // 
            // comboBox_BPersonel
            // 
            comboBox_BPersonel.Cursor = Cursors.Hand;
            comboBox_BPersonel.ForeColor = Color.Navy;
            comboBox_BPersonel.FormattingEnabled = true;
            comboBox_BPersonel.Location = new Point(24, 159);
            comboBox_BPersonel.Name = "comboBox_BPersonel";
            comboBox_BPersonel.Size = new Size(216, 28);
            comboBox_BPersonel.TabIndex = 3;
            comboBox_BPersonel.Visible = false;
            // 
            // label_BDate
            // 
            label_BDate.AutoSize = true;
            label_BDate.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_BDate.ForeColor = Color.Navy;
            label_BDate.Location = new Point(319, 117);
            label_BDate.Name = "label_BDate";
            label_BDate.Size = new Size(195, 39);
            label_BDate.TabIndex = 5;
            label_BDate.Text = "Tarih Seçiniz";
            label_BDate.Visible = false;
            // 
            // label_BClient
            // 
            label_BClient.AutoSize = true;
            label_BClient.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_BClient.ForeColor = Color.Navy;
            label_BClient.Location = new Point(12, 117);
            label_BClient.Name = "label_BClient";
            label_BClient.Size = new Size(228, 39);
            label_BClient.TabIndex = 5;
            label_BClient.Text = "Müşteri Seçiniz";
            label_BClient.Visible = false;
            // 
            // label_BPersonel
            // 
            label_BPersonel.AutoSize = true;
            label_BPersonel.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_BPersonel.ForeColor = Color.Navy;
            label_BPersonel.Location = new Point(20, 117);
            label_BPersonel.Name = "label_BPersonel";
            label_BPersonel.Size = new Size(220, 39);
            label_BPersonel.TabIndex = 5;
            label_BPersonel.Text = "Çalışan Seçiniz";
            label_BPersonel.Visible = false;
            // 
            // label_BServices
            // 
            label_BServices.AutoSize = true;
            label_BServices.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_BServices.ForeColor = Color.Navy;
            label_BServices.Location = new Point(24, 201);
            label_BServices.Name = "label_BServices";
            label_BServices.Size = new Size(197, 39);
            label_BServices.TabIndex = 5;
            label_BServices.Text = "İşlem Seçiniz";
            label_BServices.Visible = false;
            // 
            // listBox_BFee
            // 
            listBox_BFee.BackColor = Color.LightYellow;
            listBox_BFee.ForeColor = Color.Navy;
            listBox_BFee.FormattingEnabled = true;
            listBox_BFee.Location = new Point(636, 159);
            listBox_BFee.Name = "listBox_BFee";
            listBox_BFee.Size = new Size(239, 204);
            listBox_BFee.TabIndex = 6;
            listBox_BFee.Visible = false;
            // 
            // button_BFinishChoise
            // 
            button_BFinishChoise.BackColor = Color.Navy;
            button_BFinishChoise.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_BFinishChoise.ForeColor = Color.LightGoldenrodYellow;
            button_BFinishChoise.Location = new Point(12, 201);
            button_BFinishChoise.Name = "button_BFinishChoise";
            button_BFinishChoise.Size = new Size(216, 51);
            button_BFinishChoise.TabIndex = 8;
            button_BFinishChoise.Text = "Seçimi Tamamla";
            button_BFinishChoise.UseVisualStyleBackColor = false;
            button_BFinishChoise.Visible = false;
            button_BFinishChoise.Click += button_BFinishChoise_Click;
            // 
            // checkedListBox_BServices
            // 
            checkedListBox_BServices.Font = new Font("Sylfaen", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkedListBox_BServices.FormattingEnabled = true;
            checkedListBox_BServices.Location = new Point(20, 262);
            checkedListBox_BServices.Name = "checkedListBox_BServices";
            checkedListBox_BServices.Size = new Size(296, 104);
            checkedListBox_BServices.TabIndex = 10;
            checkedListBox_BServices.Visible = false;
            // 
            // label_BClientWarning
            // 
            label_BClientWarning.AutoSize = true;
            label_BClientWarning.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_BClientWarning.ForeColor = Color.Navy;
            label_BClientWarning.Location = new Point(12, 88);
            label_BClientWarning.Name = "label_BClientWarning";
            label_BClientWarning.Size = new Size(356, 29);
            label_BClientWarning.TabIndex = 11;
            label_BClientWarning.Text = "Lütfen Önce Bir Müşteri Seçiniz";
            label_BClientWarning.Visible = false;
            // 
            // label_BListFee
            // 
            label_BListFee.AutoSize = true;
            label_BListFee.Font = new Font("Sylfaen", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_BListFee.ForeColor = Color.Navy;
            label_BListFee.Location = new Point(636, 117);
            label_BListFee.Name = "label_BListFee";
            label_BListFee.Size = new Size(235, 39);
            label_BListFee.TabIndex = 5;
            label_BListFee.Text = "Seçilen İşlemler";
            label_BListFee.Visible = false;
            // 
            // button_BAddList
            // 
            button_BAddList.BackColor = Color.Navy;
            button_BAddList.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_BAddList.ForeColor = Color.LightGoldenrodYellow;
            button_BAddList.Location = new Point(20, 378);
            button_BAddList.Name = "button_BAddList";
            button_BAddList.Size = new Size(216, 52);
            button_BAddList.TabIndex = 7;
            button_BAddList.Text = "Sepete Ekle";
            button_BAddList.UseVisualStyleBackColor = false;
            button_BAddList.Visible = false;
            button_BAddList.Click += button_BAddList_Click;
            // 
            // button_BFinishBook
            // 
            button_BFinishBook.BackColor = Color.Navy;
            button_BFinishBook.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_BFinishBook.ForeColor = Color.LightGoldenrodYellow;
            button_BFinishBook.Location = new Point(636, 369);
            button_BFinishBook.Name = "button_BFinishBook";
            button_BFinishBook.Size = new Size(239, 39);
            button_BFinishBook.TabIndex = 7;
            button_BFinishBook.Text = "Randevu Oluştur";
            button_BFinishBook.UseVisualStyleBackColor = false;
            button_BFinishBook.Visible = false;
            button_BFinishBook.Click += button_BFinishBook_Click;
            // 
            // button_BDeleteItems
            // 
            button_BDeleteItems.BackColor = Color.Navy;
            button_BDeleteItems.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_BDeleteItems.ForeColor = Color.LightGoldenrodYellow;
            button_BDeleteItems.Location = new Point(636, 414);
            button_BDeleteItems.Name = "button_BDeleteItems";
            button_BDeleteItems.Size = new Size(239, 39);
            button_BDeleteItems.TabIndex = 7;
            button_BDeleteItems.Text = "Sepeti Temizle";
            button_BDeleteItems.UseVisualStyleBackColor = false;
            button_BDeleteItems.Visible = false;
            button_BDeleteItems.Click += button_BDeleteItems_Click;
            // 
            // label_BBookWarning
            // 
            label_BBookWarning.AutoSize = true;
            label_BBookWarning.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_BBookWarning.ForeColor = Color.Navy;
            label_BBookWarning.Location = new Point(137, 88);
            label_BBookWarning.Name = "label_BBookWarning";
            label_BBookWarning.Size = new Size(639, 29);
            label_BBookWarning.TabIndex = 11;
            label_BBookWarning.Text = "Lütfen Bütün Gerekli İşlemleri Seçtiğinizden Emin Olunuz";
            label_BBookWarning.Visible = false;
            // 
            // label_BBookSuccess
            // 
            label_BBookSuccess.AutoSize = true;
            label_BBookSuccess.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label_BBookSuccess.ForeColor = Color.Navy;
            label_BBookSuccess.Location = new Point(255, 88);
            label_BBookSuccess.Name = "label_BBookSuccess";
            label_BBookSuccess.Size = new Size(397, 29);
            label_BBookSuccess.TabIndex = 11;
            label_BBookSuccess.Text = "Randevu Başarıyla Oluşturulmuştur";
            label_BBookSuccess.Visible = false;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(910, 476);
            Controls.Add(label_BBookSuccess);
            Controls.Add(label_BBookWarning);
            Controls.Add(label_BClientWarning);
            Controls.Add(checkedListBox_BServices);
            Controls.Add(button_BAddList);
            Controls.Add(button_BDeleteItems);
            Controls.Add(button_BFinishBook);
            Controls.Add(label_BServices);
            Controls.Add(label_BPersonel);
            Controls.Add(label_BClient);
            Controls.Add(label_BListFee);
            Controls.Add(label_BDate);
            Controls.Add(comboBox_BPersonel);
            Controls.Add(comboBox_BClient);
            Controls.Add(monthCalendar_BookDate);
            Controls.Add(panel1);
            Controls.Add(listBox_BFee);
            Controls.Add(button_BFinishChoise);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Books";
            Load += Books_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button_BBooksList;
        private Button button_BakMP;
        private Button button_Back;
        private Button button_BBookDelete;
        private Button button_CBook;
        private MonthCalendar monthCalendar_BookDate;
        private ComboBox comboBox_BClient;
        private ComboBox comboBox_BPersonel;
        private Label label_BDate;
        private Label label_BClient;
        private Label label_BPersonel;
        private Label label_BServices;
        private ListBox listBox_BFee;
        private Button button_BFinishChoise;
        private CheckedListBox checkedListBox_BServices;
        private Label label_BClientWarning;
        private Label label_BListFee;
        private Button button_BAddList;
        private Button button_BFinishBook;
        private Button button_BDeleteItems;
        private Label label_BBookWarning;
        private Label label_BBookSuccess;
    }
}