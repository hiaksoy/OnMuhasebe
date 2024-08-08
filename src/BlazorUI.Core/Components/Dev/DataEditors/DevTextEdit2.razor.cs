namespace BlazorUI.Core.Components.Dev.DataEditors;
public partial class DevTextEdit2
{
    private DxTextBox? _dxTextBox;
    private string? _value;
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter]
    public string Value
    {
        get => _value;
        set
        {
            if (_value == value) return;
            _value = value;
            ValueChanged.InvokeAsync(value);
        }
    }
}
