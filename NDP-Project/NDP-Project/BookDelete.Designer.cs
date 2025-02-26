namespace NDP_Project
{
    partial class BookDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookDelete));
            listBox_Appointments = new ListBox();
            button_Back = new Button();
            button_Delete = new Button();
            logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // listBox_Appointments
            // 
            listBox_Appointments.BackColor = Color.LightGoldenrodYellow;
            listBox_Appointments.FormattingEnabled = true;
            listBox_Appointments.Location = new Point(36, 12);
            listBox_Appointments.Name = "listBox_Appointments";
            listBox_Appointments.Size = new Size(651, 444);
            listBox_Appointments.TabIndex = 0;
            // 
            // button_Back
            // 
            button_Back.BackColor = Color.LightGoldenrodYellow;
            button_Back.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_Back.ForeColor = Color.Navy;
            button_Back.Location = new Point(730, 397);
            button_Back.Name = "button_Back";
            button_Back.Size = new Size(156, 59);
            button_Back.TabIndex = 1;
            button_Back.Text = "Geri Dön";
            button_Back.UseVisualStyleBackColor = false;
            button_Back.Click += button_Back_Click;
            // 
            // button_Delete
            // 
            button_Delete.BackColor = Color.LightGoldenrodYellow;
            button_Delete.Font = new Font("Sylfaen", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button_Delete.ForeColor = Color.Navy;
            button_Delete.Location = new Point(730, 308);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(156, 59);
            button_Delete.TabIndex = 1;
            button_Delete.Text = "Randevu Sil";
            button_Delete.UseVisualStyleBackColor = false;
            button_Delete.Click += button_Delete_Click;
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(730, 12);
            logo.Name = "logo";
            logo.Size = new Size(156, 161);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 3;
            logo.TabStop = false;
            // 
            // BookDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(910, 476);
            Controls.Add(logo);
            Controls.Add(button_Delete);
            Controls.Add(button_Back);
            Controls.Add(listBox_Appointments);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookDelete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookDelete";
            Load += BookDelete_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox_Appointments;
        private Button button_Back;
        private Button button_Delete;
        private PictureBox logo;
    }
}