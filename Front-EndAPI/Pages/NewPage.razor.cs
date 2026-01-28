using ClassLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Threading.Channels;

public class NewPageBase : ComponentBase
{

    [Inject]
    protected HttpClient Http { get; set; } = default!;
    //Ui state
    protected List<Example> items = new();
    protected bool loading = true;
    protected string? errorMessage;
    
    //Modal state
    protected bool isModalOpen = false;
    
    protected Example? example;

    protected override async Task OnInitializedAsync()
    {
        await LoadExample();
    }

    protected async Task LoadExample()
    {
        try
        {
            loading = true;
            example = await Http.GetFromJsonAsync<Example>("Example/items") ?? new();
        }
        finally
        {
            loading = false;
        }
    }

    protected async Task LoadItems()
    {
        example = await Http.GetFromJsonAsync<Example>("Example/items") ?? new();
    }

    protected async Task SaveItem()
    {
        example = await Http.GetFromJsonAsync<Example>("Example/items") ?? new();
    }

    protected async Task DeleteItem(int id)
    {
        await DeleteAsync($"Example/items/{id}");
    }

    protected async Task OpenCreateModal(){}

    protected async Task OpenEditModal(TestItem item){}

    protected async Task CloseModal(){}
}
