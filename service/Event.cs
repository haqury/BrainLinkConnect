
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrainLinkSDK_Windows;
using static BrainLinkConnect.service.Map;

namespace BrainLinkConnect.service
{

    [Serializable]


    public class Map : List<EventMouse>
    {
        class CurrentBoxes
        {
            public CurrentBoxes(CheckBox checkBox, TextBox textBox)
            {
                this.checkBox = checkBox;
                this.textBox = textBox;
            }

            public CheckBox checkBox;
            public TextBox textBox;
        }

        private List<System.Windows.Forms.CheckBox> configParams;

        int infelicity = 10;


        public EventMouse GetEvent(BrainLinkToServiseDto brainLinkToServiseDto)
        {
            return this.Find(x => (
                                x.current().input.HighBeta <= brainLinkToServiseDto.input.HighBeta + infelicity)
                              && (brainLinkToServiseDto.input.HighBeta - infelicity <= x.current().input.HighBeta)
            );
        }

        public List<EventMouse> getBy(BrainLinkToServiseDto brainLinkToServiseDto, Form1 f)
        {
            var boxes = new List<CurrentBoxes>{
                new CurrentBoxes(f.checkBoxAttention, f.textBoxAttention),
                new CurrentBoxes(f.checkBoxDelta, f.textBoxDelta),
                new CurrentBoxes(f.checkBoxMeditation, f.textBoxMeditation),
                new CurrentBoxes(f.checkBoxTheta, f.textBoxTheta),
                new CurrentBoxes(f.checkBoxHighBeta, f.textBoxHighBeta),
                new CurrentBoxes(f.checkBoxLowBeta, f.textBoxLowBeta),
                new CurrentBoxes(f.checkBoxHighAlpha, f.textBoxHighAlpha),
                new CurrentBoxes(f.checkBoxLowAlpha, f.textBoxLowAlpha),
                new CurrentBoxes(f.checkBoxHighGamma, f.textBoxHighGamma),
                new CurrentBoxes(f.checkBoxLowGamma, f.textBoxLowGamma),
            };

            IEnumerable<EventMouse> result = this.AsEnumerable();
            foreach (var b in boxes)
            {
                if (b.checkBox.Checked)
                {
                    infelicity = 0;
                    if (b.textBox.Text != "")
                    {
                        var t = b.textBox.Text;
                        infelicity = int.Parse(t);
                    }
                    result = this.FindAll(x => (
                        x.current().input.HighBeta <= brainLinkToServiseDto.input.HighBeta + infelicity)
                            && (brainLinkToServiseDto.input.HighBeta - infelicity <= x.current().input.HighBeta)
                    );
                }
            }
            return result.ToList();
        }
    }

    public class History : List<EegHistoryModel>
    {
        class CurrentBoxes
        {
            public CurrentBoxes(CheckBox checkBox, TextBox textBox)
            {
                this.checkBox = checkBox;
                this.textBox = textBox;
            }

            public CheckBox checkBox;
            public TextBox textBox;
        }

