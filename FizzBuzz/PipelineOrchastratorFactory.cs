using System.Linq;

using FizzBuzz.Interfaces;

using Microsoft.Practices.Unity;

namespace FizzBuzz
{
    public interface IPipelineOrchastratorFactory
    {
        IPipelineSequenceOrchastrator Make();
    }

    public class PipelineOrchastratorFactory : IPipelineOrchastratorFactory
    {
        private readonly string orchastrationType;

        private readonly UnityContainer container;

        public PipelineOrchastratorFactory(string orchastrationType, UnityContainer container)
        {
            this.orchastrationType = orchastrationType;
            this.container = container;
        }

        public IPipelineSequenceOrchastrator Make()
        {
            return container.Resolve<IPipelineSequenceOrchastrator>(orchastrationType ?? "oo");
        }
    }
}