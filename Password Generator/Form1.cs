using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string PasswordGenerator(bool lowerCase, bool upperCase, bool mumberic, bool specialCharacter, int length)
        {
            char[] password = new char[length];
            string charSet = "";
            System.Random _random = new Random();
            if (lowerCase)
                charSet += LOWER_CASE;
            if (upperCase)
                charSet += UPPER_CASE;
            if (mumberic)
                charSet += NUMBERIC;
            if (specialCharacter)
                charSet += SPECIAL_CHARACTER;
            for (int i = 0; i < length; i++)
                password[i] = charSet[_random.Next(charSet.Length - 1)];
            return string.Join(null, password);
        }

        const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        const string UPPER_CASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string NUMBERIC = "1234567890";
        const string SPECIAL_CHARACTER = @"~!@#$%^&*()+=-";
        private bool mouseDown;
        private Point lastLocation;

        //c# text generator
        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                txtPassword.Text = PasswordGenerator(chkLowerCase.Checked, chkUpperCase.Checked, chkNumeric.Checked, chkSpecical.Checked, int.Parse(txtPasswordLength.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Mousedown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Mousemove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Mouseup(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Mdown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Mmove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Mup(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void txtPasswordLength_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPasswordLength.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPasswordLength.Text = txtPasswordLength.Text.Remove(txtPasswordLength.Text.Length - 1);
            }
        }
    }
}
