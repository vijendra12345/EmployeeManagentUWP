using BasicMvvm;
using BasicMvvm.Commands;
using EmployeeManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class MainViewModel : BindableBase
    {
        private Employee _myEmployee;
        public  DelegateCommand SaveCommand { get; set; }
        public MainViewModel()
        {
            MyEmployee = new Employee();
            SaveCommand = new DelegateCommand(OnSaveExecute);
        }

        private void OnSaveExecute()
        {
            var sr = new DataService();
            sr.Save(MyEmployee);
        }

        public Employee MyEmployee
        {
            get { return _myEmployee; }
            set
            {
                _myEmployee = value;
                OnPropertyChanged();
            }
        }

    }
}
