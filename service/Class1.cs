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


namespace BrainLinkConnect.service
{

    public class Reaction
    {
        public string Action { get; set; }
        public List<int[]> Position { get; set; }
        public List<string> Value { get; set; }
        public List<EventMouse> Events { get; set; }

        private int infelicity = 1000;

        public EventMouse GetEvent(BrainLinkToServiseDto brainLinkToServiseDto)
        {
            return Events.Find(x => (x.current().input.HighBeta <= brainLinkToServiseDto.input.HighBeta + infelicity) && (brainLinkToServiseDto.input.HighBeta - infelicity <= x.current().input.HighBeta));
        }

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
        public List<EventMouse> Events { get; set; }
        public int Weight { get; set; }

        public EventMouse GetEvent(BrainLinkToServiseDto brainLinkToServiseDto)
        {
            return Events.Find(x => x.current().input.HighBeta == brainLinkToServiseDto.input.HighBeta + -10);
        }

        public bool GetEvent(EventMouse e, BrainLinkToServiseDto b)
        {
            return e.current().input.LowBeta == b.input.LowBeta;
        }
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
        private Map map = new Map();

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

        public void check(BrainLinkToServiseDto brainLinkToServiseDto, Form1 form)
        {
            if (timer != null) { timer.Dispose(); }
            if (brainLinkToServiseDto.system.isUseMouse())
            {
                getEvent(brainLinkToServiseDto, form).EegDto.Add(brainLinkToServiseDto);
                iterator = iterator++;
                if (iterator > int.Parse(form.ResyncInterval.Text))
                {
                    form.resync();
                    iterator = 0;
                }
            }
            else
            {
                if (form.IsUseKey.Checked)
                {
                    var eventName = form.history.getEventNameBy(brainLinkToServiseDto, form);
                    if (eventName != null)
                    {
                        timer = new System.Threading.Timer(playKey, eventName, 0, 10);
                    }
                }
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

        public void play(EventMouse eventMouse, int senc)
        {
            Console.WriteLine("count eventList: " + eventMouse.EegDto.Count);
            if (eventMouse.EegDto.Count != 0)
            {
                Console.WriteLine("event: " + eventMouse.current().input.ToString());

                var sencX = eventMouse.current().system.toX;
                var sencY = eventMouse.current().system.toY;

                if (senc > 0)
                {
                    sencX = eventMouse.current().system.toX / senc;
                    sencY = eventMouse.current().system.toY / senc;
                }

                int screenWidth = InternalGetSystemMetrics(0);
                int screenHeight = InternalGetSystemMetrics(1);

                // Mickey X coordinate
                //int mic_x = (int)System.Math.Round((Cursor.Position.X + sencX) * 65536.0 / screenWidth);
                // Mickey Y coordinate
                //int mic_y = (int)System.Math.Round((Cursor.Position.Y + sencY) * 65536.0 / screenHeight);

                // 0x0001 | 0x8000: Move + Absolute position
                //Mouse_Event(0x0001 | 0x8000, mic_x, mic_y, 0, 0);
                Cursor.Position = new Point(Cursor.Position.X + sencX, Cursor.Position.Y + sencY);
            }
        }


        public EventMouse getEvent(BrainLinkToServiseDto m, Form1 form)
        {
            Console.WriteLine("map count: " + map.Count + " Meditationt: " + m.input.Meditation);

            var newMap = map.getBy(m, form);
            if (newMap.Count == 0) return new EventMouse();

            return newMap.First();
        }


        public void saveMap(Map map1)
        {
            map = map1;
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


    [Serializable]
    public class EegHistoryModel
    {
        public int Attention { get; set; }
        public int Meditation { get; set; }
        public int Signal { get; set; }
        public int Delta { get; set; }
        public int Theta { get; set; }
        public int LowAlpha { get; set; }
        public int HighAlpha { get; set; }
        public int LowBeta { get; set; }
        public int HighBeta { get; set; }
        public int LowGamma { get; set; }
        public int HighGamma { get; set; }
        public string EventName { get; set; }

        public static EegHistoryModel getFromDto(BrainLinkToServiseDto dto)
        {
            return new EegHistoryModel
            {
                Attention = dto.input.Attention,
                Meditation = dto.input.Meditation,
                Signal = dto.input.Signal,
                Delta = dto.input.Delta,
                Theta = dto.input.Theta,
                LowAlpha = dto.input.LowAlpha,
                HighAlpha = dto.input.HighAlpha,
                LowBeta = dto.input.LowBeta,
                HighBeta = dto.input.HighBeta,
                LowGamma = dto.input.LowGamma,
                HighGamma = dto.input.HighGamma,
                EventName = dto.eventName,
            };
        }
    }


    [Serializable]
    public class Config
    {
        public int Attention { get; set; }
        public int Meditation { get; set; }
        public int Signal { get; set; }
        public int Delta { get; set; }
        public int Theta { get; set; }
        public int LowAlpha { get; set; }
        public int HighAlpha { get; set; }
        public int LowBeta { get; set; }
        public int HighBeta { get; set; }
        public int LowGamma { get; set; }
        public int HighGamma { get; set; }
        
        public static Config GetConfig(Form1 form)
        {
            Config config = new Config();
            config.Attention = int.Parse(form.textBoxAttention.Text);
            config.Meditation = int.Parse(form.textBoxMeditation.Text);
            config.Delta = int.Parse(form.textBoxDelta.Text);
            config.Theta = int.Parse(form.textBoxTheta.Text);
            config.LowAlpha = int.Parse(form.textBoxLowAlpha.Text);
            config.HighAlpha = int.Parse(form.textBoxHighAlpha.Text);
            config.LowBeta = int.Parse(form.textBoxLowBeta.Text);
            config.HighBeta = int.Parse(form.textBoxHighBeta.Text);
            config.LowGamma = int.Parse(form.textBoxLowGamma.Text);
            config.HighGamma = int.Parse(form.textBoxHighGamma.Text);
            return config;
        }


        public void set(Form1 form)
        {
            form.textBoxAttention.Text = this.Attention.ToString();
            form.textBoxMeditation.Text = this.Meditation.ToString();
            form.textBoxDelta.Text = this.Delta.ToString();
            form.textBoxTheta.Text = this.Theta.ToString();
            form.textBoxLowAlpha.Text = this.LowAlpha.ToString();
            form.textBoxHighAlpha.Text = this.HighAlpha.ToString();
            form.textBoxLowBeta.Text = this.LowBeta.ToString();
            form.textBoxHighBeta.Text = this.HighBeta.ToString();
            form.textBoxLowGamma.Text = this.LowGamma.ToString();
            form.textBoxHighGamma.Text = this.HighGamma.ToString();
        }
    }
}
