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
	public class Order : BaseObject
	{
		public Order(Session session) : base(session) { }
		private ProductNameEnum _productName;
		private double _price;
		private DateTime _buyAt;
		public ProductNameEnum ProductName
		{
			get { return _productName; }
			set { SetPropertyValue(nameof(ProductName), ref _productName, value); }
		}
		public double Price
		{
			get { return _price; }
			set { SetPropertyValue(nameof(Price), ref _price, value); }
		}
		public DateTime BuyAt
		{
			get { return _buyAt; }
			set { SetPropertyValue(nameof(BuyAt), ref _buyAt, value); }
		}
	}
	public enum ProductNameEnum
    {
		ChildrenClothes, WomenClothes, ManClothes
    }
}
