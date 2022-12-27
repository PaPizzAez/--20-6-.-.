using System;

namespace CurseH
{
    public class DiskState
    {
        //загальний об'єм пам'яті на диску
        public long TotalSpace { get; set; }

        //об'єм вільної пам'яті на диску
        public long FreeSpace { get; set; }

        public DiskState() {}

        //конструктор копіювання
        public DiskState(DiskState obj)
        {
            TotalSpace = obj.TotalSpace;
            FreeSpace = obj.FreeSpace;
        }
    }
}