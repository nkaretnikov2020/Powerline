using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powerline
{
    public class Truck : Vehicle
    {
        byte _DeteriorationPercentagePerFixWeight = 4;
        int _FixWeight = 200;
        int _LoadCapacity = 20000;
        int _CurrentLoad = 0;
        public int CurrentLoad
        {
            get { return _CurrentLoad; }
            set
            {
                if (value > _LoadCapacity || value < 0)
                {
                    Console.WriteLine("Cannot set CurrentLoad to the value specified {0} \n " +
                        "It should be greater or equal to 0 or less than {1} \n" +
                        "Setting to just 0", value, _CurrentLoad);
                    _CurrentLoad = 1;
                }
                else
                {
                    _CurrentLoad = value;
                }
            }
        }
        public override float DistanceLeft()
        {
            float _Result;
            _Result = base.DistanceLeft() * (100 - _CurrentLoad / _FixWeight * _DeteriorationPercentagePerFixWeight) / 100;
            return _Result;
        }
         public override float MinutesToFullstop()
        {
            float _MinutesToFullstop;
            float _DistanceLeft;
            _DistanceLeft = DistanceLeft();
            _MinutesToFullstop = _DistanceLeft / _CurrentSpeed * 60;
            return _MinutesToFullstop;
        }
}
}