using System.Text.Json;
using Microsoft.JSInterop; //för att kunna anropa js-fil

namespace todos
{


    public class ToDoStorage(IJSRuntime js) //: ItoDoStorage
    {

        private readonly IJSRuntime _js = js; // primärkonstruktor


        public async Task Save(List<ToDo> todos)
        {
            string jsonString = JsonSerializer.Serialize(todos); //Serializerar till json
            await _js.InvokeVoidAsync("saveData", "todos", jsonString); //anropar metod saveData från js-fil med json-string
        }

        public async Task<List<ToDo>> Load()
        {
            return await _js.InvokeAsync<List<ToDo>>("getData", "todos");
        }

       /* public async Task<string?> Load()
        {
            return await _js.InvokeAsync<string?>("getData", "test");
        }*/

        
    }
}