        public string getEventNameBy(BrainLinkToServiseDto brainLinkToServiseDto, Form1 f)
        {
            var boxes = new List<CurrentBoxes>{
                new CurrentBoxes(f.checkBoxAttention, f.textBoxAttention),
                new CurrentBoxes(f.checkBoxDelta, f.textBoxDelta),
                new CurrentBoxes(f.checkBoxMeditation, f.textBoxMeditation),
                new CurrentBoxes(f.checkBoxTheta, f.textBoxTheta),
                new CurrentBoxes(f.checkBoxHighBeta, f.textBoxHighBeta),
                new CurrentBoxes(f.checkBoxLowBeta, f.textBoxLowBeta),
                new CurrentBoxes(f.checkBoxHighAlpha, f.textBoxHighAlpha),
                new CurrentBoxes(f.checkBoxLowAlpha, f.textBoxLowAlpha),
                new CurrentBoxes(f.checkBoxHighGamma, f.textBoxHighGamma),
                new CurrentBoxes(f.checkBoxLowGamma, f.textBoxLowGamma),
            };


            var result = this.ToList();
            if (f.checkBoxAttention.Checked)
            {
                var infelicity = 0;
                if (f.textBoxAttention.Text != "")
                {
                    var t = f.textBoxAttention.Text;
                    infelicity = int.Parse(t);
                }
                result = this.FindAll(x => (
                    x.Attention <= brainLinkToServiseDto.input.Attention + infelicity)
                       && (brainLinkToServiseDto.input.Attention - infelicity <= x.Attention)
                );
            }
            if (f.checkBoxMeditation.Checked)
            {
                var infelicity = 0;
                if (f.textBoxMeditation.Text != "")
                {
                    var t = f.textBoxMeditation.Text;
                    infelicity = int.Parse(t);
                }
                result = this.FindAll(x => (
                    x.Meditation <= brainLinkToServiseDto.input.Meditation + infelicity)
                       && (brainLinkToServiseDto.input.Meditation - infelicity <= x.Meditation)
                );
            }
            if (f.checkBoxDelta.Checked)
            {
                var infelicity = 0;
                if (f.textBoxDelta.Text != "")
                {
                    var t = f.textBoxDelta.Text;
                    infelicity = int.Parse(t);
                }
                result = this.FindAll(x => (
                    x.Delta <= brainLinkToServiseDto.input.Delta + infelicity)
                       && (brainLinkToServiseDto.input.Delta - infelicity <= x.Delta)
                );
            }
            if (f.checkBoxTheta.Checked)
            {
                var infelicity = 0;
                if (f.textBoxTheta.Text != "")
                {
                    var t = f.textBoxTheta.Text;
                    infelicity = int.Parse(t);
                }
                result = this.FindAll(x => (
                    x.Theta <= brainLinkToServiseDto.input.Theta + infelicity)
                       && (brainLinkToServiseDto.input.Theta - infelicity <= x.Theta)
                );
            }
            if (f.checkBoxHighBeta.Checked)
            {
                var infelicity = 0;
                if (f.textBoxHighBeta.Text != "")
                {
                    var t = f.textBoxHighBeta.Text;
                    infelicity = int.Parse(t);
                }
                result = this.FindAll(x => (
                    x.HighBeta <= brainLinkToServiseDto.input.HighBeta + infelicity)
                       && (brainLinkToServiseDto.input.HighBeta - infelicity <= x.HighBeta)
                );
            }
            if (f.checkBoxLowBeta.Checked)
            {
                var infelicity = 0;
                if (f.textBoxLowBeta.Text != "")
                {
                    var t = f.textBoxLowBeta.Text;
                    infelicity = int.Parse(t);
                }
                result = this.FindAll(x => (
                    x.LowBeta <= brainLinkToServiseDto.input.LowBeta + infelicity)
                       && (brainLinkToServiseDto.input.LowBeta - infelicity <= x.LowBeta)
                );
            }
            if (f.checkBoxHighAlpha.Checked)
            {
                var infelicity = 0;
                if (f.textBoxHighAlpha.Text != "")
                {
                    var t = f.textBoxHighAlpha.Text;
                    infelicity = int.Parse(t);
                }
                result = this.FindAll(x => (
                    x.HighAlpha <= brainLinkToServiseDto.input.HighAlpha + infelicity)
                       && (brainLinkToServiseDto.input.HighAlpha - infelicity <= x.HighAlpha)
                );
            }
            if (f.checkBoxLowAlpha.Checked)
            {
                var infelicity = 0;
                if (f.textBoxLowAlpha.Text != "")
                {
                    var t = f.textBoxLowAlpha.Text;
                    infelicity = int.Parse(t);
                }
                result = this.FindAll(x => (
                    x.LowAlpha <= brainLinkToServiseDto.input.LowAlpha + infelicity)
                       && (brainLinkToServiseDto.input.LowAlpha - infelicity <= x.LowAlpha)
                );
            }
            if (f.checkBoxHighGamma.Checked)
            {
                var infelicity = 0;
                if (f.textBoxHighGamma.Text != "")
                {
                    var t = f.textBoxHighGamma.Text;
                    infelicity = int.Parse(t);
                }
                result = this.FindAll(x => (
                    x.HighGamma <= brainLinkToServiseDto.input.HighGamma + infelicity)
                       && (brainLinkToServiseDto.input.HighGamma - infelicity <= x.HighGamma)
                );
            }
            if (f.checkBoxLowGamma.Checked)
            {
                var infelicity = 0;
                if (f.textBoxLowGamma.Text != "")
                {
                    var t = f.textBoxLowGamma.Text;
                    infelicity = int.Parse(t);
                }
                result = this.FindAll(x => (
                    x.LowGamma <= brainLinkToServiseDto.input.LowGamma + infelicity)
                       && (brainLinkToServiseDto.input.LowGamma - infelicity <= x.LowGamma)
                );
            }
            if (result.Count != 0)
            {
                return result[0].EventName;
            } else
            {
                return "";
            }
        }
    }

        public class EventMouse
    {
        public List<BrainLinkToServiseDto> EegDto = new List<BrainLinkToServiseDto>();
        private int currentLinkId = 0;

        public BrainLinkToServiseDto current()
        {
            return EegDto[0];
        }

        public bool isUse()
        {
            return EegDto.Last().system.isUseMouse();
        }

        public int count()
        {
            return EegDto.Count;
        }
    }
}
