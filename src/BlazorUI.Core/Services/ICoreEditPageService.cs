using Volo.Abp.Application.Dtos;

namespace BlazorUI.Core.Services;
public interface ICoreEditPageService<TDataSource>
{
    public TDataSource DataSource { get; set; }
    void ButtonEditDeleteKeyDown(IEntityDto entity,string fieldName);
}
