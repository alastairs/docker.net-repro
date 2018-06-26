using System;
using System.Threading.Tasks;
using Docker.DotNet;
using Docker.DotNet.Models;

namespace Repro
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new DockerClientConfiguration(new Uri("unix:///var/run/docker.sock")).CreateClient();
            await client.Images.ListImagesAsync(new ImagesListParameters
            {
                All = true
            });
        }
    }
}
