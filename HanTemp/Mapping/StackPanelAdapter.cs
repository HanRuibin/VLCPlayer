using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Regions;
using System.Windows.Controls;

namespace HanTemp.Mapping
{
    public class StackPanelAdapter : RegionAdapterBase<StackPanel>
    {
        public StackPanelAdapter( IRegionBehaviorFactory regionBehaviorFactory):base(regionBehaviorFactory)
        {

        }
        protected override void Adapt(IRegion region, StackPanel regionTarget)
        {
            
        }

        protected override IRegion CreateRegion()
        {
            return new AllActiveRegion();
        }
    }
}
