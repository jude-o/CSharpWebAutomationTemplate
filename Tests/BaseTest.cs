using NUnit.Framework;
using WebAutomation;

namespace $safeprojectname$
{
    public class BaseTest
    {
        [SetUp]
        public void Init()
        {
            Driver.Initialize();
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
