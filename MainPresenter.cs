using System;
using System.Windows.Forms;
using System.Drawing;

namespace CurseH
{
    public class MainPresenter
    {
      
        private MainForm mymainForm;
        private DiskMonitoring mydiskData;           //об'єкт, що збирає дані про вільне місце на дисках
        private DataGridView mydataGrid;
        private Timer timmer;
        private Form AlertWindow;                   //вікно для відображення повідомлення
        private Label MessageSave;                 //керуючий елемент, що зберігає текст повідомлення

       

        public MainPresenter(MainForm form, DiskMonitoring monitor)
        {

            mymainForm = form;
            mydiskData = monitor;

            

            mydataGrid = mymainForm.GetDataGrid();

            //створення та налаштування таймеру для оновлення даних та виведення повідомлення
            timmer = new Timer();
            timmer.Interval = 5000;
            timmer.Tick += updateTimerperTick;
            timmer.Start();

            //створення та налаштування вікна та текстового поля (Label) для відображення повідомлення
            AlertWindow = new Form();
            AlertWindow.Size = new Size(700, 250); 
            AlertWindow.FormBorderStyle = FormBorderStyle.FixedDialog; 

          

            MessageSave = new Label();
            MessageSave.Location = new Point(0, 0);
            MessageSave.Size = new Size(700, 200);
            MessageSave.Font = new Font(FontFamily.GenericMonospace, 16);

            AlertWindow.Controls.Add(MessageSave);

            //підписки на події головного вікна
            mymainForm.MeasureChange += MmeasureUnits_Changed;
            mymainForm.MainFormClose += MmainForm_Closing;
            mymainForm.DoubleClick += mainForm_DoubleClicked;

            mydiskData.LoadData(mydataGrid);
        }

        private void mainForm_DoubleClicked(object sender, EventArgs e)
        {
            var diskInfoDialog = new DiskInfoForm(mydataGrid.SelectedRows[0].Cells[0].Value.ToString());
            diskInfoDialog.ShowDialog();
        }

        private void MmainForm_Closing(object sender, EventArgs e)
        {
            AlertWindow.Hide();
            timmer.Stop();
        }

        private void MmeasureUnits_Changed(object sender, EventArgs e)
        {
            mydiskData.currentUnit = (MemoryUnits)((ComboBox)sender).SelectedIndex;
            mydiskData.LoadData(mydataGrid);
        }

        private void updateTimerperTick(object sender, EventArgs e)
        {
            mydiskData.UpdateDiskStates();
            mydiskData.LoadData(mydataGrid);
        }

       
    }
}
