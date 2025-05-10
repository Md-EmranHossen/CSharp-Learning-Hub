using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Example
{
    public class Pen
    {
        private string _inkColor;
        private string _model;
        private int _inkAmount;
        public string Somthing { get; set; }

        public int InkAmount
        {
            get
            {
                if(_inkAmount < 0)
                {
                    _inkAmount = 0;
                }
                return _inkAmount;
            }
            set
            {
                InkAmount = value;
            }
        }

        public Pen(string inkColour, string model, int inkAmount)
        {
            _inkAmount = inkAmount;
            _model = model;
            _inkColor = inkColour;
        }



        public void Write(string text)
        {
            if (_inkAmount >= text.Length)
            {
                Console.WriteLine(text);
                _inkAmount -= text.Length;
            }
        }
    }
}
