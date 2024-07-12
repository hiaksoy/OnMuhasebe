﻿using DevExpress.Blazor;
using DevExpress.Blazor.Base;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Core.Components.DevEx.DataEditors.Base
{
    public abstract class DevExBaseEditor : DxComponentBase
    {
        [Parameter] public string Caption { get; set; }
        [Parameter] public string CaptionCssClass { get; set; } = "caption";
        [Parameter] public bool CaptionVisible { get; set; } = true;
        [Parameter] public DataEditorClearButtonDisplayMode ClearButtonDisplayMode { get; set; } = DataEditorClearButtonDisplayMode.Never;
        [Parameter] public int ColumnIndex { get; set; }
        [Parameter] public int ColumnSpan { get; set; }
        [Parameter] public string EditorCssClass { get; set; }
        [Parameter] public bool Enabled { get; set; } = true;
        [Parameter] public string InputCssClass { get; set; }
        [Parameter] public bool IsFocus { get; set; }
        [Parameter] public string LayoutItemCssClass { get; set; }
        [Parameter] public string NullText { get; set; }
        [Parameter] public int RowIndex { get; set; }
        [Parameter] public int RowSpan { get; set; }
        [Parameter] public bool ReadOnly { get; set; }
        [Parameter] public string SeparateCaption { get; set; } = ":";
        [Parameter] public bool SepareteCaptionVisible { get; set; } = true;
        [Parameter] public bool Visible { get; set; } = true;

    }
}
