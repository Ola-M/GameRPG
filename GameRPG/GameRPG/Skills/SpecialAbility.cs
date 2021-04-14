using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRPG.Characters
{
    class SpecialAbility
    {
        private string _name;
        private int _pointsAttack;

        public SpecialAbility()
        {

        }

        public SpecialAbility( string name , int pointsAttack)
        {
            _name = name;
            _pointsAttack = pointsAttack;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int PointsAttack
        {
            get { return _pointsAttack; }
            set { _pointsAttack = value; }
        }

    }
}
