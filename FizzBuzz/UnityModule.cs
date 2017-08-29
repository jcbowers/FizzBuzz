﻿using FizzBuzz.Core;
using FizzBuzz.Core.Strategies;
using FizzBuzz.Interfaces;
using FizzBuzz.MVP;

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
                .RegisterType<IPipelineOrchastratorFactory, PipelineOrchastratorFactory>()
                .RegisterType<IPipelineExecutionStrategy, PipelineExecutionStrategy>()
                .RegisterType<IPipelineSequenceOrchastrator, FunctionalPipelineSequenceOrchastrator>("fp")
                .RegisterType<IPipelineSequenceOrchastrator, PipelineSequenceOrchastrator>("oo");
        }
    }
}