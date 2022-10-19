using M3HW4_2.Models;

namespace M3HW4_2
{
    public class Starter
    {
        private List<Contact> Contacts { get; } = new List<Contact>
        {
            new Contact("Vlad", "Petrov", "Olegovich", 20, "0957178012"),
            new Contact("Діма", "Кравцов", "Іванович", 15, "0638166583"),
            new Contact("Anton", "Gromov", "Antonovich", 18, "0951946156"),
            new Contact("Gennadiy", "Panov", "Oleksandrovich", 78, "0508641585"),
            new Contact("Максим", "Ілларіонов", "Юрійович", 43, "0680243923"),
            new Contact("Роман", "Каменюка", "Павлович", 37, "0980427548"),
            new Contact("Robert", "Filatov", "Timurovich", 49, "0680285993"),
            new Contact("Ostap", "Vushnya", "Evgenovich", 12, "0560235775"),
            new Contact("Vlad", "Denisov", "Oleksandrovich", 25, "0999257379"),
            new Contact("Міша", "Шкарлат", "Дмитрович", 17, "0680348434"),
            new Contact("Gennadiy", "Piantkovskiy", "Kirillovich", 9, "0679389592"),
            new Contact("Валерій", "Латов", "Olegovich", 56, "0539891868"),
        };

        public void Run()
        {
            var firstOrDefaultContactWhichHasNameGennadiy = Contacts.FirstOrDefault(f => f.Name == "Gennadiy");

            Console.WriteLine("First or default contact which has name Gennadiy:");
            Console.WriteLine($"{firstOrDefaultContactWhichHasNameGennadiy}{Environment.NewLine}");

            var contactsWherePhoneNumberStartWithCertainCode = Contacts.Where(w => w.PhoneNumber.StartsWith("068")).ToList();

            Console.WriteLine("Contacts where phone number start with 068 code:");

            foreach (var item in contactsWherePhoneNumberStartWithCertainCode)
            {
                Console.WriteLine(item);
            }

            var selectedPatronymicWhereAgeMoreThanCertainAgeAndLessThanCertainAge = Contacts.Where(w => w.Age > 15 && w.Age < 45).Select(s => s.Patronymic).ToList();

            Console.WriteLine($"{Environment.NewLine}Selected patronymic where contact age more than 15 and less than 45:");

            selectedPatronymicWhereAgeMoreThanCertainAgeAndLessThanCertainAge.ForEach(f => { Console.WriteLine(f); });

            var countContantsWhichHaveLetterВInSurname = Contacts.Count(c => c.SurName.ToUpper().Contains("В"));

            Console.WriteLine($"{Environment.NewLine}Count contacts which have letter В in surname = {countContantsWhichHaveLetterВInSurname}");

            var contactsSkipCertainContactsAndTakeCertainContactsAndOrderByNameDescending = Contacts.Skip(4).Take(5).OrderByDescending(o => o.Name).ToList();

            Console.WriteLine($"{Environment.NewLine}Skip 4 contacts and take 5 contacts:");

            foreach (var item in contactsSkipCertainContactsAndTakeCertainContactsAndOrderByNameDescending)
            {
                Console.WriteLine(item);
            }
        }
    }
}
