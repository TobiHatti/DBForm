namespace DBForm
{
    public struct TextInputData : IDomData, IDomEvents
    {
        #region 
        public string Name { get; set; }
        public string Class { get; set; }
        public string Id { get; set; }
        public string Value { get; set; }
        public string Hidden { get; set; }
        public string ReadOnly { get; set; }
        public string AdditionalValues { get; set; }
        public string OnClick { get; set; }
        public string OnChange { get; set; }
        public string OnInput { get; set; }
        public string OnMouseDown { get; set; }
        public string OnMouseUp { get; set; }
        public string OnFocus { get; set; }

        #endregion

        public string Placeholder { get; set; }
    }

    public struct NumericInputData : IDomData, IDomEvents
    {
        #region 
        public string Name { get; set; }
        public string Class { get; set; }
        public string Id { get; set; }
        public string Value { get; set; }
        public string Hidden { get; set; }
        public string ReadOnly { get; set; }
        public string AdditionalValues { get; set; }
        public string OnClick { get; set; }
        public string OnChange { get; set; }
        public string OnInput { get; set; }
        public string OnMouseDown { get; set; }
        public string OnMouseUp { get; set; }
        public string OnFocus { get; set; }

        #endregion

        public int Step { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public struct ButtonInputData : IDomData, IDomEvents
    {
        #region 
        public string Name { get; set; }
        public string Class { get; set; }
        public string Id { get; set; }
        public string Value { get; set; }
        public string Hidden { get; set; }
        public string ReadOnly { get; set; }
        public string AdditionalValues { get; set; }
        public string OnClick { get; set; }
        public string OnChange { get; set; }
        public string OnInput { get; set; }
        public string OnMouseDown { get; set; }
        public string OnMouseUp { get; set; }
        public string OnFocus { get; set; }

        #endregion
    }

    public struct ButtonElementData : IDomData, IDomEvents
    {
        #region 
        public string Name { get; set; }
        public string Class { get; set; }
        public string Id { get; set; }
        public string Value { get; set; }
        public string Hidden { get; set; }
        public string ReadOnly { get; set; }
        public string AdditionalValues { get; set; }
        public string OnClick { get; set; }
        public string OnChange { get; set; }
        public string OnInput { get; set; }
        public string OnMouseDown { get; set; }
        public string OnMouseUp { get; set; }
        public string OnFocus { get; set; }

        #endregion

        public string DisplayText { get; set; }
    }

    public struct DateTimeInputData : IDomData, IDomEvents
    {
        #region 
        public string Name { get; set; }
        public string Class { get; set; }
        public string Id { get; set; }
        public string Value { get; set; }
        public string Hidden { get; set; }
        public string ReadOnly { get; set; }
        public string AdditionalValues { get; set; }
        public string OnClick { get; set; }
        public string OnChange { get; set; }
        public string OnInput { get; set; }
        public string OnMouseDown { get; set; }
        public string OnMouseUp { get; set; }
        public string OnFocus { get; set; }

        #endregion
    }

    public struct ListStyleInputData : IDomData, IDomEvents
    {
        #region 
        public string Name { get; set; }
        public string Class { get; set; }
        public string Id { get; set; }
        public string Value { get; set; }
        public string Hidden { get; set; }
        public string ReadOnly { get; set; }
        public string AdditionalValues { get; set; }
        public string OnClick { get; set; }
        public string OnChange { get; set; }
        public string OnInput { get; set; }
        public string OnMouseDown { get; set; }
        public string OnMouseUp { get; set; }
        public string OnFocus { get; set; }
        public string Checked { get; set; }
        public string Selected { get; set; }

        #endregion
    }

    public struct ColorInputData : IDomData, IDomEvents
    {
        #region 
        public string Name { get; set; }
        public string Class { get; set; }
        public string Id { get; set; }
        public string Value { get; set; }
        public string Hidden { get; set; }
        public string ReadOnly { get; set; }
        public string AdditionalValues { get; set; }
        public string OnClick { get; set; }
        public string OnChange { get; set; }
        public string OnInput { get; set; }
        public string OnMouseDown { get; set; }
        public string OnMouseUp { get; set; }
        public string OnFocus { get; set; }

        #endregion
    }

    public struct FileInputData : IDomData, IDomEvents
    {
        #region 
        public string Name { get; set; }
        public string Class { get; set; }
        public string Id { get; set; }
        public string Value { get; set; }
        public string Hidden { get; set; }
        public string ReadOnly { get; set; }
        public string AdditionalValues { get; set; }
        public string OnClick { get; set; }
        public string OnChange { get; set; }
        public string OnInput { get; set; }
        public string OnMouseDown { get; set; }
        public string OnMouseUp { get; set; }
        public string OnFocus { get; set; }

        #endregion
    }

    public struct ImageInputData : IDomData, IDomEvents
    {
        #region 
        public string Name { get; set; }
        public string Class { get; set; }
        public string Id { get; set; }
        public string Value { get; set; }
        public string Hidden { get; set; }
        public string ReadOnly { get; set; }
        public string AdditionalValues { get; set; }
        public string OnClick { get; set; }
        public string OnChange { get; set; }
        public string OnInput { get; set; }
        public string OnMouseDown { get; set; }
        public string OnMouseUp { get; set; }
        public string OnFocus { get; set; }

        #endregion
        public string Type { get; set; }
        public string Src { get; set; }
    }
}
