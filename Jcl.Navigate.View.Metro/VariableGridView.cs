using Jcl.Navigate.Model.MetroInterface;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Jcl.Navigate.View.Metro
{
    public class VariableGridView : GridView
    {
        protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
        {
            var viewModel = item as IResizable;

            element.SetValue(VariableSizedWrapGrid.ColumnSpanProperty, viewModel.Width);
            element.SetValue(VariableSizedWrapGrid.RowSpanProperty, viewModel.Height);

            base.PrepareContainerForItemOverride(element, item);
        }
    }
}
