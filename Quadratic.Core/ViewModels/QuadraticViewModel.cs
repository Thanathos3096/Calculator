using MvvmCross.Commands;
using MvvmCross.ViewModels;
using Quadratic.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Quadratic.Core.ViewModels
{
    public class QuadraticViewModel : MvxViewModel
    {
        private readonly IQuadraticService _quadraticService;
        private int _a;
        private int _b;
        private int _c;
        private double _resultx1;
        private double _resultx2;
        private MvxCommand _calculateCommand;

        public QuadraticViewModel(IQuadraticService quadraticService)
        {
            _quadraticService = quadraticService;
        }
        public int A
        {
            get => _a;
            set => SetProperty(ref _a, value);
        }
        public int B
        {
            get => _b;
            set => SetProperty(ref _b, value);
        }
        public int C
        {
            get => _c;
            set => SetProperty(ref _c, value);
        }

        public double Resultx1
        {

            get => _resultx1;
            set => SetProperty(ref _resultx1, value);

        }
        public double Resultx2
        {

            get => _resultx2;
            set => SetProperty(ref _resultx2, value);

        }
        public async override Task Initialize()
        {
            await base.Initialize();
            A = 1;
            B = 3;
            C = 2;

            Calculate();
        }
        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }
        }
        private void Calculate()
        {
            Resultx1 = _quadraticService.GetQuadraticpos(A, B, C);
            Resultx2 = _quadraticService.GetQuadraticneg(A, B, C);
        }
    }
}
