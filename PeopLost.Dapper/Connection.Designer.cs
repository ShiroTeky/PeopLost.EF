﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PeopLost.Dapper {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Connection : global::System.Configuration.ApplicationSettingsBase {
        
        private static Connection defaultInstance = ((Connection)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Connection())));
        
        public static Connection Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=(LocalDb)\\v11.0;Initial Catalog=bdlostConnectionString;Integrated Sec" +
            "urity=True")]
        public string bdlostConnectionString {
            get {
                return ((string)(this["bdlostConnectionString"]));
            }
        }
    }
}
