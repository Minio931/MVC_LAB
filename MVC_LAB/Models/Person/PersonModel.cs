namespace MVC_LAB.Models.Person
{
    public class PersonModel
    {
        public PersonModel()
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public GenderEnum Gender { get; set; }
        public string City { get; set; }

        public List<PersonModel> GetPeople(){
            return new List<PersonModel>(){
                new PersonModel()
                {
                 Id = 1,
                 Name = "John",
                 City = "Rzeszów",
                 Gender = GenderEnum.Male,
                 },
                new PersonModel()
                {
                    Id = 2,
                    Name = "Anna",
                    City = "Kraków",
                    Gender = GenderEnum.Female,
                },
                new PersonModel()
                {
                    Id = 3,
                    Name = "Krzysztof",
                    City = "Warszawa",
                    Gender = GenderEnum.Male,
                },
                new PersonModel()
                {
                    Id = 4,
                    Name = "Katarzyna",
                    City = "Wrocław",
                    Gender = GenderEnum.Female,
                }
                };
        }
    }
}
