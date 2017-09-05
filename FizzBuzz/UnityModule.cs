using FizzBuzz.Core;
using FizzBuzz.Core.Strategies;
using FizzBuzz.Interfaces;
using FizzBuzz.MVP;
using FizzBuzz.Service;

using Microsoft.Practices.Unity;

namespace FizzBuzz
{
    internal static class UnityModule
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IView, View>()
                .RegisterType<IPresenter, Presenter>()
                .RegisterType<IMapPipelineBuilder, MapPipelineBuilder>()
                .RegisterType<IPipelineExecutionStrategy, PipelineExecutionStrategy>()
                .RegisterType<INumberService, NumberService>()
                .RegisterType<IPipelineSequenceOrchastrator, FunctionalPipelineSequenceOrchastrator>("fp")
                .RegisterType<IPipelineSequenceOrchastrator, PipelineSequenceOrchastrator>("oo");
        }
    }
}
