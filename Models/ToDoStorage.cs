using System.Text.Json; //för att kunna serialisera till json-format
using Microsoft.JSInterop; //för att kunna anropa js-fil

namespace todos
{


    //Klassen tar emot en instans av IJSRuntime och sparar i privat readonly fält 
    // Detta görs för att sedan kunna anropa metoderna från js-filen
    public class ToDoStorage(IJSRuntime js) : ItoDoStorage //implementerar interfacet
    {

        private readonly IJSRuntime _js = js; // primärkonstruktor

        /*Metod som tar emot lista av ToDo, serialiserar denna samt anropar js-funktionen
        för att lagra i localStorage*/
        public async void Save(List<ToDo> todos)
        {
            string jsonString = JsonSerializer.Serialize(todos); //Serializerar till json
            await _js.InvokeVoidAsync("saveData", "todos", jsonString); //anropar metod saveData från js-fil med json-string
        }

        /*Metod som anropar js-funktionen för att hämta data från localStorage, 
        och returnerar en deserialiserad lista av ToDo eller en tom lista av ToDo om det 
        ej gick att deserialisera*/
        public async Task<List<ToDo>> Load()
        {
            string? fetchedToDos = await _js.InvokeAsync<string?>("getData", "todos");
            return JsonSerializer.Deserialize<List<ToDo>>(fetchedToDos!) ?? new List<ToDo>();
        }


    }
}

