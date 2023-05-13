using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Aggregator.DynamicFormObjs
{
    /// <summary>
    /// Class for creating a copy of a TextBox object
    /// </summary>
    public partial class TextBoxReference : System.Windows.Forms.TextBox
    {
        private System.Windows.Forms.TextBox _textBoxCopy;

        /// <summary>
        /// Constructor for the TextBoxReference class
        /// </summary>
        /// <param name="textBoxReference"></param>
        /// <param name="index"></param>
        public TextBoxReference(System.Windows.Forms.TextBox textBoxReference, int index)
        {
            _textBoxCopy = new System.Windows.Forms.TextBox();
            
            _textBoxCopy.ReadOnly = textBoxReference.ReadOnly;
            _textBoxCopy.Name = textBoxReference.Name + index;
            _textBoxCopy.TabIndex = textBoxReference.TabIndex;
            _textBoxCopy.Size = textBoxReference.Size;
            _textBoxCopy.Location = new System.Drawing.Point(textBoxReference.Location.X, textBoxReference.Location.Y + index%3);
            _textBoxCopy.Enabled = textBoxReference.Enabled;
        }

        /// <summary>
        /// Method to get the TextBox object
        /// </summary>
        public System.Windows.Forms.TextBox TextBox
        {
            get { return _textBoxCopy; }
        }
    }
}
