using Microsoft.VisualStudio.Coverage.Analysis;
using System.IO;

namespace CoverageToXml
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var solutionPath = args[0];
            var coverageFile = args[1];

            using (CoverageInfo info = CoverageInfo.CreateFromFile(
                    Path.Combine(Directory.GetCurrentDirectory(), coverageFile),
                    new string[]
                    {
                        $"{solutionPath}"
                    },
                    new string[] { }))
            {
                CoverageDS data = info.BuildDataSet();
                data.WriteXml("converted.coveragexml");
            }
        }
    }
}