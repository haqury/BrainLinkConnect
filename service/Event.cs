
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrainLinkConnect.service
{

    [Serializable]

    public class Map : List<EventMouse>
    {

        private List<System.Windows.Forms.CheckBox> configParams;

        int infelicity = 10;


        public EventMouse GetEvent(BrainLinkToServiseDto brainLinkToServiseDto)
        {
            return this.Find(x => (
                                x.current().input.HighBeta <= brainLinkToServiseDto.input.HighBeta + infelicity)
                              && (brainLinkToServiseDto.input.HighBeta - infelicity <= x.current().input.HighBeta)
            );
        }

        class CurrentBoxes {
            public CurrentBoxes(CheckBox checkBox, TextBox textBox)
            {
                this.checkBox = checkBox;
                this.textBox = textBox;
            }

            public CheckBox checkBox;
            public TextBox textBox;
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
