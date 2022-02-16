using DevExpress.ExpressApp.Blazor;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnXAFAddEksternalChart.Module.Blazor
{
    public interface IModelSalesInvoiceButtonDetailViewItemBlazor : IModelViewItem { }

    [ViewItem(typeof(IModelSalesInvoiceButtonDetailViewItemBlazor))]
    public class SalesInvoiceButtonDetailViewItemBlazor : ViewItem
    {
        public class DxButtonHolder : IComponentContentHolder
        {
            RenderFragment IComponentContentHolder.ComponentContent => SalesInvoiceButtonRenderer.Create();
        }
        public SalesInvoiceButtonDetailViewItemBlazor(IModelViewItem model, Type objectType) : base(objectType, model.Id) { }
        protected override object CreateControlCore() => new DxButtonHolder();
        public void test()
        {
            var tmp = CurrentObject;
        }
    }
}
