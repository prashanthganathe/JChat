﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("JModel", "FK_MessageTb_Group", "Group", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(BizService.Group), "MessageTb", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(BizService.MessageTb), true)]
[assembly: EdmRelationshipAttribute("JModel", "FK_UserState_User", "User", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(BizService.User), "UserState", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(BizService.UserState), true)]

#endregion

namespace BizService
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class JModelEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new JModelEntities object using the connection string found in the 'JModelEntities' section of the application configuration file.
        /// </summary>
        public JModelEntities() : base("name=JModelEntities", "JModelEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new JModelEntities object.
        /// </summary>
        public JModelEntities(string connectionString) : base(connectionString, "JModelEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new JModelEntities object.
        /// </summary>
        public JModelEntities(EntityConnection connection) : base(connection, "JModelEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Group> Groups
        {
            get
            {
                if ((_Groups == null))
                {
                    _Groups = base.CreateObjectSet<Group>("Groups");
                }
                return _Groups;
            }
        }
        private ObjectSet<Group> _Groups;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<MessageTb> MessageTbs
        {
            get
            {
                if ((_MessageTbs == null))
                {
                    _MessageTbs = base.CreateObjectSet<MessageTb>("MessageTbs");
                }
                return _MessageTbs;
            }
        }
        private ObjectSet<MessageTb> _MessageTbs;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<UserState> UserStates
        {
            get
            {
                if ((_UserStates == null))
                {
                    _UserStates = base.CreateObjectSet<UserState>("UserStates");
                }
                return _UserStates;
            }
        }
        private ObjectSet<UserState> _UserStates;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Groups EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToGroups(Group group)
        {
            base.AddObject("Groups", group);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the MessageTbs EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToMessageTbs(MessageTb messageTb)
        {
            base.AddObject("MessageTbs", messageTb);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the UserStates EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUserStates(UserState userState)
        {
            base.AddObject("UserStates", userState);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="JModel", Name="Group")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Group : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Group object.
        /// </summary>
        /// <param name="gId">Initial value of the GId property.</param>
        public static Group CreateGroup(global::System.Int32 gId)
        {
            Group group = new Group();
            group.GId = gId;
            return group;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 GId
        {
            get
            {
                return _GId;
            }
            set
            {
                if (_GId != value)
                {
                    OnGIdChanging(value);
                    ReportPropertyChanging("GId");
                    _GId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("GId");
                    OnGIdChanged();
                }
            }
        }
        private global::System.Int32 _GId;
        partial void OnGIdChanging(global::System.Int32 value);
        partial void OnGIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String GName
        {
            get
            {
                return _GName;
            }
            set
            {
                OnGNameChanging(value);
                ReportPropertyChanging("GName");
                _GName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("GName");
                OnGNameChanged();
            }
        }
        private global::System.String _GName;
        partial void OnGNameChanging(global::System.String value);
        partial void OnGNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("JModel", "FK_MessageTb_Group", "MessageTb")]
        public EntityCollection<MessageTb> MessageTbs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<MessageTb>("JModel.FK_MessageTb_Group", "MessageTb");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<MessageTb>("JModel.FK_MessageTb_Group", "MessageTb", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="JModel", Name="MessageTb")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class MessageTb : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new MessageTb object.
        /// </summary>
        /// <param name="mID">Initial value of the MID property.</param>
        /// <param name="dateTime">Initial value of the DateTime property.</param>
        /// <param name="message">Initial value of the Message property.</param>
        /// <param name="delivered">Initial value of the Delivered property.</param>
        public static MessageTb CreateMessageTb(global::System.Int32 mID, global::System.DateTime dateTime, global::System.String message, global::System.Boolean delivered)
        {
            MessageTb messageTb = new MessageTb();
            messageTb.MID = mID;
            messageTb.DateTime = dateTime;
            messageTb.Message = message;
            messageTb.Delivered = delivered;
            return messageTb;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 MID
        {
            get
            {
                return _MID;
            }
            set
            {
                if (_MID != value)
                {
                    OnMIDChanging(value);
                    ReportPropertyChanging("MID");
                    _MID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("MID");
                    OnMIDChanged();
                }
            }
        }
        private global::System.Int32 _MID;
        partial void OnMIDChanging(global::System.Int32 value);
        partial void OnMIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> GID
        {
            get
            {
                return _GID;
            }
            set
            {
                OnGIDChanging(value);
                ReportPropertyChanging("GID");
                _GID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("GID");
                OnGIDChanged();
            }
        }
        private Nullable<global::System.Int32> _GID;
        partial void OnGIDChanging(Nullable<global::System.Int32> value);
        partial void OnGIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> FromIP
        {
            get
            {
                return _FromIP;
            }
            set
            {
                OnFromIPChanging(value);
                ReportPropertyChanging("FromIP");
                _FromIP = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FromIP");
                OnFromIPChanged();
            }
        }
        private Nullable<global::System.Int32> _FromIP;
        partial void OnFromIPChanging(Nullable<global::System.Int32> value);
        partial void OnFromIPChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ToIP
        {
            get
            {
                return _ToIP;
            }
            set
            {
                OnToIPChanging(value);
                ReportPropertyChanging("ToIP");
                _ToIP = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ToIP");
                OnToIPChanged();
            }
        }
        private Nullable<global::System.Int32> _ToIP;
        partial void OnToIPChanging(Nullable<global::System.Int32> value);
        partial void OnToIPChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateTime
        {
            get
            {
                return _DateTime;
            }
            set
            {
                OnDateTimeChanging(value);
                ReportPropertyChanging("DateTime");
                _DateTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DateTime");
                OnDateTimeChanged();
            }
        }
        private global::System.DateTime _DateTime;
        partial void OnDateTimeChanging(global::System.DateTime value);
        partial void OnDateTimeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Message
        {
            get
            {
                return _Message;
            }
            set
            {
                OnMessageChanging(value);
                ReportPropertyChanging("Message");
                _Message = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Message");
                OnMessageChanged();
            }
        }
        private global::System.String _Message;
        partial void OnMessageChanging(global::System.String value);
        partial void OnMessageChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MessageType
        {
            get
            {
                return _MessageType;
            }
            set
            {
                OnMessageTypeChanging(value);
                ReportPropertyChanging("MessageType");
                _MessageType = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MessageType");
                OnMessageTypeChanged();
            }
        }
        private global::System.String _MessageType;
        partial void OnMessageTypeChanging(global::System.String value);
        partial void OnMessageTypeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Delivered
        {
            get
            {
                return _Delivered;
            }
            set
            {
                OnDeliveredChanging(value);
                ReportPropertyChanging("Delivered");
                _Delivered = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Delivered");
                OnDeliveredChanged();
            }
        }
        private global::System.Boolean _Delivered;
        partial void OnDeliveredChanging(global::System.Boolean value);
        partial void OnDeliveredChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("JModel", "FK_MessageTb_Group", "Group")]
        public Group Group
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Group>("JModel.FK_MessageTb_Group", "Group").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Group>("JModel.FK_MessageTb_Group", "Group").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Group> GroupReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Group>("JModel.FK_MessageTb_Group", "Group");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Group>("JModel.FK_MessageTb_Group", "Group", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="JModel", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="uId">Initial value of the UId property.</param>
        /// <param name="lastLogin">Initial value of the LastLogin property.</param>
        /// <param name="isActive">Initial value of the IsActive property.</param>
        public static User CreateUser(global::System.Int32 uId, global::System.DateTime lastLogin, global::System.Boolean isActive)
        {
            User user = new User();
            user.UId = uId;
            user.LastLogin = lastLogin;
            user.IsActive = isActive;
            return user;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 UId
        {
            get
            {
                return _UId;
            }
            set
            {
                if (_UId != value)
                {
                    OnUIdChanging(value);
                    ReportPropertyChanging("UId");
                    _UId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("UId");
                    OnUIdChanged();
                }
            }
        }
        private global::System.Int32 _UId;
        partial void OnUIdChanging(global::System.Int32 value);
        partial void OnUIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String UName
        {
            get
            {
                return _UName;
            }
            set
            {
                OnUNameChanging(value);
                ReportPropertyChanging("UName");
                _UName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("UName");
                OnUNameChanged();
            }
        }
        private global::System.String _UName;
        partial void OnUNameChanging(global::System.String value);
        partial void OnUNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String IP
        {
            get
            {
                return _IP;
            }
            set
            {
                OnIPChanging(value);
                ReportPropertyChanging("IP");
                _IP = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("IP");
                OnIPChanged();
            }
        }
        private global::System.String _IP;
        partial void OnIPChanging(global::System.String value);
        partial void OnIPChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Model
        {
            get
            {
                return _Model;
            }
            set
            {
                OnModelChanging(value);
                ReportPropertyChanging("Model");
                _Model = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Model");
                OnModelChanged();
            }
        }
        private global::System.String _Model;
        partial void OnModelChanging(global::System.String value);
        partial void OnModelChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime LastLogin
        {
            get
            {
                return _LastLogin;
            }
            set
            {
                OnLastLoginChanging(value);
                ReportPropertyChanging("LastLogin");
                _LastLogin = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastLogin");
                OnLastLoginChanged();
            }
        }
        private global::System.DateTime _LastLogin;
        partial void OnLastLoginChanging(global::System.DateTime value);
        partial void OnLastLoginChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                OnIsActiveChanging(value);
                ReportPropertyChanging("IsActive");
                _IsActive = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsActive");
                OnIsActiveChanged();
            }
        }
        private global::System.Boolean _IsActive;
        partial void OnIsActiveChanging(global::System.Boolean value);
        partial void OnIsActiveChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("JModel", "FK_UserState_User", "UserState")]
        public EntityCollection<UserState> UserStates
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<UserState>("JModel.FK_UserState_User", "UserState");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<UserState>("JModel.FK_UserState_User", "UserState", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="JModel", Name="UserState")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class UserState : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new UserState object.
        /// </summary>
        /// <param name="sID">Initial value of the SID property.</param>
        public static UserState CreateUserState(global::System.Int32 sID)
        {
            UserState userState = new UserState();
            userState.SID = sID;
            return userState;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SID
        {
            get
            {
                return _SID;
            }
            set
            {
                if (_SID != value)
                {
                    OnSIDChanging(value);
                    ReportPropertyChanging("SID");
                    _SID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("SID");
                    OnSIDChanged();
                }
            }
        }
        private global::System.Int32 _SID;
        partial void OnSIDChanging(global::System.Int32 value);
        partial void OnSIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> UID
        {
            get
            {
                return _UID;
            }
            set
            {
                OnUIDChanging(value);
                ReportPropertyChanging("UID");
                _UID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UID");
                OnUIDChanged();
            }
        }
        private Nullable<global::System.Int32> _UID;
        partial void OnUIDChanging(Nullable<global::System.Int32> value);
        partial void OnUIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Status
        {
            get
            {
                return _Status;
            }
            set
            {
                OnStatusChanging(value);
                ReportPropertyChanging("Status");
                _Status = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Status");
                OnStatusChanged();
            }
        }
        private global::System.String _Status;
        partial void OnStatusChanging(global::System.String value);
        partial void OnStatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Datetime
        {
            get
            {
                return _Datetime;
            }
            set
            {
                OnDatetimeChanging(value);
                ReportPropertyChanging("Datetime");
                _Datetime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Datetime");
                OnDatetimeChanged();
            }
        }
        private Nullable<global::System.DateTime> _Datetime;
        partial void OnDatetimeChanging(Nullable<global::System.DateTime> value);
        partial void OnDatetimeChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("JModel", "FK_UserState_User", "User")]
        public User User
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("JModel.FK_UserState_User", "User").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("JModel.FK_UserState_User", "User").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> UserReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("JModel.FK_UserState_User", "User");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<User>("JModel.FK_UserState_User", "User", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
