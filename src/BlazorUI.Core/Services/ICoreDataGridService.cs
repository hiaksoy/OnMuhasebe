﻿namespace BlazorUI.Core.Services;
public interface ICoreDataGridService<TDataGridItem>
{
    public ComponentBase DataGrid { get; set; }
    public IList<TDataGridItem> ListDataSource { get; set; }
    public TDataGridItem SelectedItem { get; set; }
    public IEnumerable<TDataGridItem> SelectedItems { get; set; }
    public bool ShowFilterRow { get; set; }
    public bool ShowGroupPanel { get; set; }
    public bool ShowSelectionCheckBox { get; set; }
    public bool SelectFirstDataRow { get; set; }
    public bool IsLoaded { get; set; }
    public Guid PopupListPageFocusedRowId { get; set; }
    public IList<string> ExcludeListItems { get; set; }

    void ShowListPage(bool firstRender);
    void SetDataRowSelected(TDataGridItem item);
    void SetDataRowSelected(bool first);
    void FillTable<TItem>(ICoreHareketService<TItem> hareketService, Action hasChanged);
    void AddSelectedItems();

}
