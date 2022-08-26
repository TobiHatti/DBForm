namespace DBForm
{
    public interface IDomData
    {
        string Name { get; set; }
        string Class { get; set; }
        string Id { get; set; }
        string Value { get; set; }
        string Hidden { get; set; }
        string ReadOnly { get; set; }
        string AdditionalValues { get; set; }
    }

    public interface IDomEvents
    {
        string OnClick { get; set; }
        string OnChange { get; set; }
        string OnInput { get; set; }
        string OnMouseDown { get; set; }
        string OnMouseUp { get; set; }
        string OnFocus { get; set; }
    }
}
