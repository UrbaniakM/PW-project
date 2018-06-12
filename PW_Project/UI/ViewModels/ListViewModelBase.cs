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
    public abstract class ListViewModelBase<T, WrapperT> : INotifyPropertyChanged where WrapperT : ViewModelBase
    {
        protected readonly IObjectBL<T> _objBL;
        protected WrapperT _current;

        public ObservableCollection<WrapperT> List { get; set; }
        public WrapperT Current
        {
            get { return _current; }
            set
            {
                _current = value;
                OnPropertyChanged(nameof(Current));
            }
        }

        protected WrapperT _previous;

        private bool _isEdited;

        public bool IsNotEdited
        {
            get { return !_isEdited; }
        }

        public bool IsEdited
        {
            get { return _isEdited; }
            set
            {
                _isEdited = value;
                OnPropertyChanged(nameof(IsEdited));
                OnPropertyChanged(nameof(IsNotEdited));
            }
        }

        public ListViewModelBase(IObjectBL<T> objBL)
        {
            _objBL = objBL;
            List = new ObservableCollection<WrapperT>();
            UpdateList();
            CreateCommand = new RelayCommand(o => CreateObject(), o => !IsEdited);
            EditCommand = new RelayCommand(o => Edit(), o => !IsEdited && Current != null);
            SaveCommand = new RelayCommand(o => SaveChanges(), o => IsEdited && Current != null && !Current.HasErrors);
            RemoveCommand = new RelayCommand(o => Remove(), o => Current != null && !IsEdited);
            CancelCommand = new RelayCommand(o => Cancel(), o => IsEdited);
        }

        protected abstract void UpdateList();

        #region Commands

        public RelayCommand CreateCommand { get; }
        public RelayCommand EditCommand { get; }
        public RelayCommand SaveCommand { get; }
        public RelayCommand RemoveCommand { get; }
        public RelayCommand CancelCommand { get; }

        protected abstract void CreateObject();
        protected abstract void SaveChanges();
        protected abstract void Remove();
        protected abstract void Edit();
        protected abstract void Cancel();

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
