/**************************************************************************
 *                                                                        *
 *  File:        LoadForm.cs                                              *
 *  Copyright:   (c) 2023, Arhip Constantin-Alexandru                     *
 *  E-mail:      constantin-alexandru.arhip@student.tuiasi.ro             *
 *  Description: Represents the class used to load forms inside other     *
 *               forms.                                                   *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/


using System.Linq;
using System.Windows.Forms;

namespace LoadingForms
{
    /// <summary>
    /// Class used to load forms inside other forms.
    /// </summary>
    public static class LoadForm
    {
        /// <summary>
        /// Method used to load forms inside other forms.
        /// </summary>
        /// <param name="mainPanel"></param>
        /// <param name="Form"></param>
        public static void AddForms(Panel mainPanel, object Form)
        {
            if (mainPanel.Controls.Count > 0)
            {
                mainPanel.Controls.RemoveAt(0);
            }

            Form newForm = Form as Form;
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(newForm);
            mainPanel.Tag = newForm;
            newForm.Show();
        }
    }
}
