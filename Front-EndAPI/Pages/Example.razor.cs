using ClassLibrary.Models;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

public class ExampleBase : ComponentBase
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
}
