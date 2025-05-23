namespace EstoqueFlow.UI.Utilitarios;

public class LayoutManager
{
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
        tabControl.TabPages.Clear();

        tabControl.TabPages.Add(tabPage);
        tabControl.SelectedTab = tabPage;
    }
}