using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AreaCalculator;


namespace FigureAreaCalculator
{
    public partial class Form1 : Form
    {
        ListOfFigures lf = new ListOfFigures();
        CalculateFigures cf = new CalculateFigures();
        private decimal Hight;    //Высота
        private decimal Width;    //Ширина
        private decimal Radius;   //Радиус
        private decimal Length;   //Длина
        private bool sucsess;

        ListOfFigures list = new ListOfFigures();
        

        public Form1()
        {

            InitializeComponent();
            foreach (Figures f in lf.listOfFigures)
            {
                comboBoxFigures.Items.Add(f);
            }
            SetDefValue();
            comboBoxFigures.SelectedItem = comboBoxFigures.Items[0];
            this.Text = "Расчет площади";
            
        }

        private void SetDefValue()
        {
            valueHigth.Text = "0";
            valueWidth.Text = "0";
            valueLength.Text = "0";
            valueRadius.Text = "0";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            textBoxResult.Clear();

            string result =  cf.Calculate(comboBoxFigures.SelectedItem, Hight, Width, Radius, Length);
            textBoxResult.Text = result;
        }

        private void valueHigth_TextChanged(object sender, EventArgs e)
        {
            
            sucsess = Decimal.TryParse(valueHigth.Text, out Hight);
            if (!sucsess)
                valueHigth.Text = "0";
        }

        private void valueWidth_TextChanged(object sender, EventArgs e)
        {
            sucsess = Decimal.TryParse(valueWidth.Text, out Width);
            if (!sucsess)
                valueWidth.Text = "0";
        }

        private void valueRadius_TextChanged(object sender, EventArgs e)
        {
            sucsess = Decimal.TryParse(valueRadius.Text, out Radius);
            if (!sucsess)
                valueRadius.Text = "0";
        }

        private void valueLength_TextChanged(object sender, EventArgs e)
        {
            sucsess = Decimal.TryParse(valueLength.Text, out Length);
            if (!sucsess)
                valueLength.Text = "0";
        }

        private void comboBoxFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDefValue();
            switch (comboBoxFigures.SelectedItem)
            {
                case Figures.Circle:
                    valueHigth.ReadOnly = true;
                    valueWidth.ReadOnly = true;
                    valueLength.ReadOnly = true;
                    valueRadius.ReadOnly = false;
                    break;
                case Figures.Rectangle:
                    valueHigth.ReadOnly = false;
                    valueWidth.ReadOnly = false;
                    valueLength.ReadOnly = true;
                    valueRadius.ReadOnly = true;
                    break;
                case Figures.Triangle:
                    valueHigth.ReadOnly = false;
                    valueWidth.ReadOnly = false;
                    valueLength.ReadOnly = true;
                    valueRadius.ReadOnly = true;
                    break;
                case Figures.Square:
                    valueHigth.ReadOnly = true;
                    valueWidth.ReadOnly = true;
                    valueLength.ReadOnly = false;
                    valueRadius.ReadOnly = true;
                    break;
                case Figures.None:
                    valueHigth.ReadOnly = false;
                    valueWidth.ReadOnly = false;
                    valueLength.ReadOnly = false;
                    valueRadius.ReadOnly = false;
                    break;
            }
        }
    }

   
    
}
