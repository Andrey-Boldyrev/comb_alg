using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Необходимо сравнить решения, полученные точным алгоритмом (перебором вариантов), 
 и одним и алгоритмов ниже. Результаты (время работы и оптимальность) сравнить.
 3. a) Задача укладки по дискетам (ящикам): Жадный алгоритм;
 Пример из макконела: вместимость:10; размеры: 2 6 5 2 8 3 2 2
*/

namespace std 
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBoxSizes_KeyPress(object sender, KeyPressEventArgs e)
        {
            //обрабатываем только числа, пробел и backspace
            if ((e.KeyChar != 32) && (e.KeyChar != 8) && (e.KeyChar < 48 || e.KeyChar > 57))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3.а) Необходимо сравнить решения, полученные точным и жадным алгоритмом, время работы и оптимальность. Задача укладки по дискетам.", "Условие", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        //отображение результата
        public void ShowRes(long timeSort, long timeGreed, List<StringBuilder> sortAlg, List<StringBuilder> greedyAlg)
        {
            resPerebor.Clear();
            resGreedy.Clear();
            for (int i = 0; i < sortAlg.Count();i++)
            {
                resPerebor.Text += (i + 1).ToString()+" ящик: " + sortAlg[i].ToString() + Environment.NewLine;
            }
            
            for (int i = 0; i < greedyAlg.Count(); i++)
            {
                resGreedy.Text += (i + 1).ToString() + " ящик: " + greedyAlg[i].ToString() + Environment.NewLine;
            }

            dgvResCompare.RowCount = 2;
            dgvResCompare.Rows[0].Cells[0].Value = "Время работы:";
            dgvResCompare.Rows[1].Cells[0].Value = "Результат:";
            dgvResCompare.Rows[0].Cells[1].Value = timeSort.ToString();
            dgvResCompare.Rows[0].Cells[2].Value = timeGreed.ToString();
            dgvResCompare.Rows[1].Cells[1].Value = sortAlg.Count().ToString();
            dgvResCompare.Rows[1].Cells[2].Value = greedyAlg.Count().ToString();
            dgvResCompare.AutoResizeColumns();

        }


        private void btnRun_Click(object sender, EventArgs e)
        {
            if ((txtBoxSize.Text == "") || (txtboxDisk.Text == ""))
            {
                MessageBox.Show("Введите размеры файлов.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //массив размеров файлов
                int[] sizes = null;
                try
                {
                    sizes = txtBoxSize.Text.Split(' ').Where(x => !string.IsNullOrWhiteSpace(x)).Select(x => int.Parse(x)).ToArray();                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка при вводе чисел.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //время выполнения
                long timeSort = 0;
                long timeGreed = 0;

                List<StringBuilder> sortAlg = BackTrackAlg.FindRes(sizes, int.Parse(txtboxDisk.Text), out timeSort);
                List<StringBuilder> greedyAlg = GreedAlgorithm.FindRes(sizes, int.Parse(txtboxDisk.Text), out timeGreed);
                
                if ((sortAlg == null) || (greedyAlg == null))
                {
                    MessageBox.Show("Алгоритмы не дали результатов.", "Увы!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ShowRes(timeSort, timeGreed,  sortAlg, greedyAlg);
                }               
            }
        }
    }
}
