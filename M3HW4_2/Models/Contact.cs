namespace M3HW4_2.Models
{
    public class Contact
    {
        private readonly string _fullName;

        public Contact(string name, string surName, string patronymic, int age, string phoneNumber)
        {
            Name = name;
            SurName = surName;
            Patronymic = patronymic;
            Age = age;
            PhoneNumber = phoneNumber;
            _fullName = $"{SurName} {Name} {Patronymic}";
        }

        public string Name { get; }

        public string SurName { get; }

        public string Patronymic { get; }

        public int Age { get; }

        public string PhoneNumber { get; }

        public override string ToString()
        {
            return $"FIO: {_fullName} | Age: {Age} | Phone number: {string.Format("+38 ({0}) {1}-{2}-{3}", PhoneNumber[..3], PhoneNumber.Substring(3, 3), PhoneNumber.Substring(6, 2), PhoneNumber.Substring(8, 2))}";
        }
    }
}
