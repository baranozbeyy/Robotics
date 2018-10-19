using Robotics.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robotics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void planeSize_TxtBox_Leave(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;
            if (text == "")
                return;

            if (text.Length != 3)
                Error(planeSize_TxtBox, Statics.planeSizeErrorMes);
            else
            {
                foreach (var ch in text)
                {
                    int index = text.IndexOf(ch);
                    if (index == 0 || index == 2)
                    {
                        if (!Statics.numbers.Contains(ch))
                        {
                            Error(planeSize_TxtBox, Statics.planeSizeErrorMes);
                            return;
                        }
                    }
                    else
                    {
                        if (ch != ',')
                        {
                            Error(planeSize_TxtBox, Statics.planeSizeErrorMes);
                            return;
                        }
                    }
                }
            }
        }

        private void robot1Location_TxtBox_Leave(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;
            if (text == "")
                return;

            if (text.Length != 5)
                Error(robot1Location_TxtBox, Statics.robotLocationErrorMes);
            else
            {
                foreach (var ch in text)
                {
                    int index = text.IndexOf(ch);

                    if (index == 0 || index == 2)
                    {
                        if (!Statics.numbers.Contains(ch))
                        {
                            Error(robot1Location_TxtBox, Statics.robotLocationErrorMes);
                            return;
                        }
                    }
                    else if (index == 1)
                    {
                        if (ch != ',')
                        {
                            Error(robot1Location_TxtBox, Statics.robotLocationErrorMes);
                            return;
                        }
                    }
                    else if (index == 3)
                    {
                        if (ch != ' ')
                        {
                            Error(robot1Location_TxtBox, Statics.robotLocationErrorMes);
                            return;
                        }
                    }
                    else
                    {
                        if (!Statics.directions.Contains(ch))
                        {
                            Error(robot1Location_TxtBox, Statics.robotLocationErrorMes);
                            return;
                        }
                    }
                }
            }
        }

        private void robot1Command_TxtBox_Leave(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;

            bool notMatched = text.ToString().Any(b => !Statics.commands.Contains(b));
            if (notMatched)
                Error(robot1Command_TxtBox, Statics.commandErrorMes);
        }

        private void robot2Location_TxtBox_Leave(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;
            if (text == "")
                return;

            if (text.Length != 5)
                Error(robot2Location_TxtBox, Statics.robotLocationErrorMes);
            else
            {
                foreach (var ch in text)
                {
                    int index = text.IndexOf(ch);

                    if (index == 0 || index == 2)
                    {
                        if (!Statics.numbers.Contains(ch))
                        {
                            Error(robot2Location_TxtBox, Statics.robotLocationErrorMes);
                            return;
                        }
                    }
                    else if (index == 1)
                    {
                        if (ch != ',')
                        {
                            Error(robot2Location_TxtBox, Statics.robotLocationErrorMes);
                            return;
                        }
                    }
                    else if (index == 3)
                    {
                        if (ch != ' ')
                        {
                            Error(robot2Location_TxtBox, Statics.robotLocationErrorMes);
                            return;
                        }
                    }
                    else
                    {
                        if (!Statics.directions.Contains(ch))
                        {
                            Error(robot2Location_TxtBox, Statics.robotLocationErrorMes);
                            return;
                        }
                    }
                }
            }
        }

        private void robot2Command_TxtBox_Leave(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;

            bool notMatched = text.ToString().Any(b => !Statics.commands.Contains(b));
            if (notMatched)
                Error(robot2Command_TxtBox, Statics.commandErrorMes);
        }

        private void Error(TextBox txtBox, string errorMessage)
        {
            MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            txtBox.Text = "";
            txtBox.Focus();
        }

        private void routing_btn_Click(object sender, EventArgs e)
        {
            if (planeSize_TxtBox.Text == "" || robot1Location_TxtBox.Text == "" || robot1Command_TxtBox.Text == "")
            {
                MessageBox.Show("Tüm Alanları Doldurunuz");
                return;
            }
            Robotic robotic1 = new Robotic(Statics.lowerLeftCorner, planeSize_TxtBox.Text, robot1Location_TxtBox.Text, robot1Command_TxtBox.Text);
            Robotic robotic2 = new Robotic(Statics.lowerLeftCorner, planeSize_TxtBox.Text, robot2Location_TxtBox.Text, robot2Command_TxtBox.Text);
            MessageBox.Show("Robot1 Konumu  " + robotic1.currentLocation + "\n" + "Robot2 Konumu  " + robotic2.currentLocation);
        }
    }
}
