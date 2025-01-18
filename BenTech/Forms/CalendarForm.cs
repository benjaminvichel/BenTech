using BenTech.Managers;
using System;
using System.Windows.Forms;

namespace BenTech.Forms
{
    public partial class CalendarForm : Form
    {
        private bool isConfirmedSelection = false;//confirms that the user changed the value in DatetimePickerCalendar
        private readonly DatabaseRepository _databaseRepository;
        private CalendarManager _calendarManager = new CalendarManager();
        private readonly PricesManager _pricesManager;
        private PredefinedPricesManager _predefinedPricesManager;
       
        //timer
        private Timer resizeTimer;
        public CalendarForm()
        {
            InitializeComponent();

            // Inicializa o Timer
            resizeTimer = new Timer();
            resizeTimer.Interval = 100;  // Intervalo de 100ms para aguardar o final do redimensionamento
            resizeTimer.Tick += ResizeTimer_Tick;


            _databaseRepository = new DatabaseRepository();
            _pricesManager = new PricesManager(_databaseRepository);
            _predefinedPricesManager = new PredefinedPricesManager(_databaseRepository);

            //catch events
            PredefinedPricesForm.OnPricesUpdated += HandlePricesUpdated;
        }

        private void HandlePricesUpdated() {
            DisplayCalendar();
            ShowPredefinedPrices();
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {

            DisplayCalendar();
            ShowPredefinedPrices();
        }
        public void DisplayCalendar(int addOrRemoveMonth = 0)
        {
            dateTimePickerCalendar.Value = dateTimePickerCalendar.Value.AddMonths(addOrRemoveMonth);
            // Obtém o mês e o ano selecionados no DateTimePicker
            int selectedMonth = dateTimePickerCalendar.Value.Month;
            int selectedYear = dateTimePickerCalendar.Value.Year;

            // Chama o método para exibir o calendário com o mês e ano selecionados
            _calendarManager.DisplayCalendarDays(calendarPanel, dateTimePickerCalendar, selectedMonth, selectedYear, _pricesManager);
        }

        private void CalendarForm_Resize(object sender, EventArgs e)
        {
            resizeTimer.Stop();
            resizeTimer.Start();
        }

        private void ResizeTimer_Tick(object sender, EventArgs e)
        {
            // Para o Timer, pois o redimensionamento foi concluído
            resizeTimer.Stop();

            // Chama a função para ajustar os controles
           // ResizeCalendarControls();
        }

        private void dateTimePickerCalendar_ValueChanged(object sender, EventArgs e)
        {
            isConfirmedSelection = true;
          
        }

        private void dateTimePickerCalendar_CloseUp(object sender, EventArgs e)
        {
            if (isConfirmedSelection)
            {
                // Obtém o mês e o ano selecionados
                int selectedMonth = dateTimePickerCalendar.Value.Month;
                int selectedYear = dateTimePickerCalendar.Value.Year;

                // Atualiza o calendário com o mês e ano selecionados
                DisplayCalendar();

                // Reseta a flag
                isConfirmedSelection = false;
            }
        }

        private void pbPreviousMonth_Click(object sender, EventArgs e)
        {
            DisplayCalendar(-1);
        }

        private void pbNextMonth_Click(object sender, EventArgs e)
        {
            DisplayCalendar(+1);
        }

//predefined Prices

        private void ShowPredefinedPrices()
        {
            _predefinedPricesManager.GetPredefinedPrices(panelPredefinedPrices);
        }

        private void ibtnCreateNewPredefinedValues_Click(object sender, EventArgs e)
        {
            var form = new PredefinedPricesForm(_predefinedPricesManager);
            form.ShowDialog();
        }
    }
}
