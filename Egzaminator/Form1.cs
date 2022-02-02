using System;
using System.Threading;
using System.Windows.Forms;

namespace Egzaminator
{
    public partial class Form1 : Form
    {
        Grid[,] arrayGrid = new Grid[7, 7];
        string read;
        Element thing;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            Random rnd = new Random();
            int version = rnd.Next(5);
            int value = 0;
            int chairs = 0;
            for (int i = 0; i <= 48; i++, Thread.Sleep(50))
            {
                Button buttonGrid = new Button();
                buttonGrid.Name = "buttonGrid" + i.ToString();
                buttonGrid.Size = new System.Drawing.Size(60, 60);
                buttonGrid.BackgroundImageLayout = ImageLayout.Stretch;
                buttonGrid.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                buttonGrid.ForeColor = System.Drawing.Color.White;
                buttonGrid.UseVisualStyleBackColor = true;
                if (Properties.Resources.gridValues1[value] == ' ')
                    value++;
                switch (version)
                {
                    case 0:
                        read = Properties.Resources.gridValues1[value++].ToString();
                        break;
                    case 1:
                        read = Properties.Resources.gridValues2[value++].ToString();
                        break;
                    case 2:
                        read = Properties.Resources.gridValues3[value++].ToString();
                        break;
                    case 3:
                        read = Properties.Resources.gridValues4[value++].ToString();
                        break;
                    default:
                        read = Properties.Resources.gridValues5[value++].ToString();
                        break;
                }
                if (read == "-")
                {
                    buttonGrid.Tag = true;
                    buttonGrid.Text = " ";
                    buttonGrid.BackgroundImage = Properties.Resources.chairs;
                    buttonGrid.Enabled = true;
                    buttonGrid.BackColor = System.Drawing.Color.Transparent;
                    chairs++;
                    thing = Element.chair;
                }
                else
                {
                    buttonGrid.Text = read;
                    buttonGrid.BackgroundImage = null;
                    buttonGrid.Enabled = false;
                    buttonGrid.BackColor = System.Drawing.Color.DimGray;
                    buttonGrid.Tag = false;
                    if (read == "x")
                        thing = Element.Phillarx;
                    else if (read == "0")
                        thing = Element.Phillar0;
                    else if (read == "1")
                        thing = Element.Phillar1;
                    else if (read == "2")
                        thing = Element.Phillar2;
                    else if (read == "3")
                        thing = Element.Phillar3;
                    else
                        thing = Element.chair;
                }
                buttonGrid.Click += buttonGrid_Click;
                flowLayoutPanelGrid.Controls.Add(buttonGrid);
                Grid tempGrid = new Grid(buttonGrid, thing);
                arrayGrid[i / 7, i % 7] = tempGrid;
                flowLayoutPanelGrid.Update();
            }
            progressBar.Maximum = chairs;
        }

