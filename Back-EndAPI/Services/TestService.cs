using Back_EndAPI.Data;
using ClassLibrary.Models;

namespace Back_EndAPI.Services
{
    public class TestService
    {
        private readonly AppDbContext _db;

        public TestService(AppDbContext db)
        {
            _db = db;
        }

        // Service methods to interact with the Test entity can be added here
        public async Task<List<Test>> GetAllTestsAsync()
        {
            var tests = await _db.Tests.ToListAsync();
            return tests.Select(t => new TestDTO { Id = t.Id, Name = t.Name }).ToList();
        }
    }
}
