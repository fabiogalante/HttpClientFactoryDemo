using HttpClientFactoryProject.Models;
using System.Threading.Tasks;
using Refit;

namespace HttpClientFactoryProject.Services
{
    public interface ITodoService
    {
        [Get("/todos/{id}")]
        Task<TodoModel> GetTodo(int id);
    }
}
