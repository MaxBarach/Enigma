using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnigmaApp
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void QButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "Q";
        }

        protected void WButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "W";
        }

        protected void EButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "E";
        }

        protected void RButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "R";
        }

        protected void TButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "T";
        }

        protected void YButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "Y";
        }

        protected void UButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "U";
        }

        protected void IButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "I";
        }

        protected void OButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "O";
        }

        protected void PButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "P";
        }

        protected void AButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "A";
        }

        protected void SButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "S";
        }

        protected void DButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "D";
        }

        protected void FButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "F";
        }

        protected void GButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "G";
        }

        protected void HButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "H";
        }

        protected void JButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "J";
        }

        protected void KButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "K";
        }

        protected void LButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "L";
        }

        protected void ZButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "Z";
        }

        protected void XButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "X";
        }

        protected void CButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "C";
        }

        protected void VButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "V";
        }

        protected void BButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "B";
        }

        protected void NButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "N";
        }

        protected void MButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += "M";
        }

        protected void SpaceButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text += " ";
        }

        protected void ResetButton_Click(object sender, EventArgs e)
        {
            OutputTxt.Text = "";
        }

        protected void RotorNumList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected char UseRotors ()
        {
            Rotor staticWheel = new Rotor();
            Rotor Wheel3 = new Rotor();
            Rotor Wheel2 = new Rotor();
            Rotor Wheel1 = new Rotor();
            Rotor Reflector = new Rotor();

        }
    }
}