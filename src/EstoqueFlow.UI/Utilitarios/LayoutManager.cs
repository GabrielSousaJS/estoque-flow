using System.Linq.Expressions;

namespace EstoqueFlow.UI.Utilitarios;

public static class LayoutManager
{
    private static Dictionary<TabControl, List<TabPage>> guiasRemovidas = new Dictionary<TabControl, List<TabPage>>();
    private static List<object> TiposMovimentacao = new List<object>
    {
        new
        {
            Id = 1,
            Descricao = "Entrada"
        },
        new
        {
            Id = 2,
            Descricao = "Saída"
        }
    };

    public static async void RealizarClickVisual(Button button)
    {
        button.Focus();
        button.PerformClick();

        var originalBackColor = button.BackColor;

        button.BackColor = Color.LightGray;

        await Task.Delay(100);

        button.BackColor = originalBackColor;
    }

    public static void ConfigurarDataGridView(DataGridView dgvConfigurar)
    {
        dgvConfigurar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        int ultimaColunaIndex = dgvConfigurar.Columns.Count - 1;
        if (ultimaColunaIndex >= 0)
        {
            if (dgvConfigurar.Columns.Count > 5)
            {
                for (int i = 0; i < ultimaColunaIndex; i++)
                {
                    dgvConfigurar.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                dgvConfigurar.Columns[ultimaColunaIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                dgvConfigurar.Columns[ultimaColunaIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dgvConfigurar.Columns[ultimaColunaIndex].MinimumWidth = 100;
        }

        dgvConfigurar.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
    }

    public static void MostraApenasUmaGuia(TabControl tabControl, TabPage tabPage)
    {
        if (!guiasRemovidas.ContainsKey(tabControl))
        {
            guiasRemovidas[tabControl] = new List<TabPage>();
        }
        else
        {
            guiasRemovidas[tabControl].Clear();
        }

        foreach (TabPage page in tabControl.TabPages)
        {
            if (page != tabPage)
            {
                guiasRemovidas[tabControl].Add(page);
            }
        }

        tabControl.TabPages.Clear();

        tabControl.TabPages.Add(tabPage);
        tabControl.SelectedTab = tabPage;
    }

    public static void RestaurarGuiasRemovidas(TabControl tabControl, TabPage guiaRemovida, TabPage guiaSelecionada)
    {
        if (guiasRemovidas.ContainsKey(tabControl))
        {
            foreach (TabPage page in guiasRemovidas[tabControl])
            {
                if (!tabControl.TabPages.Contains(page))
                {
                    tabControl.TabPages.Add(page);
                }
            }

            guiasRemovidas[tabControl].Clear();
        }

        tabControl.TabPages.Remove(guiaRemovida);
        tabControl.SelectedTab = guiaSelecionada;
    }

    public static void LimparCampos(Control container)
    {
        foreach (Control control in container.Controls)
        {
            if (control is TextBox || control is MaskedTextBox)
            {
                control.Text = string.Empty;
            }
            else if (control is NumericUpDown numericUpDown)
            {
                numericUpDown.Value = numericUpDown.Minimum;
            }
            else if (control is ComboBox comboBox)
            {
                if (comboBox.Items.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                }
                else
                {
                    comboBox.SelectedIndex = -1;
                }
            }

            if (control.HasChildren)
            {
                LimparCampos(control);
            }
        }
    }

    public static void PreencherComboBox<T>(this ComboBox comboBox, IEnumerable<T> dados, string displayName, string valueName)
    {
        comboBox.DataSource = dados.ToList();
        comboBox.DisplayMember = displayName;
        comboBox.ValueMember = valueName;
    }

    public static void PreencherComboBoxTipoMovimentacao(this ComboBox comboBox)
    {
        comboBox.DataSource = TiposMovimentacao;
        comboBox.DisplayMember = "Descricao";
        comboBox.ValueMember = "Id";

    }

    public static void FormatarTextBoxNumeroDecimal(this TextBox textBox, object sender, EventArgs e, ref string valorAnteior)
    {
        string valor = textBox.Text.Replace("R$ ", "").Replace(",", "").Replace(".", "").Trim();

        if (valor.Length > 10)
        {
            textBox.Text = valorAnteior;
            textBox.SelectionStart = textBox.Text.Length;
            return;
        }

        if (decimal.TryParse(valor, out decimal value))
        {
            textBox.Text = string.Format("R$ {0:N2}", value / 100);
            textBox.SelectionStart = textBox.Text.Length;
            valorAnteior = textBox.Text;
        }
    }
}