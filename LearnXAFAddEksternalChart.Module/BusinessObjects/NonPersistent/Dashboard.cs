using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnXAFAddEksternalChart.Module.BusinessObjects.NonPersistent
{
    [DomainComponent]
    public class Dashboard : NonPersistentObjectImpl
    {
        private DateTime _startDate;
        private DateTime _endDate;

        [RuleRequiredField(DefaultContexts.Save)]
        public DateTime StartDate
        {
            get { return _startDate; }
            set { SetPropertyValue(ref _startDate, value); }
        }
        [RuleRequiredField(DefaultContexts.Save)]
        public DateTime EndDate
        {
            get { return _endDate; }
            set { SetPropertyValue(ref _endDate, value); }
        }
    }
}
