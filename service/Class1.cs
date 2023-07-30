using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using System.Windows.Forms;
using System.Drawing;
using BrainLinkSDK_Windows;

using System.Runtime.InteropServices;
using ContollerBL.dto;

using System.Runtime.InteropServices;

namespace BrainLinkConnect.service
{

    public class Reaction
    {
        public string Action { get; set; }
        public List<int[]> Position { get; set; }
        public List<string> Value { get; set; }

        private int infelicity = 1000;

    }
    public class Map2
    {
        public int Id { get; set; }
        public Dictionary<int, Reaction> Maps { get; set; } = new Dictionary<int, Reaction>();
    }

    public class Reaction1
    {
        public string Action { get; set; }
        public List<int[]> Position { get; set; }
        public List<string> Value { get; set; }
        public int Weight { get; set; }
    }

    public class Map1
    {
        public List<string> Attention;

        public List<string> Meditation { get; set; }

        public List<string> Signal { get; set; }

        public List<string> Delta { get; set; }

        public List<string> Theta { get; set; }

        public List<string> LowAlpha { get; set; }

        public List<string> HighAlpha { get; set; }

        public List<string> LowBeta { get; set; }

        public List<string> HighBeta { get; set; }

        public List<string> LowGamma { get; set; }

        public List<string> HighGamma { get; set; }
    }

    public class services
    {
        public Mouse mouse = new Mouse();
    }

    public class Mouse
    {

        private System.Threading.Timer timer;
        private int iterator = 0;

        [DllImport("User32.dll",
                EntryPoint = "mouse_event",
                CallingConvention = CallingConvention.Winapi)]
        internal static extern void Mouse_Event(int dwFlags,
                                            int dx,
                                            int dy,
                                            int dwData,
                                            int dwExtraInfo);

        [DllImport("User32.dll",
                    EntryPoint = "GetSystemMetrics",
                    CallingConvention = CallingConvention.Winapi)]
        internal static extern int InternalGetSystemMetrics(int value);

        public void play(EegHistoryModel brainLinkToServiseDto, ConfigParams conf, string eventName, bool isUse)
        {
            if (timer != null) { timer.Dispose(); }
            if (eventName != "" && isUse)
            {
                timer = new System.Threading.Timer(playKey, eventName, 0, 10);
            }
        }

        private void playKey(object eventMouse)
        {
            switch (eventMouse)
            {
                case "ml":
                    Cursor.Position = new Point(Cursor.Position.X - 1, Cursor.Position.Y);
                    break;
                case "mr":
                    Cursor.Position = new Point(Cursor.Position.X + 1, Cursor.Position.Y);
                    break;
                case "md":
                    Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + 1);
                    break;
                case "mu":
                    Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - 1);
                    break;
            }
        }

    }


    [Serializable]
    public class BrainLinkToServiseDto
    {
        public int id;
        public BrainLinkModel input = new BrainLinkModel();
        public SystemInfo system;
        public string eventName = "";
    }
}
