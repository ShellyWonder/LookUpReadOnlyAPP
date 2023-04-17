using Bogus;

namespace BogusDataGenerator.Data
{
    public class DataGenerator
    {
        Faker<AERecordModel> AERecordModelFaker;

        public DataGenerator()
        {
            Randomizer.Seed = new Random(123);


            AERecordModelFaker = new Faker<AERecordModel>()
            .RuleFor(ae => ae.AEId, f => f.Random.AlphaNumeric(6))
            .RuleFor(ae => ae.EmployeeId, f => f.Random.Number(1000, 50000).ToString())
            .RuleFor(ae => ae.FirstName, f => f.Name.FirstName())
            .RuleFor(ae => ae.LastName, f => f.Name.LastName())
            .RuleFor(ae => ae.JobTitle, f => f.Name.JobTitle())
            .RuleFor(ae => ae.Email, f => f.Internet.Email())
            .RuleFor(ae => ae.Phone, f => f.Phone.PhoneNumber("###.###.####"))
            .RuleFor(ae => ae.CorporateAddress, f => f.Address.StreetAddress())
            .RuleFor(ae => ae.City, f => f.Address.City())
            .RuleFor(ae => ae.State, f => f.Address.StateAbbr())
            .RuleFor(ae => ae.ZipCode, f => f.Address.ZipCode())
            .RuleFor(ae => ae.EmploymentDate, f => DateTime.SpecifyKind(f.Date.Past().Date, DateTimeKind.Utc));
        }
        public AERecordModel GenerateAERecord()
        {
            return AERecordModelFaker.Generate();
        }

        public IEnumerable<AERecordModel> GenerateAERecords()
        {
            return AERecordModelFaker.GenerateForever();
        }
    }


}
