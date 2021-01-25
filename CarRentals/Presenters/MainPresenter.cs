using CarRentals;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentals.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        IMainView _mainView;

        public MainPresenter(IMainView mainView)
        {
            _mainView = mainView;
        }

        public IMainView GetMainView()
        {
            return _mainView;
        }

    }
}
