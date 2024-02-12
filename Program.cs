using System;
using System.Linq;

namespace Theme26;

public static class Program
{
    static void Main()
    {
        // 1. Ввести две даты и определить количество дней между ними.
        DateTime date1 = new DateTime(2022, 2, 15);
        DateTime date2 = new DateTime(2022, 3, 20);
        int daysDifference = DateHelper.GetDaysDifference(date1, date2);
        Console.WriteLine($"Days between the two dates: {daysDifference}");

        Console.WriteLine();

        // 2. Определить, сколько дней осталось до конца месяца.
        DateTime dateNow = DateTime.Today;
        int daysRemainingInMonth = DateHelper.GetDaysRemainingInMonth(dateNow);
        Console.WriteLine($"Days remaining in the month: {daysRemainingInMonth}");

        Console.WriteLine();

        // 3. Ввести свою дату рождения и вывести информацию
        DateTime birthday = new DateTime(2000, 5, 25);
        DateHelper.GetBirthdayInfo(birthday);
    }
}
	}
}
