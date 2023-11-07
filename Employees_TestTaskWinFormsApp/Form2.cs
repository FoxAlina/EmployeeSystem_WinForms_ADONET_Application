using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees_TestTaskWinFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // данная строка кода позволяет загрузить данные в таблицу "EmployeesDataSet.AverageSalaryInPositionInfo". При необходимости она может быть перемещена или удалена.
            this.AverageSalaryInPositionInfoTableAdapter.Fill(this.EmployeesDataSet.AverageSalaryInPositionInfo);

            this.reportViewer1.RefreshReport();
        }
    }
}
