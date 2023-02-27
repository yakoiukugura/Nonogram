using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nonogram
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		string[] top_string = new string[10];
		string[] bottom_string = new string[10];
		string[] map_string = new string[100];

		Label[] top = new Label[10];
		Label[] bottom = new Label[10];
		Label[] map = new Label[100];

		private void label1_Click(object sender, EventArgs e)
		{
			Label label = sender as Label;
			MouseEventArgs me = e as MouseEventArgs;
			if (me.Button == MouseButtons.Left)
			{
				label.Text = "";
				if (label.BackColor == Color.Black)
					label.BackColor = Color.White;
				else
					label.BackColor = Color.Black;
			}
			else
			{
				label.BackColor = Color.White;
				if (label.Text == "X")
					label.Text = "";
				else
					label.Text = "X";
			}
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			top_string[0] = "1";
			top_string[1] = "1 3 3";
			top_string[2] = "2 7";
			top_string[3] = "2 3";
			top_string[4] = "2 7";
			top_string[5] = "1 8";
			top_string[6] = "5 4";
			top_string[7] = "3";
			top_string[8] = "1";
			top_string[9] = "2";

			bottom_string[0] = "6";
			bottom_string[1] = "3 1";
			bottom_string[2] = "1 2";
			bottom_string[3] = "2 3";
			bottom_string[4] = "6";
			bottom_string[5] = "4";
			bottom_string[6] = "5";
			bottom_string[7] = "2 4";
			bottom_string[8] = "2 4 1";
			bottom_string[9] = "3 6";

			map_string[0] = "";
			map_string[1] = "";
			map_string[2] = "";
			map_string[3] = "";
			map_string[4] = "";
			map_string[5] = "";
			map_string[6] = "";
			map_string[7] = "";
			map_string[8] = "X";
			map_string[9] = "X";

			map_string[10] = "X";
			map_string[11] = "";
			map_string[12] = "";
			map_string[13] = "";
			map_string[14] = "";
			map_string[15] = "X";
			map_string[16] = "";
			map_string[17] = "X";
			map_string[18] = "";
			map_string[19] = "";

			map_string[20] = "X";
			map_string[21] = "";
			map_string[22] = "X";
			map_string[23] = "X";
			map_string[24] = "";
			map_string[25] = "";
			map_string[26] = "";
			map_string[27] = "X";
			map_string[28] = "X";
			map_string[29] = "";

			map_string[30] = "";
			map_string[31] = "";
			map_string[32] = "";
			map_string[33] = "X";
			map_string[34] = "";
			map_string[35] = "";
			map_string[36] = "";
			map_string[37] = "";
			map_string[38] = "X";
			map_string[39] = "X";

			map_string[40] = "";
			map_string[41] = "";
			map_string[42] = "";
			map_string[43] = "";
			map_string[44] = "";
			map_string[45] = "";
			map_string[46] = "";
			map_string[47] = "X";
			map_string[48] = "X";
			map_string[49] = "X";

			map_string[50] = "X";
			map_string[51] = "X";
			map_string[52] = "";
			map_string[53] = "";
			map_string[54] = "";
			map_string[55] = "";
			map_string[56] = "";
			map_string[57] = "";
			map_string[58] = "X";
			map_string[59] = "";

			map_string[60] = "X";
			map_string[61] = "";
			map_string[62] = "";
			map_string[63] = "";
			map_string[64] = "";
			map_string[65] = "";
			map_string[66] = "";
			map_string[67] = "";
			map_string[68] = "X";
			map_string[69] = "";

			map_string[70] = "";
			map_string[71] = "";
			map_string[72] = "";
			map_string[73] = "";
			map_string[74] = "";
			map_string[75] = "";
			map_string[76] = "";
			map_string[77] = "";
			map_string[78] = "";
			map_string[79] = "";

			map_string[80] = "X";
			map_string[81] = "";
			map_string[82] = "";
			map_string[83] = "";
			map_string[84] = "";
			map_string[85] = "";
			map_string[86] = "";
			map_string[87] = "";
			map_string[88] = "X";
			map_string[89] = "";

			map_string[90] = "";
			map_string[91] = "";
			map_string[92] = "";
			map_string[93] = "";
			map_string[94] = "";
			map_string[95] = "";
			map_string[96] = "";
			map_string[97] = "";
			map_string[98] = "";
			map_string[99] = "";

			top[0] = label101;
			top[1] = label102;
			top[2] = label103;
			top[3] = label104;
			top[4] = label105;
			top[5] = label106;
			top[6] = label107;
			top[7] = label108;
			top[8] = label109;
			top[9] = label110;

			bottom[0] = label111;
			bottom[1] = label112;
			bottom[2] = label113;
			bottom[3] = label114;
			bottom[4] = label115;
			bottom[5] = label116;
			bottom[6] = label117;
			bottom[7] = label118;
			bottom[8] = label119;
			bottom[9] = label120;

			map[0] = label1;
			map[1] = label2;
			map[2] = label3;
			map[3] = label4;
			map[4] = label5;
			map[5] = label6;
			map[6] = label7;
			map[7] = label8;
			map[8] = label9;
			map[9] = label10;
			map[10] = label11;
			map[11] = label12;
			map[12] = label13;
			map[13] = label14;
			map[14] = label15;
			map[15] = label16;
			map[16] = label17;
			map[17] = label18;
			map[18] = label19;
			map[19] = label20;
			map[20] = label21;
			map[21] = label22;
			map[22] = label23;
			map[23] = label24;
			map[24] = label25;
			map[25] = label26;
			map[26] = label27;
			map[27] = label28;
			map[28] = label29;
			map[29] = label30;
			map[30] = label31;
			map[31] = label32;
			map[32] = label33;
			map[33] = label34;
			map[34] = label35;
			map[35] = label36;
			map[36] = label37;
			map[37] = label38;
			map[38] = label39;
			map[39] = label40;
			map[40] = label41;
			map[41] = label42;
			map[42] = label43;
			map[43] = label44;
			map[44] = label45;
			map[45] = label46;
			map[46] = label47;
			map[47] = label48;
			map[48] = label49;
			map[49] = label50;
			map[50] = label51;
			map[51] = label52;
			map[52] = label53;
			map[53] = label54;
			map[54] = label55;
			map[55] = label56;
			map[56] = label57;
			map[57] = label58;
			map[58] = label59;
			map[59] = label60;
			map[60] = label61;
			map[61] = label62;
			map[62] = label63;
			map[63] = label64;
			map[64] = label65;
			map[65] = label66;
			map[66] = label67;
			map[67] = label68;
			map[68] = label69;
			map[69] = label70;
			map[70] = label71;
			map[71] = label72;
			map[72] = label73;
			map[73] = label74;
			map[74] = label75;
			map[75] = label76;
			map[76] = label77;
			map[77] = label78;
			map[78] = label79;
			map[79] = label80;
			map[80] = label81;
			map[81] = label82;
			map[82] = label83;
			map[83] = label84;
			map[84] = label85;
			map[85] = label86;
			map[86] = label87;
			map[87] = label88;
			map[88] = label89;
			map[89] = label90;
			map[90] = label91;
			map[91] = label92;
			map[92] = label93;
			map[93] = label94;
			map[94] = label95;
			map[95] = label96;
			map[96] = label97;
			map[97] = label98;
			map[98] = label99;
			map[99] = label100;

			for (int i = 0; i < 10; i++)
			{
				top[i].Text = top_string[i];
				bottom[i].Text = bottom_string[i];
			}
			for (int i = 0; i < 100; i++)
            {
				if (map_string[i] == "X")
					map[i].Text = "X";
            }
		}

        private void timer1_Tick(object sender, EventArgs e)
        {
			bool end = true;
			for (int i = 0; i < 100 && end; i++)
				if (map[i].Text == "" && map[i].BackColor == Color.White)
					end = false;
			if (end)
            {
				timer1.Enabled = false;
				for (int i = 0; i < 100; i++)
                {
					if (map[i].Text == "X")
					{
						map[i].Text = "";
						map[i].BackColor = Color.Blue;
					}
					else
						map[i].BackColor = Color.Gold;
                }
				MessageBox.Show("You Win!");
				this.Close();
            }
        }
    }
}
