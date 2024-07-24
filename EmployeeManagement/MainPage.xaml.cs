using EmployeeManagement.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EmployeeManagement
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            ViewModel = new MainViewModel();
            this.DataContext = ViewModel;
        }

        //private void btnsv_Click(object sender, RoutedEventArgs e)
        //{
        //    Employee emp=new Employee();
        //  Thread.Sleep(10000);
        //    emp.Id =  Guid.NewGuid();
        //    emp.FirstName = txtfn.Text;   
        //    emp.LastName = txtln.Text;
        //    emp.Phone = txtph.Text;

        //    emp.Email=txtem.Text;
        //    emp.City=txtcty.Text;
        //    emp.Address=txtha.Text;
        //    emp.State=cmbost.Text;
        //    emp.MaritalStatus = cmboms.Text;

        //    DataService dataService = new DataService();
        //    dataService.Save(emp);

        //}
        


    }
}
