using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHCProject
{
    public class ViewModel
    {
        public List<AnualValues> Data { get; set; }
        public List<MonthValues> DataTMonth { get; set; }
        public List<AnualValues> DataHumidity { get; set; }
        public List<MonthValues> DataHMonth { get; set; }
        public List<AnualValues> DataEE { get; set; }
        public List<MonthValues> DataEEMonth { get; set; }
        public List<AnualValues> DataCO2 { get; set; }
        public List<MonthValues> DataCO2Month { get; set; }
        public ViewModel()
        {
            Data = new List<AnualValues>()
            {
                new AnualValues {Month = "JAN", Value = 18},
                new AnualValues {Month = "FEB", Value = 18.5},
                new AnualValues {Month = "MAR", Value = 19},
                new AnualValues {Month = "APR", Value = 20.3},
                new AnualValues {Month = "MAY", Value = 22}
            };

            DataTMonth = new List<MonthValues>()
            {
                new MonthValues {Day = "1", Value = 18},
                new MonthValues {Day = "2", Value = 18.5},
                new MonthValues {Day = "3", Value = 19},
                new MonthValues {Day = "4", Value = 20.3},
                new MonthValues {Day = "5", Value = 22},
                new MonthValues {Day = "6", Value = 21},
                new MonthValues {Day = "7", Value = 20.3},
                new MonthValues {Day = "8", Value = 24},
                new MonthValues {Day = "9", Value = 25},
                new MonthValues {Day = "10", Value = 22},
                new MonthValues {Day = "11", Value = 19},
                new MonthValues {Day = "12", Value = 19.5},
                new MonthValues {Day = "13", Value = 20.7},
                new MonthValues {Day = "14", Value = 20.3},
                new MonthValues {Day = "15", Value = 22}
            };

            DataHMonth = new List<MonthValues>()
            {
                new MonthValues {Day = "1", Value = 52},
                new MonthValues {Day = "2", Value = 50},
                new MonthValues {Day = "3", Value = 53},
                new MonthValues {Day = "4", Value = 48},
                new MonthValues {Day = "5", Value = 50.3},
                new MonthValues {Day = "6", Value = 49},
                new MonthValues {Day = "7", Value = 46},
                new MonthValues {Day = "8", Value = 40},
                new MonthValues {Day = "9", Value = 42},
                new MonthValues {Day = "10", Value = 44},
                new MonthValues {Day = "11", Value = 38},
                new MonthValues {Day = "12", Value = 35},
                new MonthValues {Day = "13", Value = 32},
                new MonthValues {Day = "14", Value = 37},
                new MonthValues {Day = "15", Value = 34}
            };

            DataCO2Month = new List<MonthValues>()
            {
                new MonthValues {Day = "1", Value = 992},
                new MonthValues {Day = "2", Value = 1050},
                new MonthValues {Day = "3", Value = 1053},
                new MonthValues {Day = "4", Value = 1048},
                new MonthValues {Day = "5", Value = 980.3},
                new MonthValues {Day = "6", Value = 949},
                new MonthValues {Day = "7", Value = 976},
                new MonthValues {Day = "8", Value = 1000},
                new MonthValues {Day = "9", Value = 1022},
                new MonthValues {Day = "10", Value = 1044},
                new MonthValues {Day = "11", Value = 1038},
                new MonthValues {Day = "12", Value = 1025},
                new MonthValues {Day = "13", Value = 1002},
                new MonthValues {Day = "14", Value = 1017},
                new MonthValues {Day = "15", Value = 1024}
            };

            DataHumidity = new List<AnualValues>()
            {
                new AnualValues {Month = "JAN", Value = 40},
                new AnualValues {Month = "FEB", Value = 49},
                new AnualValues {Month = "MAR", Value = 47},
                new AnualValues {Month = "APR", Value = 39},
                new AnualValues {Month = "MAY", Value = 35}
            };

            DataEE = new List<AnualValues>()
            {
                new AnualValues {Month = "JAN", Value = 350},
                new AnualValues {Month = "FEB", Value = 362},
                new AnualValues {Month = "MAR", Value = 359},
                new AnualValues {Month = "APR", Value = 380},
                new AnualValues {Month = "MAY", Value = 420}
            };

            DataEEMonth = new List<MonthValues>()
            {
                new MonthValues {Day = "1", Value = 20},
                new MonthValues {Day = "2", Value = 17},
                new MonthValues {Day = "3", Value = 23},
                new MonthValues {Day = "4", Value = 25},
                new MonthValues {Day = "5", Value = 26},
                new MonthValues {Day = "6", Value = 33},
                new MonthValues {Day = "7", Value = 19},
                new MonthValues {Day = "8", Value = 35},
                new MonthValues {Day = "9", Value = 29},
                new MonthValues {Day = "10", Value = 27},
                new MonthValues {Day = "11", Value = 15},
                new MonthValues {Day = "12", Value = 21},
                new MonthValues {Day = "13", Value = 30},
                new MonthValues {Day = "14", Value = 28},
                new MonthValues {Day = "15", Value = 10}
            };

            DataCO2 = new List<AnualValues>()
            {
                new AnualValues {Month = "JAN", Value = 950},
                new AnualValues {Month = "FEB", Value = 980},
                new AnualValues {Month = "MAR", Value = 925},
                new AnualValues {Month = "APR", Value = 1022},
                new AnualValues {Month = "MAY", Value = 1005}
            };
        }
    }
}
