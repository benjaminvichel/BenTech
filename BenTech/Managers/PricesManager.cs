using BenTech.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace BenTech.Managers
{
    class PricesManager
    {

        private readonly DatabaseRepository _databaseRepository;

        public PricesManager(DatabaseRepository databaseRepository)
        {
            _databaseRepository = databaseRepository;
        }

        private string _dateStart, _dateEnd;
        public List<Prices> GetValidatedPrices(string dateStart, string dateEnd, bool validateExistence = true)
        {
            _dateStart = dateStart;
            _dateEnd = dateEnd;

            try
            {
                if (!ValidateDateTime()) { throw new Exception("Verifique a data!"); }

                if (validateExistence && !_databaseRepository.DoDatesExistInDatabase(_dateStart, _dateEnd))
                {
                    throw new Exception("Uma das datas não possui valor no banco!");
                }

                var pricesList = _databaseRepository.GetPricesInRange(_dateStart, _dateEnd);

                return pricesList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<Prices>();
            }


        }
        public Prices GetValidatedSumPrices(string dateStart, string dateEnd, bool validateExistence = true)
        {
            _dateStart = dateStart;
            _dateEnd = dateEnd;

            try
            {
                if (!ValidateDateTime()) { throw new Exception("Verifique a data!"); }

                if (validateExistence && !_databaseRepository.DoDatesExistInDatabase(_dateStart, _dateEnd))
                {
                    throw new Exception("Uma das datas não possui valor no banco!");
                }

                var prices = _databaseRepository.GetSumPricesInRange(_dateStart, _dateEnd);

                return prices;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }


        }

        public bool ValidateDateTime()
        {
            DateTime dateStart = DateTime.ParseExact(_dateStart, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime dateEnd = DateTime.ParseExact(_dateEnd, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            int res = DateTime.Compare(dateStart, dateEnd);
            if (res > 0) return false;
            dateEnd = res == 0 ? dateEnd : dateEnd.AddDays(-1); //same dates gets null values in database, so you need to add 1 day!
            _dateEnd = dateEnd.Date.ToString("yyyy-MM-dd");
            return true;
        }
      
    }
}
