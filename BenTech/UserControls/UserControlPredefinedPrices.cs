using BenTech.Forms;
using BenTech.Managers;
using BenTech.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BenTech.UserControls
{
    public partial class UserControlPredefinedPrices : UserControl
    {
        private Point _dragStartPoint;
        private Color _color;
        private PredefinedPrices _predefinedPrices;
        private PredefinedPricesManager _predefinedPricesManager;
        // Define o evento para notificar mudanças
        public event Action OnPredefinedPricesUpdated;
  
        internal UserControlPredefinedPrices(PredefinedPricesManager predefinedPricesManager)
        {
            _predefinedPricesManager = predefinedPricesManager;
            InitializeComponent();
        }
        internal void DisplayColorAndName(PredefinedPrices predefinedPrices)
        {
            _predefinedPrices = predefinedPrices;
            _color = ColorTranslator.FromHtml(predefinedPrices.ColorCode);
            lblName.Text = $"{predefinedPrices.Name}";
            PanelColor.BackColor = _color;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            PredefinedPricesForm predefinedPricesForm = new PredefinedPricesForm();

            predefinedPricesForm.DisplayToEdit(_predefinedPrices, _predefinedPricesManager);
            predefinedPricesForm.ShowDialog();
            OnPredefinedPricesUpdated?.Invoke();
        }

        private void PanelColor_MouseDown(object sender, MouseEventArgs e)
        {
            var dataToSend = new DragDropData
            {
                PredefinedPrices = _predefinedPrices,
                Manager = _predefinedPricesManager
            };

            PanelColor.DoDragDrop(dataToSend, DragDropEffects.Copy);
        }

        private void lblName_MouseMove(object sender, MouseEventArgs e)
        {
         
        }

        private void lblName_MouseDown(object sender, MouseEventArgs e)
        {
            //do nothing
        }
    }
}
