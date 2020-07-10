using System;
using System.Collections.Generic;

namespace DockerComposeFixture
{
    public interface IDockerFixtureOptions
    {
        Func<string[], bool> CustomUpTest { get; set; }
        string[] DockerComposeFiles { get; set; }
        string DockerComposeUpArgs { get; set; }
        string DockerComposeDownArgs { get; set; }
        int StartupTimeoutSecs { get; set; }
        
        string LogFilePath { get; set; }
        
        IEnumerable<KeyValuePair<string, object>> EnvironmentVariables { get; set; }

        void Validate();

    }
}