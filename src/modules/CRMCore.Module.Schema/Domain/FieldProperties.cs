﻿namespace CRMCore.Module.Schema.Domain
{
    public abstract class FieldProperties : NamedElementPropertiesBase
    {
        public bool IsRequired { get; set; }

        public bool IsListField { get; set; }

        public string Placeholder { get; set; }
    }
}
