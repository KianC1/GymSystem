using System;
using System.Collections.Generic;
using System.Text;

namespace GymSystem
{
    internal class Equipment
    {
        // Private properties
        private int equipmentId;
        private string name;
        private bool isAvailable = false;

        // Public Properties
        public int EquipmentId
        {
            get { return equipmentId; }
            set { equipmentId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        // Parameterised Constructor
        public Equipment(int equipmentId, string name, bool isAvailable)
        {
            this.equipmentId = equipmentId;
            this.name = name;
            this.isAvailable = isAvailable;
        }

    }

}
