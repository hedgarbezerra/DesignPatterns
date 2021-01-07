using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class PointInner
    {
        private double x, y;

        private PointInner(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static class Factory
        {
            public static PointInner NewPolarPoint(double rho, double theta)
            {
                return new PointInner(rho * 12, Math.Sqrt(theta));
            }

            public static PointInner NewCartesianPoint(double x, double y)
            {
                return new PointInner(x, y);
            }
        }
    }
}
