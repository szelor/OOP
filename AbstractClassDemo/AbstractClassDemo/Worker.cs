using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            List<Control> controls = new List<Control>();
            Button button = new Button(0,100,"click me");
            ListBox listBox = new ListBox(100, 300, new List<String>());
            Button cancelButton = new Button(150, 100, "cancel");

            controls.Add(button);
            controls.Add(listBox);
            controls.Add(cancelButton);

            foreach (Control control in controls)
            {
                control.Draw();
            }
        }
    }


}
