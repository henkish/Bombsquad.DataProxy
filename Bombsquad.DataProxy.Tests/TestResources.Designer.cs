﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bombsquad.DataProxy.Tests {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TestResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TestResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Bombsquad.DataProxy.Tests.TestResources", typeof(TestResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to if object_id(&apos;dbo.UserMessages&apos;) is not null
        ///begin
        ///  drop table dbo.UserMessages
        ///end
        ///
        ///if object_id(&apos;dbo.Users&apos;) is not null
        ///begin
        ///  drop table dbo.Users
        ///end
        ///
        ///go
        ///
        ///create table dbo.Users
        ///(
        ///	UserId int identity(1,1) not null,
        ///	FirstName varchar(64) not null,
        ///	LastName varchar(64) not null,
        ///	EmailAddress varchar(128) not null,
        ///	BirthDate smalldatetime null,
        ///    constraint PK_Users primary key clustered ( UserId asc )
        ///)
        ///
        ///go
        ///
        ///create table dbo.UserMessages
        ///(
        ///	MessageId int identity(1,1) n [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string IntegrationTestInitScript {
            get {
                return ResourceManager.GetString("IntegrationTestInitScript", resourceCulture);
            }
        }
    }
}
