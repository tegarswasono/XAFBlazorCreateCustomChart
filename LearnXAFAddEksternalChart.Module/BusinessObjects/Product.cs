using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnXAFAddEksternalChart.Module.BusinessObjects
{
	[DefaultClassOptions]
	public class Product : BaseObject
	{
		public Product(Session session) : base(session) { }
		private string _name;
		private string _desc;
		public string Name
		{
			get { return _name; }
			set { SetPropertyValue(nameof(Name), ref _name, value); }
		}
		public string Desc
		{
			get { return _desc; }
			set { SetPropertyValue(nameof(Desc), ref _desc, value); }
		}
	}
}
