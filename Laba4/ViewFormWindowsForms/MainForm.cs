﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using ModelLaba4WindowsForms;
using System.Text.RegularExpressions;

namespace ViewFormWindowsForms
{
    public partial class MainForm : Form
    {
        private BindingList<FiguresAreaBase> _figuresList = 
            new BindingList<FiguresAreaBase>()
        {
            new Circle(10),
            new ModelLaba4WindowsForms.Rectangle(7, 9),
            new Triangle(3, 2, 4)
        };
            
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            dataGridViewMain.DataSource = _figuresList;
            dataGridViewMain.AutoResizeColumns();
        }

        private void AddFigureClick(object sender, EventArgs e)
        {
            this.Hide();
            AddForm addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    switch (addForm.FigureParam().Length)
                    {
                        case 1:
                            _figuresList.Add(new Circle(addForm.FigureParam()[0]));
                            break;
                        case 2:
                            _figuresList.Add(new ModelLaba4WindowsForms.Rectangle(addForm.FigureParam()[0], addForm.FigureParam()[1]));
                            break;
                        case 3:
                            _figuresList.Add(new Triangle(addForm.FigureParam()[0], addForm.FigureParam()[1], addForm.FigureParam()[2]));
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AddFigureClick(sender, e);
                }
            }
        }

        private void RemoveFigureClick(object sender, EventArgs e)
        {

        }
    }
}
