using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("10. Поиск в ширину для игры Балда. Все слова которые можно получить через k-ходов.", "Условие", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private char[] rusLetters = new char[] { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

        private void btnRun_Click(object sender, EventArgs e)
        {
            BaldaWork balda = new BaldaWork(txtBoxInput.Text.ToLower(), Convert.ToInt32(numBoxSteps.Value));
            txtBoxOutput.Text = balda.Work();
        }

        private void txtBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!rusLetters.Contains(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
