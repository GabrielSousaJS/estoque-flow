namespace EstoqueFlow.UI.Utilitarios;

public class EfeitosVisuais
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
}
