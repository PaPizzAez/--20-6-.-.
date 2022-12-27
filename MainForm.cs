using System;
using System.Drawing;
using System.Windows.Forms;

namespace CurseH
{
    public partial class MainForm : Form
    {

       
        public event EventHandler MeasureChange;
        public event EventHandler DoubleClick;
        public event EventHandler MainFormClose;

        public MainForm()
        {
            InitializeComponent();
           
            //підписка на події головної форми
            FormClosing += MainForm_FormClosing;

            //налаштуваня ComboBox для відображення даних у різних одиницях (Мб / Гб)
            cbMeasureUnits.Items.AddRange(new string[] { "MB", "GB" });
            cbMeasureUnits.SelectedIndex = 0;
            cbMeasureUnits.SelectedValueChanged += CbMeasureUnits_SelectedValueChanged;

            //налаштування таблиці для відображення даних
            diskDataGridView.ColumnCount = 3;
            diskDataGridView.Columns[0].Name = "Мітка тому";
            diskDataGridView.Columns[1].Name = "Загальний об'єм пам'яті";
            diskDataGridView.Columns[2].Name = "Об'єм вільної пам'яті";

            foreach(DataGridViewColumn column in diskDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            diskDataGridView.DoubleClick += DiskDataGridView_DoubleClick;

            
        }

        public DataGridView GetDataGrid()
        {
            return diskDataGridView;
        }

        //скидання виділення для DataGridView
        private void DiskDataGridView_DoubleClick(object sender, EventArgs e)
        {
            DoubleClick?.Invoke(sender, e);
            
        }

        //обробник події закриття вікна
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFormClose?.Invoke(sender, e);
        }
        
        //обробник зміни обраного значення у ComboBox, що відповідає за одиниці виміру пам'яті
        private void CbMeasureUnits_SelectedValueChanged(object sender, EventArgs e)
        {
            MeasureChange?.Invoke(sender, e);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}