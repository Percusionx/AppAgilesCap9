﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region Metadatos de relaciones en EDM

[assembly: EdmRelationshipAttribute("LightSwitchApplication", "FK_Employees_Employees", "Employees", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(LightSwitchApplication.Implementation.EmployeesItem), "Employees1", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(LightSwitchApplication.Implementation.EmployeesItem), true)]

#endregion

namespace LightSwitchApplication.Implementation
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class NorthwindData1 : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto NorthwindData1 usando la cadena de conexión encontrada en la sección 'NorthwindData1' del archivo de configuración de la aplicación.
        /// </summary>
        public NorthwindData1() : base("name=NorthwindData1", "NorthwindData1")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto NorthwindData1.
        /// </summary>
        public NorthwindData1(string connectionString) : base(connectionString, "NorthwindData1")
        {
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto NorthwindData1.
        /// </summary>
        public NorthwindData1(EntityConnection connection) : base(connection, "NorthwindData1")
        {
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<EmployeesItem> Employees
        {
            get
            {
                if ((_Employees == null))
                {
                    _Employees = base.CreateObjectSet<EmployeesItem>("Employees");
                }
                return _Employees;
            }
        }
        private ObjectSet<EmployeesItem> _Employees;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet Employees. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToEmployees(EmployeesItem employeesItem)
        {
            base.AddObject("Employees", employeesItem);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LightSwitchApplication", Name="EmployeesItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EmployeesItem : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto EmployeesItem.
        /// </summary>
        /// <param name="employeeID">Valor inicial de la propiedad EmployeeID.</param>
        /// <param name="lastName">Valor inicial de la propiedad LastName.</param>
        /// <param name="firstName">Valor inicial de la propiedad FirstName.</param>
        public static EmployeesItem CreateEmployeesItem(global::System.Int32 employeeID, global::System.String lastName, global::System.String firstName)
        {
            EmployeesItem employeesItem = new EmployeesItem();
            employeesItem.EmployeeID = employeeID;
            employeesItem.LastName = lastName;
            employeesItem.FirstName = firstName;
            return employeesItem;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                if (_EmployeeID != value)
                {
                    OnEmployeeIDChanging(value);
                    ReportPropertyChanging("EmployeeID");
                    _EmployeeID = value;
                    ReportPropertyChanged("EmployeeID");
                    OnEmployeeIDChanged();
                }
            }
        }
        private global::System.Int32 _EmployeeID;
        partial void OnEmployeeIDChanging(global::System.Int32 value);
        partial void OnEmployeeIDChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = value;
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = value;
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = value;
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String TitleOfCourtesy
        {
            get
            {
                return _TitleOfCourtesy;
            }
            set
            {
                OnTitleOfCourtesyChanging(value);
                ReportPropertyChanging("TitleOfCourtesy");
                _TitleOfCourtesy = value;
                ReportPropertyChanged("TitleOfCourtesy");
                OnTitleOfCourtesyChanged();
            }
        }
        private global::System.String _TitleOfCourtesy;
        partial void OnTitleOfCourtesyChanging(global::System.String value);
        partial void OnTitleOfCourtesyChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> BirthDate
        {
            get
            {
                return _BirthDate;
            }
            set
            {
                OnBirthDateChanging(value);
                ReportPropertyChanging("BirthDate");
                _BirthDate = value;
                ReportPropertyChanged("BirthDate");
                OnBirthDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _BirthDate;
        partial void OnBirthDateChanging(Nullable<global::System.DateTime> value);
        partial void OnBirthDateChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> HireDate
        {
            get
            {
                return _HireDate;
            }
            set
            {
                OnHireDateChanging(value);
                ReportPropertyChanging("HireDate");
                _HireDate = value;
                ReportPropertyChanged("HireDate");
                OnHireDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _HireDate;
        partial void OnHireDateChanging(Nullable<global::System.DateTime> value);
        partial void OnHireDateChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = value;
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = value;
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Region
        {
            get
            {
                return _Region;
            }
            set
            {
                OnRegionChanging(value);
                ReportPropertyChanging("Region");
                _Region = value;
                ReportPropertyChanged("Region");
                OnRegionChanged();
            }
        }
        private global::System.String _Region;
        partial void OnRegionChanging(global::System.String value);
        partial void OnRegionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PostalCode
        {
            get
            {
                return _PostalCode;
            }
            set
            {
                OnPostalCodeChanging(value);
                ReportPropertyChanging("PostalCode");
                _PostalCode = value;
                ReportPropertyChanged("PostalCode");
                OnPostalCodeChanged();
            }
        }
        private global::System.String _PostalCode;
        partial void OnPostalCodeChanging(global::System.String value);
        partial void OnPostalCodeChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Country
        {
            get
            {
                return _Country;
            }
            set
            {
                OnCountryChanging(value);
                ReportPropertyChanging("Country");
                _Country = value;
                ReportPropertyChanged("Country");
                OnCountryChanged();
            }
        }
        private global::System.String _Country;
        partial void OnCountryChanging(global::System.String value);
        partial void OnCountryChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String HomePhone
        {
            get
            {
                return _HomePhone;
            }
            set
            {
                OnHomePhoneChanging(value);
                ReportPropertyChanging("HomePhone");
                _HomePhone = value;
                ReportPropertyChanged("HomePhone");
                OnHomePhoneChanged();
            }
        }
        private global::System.String _HomePhone;
        partial void OnHomePhoneChanging(global::System.String value);
        partial void OnHomePhoneChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Extension
        {
            get
            {
                return _Extension;
            }
            set
            {
                OnExtensionChanging(value);
                ReportPropertyChanging("Extension");
                _Extension = value;
                ReportPropertyChanged("Extension");
                OnExtensionChanged();
            }
        }
        private global::System.String _Extension;
        partial void OnExtensionChanging(global::System.String value);
        partial void OnExtensionChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.Byte[] Photo
        {
            get
            {
                return StructuralObject.GetValidValue(_Photo);
            }
            set
            {
                OnPhotoChanging(value);
                ReportPropertyChanging("Photo");
                _Photo = value;
                ReportPropertyChanged("Photo");
                OnPhotoChanged();
            }
        }
        private global::System.Byte[] _Photo;
        partial void OnPhotoChanging(global::System.Byte[] value);
        partial void OnPhotoChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Notes
        {
            get
            {
                return _Notes;
            }
            set
            {
                OnNotesChanging(value);
                ReportPropertyChanging("Notes");
                _Notes = value;
                ReportPropertyChanged("Notes");
                OnNotesChanged();
            }
        }
        private global::System.String _Notes;
        partial void OnNotesChanging(global::System.String value);
        partial void OnNotesChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PhotoPath
        {
            get
            {
                return _PhotoPath;
            }
            set
            {
                OnPhotoPathChanging(value);
                ReportPropertyChanging("PhotoPath");
                _PhotoPath = value;
                ReportPropertyChanged("PhotoPath");
                OnPhotoPathChanged();
            }
        }
        private global::System.String _PhotoPath;
        partial void OnPhotoPathChanging(global::System.String value);
        partial void OnPhotoPathChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ReportsTo
        {
            get
            {
                return _ReportsTo;
            }
            set
            {
                OnReportsToChanging(value);
                ReportPropertyChanging("ReportsTo");
                _ReportsTo = value;
                ReportPropertyChanged("ReportsTo");
                OnReportsToChanged();
            }
        }
        private Nullable<global::System.Int32> _ReportsTo;
        partial void OnReportsToChanging(Nullable<global::System.Int32> value);
        partial void OnReportsToChanged();

        #endregion

    
        #region Propiedades de navegación
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LightSwitchApplication", "FK_Employees_Employees", "Employees1")]
        public EntityCollection<EmployeesItem> Employees
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<EmployeesItem>("LightSwitchApplication.FK_Employees_Employees", "Employees1");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<EmployeesItem>("LightSwitchApplication.FK_Employees_Employees", "Employees1", value);
                }
            }
        }
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LightSwitchApplication", "FK_Employees_Employees", "Employees")]
        public EmployeesItem Manager
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EmployeesItem>("LightSwitchApplication.FK_Employees_Employees", "Employees").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EmployeesItem>("LightSwitchApplication.FK_Employees_Employees", "Employees").Value = value;
            }
        }
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<EmployeesItem> ManagerReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EmployeesItem>("LightSwitchApplication.FK_Employees_Employees", "Employees");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<EmployeesItem>("LightSwitchApplication.FK_Employees_Employees", "Employees", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
