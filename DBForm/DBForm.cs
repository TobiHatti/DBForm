using System;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using WrapSQL;

namespace DBForm
{
    public class DBFormEngine
    {
        private StringBuilder sb;
        public DBFormEngine()
        {
            sb = new StringBuilder();
        }

        public DBFormEngine ConnectSource(WrapSQLBase sqlConnection, string targetTable)
        {
            return this;
        }

        public DBFormEngine FormType(FormType type)
        {
            return this;
        }

        public DBFormEngine AddInput(TextInput type, TextInputData data, string bindColumn, bool readOnly = false) => AddTextInput(type, data, bindColumn, readOnly);
        public DBFormEngine AddInput(NumericInput type, NumericInputData data, string bindColumn, bool readOnly = false) => AddNumericInput(type, data, bindColumn, readOnly);
        public DBFormEngine AddInput(ButtonInput type, ButtonInputData data, string bindColumn, bool readOnly = false) => AddButtonInput(type, data, bindColumn, readOnly);
        public DBFormEngine AddInput(ButtonElement type, ButtonElementData data, string bindColumn, bool readOnly = false) => AddButtonElement(type, data, bindColumn, readOnly);
        public DBFormEngine AddInput(DateTimeInput type, DateTimeInputData data, string bindColumn, bool readOnly = false) => AddDateTimeInput(type, data, bindColumn, readOnly);
        public DBFormEngine AddInput(ListStyleInput type, ListStyleInputData data, string bindColumn, bool readOnly = false) => AddListStyleInput(type, data, bindColumn, readOnly);
        public DBFormEngine AddInput(ColorInputData data, string bindColumn, bool readOnly = false) => AddColorInput(data, bindColumn, readOnly);
        public DBFormEngine AddInput(FileInputData data, string bindColumn, bool readOnly = false) => AddFileInput(data, bindColumn, readOnly);
        public DBFormEngine AddInput(ImageInputData data, string bindColumn, bool readOnly = false) => AddImageInput(data, bindColumn, readOnly);

        public DBFormEngine AddTextInput(TextInput type, TextInputData data, string bindColumn, bool readOnly = false)
        {
            sb.Append(CreateGenericInputElement(type, typeof(TextInput), CreateAtttributeList(data, typeof(TextInputData))));

            return this;
        }

        public DBFormEngine AddNumericInput(NumericInput type, NumericInputData data, string bindColumn, bool readOnly = false)
        {
            return this;
        }
        public DBFormEngine AddButtonInput(ButtonInput type, ButtonInputData data, string bindColumn, bool readOnly = false)
        {
            return this;
        }
        public DBFormEngine AddButtonElement(ButtonElement type, ButtonElementData data, string bindColumn, bool readOnly = false)
        {
            return this;
        }
        public DBFormEngine AddDateTimeInput(DateTimeInput type, DateTimeInputData data, string bindColumn, bool readOnly = false)
        {
            return this;
        }
        public DBFormEngine AddListStyleInput(ListStyleInput type, ListStyleInputData data, string bindColumn, bool readOnly = false)
        {
            return this;
        }
        public DBFormEngine AddColorInput(ColorInputData data, string bindColumn, bool readOnly = false)
        {
            return this;
        }
        public DBFormEngine AddFileInput(FileInputData data, string bindColumn, bool readOnly = false)
        {
            return this;
        }
        public DBFormEngine AddImageInput(ImageInputData data, string bindColumn, bool readOnly = false)
        {
            return this;
        }
        public string Build()
        {
            return sb.ToString();
        }

        private string CreateGenericInputElement(Enum inputType, Type enumType, string attributes)
        {
            return $@"<input type=""{Enum.GetName(enumType, inputType).ToLower().Replace('_', '-')}"" {attributes}/>"; ;
        }

        private string CreateAtttributeList(IDomData data, Type dataType)
        {
            StringBuilder sb = new StringBuilder();
            foreach (FieldInfo field in dataType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
            {
                string fieldName = Regex.Match(field.Name.ToLower(), @"(?<=\<).+?(?=\>)").ToString();
                if (!string.IsNullOrEmpty(field.GetValue(data)?.ToString()))
                {
                    if (fieldName != "additionalvalues")
                        sb.Append($@"{fieldName}=""{field.GetValue(data)}"" ");
                    else
                        sb.Append($"{field.GetValue(data)} ");
                }

            }

            return sb.ToString();
        }
    }
}