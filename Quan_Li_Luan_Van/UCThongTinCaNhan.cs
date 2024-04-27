using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Luan_Van
{
    public partial class UCThongTinCaNhan : UserControl
    {
        PersonDAO thongTinCaNhan = new PersonDAO();
        public UCThongTinCaNhan()
        {
            InitializeComponent();
        }

        public void KhongTruyCap(Person person)
        {
            BtnOK.Hide();
            TxtID.Text = person.getMaso();
            TxtHoTen.Text = person.getHoTen();
            if (person.getGioiTinh() == "Nam")
                RbNam.Checked = true;
            else RbNu.Checked = true;
            TxtDiaChi.Text = person.getDiaChi();
            TxtCCCD.Text = person.getCCCD();
            string day1 = Convert.ToString(person.getNTNS());
            DateTime selectedDate;
            if (DateTime.TryParse(day1, out selectedDate))
            {
                DtBirth.Value = selectedDate;
            }
            TxtPhone.Text = person.getSDT();
            TxtEmail.Text = person.getEmail();
            TxtCCCD.Enabled = false;
            TxtDiaChi.Enabled = false;
            TxtEmail.Enabled = false;
            TxtHoTen.Enabled = false;
            TxtPhone.Enabled = false;
            RbNam.Enabled = false;
            RbNu.Enabled = false;
            DtBirth.Enabled = false;
        }
        public void TruyCap(Person person)
        {
            TxtCCCD.Enabled = true;
            TxtDiaChi.Enabled = true;
            TxtEmail.Enabled = true;
            TxtHoTen.Enabled = true;
            TxtPhone.Enabled = true;
            RbNam.Enabled = true;
            RbNu.Enabled = true;
            DtBirth.Enabled = true;
            BtnChinhSua.Hide();
            BtnOK.Show();
        }
        public Person capNhat(Person person)
        {
            string sex = "";
            if (RbNam.Checked) sex = "Nam";
            else sex = "Nu";
            person = new Person(TxtID.Text,TxtHoTen.Text, sex, TxtDiaChi.Text, TxtCCCD.Text, DtBirth.Value.ToShortDateString(),
                TxtPhone.Text, TxtEmail.Text);
            thongTinCaNhan.CapNhatThongTin(person);
            BtnChinhSua.Show();
            KhongTruyCap(person);
            return person;
        }
        public KryptonButton BtnChinhSua { get => btnChinhSua; set => btnChinhSua = value; }
        public PictureBox PicBoxUser { get => picBoxUser; set => picBoxUser = value; }
        public KryptonDateTimePicker DtBirth { get => dtBirth; set => dtBirth = value; }
        public RadioButton RbNu { get => rbNu; set => rbNu = value; }
        public RadioButton RbNam { get => rbNam; set => rbNam = value; }
        public KryptonTextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public KryptonTextBox TxtPhone { get => txtPhone; set => txtPhone = value; }
        public KryptonTextBox TxtCCCD { get => txtCCCD; set => txtCCCD = value; }
        public KryptonTextBox TxtDiaChi { get => txtDiaChi; set => txtDiaChi = value; }
        public KryptonTextBox TxtHoTen { get => txtHoTen; set => txtHoTen = value; }
        public KryptonTextBox TxtID { get => txtID; set => txtID = value; }
        public KryptonPalette KryptonPalette1 { get => kryptonPalette1; set => kryptonPalette1 = value; }
        public Label LbPhone { get => lbPhone; set => lbPhone = value; }
        public Label LbEmail { get => lbEmail; set => lbEmail = value; }
        public Label LbCCCD { get => lbCCCD; set => lbCCCD = value; }
        public Label LbBirth { get => lbBirth; set => lbBirth = value; }
        public Label LbAddress { get => lbAddress; set => lbAddress = value; }
        public Label LbSex { get => lbSex; set => lbSex = value; }
        public Label LbName { get => lbName; set => lbName = value; }
        public Label LbID { get => lbID; set => lbID = value; }
        public KryptonButton BtnOK { get => btnOK; set => btnOK = value; }
    }
}
