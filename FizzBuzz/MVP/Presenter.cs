using System.Linq;

using FizzBuzz.Interfaces;

namespace FizzBuzz.MVP
{
    internal class Presenter : IPresenter
    {
        private readonly IView view;
        private readonly IPipelineExecutionStrategy pipelineExecutionStrategy;
        private readonly INumberService numberService;

        public Presenter(IView view, IPipelineExecutionStrategy pipelineExecutionStrategy, INumberService numberService)
        {
            this.view = view;
            this.pipelineExecutionStrategy = pipelineExecutionStrategy;
            this.numberService = numberService;
        }

        public void Run()
        {
            var numbers = numberService.GetNumbers();
            var results = pipelineExecutionStrategy.RunChain(numbers);
            var viewModel = results.Select(r => $"{r.Item1}: {r.Item2}");
            view.PresnetResults(viewModel);
        }
    }
}
