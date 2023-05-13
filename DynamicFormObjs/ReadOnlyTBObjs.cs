using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Aggregator.DynamicFormObjs
{
    /// <summary>
    /// Class for making textbox objects read only
    /// </summary>
    public class ReadOnlyTBObjs
    {
        private System.Windows.Forms.Panel _panel;

        /// <summary>
        /// Getting the panel from the interface via the constructor
        /// </summary>
        /// <param name="panel"></param>
        public ReadOnlyTBObjs(System.Windows.Forms.Panel panel)
        {
            _panel = panel;
        }

        /// <summary>
        /// Method to make the textbox objects read only
        /// </summary>
        public void MakeObjReadOnly()
        {
            foreach (Control C in _panel.Controls)
            {
                if(C is GroupBox)
                {
                    foreach(Control T in C.Controls)
                    {
                        if (T is TextBox || T is RichTextBox)
                        {
                            T.Enabled = true;
                            T.Enabled = false;
                        }
                    } 
                }
            }    
        }
    }
}
