using ClassLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

public class NewPageBase : ComponentBase
{
    [Inject]
    protected HttpClient Http { get; set; } = default!;

    protected Example? example;

    protected override async Task OnInitializedAsync()
    {
        await LoadExample();
    }

    protected async Task LoadExample()
    {
        example = await Http.GetFromJsonAsync<Example>("Example/items") ?? new();
    }

    protected async Task LoadItems()
    {
        example = await Http.GetFromJsonAsync<Example>("Example/items") ?? new();
    }

    protected async Task SaveItem(){}

    protected async Task asyncDeleteItem(int id){}

    protected async Task OpenCreateModal(){}

    protected async Task OpenEditModal(TestItem item){}

    protected async Task CloseModal() {}
}
