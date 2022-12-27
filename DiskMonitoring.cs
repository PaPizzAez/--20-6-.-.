using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CurseH
{
    //перелік для позначення одиниць виміру даних
    public enum MemoryUnits
    {
        MB = 0,
        GB = 1
    }

    public class DiskMonitoring
    {
        private Dictionary<string, DiskState> disks;                        //колекція для зберігання даних про диски
        public MemoryUnits currentUnit;                                     //поточна обрана одиниця виміру даних
        
        public DiskMonitoring()
        {
            disks = new Dictionary<string, DiskState>();
            currentUnit = MemoryUnits.MB;

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            { 
                if (drive.IsReady)
                {
                    disks.Add(drive.Name, new DiskState()
                    {
                        FreeSpace = drive.AvailableFreeSpace,
                        TotalSpace = drive.TotalSize,
                    });
                }
            }
        }

        //копія даних для передачі у діалогове вікно
        public Dictionary<string, DiskState> GetDataCopy()
        {
            return new Dictionary<string, DiskState>(disks);
        }

        //завантаження даних на DataGridView
        public void LoadData(DataGridView data)
        {
            data.Rows.Clear();

            double Total, Free;

            foreach (var disk in disks)
            {
                Total = (currentUnit == MemoryUnits.MB) ? (disk.Value.TotalSpace / Math.Pow(1024, 2)) : (disk.Value.TotalSpace / Math.Pow(1024, 3));
                Free = (currentUnit == MemoryUnits.MB) ? (disk.Value.FreeSpace / Math.Pow(1024, 2)) : (disk.Value.FreeSpace / Math.Pow(1024, 3));
                
                data.Rows.Add(disk.Key,
                              string.Format("{0:0.00}", Total),
                              string.Format("{0:0.00}", Free));
            }
        }

        //оновлення даних про диски
        public void UpdateDiskStates()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            Dictionary<string, DiskState> temp = new Dictionary<string, DiskState>();

            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    temp.Add(drive.Name, new DiskState()
                    {
                        FreeSpace = drive.AvailableFreeSpace,
                        TotalSpace = drive.TotalSize,
                    });
                }
            }
            disks = temp;
        }
    }
}