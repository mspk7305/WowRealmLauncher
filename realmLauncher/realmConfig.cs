﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class config {
    
    private configRealm[] realmsField;
    
    private configClient[] clientsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("realm", IsNullable=false)]
    public configRealm[] realms {
        get {
            return this.realmsField;
        }
        set {
            this.realmsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("client", IsNullable=false)]
    public configClient[] clients {
        get {
            return this.clientsField;
        }
        set {
            this.clientsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class configRealm {
    
    private string nameField;
    
    private string realmlistField;
    
    private string patchlistField;
    
    private string clientversionField;
    
    private string websiteField;
    
    private byte idField;
    
    /// <remarks/>
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    public string realmlist {
        get {
            return this.realmlistField;
        }
        set {
            this.realmlistField = value;
        }
    }
    
    /// <remarks/>
    public string patchlist {
        get {
            return this.patchlistField;
        }
        set {
            this.patchlistField = value;
        }
    }
    
    /// <remarks/>
    public string clientversion {
        get {
            return this.clientversionField;
        }
        set {
            this.clientversionField = value;
        }
    }
    
    /// <remarks/>
    public string website {
        get {
            return this.websiteField;
        }
        set {
            this.websiteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class configClient {
    
    private string clientversionField;
    
    private string clientpathField;
    
    private byte idField;
    
    /// <remarks/>
    public string clientversion {
        get {
            return this.clientversionField;
        }
        set {
            this.clientversionField = value;
        }
    }
    
    /// <remarks/>
    public string clientpath {
        get {
            return this.clientpathField;
        }
        set {
            this.clientpathField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}