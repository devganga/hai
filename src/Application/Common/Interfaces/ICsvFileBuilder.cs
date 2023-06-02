using hai.Application.TodoLists.Queries.ExportTodos;

namespace hai.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
