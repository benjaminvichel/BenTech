using BenTech.Models;
using BenTech.UserControls;
using System.Windows.Forms;

namespace BenTech.Managers
{
    class PredefinedPricesManager
    {
        private DatabaseRepository _databaseRepository;
        private Panel _showPredefinedPrices;



        public PredefinedPricesManager(DatabaseRepository databaseRepository)
        {
            _databaseRepository = databaseRepository;
        }

        //predefinedprices methods----------
        public void CreateOrUpdatePredefinedPriceDatabase(PredefinedPrices predefinedPrices)
        {
            _databaseRepository.CreateOrUpdatePredefinedPriceDatabase(predefinedPrices);
        }

        public void GetPredefinedPrices(Panel displayPredefinedPrices)
        {
            foreach (Control control in displayPredefinedPrices.Controls)
            {
                if (control is Panel panel && panel.Name == "fpanelPredefinedPricesInner")
                {
                    _showPredefinedPrices = panel;
                    break;
                }
            }
            _showPredefinedPrices.Controls.Clear();

            foreach (PredefinedPrices i in _databaseRepository.GetPredefinedPrices())
            {
                UserControlPredefinedPrices UCpredefinedPrices = new UserControlPredefinedPrices(this);
                UCpredefinedPrices.DisplayColorAndName(i);
                _showPredefinedPrices.Controls.Add(UCpredefinedPrices);
            }
        }
        public void AssignPredefinedPricesToDay(string day, PredefinedPrices prices)
        {
            _databaseRepository.AssignPredefinedPricesToDay(day, prices);
        }
        public void DeletePredefinedPrice(string color)
        {

            _databaseRepository.DeletePredefinedPrice(color);
        }
    }
}
