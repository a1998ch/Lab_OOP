﻿using System;
using System.Windows.Forms;
using System.ComponentModel;
using ModelLaba4WindowsForms;
using System.Drawing;
using static System.Windows.Forms.LinkLabel;

namespace ViewFormWindowsForms
{
    /// <summary>
    /// Класс AddForm
    /// </summary>
    public partial class AddForm : Form
    {
        /// <summary>
        /// Предопределенный делегат, 
        /// который представляет метод обработчика событий для события
        /// нажатия на кнопку "OK"
        /// </summary>
        internal event EventHandler<FiguresAreaBase> ClicOK;

        /// <summary>
        /// Предопределенный делегат, 
        /// который представляет метод обработчика событий для события
        /// "Закрытие формы"
        /// </summary>
        internal event EventHandler CloseForm;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public AddForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка AddForm
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void AddFormLoad(object sender, EventArgs e)
        {
            ComboBoxChoiceFigure.DropDownStyle = ComboBoxStyle.DropDownList;
            AddFigureOK.Enabled = false;
        }

        /// <summary>
        /// Действия при завершении работы AddForm
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void AddFormClosing(object sender, FormClosingEventArgs e)
        {
            CloseForm?.Invoke(sender, e);
        }
        
        /// <summary>
        /// Действия при нажатие на кнопку "ОК"
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void AddFigureOKClick(object sender, EventArgs e)
        {
            try
            {
                AddFigure();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Завершение работы AddForm
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void ExitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Изменение типа фигуры
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void ChoiceFigureSelectedIndexChanged(object sender, EventArgs e)
        {
            const int CircleSelectedIndex = 0;
            const int RectangleSelectedIndex = 1;
            const int TriangleSelectedIndex = 2;
            switch (ComboBoxChoiceFigure.SelectedIndex)
            {
                case CircleSelectedIndex:
                    DataGridViewClear();
                    dataGridViewAdd.Columns.Add("Радиус", "Радиус");
                    dataGridViewAdd.Rows.Add();
                    break;
                case RectangleSelectedIndex:
                    DataGridViewClear();
                    dataGridViewAdd.Columns.Add("Сторона А", "Сторона А");
                    dataGridViewAdd.Columns.Add("Сторона В", "Сторона В");
                    dataGridViewAdd.Rows.Add();
                    break;
                case TriangleSelectedIndex:
                    DataGridViewClear();
                    dataGridViewAdd.Columns.Add("Сторона А", "Сторона А");
                    dataGridViewAdd.Columns.Add("Сторона В", "Сторона В");
                    dataGridViewAdd.Columns.Add("Сторона С", "Сторона С");
                    dataGridViewAdd.Rows.Add();
                    break;
            }
        }

        /// <summary>
        /// Изменение DataGridViewAdd
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void DataGridViewAddCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewAdd.AutoResizeColumns();

            int cellIndex = dataGridViewAdd.CurrentCell.ColumnIndex;
            int rowIndex = dataGridViewAdd.CurrentRow.Index;
            var nameHeader = dataGridViewAdd.Columns[
                dataGridViewAdd.CurrentCell.ColumnIndex].HeaderText;

            for(int i = 0; i < dataGridViewAdd.Columns.Count; i++)
            {
                if (dataGridViewAdd.CurrentCell.Value != null &&
                    !double.TryParse(dataGridViewAdd.CurrentCell.Value.ToString(), out double _))
                {
                    dataGridViewAdd.Rows[rowIndex].Cells[cellIndex].Style.BackColor = Color.Red;
                    dataGridViewAdd.Rows[rowIndex].Cells[cellIndex].ToolTipText = 
                        $"Неправильный ввод данных в столбце: \"{nameHeader}\"";
                    AddFigureOK.Enabled = false;
                }
                else
                {
                    dataGridViewAdd.Rows[rowIndex].Cells[cellIndex].Style.BackColor = Color.White;
                }
            }

            for (int i = 0, j = 0; i < dataGridViewAdd.Columns.Count; i++)
            {
                if (dataGridViewAdd[i, 0].Value != null &&
                    dataGridViewAdd.Rows[rowIndex].
                    Cells[i].Style.BackColor != Color.Red)
                {
                    j++;
                }
                if (j == dataGridViewAdd.Columns.Count)
                {
                    AddFigureOK.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Удаление строк и столбцов DataGridViewAdd
        /// </summary>
        private void DataGridViewClear()
        {
            int count = dataGridViewAdd.Columns.Count;
            dataGridViewAdd.Rows.Clear();
            for (int i = 0; i < count; i++)
            {
                dataGridViewAdd.Columns.RemoveAt(0);
            }
        }

        /// <summary>
        /// Запись параметров фигуры
        /// </summary>
        /// <returns>Параметры фигуры</returns>
        private void AddFigure()
        {
            const int numberOfCircleParam = 1;
            const int numberOfRectangleParam = 2;
            const int numberOfTriangleParam = 3;

            for (int i = 0; ;)
            {
                switch (dataGridViewAdd.Columns.Count)
                {
                    case numberOfCircleParam:
                        ClicOK?.Invoke(this, (new Circle(
                            Convert.ToDouble(dataGridViewAdd.Rows[0].Cells[i].Value))));
                        break;
                    case numberOfRectangleParam:
                        ClicOK?.Invoke(this, (new ModelLaba4WindowsForms.Rectangle(
                            Convert.ToDouble(dataGridViewAdd.Rows[0].Cells[i].Value), 
                            Convert.ToDouble(dataGridViewAdd.Rows[0].Cells[i + 1].Value))));
                        break;
                    case numberOfTriangleParam:
                        ClicOK?.Invoke(this, (new Triangle(
                            Convert.ToDouble(dataGridViewAdd.Rows[0].Cells[i].Value),
                            Convert.ToDouble(dataGridViewAdd.Rows[0].Cells[i + 1].Value),
                            Convert.ToDouble(dataGridViewAdd.Rows[0].Cells[i + 2].Value))));
                        break;
                }
                break;
            }
        }

#if DEBUG
        /// <summary>
        /// Заполнение DataGridViewAdd случайными значениями
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event</param>
        private void CreateRandomDataClick(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomFigure = random.Next(0, 3);
            ComboBoxChoiceFigure.SelectedIndex = randomFigure;

            for (int i = 0; i < dataGridViewAdd.Columns.Count; i++)
            {
                dataGridViewAdd[i, 0].Value = GetRandomData(random);

                if (dataGridViewAdd.Columns.Count == 3 && i > 0)
                {
                    dataGridViewAdd[i, 0].Value = 
                        (double)dataGridViewAdd[1, 0].Value / 10 + 
                        (double)dataGridViewAdd[i - 1, 0].Value;
                }
            }
        }
        
        /// <summary>
        /// Создание случайных параметров фигуры
        /// </summary>
        /// <param name="random">Генератор случайных чисел</param>
        /// <returns>Параметры фигуры</returns>
        private static double GetRandomData(Random random)
        {
            double doubleNumber = random.NextDouble();
            double param = random.Next(1, 100) * doubleNumber;
            return Math.Round(param, 7);
        }
#endif
    }
}
