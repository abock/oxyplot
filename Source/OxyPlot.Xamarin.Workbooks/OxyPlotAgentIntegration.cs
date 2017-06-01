using Xamarin.Interactive;

using OxyPlot.Xamarin.Workbooks;

[assembly: AgentIntegration (typeof (OxyPlotAgentIntegration))]

namespace OxyPlot.Xamarin.Workbooks
{
    sealed class OxyPlotAgentIntegration : IAgentIntegration
    {
        public void IntegrateWith(IAgent agent)
            => agent.RepresentationManager.AddProvider(
                new OxyPlotRepresentationProvider());
    }
}