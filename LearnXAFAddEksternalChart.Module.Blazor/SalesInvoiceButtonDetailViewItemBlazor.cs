using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Blazor;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Xpo;
using LearnXAFAddEksternalChart.Module.BusinessObjects;
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
    public class SalesInvoiceButtonDetailViewItemBlazor : ViewItem, IComplexViewItem
    {
        private Session sessionBase;
        public class DxButtonHolder : IComponentContentHolder
        {
            private Session _session;
            public DxButtonHolder(Session session)
            {
                _session = session;
            }
            RenderFragment IComponentContentHolder.ComponentContent => SalesInvoiceButtonRenderer.Create(_session);
        }
        
        public SalesInvoiceButtonDetailViewItemBlazor(IModelViewItem model, Type objectType) : base(objectType, model.Id) { }
        protected override object CreateControlCore() => new DxButtonHolder(sessionBase);
        void IComplexViewItem.Setup(IObjectSpace objectSpace, XafApplication application)
        {
            this.sessionBase = ((XPObjectSpace)objectSpace).Session;
        }
    }
}
