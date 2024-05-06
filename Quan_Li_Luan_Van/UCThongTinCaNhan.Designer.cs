namespace Quan_Li_Luan_Van
{
    partial class UCThongTinCaNhan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnChinhSua = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.picBoxUser = new System.Windows.Forms.PictureBox();
            this.dtBirth = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.txtEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPhone = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtCCCD = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtDiaChi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtHoTen = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbCCCD = new System.Windows.Forms.Label();
            this.lbBirth = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.btnOK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(795, 613);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(220, 51);
            this.btnChinhSua.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChinhSua.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnChinhSua.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChinhSua.StateCommon.Border.Rounding = 16;
            this.btnChinhSua.StateCommon.Border.Width = 1;
            this.btnChinhSua.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnChinhSua.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.TabIndex = 37;
            this.btnChinhSua.Values.Text = "Chỉnh sửa thông tin";
            // 
            // picBoxUser
            // 
            this.picBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxUser.Image = global::Quan_Li_Luan_Van.Properties.Resources.user_128;
            this.picBoxUser.Location = new System.Drawing.Point(57, 225);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(190, 176);
            this.picBoxUser.TabIndex = 36;
            this.picBoxUser.TabStop = false;
            // 
            // dtBirth
            // 
            this.dtBirth.Enabled = false;
            this.dtBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirth.Location = new System.Drawing.Point(750, 265);
            this.dtBirth.Name = "dtBirth";
            this.dtBirth.Size = new System.Drawing.Size(265, 40);
            this.dtBirth.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.dtBirth.StateCommon.Border.Color2 = System.Drawing.Color.Blue;
            this.dtBirth.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtBirth.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.dtBirth.StateCommon.Border.Rounding = 16;
            this.dtBirth.StateCommon.Border.Width = 1;
            this.dtBirth.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dtBirth.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.dtBirth.TabIndex = 35;
            this.dtBirth.ValueNullable = new System.DateTime(2024, 3, 10, 0, 0, 0, 0);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Enabled = false;
            this.rbNu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbNu.ForeColor = System.Drawing.Color.Black;
            this.rbNu.Location = new System.Drawing.Point(513, 348);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(56, 28);
            this.rbNu.TabIndex = 34;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Enabled = false;
            this.rbNam.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbNam.ForeColor = System.Drawing.Color.Black;
            this.rbNam.Location = new System.Drawing.Point(373, 348);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(72, 28);
            this.rbNam.TabIndex = 33;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(750, 425);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 37);
            this.txtEmail.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtEmail.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtEmail.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtEmail.StateCommon.Border.Rounding = 16;
            this.txtEmail.StateCommon.Border.Width = 1;
            this.txtEmail.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtEmail.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtEmail.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtEmail.TabIndex = 32;
            this.txtEmail.Text = "nva@gmail.com";
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(750, 348);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(265, 37);
            this.txtPhone.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtPhone.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtPhone.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtPhone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPhone.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtPhone.StateCommon.Border.Rounding = 16;
            this.txtPhone.StateCommon.Border.Width = 1;
            this.txtPhone.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtPhone.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtPhone.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPhone.TabIndex = 31;
            this.txtPhone.Text = "0542431245";
            // 
            // txtCCCD
            // 
            this.txtCCCD.Enabled = false;
            this.txtCCCD.Location = new System.Drawing.Point(750, 187);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(265, 37);
            this.txtCCCD.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtCCCD.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtCCCD.StateCommon.Border.Color2 = System.Drawing.Color.Blue;
            this.txtCCCD.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCCCD.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtCCCD.StateCommon.Border.Rounding = 16;
            this.txtCCCD.StateCommon.Border.Width = 1;
            this.txtCCCD.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCCCD.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtCCCD.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtCCCD.StateDisabled.Border.Color1 = System.Drawing.Color.Blue;
            this.txtCCCD.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCCCD.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCCCD.TabIndex = 30;
            this.txtCCCD.Text = "0432422134";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(367, 425);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(267, 37);
            this.txtDiaChi.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtDiaChi.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtDiaChi.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDiaChi.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDiaChi.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtDiaChi.StateCommon.Border.Rounding = 16;
            this.txtDiaChi.StateCommon.Border.Width = 1;
            this.txtDiaChi.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDiaChi.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtDiaChi.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtDiaChi.TabIndex = 29;
            this.txtDiaChi.Text = "Ho Chi Minh";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Enabled = false;
            this.txtHoTen.Location = new System.Drawing.Point(364, 265);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(267, 37);
            this.txtHoTen.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtHoTen.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtHoTen.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtHoTen.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtHoTen.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtHoTen.StateCommon.Border.Rounding = 16;
            this.txtHoTen.StateCommon.Border.Width = 1;
            this.txtHoTen.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtHoTen.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtHoTen.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtHoTen.StateDisabled.Border.Color1 = System.Drawing.Color.Blue;
            this.txtHoTen.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtHoTen.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtHoTen.StateDisabled.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtHoTen.StateDisabled.Border.Rounding = 16;
            this.txtHoTen.StateDisabled.Border.Width = 1;
            this.txtHoTen.TabIndex = 28;
            this.txtHoTen.Text = "Nguyen Van A";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(364, 187);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(267, 37);
            this.txtID.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtID.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtID.StateCommon.Border.Color1 = System.Drawing.Color.Blue;
            this.txtID.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtID.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtID.StateCommon.Border.Rounding = 16;
            this.txtID.StateCommon.Border.Width = 1;
            this.txtID.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtID.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtID.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtID.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtID.TabIndex = 27;
            this.txtID.Text = "123456";
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateCheckedTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateCheckedTracking.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateCheckedTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StateCheckedTracking.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonFormClose.StatePressed.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            // 
            // lbPhone
            // 
            this.lbPhone.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Image = global::Quan_Li_Luan_Van.Properties.Resources.phone2;
            this.lbPhone.Location = new System.Drawing.Point(669, 335);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(64, 60);
            this.lbPhone.TabIndex = 26;
            this.lbPhone.Text = "  ";
            // 
            // lbEmail
            // 
            this.lbEmail.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Image = global::Quan_Li_Luan_Van.Properties.Resources.email1;
            this.lbEmail.Location = new System.Drawing.Point(667, 413);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(66, 58);
            this.lbEmail.TabIndex = 25;
            this.lbEmail.Text = "  ";
            // 
            // lbCCCD
            // 
            this.lbCCCD.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCCCD.Image = global::Quan_Li_Luan_Van.Properties.Resources.id4;
            this.lbCCCD.Location = new System.Drawing.Point(665, 176);
            this.lbCCCD.Name = "lbCCCD";
            this.lbCCCD.Size = new System.Drawing.Size(68, 54);
            this.lbCCCD.TabIndex = 24;
            this.lbCCCD.Text = "  ";
            // 
            // lbBirth
            // 
            this.lbBirth.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirth.Image = global::Quan_Li_Luan_Van.Properties.Resources.birthday1;
            this.lbBirth.Location = new System.Drawing.Point(665, 265);
            this.lbBirth.Name = "lbBirth";
            this.lbBirth.Size = new System.Drawing.Size(68, 44);
            this.lbBirth.TabIndex = 23;
            this.lbBirth.Text = "  ";
            // 
            // lbAddress
            // 
            this.lbAddress.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Image = global::Quan_Li_Luan_Van.Properties.Resources.address2;
            this.lbAddress.Location = new System.Drawing.Point(286, 408);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(75, 75);
            this.lbAddress.TabIndex = 22;
            this.lbAddress.Text = "  ";
            // 
            // lbSex
            // 
            this.lbSex.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSex.Image = global::Quan_Li_Luan_Van.Properties.Resources.sex6;
            this.lbSex.Location = new System.Drawing.Point(297, 338);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(64, 46);
            this.lbSex.TabIndex = 21;
            this.lbSex.Text = "  ";
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Image = global::Quan_Li_Luan_Van.Properties.Resources.user_profile1;
            this.lbName.Location = new System.Drawing.Point(297, 257);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(61, 52);
            this.lbName.TabIndex = 20;
            this.lbName.Text = "  ";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbID
            // 
            this.lbID.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Image = global::Quan_Li_Luan_Van.Properties.Resources.StudentCode;
            this.lbID.Location = new System.Drawing.Point(293, 176);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(65, 60);
            this.lbID.TabIndex = 19;
            this.lbID.Text = "  ";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(795, 613);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(220, 51);
            this.btnOK.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOK.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnOK.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOK.StateCommon.Border.Rounding = 16;
            this.btnOK.StateCommon.Border.Width = 1;
            this.btnOK.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.btnOK.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.TabIndex = 80;
            this.btnOK.Values.Text = "OK";
            // 
            // UCThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.picBoxUser);
            this.Controls.Add(this.dtBirth);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCCCD);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbCCCD);
            this.Controls.Add(this.lbBirth);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbSex);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Name = "UCThongTinCaNhan";
            this.Size = new System.Drawing.Size(1082, 691);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnChinhSua;
        private System.Windows.Forms.PictureBox picBoxUser;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtBirth;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPhone;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCCCD;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDiaChi;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtHoTen;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtID;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbCCCD;
        private System.Windows.Forms.Label lbBirth;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnOK;
    }
}
