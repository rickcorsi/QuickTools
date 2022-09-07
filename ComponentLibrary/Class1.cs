using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentLibrary
{
    public class Class1
    {
        private bool App_GraphBuilder = false;
        private bool isExpandedGraphBuilder = false;
        private bool graphTabBars = true;
        string graphBuilderClass = "MudPaperMediumWidget";
        private double GraphBuilderMin = 0;
        private double GraphBuilderMax = 100;
        string GraphTitle = "Title";
        private int GraphNumberOfBars = 2;
        double[] GraphBar = { 0, 0, 0, 0, 0, 0 };
        double[] barHeight = { 0, 0, 0, 0, 0, 0 };
        string[] GraphBarLabel = { "Bar 1", "Bar 2", "Bar 3", "Bar 4", "Bar 5", "Bar 6" };
        public bool CheckBoxLabels { get; set; } = false;
        public bool CheckBoxValues { get; set; } = false;
        private void ExpandGraphBuilder()
        {
            if (isExpandedGraphBuilder == false)
            {
                graphBuilderClass = "MudPaperMediumWidgetExpanded";
                isExpandedGraphBuilder = true;
            }
            else if (isExpandedGraphBuilder == true)
            {
                graphBuilderClass = "MudPaperMediumWidget";
                isExpandedGraphBuilder = false;
            }
        }
        private void BuildGraph()
        {
            for (int i = 0; i < 6; i++)
            {
                barHeight[i] = GraphBar[i] / GraphBuilderMax;
                barHeight[i] = barHeight[i] * 100;
            }
        }
        private void ChangeGraphTab()
        {
            if (graphTabBars == false)
            {
                graphTabBars = true;
            }
            else if (graphTabBars == true)
            {
                graphTabBars = false;
            }
        }

    }
}
