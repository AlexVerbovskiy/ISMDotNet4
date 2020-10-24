using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormArray : Form
    {
        public FormArray()
        {
            InitializeComponent();
        }

        private void buttonKElements_Click(object sender, EventArgs e)
        {
            int k = int.Parse(textBoxKElements.Text);
            dataGridViewArray.ColumnCount = k;
            dataGridViewArray.RowCount = 1;
            for (int i = 0; i < k; i++)
            {
                dataGridViewArray.Columns[i].HeaderCell.Value = i.ToString();
            }
            Calculate.Visible = true;


        }
       
            private void FormArray_Load(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int k = int.Parse(textBoxKElements.Text);
            double[] arr = new double[k];
            for (int i = 0; i < k; i++)
            {
                arr[i] = int.Parse(dataGridViewArray[i, 0].Value.ToString());
            }

            SumNegativesElements.Visible = true;
            MaxElement.Visible = true;
            IndexMaxElement.Visible = true;
            MaxAbs.Visible = true;
            KPositiveElements.Visible = true;
            KIntElements.Visible = true;
            dataGridViewSortArray.Visible = true;
            dataGridViewDeleterNegetiveElements.Visible = true;

            labelSumNegativesElements.Visible = true;
            labelMaxElement.Visible = true;
            labelIndexMaxElement.Visible = true;
            labelMaxAbs.Visible = true;
            labelKPositiveElements.Visible = true;
            labelKIntElements.Visible = true;
            labelSort.Visible = true;
            labelDelNegElements.Visible = true;

            SumNegativesElements.Text = ClassLibraryArrays.Class1.SumNegetivesArray(arr).ToString();
            MaxElement.Text = ClassLibraryArrays.Class1.MaxElement(arr).ToString();
            IndexMaxElement.Text = ClassLibraryArrays.Class1.IndexMaxElement(arr).ToString();
            MaxAbs.Text = ClassLibraryArrays.Class1.MaxAbsElement(arr).ToString();
            KPositiveElements.Text = ClassLibraryArrays.Class1.SumIndexesPositiveElements(arr).ToString();
            KIntElements.Text = ClassLibraryArrays.Class1.CountWholeElements(arr).ToString();

            dataGridViewSortArray.ColumnCount = ClassLibraryArrays.Class1.SortArray(arr).Length;
            dataGridViewSortArray.RowCount = 1;
            dataGridViewDeleterNegetiveElements.ColumnCount = ClassLibraryArrays.Class1.DeleterNegetiveElements(arr).Length;
            dataGridViewDeleterNegetiveElements.RowCount = 1;
            double[] arr1 = new double[ClassLibraryArrays.Class1.SortArray(arr).Length];
            arr1 = ClassLibraryArrays.Class1.SortArray(arr);
            for (int i = 0; i < ClassLibraryArrays.Class1.SortArray(arr).Length; i++)
            {
                dataGridViewSortArray.Columns[i].HeaderCell.Value = i.ToString();
            }
            for (int i = 0; i < ClassLibraryArrays.Class1.SortArray(arr).Length; i++)
            {
                dataGridViewSortArray[i, 0].Value = arr1[i].ToString();
            }
            double[] arr2 = new double[ClassLibraryArrays.Class1.DeleterNegetiveElements(arr).Length];
            arr2 = ClassLibraryArrays.Class1.DeleterNegetiveElements(arr);
            for (int i = 0; i < ClassLibraryArrays.Class1.DeleterNegetiveElements(arr).Length; i++)
            {
                dataGridViewDeleterNegetiveElements.Columns[i].HeaderCell.Value = i.ToString();
            }
            for (int i = 0; i < ClassLibraryArrays.Class1.DeleterNegetiveElements(arr).Length; i++)
            {
                dataGridViewDeleterNegetiveElements[i,0].Value = arr2[i].ToString();
            }
        }
    }
}
