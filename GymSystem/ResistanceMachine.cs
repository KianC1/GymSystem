using System;
using System.Collections.Generic;
using System.Text;

namespace GymSystem
{
    internal class ResistanceMachine
    {

        public class resistanceMachine : Equipment
        {
            // Private properties
            private int weightStackMax;

            // Public Properties
            public int WeightStackMax
            {
                get { return weightStackMax; }
                set { weightStackMax = value; }
            }
            // Parameterised Constructor
            public resistanceMachine(int equipmentId, string name, bool isAvailable, int weightMaxStack)
                : base(equipmentId, name, isAvailable)
            {
                this.weightStackMax = weightMaxStack;
            }

        }
    }
}
