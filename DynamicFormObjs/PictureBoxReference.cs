using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Aggregator.DynamicFormObjs
{
    /// <summary>
    /// Class for creating a copy of a PictureBox object
    /// </summary>
    public partial class PictureBoxReference: System.Windows.Forms.PictureBox
    {
        private System.Windows.Forms.PictureBox _pictureBoxCopy;

        /// <summary>
        /// Constructor for the PictureBoxReference class
        /// </summary>
        /// <param name="pictureBoxReference"></param>
        /// <param name="index"></param>
        public PictureBoxReference(System.Windows.Forms.PictureBox pictureBoxReference, int index)
        {
            _pictureBoxCopy = new System.Windows.Forms.PictureBox();
            
            _pictureBoxCopy.Name = pictureBoxReference.Name + index;
            _pictureBoxCopy.TabIndex = pictureBoxReference.TabIndex;
            _pictureBoxCopy.Size = pictureBoxReference.Size;
            _pictureBoxCopy.Location = new System.Drawing.Point(pictureBoxReference.Location.X, pictureBoxReference.Location.Y +  index%3);
        }
        /// <summary>
        /// Method to get the PictureBox object
        /// </summary>
        public System.Windows.Forms.PictureBox PictureBox
        {
            get { return _pictureBoxCopy; }
        }
    }
}
