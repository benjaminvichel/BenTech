using BenTech.Managers;
using BenTech.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BenTech
{
    public partial class UserControlDays : UserControl
    {
        private string _globalDate;
        private string _dayNumber;
        private bool isSelected;
        public UserControlDays()
        {
            InitializeComponent();
            this.AllowDrop = true;


        }

        public void Days(DateTime date)
        {
            _globalDate = date.ToString("yyyy-MM-dd"); ;
            _dayNumber = date.Day.ToString();
            lblDays.Text = _dayNumber;
        }
        internal void SetDayValue(Prices prices)
        {
            panelDisplayColorCode.BackColor = System.Drawing.ColorTranslator.FromHtml(prices.ColorCode);
            // lblCouple.Text = $"Casal: {prices.TotalCouple.ToString("C")}";
            // lblSingle.Text = $"Solteiro: {prices.TotalSingle.ToString("C")}";
            // lblTriple.Text = $"Triplo: {prices.TotalTriple.ToString("C")}";
            // lblQuadruple.Text = $"Quadruplo: {prices.TotalQuadruple.ToString("C")}";
            // lblQuintuple.Text = $"Quintuplo: {prices.TotalQuintuple.ToString("C")}";
            // lblChild03To06.Text = $"Criança 03-06: {prices.TotalChild03To06.ToString("C")}";
            // lblChild07To10.Text = $"Criança 07-10: {prices.TotalChild07To10.ToString("C")}";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            isSelected = !isSelected;
            this.BackColor = isSelected ? Color.LightBlue : Color.FromArgb(254, 254, 254);

            if (isSelected)
            {
                CalendarManager.SelectedDays.Add(this);
            }
            else { CalendarManager.SelectedDays.Remove(this); }
            // MessageBox.Show($"Você clicou no dia {_dayNumber}, selecionado: {isSelected}");
        }


        private void UserControlDays_DragEnter(object sender, DragEventArgs e)
        {
            // Verifica se os dados são do tipo esperado (PredefinedPrices)
            if (e.Data.GetDataPresent(typeof(DragDropData)))
            {
                e.Effect = DragDropEffects.Copy; // Indica que o drop é permitido
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void UserControlDays_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DragDropData)))
            {
                var dragDropData = e.Data.GetData(typeof(DragDropData)) as DragDropData;

                if (dragDropData != null && dragDropData.PredefinedPrices != null)
                {
                    var predefinedPrices = dragDropData.PredefinedPrices;
                    var predefinedPricesManager = dragDropData.Manager;

                    // Obtém o controle do dia onde o DragDrop ocorreu para adicionar na lsita caso n está.
                    var droppedDay = sender as UserControlDays;
                    var daysToProcess = new List<UserControlDays>(CalendarManager.SelectedDays);
                    if (droppedDay != null && !daysToProcess.Contains(droppedDay))
                    {
                        daysToProcess.Add(droppedDay);
                    }

                    foreach (var day in daysToProcess)
                    {
                        day.panelDisplayColorCode.BackColor = ColorTranslator.FromHtml(predefinedPrices.ColorCode);
                        predefinedPricesManager.AssignPredefinedPricesToDay(day._globalDate, predefinedPrices);
                        day.UpdateDisplayAfterDragDrop(predefinedPrices);
                        day.BackColor = Color.FromArgb(254, 254, 254);
                        day.isSelected = false;
                    }
                    CalendarManager.SelectedDays.Clear();
                    MessageBox.Show("Alterações aplicadas aos dias selecionados!");
                }
            }
        }
        private void UpdateDisplayAfterDragDrop(PredefinedPrices predefinedPrices)
        {
            //lblCouple.Text = $"Casal: {predefinedPrices.Couple.ToString("C")}";
            //lblSingle.Text = $"Solteiro: {predefinedPrices.Single.ToString("C")}";
            //lblTriple.Text = $"Triplo: {predefinedPrices.Triple.ToString("C")}";
            //lblQuadruple.Text = $"Quadruplo: {predefinedPrices.Quadruple.ToString("C")}";
            //lblQuintuple.Text = $"Quintuplo: {predefinedPrices.Quintuple.ToString("C")}";
            //lblChild03To06.Text = $"Criança 03-06: {predefinedPrices.Child03To06.ToString("C")}";
            //lblChild07To10.Text = $"Criança 07-10: {predefinedPrices.Child07To10.ToString("C")}";
        }
    }
}

