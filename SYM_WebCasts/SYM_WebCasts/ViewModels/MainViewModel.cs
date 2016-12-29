using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYM_WebCasts.ViewModels
{
    class MainViewModel
    {
        private string newTaskDescriptin;

        public string NewTaskDescription
        {
            get { return newTaskDescriptin; }
            set { newTaskDescriptin = value; }
        }

        private ObservableCollection<String> toDoList = new ObservableCollection<string>();

        public ObservableCollection<String> ToDoList
        {
            get { return toDoList; }
            set { toDoList = value; }
        }

        public MainViewModel()
        {
                ToDoList.Add("Some New Task");
                ToDoList.Add("Second New Task");
        }

    }
}
