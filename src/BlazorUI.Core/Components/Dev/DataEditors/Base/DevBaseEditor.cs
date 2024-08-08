﻿using DevExpress.Blazor;
using DevExpress.Blazor.Base;
using Microsoft.AspNetCore.Components;


namespace BlazorUI.Core.Components.Dev.DataEditors.Base
{
    public abstract class DevBaseEditor : DxComponentBase
    {
        [Parameter] public string? Caption { get; set; }
        [Parameter] public string CaptionCssClass { get; set; } = "caption";
        [Parameter] public virtual bool CaptionVisible { get; set; } = true;
        [Parameter] public DataEditorClearButtonDisplayMode ClearButtonDisplayMode { get; set; } = DataEditorClearButtonDisplayMode.Auto;
        [Parameter] public int ColumnIndex { get; set; }
        [Parameter] public int ColumnSpan { get; set; }
        [Parameter] public virtual string? EditorCssClass { get; set; } 
        [Parameter] public bool Enabled { get; set; } = true;
        [Parameter] public string? InputCssClass { get; set; }
        [Parameter] public string? LayoutItemCssClass { get; set; }
        [Parameter] public string SeparateCaption { get; set; } = ":";
        [Parameter] public string? NullText { get; set; }
        [Parameter] public bool ReadOnly { get; set; }
        [Parameter] public int RowIndex { get; set; }
        [Parameter] public int RowSpan { get; set; }
        [Parameter] public bool Visible { get; set; } = true;
        [Parameter] public virtual bool SeparateCaptionVisible { get; set; } = true;
        [Parameter] public bool IsFocus { get; set; }
    }
}
