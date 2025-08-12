namespace tester_tools.Helpers
{
    internal class Helpers
    {
        public static void CheckTINMessage(bool result)
        {
            if (result)
            {
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBox.Show("ИНН корректный", "Проверка ИНН", MessageBoxButtons.OK, icon);
            }
            else
            {
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox.Show("ИНН некорректный", "Проверка ИНН", MessageBoxButtons.OK, icon);
            }
        }
    }
}