        private void buttonGrid_Click(object sender, EventArgs e)
        {
            Button buttonGrid = (Button)sender;
            bool tag = (bool)buttonGrid.Tag;
            int gridNumber = int.Parse(buttonGrid.Name.Substring(10));
            int solution = 0;
            bool can = true;

            if (buttonGrid.BackColor == System.Drawing.Color.Khaki)
                can = false;

            if (gridNumber / 7 + 1 < 7 && arrayGrid[gridNumber / 7 + 1, gridNumber % 7].element != Element.chair && can)
            {
                //check DOWN
                if (arrayGrid[gridNumber / 7 + 1, gridNumber % 7].element != Element.chair || arrayGrid[gridNumber / 7 + 1, gridNumber % 7].element != Element.Phillarx)
                {
                    Check tempCheck = new Check();
                    solution = Check.Checking(arrayGrid, gridNumber / 7 + 1, gridNumber % 7);
                }
                _ = solution < 0 ? can = false : can = true;
            }

            if (gridNumber / 7 - 1 >= 0 && arrayGrid[gridNumber / 7 - 1, gridNumber % 7].element != Element.chair && can)
            {
                //check UP
                if (arrayGrid[gridNumber / 7 - 1, gridNumber % 7].element != Element.chair || arrayGrid[gridNumber / 7 + 1, gridNumber % 7].element != Element.Phillarx)
                {
                    Check tempCheck = new Check();
                    solution = Check.Checking(arrayGrid, gridNumber / 7 - 1, gridNumber % 7);
                }
                _ = solution < 0 ? can = false : can = true;
            }

            if (gridNumber % 7 + 1 < 7 && arrayGrid[gridNumber / 7, gridNumber % 7 + 1].element != Element.chair && can)
            {
                //check RIGHT
                if (arrayGrid[gridNumber / 7, gridNumber % 7 + 1].element != Element.chair || arrayGrid[gridNumber / 7 + 1, gridNumber % 7].element != Element.Phillarx)
                {
                    Check tempCheck = new Check();
                    solution = Check.Checking(arrayGrid, gridNumber / 7, gridNumber % 7 + 1);
                }
                _ = solution < 0 ? can = false : can = true;
            }

            if (gridNumber % 7 - 1 >= 0 && arrayGrid[gridNumber / 7, gridNumber % 7 - 1].element != Element.chair && can)
            {
                //check LEFT
                if (arrayGrid[gridNumber / 7, gridNumber % 7 - 1].element != Element.chair || arrayGrid[gridNumber / 7 + 1, gridNumber % 7].element != Element.Phillarx)
                {
                    Check tempCheck = new Check();
                    solution = Check.Checking(arrayGrid, gridNumber / 7, gridNumber % 7 - 1);
                }
                _ = solution < 0 ? can = false : can = true;
            }

            if (!can)
            {
                MessageBox.Show("Nie można tutaj ustawić obserwatora!");
                buttonGrid.Enabled = false;
            }
            else
            {
                if (tag)
                {
                    for (int i = 1; i < 7; i++)
                    {
                        if (gridNumber / 7 + i < 7 && arrayGrid[gridNumber / 7 + i, gridNumber % 7].element == Element.chair)
                        {
                            if (arrayGrid[gridNumber / 7 + i, gridNumber % 7].button.BackColor != System.Drawing.Color.Khaki)
                                progressBar.PerformStep();
                            arrayGrid[gridNumber / 7 + i, gridNumber % 7].button.BackColor = System.Drawing.Color.Khaki;
                        }
                        else
                            break;
                    }
                    for (int i = 1; i < 7; i++)
                    {
                        if (gridNumber / 7 - i >= 0 && arrayGrid[gridNumber / 7 - i, gridNumber % 7].element == Element.chair)
                        {
                            if (arrayGrid[gridNumber / 7 - i, gridNumber % 7].button.BackColor != System.Drawing.Color.Khaki)
                                progressBar.PerformStep();
                            arrayGrid[gridNumber / 7 - i, gridNumber % 7].button.BackColor = System.Drawing.Color.Khaki;
                        }
                        else
                            break;
                    }
                    for (int i = 1; i < 7; i++)
                    {
                        if (gridNumber % 7 + i < 7 && arrayGrid[gridNumber / 7, gridNumber % 7 + i].element == Element.chair)
                        {
                            if (arrayGrid[gridNumber / 7, gridNumber % 7 + i].button.BackColor != System.Drawing.Color.Khaki)
                                progressBar.PerformStep();
                            arrayGrid[gridNumber / 7, gridNumber % 7 + i].button.BackColor = System.Drawing.Color.Khaki;
                        }
                        else
                            break;
                    }
                    for (int i = 1; i < 7; i++)
                    {
                        if (gridNumber % 7 - i >= 0 && arrayGrid[gridNumber / 7, gridNumber % 7 - i].element == Element.chair)
                        {
                            if (arrayGrid[gridNumber / 7, gridNumber % 7 - i].button.BackColor != System.Drawing.Color.Khaki)
                                progressBar.PerformStep();
                            arrayGrid[gridNumber / 7, gridNumber % 7 - i].button.BackColor = System.Drawing.Color.Khaki;                         
                        }
                        else
                            break;
                    }
                    buttonGrid.BackgroundImage = Properties.Resources.chair;
                    buttonGrid.BackColor = System.Drawing.Color.Yellow;
                    thing = Element.observer;
                    Grid tempGrid = new Grid(buttonGrid, thing);
                    arrayGrid[gridNumber / 7, gridNumber % 7] = tempGrid;
                    buttonGrid.Enabled = false;
                    progressBar.PerformStep();
                }
            }
            int canWePlay = 0;
            for (int i = 0; i < 49; i++)
            {
                if (arrayGrid[i / 7, i % 7].button.Enabled == true && arrayGrid[i / 7, i % 7].button.BackColor != System.Drawing.Color.Khaki)
                    canWePlay++;
                if (canWePlay > 0)
                    break;
            }
            if (progressBar.Value == progressBar.Maximum || canWePlay == 0)
            {
                if (progressBar.Value == progressBar.Maximum)
                    canWePlay--;
                string messageTitle = canWePlay == 0 ? "Co za pech..." : "Gratulacje!";
                var result = MessageBox.Show("Czy chcesz zagrać jeszcze raz?",
                    messageTitle,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    this.Close();
                else
                    flowLayoutPanelGrid.Controls.Clear();
                progressBar.Value = 0;
                buttonStart.Enabled = true;
            }
        }
    }
    public enum Element
    {
        chair,
        observer,
        Phillarx,
        Phillar0,
        Phillar1,
        Phillar2,
        Phillar3
    }

    public class Grid
    {
        public Button button { get; set; }
        public Element element;
        public Grid(Button button, Element element)
        {
            this.button = button;
            this.element = element;
        }
    }
    class Check
    {
        public static int Checking(Grid[,] arrayGrid, int checkwidth, int checkhight)
        {
            int count = 0;
            if (arrayGrid[checkwidth, checkhight].element == Element.Phillar3)
                count = 2;
            if (arrayGrid[checkwidth, checkhight].element == Element.Phillar2)
                count = 1;
            if (arrayGrid[checkwidth, checkhight].element == Element.Phillar1)
                count = 0;
            if (arrayGrid[checkwidth, checkhight].element == Element.Phillar0)
                count = -1;
            if (arrayGrid[checkwidth, checkhight].element != Element.Phillarx)
            {
                //chceck near
                if (checkwidth + 1 < 7 && arrayGrid[checkwidth + 1, checkhight].element == Element.observer)
                    count--;
                if (checkwidth - 1 >= 0 && arrayGrid[checkwidth - 1, checkhight].element == Element.observer)
                    count--;
                if (checkhight + 1 < 7 && arrayGrid[checkwidth, checkhight + 1].element == Element.observer)
                    count--;
                if (checkhight - 1 >= 0 && arrayGrid[checkwidth, checkhight - 1].element == Element.observer)
                    count--;
            }
            return count;
        }
    }
}