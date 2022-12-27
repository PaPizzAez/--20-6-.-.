using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace CurseH
{
    public partial class DiskInfoForm : Form
    {
        private DriveInfo selectedDiskInfo;
        public DiskInfoForm(string diskName)
        {
            InitializeComponent();
            selectedDiskInfo = new DriveInfo(diskName);
            LblDriveName.Text += selectedDiskInfo.Name;
            LblDriveFormat.Text += selectedDiskInfo.DriveFormat;
            LblFreeSpace.Text += string.Format("{0:N} байт,  {1:0.00} Гб", selectedDiskInfo.AvailableFreeSpace, selectedDiskInfo.AvailableFreeSpace / Math.Pow(1024, 3));
            LblTotalSpace.Text += string.Format("{0:N} байт,  {1:0.00} Гб", selectedDiskInfo.TotalSize, selectedDiskInfo.TotalSize / Math.Pow(1024, 3));
            LblOccupiedSpace.Text += string.Format("{0:N} байт,  {1:0.00} Гб", selectedDiskInfo.TotalSize - selectedDiskInfo.AvailableFreeSpace, (selectedDiskInfo.TotalSize - selectedDiskInfo.AvailableFreeSpace)/Math.Pow(1024, 3));
            switch (selectedDiskInfo.DriveType)
            {
                case DriveType.Fixed:
                    LblDriveType.Text += "Жорсткий диск";
                    break;

                case DriveType.Removable:
                    LblDriveType.Text += "З'ємний пристрий";
                    break;

                case DriveType.CDRom:
                    LblDriveType.Text += "Оптичниий диск (DVD/CD)";
                    break;

                case DriveType.Network:
                    LblDriveType.Text += "Мережевий диск";
                    break;

                case DriveType.Unknown:
                    LblDriveType.Text += "Невідомо";
                    break;
            }

            Paint += DiskInfoForm_Paint;
        }

        private void DiskInfoForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush freeSpaceBrush = Brushes.Green;
            Brush occupiedSpaceBrush = Brushes.Orange;
            Rectangle diagramArea = new Rectangle(150, 250, 150, 150);

            float freeSizeProportion = selectedDiskInfo.AvailableFreeSpace * 360 / selectedDiskInfo.TotalSize;

            g.FillPie(occupiedSpaceBrush, diagramArea, 0, 360 - freeSizeProportion);
            g.FillPie(freeSpaceBrush, diagramArea, 360 - freeSizeProportion, freeSizeProportion);
            g.DrawEllipse(Pens.Black, diagramArea);
            
        }
    }
}
