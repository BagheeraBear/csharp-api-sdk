﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:2.0.50727.5472
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using System.Collections.Generic;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 

namespace FortnoxAPILibrary
{
	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
	public partial class FinancialYears
	{

		private List<FinancialYearSubset> financialYearSubsetField;

		private string totalResourcesField;

		private string totalPagesField;

		private string currentPageField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElementAttribute("FinancialYearSubset")]
		public List<FinancialYearSubset> FinancialYearSubset
		{
			get
			{
				return this.financialYearSubsetField;
			}
			set
			{
				this.financialYearSubsetField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TotalResources
		{
			get
			{
				return this.totalResourcesField;
			}
			set
			{
				this.totalResourcesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string TotalPages
		{
			get
			{
				return this.totalPagesField;
			}
			set
			{
				this.totalPagesField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string CurrentPage
		{
			get
			{
				return this.currentPageField;
			}
			set
			{
				this.currentPageField = value;
			}
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
	[System.SerializableAttribute()]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
	public partial class FinancialYearSubset
	{

		private string idField;

		private string fromDateField;

		private string toDateField;

		private string urlField;

		/// <remarks/>
		public string Id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		/// <remarks/>
		public string FromDate
		{
			get
			{
				return this.fromDateField;
			}
			set
			{
				this.fromDateField = value;
			}
		}

		/// <remarks/>
		public string ToDate
		{
			get
			{
				return this.toDateField;
			}
			set
			{
				this.toDateField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlAttributeAttribute()]
		public string url
		{
			get
			{
				return this.urlField;
			}
			set
			{
				this.urlField = value;
			}
		}
	}
}