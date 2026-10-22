using System.Text.Json;
using Microsoft.JSInterop; //för att kunna anropa js-fil

namespace todos
{


    public class ToDoStorage(IJSRuntime js) : ItoDoStorage
    {

        private readonly IJSRuntime _js = js; // primärkonstruktor


        public async void Save(List<ToDo> todos)
        {
            string jsonString = JsonSerializer.Serialize(todos); //Serializerar till json
            await _js.InvokeVoidAsync("saveData", "todos", jsonString); //anropar metod saveData från js-fil med json-string
        }

      
        public async Task<List<ToDo>> Load()
        {
            string? fetchedToDos = await _js.InvokeAsync<string?>("getData", "todos");
            return JsonSerializer.Deserialize<List<ToDo>>(fetchedToDos!) ?? new List<ToDo>();
        }

        
    }
}

