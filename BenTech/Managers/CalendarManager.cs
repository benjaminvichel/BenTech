using BenTech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BenTech.Managers
{
    class CalendarManager
    {
        // Variáveis para armazenar o mês e o ano atuais
        private int currentYear = DateTime.Now.Year;
        private int currentMonth = DateTime.Now.Month;
        public static List<UserControlDays> SelectedDays { get; private set; } = new List<UserControlDays>();



        // Método para exibir os dias do calendário
        public void DisplayCalendarDays(Panel calendarPanel, DateTimePicker dateTimePickerCalendar, int selectedMonth, int selectedYear, PricesManager pricesManager)
        {
            // Atualiza o DateTimePicker para o mês e ano selecionados
            dateTimePickerCalendar.Value = new DateTime(selectedYear, selectedMonth, 1);

            // Limpa os controles do painel
            calendarPanel.Controls.Clear();

            // Primeiro dia do mês
            DateTime firstDayOfMonth = new DateTime(selectedYear, selectedMonth, 1);

            // Número de dias no mês
            int days = DateTime.DaysInMonth(selectedYear, selectedMonth);

            // Dia da semana do primeiro dia do mês (como número)
            int daysofTheweek = Convert.ToInt32(firstDayOfMonth.DayOfWeek.ToString("d"));

            // Obtém as datas de início e fim do mês
            var (dateStart, dateEnd) = GetStartAndEndOfMonth(selectedMonth, selectedYear);

            List<Prices> pricesList = pricesManager.GetValidatedPrices(dateStart.ToString("yyyy-MM-dd"), dateEnd.ToString("yyyy-MM-dd"),false);
    
            // Cria um dicionário para associar datas específicas aos preços correspondentes
            var pricesByDate = pricesList.ToDictionary(p => p.Data, p => p);

            // Adiciona espaços em branco antes do primeiro dia do mês
            for (int i = 1; i <= daysofTheweek; i++)
            {
                UserControlBLANK ucblank = new UserControlBLANK();
             
                calendarPanel.Controls.Add(ucblank);
            }

            // Adiciona os dias do mês
            for (int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
               
                DateTime exactDay = new DateTime(selectedYear, selectedMonth, i);
                ucdays.Days(exactDay);

                if (pricesByDate.TryGetValue(exactDay, out var dayPrices))
                {
                    ucdays.SetDayValue(dayPrices);
                }
                ucdays.Dock = DockStyle.Fill;
                calendarPanel.Controls.Add(ucdays);
            }
        }

   

        // Método para obter o início e o fim do mês
        public (DateTime, DateTime) GetStartAndEndOfMonth(int selectedMonth, int selectedYear)
        {
            DateTime firstDayOfMonth = new DateTime(selectedYear, selectedMonth, 1);
            DateTime lastDayOfMonth = new DateTime(selectedYear, selectedMonth, DateTime.DaysInMonth(selectedYear, selectedMonth));
            return (firstDayOfMonth, lastDayOfMonth);
        }
    }
}