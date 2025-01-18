using BenTech.Managers;
using BenTech.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BenTech.Forms
{
    public partial class EmployeeForm : Form
    {
        private readonly DatabaseRepository _databaseRepository;
        private readonly EmployeesManager _employeesManager;
        private bool _isEditMode = false; // Indica se estamos editando um funcionário
        private int _currentEmployeeId = -1; // Armazena o ID do funcionário a ser editado

        private Button currentBtn;

        public EmployeeForm()
        {
            InitializeComponent();
            _databaseRepository = new DatabaseRepository();
            _employeesManager = new EmployeesManager(_databaseRepository);
        }
        private struct RGBColors
        {
            //base colors

            public static Color color1 = Color.FromArgb(19, 100, 131); //blue dark #136483F2
            public static Color color2 = Color.FromArgb(33, 34, 39);//raising black
            public static Color color3 = Color.FromArgb(255, 255, 255); //#ffffff white color
            public static Color color4 = Color.FromArgb(240, 240, 240);//  #f0f0f0 anti-flash white


            public static Color color5 = Color.FromArgb(187, 113, 84); //#bb7154
            public static Color color6 = Color.FromArgb(102, 51, 0);//#663300 brown dark

        }

        private void ActivateButton(object SenderBtn)
        {
            DisableButton();
            if (SenderBtn != null)
            {
                currentBtn = (Button)SenderBtn;
                currentBtn.ForeColor = RGBColors.color1;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = RGBColors.color2;
            }
        }
        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            UpdateListView();
        }
        private void UpdateListView()
        {
            // Configuração do ListView
            listView1.Items.Clear();  // Limpa o ListView antes de adicionar novos itens
            listView1.Columns.Clear();
            listView1.View = View.Details;  // Define que o ListView será exibido em formato de tabela
            listView1.LabelEdit = true;    // Permite edição de rótulos (nomes das colunas)
            listView1.AllowColumnReorder = true;  // Permite reorganizar as colunas
            listView1.FullRowSelect = true; // Destaca a linha inteira quando o usuário seleciona
            listView1.GridLines = true;    // Exibe as linhas da grade

            // Adicionar as colunas
            listView1.Columns.Add("ID", 150, HorizontalAlignment.Left); // Coluna UserID
            listView1.Columns.Add("Username", 150, HorizontalAlignment.Left); // Coluna Username
            listView1.Columns.Add("IsAdmin", 75, HorizontalAlignment.Left);   // Coluna IsA

            List<Employees> employees = _employeesManager.GetAllEmployees();
            foreach (var employee in employees)
            {
                var linha_listView = new ListViewItem(employee.ID.ToString()); // Adiciona o ID na primeira coluna
                linha_listView.SubItems.Add(employee.Username);
                linha_listView.SubItems.Add(employee.IsAdmin ? "Yes" : "No");  // Adiciona "Yes" ou "No" para IsAdmin

                // Adiciona o item ao ListView
                listView1.Items.Add(linha_listView);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            _isEditMode = false;
            ctbEmployeeName.SetTextBoxText("");
            ctbEmployeePassw.SetTextBoxText("");
            cbEmployeeTF.SelectedIndex = 1;
            panelAddEmployee.Visible = true;
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            if (listView1.SelectedItems.Count > 0)  // Verifica se há um item selecionado
            {
                // Obtém o ID ou o nome do usuário da linha selecionada (assumindo que você tenha armazenado o ID como parte do item)
                var selectedItem = listView1.SelectedItems[0];
                int id = int.Parse(selectedItem.Text);  // Supondo que o ID esteja na primeira coluna (ajuste conforme necessário)

                // Chama o método de deleção
                bool success = _employeesManager.DeleteEmployee(id);

                // Atualiza a UI para refletir a remoção
                if (success)
                {
                    MessageBox.Show("Usuário deletado com sucesso!");
                    listView1.Items.Remove(selectedItem);  // Remove o item da ListView
                }
                else
                {
                    MessageBox.Show("Erro ao deletar o usuário.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um usuário para deletar.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            // Verifique se um item foi selecionado no ListView
            if (listView1.SelectedItems.Count > 0)
            {
                // Obtenha o ID do funcionário selecionado (supondo que o ID esteja na primeira coluna, por exemplo)
                int employeeId = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);

                // Recupere os dados do funcionário selecionado
                Employees selectedEmployee = _employeesManager.GetEmployeeById(employeeId);

                // Preencha os campos de texto com os dados do funcionário
                ctbEmployeeName.SetTextBoxText(selectedEmployee.Username);
                ctbEmployeePassw.SetTextBoxText(selectedEmployee.Password);
                cbEmployeeTF.SelectedItem = selectedEmployee.IsAdmin ? "True" : "False";

                // Altere para o modo de edição
                _isEditMode = true;
                _currentEmployeeId = employeeId;

                // Exiba o painel de edição
                panelAddEmployee.Visible = true;
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para editar.");
            }
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            // Verifique se todos os campos necessários estão preenchidos corretamente
            if (!string.IsNullOrEmpty(ctbEmployeeName.GetTextBoxText()) &&
                !string.IsNullOrEmpty(ctbEmployeePassw.GetTextBoxText()) &&
                cbEmployeeTF.SelectedItem != null)
            {
                // Verifique se o valor selecionado no ComboBox é "True" ou "False"
                bool isAdmin = cbEmployeeTF.SelectedItem.ToString() == "True";

                if (_isEditMode)
                {
                    // Se estamos em modo de edição, atualiza o funcionário existente
                    bool result = _employeesManager.UpdateEmployee(_currentEmployeeId, ctbEmployeeName.GetTextBoxText(),
                        ctbEmployeePassw.GetTextBoxText(), isAdmin);
                    MessageBox.Show(result ? "Funcionário atualizado com sucesso." : "Falha ao atualizar funcionário.");
                }
                else
                {
                    // Se estamos em modo de adição, adiciona um novo funcionário
                    bool result = _employeesManager.AddEmployee(ctbEmployeeName.GetTextBoxText(), ctbEmployeePassw.GetTextBoxText(), isAdmin);
                    MessageBox.Show(result ? "Funcionário adicionado com sucesso." : "Falha ao adicionar funcionário.");
                }

                UpdateListView();

                // Limpeza dos campos após salvar
                ctbEmployeeName.SetTextBoxText("");
                ctbEmployeePassw.SetTextBoxText("");
                cbEmployeeTF.SelectedIndex = -1;

                // Fecha o painel de adicionar/editar
                panelAddEmployee.Visible = false;

                // Reseta o modo de edição
                _isEditMode = false;
                _currentEmployeeId = -1;


            }
            else
            {
                // Exibe uma mensagem de erro caso os campos não estejam corretamente preenchidos
                MessageBox.Show("Por favor, preencha todos os campos corretamente.");
            }
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            if (currentBtn != (Button)sender)
            {
                Button currentButton = (Button)sender;
                currentButton.ForeColor = RGBColors.color1;
            }

        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            if (currentBtn != (Button)sender)
            {
                Button currentButton = (Button)sender;
                currentButton.ForeColor = RGBColors.color2;
            }

        }
    }
}
