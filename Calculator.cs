using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMCalculator
{
    class Calculator
    {
        //linked to auto generated constructor below
        private decimal oneRM;
        private decimal twoRM;
        private decimal threeRM;
        private decimal fourRM;
        private decimal fiveRM;
        private decimal sixRM;
        private decimal sevenRM;
        private decimal eightRM;
        private decimal nineRM;
        private decimal tenRM;
        private decimal fifteenRM;
        private decimal twentyRM;


        //date of max lift

        //public string Maxday { get; }

        public string Movement { get; set; }

        public decimal OneRM
        {
            get { return oneRM; }
            set { if (value >= 0) oneRM = value; }
        }
        
        public decimal TwoRM
        {
            get { return twoRM; }
            set { if (value >= 0) twoRM = value; }
        }
        
        public decimal ThreeRM
        {
            get { return threeRM; }
            set { if (value >= 0) threeRM = value; }
        }

        public decimal FourRM
        {
            get { return fourRM; }
            set { if (value >= 0) fourRM = value; }
        }

        public decimal FiveRM
        {
            get { return fiveRM; }
            set { if (value >= 0) fiveRM = value; }
        }

        public decimal SixRM
        {
            get { return sixRM; }
            set { if (value >= 0) sixRM = value; }
        }

        public decimal SevenRM
        {
            get { return sevenRM; }
            set { if (value >= 0) sevenRM = value; }
        }

        public decimal EightRM
        {
            get { return eightRM; }
            set { if (value >= 0) eightRM = value; }
        }

        public decimal NineRM
        {
            get { return nineRM; }
            set { if (value >= 0) nineRM = value; }
        }

        public decimal TenRM
        {
            get { return tenRM; }
            set { if (value >= 0) tenRM = value; }
        }

        public decimal FifteenRM
        {
            get { return fifteenRM; }
            set { if (value >= 0) fifteenRM = value; }
        }

        public decimal TwentyRM
        {
            get { return twentyRM; }
            set { if (value >= 0) twentyRM = value; }
        }

        
        //constructor
        //takes data from weight and reps in GUI
        //sends data to array in FileIO

        //auto generated constructor
        public Calculator(decimal one, decimal two, decimal three, decimal four, decimal five, decimal six, decimal seven, decimal eight, decimal nine, decimal ten, decimal fifteen, decimal twenty)
        {
            this.oneRM = one;
            this.twoRM = two;
            this.threeRM = three;
            this.fourRM = four;
            this.fiveRM = five;
            this.sixRM = six;
            this.sevenRM = seven;
            this.eightRM = eight;
            this.nineRM = nine;
            this.tenRM = ten;
            this.fifteenRM = fifteen;
            this.twentyRM = twenty;
        }

        //output data to list box
        //public override string ToString()
        //{
        //    return "Movement: " + Movement + " " + oneRM.ToString();
        //    //need 
        //}

    }
}
