using Prism.Mvvm;
using System;

namespace ModuleJw.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        private String _title = "Hello Jw";
        public String Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }
    }
}
