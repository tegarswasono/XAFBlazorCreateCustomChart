using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Blazor;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using LearnXAFAddEksternalChart.Module.BusinessObjects;
using LearnXAFAddEksternalChart.Module.BusinessObjects.NonPersistent;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnXAFAddEksternalChart.Module.Blazor.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class OrderControllerListView : ObjectViewController<ListView, Order>
    {
        // Use CodeRush to create Controllers and Actions with a few keystrokes.
        // https://docs.devexpress.com/CodeRushForRoslyn/403133/
        public OrderControllerListView()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
            var dashboard = new PopupWindowShowAction(this, "OrderControllerListView_dashboard", PredefinedCategory.View)
            {
                Caption = "Dashboard",
                ImageName = "ChartType_Bar3D",
                AcceptButtonCaption = "Process"
            };
            dashboard.Execute += Action_Execute;
            dashboard.CustomizePopupWindowParams += Action_CustomizePopupWindowParams;
        }
        private void Action_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            NonPersistentObjectSpace os = (NonPersistentObjectSpace)e.Application.CreateObjectSpace(typeof(Dashboard));
            os.PopulateAdditionalObjectSpaces(Application);
            e.View = e.Application.CreateDetailView(os, os.CreateObject<Dashboard>());

            e.View.CurrentObject = new Dashboard() { StartDate = DateTime.Now.Date, EndDate = DateTime.Now.Date };
        }
        private void Action_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            Dashboard data = ((Dashboard)e.PopupWindowViewCurrentObject);
            var navigationManager = ((BlazorApplication)Application).ServiceProvider.GetRequiredService<NavigationManager>();
            navigationManager.NavigateTo("/ChartExampleDetailView", forceLoad: true);
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }
    }
}
