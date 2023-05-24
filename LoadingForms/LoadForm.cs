using System.Linq;
using System.Windows.Forms;

namespace LoadingForms
{
    public static class LoadForm
    {
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
