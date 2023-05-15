using System.Collections.ObjectModel;

namespace todo.ViewModel
{
    public class ToDoListViewModel
    {
        public static ObservableCollection<ToDoItemViewModel> ToDoList { get; set; }

        public static void AddItem(string name)
        {
            ToDoList.Add(new ToDoItemViewModel(name));
        }

        public ToDoListViewModel()
        {
            ToDoList = new ObservableCollection<ToDoItemViewModel>();
        }
    }
}