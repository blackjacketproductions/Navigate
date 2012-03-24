using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jcl.Navigate.Model;
using Windows.UI.Xaml;
using System.Windows.Input;
using Jcl.Navigate.Model.TubeLine;
using Windows.UI.Xaml.Data;
using System.Collections.ObjectModel;

namespace Jcl.Navigate.ViewModel
{
    public class LineStatusViewModel : DependencyObject
    {
        private readonly ILineStatusRepository _lineStatusRepository;


        public DelegateCommand<object> RefreshCommand  {get; set;} 
       
        #region LineStatuses


        public List<LineStatus> LineStatuses
        {
            get { return (List<LineStatus>)GetValue(LineStatusesProperty); }
            set { SetValue(LineStatusesProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LineStatuses.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LineStatusesProperty =
            DependencyProperty.Register("LineStatuses", typeof(List<LineStatus>), typeof(LineStatusViewModel), null);

        #endregion

        public LineStatusViewModel(ILineStatusRepository lineStatusRepository)
        {
            _lineStatusRepository = lineStatusRepository;
            RefreshCommand = new DelegateCommand<object>(Refresh);

            Refresh(null);
        }

        private void Refresh(object param)
        {
            var linestatuses = _lineStatusRepository.FindAll();

            LineStatuses = linestatuses.ToList<LineStatus>();
        }

        private bool CanRefresh(object param)
        {
            return true;
        }



    }
}
