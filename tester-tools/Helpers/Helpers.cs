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

        public static int CalculateCalendarDays(DateTime dateFrom, DateTime dateTo, bool includeFromDate = false)
        {
            var fromDate = DateOnly.FromDateTime(dateFrom);
            var toDate = DateOnly.FromDateTime(dateTo);

            if (fromDate > toDate)
            {
                (fromDate, toDate) = (toDate, fromDate);
            }

            int days = toDate.DayNumber - fromDate.DayNumber;

            return includeFromDate ? days + 1 : days;
        }

        public static int CalculateBusinessDays(DateTime dateFrom, DateTime dateTo, bool includeFromDateIfMatch = false)
        {
            var fromDate = DateOnly.FromDateTime(dateFrom);
            var toDate = DateOnly.FromDateTime(dateTo);

            if (fromDate > toDate)
            {
                (fromDate, toDate) = (toDate, fromDate);
            }

            int totalDays = toDate.DayNumber - fromDate.DayNumber;
            int businessDays = 0;

            // Count business days in the range
            for (int i = 0; i <= totalDays; i++)
            {
                var currentDate = fromDate.AddDays(i);
                if (IsBusinessDay(currentDate))
                {
                    businessDays++;
                }
            }

            // Adjust if we shouldn't include fromDate date
            if (!includeFromDateIfMatch && IsBusinessDay(fromDate))
            {
                businessDays--;
            }

            return businessDays;
        }

        private static bool IsBusinessDay(DateOnly date)
        {
            return date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday;
        }
    }
}
