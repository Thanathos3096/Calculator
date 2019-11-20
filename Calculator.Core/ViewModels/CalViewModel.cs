using Calculator.Core.Services;
using MvvmCross.ViewModels;
using System.Threading.Tasks;

namespace Calculator.Core.ViewModels
{
    public class CalViewModel : MvxViewModel
    {
        private readonly ICalculatorService _calculatorService;
        private decimal _subTotal;
        private int _generosity;
        private decimal _tip;

        public CalViewModel(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        public decimal SubTotal
        {
            get => _subTotal;
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);
                Recalculate();
            }
        }

        public decimal Tip
        {
            get => _tip;
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        public int Generosity
        {
            get => _generosity;
            set
            {
                _generosity = value;
                RaisePropertyChanged(() => Generosity);
                Recalculate();
            }
        }
        public override async Task Initialize()
        {
            await base.Initialize();

            SubTotal = 100;
            Generosity = 10;
            Recalculate();
        }
        private void Recalculate()
        {
            Tip = _calculatorService.TipAmount(SubTotal, Generosity);
        }
    }
}
