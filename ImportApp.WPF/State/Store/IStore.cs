using CommunityToolkit.Mvvm.Input;
using ImportApp.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ImportApp.WPF.State.Store
{
    public enum StoreType
    {
        Articles,
        Economato
    }


    public interface IStore
    {
        BaseViewModel? CurrentDataGrid { get; set; }
        //ICommand UpdateCurrentViewModelCommand { get; }
    }
}
