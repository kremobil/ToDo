using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace todo.ViewModel
{
    public class ToDoItemViewModel
    {
        public string Title { get; set; }
        private bool IsDone { get; set; }

        public class Style
        {
            public Brush Foreground { get; set; }
            public string TextDecoration { get; set; }
            
        }
        public Style ItemStyle { get; set; }

        public ToDoItemViewModel(string title)
        {
            Title = title;
            IsDone = false;
            Style itemStyle = new Style();
            itemStyle.Foreground = new LinearGradientBrush(
                (Color)ColorConverter.ConvertFromString("#93E35D"),
                (Color)ColorConverter.ConvertFromString("#0CAD0C"),
                new Point(0, 0),
                new Point(1, 1)
            );
            itemStyle.TextDecoration = "none";
            ItemStyle = itemStyle;
        }

        public void SwitchStatus()
        {
            if (IsDone)
            {
                IsDone = false;
                Style itemStyle = new Style();
                itemStyle.Foreground = Brushes.Gray;
                itemStyle.TextDecoration = "line-through";
                ItemStyle = itemStyle;
            }
            else
            {
                IsDone = true;
                Style itemStyle = new Style();
                itemStyle.Foreground = new LinearGradientBrush(
                    (Color)ColorConverter.ConvertFromString("#93E35D"),
                    (Color)ColorConverter.ConvertFromString("#0CAD0C"),
                    new Point(0, 0),
                    new Point(1, 1)
                );
                itemStyle.TextDecoration = "none";
                ItemStyle = itemStyle;
            }
        }
    }
}