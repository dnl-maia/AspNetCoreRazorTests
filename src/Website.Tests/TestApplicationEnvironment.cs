using System;
using System.IO;
using System.Runtime.Versioning;
using Microsoft.Extensions.PlatformAbstractions;

namespace Website.Tests
{
    public class TestApplicationEnvironment : IApplicationEnvironment
    {
        public TestApplicationEnvironment()
        {
            string shopPath =
                Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\Website"));
            ApplicationBasePath = shopPath;
        }

        public object GetData(string name)
        {
            throw new NotImplementedException();
        }

        public void SetData(string name, object value)
        {
            throw new NotImplementedException();
        }

        public string ApplicationName => "Website.Tests";
        public string ApplicationVersion => "1.0";
        public string ApplicationBasePath { get; }

        public string Configuration => "Debug";

        public FrameworkName RuntimeFramework => new FrameworkName(".NETFramework", new Version("4.5.1"));
    }
}