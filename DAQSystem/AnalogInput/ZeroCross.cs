using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAQmx
{
    public enum direction
    {
        either,
        minus_plus,
        plus_minus

    }

     public class ZeroCross
    {
        private bool firstTimeTouse;
        //上一次数值
        private double lastValue;
        //是否出现交叉
        private bool crossing;
        //偏置数值
        private double offSet;
        //初始化
        public ZeroCross()
        {
            firstTimeTouse = true;
            crossing = false;
            offSet = 0;
        }
        //初始化同时创建偏置数值
        public ZeroCross(double offset)
        { 
            firstTimeTouse = true;
            crossing = false;
            offSet = offset;
        }

        public void initialize()
        {
            firstTimeTouse = true;
            crossing = false;

        }

        public bool judgeCrossing(double inputData,direction direction)
        {
            bool crossingResult;
            if (firstTimeTouse)
            {
                lastValue = inputData;
                crossingResult = false;
                firstTimeTouse = false;
            }
            else
            {
                switch (direction)
                {
                    case direction.either:
                        crossingResult = (lastValue - offSet) * (inputData - offSet) <= 0;
                        break;
                    case direction.minus_plus:
                        crossingResult = lastValue <= offSet && inputData > offSet;
                        break;
                    case direction.plus_minus:
                        crossingResult = lastValue > offSet && inputData <= offSet;
                        break;
                    default:
                        crossingResult = false;
                        break;
                }
                lastValue = inputData;
            }
            return crossingResult;
        
        }

    }
}
