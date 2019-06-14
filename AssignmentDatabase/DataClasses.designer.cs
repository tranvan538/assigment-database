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

namespace AssignmentDatabase
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Assigment")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAccount(Account instance);
    partial void UpdateAccount(Account instance);
    partial void DeleteAccount(Account instance);
    partial void InsertDevice(Device instance);
    partial void UpdateDevice(Device instance);
    partial void DeleteDevice(Device instance);
    partial void InsertDeviceType(DeviceType instance);
    partial void UpdateDeviceType(DeviceType instance);
    partial void DeleteDeviceType(DeviceType instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::AssignmentDatabase.Properties.Settings.Default.AssigmentConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Account> Accounts
		{
			get
			{
				return this.GetTable<Account>();
			}
		}
		
		public System.Data.Linq.Table<Device> Devices
		{
			get
			{
				return this.GetTable<Device>();
			}
		}
		
		public System.Data.Linq.Table<DeviceType> DeviceTypes
		{
			get
			{
				return this.GetTable<DeviceType>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Account")]
	public partial class Account : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Username;
		
		private string _Name;
		
		private string _Password;
		
		private System.Nullable<System.DateTime> _CreatedDate;
		
		private System.Nullable<System.DateTime> _UpdatedDate;
		
		private EntitySet<Device> _Devices;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedDateChanged();
    partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdatedDateChanged();
    #endregion
		
		public Account()
		{
			this._Devices = new EntitySet<Device>(new Action<Device>(this.attach_Devices), new Action<Device>(this.detach_Devices));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdatedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._UpdatedDate;
			}
			set
			{
				if ((this._UpdatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._UpdatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Device", Storage="_Devices", ThisKey="Username", OtherKey="Owner")]
		public EntitySet<Device> Devices
		{
			get
			{
				return this._Devices;
			}
			set
			{
				this._Devices.Assign(value);
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
		
		private void attach_Devices(Device entity)
		{
			this.SendPropertyChanging();
			entity.Account = this;
		}
		
		private void detach_Devices(Device entity)
		{
			this.SendPropertyChanging();
			entity.Account = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Device")]
	public partial class Device : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Code;
		
		private string _Type;
		
		private decimal _Value;
		
		private string _Owner;
		
		private System.Nullable<System.DateTime> _CreatedDate;
		
		private System.Nullable<System.DateTime> _UpdatedDate;
		
		private EntityRef<Account> _Account;
		
		private EntityRef<DeviceType> _DeviceType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(string value);
    partial void OnCodeChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnValueChanging(decimal value);
    partial void OnValueChanged();
    partial void OnOwnerChanging(string value);
    partial void OnOwnerChanged();
    partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedDateChanged();
    partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdatedDateChanged();
    #endregion
		
		public Device()
		{
			this._Account = default(EntityRef<Account>);
			this._DeviceType = default(EntityRef<DeviceType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					if (this._DeviceType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Value", DbType="Money NOT NULL")]
		public decimal Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				if ((this._Value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._Value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Owner", DbType="VarChar(100)")]
		public string Owner
		{
			get
			{
				return this._Owner;
			}
			set
			{
				if ((this._Owner != value))
				{
					if (this._Account.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOwnerChanging(value);
					this.SendPropertyChanging();
					this._Owner = value;
					this.SendPropertyChanged("Owner");
					this.OnOwnerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdatedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._UpdatedDate;
			}
			set
			{
				if ((this._UpdatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._UpdatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Account_Device", Storage="_Account", ThisKey="Owner", OtherKey="Username", IsForeignKey=true, DeleteRule="SET NULL")]
		public Account Account
		{
			get
			{
				return this._Account.Entity;
			}
			set
			{
				Account previousValue = this._Account.Entity;
				if (((previousValue != value) 
							|| (this._Account.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Account.Entity = null;
						previousValue.Devices.Remove(this);
					}
					this._Account.Entity = value;
					if ((value != null))
					{
						value.Devices.Add(this);
						this._Owner = value.Username;
					}
					else
					{
						this._Owner = default(string);
					}
					this.SendPropertyChanged("Account");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DeviceType_Device", Storage="_DeviceType", ThisKey="Type", OtherKey="Code", IsForeignKey=true)]
		public DeviceType DeviceType
		{
			get
			{
				return this._DeviceType.Entity;
			}
			set
			{
				DeviceType previousValue = this._DeviceType.Entity;
				if (((previousValue != value) 
							|| (this._DeviceType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DeviceType.Entity = null;
						previousValue.Devices.Remove(this);
					}
					this._DeviceType.Entity = value;
					if ((value != null))
					{
						value.Devices.Add(this);
						this._Type = value.Code;
					}
					else
					{
						this._Type = default(string);
					}
					this.SendPropertyChanged("DeviceType");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DeviceType")]
	public partial class DeviceType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Code;
		
		private string _Name;
		
		private string _Description;
		
		private System.Nullable<System.DateTime> _CreatedDate;
		
		private System.Nullable<System.DateTime> _UpdatedDate;
		
		private EntitySet<Device> _Devices;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(string value);
    partial void OnCodeChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnCreatedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCreatedDateChanged();
    partial void OnUpdatedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnUpdatedDateChanged();
    #endregion
		
		public DeviceType()
		{
			this._Devices = new EntitySet<Device>(new Action<Device>(this.attach_Devices), new Action<Device>(this.detach_Devices));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UpdatedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> UpdatedDate
		{
			get
			{
				return this._UpdatedDate;
			}
			set
			{
				if ((this._UpdatedDate != value))
				{
					this.OnUpdatedDateChanging(value);
					this.SendPropertyChanging();
					this._UpdatedDate = value;
					this.SendPropertyChanged("UpdatedDate");
					this.OnUpdatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DeviceType_Device", Storage="_Devices", ThisKey="Code", OtherKey="Type")]
		public EntitySet<Device> Devices
		{
			get
			{
				return this._Devices;
			}
			set
			{
				this._Devices.Assign(value);
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
		
		private void attach_Devices(Device entity)
		{
			this.SendPropertyChanging();
			entity.DeviceType = this;
		}
		
		private void detach_Devices(Device entity)
		{
			this.SendPropertyChanging();
			entity.DeviceType = null;
		}
	}
}
#pragma warning restore 1591