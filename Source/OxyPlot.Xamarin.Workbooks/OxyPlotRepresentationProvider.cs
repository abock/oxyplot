using System.Collections.Generic;

using Xamarin.Interactive.Representations;

namespace OxyPlot.Xamarin.Workbooks
{
    sealed class OxyPlotRepresentationProvider : RepresentationProvider
    {
        public override IEnumerable<object> ProvideRepresentations(object obj)
        {
            if (obj is PlotModel plotModel)
                yield return Image.FromSvg(SvgExporter.ExportToString(
                    plotModel,
                    width: 800,
                    height: 600,
                    isDocument: true));
        }
    }
}