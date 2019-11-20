﻿using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Calculator.Core.ViewModels;

namespace Calculator.Core
{

    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<CalViewModel>();
        }
    }
}
