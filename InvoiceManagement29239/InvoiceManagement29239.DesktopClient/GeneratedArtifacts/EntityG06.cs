﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No hay ninguna descripción modelada
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
    public sealed partial class CategoriesItem : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Inicializa una nueva instancia de la entidad CategoriesItem.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public CategoriesItem()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public CategoriesItem(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.CategoriesItem> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.CategoriesItem.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CategoriesItem_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CategoriesItem_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Obtiene el objeto Application para esta aplicación. El objeto Application proporciona acceso a pantallas activas, métodos para abrir pantallas y acceso al usuario actual.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return (global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace>)global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Obtiene el área de trabajo de datos contenedora. Dicha área proporciona acceso a todos los orígenes de datos de la aplicación.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No hay ninguna descripción modelada
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int CategoryID
        {
            get
            {
                return global::LightSwitchApplication.CategoriesItem.DetailsClass.GetValue(this, global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties.CategoryID);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CategoryID_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CategoryID_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CategoryID_Changed();

        /// <summary>
        /// No hay ninguna descripción modelada
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string CategoryName
        {
            get
            {
                return global::LightSwitchApplication.CategoriesItem.DetailsClass.GetValue(this, global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties.CategoryName);
            }
            set
            {
                global::LightSwitchApplication.CategoriesItem.DetailsClass.SetValue(this, global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties.CategoryName, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CategoryName_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CategoryName_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void CategoryName_Changed();

        /// <summary>
        /// No hay ninguna descripción modelada
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public string Description
        {
            get
            {
                return global::LightSwitchApplication.CategoriesItem.DetailsClass.GetValue(this, global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties.Description);
            }
            set
            {
                global::LightSwitchApplication.CategoriesItem.DetailsClass.SetValue(this, global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties.Description, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Description_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Description_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Description_Changed();

        /// <summary>
        /// No hay ninguna descripción modelada
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public byte[] Picture
        {
            get
            {
                return global::LightSwitchApplication.CategoriesItem.DetailsClass.GetValue(this, global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties.Picture);
            }
            set
            {
                global::LightSwitchApplication.CategoriesItem.DetailsClass.SetValue(this, global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties.Picture, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Picture_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Picture_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Picture_Changed();

        /// <summary>
        /// No hay ninguna descripción modelada
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.ProductsItem> Products
        {
            get
            {
                return global::LightSwitchApplication.CategoriesItem.DetailsClass.GetValue(this, global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties.Products);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.ProductsItem> ProductsQuery
        {
            get
            {
                return global::LightSwitchApplication.CategoriesItem.DetailsClass.GetQuery(this, global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties.Products);
            }
        }

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.CategoriesItem,
                global::LightSwitchApplication.CategoriesItem.DetailsClass,
                global::LightSwitchApplication.CategoriesItem.DetailsClass.IImplementation,
                global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties.CategoryID;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass>.Entry
                __CategoriesItemEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass>.Entry(
                    global::LightSwitchApplication.CategoriesItem.DetailsClass.__CategoriesItem_CreateNew,
                    global::LightSwitchApplication.CategoriesItem.DetailsClass.__CategoriesItem_Created,
                    global::LightSwitchApplication.CategoriesItem.DetailsClass.__CategoriesItem_AllowSaveWithErrors);
            private static global::LightSwitchApplication.CategoriesItem __CategoriesItem_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.CategoriesItem> es)
            {
                return new global::LightSwitchApplication.CategoriesItem(es);
            }
            private static void __CategoriesItem_Created(global::LightSwitchApplication.CategoriesItem e)
            {
                e.CategoriesItem_Created();
            }
            private static bool __CategoriesItem_AllowSaveWithErrors(global::LightSwitchApplication.CategoriesItem e)
            {
                bool result = false;
                e.CategoriesItem_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, int> CategoryID
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties.CategoryID) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, string> CategoryName
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties.CategoryName) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, string> Description
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties.Description) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, string>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, byte[]> Picture
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties.Picture) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, byte[]>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, global::LightSwitchApplication.ProductsItem> Products
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties.Products) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, global::LightSwitchApplication.ProductsItem>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int CategoryID { get; }
                new string CategoryName { get; set; }
                new string Description { get; set; }
                new byte[] Picture { get; set; }
                new global::System.Collections.IEnumerable Products { get; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "14.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, int>.Entry
                    CategoryID = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, int>.Entry(
                        "CategoryID",
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._CategoryID_Stub,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._CategoryID_ComputeIsReadOnly,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._CategoryID_Validate,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._CategoryID_GetImplementationValue,
                        null,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._CategoryID_OnValueChanged);
                private static void _CategoryID_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.CategoriesItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, int>.Data> c, global::LightSwitchApplication.CategoriesItem.DetailsClass d, object sf)
                {
                    c(d, ref d._CategoryID, sf);
                }
                private static bool _CategoryID_ComputeIsReadOnly(global::LightSwitchApplication.CategoriesItem e)
                {
                    bool result = false;
                    e.CategoryID_IsReadOnly(ref result);
                    return result;
                }
                private static void _CategoryID_Validate(global::LightSwitchApplication.CategoriesItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.CategoryID_Validate(r);
                }
                private static int _CategoryID_GetImplementationValue(global::LightSwitchApplication.CategoriesItem.DetailsClass d)
                {
                    return d.ImplementationEntity.CategoryID;
                }
                private static void _CategoryID_OnValueChanged(global::LightSwitchApplication.CategoriesItem e)
                {
                    e.CategoryID_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, string>.Entry
                    CategoryName = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, string>.Entry(
                        "CategoryName",
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._CategoryName_Stub,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._CategoryName_ComputeIsReadOnly,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._CategoryName_Validate,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._CategoryName_GetImplementationValue,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._CategoryName_SetImplementationValue,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._CategoryName_OnValueChanged);
                private static void _CategoryName_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.CategoriesItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, string>.Data> c, global::LightSwitchApplication.CategoriesItem.DetailsClass d, object sf)
                {
                    c(d, ref d._CategoryName, sf);
                }
                private static bool _CategoryName_ComputeIsReadOnly(global::LightSwitchApplication.CategoriesItem e)
                {
                    bool result = false;
                    e.CategoryName_IsReadOnly(ref result);
                    return result;
                }
                private static void _CategoryName_Validate(global::LightSwitchApplication.CategoriesItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.CategoryName_Validate(r);
                }
                private static string _CategoryName_GetImplementationValue(global::LightSwitchApplication.CategoriesItem.DetailsClass d)
                {
                    return d.ImplementationEntity.CategoryName;
                }
                private static void _CategoryName_SetImplementationValue(global::LightSwitchApplication.CategoriesItem.DetailsClass d, string v)
                {
                    d.ImplementationEntity.CategoryName = v;
                }
                private static void _CategoryName_OnValueChanged(global::LightSwitchApplication.CategoriesItem e)
                {
                    e.CategoryName_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, string>.Entry
                    Description = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, string>.Entry(
                        "Description",
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._Description_Stub,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._Description_ComputeIsReadOnly,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._Description_Validate,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._Description_GetImplementationValue,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._Description_SetImplementationValue,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._Description_OnValueChanged);
                private static void _Description_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.CategoriesItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, string>.Data> c, global::LightSwitchApplication.CategoriesItem.DetailsClass d, object sf)
                {
                    c(d, ref d._Description, sf);
                }
                private static bool _Description_ComputeIsReadOnly(global::LightSwitchApplication.CategoriesItem e)
                {
                    bool result = false;
                    e.Description_IsReadOnly(ref result);
                    return result;
                }
                private static void _Description_Validate(global::LightSwitchApplication.CategoriesItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Description_Validate(r);
                }
                private static string _Description_GetImplementationValue(global::LightSwitchApplication.CategoriesItem.DetailsClass d)
                {
                    return d.ImplementationEntity.Description;
                }
                private static void _Description_SetImplementationValue(global::LightSwitchApplication.CategoriesItem.DetailsClass d, string v)
                {
                    d.ImplementationEntity.Description = v;
                }
                private static void _Description_OnValueChanged(global::LightSwitchApplication.CategoriesItem e)
                {
                    e.Description_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, byte[]>.Entry
                    Picture = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, byte[]>.Entry(
                        "Picture",
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._Picture_Stub,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._Picture_ComputeIsReadOnly,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._Picture_Validate,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._Picture_GetImplementationValue,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._Picture_SetImplementationValue,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._Picture_OnValueChanged);
                private static void _Picture_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.CategoriesItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, byte[]>.Data> c, global::LightSwitchApplication.CategoriesItem.DetailsClass d, object sf)
                {
                    c(d, ref d._Picture, sf);
                }
                private static bool _Picture_ComputeIsReadOnly(global::LightSwitchApplication.CategoriesItem e)
                {
                    bool result = false;
                    e.Picture_IsReadOnly(ref result);
                    return result;
                }
                private static void _Picture_Validate(global::LightSwitchApplication.CategoriesItem e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Picture_Validate(r);
                }
                private static byte[] _Picture_GetImplementationValue(global::LightSwitchApplication.CategoriesItem.DetailsClass d)
                {
                    return d.ImplementationEntity.Picture;
                }
                private static void _Picture_SetImplementationValue(global::LightSwitchApplication.CategoriesItem.DetailsClass d, byte[] v)
                {
                    d.ImplementationEntity.Picture = v;
                }
                private static void _Picture_OnValueChanged(global::LightSwitchApplication.CategoriesItem e)
                {
                    e.Picture_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, global::LightSwitchApplication.ProductsItem>.Entry
                    Products = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, global::LightSwitchApplication.ProductsItem>.Entry(
                        "Products",
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._Products_Stub,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._Products_GetReferencedEntities,
                        global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties._Products_GetEntityCollection);
                private static void _Products_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.CategoriesItem.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, global::LightSwitchApplication.ProductsItem>.Data> c, global::LightSwitchApplication.CategoriesItem.DetailsClass d, object sf)
                {
                    c(d, ref d._Products, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.ProductsItem> _Products_GetReferencedEntities(global::LightSwitchApplication.CategoriesItem.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.ProductsItem, global::LightSwitchApplication.ProductsItem.DetailsClass>(global::LightSwitchApplication.CategoriesItem.DetailsClass.PropertySetProperties.Products, ref d._Products);
                }
                private static global::System.Collections.IEnumerable _Products_GetEntityCollection(global::LightSwitchApplication.CategoriesItem.DetailsClass d)
                {
                    return d.ImplementationEntity.Products;
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, int>.Data _CategoryID;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, string>.Data _CategoryName;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, string>.Data _Description;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, byte[]>.Data _Picture;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.CategoriesItem, global::LightSwitchApplication.CategoriesItem.DetailsClass, global::LightSwitchApplication.ProductsItem>.Data _Products;
            
        }
    
        #endregion
    }
    
    #endregion
}
