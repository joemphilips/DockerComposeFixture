using DockerComposeFixture.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DockerComposeFixture.Compose
{
    public interface IDockerCompose
    {
        void Init(string dockerComposeArgs, string dockerComposeUpArgs, string dockerComposeDownArgs);
        void Down();
        IEnumerable<string> Ps();
        Task Up();

        /// <summary>
        /// Restart specific service. If it is null, restart every service.
        /// </summary>
        /// <param name="serviceName"></param>
        /// <returns></returns>
        Task Restart(string serviceName = null);
        int PauseMs { get; }
        ILogger[] Logger { get; }
    }
}