using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Aggregator.DynamicFormObjs
{
    /// <summary>
    /// Class for creating a copy of a label object
    /// </summary>
    public partial class LabelReference : System.Windows.Forms.Label
    {
        private System.Windows.Forms.Label _labelCopy;

        /// <summary>
        /// Constructor for the LabelReference class
        /// </summary>
        /// <param name="labelReference"></param>
        /// <param name="index"></param>
        public LabelReference(System.Windows.Forms.Label labelReference, int index)
        {
            _labelCopy = new System.Windows.Forms.Label();
            
            _labelCopy.AutoSize = labelReference.AutoSize;
            _labelCopy.Name = labelReference.Name + index;
            _labelCopy.TabIndex = labelReference.TabIndex;
            _labelCopy.Text = labelReference.Text;
            _labelCopy.Size = labelReference.Size;
            _labelCopy.Location = new System.Drawing.Point(labelReference.Location.X, labelReference.Location.Y + index%3);
        }

        /// <summary>
        /// Method to get the Label object
        /// </summary>
        public System.Windows.Forms.Label Label
        {
            get { return _labelCopy; }
        }
    }
}
