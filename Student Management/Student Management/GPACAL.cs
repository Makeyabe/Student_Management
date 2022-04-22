using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    internal class GPACAL
    {
        internal class GPACal
        {
            private double sum = 0;
            private int n = 0;
            private double max = 0;
            private double min = 4;
            private string maxname = string.Empty; // ""
            private string minname = string.Empty; // ""
            private string alldata = string.Empty; // ""

            /// <summary>
            /// Add new GPA to class
            /// </summary>
            /// <param name="gpa">gpa score</param>
            public void addGPA(double gpa, string name)
            {
                this.sum += gpa;
                this.n++;
                this.alldata += name + " " + gpa + Environment.NewLine;

                if (this.max < gpa)
                {
                    this.max = gpa;
                    this.maxname = name;


                }
                if (this.min > gpa)
                {
                    this.min = gpa;
                    this.minname = name;

                }
            }
            internal void addGPA(double dInput, object name)
            {
                throw new NotImplementedException();
            }
            /// <summary>
            /// Return GPAx of class
            /// </summary>
            /// <returns>GPAx</returns>
            public double gatGPAx()
            {
                double result = this.sum / this.n;
                return result;
            }
            public double getMax()
            {
                return this.max;
            }

            public double gatMin()
            {
                return this.min;
            }
        }
    }
}
