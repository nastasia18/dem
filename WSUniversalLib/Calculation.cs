using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WSUniversalLib
{
    public class Calculation
    {
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            double coefType, coef;
            if (productType == 1)
            {
                coefType = 1.1;
            }
            else if (productType == 2)
            {
                coefType = 2.5;
            }
            else if (productType == 3)
            {
                coefType = 8.43;
            }
            else
            {
                return -1;
            }

            if (materialType == 1)
            {
                coef = 0.3;
            }
            else if (materialType == 2)
            {
                coef = 0.12;
            }
            else
            {
                return -1;
            }

            double countMaterial = count * width * length * coefType;
            double marriage = countMaterial * coef / 100;
            double result = countMaterial + marriage;
            return (int)result;
        }
    }
}