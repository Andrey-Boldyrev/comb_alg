namespace std
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSizes = new System.Windows.Forms.Label();
            this.txtBoxSize = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxDisk = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.resPerebor = new System.Windows.Forms.TextBox();
            this.resGreedy = new System.Windows.Forms.TextBox();
            this.btnTask = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvResCompare = new System.Windows.Forms.DataGridView();
            this.ColumnText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSortAlg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGreedyAlg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResCompare)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSizes
            // 
            this.labelSizes.AutoSize = true;
            this.labelSizes.Location = new System.Drawing.Point(14, 83);
            this.labelSizes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSizes.Name = "labelSizes";
            this.labelSizes.Size = new System.Drawing.Size(98, 13);
            this.labelSizes.TabIndex = 1;
            this.labelSizes.Text = "Размеры файлов:";
            // 
            // txtBoxSize
            // 
            this.txtBoxSize.Location = new System.Drawing.Point(17, 98);
            this.txtBoxSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxSize.Name = "txtBoxSize";
            this.txtBoxSize.Size = new System.Drawing.Size(249, 20);
            this.txtBoxSize.TabIndex = 2;
            this.txtBoxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSizes_KeyPress);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(340, 52);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 35);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Найти решение";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Размер дискa:";
            // 
            // txtboxDisk
            // 
            this.txtboxDisk.Location = new System.Drawing.Point(17, 36);
            this.txtboxDisk.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxDisk.Name = "txtboxDisk";
            this.txtboxDisk.Size = new System.Drawing.Size(249, 20);
            this.txtboxDisk.TabIndex = 1;
            this.txtboxDisk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSizes_KeyPress);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(340, 90);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 35);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // resPerebor
            // 
            this.resPerebor.Location = new System.Drawing.Point(17, 155);
            this.resPerebor.Multiline = true;
            this.resPerebor.Name = "resPerebor";
            this.resPerebor.ReadOnly = true;
            this.resPerebor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resPerebor.Size = new System.Drawing.Size(199, 156);
            this.resPerebor.TabIndex = 9;
            // 
            // resGreedy
            // 
            this.resGreedy.Location = new System.Drawing.Point(239, 155);
            this.resGreedy.Multiline = true;
            this.resGreedy.Name = "resGreedy";
            this.resGreedy.ReadOnly = true;
            this.resGreedy.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resGreedy.Size = new System.Drawing.Size(201, 156);
            this.resGreedy.TabIndex = 10;
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(340, 12);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(100, 35);
            this.btnTask.TabIndex = 11;
            this.btnTask.Text = "Условие";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Результат жадного алгоритма:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Результат точного алгоритма:";
            // 
            // dgvResCompare
            // 
            this.dgvResCompare.AllowUserToAddRows = false;
            this.dgvResCompare.AllowUserToDeleteRows = false;
            this.dgvResCompare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResCompare.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResCompare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResCompare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnText,
            this.ColumnSortAlg,
            this.ColumnGreedyAlg});
            this.dgvResCompare.Location = new System.Drawing.Point(54, 317);
            this.dgvResCompare.Name = "dgvResCompare";
            this.dgvResCompare.ReadOnly = true;
            this.dgvResCompare.Size = new System.Drawing.Size(360, 76);
            this.dgvResCompare.TabIndex = 14;
            // 
            // ColumnText
            // 
            this.ColumnText.Frozen = true;
            this.ColumnText.HeaderText = "Сравение по:";
            this.ColumnText.Name = "ColumnText";
            this.ColumnText.ReadOnly = true;
            this.ColumnText.Width = 91;
            // 
            // ColumnSortAlg
            // 
            this.ColumnSortAlg.HeaderText = "Точный алгоритм";
            this.ColumnSortAlg.Name = "ColumnSortAlg";
            this.ColumnSortAlg.ReadOnly = true;
            this.ColumnSortAlg.Width = 111;
            // 
            // ColumnGreedyAlg
            // 
            this.ColumnGreedyAlg.HeaderText = "Жадный алгоритм";
            this.ColumnGreedyAlg.Name = "ColumnGreedyAlg";
            this.ColumnGreedyAlg.ReadOnly = true;
            this.ColumnGreedyAlg.Width = 115;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 402);
            this.Controls.Add(this.dgvResCompare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.resGreedy);
            this.Controls.Add(this.resPerebor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtboxDisk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtBoxSize);
            this.Controls.Add(this.labelSizes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Сравнение жадного алгоритма с перебором. Задача укладки по дискетам.";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResCompare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSizes;
        private System.Windows.Forms.TextBox txtBoxSize;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxDisk;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox resPerebor;
        private System.Windows.Forms.TextBox resGreedy;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvResCompare;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnText;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSortAlg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGreedyAlg;
    }
}

