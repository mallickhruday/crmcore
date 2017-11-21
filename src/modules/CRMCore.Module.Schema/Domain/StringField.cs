﻿using System;

namespace CRMCore.Module.Schema.Domain
{
    public class StringField : Field<StringFieldProperties>
    {
        public StringField(Guid id, string name)
            : base(id, name, new StringFieldProperties())
        {
        }

        public StringField(Guid id, string name, StringFieldProperties properties)
            : base(id, name, properties)
        {
        }
    }
}
