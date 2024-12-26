//Console.Write("Введите дату (ДД.ММ.ГГГГ): ");
//string inputDate = Console.ReadLine();
//DateTime date;
//bool isValid = DateTime.TryParseExact(inputDate, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out date);

//if (!isValid)
//{
//    Console.WriteLine("Неверный формат даты. Попробуйте еще раз.");
//    return;
//}

//int daysPassed = date.DayOfYear;
//Console.WriteLine($"Количество дней, прошедших от начала года до {date:d}: {daysPassed}.");



Console.Write("Введите дату и время визита (ДД.ММ.ГГГГ ЧЧ:ММ): ");
string inputDateTime = Console.ReadLine();
DateTime visitDateTime;
bool isValid = DateTime.TryParseExact(inputDateTime, "dd.MM.yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out visitDateTime);

if (!isValid)
{
    Console.WriteLine("Неверный формат даты и времени. Попробуйте еще раз.");
    return;
}
DateTime currentTime = DateTime.Now;
TimeSpan timeLeft = visitDateTime - currentTime;
string partOfDay = visitDateTime.Hour < 12 ? "первой половине дня" : "второй половине дня";
Console.WriteLine($"До визита к доктору осталось {timeLeft.Hours} часов и {timeLeft.Minutes} минут. Визит состоится в {partOfDay}.");