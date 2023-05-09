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

		string[] top_string;
		string[] bottom_string;
		string[,] map_string;

		Label[] top;
		Label[] bottom;
		Label[,] map;

		private void start_button_Click(object sender, EventArgs e)
		{
			menu.Enabled = false;
			menu.Visible = false;

			title.Enabled = false;
			title.Visible = false;

			start_button.Enabled = false;
			start_button.Visible = false;

			quit_button.Enabled = false;
			quit_button.Visible = false;

			top_string = new string[] { "1", "1 3 3", "2 7", "2 3", "2 7", "1 8", "5 4", "3", "1", "2" };
			bottom_string = new string[] { "6", "3 1", "1 2", "2 3", "6", "4", "5", "2 4", "2 4 1", "3 6" };
			map_string = new string[,]{
				{ "", "", "", "", "", "", "", "", "X", "X" },
				{ "X", "", "", "", "", "X", "", "X", "", "" },
				{ "X", "", "X", "X", "", "", "", "X", "X", "" },
				{ "", "", "", "X", "", "", "", "", "X", "X" },
				{ "", "", "", "", "", "", "", "X", "X", "X" },
				{ "X", "X", "", "", "", "", "", "", "X", "" },
				{ "X", "", "", "", "", "", "", "", "X", "" },
				{ "", "", "", "", "", "", "", "", "", "" },
				{ "X", "", "", "", "", "", "", "", "X", "" },
				{ "", "", "", "", "", "", "", "", "", "" }
			};
			top = new Label[] { label101, label102, label103, label104, label105, label106, label107, label108, label109, label110 };

			bottom = new Label[] { label111, label112, label113, label114, label115, label116, label117, label118, label119, label120 };

			map = new Label[,]{
				{ label1, label2, label3, label4, label5, label6, label7, label8, label9, label10 },
				{ label11, label12, label13, label14, label15, label16, label17, label18, label19, label20 },
				{ label21, label22, label23, label24, label25, label26, label27, label28, label29, label30 },
				{ label31, label32, label33, label34, label35, label36, label37, label38, label39, label40 },
				{ label41, label42, label43, label44, label45, label46, label47, label48, label49, label50 },
				{ label51, label52, label53, label54, label55, label56, label57, label58, label59, label60 },
				{ label61, label62, label63, label64, label65, label66, label67, label68, label69, label70 },
				{ label71, label72, label73, label74, label75, label76, label77, label78, label79, label80 },
				{ label81, label82, label83, label84, label85, label86, label87, label88, label89, label90 },
				{ label91, label92, label93, label94, label95, label96, label97, label98, label99, label100 },
			};

			for (int i = 0; i < 10; i++)
			{
				top[i].Text = top_string[i];
				bottom[i].Text = bottom_string[i];
			}
			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					map[i, j].Text = map_string[i, j];
				}
			}
			timer1.Enabled = true;
		}

		private void quit_button_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to quit?", "Quit Game", MessageBoxButtons.YesNo) == DialogResult.Yes)
				this.Close();
		}

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

		private void timer1_Tick(object sender, EventArgs e)
		{
			bool end = true;
			for (int i = 0; i < 10; i++)
				for (int j = 0; j < 10; j++)
					if (map_string[i, j] == "" && map[i, j].BackColor == Color.White)
						end = false;
			if (end)
			{
				timer1.Enabled = false;
				for (int i = 0; i < 10; i++)
				{
					for (int j = 0; j < 10; j++)
					{
						if (map[i, j].Text == "X")
						{
							map[i, j].Text = "";
							map[i, j].BackColor = Color.Blue;
						}
						else
							map[i, j].BackColor = Color.Gold;
					}
				}
				wait(2000);
				gameOver();
			}
		}

		private void gameOver()
		{
			menu.Enabled = true;
			menu.Visible = true;

			title.Enabled = true;
			title.Visible = true;

			start_button.Enabled = true;
			start_button.Visible = true;

			quit_button.Enabled = true;
			quit_button.Visible = true;
		}

		public void wait(int milliseconds)
		{
			var timer1 = new System.Windows.Forms.Timer();
			if (milliseconds == 0 || milliseconds < 0) return;

			// Console.WriteLine("start wait timer");
			timer1.Interval = milliseconds;
			timer1.Enabled = true;
			timer1.Start();

			timer1.Tick += (s, e) =>
			{
				timer1.Enabled = false;
				timer1.Stop();
				// Console.WriteLine("stop wait timer");
			};

			while (timer1.Enabled)
			{
				Application.DoEvents();
			}
		}
	}
}