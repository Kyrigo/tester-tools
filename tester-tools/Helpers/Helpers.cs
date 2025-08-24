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

        public static int DaysBetweenDates(DateTime dateFrom, DateTime dateTo)
        {
            if (dateFrom == dateTo)
            {
                return 0;
            }

            return dateTo.Subtract(dateFrom).Days;
        }
    }
}
