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
        int rotor1Index;
        int rotor2Index;
        int rotor3Index;
        int staticIndex;

        //create the static wheel, rotors, and reflector
        char[] staticWheel = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] rotor1 = { 'E', 'K', 'M', 'F', 'L', 'G', 'D', 'Q', 'V', 'Z', 'N', 'T', 'O', 'W', 'Y', 'H', 'X', 'U', 'S', 'P', 'A', 'I', 'B', 'R', 'C', 'J' };
        char[] rotor2 = { 'A', 'J', 'D', 'K', 'S', 'I', 'R', 'U', 'X', 'B', 'L', 'H', 'W', 'T', 'M', 'C', 'Q', 'G', 'Z', 'N', 'P', 'Y', 'F', 'V', 'O', 'E' };
        char[] rotor3 = { 'B', 'D', 'F', 'H', 'J', 'L', 'C', 'P', 'R', 'T', 'X', 'V', 'Z', 'N', 'Y', 'E', 'I', 'W', 'G', 'A', 'K', 'M', 'U', 'S', 'Q', 'O' };

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
            OutputTxt.Text += UseRotors('A');
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
            rotor1Index = 0;
            rotor2Index = 0;
            rotor3Index = 0;
            staticIndex = 0;
        }

        protected void RotorNumList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected char UseRotors(char input)
        {
            char output;
            for (int i = 0; i < 26; i++)
            {
                if (staticWheel[i] == input)
                {
                    staticIndex = i;
                }
            }
            output = rotor1[staticIndex + rotor1Index];

            for(int i = 0; i < 26; i++)
            {
                if(staticWheel[i] == output)
                {
                    staticIndex = i;
                }
            }
            output = rotor2[staticIndex + rotor2Index];
            
            for(int i = 0; i < 26; i++)
            {
                if(staticWheel[i] == output)
                {
                    staticIndex = i;
                }
            }
            output = rotor3[staticIndex + rotor3Index];

            //advance the rotors
            rotor1Index++;
            if(rotor1Index > 25)
            {
                rotor1Index = 0;
                rotor2Index++;
            }
            if(rotor2Index > 25)
            {
                rotor2Index = 0;
                rotor3Index++;
            }
            if(rotor3Index > 25)
            {
                rotor3Index = 0;
            }
            return output;
        }

    }
}