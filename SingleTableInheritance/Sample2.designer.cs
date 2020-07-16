﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SingleTableInheritance
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Sample2")]
	public partial class Sample2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    #endregion
		
		public Sample2DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Sample2ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public Sample2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Sample2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Sample2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public Sample2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employees")]
	[global::System.Data.Linq.Mapping.InheritanceMappingAttribute(Code="PermanentEmployee", Type=typeof(PermanentEmployee), IsDefault=true)]
	[global::System.Data.Linq.Mapping.InheritanceMappingAttribute(Code="ContractEmployee", Type=typeof(ContractEmployee))]
	public abstract partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Gender;
		
		private string _Discriminator;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnDiscriminatorChanging(string value);
    partial void OnDiscriminatorChanged();
    #endregion
		
		public Employee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(50)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Discriminator", DbType="NVarChar(50)", IsDiscriminator=true)]
		public string Discriminator
		{
			get
			{
				return this._Discriminator;
			}
			set
			{
				if ((this._Discriminator != value))
				{
					this.OnDiscriminatorChanging(value);
					this.SendPropertyChanging();
					this._Discriminator = value;
					this.SendPropertyChanged("Discriminator");
					this.OnDiscriminatorChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	public partial class PermanentEmployee : Employee
	{
		
		private System.Nullable<int> _AnnualSalary;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAnnualSalaryChanging(System.Nullable<int> value);
    partial void OnAnnualSalaryChanged();
    #endregion
		
		public PermanentEmployee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnnualSalary", DbType="Int")]
		public System.Nullable<int> AnnualSalary
		{
			get
			{
				return this._AnnualSalary;
			}
			set
			{
				if ((this._AnnualSalary != value))
				{
					this.OnAnnualSalaryChanging(value);
					this.SendPropertyChanging();
					this._AnnualSalary = value;
					this.SendPropertyChanged("AnnualSalary");
					this.OnAnnualSalaryChanged();
				}
			}
		}
	}
	
	public partial class ContractEmployee : Employee
	{
		
		private System.Nullable<int> _HourlyPay;
		
		private System.Nullable<int> _HoursWorked;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHourlyPayChanging(System.Nullable<int> value);
    partial void OnHourlyPayChanged();
    partial void OnHoursWorkedChanging(System.Nullable<int> value);
    partial void OnHoursWorkedChanged();
    #endregion
		
		public ContractEmployee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HourlyPay", DbType="Int")]
		public System.Nullable<int> HourlyPay
		{
			get
			{
				return this._HourlyPay;
			}
			set
			{
				if ((this._HourlyPay != value))
				{
					this.OnHourlyPayChanging(value);
					this.SendPropertyChanging();
					this._HourlyPay = value;
					this.SendPropertyChanged("HourlyPay");
					this.OnHourlyPayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoursWorked", DbType="Int")]
		public System.Nullable<int> HoursWorked
		{
			get
			{
				return this._HoursWorked;
			}
			set
			{
				if ((this._HoursWorked != value))
				{
					this.OnHoursWorkedChanging(value);
					this.SendPropertyChanging();
					this._HoursWorked = value;
					this.SendPropertyChanged("HoursWorked");
					this.OnHoursWorkedChanged();
				}
			}
		}
	}
}
#pragma warning restore 1591
