// See https://aka.ms/new-console-template for more information
using DBForm;
using WrapSQL;

WrapMySQL sql = new WrapMySQL("####", "####", "####", "####");

string form = new DBFormEngine()
    .ConnectSource(sql, "SomeTableIDK")
    .FormType(FormType.Add)
    .AddTextInput(TextInput.Url, new TextInputData { Name = "123", Placeholder = "123", AdditionalValues = @"radomStuff=""adasdasd""" }, "")
    .Build();


Console.WriteLine(form);