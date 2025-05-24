namespace EstoqueFlow.UI.Utilitarios;

public class LayoutManager
{
    private static Dictionary<TabControl, List<TabPage>> guiasRemovidas = new Dictionary<TabControl, List<TabPage>>();

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
            dgvConfigurar.Columns[ultimaColunaIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
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
}