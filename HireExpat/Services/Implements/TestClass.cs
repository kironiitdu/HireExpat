using HireExpat.Services.Interface;

namespace HireExpat.Services.Implements
{
    public class TestClass : ITestInterface
    {
        public IEnumerable<string> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
