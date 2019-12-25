using System.Windows.Forms;

namespace TaskManager
{
    class Program
    {
        static public TaskManagerForm FormTask;
        static void Main()
        {
            FormTask = new TaskManagerForm();
            Application.Run(FormTask);
        }
    }
}