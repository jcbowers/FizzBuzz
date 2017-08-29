using System.Linq;

using FizzBuzz.Interfaces;

namespace FizzBuzz.MVP
{
    internal class Presenter : IPresenter
    {
        private readonly IView view;

        private readonly IPipelineExecutionStrategy pipelineExecutionStrategy;

        public Presenter(IView view, IPipelineExecutionStrategy pipelineExecutionStrategy)
        {
            this.view = view;
            this.pipelineExecutionStrategy = pipelineExecutionStrategy;
        }

        public void Run()
        {
            var results = pipelineExecutionStrategy.RunChain(Enumerable.Range(1, 100));
            var viewModel = results.Select(r => $"{r.Item1}: {r.Item2}");
            view.PresnetResults(viewModel);
        }
    }
}
