using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//dlls
using Urbaniak.PW_project.CORE;
using Urbaniak.PW_project.INTERFACES;

namespace Urbaniak.PW_project.UI.ViewModels
{
    public abstract class ListViewModelBase<T> : INotifyPropertyChanged
    {
        private readonly IObjectBL<T> _objBL;
        private T _current;

        public ObservableCollection<T> List { get; set; }
        public T Current
        {
            get { return _current; }
            set
            {
                _current = value;
                OnPropertyChanged(nameof(Current));
            }
        }

        public ListViewModelBase(IObjectBL<T> objBL)
        {
            _objBL = objBL;
            List = new ObservableCollection<T>(_objBL.GetAll());
            CreateCommand = new RelayCommand(o => CreateObject());
            EditCommand = new RelayCommand(o => Edit());
            SaveCommand = new RelayCommand(o => SaveChanges());
            RemoveCommand = new RelayCommand(o => Remove());
        }

        #region Commands

        public RelayCommand CreateCommand { get; }
        public RelayCommand EditCommand { get; }
        public RelayCommand SaveCommand { get; }
        public RelayCommand RemoveCommand { get; }

        protected abstract void CreateObject();
        protected abstract void SaveChanges();
        protected abstract void Remove();
        protected abstract void Edit();

        protected void UpdateList()
        {
            List.Clear();
            _objBL.GetAll().ForEach(obj => List.Add(obj));
            OnPropertyChanged(nameof(List));
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
