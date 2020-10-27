using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MethodLib;

namespace ISMDotNet4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1generate_Click(object sender, EventArgs e)
        {
            bool flag;
            int f, count = 0;
            flag = int.TryParse(textBoxCount.Text, out f);
            if (flag == true)
                count = f;
            else
                textBoxCount.Clear();
            dataGridViewArray.ColumnCount = count;
            dataGridViewArray.RowCount = 1;
            Random rnd = new Random();
            for(int i = 0; i < count; i++)
            {
                dataGridViewArray.Columns[i].HeaderCell.Value = i.ToString();
                dataGridViewArray[i, 0].Value = rnd.Next(-100, 100);
                dataGridViewArray.Columns[i].Width = 35; 
            }
        }
        public void buttonCalculate_Click(object sender, EventArgs e)
        {

            double[] arr = new double[dataGridViewArray.ColumnCount];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(dataGridViewArray[i, 0].Value.ToString());
            }
            double sum = MyArray.SumOfNegative(arr);
            labelSumofnegative.Text = sum.ToString();
            double max = MyArray.MaxElement(arr);
            labelMaximumelement.Text = max.ToString();
            int indexMax = MyArray.IndexOfMax(arr);
            labelMaximumelementnumber.Text = indexMax.ToString();
            double maxmod = MyArray.MaxModElement(arr);
            labelMaximumelementmodulo.Text = maxmod.ToString();
            int sumindexofpozitiveEl = MyArray.SumIndexOfPozitiveEl(arr);
            labelSumofindices.Text = sumindexofpozitiveEl.ToString();
            int numberofwhole = MyArray.Numberofwhole(arr);
            labelNumberofintegers.Text = numberofwhole.ToString();
            arr = MyArray.SortArray(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                dataGridViewSortedarray.ColumnCount = arr.Length;
                dataGridViewSortedarray.RowCount = 1;
                dataGridViewSortedarray.Columns[i].HeaderCell.Value = i.ToString();
                dataGridViewSortedarray[i, 0].Value = arr[i];
                dataGridViewSortedarray.Columns[i].Width = 35;
            }
            arr = MyArray.GetPozitiveElements(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                dataGridViewPositivearray.ColumnCount = arr.Length;
                dataGridViewPositivearray.RowCount = 1;
                dataGridViewPositivearray.Columns[i].HeaderCell.Value = i.ToString();
                dataGridViewPositivearray[i, 0].Value = arr[i];
                dataGridViewPositivearray.Columns[i].Width = 35;
            }
        }
    }
}
