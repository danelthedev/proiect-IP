using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace F1Aggregator.DynamicFormObjs
{
    /// <summary>
    /// Class for creating a copy of a groupbox object
    /// </summary>
    public partial class GroupBoxReference : System.Windows.Forms.GroupBox
    {
        private System.Windows.Forms.GroupBox _groupBoxCopy;

        /// <summary>
        /// Constructor for the GroupBoxReference class
        /// </summary>
        /// <param name="groupBoxReference"></param>
        /// <param name="index"></param>
        public GroupBoxReference(System.Windows.Forms.GroupBox groupBoxReference, int index)
        {
            _groupBoxCopy = new System.Windows.Forms.GroupBox();

            _groupBoxCopy.Name = groupBoxReference.Name + index;
            _groupBoxCopy.TabIndex = groupBoxReference.TabIndex;
            _groupBoxCopy.TabStop = groupBoxReference.TabStop;
            _groupBoxCopy.Size = groupBoxReference.Size;
            _groupBoxCopy.Location = new Point(groupBoxReference.Location.X, groupBoxReference.Location.Y + groupBoxReference.Size.Height * index);
        }

        /// <summary>
        /// Method to get the GroupBox object
        /// </summary>
        public System.Windows.Forms.GroupBox GroupBox
        {
            get { return _groupBoxCopy; }
        }

    }
}
