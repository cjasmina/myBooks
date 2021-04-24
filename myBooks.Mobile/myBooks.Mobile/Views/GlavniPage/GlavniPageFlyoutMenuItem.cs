using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myBooks.Mobile.Views.GlavniPage
{
    public class GlavniPageFlyoutMenuItem
    {
        public GlavniPageFlyoutMenuItem()
        {
            TargetType = typeof(GlavniPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
        public Action Action { get; set; }
    }
}