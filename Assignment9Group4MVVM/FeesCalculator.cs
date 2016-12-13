using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9Group4MVVM
{
    class FeesCalculator : INotifyPropertyChanged
    {
        const int FEES_ALLEN = 1500;
        const int FEES_PIKE = 1600;
        const int FEES_FARTHING = 1800;
        const int FEES_UNIVERSITY = 2500;
        const int FEES_SEVENMEAL = 600;
        const int FEES_FORTEENMEAL = 1200;
        const int FEES_UNLIMITED = 1700;
        public bool AllenPrice
        {
            get { return _AllenPrice; }
            set { _AllenPrice = value; OnPropertyChanged(); }
        }
        private bool _AllenPrice;
        public bool PikePrice
        {
            get { return _PikePrice; }
            set { _PikePrice = value; OnPropertyChanged(); }
        }
        private bool _PikePrice;
        public bool FarthingPrice
        {
            get { return _FarthingPrice; }
            set { _FarthingPrice = value; OnPropertyChanged(); }
        }
        private bool _FarthingPrice;
        public bool UniversityPrice
        {
            get { return _UniversityPrice; }
            set { _UniversityPrice = value; OnPropertyChanged(); }
        }
        private bool _UniversityPrice;
        public bool SevenMealPrice
        {
            get { return _SevenMealPrice; }
            set { _SevenMealPrice = value; OnPropertyChanged(); }
        }
        private bool _SevenMealPrice;
        public bool ForteenMealPrice
        {
            get { return _ForteenMealPrice; }
            set { _ForteenMealPrice = value; OnPropertyChanged(); }
        }
        private bool _ForteenMealPrice;
        public bool UnlimitedMealPrice
        {
            get { return _UnlimitedMealPrice; }
            set { _UnlimitedMealPrice = value; OnPropertyChanged(); }
        }
        private bool _UnlimitedMealPrice;
        public int TotalFees
        {
            get { return _TotalFees; }
            set { _TotalFees = value;  OnPropertyChanged(); }
        }
        private int _TotalFees;

        public void GetTotalFees()
        {
            if (_AllenPrice)
            {
                if (_SevenMealPrice)
                {
                    _TotalFees = FEES_ALLEN + FEES_SEVENMEAL;
                    TotalFees = _TotalFees;
                }else if(_ForteenMealPrice)
                {
                    _TotalFees = FEES_ALLEN + FEES_FORTEENMEAL;
                    TotalFees = _TotalFees;
                }else
                {
                    _TotalFees = FEES_ALLEN + FEES_UNLIMITED;
                    TotalFees = _TotalFees;
                }
            }
            else if (_FarthingPrice)
            {
                if (_SevenMealPrice)
                {
                    _TotalFees = FEES_FARTHING + FEES_SEVENMEAL;
                    TotalFees = _TotalFees;
                }
                else if (_ForteenMealPrice)
                {
                    _TotalFees = FEES_FARTHING + FEES_FORTEENMEAL;
                    TotalFees = _TotalFees;
                }
                else
                {
                    _TotalFees = FEES_FARTHING + FEES_UNLIMITED;
                    TotalFees = _TotalFees;
                }
            }else if(_PikePrice)
            {
                if (_SevenMealPrice)
                {
                    _TotalFees = FEES_PIKE + FEES_SEVENMEAL;
                    TotalFees = _TotalFees;
                }
                else if (_ForteenMealPrice)
                {
                    _TotalFees = FEES_PIKE + FEES_FORTEENMEAL;
                    TotalFees = _TotalFees;
                }
                else
                {
                    _TotalFees = FEES_PIKE + FEES_UNLIMITED;
                    TotalFees = _TotalFees;
                }
            }else
            {
                if (_SevenMealPrice)
                {
                    _TotalFees = FEES_UNIVERSITY + FEES_SEVENMEAL;
                    TotalFees = _TotalFees;
                }
                else if (_ForteenMealPrice)
                {
                    _TotalFees = FEES_UNIVERSITY + FEES_FORTEENMEAL;
                    TotalFees = _TotalFees;
                }
                else
                {
                    _TotalFees = FEES_UNIVERSITY + FEES_UNLIMITED;
                    TotalFees = _TotalFees;
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
