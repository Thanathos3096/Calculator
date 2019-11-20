
using Android.App;
using Android.OS;
using Calculator.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace Calculator.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class CalculatorView : MvxActivity<CalViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CalculatorPage);
        }
    }
}