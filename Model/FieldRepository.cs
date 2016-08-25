using System;
using System.Linq;

namespace WFFM.SQLServer.SaveToDatabase.Model
{
    class FieldRepository
    {
        public Field Get(Form form, Guid fieldId)
        {
            return form == null ? null : form.Field.FirstOrDefault(field => field.FieldId == fieldId);
        }
    }
}
