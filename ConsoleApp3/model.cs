


public class DerivatesResult
{
    public string  Male{ get; set; }
    public string Female { get; set; }
}




// UWAGA: Wygenerowany kod może wymagać co najmniej programu .NET Framework 4.5 lub .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute("array-list", Namespace = "", IsNullable = false)]
public partial class arraylist
{

    private arraylistLexicalunit[] lexicalunitField;

    private arraylistLexicalrelations[] lexicalrelationsField;

    private string ownerField;

    private string dateField;

    private string versionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("lexical-unit")]
    public arraylistLexicalunit[] lexicalunit
    {
        get
        {
            return this.lexicalunitField;
        }
        set
        {
            this.lexicalunitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("lexicalrelations")]
    public arraylistLexicalrelations[] lexicalrelations
    {
        get
        {
            return this.lexicalrelationsField;
        }
        set
        {
            this.lexicalrelationsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string owner
    {
        get
        {
            return this.ownerField;
        }
        set
        {
            this.ownerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class arraylistLexicalunit
{

    private int idField;

    private string nameField;

    private string posField;

    private int tagcountField;

    private string domainField;

    private string descField;

    private string workstateField;

    private string sourceField;

    private int variantField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int id
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string pos
    {
        get
        {
            return this.posField;
        }
        set
        {
            this.posField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int tagcount
    {
        get
        {
            return this.tagcountField;
        }
        set
        {
            this.tagcountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string domain
    {
        get
        {
            return this.domainField;
        }
        set
        {
            this.domainField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string desc
    {
        get
        {
            return this.descField;
        }
        set
        {
            this.descField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string workstate
    {
        get
        {
            return this.workstateField;
        }
        set
        {
            this.workstateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string source
    {
        get
        {
            return this.sourceField;
        }
        set
        {
            this.sourceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int variant
    {
        get
        {
            return this.variantField;
        }
        set
        {
            this.variantField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class arraylistLexicalrelations
{

    private int parentField;

    private int childField;

    private int relationField;

    private bool validField;

    private string ownerField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int parent
    {
        get
        {
            return this.parentField;
        }
        set
        {
            this.parentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int child
    {
        get
        {
            return this.childField;
        }
        set
        {
            this.childField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public int relation
    {
        get
        {
            return this.relationField;
        }
        set
        {
            this.relationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool valid
    {
        get
        {
            return this.validField;
        }
        set
        {
            this.validField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string owner
    {
        get
        {
            return this.ownerField;
        }
        set
        {
            this.ownerField = value;
        }
    }
}

