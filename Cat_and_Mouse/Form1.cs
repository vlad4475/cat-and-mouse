using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Cat_and_Mouse
{
    public partial class Form1 : Form
    {

        //Переменные найваны так, как называются коэффициенты в статье, в которой описывается данный процесс.
        double a, b, c, d, x, y; 
        const double ITERATION_COEFFICIENT = 0.01;

        Form2 formTable;
        List<double> listX = new List<double>();
        List<double> listY = new List<double>();

        public Form1()
        {
            InitializeComponent();
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart2.ChartAreas[0].AxisX.Minimum = 0;

            ClearGraphs();
            inputA.Text = Convert.ToString(4);
            inputB.Text = Convert.ToString(2.5);
            inputC.Text = Convert.ToString(2);
            inputD.Text = Convert.ToString(1);
            inputCountWolf.Text = Convert.ToString(1);
            inputCountSheep.Text = Convert.ToString(3);

            tLenghtTime.Text = Convert.ToString(1000);
        }

        private void DrowGraph()
        {
            int countCycle = 0, longCycle = 0, prevCycle = 0;

            a = Convert.ToDouble(inputA.Text);
            b = Convert.ToDouble(inputB.Text);
            c = Convert.ToDouble(inputC.Text);
            d = Convert.ToDouble(inputD.Text);
            x = Convert.ToDouble(inputCountSheep.Text);
            y = Convert.ToDouble(inputCountWolf.Text);

            if (x < 0 || y < 0)
            {
                lisError.Text = "Ошибка. Кол-во хищников и жертв должно быть положительно.";
                return;
            }

            for (int i = 0; i < Convert.ToDouble(tLenghtTime.Text); i++)
            {

                chart1.Series[0].Points.AddXY(i, x);
                chart1.Series[1].Points.AddXY(i, y);

                listX.Add(x);
                listY.Add(y);

                x = x + ITERATION_COEFFICIENT * x * (a - y * b); //x + x*a - x*y*b
                y = y - ITERATION_COEFFICIENT * y * (c - d * x); //y - y*c + d*y*x                   

                if(x < 0 || y < 0)
                {
                    lisError.Text = "Ошибка. Выберите меньший шаг для данной сиситемы, т.к. происходит полиномиальное расскачивание.";
                    chart1.Series[0].Points.Clear();
                    chart1.Series[1].Points.Clear();
                    return;
                }
            }

            for (int i = 1; i < listX.Count-1; i++)
            {
                if ((listX[i - 1] < listX[i]) && (listX[i] > listX[i + 1]))
                {
                    countCycle += 1;
                    longCycle = i - prevCycle;
                    prevCycle = i;                    
                }                    
            }

            lisError.Text = "График успешно построен. \r Кол-во циклов= " + 
                countCycle + "\r Длинна цикла = " +
                longCycle + "\r \r Стационарная точка:\r x= " + a / b +
                " \r y= " + c / d;
        }


        private void DrowFazGraph() 
        {
            a = Convert.ToDouble(inputA.Text);
            b = Convert.ToDouble(inputB.Text);
            c = Convert.ToDouble(inputC.Text);
            d = Convert.ToDouble(inputD.Text);
            x = Convert.ToDouble(inputCountSheep.Text);
            y = Convert.ToDouble(inputCountWolf.Text);
          
            if ((listX.Count <= 0) || (listX.Count <= 0))
            {
                MessageBox.Show("Ошибка. \rСначала требуется построить основной график.");
                return;
            }             

            for (int i = 0; i < Convert.ToDouble(tLenghtTime.Text); i++)
            {
                chart2.Series[0].Points.AddXY(listX[i], listY[i]); 
              
                if (x < 0 || y < 0)
                {
                    lisError.Text = "Что то пошло не так";
                    chart2.Series[0].Points.Clear();                    
                    return;
                }
            }
        }


        private void DrowGraph_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            listX.Clear();
            listY.Clear();

            DrowGraph();
        }

        private void пример1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearGraphs();
            inputA.Text = Convert.ToString(0.2);
            inputB.Text = Convert.ToString(0.01);
            inputC.Text = Convert.ToString(0.1);
            inputD.Text = Convert.ToString(0.001);
            inputCountWolf.Text = Convert.ToString(50);
            inputCountSheep.Text = Convert.ToString(500);
        }

        private void пример2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearGraphs();
            inputA.Text = Convert.ToString(0.01);
            inputB.Text = Convert.ToString(0.001);
            inputC.Text = Convert.ToString(0.1);
            inputD.Text = Convert.ToString(0.001);
            inputCountWolf.Text = Convert.ToString(50);
            inputCountSheep.Text = Convert.ToString(500);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart2.Series[0].Points.Clear();
            DrowFazGraph();
        }

        private void ClearGraphs()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart2.Series[0].Points.Clear();
            listX.Clear();
            listY.Clear();
        }

        private void пример3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearGraphs();
            inputA.Text = Convert.ToString(4);
            inputB.Text = Convert.ToString(2.5);
            inputC.Text = Convert.ToString(2);
            inputD.Text = Convert.ToString(1);
            inputCountWolf.Text = Convert.ToString(1);
            inputCountSheep.Text = Convert.ToString(3);
        }

        private void ненужноеСтрашноеОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listX.Count == 0)
            {
                MessageBox.Show("Постройте график", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
                
            formTable = new Form2(listX, listY);
            formTable.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
