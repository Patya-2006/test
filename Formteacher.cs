using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Formteacher : Form
    {
        public Formteacher()
        {
            InitializeComponent();
        }

        private void учителяBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.учителяBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.schoolDataSet);

        }

        private void Formteacher_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "schoolDataSet.Учителя". При необходимости она может быть перемещена или удалена.
            this.учителяTableAdapter.Fill(this.schoolDataSet.Учителя);

        }
    }
}
