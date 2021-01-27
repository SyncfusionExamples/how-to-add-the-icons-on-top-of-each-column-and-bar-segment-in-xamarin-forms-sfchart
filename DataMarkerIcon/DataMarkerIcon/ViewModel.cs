using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataMarkerIcon
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<Model>
            {
                new Model("Jan", 40),
                new Model("Feb", 60),
                new Model("Mar", -30),
                new Model("Apr", 40),
                new Model("May", -70),
                new Model("Jun", -50)
            };
        }
    }
}
