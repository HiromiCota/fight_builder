using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fight_builder
{
    public enum Modifier
    {
        Head,
        Butt,
        Haft
    }

    public class Attack
    {
        public Limb Limb { get; set; }
        public Modifier Modifier { get; set; }
        public TargetNumber TargetNumber { get; set; }

        public Attack (Limb limb, Modifier modifier, TargetNumber targetNumber)
        {
            this.Limb = Limb.RightHand;
            this.Modifier = Modifier.Head;
            this.TargetNumber = TargetNumber.One;
        }
    }
}
