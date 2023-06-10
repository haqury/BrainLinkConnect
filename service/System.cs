using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace BrainLinkConnect.service
{
    [Serializable]
    public class SystemInfo
    {
        public int x;
        public int y;
        public int toX;
        public int toY;
        public int endX;
        public int endY;

        public bool isUseMouse()
        {
            return toX == 0
                && toY == 0;
        }
    }

    public class SystemServiceConfig
    {

    }


    public class SystemService
    {
        private SystemInfo info = new SystemInfo();
        public SystemServiceConfig config;

        public SystemInfo UpdateGetInfo()
        {
            info.x = Cursor.Position.X;
            info.y = Cursor.Position.Y;
            return info;
        }

        public SystemInfo Run(SystemInfo info)
        {
            info.endX = Cursor.Position.X;
            info.endY = Cursor.Position.Y;
            info.toX = Cursor.Position.X - info.x;
            info.toY = Cursor.Position.Y - info.y;
            return info;
        }
    }
}
