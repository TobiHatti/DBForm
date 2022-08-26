namespace DBForm
{
    public enum FormType
    {
        Add,
        Edit,
        Delete,
        Sort
    }

    public enum TextInput
    {
        Text,
        Password,
        Email,
        Url,
        Search,
        Tel,
        Textarea
    }

    public enum NumericInput
    {
        Number,
        Range
    }

    public enum ButtonInput
    {
        Button,
        Submit,
        Reset
    }

    public enum ButtonElement
    {
        Button,
        Submit,
        Reset
    }

    public enum DateTimeInput
    {
        Time,
        Date,
        DateTime_Local,
        Week,
        Month
    }

    public enum ListStyleInput
    {
        Radio,
        Checkbox,
        SelectOption
    }
}
